using System.Security.Cryptography.X509Certificates;

internal partial class Program
{ // conta corrente
    private static void Main(string[] args)
    {

        do
        {

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Bem-vindo ao sistema bancário!");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1 - sacar");
            Console.WriteLine("2 - depositar");
            Console.WriteLine("3 - consultar saldo");
            Console.WriteLine("4 - sair");
            Console.WriteLine("------------------------------------------");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    conta.Sacar();
                    break;
                case "2":
                    conta.Depositar();
                    break;
                case "3":
                    conta.ConsultarSaldo();
                    break;
                case "4":
                    Console.WriteLine("Obrigado por usar nosso sistema bancário. Até logo!");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        } while (true);

    }
}