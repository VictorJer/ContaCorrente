using System.Security.Cryptography.X509Certificates;

internal partial class Program
{ // conta corrente
    private static void Main(string[] args)
    {
        string usuario = "vitu";
        decimal saldoConta = 1000;
        decimal limiteDebito = 1200;

        string usuario2 = "thi";
        decimal saldoConta2 = 12000;
        decimal limiteDebito2 = 6000;

        do
        {

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Bem-vindo ao sistema bancário!");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1 - sacar");
            Console.WriteLine("2 - depositar");
            Console.WriteLine("3 - consultar saldo");
            System.Console.WriteLine("4 - Trasferir");
            Console.WriteLine("S - sair");
            Console.WriteLine("------------------------------------------");
            string? opcao = Console.ReadLine()?.ToLower();

            if (opcao == "s")
                break;

            else if (opcao == "1")
            {
                System.Console.WriteLine("quanto deseja sacar:");
                decimal quantoSacar = Convert.ToDecimal(Console.ReadLine());

                if (saldoConta <= -limiteDebito)
                {
                    System.Console.WriteLine("O valor Limite de debito da foi ultapassado!");
                    Console.ReadLine();
                }
                else
                {
                    saldoConta -= quantoSacar;
                }

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

            else if (opcao == "4")
            {
                System.Console.WriteLine("Digite o valor que deseja transferir:");
                decimal valorTrasferencia = Convert.ToDecimal(Console.ReadLine());

                // validação do saldo da conta
                if (saldoConta <= valorTrasferencia)
                {
                    System.Console.WriteLine("saldo insuficiente");
                }
                else
                {
                    saldoConta -= valorTrasferencia;
                    saldoConta2 += valorTrasferencia;

                    System.Console.WriteLine($"O valor de {valorTrasferencia} foi trasferido");
                    Console.ReadLine();
                }
            }

        } while (true);

    }
}