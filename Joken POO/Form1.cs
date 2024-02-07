using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Joken_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Computador maquina = new Computador();

        Jogador jogador = new Jogador(Microsoft.VisualBasic.Interaction.InputBox("Qual o seu nome, jogador?"));
             
          
        int contE = 1, contP = 1;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
            int gerar = maquina.Gerar();

            if (gerar == 1)
            {
                label3.Text = $"Empates: {contE++}";
            }
            else if (gerar == 2)
            {
                label2.Text = $"Máquina: {maquina.totalObj++}";
            }
            else 
            {
                label1.Text = $"{jogador.nome}: {jogador.totalJogadas++}";
            }

            new Form2(1,gerar).ShowDialog();
            label4.Text = $"RODADA: {contP++}";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            int gerar = maquina.Gerar();

            if (gerar == 1)
            {
                label1.Text = $"{jogador.nome}: {jogador.totalJogadas++}";
          
            }
            else if (gerar == 2)
            {
                label3.Text = $"Empates: {contE++}";
            }
            else
            {            
                label2.Text = $"Máquina: {maquina.totalObj++}";
            }
            new Form2(2, gerar).ShowDialog();
            label4.Text = $"RODADA: {contP++}";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            int gerar = maquina.Gerar();

            if (gerar == 1)
            {
                label2.Text = $"Máquina: {maquina.totalObj++}";      
            }
            else if (gerar == 2)
            {
                label1.Text = $"{jogador.nome}: {jogador.totalJogadas++}";
            }
            else
            {
                label3.Text = $"Empates: {contE++}";         
            }

            new Form2(3, gerar).ShowDialog();
            label4.Text = $"RODADA: {contP++} ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = $"{jogador.nome}: 0";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 instrucao = new Form3();
            instrucao.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
