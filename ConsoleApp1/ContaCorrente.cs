public class ContaCorrente
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

        var resultado = this.Sacar(valorTrasferencia);


        // validação do saldo da conta
        if (!resultado)
        {
            return false;
        }
        else
        {
            contaDestino.Depositar(valorTrasferencia);

            return true;
        }
    }

    public decimal ObterSaldo()
    {
        return saldoConta;
    }
}

