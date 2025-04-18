using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Forms;

namespace Presentacion
{
    public partial class FormCampos : LostForm
    {
        public FormCampos()
        {
            InitializeComponent();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            OcultarCampos();
            lblTitulo.Text = "Categoría";
            lblNombre.Visible = true;
            txtNombre.Visible = true;

            btnCategoria.BackColor = Color.LightGray;
            btnArticulo.BackColor = Color.FromArgb(33, 33, 33);
            btnMarca.BackColor = Color.FromArgb(33,33,33);
            btnAceptar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            OcultarCampos();
            lblNombre.Visible = true;
            txtNombre.Visible = true;
            lblTitulo.Text = "Marca";
            btnMarca.BackColor = Color.LightGray;
            btnArticulo.BackColor = Color.FromArgb(33, 33, 33);
            btnCategoria.BackColor = Color.FromArgb(33, 33, 33);
            btnAceptar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Artículo";
            btnArticulo.BackColor = Color.LightGray;
            btnMarca.BackColor = Color.FromArgb(33, 33, 33);
            btnCategoria.BackColor = Color.FromArgb(33, 33, 33);
            MostrarCampos();
        }
        private void OcultarCampos()
        {
            lblNombre.Visible = false;
            txtNombre.Visible = false;
            lblCodigo.Visible = false;
            txtCodigo.Visible = false;
            lblDescripcion.Visible = false;
            txtDescripcion.Visible = false;
            lblUrlImagen.Visible = false;
            txtUrlImagen.Visible = false;
            lblMarca.Visible = false;
            lblCategoria.Visible = false;
            cbxCategoria.Visible = false;
            cbxMarca.Visible = false;
            btnAceptar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void MostrarCampos()
        {
            lblNombre.Visible = true;
            txtNombre.Visible = true;
            lblCodigo.Visible = true;
            txtCodigo.Visible = true;
            lblDescripcion.Visible = true;
            txtDescripcion.Visible = true;
            lblUrlImagen.Visible = true;
            txtUrlImagen.Visible = true;
            lblMarca.Visible = true;
            lblCategoria.Visible = true;
            cbxCategoria.Visible = true;
            cbxMarca.Visible = true;
            btnAceptar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void FormCampos_Load(object sender, EventArgs e)
        {
            OcultarCampos();
        }
    }
}
