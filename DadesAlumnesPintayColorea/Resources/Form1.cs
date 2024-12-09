using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dades_Alumnes_Joc_Pintar
{
    public partial class Form1 : Form
    {
        private ImageList imageList;

        public Form1()
        {
            InitializeComponent();

            // Configurar el ListView
            listViewArchivos.View = View.LargeIcon;

            // Crear y configurar el ImageList
            imageList = new ImageList
            {
                ImageSize = new Size(64, 64),
                ColorDepth = ColorDepth.Depth32Bit
            };
            listViewArchivos.LargeImageList = imageList;
            string ruta = @"C:\";
            LoadFolder(ruta);
        }

        private void LoadFolder(string path, string filter = "Todos")
        {
            listViewArchivos.Items.Clear();
            imageList.Images.Clear();

            try
            {
                if (!Directory.Exists(path))
                {
                    MessageBox.Show("La ruta especificada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                textBoxPath.Text = path;

                if (!imageList.Images.ContainsKey("folder"))
                {
                    string shellFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
                    string folderIconPath = Path.Combine(shellFolderPath, "..", "explorer.exe");
                    Icon folderIcon = Icon.ExtractAssociatedIcon(folderIconPath);
                    imageList.Images.Add("folder", folderIcon.ToBitmap());
                }

                // Cargar subcarpetas
                var directories = Directory.GetDirectories(path);
                foreach (var dir in directories)
                {
                    string folderName = Path.GetFileName(dir);
                    ListViewItem item = new ListViewItem(folderName)
                    {
                        ImageKey = "folder",
                        Tag = dir
                    };
                    listViewArchivos.Items.Add(item);
                }

                // Cargar archivos
                var files = Directory.GetFiles(path);
                foreach (var file in files)
                {
                    string fileName = Path.GetFileName(file);
                    DateTime creationTime = File.GetCreationTime(file);
                    string fileType = Path.GetExtension(file);

                    Icon icon = Icon.ExtractAssociatedIcon(file);
                    if (icon != null)
                    {
                        imageList.Images.Add(file, icon.ToBitmap());
                    }

                    ListViewItem item = new ListViewItem(fileName)
                    {
                        ImageKey = file,
                        Tag = file
                    };

                    item.SubItems.Add(creationTime.ToString()); // Añadir fecha de creación
                    item.SubItems.Add(fileType); // Añadir tipo de archivo

                    // Filtrar según el criterio seleccionado
                    if (ShouldIncludeItem(item, filter))
                    {
                        listViewArchivos.Items.Add(item);
                    }
                }

                // Ordenar después de cargar
                SortListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la carpeta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void buttonBack_Click(object sender, EventArgs e)
        {
            string currentPath = textBoxPath.Text;

            // Verificar si hay partes en la ruta
            if (Directory.Exists(currentPath))
            {
                string parentPath = Directory.GetParent(currentPath)?.FullName;

                if (parentPath != null)
                {
                    LoadFolder(parentPath); // Cargar la carpeta padre
                }
                else
                {
                    MessageBox.Show("No hay más carpetas anteriores.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("La ruta actual no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewArchivos.SelectedItems.Count > 0)
            {
                textBoxCopiarNombre.Clear();
                textBoxEliminarArchivo.Clear();
                String rutaSeleccionada = listViewArchivos.SelectedItems[0].Tag.ToString();
                String nomArchiu = listViewArchivos.SelectedItems[0].Text.ToString();
                textBoxCopiarNombre.Text = rutaSeleccionada;
                textBoxEliminarArchivo.Text = nomArchiu;
                labelArchivoSelecionado.Text = nomArchiu;

            }


        }
        private void buttonCambiarNombre_Click(object sender, EventArgs e)
        {
            cambiarNomArxiu();
        }

        private void cambiarNomArxiu()
        {
            if (listViewArchivos.SelectedItems.Count > 0)
            {
                string rutaOriginal = listViewArchivos.SelectedItems[0].Tag.ToString();
                string nuevoNombre = textBoxCambiarNombre.Text;

                if (string.IsNullOrWhiteSpace(nuevoNombre))
                {
                    MessageBox.Show("Por favor, ingresa un nuevo nombre válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string directorio = Path.GetDirectoryName(rutaOriginal);
                string nuevaRuta = Path.Combine(directorio, nuevoNombre);

                try
                {
                    if (File.Exists(rutaOriginal))
                    {
                        File.Move(rutaOriginal, nuevaRuta);
                        MessageBox.Show("Archivo renombrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Directory.Exists(rutaOriginal))
                    {
                        Directory.Move(rutaOriginal, nuevaRuta);
                        MessageBox.Show("Carpeta renombrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El elemento seleccionado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // Actualizar el ListView para reflejar los cambios
                    LoadFolder(textBoxPath.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al renombrar el elemento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un archivo o carpeta para cambiar el nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void listViewArchivos_DoubleClick(object sender, EventArgs e)
        {

            if (listViewArchivos.SelectedItems.Count > 0)
            {
                var selectedItem = listViewArchivos.SelectedItems[0];
                string path = selectedItem.Tag.ToString();

                if (Directory.Exists(path))
                {
                    // Si es una carpeta, cargar su contenido en el mismo ListView
                    LoadFolder(path);
                }
                else if (File.Exists(path))
                {
                    // Si es un archivo, abrirlo con el programa predeterminado
                    try
                    {
                        System.Diagnostics.Process.Start(path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al abrir el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }



        private void buttonCopiarNombre_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBoxCopiarNombre.Text))
            {
                try
                {
                    // Copiar el texto al portapapeles
                    Clipboard.SetText(textBoxCopiarNombre.Text);
                    MessageBox.Show("El nombre ha sido copiado al portapapeles.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al copiar al portapapeles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un archivo o carpeta primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void buttonCargar_Click(object sender, EventArgs e)
        {
            string ruta = textBoxPath.Text;

            if (string.IsNullOrWhiteSpace(ruta))
            {
                MessageBox.Show("Por favor, ingresa una ruta válida.", "Ruta Vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadFolder(ruta);
        }

        private void buttonCrearCarpeta_Click(object sender, EventArgs e)
        {
            string ruta = textBoxPath.Text;
            string nuevaCarpeta = textBoxCrearCarpeta.Text;

            if (string.IsNullOrWhiteSpace(ruta) || string.IsNullOrWhiteSpace(nuevaCarpeta))
            {
                MessageBox.Show("Por favor, especifica una ruta y un nombre para la carpeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string carpetaCompleta = Path.Combine(ruta, nuevaCarpeta);

            try
            {
                Directory.CreateDirectory(carpetaCompleta);
                MessageBox.Show("Carpeta creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFolder(ruta); // Actualizar el contenido del ListView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la carpeta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCrearArchivo_Click(object sender, EventArgs e)
        {
            string ruta = textBoxPath.Text;
            string nuevoArchivo = textBoxCrearArchivo.Text;

            if (string.IsNullOrWhiteSpace(ruta) || string.IsNullOrWhiteSpace(nuevoArchivo))
            {
                MessageBox.Show("Por favor, especifica una ruta y un nombre para el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string archivoCompleto = Path.Combine(ruta, nuevoArchivo);

            try
            {
                File.Create(archivoCompleto).Dispose(); // Crear archivo vacío
                MessageBox.Show("Archivo creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFolder(ruta); // Actualizar el contenido del ListView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonEliminarArchivo_Click(object sender, EventArgs e)
        {
            string rutaSeleccionada;

            if (listViewArchivos.SelectedItems.Count > 0)
            {
                rutaSeleccionada = listViewArchivos.SelectedItems[0].Tag.ToString();
            }
            else if (!string.IsNullOrWhiteSpace(textBoxEliminarArchivo.Text))
            {
                rutaSeleccionada = Path.Combine(textBoxPath.Text, textBoxEliminarArchivo.Text);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un elemento o ingresa un nombre en el TextBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Directory.Exists(rutaSeleccionada))
                {
                    Directory.Delete(rutaSeleccionada, true);
                    MessageBox.Show("Carpeta eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxEliminarArchivo.Clear();
                }
                else if (File.Exists(rutaSeleccionada))
                {
                    File.Delete(rutaSeleccionada);
                    MessageBox.Show("Archivo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxEliminarArchivo.Clear();
                }
                else
                {
                    MessageBox.Show("El elemento no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxEliminarArchivo.Clear();
                }

                LoadFolder(textBoxPath.Text); // Actualizar contenido
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el elemento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SortListView()
        {
            if (comboBoxOrdenar.SelectedItem == null)
                return;

            string sortBy = comboBoxOrdenar.SelectedItem.ToString();

            List<ListViewItem> items = listViewArchivos.Items.Cast<ListViewItem>().ToList();

            switch (sortBy)
            {
                case "Nombre":
                    items = items.OrderBy(item => item.Text).ToList();
                    break;
                case "Fecha de creación":
                    items = items.OrderBy(item => File.GetCreationTime(item.Tag.ToString())).ToList();
                    break;
                case "Tipo":
                    items = items.OrderBy(item => Path.GetExtension(item.Tag.ToString())).ToList();
                    break;
            }

            listViewArchivos.Items.Clear();
            listViewArchivos.Items.AddRange(items.ToArray());
        }

        private void comboBoxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortListView();
        }

        private bool ShouldIncludeItem(ListViewItem item, string filter)
        {
            string filePath = item.Tag.ToString();

            switch (filter)
            {
                case "Solo JSON":
                    return Path.GetExtension(filePath).Equals(".json", StringComparison.OrdinalIgnoreCase);
                case "Solo Carpetas":
                    return Directory.Exists(filePath);
                case "Solo Archivos":
                    return File.Exists(filePath);
                default: // "Todos"
                    return true;
            }
        }


        private void comboBoxFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentPath = textBoxPath.Text;
            string selectedFilter = comboBoxFiltrar.SelectedItem?.ToString() ?? "Todos";

            LoadFolder(currentPath, selectedFilter);
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            string currentPath = textBoxPath.Text;

            // Verificar si la ruta es válida
            if (Directory.Exists(currentPath))
            {
                // Obtener la unidad y la ruta completa
                string root = Path.GetPathRoot(currentPath); // Obtener la unidad (ej. C:\)
                string relativePath = currentPath.Substring(root.Length); // Obtener el resto de la ruta

                // Dividir la ruta relativa en partes
                var parts = relativePath.Split(Path.DirectorySeparatorChar);

                // Verificar que haya más de una parte
                if (parts.Length > 0)
                {
                    // Eliminar la última parte
                    string newRelativePath = string.Join(Path.DirectorySeparatorChar.ToString(), parts, 0, parts.Length - 1);

                    // Si se elimina todo, mantener la raíz
                    if (string.IsNullOrEmpty(newRelativePath))
                    {
                        newRelativePath = ""; // Mantener la raíz
                    }

                    string newPath = Path.Combine(root, newRelativePath); // Combinar la unidad con la nueva ruta
                    LoadFolder(newPath); // Cargar la nueva carpeta
                }
                else
                {
                    MessageBox.Show("No se puede retroceder más.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("La ruta actual no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}