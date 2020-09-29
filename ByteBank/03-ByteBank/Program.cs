using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Byte Bank - Projeto 03***\n");

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 0648;
            contaDaGabriela.numero = 180594;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 0648;
            contaDaGabriela.numero = 180594;

            Console.WriteLine("Igauldade de tipo de referência: " + (contaDaGabriela ==
                contaDaGabrielaCosta));

            int idade = 27;
            int idadeMais= 27;

            Console.WriteLine("Igualdade de tipo de valor: "+ (idade == idadeMais));

            contaDaGabriela = contaDaGabrielaCosta;

            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);

            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);


            if (contaDaGabriela.saldo >= 100) 
            {
               contaDaGabriela.saldo -= 100;
            }



            Console.ReadLine();
        }
    }
}
