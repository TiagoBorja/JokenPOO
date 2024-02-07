using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joken_POO
{
    public partial class Form2 : Form
    {
        int humano;
        int maquina;

        public Form2(int hum,int maq)
        {
            InitializeComponent();
            
            humano = hum;
            maquina = maq;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            switch(humano)
            {
                case 1: pictureBox1.Image = imageList1.Images[0];
                    break;
                case 2:
                    pictureBox1.Image = imageList1.Images[1];
                    break;
                case 3:
                    pictureBox1.Image = imageList1.Images[2];
                    break;
            }
            switch (maquina)
            {
                case 1:
                    pictureBox2.Image = imageList1.Images[0];
                    break;
                case 2:
                    pictureBox2.Image = imageList1.Images[1];
                    break;
                case 3:
                    pictureBox2.Image = imageList1.Images[2];
                    break;
            }
      
            if (humano == maquina)
            {
                label1.Text = "Empate";
                SoundPlayer sonzinho = new SoundPlayer(@"C:\Users\aluno\Downloads\empate.wav");
                sonzinho.Play();
                this.BackColor = Color.Yellow;
                   
            }
            else if ((humano == 1 && maquina == 3) || (humano == 3 && maquina == 2) || (humano == 2 && maquina == 1))
            {           
                label1.Text = "Você ganhou!";
                SoundPlayer sonzinho = new SoundPlayer(@"C:\Users\aluno\Downloads\vitoria.wav");
                sonzinho.Play();
                this.BackColor = Color.Green;
            }
            else
            {
                label1.Text = "Você perdeu";
                SoundPlayer sonzinho = new SoundPlayer(@"C:\Users\aluno\Downloads\derrota.wav");
                sonzinho.Play();
                this.BackColor = Color.Red;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
