using _07_ByteBank;
using System;

namespace _07_ByteBank 
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public int Agencia { get; set; }
        public int Numero { get; set; }

        //saldo, campo privado saldo
        private double _saldo = 100;
        public double Saldo 
        {
            //o get precisa ter um retorno
            get 
            {
                return _saldo;
            }
            //value só funciona dentro do método
            //defini a propriedade saldo
            set 
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
                //this.saldo é o campo
            }
        }
        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }
        //Quando usamos void, dizemos que esssa função não têm retorno
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }

    }
}


   



