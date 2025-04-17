
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pnlDerecho = new System.Windows.Forms.Panel();
            this.pbxImagenUrl = new System.Windows.Forms.PictureBox();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblTextoDescripcion = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.pnlDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenUrl)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(3, 15);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(614, 386);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pnlDerecho
            // 
            this.pnlDerecho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDerecho.Controls.Add(this.panel1);
            this.pnlDerecho.Controls.Add(this.pbxImagenUrl);
            this.pnlDerecho.Location = new System.Drawing.Point(649, 145);
            this.pnlDerecho.Name = "pnlDerecho";
            this.pnlDerecho.Size = new System.Drawing.Size(346, 426);
            this.pnlDerecho.TabIndex = 2;
            // 
            // pbxImagenUrl
            // 
            this.pbxImagenUrl.Location = new System.Drawing.Point(13, 14);
            this.pbxImagenUrl.Name = "pbxImagenUrl";
            this.pbxImagenUrl.Size = new System.Drawing.Size(320, 320);
            this.pbxImagenUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenUrl.TabIndex = 0;
            this.pbxImagenUrl.TabStop = false;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSuperior.Location = new System.Drawing.Point(13, 38);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(982, 95);
            this.pnlSuperior.TabIndex = 3;
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
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 21);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(0, 21);
            this.lblDescripcion.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblTextoDescripcion);
            this.panel1.Location = new System.Drawing.Point(13, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 51);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvArticulos);
            this.panel2.Location = new System.Drawing.Point(13, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 425);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 649);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.pnlDerecho);
            this.Image = null;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Artículos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.pnlDerecho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenUrl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Panel pnlDerecho;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.PictureBox pbxImagenUrl;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTextoDescripcion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}