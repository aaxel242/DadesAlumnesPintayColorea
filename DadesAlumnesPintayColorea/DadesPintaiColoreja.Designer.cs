
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dades_Alumnes_Joc_Pintar
{
    partial class formJocPintar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelJSON = new System.Windows.Forms.DataGridView();
            this.lblDadesAlumnes = new System.Windows.Forms.Label();
            this.btnObrirArxiu = new System.Windows.Forms.Button();
            this.btnSortir = new System.Windows.Forms.Button();
            this.btnAfegirFila = new System.Windows.Forms.Button();
            this.btnEliminarFila = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pBoxDadesAlumnes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelJSON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDadesAlumnes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelJSON
            // 
            this.panelJSON.AllowDrop = true;
            this.panelJSON.AllowUserToAddRows = false;
            this.panelJSON.AllowUserToDeleteRows = false;
            this.panelJSON.BackgroundColor = System.Drawing.SystemColors.Info;
            this.panelJSON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panelJSON.Location = new System.Drawing.Point(39, 132);
            this.panelJSON.Name = "panelJSON";
            this.panelJSON.RowHeadersWidth = 51;
            this.panelJSON.Size = new System.Drawing.Size(1004, 492);
            this.panelJSON.TabIndex = 0;
            // 
            // lblDadesAlumnes
            // 
            this.lblDadesAlumnes.AutoSize = true;
            this.lblDadesAlumnes.Location = new System.Drawing.Point(39, 102);
            this.lblDadesAlumnes.Name = "lblDadesAlumnes";
            this.lblDadesAlumnes.Size = new System.Drawing.Size(0, 16);
            this.lblDadesAlumnes.TabIndex = 1;
            // 
            // btnObrirArxiu
            // 
            this.btnObrirArxiu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnObrirArxiu.Location = new System.Drawing.Point(604, 649);
            this.btnObrirArxiu.Name = "btnObrirArxiu";
            this.btnObrirArxiu.Size = new System.Drawing.Size(167, 49);
            this.btnObrirArxiu.TabIndex = 2;
            this.btnObrirArxiu.Text = "Obrir arxiu";
            this.btnObrirArxiu.UseVisualStyleBackColor = false;
            this.btnObrirArxiu.Click += new System.EventHandler(this.btnObrirArxiu_Click_1);
            // 
            // btnSortir
            // 
            this.btnSortir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSortir.Location = new System.Drawing.Point(793, 649);
            this.btnSortir.Name = "btnSortir";
            this.btnSortir.Size = new System.Drawing.Size(167, 49);
            this.btnSortir.TabIndex = 3;
            this.btnSortir.Text = "Sortir";
            this.btnSortir.UseVisualStyleBackColor = false;
            this.btnSortir.Click += new System.EventHandler(this.btnSortir_Click_1);
            // 
            // btnAfegirFila
            // 
            this.btnAfegirFila.Location = new System.Drawing.Point(42, 649);
            this.btnAfegirFila.Name = "btnAfegirFila";
            this.btnAfegirFila.Size = new System.Drawing.Size(167, 49);
            this.btnAfegirFila.TabIndex = 4;
            this.btnAfegirFila.Text = "Afegir Fila";
            this.btnAfegirFila.UseVisualStyleBackColor = true;
            this.btnAfegirFila.Click += new System.EventHandler(this.btnAfegirFila_Click_1);
            // 
            // btnEliminarFila
            // 
            this.btnEliminarFila.Location = new System.Drawing.Point(230, 649);
            this.btnEliminarFila.Name = "btnEliminarFila";
            this.btnEliminarFila.Size = new System.Drawing.Size(167, 49);
            this.btnEliminarFila.TabIndex = 5;
            this.btnEliminarFila.Text = "Eliminar Fila";
            this.btnEliminarFila.UseVisualStyleBackColor = true;
            this.btnEliminarFila.Click += new System.EventHandler(this.btnEliminarFila_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(418, 649);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(167, 49);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // pBoxDadesAlumnes
            // 
            this.pBoxDadesAlumnes.BackColor = System.Drawing.Color.Transparent;
            this.pBoxDadesAlumnes.Image = global::DadesAlumnesPintayColorea.Properties.Resources.Dades_Alumnes;
            this.pBoxDadesAlumnes.Location = new System.Drawing.Point(39, 80);
            this.pBoxDadesAlumnes.Name = "pBoxDadesAlumnes";
            this.pBoxDadesAlumnes.Size = new System.Drawing.Size(440, 38);
            this.pBoxDadesAlumnes.TabIndex = 9;
            this.pBoxDadesAlumnes.TabStop = false;
            // 
            // formJocPintar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DadesAlumnesPintayColorea.Properties.Resources.fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 728);
            this.Controls.Add(this.pBoxDadesAlumnes);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminarFila);
            this.Controls.Add(this.btnAfegirFila);
            this.Controls.Add(this.btnSortir);
            this.Controls.Add(this.btnObrirArxiu);
            this.Controls.Add(this.lblDadesAlumnes);
            this.Controls.Add(this.panelJSON);
            this.DoubleBuffered = true;
            this.Name = "formJocPintar";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panelJSON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDadesAlumnes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            

        }

        #endregion

        private DataGridView panelJSON;
        private Label lblDadesAlumnes;
        private Button btnObrirArxiu;
        private Button btnSortir;
        private Button btnAfegirFila;
        private Button btnEliminarFila;
        private Button btnGuardar;
        private PictureBox pBoxDadesAlumnes;
    }
}
