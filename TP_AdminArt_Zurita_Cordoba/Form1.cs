using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using TPWinForm_Zurita_Cordoba;

namespace TP_AdminArt_Zurita_Cordoba
{
    public partial class Form1Articulos : Form
    {
        public Form1Articulos()
        {
            InitializeComponent();
        }

        List<Articulo> ListaArticulos;

        private void Form1Articulos_Load(object sender, EventArgs e)
        {
            Cargar();

        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo Seleccionado=(Articulo)dgvArticulos.CurrentRow.DataBoundItem;
           CargarImagen(Seleccionado.Imagen);
          
        }

        private void Cargar()
        {
            ArticuloNegocio evento = new ArticuloNegocio();
            try
            {
                ListaArticulos = evento.listar();

                dgvArticulos.DataSource = ListaArticulos;

                dgvArticulos.Columns["Imagen"].Visible = false;

                CargarImagen(ListaArticulos[0].Imagen);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void CargarImagen(string Imagen) 
        { 
            try
            {
                pBoxArticulo.Load(Imagen);
                 
            }
            catch
            {

                pBoxArticulo.Load("http://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif");
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo Alta = new frmAltaArticulo();
            Alta.ShowDialog();
         
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Articulo Seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAltaArticulo Alta = new frmAltaArticulo(Seleccionado);
            Alta.ShowDialog();
            Cargar();
        }
    }
}
