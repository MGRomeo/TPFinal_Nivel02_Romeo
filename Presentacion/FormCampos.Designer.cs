
namespace Presentacion
{
    partial class FormCampos
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
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.btnAgregarImagen = new FontAwesome.Sharp.IconButton();
            this.cbxNombreActual = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlImagen = new System.Windows.Forms.Panel();
            this.pbxUrlImagen = new System.Windows.Forms.PictureBox();
            this.btnMarca = new FontAwesome.Sharp.IconButton();
            this.btnCategoria = new FontAwesome.Sharp.IconButton();
            this.btnArticulo = new FontAwesome.Sharp.IconButton();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.lbltextoNuevo = new System.Windows.Forms.Label();
            this.btnAceptar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.pnlCampos.SuspendLayout();
            this.pnlImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrlImagen)).BeginInit();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCampos
            // 
            this.pnlCampos.BackColor = System.Drawing.Color.DimGray;
            this.pnlCampos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCampos.Controls.Add(this.btnAgregarImagen);
            this.pnlCampos.Controls.Add(this.cbxNombreActual);
            this.pnlCampos.Controls.Add(this.lblPrecio);
            this.pnlCampos.Controls.Add(this.txtPrecio);
            this.pnlCampos.Controls.Add(this.lblTitulo);
            this.pnlCampos.Controls.Add(this.txtUrlImagen);
            this.pnlCampos.Controls.Add(this.lblCategoria);
            this.pnlCampos.Controls.Add(this.cbxCategoria);
            this.pnlCampos.Controls.Add(this.cbxMarca);
            this.pnlCampos.Controls.Add(this.lblMarca);
            this.pnlCampos.Controls.Add(this.lblUrlImagen);
            this.pnlCampos.Controls.Add(this.txtDescripcion);
            this.pnlCampos.Controls.Add(this.lblDescripcion);
            this.pnlCampos.Controls.Add(this.txtCodigo);
            this.pnlCampos.Controls.Add(this.lblCodigo);
            this.pnlCampos.Controls.Add(this.txtNombre);
            this.pnlCampos.Controls.Add(this.lblNombre);
            this.pnlCampos.Location = new System.Drawing.Point(142, 48);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(238, 401);
            this.pnlCampos.TabIndex = 1;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.BackColor = System.Drawing.Color.White;
            this.btnAgregarImagen.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarImagen.IconColor = System.Drawing.Color.Black;
            this.btnAgregarImagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarImagen.IconSize = 15;
            this.btnAgregarImagen.Location = new System.Drawing.Point(202, 214);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(26, 29);
            this.btnAgregarImagen.TabIndex = 4;
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // cbxNombreActual
            // 
            this.cbxNombreActual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNombreActual.FormattingEnabled = true;
            this.cbxNombreActual.Location = new System.Drawing.Point(105, 58);
            this.cbxNombreActual.Name = "cbxNombreActual";
            this.cbxNombreActual.Size = new System.Drawing.Size(121, 29);
            this.cbxNombreActual.TabIndex = 0;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(40, 354);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 21);
            this.lblPrecio.TabIndex = 21;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(105, 346);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(119, 29);
            this.txtPrecio.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(93, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 25);
            this.lblTitulo.TabIndex = 19;
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(105, 214);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(91, 29);
            this.txtUrlImagen.TabIndex = 3;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(16, 316);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(77, 21);
            this.lblCategoria.TabIndex = 10;
            this.lblCategoria.Text = "Categoría";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(105, 302);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 29);
            this.cbxCategoria.TabIndex = 6;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(105, 258);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(121, 29);
            this.cbxMarca.TabIndex = 5;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(40, 267);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(53, 21);
            this.lblMarca.TabIndex = 7;
            this.lblMarca.Text = "Marca";
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.ForeColor = System.Drawing.Color.White;
            this.lblUrlImagen.Location = new System.Drawing.Point(6, 216);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(87, 21);
            this.lblUrlImagen.TabIndex = 6;
            this.lblUrlImagen.Text = "Url Imagen";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(105, 146);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 53);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(2, 150);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 21);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(105, 102);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 29);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(33, 107);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 21);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 29);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(25, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // pnlImagen
            // 
            this.pnlImagen.BackColor = System.Drawing.Color.DimGray;
            this.pnlImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImagen.Controls.Add(this.pbxUrlImagen);
            this.pnlImagen.Location = new System.Drawing.Point(397, 48);
            this.pnlImagen.Name = "pnlImagen";
            this.pnlImagen.Size = new System.Drawing.Size(280, 279);
            this.pnlImagen.TabIndex = 4;
            // 
            // pbxUrlImagen
            // 
            this.pbxUrlImagen.Location = new System.Drawing.Point(16, 15);
            this.pbxUrlImagen.Name = "pbxUrlImagen";
            this.pbxUrlImagen.Size = new System.Drawing.Size(250, 251);
            this.pbxUrlImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUrlImagen.TabIndex = 0;
            this.pbxUrlImagen.TabStop = false;
            // 
            // btnMarca
            // 
            this.btnMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarca.ForeColor = System.Drawing.Color.White;
            this.btnMarca.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMarca.IconColor = System.Drawing.Color.Black;
            this.btnMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMarca.Location = new System.Drawing.Point(18, 134);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(75, 31);
            this.btnMarca.TabIndex = 1;
            this.btnMarca.Text = "Marca";
            this.btnMarca.UseVisualStyleBackColor = false;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCategoria.IconColor = System.Drawing.Color.Black;
            this.btnCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategoria.Location = new System.Drawing.Point(9, 190);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(92, 31);
            this.btnCategoria.TabIndex = 2;
            this.btnCategoria.Text = "Categoría";
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnArticulo
            // 
            this.btnArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulo.ForeColor = System.Drawing.Color.White;
            this.btnArticulo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnArticulo.IconColor = System.Drawing.Color.Black;
            this.btnArticulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArticulo.Location = new System.Drawing.Point(18, 78);
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Size = new System.Drawing.Size(75, 31);
            this.btnArticulo.TabIndex = 0;
            this.btnArticulo.Text = "Artículo";
            this.btnArticulo.UseVisualStyleBackColor = false;
            this.btnArticulo.Click += new System.EventHandler(this.btnArticulo_Click);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBotones.BackColor = System.Drawing.Color.DimGray;
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.Controls.Add(this.lbltextoNuevo);
            this.pnlBotones.Controls.Add(this.btnArticulo);
            this.pnlBotones.Controls.Add(this.btnMarca);
            this.pnlBotones.Controls.Add(this.btnCategoria);
            this.pnlBotones.Location = new System.Drawing.Point(15, 47);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(113, 326);
            this.pnlBotones.TabIndex = 0;
            // 
            // lbltextoNuevo
            // 
            this.lbltextoNuevo.AutoSize = true;
            this.lbltextoNuevo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbltextoNuevo.ForeColor = System.Drawing.Color.White;
            this.lbltextoNuevo.Location = new System.Drawing.Point(22, 16);
            this.lbltextoNuevo.Name = "lbltextoNuevo";
            this.lbltextoNuevo.Size = new System.Drawing.Size(67, 25);
            this.lbltextoNuevo.TabIndex = 18;
            this.lbltextoNuevo.Text = "Nuevo";
            this.lbltextoNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Lime;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAceptar.IconColor = System.Drawing.Color.Black;
            this.btnAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceptar.IconSize = 20;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAceptar.Location = new System.Drawing.Point(142, 455);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 31);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 20;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancelar.Location = new System.Drawing.Point(276, 455);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 31);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormCampos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 554);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlImagen);
            this.Controls.Add(this.pnlCampos);
            this.Image = null;
            this.Name = "FormCampos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.FormCampos_Load);
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.pnlImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrlImagen)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.pnlBotones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel pnlImagen;
        private FontAwesome.Sharp.IconButton btnMarca;
        private FontAwesome.Sharp.IconButton btnCategoria;
        private FontAwesome.Sharp.IconButton btnArticulo;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Label lbltextoNuevo;
        private System.Windows.Forms.PictureBox pbxUrlImagen;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private FontAwesome.Sharp.IconButton btnAgregarImagen;
        private System.Windows.Forms.ComboBox cbxNombreActual;
    }
}