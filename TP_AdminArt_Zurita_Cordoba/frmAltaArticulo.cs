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
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            ArticuloNegocio artNegocio = new ArticuloNegocio();

            try
            {
                art.Nombre = txtNombre.Text;
                art.CodigoArticulo = txtCodigo.Text;
                art.Descripción = txtDescripcion.Text;
                art.Marca = (Marca)cboMarcas.SelectedItem;
                art.Categoria = (Categoria)cboCategoria.SelectedItem;
                art.Precio = (float) decimal.Parse(txtPrecio.Text);

                artNegocio.Agregar(art);
                MessageBox.Show("Agregado exitosamente");
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
                cboCategoria.DataSource = CatNegocio.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
