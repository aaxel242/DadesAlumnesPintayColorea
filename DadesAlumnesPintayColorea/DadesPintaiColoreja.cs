using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Dades_Alumnes_Joc_Pintar
{
    public partial class formJocPintar : Form
    {
        private PictureBox pictureBox;
        private string filePath;
        private bool mostrarImagen = true;
        private string nomArxiu;
        private string nouNomArxiu;

        //Metodos Click Eventos
        public formJocPintar()
        {
            InitializeComponent();
        }
        private void btnAfegirFila_Click_1(object sender, EventArgs e)
        {
            afegirFila();
        }
        private void btnEliminarFila_Click_1(object sender, EventArgs e)
        {
            EliminarFila();
        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            guardarArxiu();
        }
        private void btnObrirArxiu_Click_1(object sender, EventArgs e)
        {
            obrirArxiu();
        }
        private void pBoxAfegir_Click(object sender, EventArgs e)
        {
            obrirArxiu();
        }
        private void btnSortir_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void btnEditarArxiu_Click(object sender, EventArgs e)
        {
            EditarArxiu();
        }
        private void btnConfirmarNomArxiu_Click(object sender, EventArgs e)
        {
            cambiarNomArxiu();
        }
        private void btnEliminarArxiu_Click(object sender, EventArgs e)
        {
            EliminarArxiu();
        }

        // Metodos principales
        private void afegirFila()
        {
            ValidarArxiuCargat();

            try
            {
                DataTable taula = (DataTable)panelJSON.DataSource;
                DataRow fila = taula.NewRow();
                taula.Rows.Add(fila);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error al afegir una fila: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EliminarFila()
        {
            if (panelJSON.SelectedRows.Count > 0)
            {
                try
                {
                    DataTable dataTable = (DataTable)panelJSON.DataSource;

                    foreach (DataGridViewRow row in panelJSON.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            dataTable.Rows.RemoveAt(row.Index);
                        }
                    }

                    panelJSON.DataSource = null;
                    panelJSON.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error al eliminar. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this, "Selecciona una fila.", "Missatge", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void guardarArxiu()
        {
            ValidarArxiuCargat();
            try
            {
                DataTable json = (DataTable)panelJSON.DataSource;
                JArray jsonArray = new JArray();
                foreach (DataRow fila in json.Rows)
                {
                    JObject obj = new JObject();
                    foreach (DataColumn columna in json.Columns)
                    {
                        obj[columna.ColumnName] = JToken.FromObject(fila[columna]);
                    }
                    jsonArray.Add(obj);
                }

                string archivoAJSON = jsonArray.ToString();
                File.WriteAllText(filePath, archivoAJSON);
                MessageBox.Show(this, "L'arxiu s'ha guardat correctament.", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error al guardar l'arxiu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditarArxiu()
        {
            MostrarElementsEditarArxiu();
            ConfiguracioTextBox();
            BloquejarBotoEditarArxiu();
        }
        private void cambiarNomArxiu()
        {
            if (!string.IsNullOrWhiteSpace(txtBoxEditarNomArxiu.Text))
            {
                nouNomArxiu = txtBoxEditarNomArxiu.Text;
                lblNomArxiu.Text = nouNomArxiu;
                lblNomArxiu.Visible = true;
                lblNomArxiu.Invalidate();
                lblNomArxiu.Refresh();

                try
                {
                    nouNomArxiu = txtBoxEditarNomArxiu.Text.Trim();
                    string newFilePath = Path.Combine(Path.GetDirectoryName(filePath), $"{nouNomArxiu}.json");

                    if (File.Exists(newFilePath))
                    {
                        MessageBox.Show(this, "Ja existeix un arxiu amb aquest nom.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    File.Move(filePath, newFilePath);
                    filePath = newFilePath;
                    lblNomArxiu.Text = nouNomArxiu;
                    MessageBox.Show(this, "Nom de l'arxiu canviat correctament.", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cambiar el nom de l'arxiu " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("El nom del arxiu no pot estar buit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void EliminarArxiu()
        {
            ValidarArxiuCargat();

            DialogResult confirmResult = MessageBox.Show(
                "Estàs segur que vols eliminar aquest arxiu?",
                "Confirmació d'eliminació",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    File.Delete(filePath);
                    filePath = null;

                    if (panelJSON.DataSource != null)
                    {
                        ((DataTable)panelJSON.DataSource).Clear();
                        panelJSON.DataSource = null;
                    }

                    OcultarElementsEditarArxiu();
                    
                    MessageBox.Show(this, "L'arxiu s'ha eliminat correctament.", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error al eliminar l'arxiu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void obrirArxiu()
        {
            string nuevoFilePath;
            if (!MostrarExploradorDArxius(out nuevoFilePath)) return;

            if (!ProcessarNouArxiu(nuevoFilePath, out DataTable dataTable)) return;

            LimpiarDatosAnteriores();
            CargarNuevoArchivo(nuevoFilePath, dataTable);
            ConfigurarControlesDespuesDeCargar();
        }

        //Submetodos
        private bool ValidarArxiuCargat()
        {
            // Verificar si el archivo está cargado
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show(this, "Siusplau, obre un arxiu.", "Missatge", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verificar si el DataTable asociado a DataGridView tiene datos
            if (panelJSON.DataSource == null || ((DataTable)panelJSON.DataSource).Rows.Count == 0)
            {
                MessageBox.Show(this, "No hi ha dades carregades. Si us plau, obriu un arxiu.", "Missatge", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void MostrarElementsEditarArxiu()
        {
            lblNomArxiu.Visible = true;
            txtBoxEditarNomArxiu.Visible = true;
            pBoxTituloEditarArxiu.Visible = true;
            btnConfirmarNomArxiu.Visible = true;
            btnEliminarArxiu.Visible = true;
            pBoxEditarArxiu.Visible = true;
        }
        private void BloquejarBotoEditarArxiu()
        {
            if (pBoxEditarArxiu.Visible &&
               pBoxTituloEditarArxiu.Visible &&
               lblNomArxiu.Visible &&
               txtBoxEditarNomArxiu.Visible &&
               btnConfirmarNomArxiu.Visible)
            {
                btnEditarArxiu.Enabled = false;
            }
        }
        private void ConfiguracioTextBox()
        {
            txtBoxEditarNomArxiu.Text = "Canviar nom d'arxiu";
            txtBoxEditarNomArxiu.ForeColor = Color.Gray;

            txtBoxEditarNomArxiu.Enter += (s, ev) =>
            {
                if (txtBoxEditarNomArxiu.Text == "Canviar nom d'arxiu")
                {
                    txtBoxEditarNomArxiu.Text = "";
                    txtBoxEditarNomArxiu.ForeColor = Color.Black;
                }
            };

            txtBoxEditarNomArxiu.Leave += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtBoxEditarNomArxiu.Text))
                {
                    txtBoxEditarNomArxiu.Text = $"{nomArxiu}";
                    txtBoxEditarNomArxiu.ForeColor = Color.Black;
                }
            };

            // Capturar Enter y procesar el cambio
            txtBoxEditarNomArxiu.KeyPress += (s, ev) =>
            {
                if (ev.KeyChar == (char)13) // Enter key
                {
                    ev.Handled = true; // Evitar el sonido de "ding" al presionar Enter
                    cambiarNomArxiu();
                }
            };
        }
        private void OcultarElementsEditarArxiu()
        {
            txtBoxEditarNomArxiu.Text = " ";
            lblNomArxiu.Text = " ";
            pBoxEditarArxiu.Visible = false;
            lblNomArxiu.Visible = false;
            txtBoxEditarNomArxiu.Visible = false;
            btnEliminarArxiu.Visible = false;
            btnConfirmarNomArxiu.Visible = false;
            pBoxTituloEditarArxiu.Visible = false;
            btnEditarArxiu.Visible = false;
            btnAfegirFila.Visible = false;
            btnEliminarFila.Visible = false;
            btnGuardar.Visible = false;
        }
        private bool MostrarExploradorDArxius(out string nuevoFilePath)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos JSON (*.json)|*.json",
                Title = "Selecciona l'arxiu"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                nuevoFilePath = openFileDialog.FileName;
                return true;
            }

            nuevoFilePath = null;
            return false;
        }
        private bool ProcessarNouArxiu(string filePath, out DataTable dataTable)
        {
            dataTable = null;

            try
            {
                string fileJson = File.ReadAllText(filePath);
                JArray jsonArray = JArray.Parse(fileJson);
                dataTable = CrearTablaDesdeJSON(jsonArray);  
                return true;
            }
            catch (JsonReaderException jsonEx)
            {
                MessageBox.Show(this, "Error al parsear el archivo JSON: " + jsonEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ioEx)
            {
                MessageBox.Show(this, "Error de entrada/salida: " + ioEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error al cargar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
        private DataTable CrearTablaDesdeJSON(JArray jsonArray)
        {
            DataTable dataTable = new DataTable();

            foreach (JObject obj in jsonArray)
            {
                foreach (JProperty property in obj.Properties())
                {
                    if (!dataTable.Columns.Contains(property.Name))
                    {
                        dataTable.Columns.Add(property.Name);
                    }
                }
            }

            foreach (JObject obj in jsonArray)
            {
                DataRow row = dataTable.NewRow();
                foreach (JProperty property in obj.Properties())
                {
                    row[property.Name] = property.Value;
                }
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
        private void LimpiarDatosAnteriores()
        {
            if (panelJSON.DataSource != null)
            {
                ((DataTable)panelJSON.DataSource).Clear();
                panelJSON.DataSource = null;
            }
        }
        private void CargarNuevoArchivo(string nuevoFilePath, DataTable dataTable)
        {
            filePath = nuevoFilePath; // Aquí se actualiza la ruta correctamente
            nomArxiu = Path.GetFileNameWithoutExtension(nuevoFilePath); // Actualiza el nombre del archivo
            panelJSON.DataSource = dataTable; // Asignar datos al DataGridView
        }
        private void ConfigurarControlesDespuesDeCargar()
        {
            // Configuracions visuals del DataGridView
            panelJSON.DefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Regular);
            panelJSON.DefaultCellStyle.ForeColor = Color.Black;

            panelJSON.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
            panelJSON.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            panelJSON.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            panelJSON.EnableHeadersVisualStyles = false;

            panelJSON.RowHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
            panelJSON.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            panelJSON.RowHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Italic);

            panelJSON.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            panelJSON.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            panelJSON.AutoResizeColumns();
            panelJSON.AutoResizeRows();

            //Configuració elements visibles
            btnEditarArxiu.Visible = true;
            btnAfegirFila.Visible = true;
            btnEliminarFila.Visible = true;
            btnGuardar.Visible = true;
            pBoxAfegir.Visible = false;

            pBoxEditarArxiu.Visible = false;
            lblNomArxiu.Visible = false;
            txtBoxEditarNomArxiu.Visible = false;
            btnEliminarArxiu.Visible = false;
            btnConfirmarNomArxiu.Visible = false;
            pBoxTituloEditarArxiu.Visible = false;
            btnEditarArxiu.Enabled = true;

            //Configura nom del label
            lblNomArxiu.Text = $"{nomArxiu}";
            lblNomArxiu.Font = new Font("Tahoma", 18, FontStyle.Regular);
            lblNomArxiu.ForeColor = Color.Black;
        }
        private void btnObrirExplorador_Click(object sender, EventArgs e)
        {
            formExplorador formulariExplorador = new formExplorador();
            formulariExplorador.ShowDialog();
        }
        public void LoadJsonToDataGridView(string filePath)
        {
            try
            {
                // Intentamos obtener la instancia existente de FormJocPintar
                formJocPintar formJocPintarInstance = Application.OpenForms.OfType<formJocPintar>().FirstOrDefault();

                if (formJocPintarInstance == null)
                {
                    // Si no hay ninguna instancia abierta, creamos una nueva instancia
                    formJocPintarInstance = new formJocPintar();
                    formJocPintarInstance.Show();  // Mostrar el formulario
                }

                // Cargar el archivo JSON y convertirlo en un DataTable
                string jsonContent = File.ReadAllText(filePath); // Leer el contenido del archivo JSON

                var data = JsonConvert.DeserializeObject<DataTable>(jsonContent);

                if (data != null)
                {
                    // Asignar los datos al DataGridView dentro del formulario FormJocPintar
                    formJocPintarInstance.panelJSON.DataSource = data;
                    formJocPintarInstance.panelJSON.Visible = true; // Hacer visible el DataGridView
                }
                else
                {
                    MessageBox.Show("El archivo JSON no contiene datos válidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Llamar a ConfigurarControlesDespuesDeCargar() después de cargar los datos
                formJocPintarInstance.ConfigurarControlesDespuesDeCargar();

                // Cerrar el formulario actual (Form1)
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el archivo JSON: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
