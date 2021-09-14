using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
   public class Articulo
    {
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripción { get; set; }
        public Marca Marca { get; set; }//(seleccionable de una lista desplegable).
        public Categoria Categoria { get; set; } // (seleccionable de una lista desplegable.
        public string Imagen { get; set; }
        public float  Precio { get; set; }
       
    }

}
