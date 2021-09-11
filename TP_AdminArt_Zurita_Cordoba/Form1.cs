using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_AdminArt_Zurita_Cordoba
{
    public partial class Form1Articulos : Form
    {
        List<Articulo> ListaArticulos;
        public Form1Articulos()
        {
            InitializeComponent();
        }

        private void Form1Articulos_Load(object sender, EventArgs e)
        {
            ArticuloEvent evento = new ArticuloEvent();
            ListaArticulos = evento.listar();
            dgvArticulos.DataSource = ListaArticulos;
           CargarImagen(ListaArticulos[0].Imagen);


        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo Seleccionado=(Articulo)dgvArticulos.CurrentRow.DataBoundItem;
           CargarImagen(Seleccionado.Imagen);
        }

        private void CargarImagen(string Imagen) 
        {
            try
            {
                pBoxArticulo.Load(Imagen);
                 
            }
            catch (Exception ex)
            {

                pBoxArticulo.Load("http://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif");
            }
        }
    }
}
