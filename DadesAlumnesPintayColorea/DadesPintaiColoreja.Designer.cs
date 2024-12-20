﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelJSON = new System.Windows.Forms.DataGridView();
            this.lblDadesAlumnes = new System.Windows.Forms.Label();
            this.btnObrirArxiu = new System.Windows.Forms.Button();
            this.btnSortir = new System.Windows.Forms.Button();
            this.btnAfegirFila = new System.Windows.Forms.Button();
            this.btnEliminarFila = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pBoxDadesAlumnes = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBoxAfegir = new System.Windows.Forms.PictureBox();
            this.btnEditarArxiu = new System.Windows.Forms.Button();
            this.pBoxEditarArxiu = new System.Windows.Forms.PictureBox();
            this.lblNomArxiu = new System.Windows.Forms.Label();
            this.txtBoxEditarNomArxiu = new System.Windows.Forms.TextBox();
            this.pBoxTituloEditarArxiu = new System.Windows.Forms.PictureBox();
            this.btnConfirmarNomArxiu = new System.Windows.Forms.Button();
            this.btnEliminarArxiu = new System.Windows.Forms.Button();
            this.btnObrirExplorador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelJSON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDadesAlumnes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAfegir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxEditarArxiu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTituloEditarArxiu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelJSON
            // 
            this.panelJSON.AllowDrop = true;
            this.panelJSON.AllowUserToAddRows = false;
            this.panelJSON.AllowUserToDeleteRows = false;
            this.panelJSON.BackgroundColor = System.Drawing.SystemColors.Info;
            this.panelJSON.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.panelJSON.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.panelJSON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.panelJSON.DefaultCellStyle = dataGridViewCellStyle6;
            this.panelJSON.GridColor = System.Drawing.SystemColors.Desktop;
            this.panelJSON.Location = new System.Drawing.Point(54, 135);
            this.panelJSON.Margin = new System.Windows.Forms.Padding(2);
            this.panelJSON.Name = "panelJSON";
            this.panelJSON.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 11.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.panelJSON.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.panelJSON.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 11.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.panelJSON.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.panelJSON.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info;
            this.panelJSON.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelJSON.Size = new System.Drawing.Size(1021, 400);
            this.panelJSON.TabIndex = 0;
            // 
            // lblDadesAlumnes
            // 
            this.lblDadesAlumnes.AutoSize = true;
            this.lblDadesAlumnes.Location = new System.Drawing.Point(29, 83);
            this.lblDadesAlumnes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDadesAlumnes.Name = "lblDadesAlumnes";
            this.lblDadesAlumnes.Size = new System.Drawing.Size(0, 13);
            this.lblDadesAlumnes.TabIndex = 1;
            // 
            // btnObrirArxiu
            // 
            this.btnObrirArxiu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnObrirArxiu.FlatAppearance.BorderSize = 2;
            this.btnObrirArxiu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnObrirArxiu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrirArxiu.Location = new System.Drawing.Point(54, 553);
            this.btnObrirArxiu.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrirArxiu.Name = "btnObrirArxiu";
            this.btnObrirArxiu.Size = new System.Drawing.Size(125, 40);
            this.btnObrirArxiu.TabIndex = 2;
            this.btnObrirArxiu.Text = "Obrir arxiu";
            this.btnObrirArxiu.UseVisualStyleBackColor = false;
            this.btnObrirArxiu.Click += new System.EventHandler(this.btnObrirArxiu_Click_1);
            // 
            // btnSortir
            // 
            this.btnSortir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSortir.FlatAppearance.BorderSize = 2;
            this.btnSortir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSortir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSortir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortir.Location = new System.Drawing.Point(950, 553);
            this.btnSortir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSortir.Name = "btnSortir";
            this.btnSortir.Size = new System.Drawing.Size(125, 40);
            this.btnSortir.TabIndex = 3;
            this.btnSortir.Text = "Sortir";
            this.btnSortir.UseVisualStyleBackColor = false;
            this.btnSortir.Click += new System.EventHandler(this.btnSortir_Click_1);
            // 
            // btnAfegirFila
            // 
            this.btnAfegirFila.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAfegirFila.FlatAppearance.BorderSize = 2;
            this.btnAfegirFila.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAfegirFila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfegirFila.Location = new System.Drawing.Point(523, 553);
            this.btnAfegirFila.Margin = new System.Windows.Forms.Padding(2);
            this.btnAfegirFila.Name = "btnAfegirFila";
            this.btnAfegirFila.Size = new System.Drawing.Size(125, 40);
            this.btnAfegirFila.TabIndex = 4;
            this.btnAfegirFila.Text = "Afegir Fila";
            this.btnAfegirFila.UseVisualStyleBackColor = false;
            this.btnAfegirFila.Visible = false;
            this.btnAfegirFila.Click += new System.EventHandler(this.btnAfegirFila_Click_1);
            // 
            // btnEliminarFila
            // 
            this.btnEliminarFila.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarFila.FlatAppearance.BorderSize = 2;
            this.btnEliminarFila.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminarFila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFila.Location = new System.Drawing.Point(667, 553);
            this.btnEliminarFila.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarFila.Name = "btnEliminarFila";
            this.btnEliminarFila.Size = new System.Drawing.Size(125, 40);
            this.btnEliminarFila.TabIndex = 5;
            this.btnEliminarFila.Text = "Eliminar Fila";
            this.btnEliminarFila.UseVisualStyleBackColor = false;
            this.btnEliminarFila.Visible = false;
            this.btnEliminarFila.Click += new System.EventHandler(this.btnEliminarFila_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(809, 553);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 40);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // pBoxDadesAlumnes
            // 
            this.pBoxDadesAlumnes.BackColor = System.Drawing.Color.Transparent;
            this.pBoxDadesAlumnes.Image = global::DadesAlumnesPintayColorea.Properties.Resources.Dades_Alumnes;
            this.pBoxDadesAlumnes.Location = new System.Drawing.Point(29, 23);
            this.pBoxDadesAlumnes.Margin = new System.Windows.Forms.Padding(2);
            this.pBoxDadesAlumnes.Name = "pBoxDadesAlumnes";
            this.pBoxDadesAlumnes.Size = new System.Drawing.Size(330, 31);
            this.pBoxDadesAlumnes.TabIndex = 9;
            this.pBoxDadesAlumnes.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DadesAlumnesPintayColorea.Properties.Resources.imgTablon3;
            this.pictureBox1.Location = new System.Drawing.Point(-10, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1146, 641);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pBoxAfegir
            // 
            this.pBoxAfegir.BackColor = System.Drawing.SystemColors.Info;
            this.pBoxAfegir.Image = global::DadesAlumnesPintayColorea.Properties.Resources.imgAfegir1;
            this.pBoxAfegir.Location = new System.Drawing.Point(83, 166);
            this.pBoxAfegir.Name = "pBoxAfegir";
            this.pBoxAfegir.Size = new System.Drawing.Size(293, 343);
            this.pBoxAfegir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxAfegir.TabIndex = 11;
            this.pBoxAfegir.TabStop = false;
            this.pBoxAfegir.Click += new System.EventHandler(this.pBoxAfegir_Click);
            // 
            // btnEditarArxiu
            // 
            this.btnEditarArxiu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarArxiu.FlatAppearance.BorderSize = 2;
            this.btnEditarArxiu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEditarArxiu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarArxiu.Location = new System.Drawing.Point(331, 553);
            this.btnEditarArxiu.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarArxiu.Name = "btnEditarArxiu";
            this.btnEditarArxiu.Size = new System.Drawing.Size(125, 40);
            this.btnEditarArxiu.TabIndex = 12;
            this.btnEditarArxiu.Text = "Editar Arxiu";
            this.btnEditarArxiu.UseVisualStyleBackColor = false;
            this.btnEditarArxiu.Visible = false;
            this.btnEditarArxiu.Click += new System.EventHandler(this.btnEditarArxiu_Click);
            // 
            // pBoxEditarArxiu
            // 
            this.pBoxEditarArxiu.BackColor = System.Drawing.Color.Transparent;
            this.pBoxEditarArxiu.Image = global::DadesAlumnesPintayColorea.Properties.Resources.imgTablonVertical;
            this.pBoxEditarArxiu.Location = new System.Drawing.Point(1188, 59);
            this.pBoxEditarArxiu.Name = "pBoxEditarArxiu";
            this.pBoxEditarArxiu.Size = new System.Drawing.Size(714, 930);
            this.pBoxEditarArxiu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxEditarArxiu.TabIndex = 13;
            this.pBoxEditarArxiu.TabStop = false;
            this.pBoxEditarArxiu.Visible = false;
            // 
            // lblNomArxiu
            // 
            this.lblNomArxiu.AutoSize = true;
            this.lblNomArxiu.BackColor = System.Drawing.Color.Tan;
            this.lblNomArxiu.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomArxiu.Location = new System.Drawing.Point(1321, 214);
            this.lblNomArxiu.MaximumSize = new System.Drawing.Size(1000, 30);
            this.lblNomArxiu.Name = "lblNomArxiu";
            this.lblNomArxiu.Size = new System.Drawing.Size(75, 29);
            this.lblNomArxiu.TabIndex = 14;
            this.lblNomArxiu.Text = "label1";
            this.lblNomArxiu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNomArxiu.Visible = false;
            // 
            // txtBoxEditarNomArxiu
            // 
            this.txtBoxEditarNomArxiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEditarNomArxiu.Location = new System.Drawing.Point(1326, 265);
            this.txtBoxEditarNomArxiu.Multiline = true;
            this.txtBoxEditarNomArxiu.Name = "txtBoxEditarNomArxiu";
            this.txtBoxEditarNomArxiu.Size = new System.Drawing.Size(469, 35);
            this.txtBoxEditarNomArxiu.TabIndex = 15;
            this.txtBoxEditarNomArxiu.Visible = false;
            // 
            // pBoxTituloEditarArxiu
            // 
            this.pBoxTituloEditarArxiu.BackColor = System.Drawing.Color.BurlyWood;
            this.pBoxTituloEditarArxiu.Image = global::DadesAlumnesPintayColorea.Properties.Resources.Editar_arxiu;
            this.pBoxTituloEditarArxiu.Location = new System.Drawing.Point(1451, 135);
            this.pBoxTituloEditarArxiu.Name = "pBoxTituloEditarArxiu";
            this.pBoxTituloEditarArxiu.Size = new System.Drawing.Size(220, 31);
            this.pBoxTituloEditarArxiu.TabIndex = 16;
            this.pBoxTituloEditarArxiu.TabStop = false;
            this.pBoxTituloEditarArxiu.Visible = false;
            // 
            // btnConfirmarNomArxiu
            // 
            this.btnConfirmarNomArxiu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmarNomArxiu.FlatAppearance.BorderSize = 2;
            this.btnConfirmarNomArxiu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConfirmarNomArxiu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmarNomArxiu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarNomArxiu.Location = new System.Drawing.Point(1326, 317);
            this.btnConfirmarNomArxiu.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmarNomArxiu.Name = "btnConfirmarNomArxiu";
            this.btnConfirmarNomArxiu.Size = new System.Drawing.Size(125, 40);
            this.btnConfirmarNomArxiu.TabIndex = 17;
            this.btnConfirmarNomArxiu.Text = "Confirmar";
            this.btnConfirmarNomArxiu.UseVisualStyleBackColor = false;
            this.btnConfirmarNomArxiu.Visible = false;
            this.btnConfirmarNomArxiu.Click += new System.EventHandler(this.btnConfirmarNomArxiu_Click);
            // 
            // btnEliminarArxiu
            // 
            this.btnEliminarArxiu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminarArxiu.FlatAppearance.BorderSize = 2;
            this.btnEliminarArxiu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminarArxiu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarArxiu.Location = new System.Drawing.Point(1326, 866);
            this.btnEliminarArxiu.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarArxiu.Name = "btnEliminarArxiu";
            this.btnEliminarArxiu.Size = new System.Drawing.Size(125, 40);
            this.btnEliminarArxiu.TabIndex = 18;
            this.btnEliminarArxiu.Text = "Esborrar Arxiu";
            this.btnEliminarArxiu.UseVisualStyleBackColor = false;
            this.btnEliminarArxiu.Visible = false;
            this.btnEliminarArxiu.Click += new System.EventHandler(this.btnEliminarArxiu_Click);
            // 
            // btnObrirExplorador
            // 
            this.btnObrirExplorador.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnObrirExplorador.FlatAppearance.BorderSize = 2;
            this.btnObrirExplorador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnObrirExplorador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrirExplorador.Location = new System.Drawing.Point(192, 553);
            this.btnObrirExplorador.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrirExplorador.Name = "btnObrirExplorador";
            this.btnObrirExplorador.Size = new System.Drawing.Size(125, 40);
            this.btnObrirExplorador.TabIndex = 19;
            this.btnObrirExplorador.Text = "Obrir Explorador";
            this.btnObrirExplorador.UseVisualStyleBackColor = false;
            this.btnObrirExplorador.Click += new System.EventHandler(this.btnObrirExplorador_Click);
            // 
            // formJocPintar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DadesAlumnesPintayColorea.Properties.Resources.imgPaisajeFondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1046);
            this.Controls.Add(this.btnObrirExplorador);
            this.Controls.Add(this.btnEliminarArxiu);
            this.Controls.Add(this.btnConfirmarNomArxiu);
            this.Controls.Add(this.pBoxTituloEditarArxiu);
            this.Controls.Add(this.txtBoxEditarNomArxiu);
            this.Controls.Add(this.lblNomArxiu);
            this.Controls.Add(this.pBoxEditarArxiu);
            this.Controls.Add(this.btnEditarArxiu);
            this.Controls.Add(this.pBoxAfegir);
            this.Controls.Add(this.pBoxDadesAlumnes);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminarFila);
            this.Controls.Add(this.btnAfegirFila);
            this.Controls.Add(this.btnSortir);
            this.Controls.Add(this.btnObrirArxiu);
            this.Controls.Add(this.lblDadesAlumnes);
            this.Controls.Add(this.panelJSON);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formJocPintar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Dades Alumnes";
            ((System.ComponentModel.ISupportInitialize)(this.panelJSON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDadesAlumnes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAfegir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxEditarArxiu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTituloEditarArxiu)).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pBoxAfegir;
        private Button btnEditarArxiu;
        private PictureBox pBoxEditarArxiu;
        private Label lblNomArxiu;
        private TextBox txtBoxEditarNomArxiu;
        private PictureBox pBoxTituloEditarArxiu;
        private Button btnConfirmarNomArxiu;
        private Button btnEliminarArxiu;
        private Button btnObrirExplorador;
    }
}
