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
    public partial class Libre : Form
    {
        Piano piano = new Piano();
        Button[] arrBotones = new Button[12];

        public Libre()
        {
            InitializeComponent();
            this.KeyPress += Tecla; 
        }

        private void Tecla (object sender, KeyPressEventArgs e)
        {
             

            char k = Char.ToLower(e.KeyChar); //Convierte la tecla presionada a lower case para solo tener 1 case en el switch

            foreach (Control c in Controls)
            {                                 //Recorre todo los controles en la forma para obtener el puntero del objeto button
                if (c.Name == "C")
                    arrBotones[0] = (Button)c;
                else if (c.Name == "Db")
                    arrBotones[1] = (Button)c;
                else if (c.Name == "D")
                    arrBotones[2] = (Button)c;
                else if (c.Name == "Eb")
                    arrBotones[3] = (Button)c;
                else if (c.Name == "E")
                    arrBotones[4] = (Button)c;
                else if (c.Name == "F")
                    arrBotones[5] = (Button)c;
                else if (c.Name == "Gb")
                    arrBotones[6] = (Button)c;
                else if (c.Name == "G")
                    arrBotones[7] = (Button)c;
                else if (c.Name == "Ab")
                    arrBotones[8] = (Button)c;
                else if (c.Name == "A")
                    arrBotones[9] = (Button)c; 
                else if (c.Name== "Bb")
                    arrBotones[10] = (Button)c;
                else if (c.Name == "B")
                    arrBotones[11] = (Button) c;

            }

            switch (k)   //Switch en base a la tecla presionada que llama al metodo pasando como referencia el puntero a el button activo
            {
                case 'a':
                    piano.TeclaYSonido(arrBotones[0]); 
                    break;
                case 'w':
                    piano.TeclaYSonido(arrBotones[1]);
                    break;
                case 's':
                    piano.TeclaYSonido(arrBotones[2]);
                    break;
                case 'e':
                    piano.TeclaYSonido(arrBotones[3]);
                    break;
                case 'd':
                    piano.TeclaYSonido(arrBotones[4]);
                    break;
                case 'f':
                    piano.TeclaYSonido(arrBotones[5]);
                    break;
                case 't':
                    piano.TeclaYSonido(arrBotones[6]);
                    break;
                case 'g':
                    piano.TeclaYSonido(arrBotones[7]);
                    break;
                case 'y':
                    piano.TeclaYSonido(arrBotones[8]);
                    break;
                case 'h':
                    piano.TeclaYSonido(arrBotones[9]);
                    break;
                case 'u':
                    piano.TeclaYSonido(arrBotones[10]);
                    break;
                case 'j':
                    piano.TeclaYSonido(arrBotones[11]);
                    break; 
                default:
                    break; 
            }
            
        }

        private void Libre_Load(object sender, EventArgs e)
        {
            String[] Negras = {"Db", "Eb", "_", "Gb", "Ab", "Bb"};
            String[] Blancas = {"C", "D", "E", "F", "G", "A", "B" };

            
            piano.CrearTeclasNegras(Negras, this); 
            piano.CrearTeclasBlancas(Blancas, this);
            Mensaje(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public async void Mensaje()
        {
            await Task.Delay(500); // wait for 1 second
            MessageBox.Show("Usa el teclado de la computadora o da click a la tecla para reproducir sonido");
        }

    }
}
