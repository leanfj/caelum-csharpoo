using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OiMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

            
        {
            //Tipos de variáveis
            int inteiro = 10;
            double numeroRealMaior = 200.50;
            char caractere = 'b'; //Apenas um caractere entre aspas simples 'a'
            float numeroRealMenor = 2.5f; // Precisa indicar o f para float
            string palavrasEFrases = "Um exemplo de frase"; //Utiliza aspas duplas

            //Declaração de variáveis
            double saldo;
            double saque;

            //Atribuição de valores
            saldo = 100.0;
            saque = 10.0;

            //Operações
            saldo = saldo - saque;

            //casting
            int valor = 1;
            short valorPequeno = (short)valor;

            //concatenação
            string palavra1 = "Ola";
            string palavra2 = "Mundo";

            string concatenada = palavra1 + palavra2;



            MessageBox.Show("Palavra concatenda " + concatenada);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idadeJoao = 10;
            int idadeMaria = 25;

            int somaDasIdades = idadeJoao + idadeMaria;

            MessageBox.Show("Soma das idades " + somaDasIdades);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int pi = 3.14;
            
            //Erro CS0266 Não é possível converter implicitamente tipo "double" em "int".]
            //Existe uma conversão explícita(há uma conversão ausente ?)

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("piQuebrado = " + piQuebrado);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a, b, c;
            double delta, a1, a2;

            a = 5;
            b = 8;
            c = 2;

            delta = b * b - (4 * a * c);

            a1 = (- b + (Math.Sqrt(delta)) / (2 * a));
            a2 = (- b - (Math.Sqrt(delta)) / (2 * a));

            MessageBox.Show("Delta = " + delta + " A1 = " + a1 + " A2 = " + a2);
    
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double saldo = 1000.0;
            double valorSaque = 100.0;

            bool podeSacar = saldo >= valorSaque;

            bool realmentoPodeSAcar = (saldo >= valorSaque) && (valorSaque > 0);

            if (realmentoPodeSAcar)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado, seu saldo é " + saldo);
            } 
            else
            {
                MessageBox.Show("Saldo insuficiente!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double saldo = 5.0;
            double valorSaque = 10.0;

            if(saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com sucesso! Seu saldo é " + saldo);
            }
            else
            {
                MessageBox.Show("Saldo insuficiente! Seu saldo é " + saldo);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double saldo = 6000.0;
            double valorSaque = 10;
            double taxa;

            if (saldo < 1000)
            {
                taxa = 0.01;
            }
            else if (saldo <= 5000)
            {
                taxa = 0.05;
            } else
            {
                taxa = 0.1;
            }

            if (saldo >= valorSaque)
            {
                saldo -= (valorSaque + (valorSaque * taxa));
                MessageBox.Show("Saque realizado! Seu saldo é " + saldo + " Saque com taxa " + ((valorSaque * taxa) + valorSaque));
            }
            else
            {
                MessageBox.Show("Saldo insuficitente");
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int idade;
            bool brasileira;
            bool podeVotar;

            idade = 20;
            brasileira = false;

            podeVotar = (idade >= 16) && brasileira;


            if (podeVotar)
            {
                MessageBox.Show("Pode realizar voto!");
            } else
            {
                MessageBox.Show("Não pode realizar voto!");
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            double valorNotaFiscal;
            double imposto = 0;

            valorNotaFiscal = 7004;

            if (valorNotaFiscal <= 999)
            {
                imposto = 2;
            }
            else if (valorNotaFiscal > 1000 && valorNotaFiscal <= 2999)
            {
                imposto = 2.5;
            } else if (valorNotaFiscal > 3000 && valorNotaFiscal <= 6999)
            {
                imposto = 2.8;
            } 
            else if (valorNotaFiscal >= 7000)
            {
                imposto = 3;
            }

            MessageBox.Show("Valor do imposto é de " + imposto);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int valor = 15;
            string mensagem;

            if (valor > 10) mensagem = "Maior que 10"; else mensagem = "Menor que 10";
                
            MessageBox.Show(mensagem);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double valorInvestido = 1000.0;

            //for (int i = 1; i <= 12; i++)
            //{
            //    valorInvestido *= 1.01;
            //}

            //int i = 1;
            //while ( i <= 12 )
            //{
            //    valorInvestido *= 1.01;
            //    i++;
            //}

            int i = 1;

            do
            {
                valorInvestido *= 1.01;
                i += 1;
            } while (i <= 12);


            
            MessageBox.Show("Valor Investido agora é " + valorInvestido.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")));

        }

        private void button13_Click(object sender, EventArgs e)
        {
            int total = 2;
            for (int i = 0; i < 5; i += 1)
            {
                total = total * 2;
            }


        }

        private void button14_Click(object sender, EventArgs e)
        {
            Cliente leandro = new Cliente();
            leandro.nome = "Leandro";
            leandro.idade = 10;

            Conta contaLeandro = new Conta();
            contaLeandro.Deposita(500.0);
            contaLeandro.Numero = 1;
            contaLeandro.Titular = leandro;

            contaLeandro.Titular.rg = "22783115";

            bool deuCerto = contaLeandro.Saca(400.0);

            if (deuCerto)
            {
                MessageBox.Show("Saque realizado com sucesso! Saldo restante de " + contaLeandro.PegaSaldo());
            }
            else
            {
                MessageBox.Show("Saldo insuficiente " + contaLeandro.PegaSaldo());
            }


            MessageBox.Show(contaLeandro.Titular.nome);
            MessageBox.Show(leandro.rg);

            bool maiorDeIdade = leandro.isMaiorDeIdade();
 
            if (maiorDeIdade)
            {
                MessageBox.Show("É maior de idade!");
            } 
            else
            {
                MessageBox.Show("Não é maior de idade");
            }
        }
    }
} 