using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD.WebAPI.Data;
using CRUD.WebAPI.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CervezasController : ControllerBase
    {
        private readonly DataContext context;

        public CervezasController(DataContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public ActionResult<List<Cerveza>> Get() 
        {
            return context.Cervezas.ToList();
        }
        [HttpGet("{id}", Name = "ObtenerCervezaPorId")]
        public ActionResult<Cerveza> Get(int id)
        {
            var cerveza = context.Cervezas.FirstOrDefault(p => p.Id == id);
            if (cerveza == null)
            {
                return NotFound();
            }
            return cerveza;
        }
        [HttpPost]
        public ActionResult<Cerveza> Post([FromBody] Cerveza cerveza)
        {
            context.Cervezas.Add(cerveza);
            context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerCervezaPorId", new { id = cerveza.Id }, cerveza);
        }
        [HttpPut("{id}")]
        public ActionResult<Cerveza> Put(int id, [FromBody] Cerveza cerveza)
        {
            if (id != cerveza.Id)
            {
                return BadRequest();
            }
            context.Entry(cerveza).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult<Cerveza> Delete(int id)
        {
            var pais = context.Cervezas.FirstOrDefault(p => p.Id == id);
            if (pais == null)
            {
                return NotFound();
            }
            context.Cervezas.Remove(pais);
            context.SaveChanges();
            return Ok();
        }
    }
}