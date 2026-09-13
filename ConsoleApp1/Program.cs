using System.Security.Cryptography.X509Certificates;

internal partial class Program
{ // conta corrente
    private static void Main(string[] args)
    {
        string usuario = "vitu";
        decimal saldoConta = 1000;
        decimal limiteDebito = 1200;

        do
        {

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Bem-vindo ao sistema bancário!");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1 - sacar");
            Console.WriteLine("2 - depositar");
            Console.WriteLine("3 - consultar saldo");
            Console.WriteLine("S - sair");
            Console.WriteLine("------------------------------------------");
            string? opcao = Console.ReadLine()?.ToLower();

            if (opcao == "s")
                break;
            else if (opcao == "1")
            {
                System.Console.WriteLine("quanto deseja sacar:");
                decimal quantoSacar = Convert.ToDecimal(Console.ReadLine());

                saldoConta -= quantoSacar;
            }
            else if (opcao == "2")
            {
                System.Console.WriteLine("valor do deposito:");
                decimal quantoDeposito = Convert.ToDecimal(Console.ReadLine());

                saldoConta += quantoDeposito;
            }
            else if (opcao == "3")
            {
                System.Console.WriteLine($"saldo da conta {saldoConta}");
            }

        } while (true);

    }
}