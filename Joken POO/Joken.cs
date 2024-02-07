using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joken_POO
{
    class Jogador
    {
        public string nome;
        public int totalJogadas = 1;

        public  Jogador(string nomeFixo)
        {
           if(!string.IsNullOrWhiteSpace(nomeFixo))
           {
                this.nome = nomeFixo;               
           } 
           else
           {
                while (string.IsNullOrWhiteSpace(nomeFixo))
                {
                    nomeFixo = Microsoft.VisualBasic.Interaction.InputBox("Qual o seu nome, jogador?");
                    this.nome = nomeFixo;              
                }
           }         
        }

       

    }

    

    class Computador
    {
        public int totalObj = 1;

        public int Gerar()
        {
            Random random = new Random();
            return random.Next(1, 4);
        }
    }

    class Pedra
    { 
        public int imagem { get; set; }     

        public Pedra()
        {
            this.imagem = 1;
        }
    }

    class Tesoura
    {
        public int imagem { get; set; }

        public Tesoura()
        {
            this.imagem = 2;
        }
    }

    class Papel
    {
        public int imagem { get; set; }

        public Papel()
        {
            this.imagem = 3;
        }
    }


    
}
