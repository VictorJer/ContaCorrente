public class TelaPrincipal()
{
    public string? ApresentarOpcaoMenu(ContaCorrente contaAcessada)
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"Bem-vindo ao sistema bancário, numero de identificação {contaAcessada.idConta} de {contaAcessada.titular}!");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("1 - sacar");
        Console.WriteLine("2 - depositar");
        Console.WriteLine("3 - consultar saldo");
        System.Console.WriteLine("4 - Trasferir");
        Console.WriteLine("S - sair");
        Console.WriteLine("------------------------------------------");
        string? opcao = Console.ReadLine()?.ToLower();

        return opcao;
    }

    public void ApresentarSaque(ContaCorrente contaAcessada)
    {
        System.Console.WriteLine("quanto deseja sacar:");
        decimal quantoSacar = Convert.ToDecimal(Console.ReadLine());

        var resultado = contaAcessada.Sacar(quantoSacar);

        if (resultado == false)
        {
            System.Console.WriteLine("O valor Limite de debito da foi ultapassado!");
            Console.ReadLine();
        }
        else if (resultado == true)
        {
            System.Console.WriteLine($"O valor {quantoSacar} foi sacado!");
            Console.ReadLine();
        }
    }

    public void ApresentarDeposito(ContaCorrente contaAcessada)
    {
        System.Console.WriteLine("valor do deposito:");
        decimal quantoDeposito = Convert.ToDecimal(Console.ReadLine());

        contaAcessada.Depositar(quantoDeposito);
    }

    public void ApresentarSaldo(ContaCorrente contaAcessada)
    {
        var valorSaldo = contaAcessada.ObterSaldo();

        System.Console.WriteLine($"O valor do saldo é {valorSaldo}");
        Console.ReadLine();
    }

    public void ApresentarTransferencia(ContaCorrente contaAcessada, ContaCorrente contaDestino)
    {
        System.Console.WriteLine("Digite o valor que deseja transferir:");
        decimal valorTrasferencia = Convert.ToDecimal(Console.ReadLine());

        var resultado = contaAcessada.TrasferirPara(contaDestino, valorTrasferencia);

        if (!resultado)
        {
            System.Console.WriteLine("saldo insuficiente");
            Console.ReadLine();
        }
        else
        {
            System.Console.WriteLine($"O valor de {valorTrasferencia} foi trasferido");
            Console.ReadLine();
        }
    }
}



