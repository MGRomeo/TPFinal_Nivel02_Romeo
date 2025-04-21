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
using System.IO;

namespace Presentacion
{
    public partial class FormCampos : LostForm
    {
        Articulo articulo = null;
        ArticuloNegocio negocio = new ArticuloNegocio();
        private string bandera;
        private int IdMarca;
        private int IdCategoria;
        private string nombreMC;




        public FormCampos()
        {
            InitializeComponent();
            CargaComboBox();
            CentrarTitulo();
        }

        //Constructor para modificar y borrar Marcas y Categorías
        public FormCampos(string nombre, string bandera, string accion)
        {
            InitializeComponent();
            this.bandera = bandera;
            nombreMC = nombre;
            Text = accion;
            lbltextoNuevo.Text = "";
            CargaComboBox();
            CentrarTitulo();
            if (Text == "Modificar")
            {
                CargarMarcaCategoria();
            }
            else
            {
                CargarMarcaCategoria();
                BorrarMarcaCategoria();
            }
            
        }

        // Constructor para Modificar y borrar artículos
        public FormCampos(Articulo articulo, string text)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = text;
            lbltextoNuevo.Text = "";
            CentrarTitulo();
            MostrarCampos();
            CargaComboBox();
            if (Text == "Modificar")
            {
                CargaArticulo();
            }
            else
            {
                CargaArticulo();
                MostrarArticuloBorrar();
            }
        }


        private void FormCampos_Load(object sender, EventArgs e)
        {
            if (Text == "Agregar")
            {
                OcultarCampos();
            }

        }

        private void CentrarTitulo()
        {
            //Centra el titulo del paner de carga
            lblTitulo.Left = (pnlCampos.Width - lblTitulo.Width) / 2;
            lbltextoNuevo.Left = (pnlBotones.Width - lbltextoNuevo.Width) / 2;
        }

        private void CargaComboBox()
        {
            Dictionary<int, string> marcas = negocio.ListaMarca();
            Dictionary<int, string> categorias = negocio.ListaCategoria();
            // Para diferenciar el modificar Marca de Categoria
            if (bandera == "Marcas")
            {
                //Nombre actual
                cbxNombreActual.DataSource = new BindingSource(marcas, null);
                cbxNombreActual.DisplayMember = "value";
                cbxNombreActual.ValueMember = "key";

            }
            else if (bandera == "Categorías")
            {
                //Nombre actual
                cbxNombreActual.DataSource = new BindingSource(categorias, null);
                cbxNombreActual.DisplayMember = "value";
                cbxNombreActual.ValueMember = "key";
            }
            else
            {

                cbxMarca.DataSource = new BindingSource(marcas, null);
                cbxMarca.DisplayMember = "value";
                cbxMarca.ValueMember = "key";

                cbxCategoria.DisplayMember = "value";
                cbxCategoria.ValueMember = "key";
                cbxCategoria.DataSource = new BindingSource(categorias, null);
            }

        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Artículo";
            CentrarTitulo();
            btnArticulo.BackColor = Color.LightGray;
            btnMarca.BackColor = Color.FromArgb(33, 33, 33);
            btnCategoria.BackColor = Color.FromArgb(33, 33, 33);
            OcultarCampos();
            MostrarCampos();

            bandera = null;

        }

