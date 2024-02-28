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
           
            
                
                Pantallas.AdministradorTareas adminTareas = new Pantallas.AdministradorTareas();
                adminTareas.Show();
            
         
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantallas.ReproductorMusica reproductorMusica = new Pantallas.ReproductorMusica();
            reproductorMusica.Show();

        }

        private void btnEditorTexto_Click(object sender, EventArgs e)
        {
            Pantallas.BlocNotas BlocNotas = new Pantallas.BlocNotas();
            BlocNotas.Show();

        }

        private void btnNavegador_Click(object sender, EventArgs e)
        {
            Pantallas.Navegador navegador = new Pantallas.Navegador();
            navegador.Show();
        }

        private void btnCarpetas_Click(object sender, EventArgs e)
        {
            Pantallas.Carpetas carpetas = new Pantallas.Carpetas();
            carpetas.Show();


        }
    }
}
