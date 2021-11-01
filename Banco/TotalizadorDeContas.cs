using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class TotalizadorDeContas
    {
        public double ValorTotal { get; private set; }

        public void Soma(Conta conta)
        {
            this.ValorTotal += conta.Saldo;
        }
    }
}
