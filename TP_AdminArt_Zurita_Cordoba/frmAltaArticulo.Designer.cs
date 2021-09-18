
namespace TPWinForm_Zurita_Cordoba
{
    partial class frmAltaArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pBoxArticulo = new System.Windows.Forms.PictureBox();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.LabelCodigo = new System.Windows.Forms.Label();
            this.LabelDescripcion = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.LabelPrecio = new System.Windows.Forms.Label();
            this.LabelMarca = new System.Windows.Forms.Label();
            this.LabelCategoria = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.cboMarcas = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtBUrlImagen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxArticulo
            // 
            this.pBoxArticulo.Location = new System.Drawing.Point(43, 85);
            this.pBoxArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.pBoxArticulo.Name = "pBoxArticulo";
            this.pBoxArticulo.Size = new System.Drawing.Size(424, 262);
            this.pBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxArticulo.TabIndex = 0;
            this.pBoxArticulo.TabStop = false;
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(605, 65);
            this.LabelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(58, 17);
            this.LabelNombre.TabIndex = 1;
            this.LabelNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(609, 85);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(780, 85);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(161, 22);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(609, 212);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(332, 134);
            this.txtDescripcion.TabIndex = 4;
            // 
            // LabelCodigo
            // 
            this.LabelCodigo.AutoSize = true;
            this.LabelCodigo.Location = new System.Drawing.Point(835, 65);
            this.LabelCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCodigo.Name = "LabelCodigo";
            this.LabelCodigo.Size = new System.Drawing.Size(52, 17);
            this.LabelCodigo.TabIndex = 7;
            this.LabelCodigo.Text = "Codigo";
            // 
            // LabelDescripcion
            // 
            this.LabelDescripcion.AutoSize = true;
            this.LabelDescripcion.Location = new System.Drawing.Point(605, 191);
            this.LabelDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDescripcion.Name = "LabelDescripcion";
            this.LabelDescripcion.Size = new System.Drawing.Size(82, 17);
            this.LabelDescripcion.TabIndex = 8;
            this.LabelDescripcion.Text = "Descripcion";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(609, 375);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(332, 22);
            this.txtPrecio.TabIndex = 5;
            // 
            // LabelPrecio
            // 
            this.LabelPrecio.AutoSize = true;
            this.LabelPrecio.Location = new System.Drawing.Point(605, 356);
            this.LabelPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPrecio.Name = "LabelPrecio";
            this.LabelPrecio.Size = new System.Drawing.Size(48, 17);
            this.LabelPrecio.TabIndex = 10;
            this.LabelPrecio.Text = "Precio";
            // 
            // LabelMarca
            // 
            this.LabelMarca.AutoSize = true;
            this.LabelMarca.Location = new System.Drawing.Point(607, 409);
            this.LabelMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMarca.Name = "LabelMarca";
            this.LabelMarca.Size = new System.Drawing.Size(47, 17);
            this.LabelMarca.TabIndex = 12;
            this.LabelMarca.Text = "Marca";
            // 
            // LabelCategoria
            // 
            this.LabelCategoria.AutoSize = true;
            this.LabelCategoria.Location = new System.Drawing.Point(761, 409);
            this.LabelCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCategoria.Name = "LabelCategoria";
            this.LabelCategoria.Size = new System.Drawing.Size(69, 17);
            this.LabelCategoria.TabIndex = 13;
            this.LabelCategoria.Text = "Categoria";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(43, 428);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(100, 28);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(367, 428);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(100, 28);
            this.buttonAceptar.TabIndex = 9;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // cboMarcas
            // 
            this.cboMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcas.FormattingEnabled = true;
            this.cboMarcas.Location = new System.Drawing.Point(611, 428);
            this.cboMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.cboMarcas.Name = "cboMarcas";
            this.cboMarcas.Size = new System.Drawing.Size(160, 24);
            this.cboMarcas.TabIndex = 6;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(780, 428);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(160, 24);
            this.cboCategoria.TabIndex = 7;
            // 
            // txtBUrlImagen
            // 
            this.txtBUrlImagen.Location = new System.Drawing.Point(608, 147);
            this.txtBUrlImagen.Margin = new System.Windows.Forms.Padding(4);
            this.txtBUrlImagen.Name = "txtBUrlImagen";
            this.txtBUrlImagen.Size = new System.Drawing.Size(332, 22);
            this.txtBUrlImagen.TabIndex = 3;
            this.txtBUrlImagen.Leave += new System.EventHandler(this.txtBUrlImagen_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Url Imagen";
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBUrlImagen);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarcas);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.LabelCategoria);
            this.Controls.Add(this.LabelMarca);
            this.Controls.Add(this.LabelPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.LabelDescripcion);
            this.Controls.Add(this.LabelCodigo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.LabelNombre);
            this.Controls.Add(this.pBoxArticulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAltaArticulo";
            this.Text = "Agregar articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxArticulo;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label LabelCodigo;
        private System.Windows.Forms.Label LabelDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label LabelPrecio;
        private System.Windows.Forms.Label LabelMarca;
        private System.Windows.Forms.Label LabelCategoria;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.ComboBox cboMarcas;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txtBUrlImagen;
        private System.Windows.Forms.Label label1;
    }
}