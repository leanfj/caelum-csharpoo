using System;
using System.Collections.Generic;
using System.Text;

namespace OiMundo
{
    class Cliente
    {
        public string Nome { get; set; }
        public string cpf;
        public string rg;
        public string endereco;
        public int idade;

        public Cliente (string nome)
        {
            this.Nome = nome;
        }

        public bool isMaiorDeIdade ()
        {
            if (idade > 18)
            {
                return true;
            }

            return false;
        }
    }
}
