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
            
        }
        
        private void Listar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.Listar();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Precio"].Visible = false;
            dgvArticulos.Columns["Codigo"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;

        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                
                Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                lblDescripcion.Text = articulo.Descripcion;
                pbxImagenUrl.Load(articulo.ImagenUrl);
            }
            catch (Exception)
            {

                pbxImagenUrl.Load("https://png.pngtree.com/png-clipart/20230917/original/pngtree-no-image-available-icon-flatvector-illustration-thumbnail-graphic-illustration-vector-png-image_12323920.png");

            }

        }
    }
}
