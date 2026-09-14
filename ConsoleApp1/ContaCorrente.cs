class ContaCorrente
{
    public int idConta;
    public string titular;
    public decimal saldoConta;
    public decimal limiteDebito;

    public bool Sacar(decimal quantoSacar)
    {
        if (quantoSacar > saldoConta + limiteDebito)
        {
            return false;
        }
        else
        {
            saldoConta -= quantoSacar;

            return true;
        }
    }

    public void Depositar(decimal quantoDeposito)
    {
        saldoConta += quantoDeposito;
    }

    public bool TrasferirPara(ContaCorrente contaDestino, decimal valorTrasferencia)
    {

        // validação do saldo da conta
        if (saldoConta < valorTrasferencia)
        {
            return false;
        }
        else
        {
            saldoConta -= valorTrasferencia;
            contaDestino.saldoConta += valorTrasferencia;

            return true;
        }
    }

    public void ObterSaldo()
    {
        System.Console.WriteLine($"saldo da conta {saldoConta}");
    }
}

