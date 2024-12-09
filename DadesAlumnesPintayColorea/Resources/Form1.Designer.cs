namespace Dades_Alumnes_Joc_Pintar
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.textBoxCrearCarpeta = new System.Windows.Forms.TextBox();
            this.textBoxCrearArchivo = new System.Windows.Forms.TextBox();
            this.textBoxEliminarArchivo = new System.Windows.Forms.TextBox();
            this.buttonCrearCarpeta = new System.Windows.Forms.Button();
            this.buttonCrearArchivo = new System.Windows.Forms.Button();
            this.buttonEliminarArchivo = new System.Windows.Forms.Button();
            this.listViewArchivos = new System.Windows.Forms.ListView();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonCopiarNombre = new System.Windows.Forms.Button();
            this.textBoxCopiarNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFiltrar = new System.Windows.Forms.ComboBox();
            this.comboBoxOrdenar = new System.Windows.Forms.ComboBox();
            this.labelOrdenar = new System.Windows.Forms.Label();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.textBoxCambiarNombre = new System.Windows.Forms.TextBox();
            this.buttonCambiarNombre = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelArchivoSelecionado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(75, 22);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(158, 20);
            this.textBoxPath.TabIndex = 0;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(28, 25);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(29, 13);
            this.labelPath.TabIndex = 1;
            this.labelPath.Text = "Path";
            // 
            // textBoxCrearCarpeta
            // 
            this.textBoxCrearCarpeta.Location = new System.Drawing.Point(31, 77);
            this.textBoxCrearCarpeta.Name = "textBoxCrearCarpeta";
            this.textBoxCrearCarpeta.Size = new System.Drawing.Size(202, 20);
            this.textBoxCrearCarpeta.TabIndex = 2;
            // 
            // textBoxCrearArchivo
            // 
            this.textBoxCrearArchivo.Location = new System.Drawing.Point(31, 138);
            this.textBoxCrearArchivo.Name = "textBoxCrearArchivo";
            this.textBoxCrearArchivo.Size = new System.Drawing.Size(202, 20);
            this.textBoxCrearArchivo.TabIndex = 5;
            // 
            // textBoxEliminarArchivo
            // 
            this.textBoxEliminarArchivo.Location = new System.Drawing.Point(31, 197);
            this.textBoxEliminarArchivo.Name = "textBoxEliminarArchivo";
            this.textBoxEliminarArchivo.Size = new System.Drawing.Size(202, 20);
            this.textBoxEliminarArchivo.TabIndex = 6;
            // 
            // buttonCrearCarpeta
            // 
            this.buttonCrearCarpeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCrearCarpeta.Location = new System.Drawing.Point(263, 76);
            this.buttonCrearCarpeta.Name = "buttonCrearCarpeta";
            this.buttonCrearCarpeta.Size = new System.Drawing.Size(121, 23);
            this.buttonCrearCarpeta.TabIndex = 7;
            this.buttonCrearCarpeta.Text = "Crear carpeta";
            this.buttonCrearCarpeta.UseVisualStyleBackColor = false;
            this.buttonCrearCarpeta.Click += new System.EventHandler(this.buttonCrearCarpeta_Click);
            // 
            // buttonCrearArchivo
            // 
            this.buttonCrearArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCrearArchivo.Location = new System.Drawing.Point(263, 137);
            this.buttonCrearArchivo.Name = "buttonCrearArchivo";
            this.buttonCrearArchivo.Size = new System.Drawing.Size(121, 23);
            this.buttonCrearArchivo.TabIndex = 8;
            this.buttonCrearArchivo.Text = "Crear archivo";
            this.buttonCrearArchivo.UseVisualStyleBackColor = false;
            this.buttonCrearArchivo.Click += new System.EventHandler(this.buttonCrearArchivo_Click);
            // 
            // buttonEliminarArchivo
            // 
            this.buttonEliminarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonEliminarArchivo.Location = new System.Drawing.Point(263, 196);
            this.buttonEliminarArchivo.Name = "buttonEliminarArchivo";
            this.buttonEliminarArchivo.Size = new System.Drawing.Size(121, 23);
            this.buttonEliminarArchivo.TabIndex = 9;
            this.buttonEliminarArchivo.Text = "Eliminar archivo";
            this.buttonEliminarArchivo.UseVisualStyleBackColor = false;
            this.buttonEliminarArchivo.Click += new System.EventHandler(this.buttonEliminarArchivo_Click);
            // 
            // listViewArchivos
            // 
            this.listViewArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewArchivos.HideSelection = false;
            this.listViewArchivos.Location = new System.Drawing.Point(502, 44);
            this.listViewArchivos.Name = "listViewArchivos";
            this.listViewArchivos.Size = new System.Drawing.Size(555, 407);
            this.listViewArchivos.TabIndex = 11;
            this.listViewArchivos.UseCompatibleStateImageBehavior = false;
            this.listViewArchivos.SelectedIndexChanged += new System.EventHandler(this.listViewArchivos_SelectedIndexChanged);
            this.listViewArchivos.DoubleClick += new System.EventHandler(this.listViewArchivos_DoubleClick);
            // 
            // buttonCargar
            // 
            this.buttonCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCargar.Location = new System.Drawing.Point(263, 22);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(121, 23);
            this.buttonCargar.TabIndex = 12;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = false;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // buttonCopiarNombre
            // 
            this.buttonCopiarNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCopiarNombre.Location = new System.Drawing.Point(263, 322);
            this.buttonCopiarNombre.Name = "buttonCopiarNombre";
            this.buttonCopiarNombre.Size = new System.Drawing.Size(121, 23);
            this.buttonCopiarNombre.TabIndex = 14;
            this.buttonCopiarNombre.Text = "Copiar ruta del archivo";
            this.buttonCopiarNombre.UseVisualStyleBackColor = false;
            this.buttonCopiarNombre.Click += new System.EventHandler(this.buttonCopiarNombre_Click);
            // 
            // textBoxCopiarNombre
            // 
            this.textBoxCopiarNombre.Location = new System.Drawing.Point(31, 323);
            this.textBoxCopiarNombre.Name = "textBoxCopiarNombre";
            this.textBoxCopiarNombre.Size = new System.Drawing.Size(202, 20);
            this.textBoxCopiarNombre.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Archivos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(835, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Filtrar";
            // 
            // comboBoxFiltrar
            // 
            this.comboBoxFiltrar.FormattingEnabled = true;
            this.comboBoxFiltrar.Items.AddRange(new object[] {
            "Todos",
            "Solo JSON",
            "Solo Carpetas",
            "Solo Archivos"});
            this.comboBoxFiltrar.Location = new System.Drawing.Point(873, 24);
            this.comboBoxFiltrar.Name = "comboBoxFiltrar";
            this.comboBoxFiltrar.Size = new System.Drawing.Size(184, 21);
            this.comboBoxFiltrar.TabIndex = 16;
            this.comboBoxFiltrar.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltrar_SelectedIndexChanged);
            // 
            // comboBoxOrdenar
            // 
            this.comboBoxOrdenar.FormattingEnabled = true;
            this.comboBoxOrdenar.Items.AddRange(new object[] {
            "Nombre",
            "Fecha de creación",
            "Tipo"});
            this.comboBoxOrdenar.Location = new System.Drawing.Point(646, 24);
            this.comboBoxOrdenar.Name = "comboBoxOrdenar";
            this.comboBoxOrdenar.Size = new System.Drawing.Size(184, 21);
            this.comboBoxOrdenar.TabIndex = 21;
            this.comboBoxOrdenar.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrdenar_SelectedIndexChanged);
            // 
            // labelOrdenar
            // 
            this.labelOrdenar.AutoSize = true;
            this.labelOrdenar.Location = new System.Drawing.Point(599, 27);
            this.labelOrdenar.Name = "labelOrdenar";
            this.labelOrdenar.Size = new System.Drawing.Size(45, 13);
            this.labelOrdenar.TabIndex = 20;
            this.labelOrdenar.Text = "Ordenar";
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(445, 44);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(51, 23);
            this.buttonAtras.TabIndex = 22;
            this.buttonAtras.Text = "🡰";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // textBoxCambiarNombre
            // 
            this.textBoxCambiarNombre.Location = new System.Drawing.Point(31, 260);
            this.textBoxCambiarNombre.Name = "textBoxCambiarNombre";
            this.textBoxCambiarNombre.Size = new System.Drawing.Size(202, 20);
            this.textBoxCambiarNombre.TabIndex = 23;
            // 
            // buttonCambiarNombre
            // 
            this.buttonCambiarNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCambiarNombre.Location = new System.Drawing.Point(263, 258);
            this.buttonCambiarNombre.Name = "buttonCambiarNombre";
            this.buttonCambiarNombre.Size = new System.Drawing.Size(121, 23);
            this.buttonCambiarNombre.TabIndex = 24;
            this.buttonCambiarNombre.Text = "Cambiar Nombre";
            this.buttonCambiarNombre.UseVisualStyleBackColor = false;
            this.buttonCambiarNombre.Click += new System.EventHandler(this.buttonCambiarNombre_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Archivo Seleccionado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 26;
            // 
            // labelArchivoSelecionado
            // 
            this.labelArchivoSelecionado.AutoSize = true;
            this.labelArchivoSelecionado.Location = new System.Drawing.Point(138, 244);
            this.labelArchivoSelecionado.Name = "labelArchivoSelecionado";
            this.labelArchivoSelecionado.Size = new System.Drawing.Size(47, 13);
            this.labelArchivoSelecionado.TabIndex = 27;
            this.labelArchivoSelecionado.Text = "Ninguno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 463);
            this.Controls.Add(this.labelArchivoSelecionado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCambiarNombre);
            this.Controls.Add(this.textBoxCambiarNombre);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.comboBoxOrdenar);
            this.Controls.Add(this.labelOrdenar);
            this.Controls.Add(this.comboBoxFiltrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCopiarNombre);
            this.Controls.Add(this.textBoxCopiarNombre);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.listViewArchivos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEliminarArchivo);
            this.Controls.Add(this.buttonCrearArchivo);
            this.Controls.Add(this.buttonCrearCarpeta);
            this.Controls.Add(this.textBoxEliminarArchivo);
            this.Controls.Add(this.textBoxCrearArchivo);
            this.Controls.Add(this.textBoxCrearCarpeta);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.textBoxPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBoxCrearCarpeta;
        private System.Windows.Forms.TextBox textBoxCrearArchivo;
        private System.Windows.Forms.TextBox textBoxEliminarArchivo;
        private System.Windows.Forms.Button buttonCrearCarpeta;
        private System.Windows.Forms.Button buttonCrearArchivo;
        private System.Windows.Forms.Button buttonEliminarArchivo;
        private System.Windows.Forms.ListView listViewArchivos;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonCopiarNombre;
        private System.Windows.Forms.TextBox textBoxCopiarNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFiltrar;
        private System.Windows.Forms.ComboBox comboBoxOrdenar;
        private System.Windows.Forms.Label labelOrdenar;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.TextBox textBoxCambiarNombre;
        private System.Windows.Forms.Button buttonCambiarNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelArchivoSelecionado;
    }
}

