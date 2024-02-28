using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TayotaOS.Pantallas
{
    public partial class BlocNotas : Form
    {

        private Stack<string> historialDeRutas = new Stack<string>();
        string rutaDirectorio = "Recursos";

        public BlocNotas()
        {
            InitializeComponent();
            CargarCarpetas(rutaDirectorio);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = txtNombreArchivo.Text;

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Por favor, ingrese un nombre de archivo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string folderPath = Path.Combine(Application.StartupPath, "Recursos/Notas");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            fileName += ".txt";

            string filePath = Path.Combine(folderPath, fileName);

            File.WriteAllText(filePath, richTextBox1.Text);

            MessageBox.Show("Archivo guardado en: " + filePath, "Guardar archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridView1.Rows.Add(fileName);

            txtNombreArchivo.Text = "";


            
        }

        
        

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            string nombreArchivo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string rutaArchivo = Path.Combine(Application.StartupPath, "Recursos/Notas", nombreArchivo);

            if (File.Exists(rutaArchivo))
            {
                File.Delete(rutaArchivo);
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                richTextBox1.Text = "";
            }
            else
            {
                MessageBox.Show("No se encontró el archivo en la ruta " + rutaArchivo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCarpetas(string rutaDirectorio)
        {

            // Verificar si la ruta especificada es un directorio
            if (Directory.Exists(rutaDirectorio))
            {
                string[] carpetasYArchivos = Directory.GetFileSystemEntries(rutaDirectorio);

                // Limpiar el DataGridView antes de cargar nuevos datos
                dataGridView1.Rows.Clear();

                // Agregar cada carpeta o archivo al DataGridView
                foreach (string item in carpetasYArchivos)
                {
                    // Obtener el nombre del archivo o carpeta
                    string nombreItem = Path.GetFileName(item);

                    // Agregar el nombre del archivo o carpeta al DataGridView
                    dataGridView1.Rows.Add(nombreItem, item);
                }

                // Actualizar el historial de rutas con la nueva ruta
                historialDeRutas.Push(rutaDirectorio);
            }
            else
            {
                MessageBox.Show("La ruta especificada no es un directorio válido.");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            openFileDialog.Title = "Abrir archivo de texto";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                string contenido = File.ReadAllText(rutaArchivo);
                richTextBox1.Text = contenido;
            }
        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if (dataGridView != null && dataGridView.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView.SelectedCells[0].RowIndex;

                // Obtener la ruta del elemento seleccionado en la primera celda de la fila
                string elementoSeleccionado = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();

                if (File.Exists(elementoSeleccionado))
                {
                    if (Path.GetExtension(elementoSeleccionado).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        try
                        {
                            // Leer el contenido del archivo .txt
                            string contenido = File.ReadAllText(elementoSeleccionado);

                            // Mostrar el contenido en un TextBox
                            richTextBox1.Text = contenido;

                            // Obtener y mostrar el nombre del archivo (sin la extensión .txt) en otro TextBox
                            string nombreArchivoSinExtension = Path.GetFileNameWithoutExtension(elementoSeleccionado);
                            txtNombreArchivo.Text = nombreArchivoSinExtension;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al leer el archivo: " + ex.Message);
                        }
                    }
                    // Si es un archivo, y no es .txt, no hacemos nada
                }
                else if (Directory.Exists(elementoSeleccionado))
                {
                    // Es un directorio, cargar el contenido del directorio
                    Console.WriteLine(elementoSeleccionado);
                    CargarCarpetas(elementoSeleccionado);
                }
            }
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (historialDeRutas.Count > 1) // Verificar si hay rutas anteriores en el historial
            {
                // Eliminar la ruta actual del historial
                historialDeRutas.Pop();
                // Obtener la ruta del directorio anterior
                string rutaAnterior = historialDeRutas.Peek();
                // Cargar el contenido del directorio anterior
                CargarCarpetas(rutaAnterior);
            }
            else
            {
                MessageBox.Show("No hay directorios anteriores en el historial.");
            }
        }
    }
}
