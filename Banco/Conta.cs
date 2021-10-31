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
    }
}