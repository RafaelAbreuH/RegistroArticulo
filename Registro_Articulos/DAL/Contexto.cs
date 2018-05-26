using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Registro_Articulos.Entidades;

namespace Registro_Articulos.DAL
{
   public class Contexto : DbContext
    {
        public DbSet <Articulo> Articulos { get; set; }
        public Contexto() : base("Constr")
        {       }
    }
}
