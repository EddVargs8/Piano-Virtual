using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PianoVirtual
{
    public partial class Notas : Form
    {

        Button[] arrBotones = new Button[12];
        Piano piano = new Piano();

        public Notas()
        {
            InitializeComponent();

        }

        private void Notas_Load(object sender, EventArgs e)
        {
            String[] Negras = { "Db", "Eb", "_", "Gb", "Ab", "Bb" };
            String[] Blancas = { "C", "D", "E", "F", "G", "A", "B" };

            
            piano.CrearTeclasNegrasSE(Negras, this);
            piano.CrearTeclasBlancasSE(Blancas, this);
            arrayBot();
            Mensaje(); 
        }

        public async void CadNotas(String notas)
        {
            //String notasM = notas.ToUpper();
            String[] arrNotas = notas.Split(' ');

            for (int i = 0; i < arrNotas.Length; i++)
                for (int j = 0; j < arrBotones.Length; j++)
                {
                    if (arrNotas[i].Equals(arrBotones[j].Text))
                    {
                        await Task.Delay(1300);
                        piano.TeclaYSonido(arrBotones[j]);
                    }
                }
        }

        private void arrayBot()    //Recorre la forma para llenar el arreglo de botones activos en el form
        {
            foreach (Control c in Controls)
            {
                if (c.Name.Equals("C"))
                    arrBotones[0] = (Button)c;
                else if (c.Name.Equals("Db"))
                    arrBotones[1] = (Button)c;
                else if (c.Name.Equals("D"))
                    arrBotones[2] = (Button)c;
                else if (c.Name.Equals("Eb"))
                    arrBotones[3] = (Button)c;
                else if (c.Name.Equals("E"))
                    arrBotones[4] = (Button)c;
                else if (c.Name.Equals("F"))
                    arrBotones[5] = (Button)c;
                else if (c.Name.Equals("Gb"))
                    arrBotones[6] = (Button)c;
                else if (c.Name.Equals("G"))
                    arrBotones[7] = (Button)c;
                else if (c.Name.Equals("Ab"))
                    arrBotones[8] = (Button)c;
                else if (c.Name.Equals("A"))
                    arrBotones[9] = (Button)c;
                else if (c.Name.Equals("Bb"))
                    arrBotones[10] = (Button)c;
                else if (c.Name.Equals("B"))
                    arrBotones[11] = (Button)c;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CadNotas(textBox1.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public async void Mensaje()
        {
            await Task.Delay(500); // wait for 1 second
            MessageBox.Show("Ingresa en el cuadro de texto las notas tal cual aparecen en el piano y da click en el boton reproducir");
        }

    }
}
