using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TayotaOS.Pantallas
{
    public partial class Navegador : Form
    {
        public Navegador()
        {
            InitializeComponent();
        }

        private void Navegador_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }

        private async Task Initialized()
        {
            await webView.EnsureCoreWebView2Async(null);
        }

        private async void InitBrowser()
        {
            await Initialized();
           
            webView.CoreWebView2.Navigate("https://www.google.com");
        }
    }
}
