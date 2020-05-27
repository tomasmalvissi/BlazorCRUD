using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.WebAPI.Data.Entities
{
    public class Cerveza
    {
        [Key]
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public string Marca { get; set; }
    }
}
