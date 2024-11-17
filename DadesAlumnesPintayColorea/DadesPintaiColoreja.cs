using System;
using System.Data;
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


        public formJocPintar()
        {
            InitializeComponent();

        }

        private void btnAfegirFila_Click(object sender, EventArgs e)
        {
         
        }

        private void btnEliminarFila_Click(object sender, EventArgs e)
        {
          
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
        
        }

        private void btnObrirArxiu_Click(object sender, EventArgs e)
        {
           
        }


        private void btnSortir_Click(object sender, EventArgs e)
        {
        }

        private void btnAfegirFila_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Siusplau, obre un arxiu.");
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
                MessageBox.Show("Error al afegir una fila: " + ex.Message);
            }
        }

        private void btnEliminarFila_Click_1(object sender, EventArgs e)
        {
            if (panelJSON.DataSource == null)
            {
                MessageBox.Show("Siusplau, obre un arxiu.");
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
                    MessageBox.Show("Error al eliminar. " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila.");
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Siusplau, obre un arxiu.");
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

                MessageBox.Show("L'arxiu s'ha guardat correctament.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar l'arxiu: " + ex.Message);
            }
        }

        private void btnObrirArxiu_Click_1(object sender, EventArgs e)
        {
            if (panelJSON.DataSource != null)
            {
                ((DataTable)panelJSON.DataSource).Clear();
                panelJSON.DataSource = null;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos JSON (*.json)|*.json";
            openFileDialog.Title = "Selecciona l'arxiu";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                try
                {
                    string fileJson = File.ReadAllText(filePath);
                    JArray jsonArray = JArray.Parse(fileJson);
                    DataTable dataTable = new DataTable();

                    // Adding columns dynamically
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

                    // Adding rows to the DataTable
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
                }
                catch (JsonReaderException jsonEx)
                {
                    MessageBox.Show("Error al parsear el archivo JSON: " + jsonEx.Message);
                }
                catch (IOException ioEx)
                {
                    MessageBox.Show("Error de entrada/salida: " + ioEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el archivo: " + ex.Message);
                }
            }
        }

        private void btnSortir_Click_1(object sender, EventArgs e)
        {
            Close();

        }

        






        // private void panelJSON_Paint(object sender, PaintEventArgs e)
        //{
        //   if (mostrarImagen && Properties.Resources.imgAfegir != null)
        //  {
        //     e.Graphics.DrawImage(Properties.Resources.imgAfegir, new Point(100, 10));
        //}
        //        }


    }
}
