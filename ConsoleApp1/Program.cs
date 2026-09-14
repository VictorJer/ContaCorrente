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

        TelaPrincipal tela = new TelaPrincipal();

        do
        {
            var opcao = tela.ApresentarOpcaoMenu(conta1);

            if (opcao == "s")
                break;

            else if (opcao == "1")
            {
                tela.ApresentarSaque(conta1);
            }

            else if (opcao == "2")
            {
                tela.ApresentarDeposito(conta1);
            }

            else if (opcao == "3")
            {
                tela.ApresentarSaldo(conta1);
            }

            else if (opcao == "4")
            {
                tela.ApresentarTransferencia(contaAcessada: conta1, contaDestino: conta2);
            }

        } while (true);

        System.Console.WriteLine("Operação terminada");

    }
}



