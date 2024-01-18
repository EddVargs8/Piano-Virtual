using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace PianoVirtual
{
    internal class Piano
    {
        public int AnchoTeclasNegras;
        public int AltoTeclasNegras;

        public int AnchoTeclasBlancas;
        public int AltoTeclasBlancas;

        public Piano ()
        {
            this.AnchoTeclasNegras = 50;
            this.AltoTeclasNegras= 260;
            this.AnchoTeclasBlancas = 60;
            this.AltoTeclasBlancas = 310; 
        }

        public void CrearTeclasNegras(String [] NotasTeclasNegras, Form forma)
        {
            for (int i = 0; i<NotasTeclasNegras.Length; i++)
            {
                if (NotasTeclasNegras[i] != "_")
                {
                    Button TeclaNegra = new Button(); 
                    TeclaNegra.BackColor = Color.Black;
                    TeclaNegra.ForeColor = Color.White;
                    TeclaNegra.Size = new Size(AnchoTeclasNegras, this.AltoTeclasNegras); 
                    TeclaNegra.Name = NotasTeclasNegras[i].ToString();
                    TeclaNegra.Location = new Point( (TeclaNegra.Location.X+200) + (i * this.AnchoTeclasBlancas) + 30, TeclaNegra.Location.Y+30);
                    TeclaNegra.Text = NotasTeclasNegras[i];
                    forma.Controls.Add(TeclaNegra);
                    TeclaNegra.Click += Click; 
                }
            }
        }

        public void CrearTeclasBlancas(String[] NotasTeclasBlancas, Form forma)
        {
            for (int i = 0; i < NotasTeclasBlancas.Length; i++)
            {
                Button TeclaBlanca = new Button();  
                TeclaBlanca.Name = NotasTeclasBlancas[i].ToString();
                TeclaBlanca.TextAlign = ContentAlignment.BottomCenter;
                TeclaBlanca.Text = NotasTeclasBlancas[i];
                TeclaBlanca.Size = new Size(this.AnchoTeclasBlancas, this.AltoTeclasBlancas); 
                TeclaBlanca.ForeColor = Color.Black;
                TeclaBlanca.BackColor = Color.White; 
                int TheX = (TeclaBlanca.Location.X+200) + (i * this.AnchoTeclasBlancas);
                TeclaBlanca.Location = new Point(TheX, TeclaBlanca.Location.Y+30); 
                forma.Controls.Add(TeclaBlanca);
                TeclaBlanca.Click += Click; 
            }
        }


        public void CrearTeclasBlancasSE (String[] NotasTeclasBlancas, Form forma)
        {
            for (int i = 0; i < NotasTeclasBlancas.Length; i++)
            {
                Button TeclaBlanca = new Button();
                TeclaBlanca.Name = NotasTeclasBlancas[i].ToString();
                TeclaBlanca.TextAlign = ContentAlignment.BottomCenter;
                TeclaBlanca.Text = NotasTeclasBlancas[i];
                TeclaBlanca.Size = new Size(this.AnchoTeclasBlancas, this.AltoTeclasBlancas);
                TeclaBlanca.ForeColor = Color.Black;
                TeclaBlanca.BackColor = Color.White;
                int TheX = (TeclaBlanca.Location.X + 200) + (i * this.AnchoTeclasBlancas);
                TeclaBlanca.Location = new Point(TheX, TeclaBlanca.Location.Y + 30);
                forma.Controls.Add(TeclaBlanca);
            }
        }

        public void CrearTeclasNegrasSE(String[] NotasTeclasNegras, Form forma)
        {
            for (int i = 0; i < NotasTeclasNegras.Length; i++)
            {
                if (NotasTeclasNegras[i] != "_")
                {
                    Button TeclaNegra = new Button();
                    TeclaNegra.BackColor = Color.Black;
                    TeclaNegra.ForeColor = Color.White;
                    TeclaNegra.Size = new Size(AnchoTeclasNegras, this.AltoTeclasNegras);
                    TeclaNegra.Name = NotasTeclasNegras[i].ToString();
                    TeclaNegra.Location = new Point((TeclaNegra.Location.X + 200) + (i * this.AnchoTeclasBlancas) + 30, TeclaNegra.Location.Y + 30);
                    TeclaNegra.Text = NotasTeclasNegras[i];
                    forma.Controls.Add(TeclaNegra);
                }
            }
        }
        
        public void Click(object sender, EventArgs e) //Evento click
        {
            var BtnSender = (Button)sender;
            TeclaYSonido(BtnSender);

        }

        public async void TeclaYSonido(Button bt)
        {

            bt.BackColor = Color.Red; //cambia el color de la nota
            Stream str = (Stream)Properties.Resources.ResourceManager.GetObject(bt.Name.ToString());

            SoundPlayer player = new SoundPlayer(str);
            player.Play();

            await Task.Delay(1000); // regresa el color original

            if (bt.Name.Contains("b"))
                bt.BackColor = Color.Black;
            else 
                bt.BackColor = Color.White;
            
        }

        

    }
}
