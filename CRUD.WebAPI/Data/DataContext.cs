using CRUD.WebAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> dbcon) : base(dbcon)
        {
        }
        public DbSet<Cerveza> Cervezas { get; set; }
    }
}
