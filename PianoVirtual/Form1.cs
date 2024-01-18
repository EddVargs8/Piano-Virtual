using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PianoVirtual
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void BtnLibre_Click(object sender, EventArgs e)
        {
            Libre libre = new Libre();  
            libre.Show();
        }

        private void BtnNotas_Click(object sender, EventArgs e)
        {
            Notas notas = new Notas();
            notas.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
