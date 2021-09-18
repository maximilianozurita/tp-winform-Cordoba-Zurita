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

namespace TPWinForm_Zurita_Cordoba
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo art = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo art)
        {
            InitializeComponent();
            this.art = art;
            Text = "Modificar artículo";
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();

            try
            {
                if (art == null)
                {
                    Articulo art = new Articulo();
                }
                art.Nombre = txtNombre.Text;
                art.CodigoArticulo = txtCodigo.Text;
                art.Descripcion = txtDescripcion.Text;
                art.Imagen = txtBUrlImagen.Text;
                art.Marca = (Marca)cboMarcas.SelectedItem;
                art.Categoria = (Categoria)cboCategoria.SelectedItem;
                art.Precio = (float) decimal.Parse(txtPrecio.Text);
                
                
                if (art.ID != 0)
                {
                    artNegocio.Modificar(art);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    artNegocio.Agregar(art);
                    MessageBox.Show("Agregado exitosamente");
                }
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio CatNegocio = new CategoriaNegocio();
            MarcasNegocio MarcaNegocio = new MarcasNegocio();
             
            try
            {
                cboMarcas.DataSource = MarcaNegocio.Listar();
                cboMarcas.ValueMember = "ID";
                cboMarcas.DisplayMember = "Descripcion";

                cboCategoria.DataSource = CatNegocio.Listar();
                cboCategoria.ValueMember = "ID";
                cboCategoria.DisplayMember = "Descripcion";

                if (art != null)
                {
                    txtDescripcion.Text = art.Descripcion;
                    txtNombre.Text= art.Nombre;
                    txtDescripcion.Text = art.Descripcion;
                    txtBUrlImagen.Text = art.Imagen;
                    CargarImagen(art.Imagen);
                    txtPrecio.Text = art.Precio.ToString();
                    cboMarcas.SelectedValue = art.Marca.ID;
                    cboCategoria.SelectedValue = art.Categoria.ID;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBUrlImagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtBUrlImagen.Text);
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
    }
}
