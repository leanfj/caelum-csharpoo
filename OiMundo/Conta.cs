using System;
using System.Collections.Generic;
using System.Text;

namespace OiMundo
{
    class Conta
    {
        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        public double Saldo {get; private set;}

        public bool Saca(double valor)
        {
            if (!(valor > this.Saldo))
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Transfere(double valor, Conta contaDestino)
        {
            if(this.Saca(valor))
            {
                contaDestino.Deposita(valor);
            }
        }

        public double PegaSaldo()
        {
            return this.Saldo;
        }
    }
}