        private void btnMarca_Click(object sender, EventArgs e)
        {

            OcultarCampos();
            lblNombre.Visible = true;
            txtNombre.Visible = true;
            lblTitulo.Text = "Marca";
            CentrarTitulo();
            btnMarca.BackColor = Color.LightGray;
            btnArticulo.BackColor = Color.FromArgb(33, 33, 33);
            btnCategoria.BackColor = Color.FromArgb(33, 33, 33);
            btnAceptar.Visible = true;
            btnCancelar.Visible = true;

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            OcultarCampos();
            lblTitulo.Text = "Categoría";
            CentrarTitulo();
            lblNombre.Visible = true;
            txtNombre.Visible = true;
            btnCategoria.BackColor = Color.LightGray;
            btnArticulo.BackColor = Color.FromArgb(33, 33, 33);
            btnMarca.BackColor = Color.FromArgb(33, 33, 33);
            btnAceptar.Visible = true;
            btnCancelar.Visible = true;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (true )
                {

                    switch (Text)
                    {
                        case "Modificar":
                            if (txtCodigo.Text == "")
                            {
                                MessageBox.Show("Ingresa un 'Nombre nuevo' primero", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                            DialogResult modificar = MessageBox.Show("¿Estás seguro que quieres Modificar este elemento?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (modificar == DialogResult.Cancel)
                            {
                                break;
                            }
                            if (bandera == "Marcas")
                            {
                                int IdActual = negocio.ListaMarca().FirstOrDefault(x => x.Value == cbxNombreActual.Text).Key;
                                negocio.ModificarMarcaCategoria(IdActual, txtCodigo.Text, bandera);
                                MessageBox.Show("Marca modificada exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (bandera == "Categorías")
                            {
                                bandera = "Categorias";
                                int IdActual = negocio.ListaCategoria().FirstOrDefault(x => x.Value == cbxNombreActual.Text).Key;
                                negocio.ModificarMarcaCategoria(IdActual, txtCodigo.Text, bandera);
                                MessageBox.Show("Categoría modificada exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {

                                SobrescribirArticulo();
                                negocio.ModificarArticulo(articulo, IdMarca, IdCategoria);
                                MessageBox.Show("Artícuo modificado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            Close();
                            break;

                        case "Borrar":
                            DialogResult eliminar = MessageBox.Show("¿Estás seguro que quieres Eliminar este elemento?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if (eliminar == DialogResult.Cancel)
                            {
                                break;
                            }
                            int Id = -1;
                            if (bandera == "Marcas")
                            {
                                Id = negocio.ListaMarca().FirstOrDefault(x => x.Value == cbxNombreActual.Text).Key;
                            }
                            else if (bandera == "Categorías")
                            {
                                Id = negocio.ListaCategoria().FirstOrDefault(x => x.Value == cbxNombreActual.Text).Key;
                                bandera = "Categorias";
                            }
                            else
                            {
                                Id = articulo.Id;
                                bandera = "Articulos";
                            }
                            Borrar(Id, bandera);
                            Close();
                            break;

                        default:
                            if (lblTitulo.Text == "Artículo")
                            {
                                if (!validarTextBoxs())
                                {
                                    break;
                                }
                            }
                            if (lblTitulo.Text != "Artículos" && txtNombre.Text == "")
                            {
                                MessageBox.Show($"El campo 'Nombre' está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtNombre.Focus();
                                break;
                            }
                            Agregar();
                            Close();
                            break;
                    }
                    CargaComboBox();

                }
                else
                {
                    MessageBox.Show("Selecciona un elemento primero","Atención",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OcultarCampos()
        {
            lblNombre.Visible = false;
            txtNombre.Visible = false;
            lblCodigo.Visible = false;
            txtCodigo.Visible = false;
            cbxNombreActual.Visible = false;
            lblDescripcion.Visible = false;
            txtDescripcion.Visible = false;
            lblUrlImagen.Visible = false;
            txtUrlImagen.Visible = false;
            lblMarca.Visible = false;
            lblCategoria.Visible = false;
            cbxCategoria.Visible = false;
            cbxMarca.Visible = false;
            btnAceptar.Visible = false;
            lblPrecio.Visible = false;
            txtPrecio.Visible = false;
            btnAgregarImagen.Visible = false;
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
            lblPrecio.Visible = true;
            txtPrecio.Visible = true;
            btnAgregarImagen.Visible = true;
        }

        private void Agregar()
        {
            lblNombre.Text = "Nombre";
            lblCodigo.Text = "Código";
            try
            {
                if (articulo == null)
                {

                    if (txtCodigo.Text == "")
                    {
                        string nombre = "";
                        switch (bandera)
                        {
                            case "Marcas":
                                nombre = txtNombre.Text;
                                negocio.AgregarMarcaCategoria("Marcas", nombre);
                                MessageBox.Show("Marca agregada exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;

                            case "Categorías":
                                nombre = txtNombre.Text;
                                negocio.AgregarMarcaCategoria("Categorias", nombre);
                                MessageBox.Show("Categoría agregada exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else
                    {
                        articulo = new Articulo();
                        articulo.Nombre = txtNombre.Text;
                        articulo.Codigo = txtCodigo.Text;
                        articulo.Descripcion = txtDescripcion.Text;
                        articulo.ImagenUrl = txtUrlImagen.Text;
                        articulo.Marca = cbxMarca.Text;
                        articulo.Categoria = cbxCategoria.Text;
                        articulo.Precio = decimal.Parse(txtPrecio.Text);
                        int idMarca = (int)cbxMarca.SelectedValue;
                        int idCategoria = (int)cbxCategoria.SelectedValue;
                        // metodo para cargar objeto a db
                        negocio.AgregarArticulo(articulo, idMarca, idCategoria);
                        MessageBox.Show("Artícuo agregado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Carga en los campos el objeto Articulo seleccionado en la gilla
        private void CargaArticulo()
        {
            try
            {
                lblTitulo.Text = "Artículo";
                CentrarTitulo();
                cbxNombreActual.Visible = false;
                btnMarca.Visible = false;
                btnCategoria.Visible = false;
                txtNombre.Text = articulo.Nombre;
                txtCodigo.Text = articulo.Codigo;
                txtDescripcion.Text = articulo.Descripcion;
                txtUrlImagen.Text = articulo.ImagenUrl;
                // busco el id (Key) de la marca (value)
                IdMarca = negocio.ListaMarca().FirstOrDefault(x => x.Value == articulo.Marca).Key;
                // se puede seleccionar así
                cbxMarca.SelectedValue = IdMarca;
                IdCategoria = negocio.ListaCategoria().FirstOrDefault(x => x.Value == articulo.Categoria).Key;
                // O se puede cargar así
                cbxCategoria.Text = articulo.Categoria;
                txtPrecio.Text = articulo.Precio.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        //Guarda lo modificado en el objeto articulo para ser actualizado
        private void SobrescribirArticulo()
        {
            try
            {
                articulo.Nombre = txtNombre.Text;
                articulo.Codigo = txtCodigo.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.ImagenUrl = txtUrlImagen.Text;
                articulo.Marca = cbxMarca.Text;
                articulo.Categoria = cbxCategoria.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                IdMarca = (int)cbxMarca.SelectedValue;
                IdCategoria = (int)cbxCategoria.SelectedValue;
            }
            catch (Exception)
            {

                throw;
            }



        }

        private void CargarMarcaCategoria()
        {
            OcultarCampos();

            lblTitulo.Text = bandera;
            if (bandera == "Marcas")
            {
                btnCategoria.Visible = false;
            }
            else
            {
                btnMarca.Visible = false;
            }
            CentrarTitulo();
            ModificarMarcaCategoria();
            lblNombre.Visible = true;
            txtNombre.Visible = true;
            btnAceptar.Visible = true;
            btnCancelar.Visible = true;
            btnArticulo.Visible = false;

        }

        private void ModificarMarcaCategoria()
        {
            try
            {
                CargaComboBox();
                if (bandera == "Marcas")
                {
                    IdMarca = negocio.ListaMarca().FirstOrDefault(x => x.Value == nombreMC).Key;
                    cbxNombreActual.SelectedValue = IdMarca;
                }
                else if (bandera == "Categorías")
                {
                    IdCategoria = negocio.ListaCategoria().FirstOrDefault(x => x.Value == nombreMC).Key;
                    cbxNombreActual.SelectedValue = IdCategoria;
                }
                lblNombre.Text = "Actual";
                lblCodigo.Text = "Nueva";
                txtNombre.Visible = false;
                cbxNombreActual.Visible = true;
                lblCodigo.Visible = true;
                txtCodigo.Visible = true;
                txtCodigo.Text = "";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            CargarImagen();
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            BuscarImagen();
            CargarImagen();
        }

        private void BuscarImagen()
        {
            OpenFileDialog archivo = new OpenFileDialog();

            archivo.Filter = "Todos los archivos|*.*|Png|*.png|Jpg|*.jpg|txt|*.txt";
            archivo.InitialDirectory = ObtenerOCrearCarpeta();

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
            }
        }

        private void CargarImagen()
        {
            try
            {
                pbxUrlImagen.Load(txtUrlImagen.Text);
            }
            catch (Exception)
            {
                pbxUrlImagen.Load("https://png.pngtree.com/png-clipart/20230917/original/pngtree-no-image-available-icon-flatvector-illustration-thumbnail-graphic-illustration-vector-png-image_12323920.png");

            }
        }

        //Obtener ruta de carpeta Archivos
        private string ObtenerOCrearCarpeta()
        {
            try
            {
                string rutaArchivo = Properties.Settings.Default.RutaArchivo;

                FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

                string DirEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string carpetaDestino = Path.Combine(DirEscritorio, "ArchivosApp");

                if (string.IsNullOrEmpty(rutaArchivo) || !Directory.Exists(rutaArchivo))
                {
                    DialogResult respuesta = MessageBox.Show("¿Deseas crear una carpeta llamada 'ArchivosApp' en el Escritorio? En esta se guardarán las imagenes y registros", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (respuesta == DialogResult.OK)
                    {
                        Directory.CreateDirectory(carpetaDestino);
                        rutaArchivo = carpetaDestino;
                    }
                    else
                    {
                        folderBrowser.Description = "Elige donde guardar tus archivos";
                        if (folderBrowser.ShowDialog() == DialogResult.OK)
                        {
                            rutaArchivo = folderBrowser.SelectedPath;

                        }
                    }
                    Properties.Settings.Default.RutaArchivo = rutaArchivo;
                    Properties.Settings.Default.Save();
                }

                return rutaArchivo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Borrar(int id, string tabla)
        {
            negocio.Borrar(id,tabla);
        }

        //Deshabilita los campos, solo se pueden ver
        private void MostrarArticuloBorrar()
        {
            txtNombre.Enabled = false;
            txtCodigo.Enabled = false;
            txtDescripcion.Enabled = false;
            txtUrlImagen.Enabled = false;
            CargarImagen();
            cbxMarca.Enabled = false;
            cbxCategoria.Enabled = false;
            txtPrecio.Enabled = false;
            btnAgregarImagen.Visible = false;
        }

        private void BorrarMarcaCategoria()
        {
            try
            {
                CargaComboBox();
                if (bandera == "Marcas")
                {
                    IdMarca = negocio.ListaMarca().FirstOrDefault(x => x.Value == nombreMC).Key;
                    cbxNombreActual.SelectedValue = IdMarca;
                }
                else if (bandera == "Categorías")
                {
                    IdCategoria = negocio.ListaCategoria().FirstOrDefault(x => x.Value == nombreMC).Key;
                    cbxNombreActual.SelectedValue = IdCategoria;
                }

                lblNombre.Text = "Nombre";
                lblNombre.Visible = true;
                txtNombre.Visible = false;
                lblCodigo.Visible = false;
                lblCodigo.Visible = false;
                txtCodigo.Visible = false;
                cbxNombreActual.Visible = true;
                cbxNombreActual.Enabled = false;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        bool validarTextBoxs()
        {
            foreach (Control item in pnlCampos.Controls.Cast<Control>().OrderBy(c => c.Top))
            {
                try
                {
                    if (item is TextBox || item is ComboBox)
                    {
                        if (item is TextBox)
                        {
                            if (item.Name == "txtPrecio")
                            {
                                if (!decimal.TryParse(item.Text, out decimal precio))
                                {
                                    MessageBox.Show("El precio debe ser un número", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    item.Focus();
                                    return false;
                                }
                            }
                            //Codigo comprobacion  de textbox
                            if (item.Text == "")
                            {
                                MessageBox.Show($"El campo '{MostrarNombre(item.Name)}' está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                item.Focus();
                                return false;
                            }
                        }
                        else if (item is ComboBox && item != cbxNombreActual)
                        {
                            if (item.Text == "")
                            {
                                MessageBox.Show($"Debes seleccionar un item de '{MostrarNombre(item.Name)}'", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                item.Focus();
                                return false;
                            }
                        }
                    }
                    
                }
                catch { }
            }
            return true;
        }

        private string MostrarNombre(string nombre)
        {
            switch (nombre)
            {
                case "txtNombre": return "Nombre";
                case "txtCodigo": return "Código";
                case "txtDescripcion": return "Descripción";
                case "txtImagenUrl": return "URL de imagen";
                case "cbxMarca": return "Marca";
                case "cbxCategoria": return "Categoría";
                case "txtPrecio": return "Precio";
                default: return nombre;
            }
        }

    }
}
