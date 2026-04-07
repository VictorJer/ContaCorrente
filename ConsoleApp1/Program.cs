using System.Security.Cryptography.X509Certificates;

internal partial class Program
{ // conta corrente
    private static void Main(string[] args)
    {
        ContaCorrenteUsuario conta = new ContaCorrenteUsuario
        {
            Titular = "João Silva",
            NumeroIdentificacao = "123456789",
            Saldo = 1000.00m,
            LimiteDebito = 500.00m
        };

        ContaCorrenteUsuario contaDestino = new ContaCorrenteUsuario
        {
            Titular = "Maria Souza",
            NumeroIdentificacao = "987654321",
            Saldo = 500.00m,
            LimiteDebito = 300.00m
        };

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