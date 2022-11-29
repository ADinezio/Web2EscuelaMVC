using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Web2EscuelaMVC.Models;

namespace Web2EscuelaMVC.Data
{
    public class EscuelaDBContext:DbContext
    {
        public EscuelaDBContext():base("KeyDBEscuela") { }

        public DbSet<Aula> Aulas { get; set; }
    }
}