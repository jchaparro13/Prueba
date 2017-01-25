using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class PruebaContext : DbContext
    {
        public PruebaContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Prueba.Models.Department> Departments { get; set; }
    }
}