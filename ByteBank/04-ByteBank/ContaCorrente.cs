
public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    //Convenção sempre escrever nome de função com a primeira letra em maísculo.
    //Toda função representa uma ação. Portanto iniciar o nome da função com 
    //um verbo no infinitivo. 
    public bool Sacar(double valor)
    {
        if(this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }
    //Quando usamos void, dizemos que esssa função não têm retorno
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }
    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if(this.saldo < valor)
        {
            return false;
        }  
        else
        {
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }    

   
}

   



