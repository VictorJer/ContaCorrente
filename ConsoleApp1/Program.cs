using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

internal partial class Program
{ // conta corrente
    private static void Main(string[] args)
    {
        ContaCorrente conta1 = new ContaCorrente();
        conta1.idConta = RandomNumberGenerator.GetInt32(1, 101);
        conta1.titular = "vitu";
        conta1.saldoConta = 1200;
        conta1.limiteDebito = 1000;

        ContaCorrente conta2 = new ContaCorrente();
        conta2.idConta = RandomNumberGenerator.GetInt32(1, 101);
        conta2.titular = "thi";
        conta2.saldoConta = 10000;
        conta2.limiteDebito = 1000;

        do
        {

            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Bem-vindo ao sistema bancário, numero de identificação {conta1.idConta} de {conta1.titular}!");
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
                conta1.Sacar();
            }

            else if (opcao == "2")
            {
                conta1.Depositar();
            }

            else if (opcao == "3")
            {
                conta1.ObterSaldo();
            }

            else if (opcao == "4")
            {
                conta1.TrasferirPara(conta2);
            }

        } while (true);

    }
}
class ContaCorrente
{
    public int idConta;
    public string titular;
    public decimal saldoConta;
    public decimal limiteDebito;

    public void Sacar()
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

    public void Depositar()
    {
        System.Console.WriteLine("valor do deposito:");
        decimal quantoDeposito = Convert.ToDecimal(Console.ReadLine());

        saldoConta += quantoDeposito;
    }

    public void TrasferirPara(ContaCorrente contaDestino)
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
            contaDestino.saldoConta += valorTrasferencia;

            System.Console.WriteLine($"O valor de {valorTrasferencia} foi trasferido");
            Console.ReadLine();
        }
    }

    public void ObterSaldo()
    {
        System.Console.WriteLine($"saldo da conta {saldoConta}");
    }
}

