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
        public int Idade { get; set; }

        public Cliente (string nome)
        {
            this.Nome = nome;
        }

        public Cliente (string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public bool isMaiorDeIdade ()
        {
            if (this.Idade > 18)
            {
                return true;
            }

            return false;
        }
    }
}
