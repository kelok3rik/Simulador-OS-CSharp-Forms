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
        public BlocNotas()
        {
            InitializeComponent();
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

        private void BlocNotas_Load(object sender, EventArgs e)
        {
            CargarArchivosTexto();
        }

        private void CargarArchivosTexto()
        {

           



            string folderPath = Path.Combine(Application.StartupPath, "Recursos/Notas");

            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("La carpeta de notas no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] archivos = Directory.GetFiles(folderPath, "*.txt");

            foreach (string archivo in archivos)
            {
                string nombreArchivo = Path.GetFileName(archivo);
                dataGridView1.Rows.Add(nombreArchivo);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            string nombreArchivo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string rutaArchivo = Path.Combine(Application.StartupPath, "Recursos/Notas", nombreArchivo);

            if (File.Exists(rutaArchivo))
            {
                string contenido = File.ReadAllText(rutaArchivo);
                richTextBox1.Text = contenido;
            }
            else
            {
                MessageBox.Show("No se encontró el archivo en la ruta " + rutaArchivo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
           
        }
    }
}
