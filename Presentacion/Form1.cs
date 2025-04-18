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
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class Form1 : LostForm
    {
        private List<Articulo> listaArticulos;
        public Form1()
        {
            InitializeComponent();
            Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbtnRapido.Checked = true;
            CargaCbx();
        }

        private void Listar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.Listar();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Precio"].Visible = false;
            dgvArticulos.Columns["Codigo"].Visible = false;

        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                lblPrecio.Text = "$" + articulo.Precio.ToString();
                lblDescripcion.Text = articulo.Descripcion;
                lblCodigo.Text = articulo.Codigo;
                pbxImagenUrl.Load(articulo.ImagenUrl);
            }
            catch (Exception)
            {

                pbxImagenUrl.Load("https://png.pngtree.com/png-clipart/20230917/original/pngtree-no-image-available-icon-flatvector-illustration-thumbnail-graphic-illustration-vector-png-image_12323920.png");

            }

        }

        #region Filtros

        // Selección Filtro
        private void SeleccionFiltro()
        {
            if (rbtnRapido.Checked)
            {
                txtFiltroRapido.Visible = true;

                txtFiltroAvanzado.Visible = false;
                cbxCampo.Visible = false;
                cbxCriterio.Visible = false;
                lblCampo.Visible = false;
                lblCriterio.Visible = false;
                lblFiltro.Visible = false;
                btnBuscarAvanzado.Visible = false;

            }
            else
            {
                txtFiltroRapido.Visible = false;

                txtFiltroAvanzado.Visible = true;
                cbxCampo.Visible = true;
                cbxCriterio.Visible = true;
                btnBuscarAvanzado.Visible = true;
                lblCampo.Visible = true;
                lblCriterio.Visible = true;
                lblFiltro.Visible = true;
            }
        }

        private void rbtnRapido_CheckedChanged(object sender, EventArgs e)
        {
            SeleccionFiltro();
        }

        // Filtro rápido
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvArticulos.DataSource = FiltroRapido();
        }

        private List<Articulo> FiltroRapido()
        {
            List<Articulo> listaFiltrada = listaArticulos.FindAll(x => x.Categoria.ToUpper().Contains(txtFiltroRapido.Text.ToUpper()) || x.Nombre.ToUpper().Contains(txtFiltroRapido.Text.ToUpper()) || x.Marca.ToUpper().Contains(txtFiltroRapido.Text.ToUpper()));


            return listaFiltrada;
        }

        // Filtro avanzado
        private void CargaCbx()
        {
            cbxCampo.Items.Add("Id");
            cbxCampo.Items.Add("Categoria");
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Marca");
            

        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCriterio.Items.Clear();
            if (cbxCampo.Text == "Id")
            {
                cbxCriterio.Items.Add("Igual a");
                cbxCriterio.Items.Add("Mayor a");
                cbxCriterio.Items.Add("Menor a");
            }
            else
            {
                cbxCriterio.Items.Add("Contenga");
                cbxCriterio.Items.Add("Comience con");
                cbxCriterio.Items.Add("Termine con");
            }
        }

        private void btnBuscarAvanzado_Click(object sender, EventArgs e)
        {
            int i;
            if (cbxCampo.Text == "Id" && !int.TryParse(txtFiltroAvanzado.Text, out i))
            {

                MessageBox.Show("Debe ingresar sólo números para buscar Id", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                dgvArticulos.DataSource = negocio.BusquedaAvanzada(cbxCampo.Text, cbxCriterio.Text, txtFiltroAvanzado.Text);
            }


        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            Listar();
            txtFiltroRapido.Text = "";
            cbxCampo.SelectedIndex = -1;
            cbxCriterio.SelectedIndex = -1;
            txtFiltroAvanzado.Text = "";
        }



        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormCampos formCampo = new FormCampos();
            formCampo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}
