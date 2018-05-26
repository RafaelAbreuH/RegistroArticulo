using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Registro_Articulos.Entidades
{
    public class Articulo
    {
        [Key]
        public int ArticuloId { get; set; }
        public String Descripcion { get; set; }
        public float Precio { get; set; }
        public int Existencia { get; set; }
        public int CantidadCotizada { get; set; }
    }
}
