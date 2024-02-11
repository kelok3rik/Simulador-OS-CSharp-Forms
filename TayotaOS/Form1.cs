using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TayotaOS
{
    public partial class Form1 : Form
    {
        // crear objeto de Administrador de Tareas
        Pantallas.AdministradorTareas adminTareas = new Pantallas.AdministradorTareas();
        Pantallas.ReproductorMusica reproductorMusica = new Pantallas.ReproductorMusica();
        Pantallas.BlocNotas BlocNotas = new Pantallas.BlocNotas();
        Pantallas.Navegador navegador = new Pantallas.Navegador();
        Pantallas.Carpetas carpetas = new Pantallas.Carpetas();



        
        public Form1()
        {
            InitializeComponent();

            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.WindowState = FormWindowState.Maximized;


            // Configurar temporizador para actualizar la hora cada segundo
            Timer timer = new Timer();
            timer.Interval = 1000; // 1000 milisegundos = 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Actualizar la hora
            labelHora.Text = DateTime.Now.ToString("hh:mm:ss tt");

            // Actualizar el texto del label con la fecha actual
            labelFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");


        }

       


        private void btnProcesos_Click(object sender, EventArgs e)
        {
            // abrir el administrador de tarea en un hilo aparte y ver cuantos recursos consume
           
            
            
                adminTareas.Show();
            
         
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reproductorMusica.Show();

        }

        private void btnEditorTexto_Click(object sender, EventArgs e)
        {
            BlocNotas.Show();

        }

        private void btnNavegador_Click(object sender, EventArgs e)
        {
            navegador.Show();
        }

        private void btnCarpetas_Click(object sender, EventArgs e)
        {
            carpetas.Show();


        }
    }
}
