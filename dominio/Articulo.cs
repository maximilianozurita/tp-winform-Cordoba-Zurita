using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
   public class Articulo
    {
        public int ID { get; set; }

        [DisplayName("Código de artículo")]
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }//(seleccionable de una lista desplegable).
        [DisplayName("Categoría")]
        public Categoria Categoria { get; set; } // (seleccionable de una lista desplegable.
        public string Imagen { get; set; }//url
        public float Precio { get; set; }
       
    }

}
