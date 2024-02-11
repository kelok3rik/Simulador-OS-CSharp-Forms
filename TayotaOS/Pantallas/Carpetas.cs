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
    public partial class Carpetas : Form
    {

        string rutaDirectorio = "Recursos";
        public Carpetas()
        {
            InitializeComponent();
            CargarCarpetas(rutaDirectorio);

            Console.WriteLine("Buscando en "+rutaDirectorio );
           

        }

        private void CargarCarpetas(string rutaDirectorio)
        {
            // Verificar si la ruta especificada es un directorio
            if (Directory.Exists(rutaDirectorio))
            {
                // Obtener todas las carpetas y archivos dentro del directorio
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
            }
            else
            {
                MessageBox.Show("La ruta especificada no es un directorio válido.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se seleccionó una carpeta
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la ruta de la carpeta seleccionada
                string carpetaSeleccionada = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                // Verificar si la carpeta seleccionada es la carpeta "Papelera"
                if (carpetaSeleccionada.Equals("Recursos/Papelera", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("La carpeta seleccionada ya está en la 'Papelera'.");
                    return;
                }

                // Mover la carpeta seleccionada a la carpeta "Papelera"
                string rutaPapelera = "Recursos/Papelera";
                string nombreCarpeta = Path.GetFileName(carpetaSeleccionada);
                string nuevaRuta = Path.Combine(rutaPapelera, nombreCarpeta);

                try
                {
                    Directory.Move(carpetaSeleccionada, nuevaRuta);
                    CargarCarpetas("Recursos"); // Actualizar el DataGridView
                    MessageBox.Show("Carpeta enviada a la Papelera exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al enviar la carpeta a la Papelera: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una carpeta para enviar a la Papelera.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nuevaNombreCarpeta = txtNombreCarpeta.Text.Trim();
                string carpetaSeleccionada = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string rutaDirectorio = Path.GetDirectoryName(carpetaSeleccionada);
                string nuevaRutaCarpeta = Path.Combine(rutaDirectorio, nuevaNombreCarpeta);

                try
                {
                    Directory.Move(carpetaSeleccionada, nuevaRutaCarpeta);
                    CargarCarpetas(rutaDirectorio);
                    MessageBox.Show("Carpeta renombrada exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al renombrar la carpeta: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una carpeta para editar.");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

            if (Directory.Exists(rutaDirectorio))
            {
                string nombreNuevaCarpeta = txtNombreCarpeta.Text.Trim(); // Obtener el nombre de la nueva carpeta

                // Crear la ruta completa para la nueva carpeta
                string rutaNuevaCarpeta = Path.Combine(rutaDirectorio, nombreNuevaCarpeta);

                try
                {
                    Directory.CreateDirectory(rutaNuevaCarpeta); // Crear la nueva carpeta en la ruta especificada
                    CargarCarpetas(rutaDirectorio); // Actualizar el DataGridView
                    MessageBox.Show("Carpeta agregada exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar la carpeta: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("La ruta especificada no es un directorio válido.");
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if (dataGridView != null && dataGridView.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView.SelectedCells[0].RowIndex;

                // Obtener la ruta de la carpeta seleccionada en la primera celda de la fila
                string carpetaSeleccionada = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();

                // Cargar el contenido de la carpeta seleccionada
                CargarCarpetas(carpetaSeleccionada);
            }
        }
    }
}
