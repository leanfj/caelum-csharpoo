namespace Banco
{
     public class ContaPoupanca : Conta
    {
        public ContaPoupanca(int numero) : base(numero)
        {
        }

        public override void Saca(double valorOperacao)
        {
            base.Saca(valorOperacao + 0.10);
        }
        
        public void CalculaRendimento()
        {

        }
    }
}