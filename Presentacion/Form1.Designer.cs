
namespace Presentacion
{
    partial class Form1
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
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.pnlDerecho = new System.Windows.Forms.Panel();
            this.pnlCodigo = new System.Windows.Forms.Panel();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTextoPrecio = new System.Windows.Forms.Label();
            this.lblTextoCodigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTextoDescripcion = new System.Windows.Forms.Label();
            this.pbxImagenUrl = new System.Windows.Forms.PictureBox();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnBuscarAvanzado = new FontAwesome.Sharp.IconButton();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.rbtnAvanzado = new System.Windows.Forms.RadioButton();
            this.rbtnRapido = new System.Windows.Forms.RadioButton();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.txtFiltroRapido = new System.Windows.Forms.TextBox();
            this.pnldgv = new System.Windows.Forms.Panel();
            this.btnLimpiarFiltro = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.gbxAcciones = new System.Windows.Forms.GroupBox();
            this.gbxListado = new System.Windows.Forms.GroupBox();
            this.btnListarArticulos = new FontAwesome.Sharp.IconButton();
            this.btnListarCategorias = new FontAwesome.Sharp.IconButton();
            this.btnListarMarcas = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.pnlDerecho.SuspendLayout();
            this.pnlCodigo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenUrl)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            this.pnldgv.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbxAcciones.SuspendLayout();
            this.gbxListado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(19, 34);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(436, 377);
            this.dgvListado.TabIndex = 1;
            this.dgvListado.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pnlDerecho
            // 
            this.pnlDerecho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDerecho.Controls.Add(this.pnlCodigo);
            this.pnlDerecho.Controls.Add(this.label2);
            this.pnlDerecho.Controls.Add(this.panel1);
            this.pnlDerecho.Controls.Add(this.pbxImagenUrl);
            this.pnlDerecho.Location = new System.Drawing.Point(649, 147);
            this.pnlDerecho.Name = "pnlDerecho";
            this.pnlDerecho.Size = new System.Drawing.Size(346, 468);
            this.pnlDerecho.TabIndex = 2;
            // 
            // pnlCodigo
            // 
            this.pnlCodigo.BackColor = System.Drawing.Color.Silver;
            this.pnlCodigo.Controls.Add(this.lblPrecio);
            this.pnlCodigo.Controls.Add(this.lblCodigo);
            this.pnlCodigo.Controls.Add(this.lblTextoPrecio);
            this.pnlCodigo.Controls.Add(this.lblTextoCodigo);
            this.pnlCodigo.Location = new System.Drawing.Point(13, 412);
            this.pnlCodigo.Name = "pnlCodigo";
            this.pnlCodigo.Size = new System.Drawing.Size(319, 51);
            this.pnlCodigo.TabIndex = 3;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrecio.Location = new System.Drawing.Point(154, 21);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 21);
            this.lblPrecio.TabIndex = 4;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCodigo.Location = new System.Drawing.Point(3, 21);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 21);
            this.lblCodigo.TabIndex = 2;
            // 
            // lblTextoPrecio
            // 
            this.lblTextoPrecio.AutoSize = true;
            this.lblTextoPrecio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTextoPrecio.Location = new System.Drawing.Point(154, 0);
            this.lblTextoPrecio.Name = "lblTextoPrecio";
            this.lblTextoPrecio.Size = new System.Drawing.Size(60, 21);
            this.lblTextoPrecio.TabIndex = 3;
            this.lblTextoPrecio.Text = "Precio :";
            // 
            // lblTextoCodigo
            // 
            this.lblTextoCodigo.AutoSize = true;
            this.lblTextoCodigo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTextoCodigo.Location = new System.Drawing.Point(3, 0);
            this.lblTextoCodigo.Name = "lblTextoCodigo";
            this.lblTextoCodigo.Size = new System.Drawing.Size(67, 21);
            this.lblTextoCodigo.TabIndex = 1;
            this.lblTextoCodigo.Text = "Código :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(100, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Información";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblTextoDescripcion);
            this.panel1.Location = new System.Drawing.Point(13, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 51);
            this.panel1.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 21);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(0, 21);
            this.lblDescripcion.TabIndex = 2;
            // 
            // lblTextoDescripcion
            // 
            this.lblTextoDescripcion.AutoSize = true;
            this.lblTextoDescripcion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTextoDescripcion.Location = new System.Drawing.Point(3, 0);
            this.lblTextoDescripcion.Name = "lblTextoDescripcion";
            this.lblTextoDescripcion.Size = new System.Drawing.Size(102, 21);
            this.lblTextoDescripcion.TabIndex = 1;
            this.lblTextoDescripcion.Text = "Descripción : ";
            // 
            // pbxImagenUrl
            // 
            this.pbxImagenUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImagenUrl.Location = new System.Drawing.Point(12, 34);
            this.pbxImagenUrl.Name = "pbxImagenUrl";
            this.pbxImagenUrl.Size = new System.Drawing.Size(320, 320);
            this.pbxImagenUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenUrl.TabIndex = 0;
            this.pbxImagenUrl.TabStop = false;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSuperior.Controls.Add(this.btnBuscarAvanzado);
            this.pnlSuperior.Controls.Add(this.lblFiltro);
            this.pnlSuperior.Controls.Add(this.lblCriterio);
            this.pnlSuperior.Controls.Add(this.lblCampo);
            this.pnlSuperior.Controls.Add(this.txtFiltroAvanzado);
            this.pnlSuperior.Controls.Add(this.rbtnAvanzado);
            this.pnlSuperior.Controls.Add(this.rbtnRapido);
            this.pnlSuperior.Controls.Add(this.cbxCriterio);
            this.pnlSuperior.Controls.Add(this.cbxCampo);
            this.pnlSuperior.Controls.Add(this.txtFiltroRapido);
            this.pnlSuperior.Location = new System.Drawing.Point(13, 38);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(982, 103);
            this.pnlSuperior.TabIndex = 3;
            // 
            // btnBuscarAvanzado
            // 
            this.btnBuscarAvanzado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnBuscarAvanzado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAvanzado.ForeColor = System.Drawing.Color.White;
            this.btnBuscarAvanzado.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarAvanzado.IconColor = System.Drawing.Color.White;
            this.btnBuscarAvanzado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarAvanzado.IconSize = 20;
            this.btnBuscarAvanzado.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBuscarAvanzado.Location = new System.Drawing.Point(879, 54);
            this.btnBuscarAvanzado.Name = "btnBuscarAvanzado";
            this.btnBuscarAvanzado.Size = new System.Drawing.Size(91, 30);
            this.btnBuscarAvanzado.TabIndex = 6;
            this.btnBuscarAvanzado.Text = "Buscar";
            this.btnBuscarAvanzado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarAvanzado.UseVisualStyleBackColor = false;
            this.btnBuscarAvanzado.Click += new System.EventHandler(this.btnBuscarAvanzado_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFiltro.Location = new System.Drawing.Point(646, 58);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(49, 21);
            this.lblFiltro.TabIndex = 11;
            this.lblFiltro.Text = "Filtro:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCriterio.Location = new System.Drawing.Point(443, 57);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(65, 21);
            this.lblCriterio.TabIndex = 10;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCampo.Location = new System.Drawing.Point(262, 58);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(63, 21);
            this.lblCampo.TabIndex = 9;
            this.lblCampo.Text = "Campo:";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(701, 55);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(164, 29);
            this.txtFiltroAvanzado.TabIndex = 8;
            // 
            // rbtnAvanzado
            // 
            this.rbtnAvanzado.AutoSize = true;
            this.rbtnAvanzado.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.rbtnAvanzado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnAvanzado.Location = new System.Drawing.Point(266, 15);
            this.rbtnAvanzado.Name = "rbtnAvanzado";
            this.rbtnAvanzado.Size = new System.Drawing.Size(165, 29);
            this.rbtnAvanzado.TabIndex = 7;
            this.rbtnAvanzado.TabStop = true;
            this.rbtnAvanzado.Text = "Filtro Avanzado:";
            this.rbtnAvanzado.UseVisualStyleBackColor = true;
            // 
            // rbtnRapido
            // 
            this.rbtnRapido.AutoSize = true;
            this.rbtnRapido.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.rbtnRapido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnRapido.Location = new System.Drawing.Point(16, 13);
            this.rbtnRapido.Name = "rbtnRapido";
            this.rbtnRapido.Size = new System.Drawing.Size(141, 29);
            this.rbtnRapido.TabIndex = 6;
            this.rbtnRapido.TabStop = true;
            this.rbtnRapido.Text = "Filtro Rápido:";
            this.rbtnRapido.UseVisualStyleBackColor = true;
            this.rbtnRapido.CheckedChanged += new System.EventHandler(this.rbtnRapido_CheckedChanged);
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(511, 55);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(121, 29);
            this.cbxCriterio.TabIndex = 4;
            // 
            // cbxCampo
            // 
            this.cbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(328, 54);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(103, 29);
            this.cbxCampo.TabIndex = 3;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // txtFiltroRapido
            // 
            this.txtFiltroRapido.Location = new System.Drawing.Point(16, 53);
            this.txtFiltroRapido.Name = "txtFiltroRapido";
            this.txtFiltroRapido.Size = new System.Drawing.Size(149, 29);
            this.txtFiltroRapido.TabIndex = 1;
            this.txtFiltroRapido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pnldgv
            // 
            this.pnldgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnldgv.Controls.Add(this.btnLimpiarFiltro);
            this.pnldgv.Controls.Add(this.lblTitulo);
            this.pnldgv.Controls.Add(this.dgvListado);
            this.pnldgv.Location = new System.Drawing.Point(163, 147);
            this.pnldgv.Name = "pnldgv";
            this.pnldgv.Size = new System.Drawing.Size(481, 468);
            this.pnldgv.TabIndex = 4;
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnLimpiarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltro.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarFiltro.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnLimpiarFiltro.IconColor = System.Drawing.Color.White;
            this.btnLimpiarFiltro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarFiltro.IconSize = 26;
            this.btnLimpiarFiltro.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(310, 417);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(145, 40);
            this.btnLimpiarFiltro.TabIndex = 6;
            this.btnLimpiarFiltro.Text = "Eliminar Filtros";
            this.btnLimpiarFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarFiltro.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(186, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(107, 32);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Artículos";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.gbxListado);
            this.panel3.Controls.Add(this.gbxAcciones);
            this.panel3.Location = new System.Drawing.Point(13, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 468);
            this.panel3.TabIndex = 5;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnBorrar.IconColor = System.Drawing.Color.White;
            this.btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrar.IconSize = 26;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBorrar.Location = new System.Drawing.Point(6, 130);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(109, 40);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            this.btnModificar.IconColor = System.Drawing.Color.White;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 24;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnModificar.Location = new System.Drawing.Point(6, 79);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(109, 40);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 26;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAgregar.Location = new System.Drawing.Point(6, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 40);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbxAcciones
            // 
            this.gbxAcciones.Controls.Add(this.btnAgregar);
            this.gbxAcciones.Controls.Add(this.btnBorrar);
            this.gbxAcciones.Controls.Add(this.btnModificar);
            this.gbxAcciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxAcciones.Location = new System.Drawing.Point(11, 234);
            this.gbxAcciones.Name = "gbxAcciones";
            this.gbxAcciones.Size = new System.Drawing.Size(121, 177);
            this.gbxAcciones.TabIndex = 6;
            this.gbxAcciones.TabStop = false;
            this.gbxAcciones.Text = "Acciones";
            // 
            // gbxListado
            // 
            this.gbxListado.Controls.Add(this.btnListarArticulos);
            this.gbxListado.Controls.Add(this.btnListarCategorias);
            this.gbxListado.Controls.Add(this.btnListarMarcas);
            this.gbxListado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxListado.Location = new System.Drawing.Point(11, 34);
            this.gbxListado.Name = "gbxListado";
            this.gbxListado.Size = new System.Drawing.Size(121, 177);
            this.gbxListado.TabIndex = 7;
            this.gbxListado.TabStop = false;
            this.gbxListado.Text = "Listar";
            // 
            // btnListarArticulos
            // 
            this.btnListarArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnListarArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarArticulos.ForeColor = System.Drawing.Color.White;
            this.btnListarArticulos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnListarArticulos.IconColor = System.Drawing.Color.White;
            this.btnListarArticulos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListarArticulos.IconSize = 26;
            this.btnListarArticulos.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnListarArticulos.Location = new System.Drawing.Point(6, 28);
            this.btnListarArticulos.Name = "btnListarArticulos";
            this.btnListarArticulos.Size = new System.Drawing.Size(109, 40);
            this.btnListarArticulos.TabIndex = 6;
            this.btnListarArticulos.Text = "Artículos";
            this.btnListarArticulos.UseVisualStyleBackColor = false;
            this.btnListarArticulos.Click += new System.EventHandler(this.btnListarArticulos_Click);
            // 
            // btnListarCategorias
            // 
            this.btnListarCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnListarCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarCategorias.ForeColor = System.Drawing.Color.White;
            this.btnListarCategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnListarCategorias.IconColor = System.Drawing.Color.White;
            this.btnListarCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListarCategorias.IconSize = 26;
            this.btnListarCategorias.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnListarCategorias.Location = new System.Drawing.Point(6, 130);
            this.btnListarCategorias.Name = "btnListarCategorias";
            this.btnListarCategorias.Size = new System.Drawing.Size(109, 40);
            this.btnListarCategorias.TabIndex = 8;
            this.btnListarCategorias.Text = "Categorias";
            this.btnListarCategorias.UseVisualStyleBackColor = false;
            this.btnListarCategorias.Click += new System.EventHandler(this.btnListarCategorias_Click);
            // 
            // btnListarMarcas
            // 
            this.btnListarMarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnListarMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarMarcas.ForeColor = System.Drawing.Color.White;
            this.btnListarMarcas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnListarMarcas.IconColor = System.Drawing.Color.White;
            this.btnListarMarcas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListarMarcas.IconSize = 24;
            this.btnListarMarcas.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnListarMarcas.Location = new System.Drawing.Point(6, 79);
            this.btnListarMarcas.Name = "btnListarMarcas";
            this.btnListarMarcas.Size = new System.Drawing.Size(109, 40);
            this.btnListarMarcas.TabIndex = 7;
            this.btnListarMarcas.Text = "Marcas";
            this.btnListarMarcas.UseVisualStyleBackColor = false;
            this.btnListarMarcas.Click += new System.EventHandler(this.btnListarMarcas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 631);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnldgv);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.pnlDerecho);
            this.Image = null;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Artículos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.pnlDerecho.ResumeLayout(false);
            this.pnlDerecho.PerformLayout();
            this.pnlCodigo.ResumeLayout(false);
            this.pnlCodigo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenUrl)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.pnldgv.ResumeLayout(false);
            this.pnldgv.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.gbxAcciones.ResumeLayout(false);
            this.gbxListado.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Panel pnlDerecho;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.PictureBox pbxImagenUrl;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTextoDescripcion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnldgv;
        private System.Windows.Forms.TextBox txtFiltroRapido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.RadioButton rbtnAvanzado;
        private System.Windows.Forms.RadioButton rbtnRapido;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Panel pnlCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTextoCodigo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTextoPrecio;
        private FontAwesome.Sharp.IconButton btnLimpiarFiltro;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnBuscarAvanzado;
        private System.Windows.Forms.GroupBox gbxListado;
        private FontAwesome.Sharp.IconButton btnListarArticulos;
        private FontAwesome.Sharp.IconButton btnListarCategorias;
        private FontAwesome.Sharp.IconButton btnListarMarcas;
        private System.Windows.Forms.GroupBox gbxAcciones;
    }
}