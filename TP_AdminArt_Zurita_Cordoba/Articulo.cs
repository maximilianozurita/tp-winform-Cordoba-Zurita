using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_AdminArt_Zurita_Cordoba
{
    class Articulo
    {
        public int CódigoArtículo { get; set; }
        public string Nombre { get; set; }
        public string Descripción { get; set; }
       // public Marca Marca { get; set; }//(seleccionable de una lista desplegable).
        // public Categoria Categoría { get; set; } // (seleccionable de una lista desplegable.
        public string Imagen { get; set; }
        public float  Precio { get; set; }
       
    }
}
