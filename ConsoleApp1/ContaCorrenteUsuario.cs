internal partial class Program
{
    class ContaCorrenteUsuario
    {
        public string Titular;

        public string NumeroIdentificacao;

        public decimal Saldo;

        public decimal LimiteDebito;

        public void Sacar()
        {
            Console.WriteLine("Digite o valor a ser sacado:");
            decimal valorSaque = Convert.ToDecimal(Console.ReadLine());
            if (valorSaque <= Saldo + LimiteDebito)
            {
                Saldo -= valorSaque;
                Console.WriteLine($"Saque de R${valorSaque} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }

            Console.WriteLine("Digite ENTER para continuar...");
            Console.ReadLine();
        }

        public void Depositar()
        {
            Console.WriteLine("Digite o valor a ser depositado:");
            decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());
            Saldo += valorDeposito;
            Console.WriteLine($"Depósito de R${valorDeposito} realizado com sucesso!");

            Console.WriteLine("Digite ENTER para continuar...");
            Console.ReadLine();
        }

        public void Transferir(ContaCorrenteUsuario contaDestino)
        {
            Console.WriteLine("Digite o valor a ser transferido:");
            decimal valorTransferencia = Convert.ToDecimal(Console.ReadLine());
            if (valorTransferencia <= Saldo + LimiteDebito)
            {
                Saldo -= valorTransferencia;
                contaDestino.Saldo += valorTransferencia;
                Console.WriteLine($"Transferência de R${valorTransferencia} realizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar a transferência.");
            }

            Console.WriteLine("Digite ENTER para continuar...");
            Console.ReadLine();
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Seu saldo atual é: R${Saldo}");
            Console.WriteLine("Digite ENTER para continuar...");
            Console.ReadLine();
        }
    }
}