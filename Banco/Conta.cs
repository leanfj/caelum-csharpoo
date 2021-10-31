using System;

namespace Banco
{
    public class Conta
    {
        public Conta()
        {

        }

        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; internal set; }

        public void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }

        public void Saca(double valorOperacao)
        {
            this.Saldo -= valorOperacao;
        }
    }
}