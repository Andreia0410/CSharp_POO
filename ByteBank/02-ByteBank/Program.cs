using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Classe Conta Corrente***\n");

            ContaCorrente conta = new ContaCorrente();
            //conta.titular = "Gabriela";
            //conta.saldo = 1000;

            Console.WriteLine(conta.titular = "Gabriela");
            Console.WriteLine(conta.agencia = 0648);
            Console.WriteLine(conta.numero = "18059-4");
            Console.WriteLine(conta.saldo = 1000);
            Console.WriteLine(conta.chequeEspecial = 1500);

            Console.ReadLine();

        }
    }
}
