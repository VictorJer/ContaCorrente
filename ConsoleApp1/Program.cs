using System.Security.Cryptography.X509Certificates;

internal class Program
{// conta corrente

    class ContaCorrenteUsuario
    {
        public string Titular { get; set; }

        public string Numero { get; set; }

        public decimal Saldo { get; set; }

        public decimal LimiteDebito { get; set; }

        public ContaCorrenteUsuario(string numero, decimal saldo, decimal limiteDebito)
        {
            Numero = numero;
            Saldo = saldo;
            LimiteDebito = limiteDebito;
        }
    }
    private static void Main(string[] args)
    {

        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Bem-vindo ao sistema bancário!");
        Console.WriteLine("------------------------------------------");


    }
}