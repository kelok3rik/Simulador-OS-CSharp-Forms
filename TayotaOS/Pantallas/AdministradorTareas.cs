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

namespace TayotaOS.Pantallas
{
    public partial class AdministradorTareas : Form
    {
        private TaskManager taskManager;
        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;
        private PerformanceCounter diskCounter;
        private PerformanceCounter networkCounter;
        private Timer timer;
        private Random random;



        public AdministradorTareas()
        {
            InitializeComponent();
            taskManager = new TaskManager();
            InitializePerformanceCounters();
            InitializeDataGridView();
            InitializeTimer();
            random = new Random();
        }


        private void InitializePerformanceCounters()
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            diskCounter = new PerformanceCounter("PhysicalDisk", "Disk Bytes/sec", "_Total");
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Add("FormName", "Procesos");
            dataGridView1.Columns.Add("CPUUsage", "uso CPU");
            dataGridView1.Columns.Add("MemoryUsage", "uso memoria (MB)");
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 2000; // Actualiza cada segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void AdministradorTareas_Load(object sender, EventArgs e)
        {
            RefreshTaskList();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            float cpuUsage = cpuCounter.NextValue();
            float ramUsage = 16000 - ramCounter.NextValue();
            float diskUsage = diskCounter.NextValue();

            

            label1.Text = $"CPU Usage: {cpuUsage}%";
            label2.Text = $"Memory Usage: {ramUsage} MB";
            label3.Text = $"Disk Usage: {diskUsage} MB/s";

            RefreshTaskList();
        }

        private void RefreshTaskList()
        {
            int totalCPU = 100;
            dataGridView1.Rows.Clear();
            foreach (var form in taskManager.GetOpenForms())
            {

                float cpuUsage = GetCpuUsage(form,totalCPU);
                float memoryUsage = GetMemoryUsage(form);

                dataGridView1.Rows.Add(form.Text, $"{cpuUsage:F2}%", $"{memoryUsage:F2}");

                totalCPU = totalCPU - (int)cpuUsage;
            }
        }

        

        private float GetCpuUsage(Form form, int sobranteTayota)
        {
           
           
            return (float)random.NextDouble() * sobranteTayota; // Uso de CPU aleatorio entre 0 y 100
        }

        private float GetMemoryUsage(Form form)
        {
            
           
            return (float)random.Next(0, 1000); // Uso de memoria aleatorio entre 0 y 1000 MB
        }


        public class TaskManager
        {
            public Form[] GetOpenForms()
            {
                return Application.OpenForms.Cast<Form>().ToArray(); // Utiliza Cast y ToArray de LINQ
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshTaskList();
        }
    }
}
