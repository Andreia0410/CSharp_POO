using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();

            //Gabriela é um objeto tipo Cliente.
            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Desenvolvedora C#";
            //gabriela.cpf = "402.225.758-08";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = gabriela;
            //Atribuindo uma nova instância

            //conta.titular = new Cliente();
            //conta.titular.nome = "Gabriela Costa";
            //conta.titular.cpf = "402.225.758-08";
            //conta.titular.profissao = "Desenvolvedora C#";

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 180594;

            if(conta.titular == null)
            {
                Console.WriteLine("Ops, a referência em conta.titular é null");
            }

            //Acessando gabriela pelo msmo objeto
            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular);
            //Console.WriteLine(conta.titular.nome);
            //Console.WriteLine(conta.titular.cpf);
            //Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();

        }
    }
}
