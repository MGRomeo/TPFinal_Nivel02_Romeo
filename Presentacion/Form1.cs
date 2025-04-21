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

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbtnRapido.Checked = true;
            CentrarTitulo();
            ListarArticulos();
            CargaCbx();
        }

        private void CentrarTitulo()
        {
            //Centra el titulo del paner de carga
            lblTitulo.Left = (pnldgv.Width - lblTitulo.Width) / 2;
        }

        private void ListarArticulos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.ListarArticulos();
            dgvListado.DataSource = listaArticulos;
            dgvListado.Columns["Descripcion"].Visible = false;
            dgvListado.Columns["ImagenUrl"].Visible = false;
            dgvListado.Columns["Precio"].Visible = false;
            dgvListado.Columns["Codigo"].Visible = false;
            lblTitulo.Text = "Artículos";
            rbtnAvanzado.Visible = true;
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (lblTitulo.Text == "Artículos")
                {
                    Articulo articulo = (Articulo)dgvListado.CurrentRow.DataBoundItem;
                    lblPrecio.Text = "$" + articulo.Precio.ToString();
                    lblDescripcion.Text = articulo.Descripcion;
                    lblCodigo.Text = articulo.Codigo;
                    pbxImagenUrl.Load(articulo.ImagenUrl);
                }
                else
                {
                    lblPrecio.Text = "";
                    lblDescripcion.Text = "";
                    lblCodigo.Text = "";
                    pbxImagenUrl.Load("");
                }

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
                if (lblTitulo.Text != "Artículos")
                {
                    rbtnAvanzado.Visible = false;
                }

            }
            else
            {
                if (lblTitulo.Text != "Artículos")
                {
                    rbtnRapido.Checked = true;
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
        }

        private void rbtnRapido_CheckedChanged(object sender, EventArgs e)
        {
            SeleccionFiltro();
        }

        // Filtro rápido
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(lblTitulo.Text == "Artículos")
            {
                dgvListado.DataSource = FiltroRapido();
            }
            else { FiltroRapidoMarcaCategoria(); }

        }

        private List<Articulo> FiltroRapido()
        {

            List<Articulo> listaFiltrada = listaArticulos.FindAll(x => x.Categoria.ToUpper().Contains(txtFiltroRapido.Text.ToUpper()) || x.Nombre.ToUpper().Contains(txtFiltroRapido.Text.ToUpper()) || x.Marca.ToUpper().Contains(txtFiltroRapido.Text.ToUpper()));
            return listaFiltrada;
        }

        private void FiltroRapidoMarcaCategoria()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            switch (lblTitulo.Text)
            {
                case "Marcas":
                    var listaMarca = negocio.ListaMarca().Where(m => m.Key != 0).Select(p => new { Id = p.Key, Nombre = p.Value }).ToList();
                    var marcaFiltrada = listaMarca.FindAll(x => x.Nombre.ToUpper().Contains(txtFiltroRapido.Text.ToUpper()));
                    dgvListado.DataSource = marcaFiltrada;
                    break;

                default:
                    var listaCategoria = negocio.ListaCategoria().Where(m => m.Key != 0).Select(p => new { Id = p.Key, Nombre = p.Value }).ToList();
                    var categoriaFiltrada = listaCategoria.FindAll(x => x.Nombre.ToUpper().Contains(txtFiltroRapido.Text.ToUpper()));
                    dgvListado.DataSource = categoriaFiltrada;
                    break;
            }
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
                dgvListado.DataSource = negocio.BusquedaAvanzada(cbxCampo.Text, cbxCriterio.Text, txtFiltroAvanzado.Text);
            }


        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            ListarArticulos();
            txtFiltroRapido.Text = "";
            cbxCampo.SelectedIndex = -1;
            cbxCriterio.SelectedIndex = -1;
            txtFiltroAvanzado.Text = "";
        }



        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //metodo de busqueda id
            FormCampos formCampo = new FormCampos();
            formCampo.ShowDialog();
            ListarArticulos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lblTitulo.Text == "Artículos")
            {
                Articulo articulo = (Articulo)dgvListado.CurrentRow.DataBoundItem;
                FormCampos formCampo = new FormCampos(articulo, "Modificar");
                formCampo.ShowDialog();
            }
            else
            {
                Dictionary<int, string> diccionario = new Dictionary<int, string>();
                string marca = dgvListado.CurrentRow.Cells["Nombre"].Value.ToString();
                FormCampos formCampo = new FormCampos(marca, lblTitulo.Text, "Modificar");
                formCampo.ShowDialog();
            }
            ListarArticulos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lblTitulo.Text == "Artículos")
            {
                Articulo articulo = (Articulo)dgvListado.CurrentRow.DataBoundItem;
                FormCampos formCampo = new FormCampos(articulo, "Borrar");
                formCampo.ShowDialog();
            }
            else
            {
                Dictionary<int, string> diccionario = new Dictionary<int, string>();
                string marca = dgvListado.CurrentRow.Cells["Nombre"].Value.ToString();
                FormCampos formCampo = new FormCampos(marca, lblTitulo.Text ,"Borrar");
                formCampo.ShowDialog();
            }



            ListarArticulos();
        }

        private void btnListarArticulos_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Artículos";
            txtFiltroRapido.Text = "";
            dgvListado.DataSource = null;
            rbtnAvanzado.Visible = true;
            ListarArticulos();
        }

        private void btnListarMarcas_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Marcas";
            txtFiltroRapido.Text = "";
            SeleccionFiltro();
            dgvListado.DataSource = null;
            ArticuloNegocio negocio = new ArticuloNegocio();
            var lista = negocio.ListaMarca().Where(m => m.Key != 0).Select(p => new { Id = p.Key, Nombre = p.Value }).ToList();
            dgvListado.DataSource = lista;

        }

        private void btnListarCategorias_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Categorías";
            txtFiltroRapido.Text = "";
            SeleccionFiltro();
            dgvListado.DataSource = null;
            ArticuloNegocio negocio = new ArticuloNegocio();
            var lista = negocio.ListaCategoria().Where(m => m.Key != 0).Select(p => new { Id = p.Key, Nombre = p.Value }).ToList();
            dgvListado.DataSource = lista;
        }

    }
}
