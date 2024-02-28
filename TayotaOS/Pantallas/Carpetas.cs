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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TayotaOS.Pantallas
{
    public partial class Carpetas : Form
    {
        private Stack<string> historialDeRutas = new Stack<string>();


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

            if (dataGridView1.SelectedRows.Count > 0)
            {
                string rutaActual = historialDeRutas.Peek(); // Obtener la ruta actual del historial
                string nombreNuevaCarpeta = txtNombreCarpeta.Text.Trim(); // Obtener el nombre de la nueva carpeta
                string rutaNuevaCarpeta = Path.Combine(rutaActual, nombreNuevaCarpeta); // Crear la ruta completa para la nueva carpeta

                try
                {
                    Directory.CreateDirectory(rutaNuevaCarpeta); // Crear la nueva carpeta en la ruta especificada
                    CargarCarpetas(rutaActual); // Actualizar el DataGridView
                    MessageBox.Show("Carpeta agregada exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar la carpeta: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una carpeta para agregar una nueva carpeta.");
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
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
                            txtEditorTexto.Text = contenido;

                            // Obtener y mostrar el nombre del archivo en otro TextBox
                            string nombreArchivo = Path.GetFileName(elementoSeleccionado);
                            txtnombreArchivoTxt.Text = nombreArchivo;

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

        private void btnAgregarTxt_Click(object sender, EventArgs e)
        {
            // Obtener la ruta del directorio actual
            string directorioActual = historialDeRutas.Peek();

            try
            {
                // Generar un nombre único para el archivo .txt
                string nombreArchivo = txtnombreArchivoTxt.Text;
                string rutaCompleta = Path.Combine(directorioActual, nombreArchivo);

                // Verificar si el archivo ya existe y agregar un número para hacerlo único si es necesario
                int contador = 1;
                while (File.Exists(rutaCompleta))
                {
                    nombreArchivo = $"nuevo_archivo_{contador}.txt";
                    rutaCompleta = Path.Combine(directorioActual, nombreArchivo);
                    contador++;
                }

                // Crear un archivo .txt vacío en la ruta especificada
                File.Create(rutaCompleta).Close();

                MessageBox.Show($"Archivo '{nombreArchivo}' creado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el archivo: " + ex.Message);
            }
        }
    }
}
