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

namespace TayotaOS.Pantallas
{
    public partial class ReproductorMusica : Form
    {
        public ReproductorMusica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             string rutaCancion = "Recursos/Musica/sonido.mp3";


            if (File.Exists(rutaCancion))
            {
                MediaPlayer.URL = rutaCancion;
                MediaPlayer.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("No se encontró la canción EN LA ruta "+ rutaCancion);
                
            }
        }

        private void ReproductorMusica_Load(object sender, EventArgs e)
        {
            CargarCanciones();
        }

        private void CargarCanciones()
        {
            string carpetaMusica = "Recursos/Musica/"; // Carpeta donde están las canciones
            string rutaCompleta = Path.Combine(Application.StartupPath, carpetaMusica);

            if (!Directory.Exists(rutaCompleta))
            {
                MessageBox.Show("La carpeta de música no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] archivos = Directory.GetFiles(rutaCompleta, "*.mp3"); // Obtener archivos de música
            foreach (string archivo in archivos)
            {
                string nombreCancion = Path.GetFileName(archivo);
                dataGridViewCanciones.Rows.Add(nombreCancion);
            }
        }

        private void dataGridViewCanciones_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridViewCanciones.SelectedRows.Count == 0)
            {
                return;
            }

            string nombreCancion = dataGridViewCanciones.SelectedRows[0].Cells[0].Value.ToString();
            string rutaCancion = Path.Combine(Application.StartupPath, "Recursos/Musica", nombreCancion);

            if (File.Exists(rutaCancion))
            {
                MediaPlayer.URL = rutaCancion;
                MediaPlayer.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("No se encontró la canción EN LA ruta " + rutaCancion);

            }
        }
    }
}
