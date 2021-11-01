using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta conta;
        private ContaPoupanca contaPoupanca;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.conta = new Conta();
            this.contaPoupanca = new ContaPoupanca();

            contaPoupanca.Numero = 2;
            
            conta.Numero = 1;

            Cliente clientePoupanca = new Cliente("Gustavo");

            contaPoupanca.Titular = clientePoupanca;

            Cliente cliente = new Cliente("Leandro");

            conta.Titular = cliente;

            TotalizadorDeContas totalizadorDeContas = new TotalizadorDeContas();
            totalizadorDeContas.Soma(contaPoupanca);
            totalizadorDeContas.Soma(conta);


            textoTitular.Text = contaPoupanca.Titular.Nome;
            textoNumero.Text = Convert.ToString(contaPoupanca.Numero);
            textoSaldo.Text = Convert.ToString(contaPoupanca.Saldo);
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.contaPoupanca.Deposita(valorOperacao);

            textoSaldo.Text = Convert.ToString(this.contaPoupanca.Saldo);

            textoValor.Text = Convert.ToString(0);

            MessageBox.Show("Depósito bem sucedido");
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.contaPoupanca.Saca(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.contaPoupanca.Saldo);
            textoValor.Text = Convert.ToString(0);
            MessageBox.Show("Saque realizado com sucesso");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
