using _07_ByteBank;
using System;

namespace _07_ByteBank 
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; } 

        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _agencia = value;
            }
        }
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
        //Forma correta de construir um  objeto do tipo ContaCorrente
        //Informando os argumetos dentro da classe construtora
        public ContaCorrente(int agencia, int numero) 
        {
            Agencia = agencia;
            Numero = numero;

            //TotalDeContasCriadas é uma característica da ContaCorrente
            //++ --> incrementa e atribui
            TotalDeContasCriadas++;
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


   



