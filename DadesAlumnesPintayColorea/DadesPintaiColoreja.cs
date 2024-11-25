using System;
using System.Data;
using System.Drawing;
using System.IO;
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

        public formJocPintar()
        {
            InitializeComponent();
        }

        private void btnAfegirFila_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show(this, "Siusplau, obre un arxiu.", "Missatge", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        private void btnEliminarFila_Click_1(object sender, EventArgs e)
        {
            if (panelJSON.DataSource == null)
            {
                MessageBox.Show(this, "Siusplau, obre un arxiu.", "Missatge", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show(this, "Siusplau, obre un arxiu.", "Missatge", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        private void btnObrirArxiu_Click_1(object sender, EventArgs e)
        {
            pBoxAfegir.Enabled = true;
            pBoxAfegir.Visible = true;

            if (panelJSON.DataSource != null)
            {
                ((DataTable)panelJSON.DataSource).Clear();
                panelJSON.DataSource = null;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos JSON (*.json)|*.json",
                Title = "Selecciona l'arxiu"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                nomArxiu = Path.GetFileNameWithoutExtension(filePath);

                try
                {
                    string fileJson = File.ReadAllText(filePath);
                    JArray jsonArray = JArray.Parse(fileJson);
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

                    panelJSON.DataSource = dataTable;

                    // Configuraciones de estilo
                    panelJSON.DefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Regular);
                    panelJSON.DefaultCellStyle.ForeColor = Color.Black;

                    panelJSON.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
                    panelJSON.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    panelJSON.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
                    panelJSON.EnableHeadersVisualStyles = false;

                    panelJSON.RowHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
                    panelJSON.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
                    panelJSON.RowHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Italic);

                    // Ajustar el tamaño de las columnas y filas
                    panelJSON.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    panelJSON.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    // Opcional: Ajustar automáticamente las celdas cuando el contenido cambie
                    panelJSON.AutoResizeColumns();
                    panelJSON.AutoResizeRows();

                    // Configuración de visibilidad de controles


                    pBoxAfegir.Enabled = false;
                    pBoxAfegir.Visible = false;
                    lblNomArxiu.Visible = false;
                    pBoxEditarArxiu.Visible = false;
                    txtBoxEditarNomArxiu.Visible = false;
                    btnConfirmarNomArxiu.Visible = false;
                    pBoxTituloEditarArxiu.Visible = false;

                    btnAfegirFila.Visible = true;
                    btnEliminarFila.Visible = true;
                    btnGuardar.Visible = true;
                    btnEditarArxiu.Visible = true;

                    if (!string.IsNullOrEmpty(nomArxiu))
                    {
                        lblNomArxiu.Text = $"{nomArxiu}";
                        lblNomArxiu.Font = new Font("Tahoma", 18, FontStyle.Regular);
                        lblNomArxiu.ForeColor = Color.Black;
                        lblNomArxiu.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("El nombre del archivo no se pudo obtener.");
                    }
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
            }
        }


        private void btnSortir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditarArxiu_Click(object sender, EventArgs e)
        {
            lblNomArxiu.Visible = true;
            txtBoxEditarNomArxiu.Visible = true;
            pBoxTituloEditarArxiu.Visible = true;
            btnConfirmarNomArxiu.Visible = true;
            pBoxEditarArxiu.Visible = true;

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

            if (pBoxEditarArxiu.Visible &&
                pBoxTituloEditarArxiu.Visible &&
                lblNomArxiu.Visible &&
                txtBoxEditarNomArxiu.Visible &&
                btnConfirmarNomArxiu.Visible)
            {
                btnEditarArxiu.Enabled = false;
            }
        }

        private void btnConfirmarNomArxiu_Click(object sender, EventArgs e)
        {
            
           
            cambiarTextLabelNomArxiu();
        }

        private void cambiarTextLabelNomArxiu()
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
                catch { 
                
                }
            }
            else
            {
                MessageBox.Show("El nombre del archivo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
