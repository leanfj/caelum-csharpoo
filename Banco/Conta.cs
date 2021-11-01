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

        public virtual void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }

        public virtual void Saca(double valorOperacao)
        {
            this.Saldo -= valorOperacao;
        }
    }
}