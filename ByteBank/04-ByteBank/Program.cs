using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //new - instancia um novo objeto
            ContaCorrente contadoBruno = new ContaCorrente();
            contadoBruno.titular = "Bruno";
            Console.WriteLine(contadoBruno.saldo);
            //Sempre respeitar o tipo da variável e o tipo de return de uma função
            bool resultadoSaque = contadoBruno.Sacar(50);
            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contadoBruno.saldo);
            
            //Método Depositar ou podemos chamar de função
            //Quando temos um método que ele retorna um valor é mais comum chamarmos de função
            contadoBruno.Depositar(500);
            //Quando temos um método void é comum chamarmos de método.
            Console.WriteLine(contadoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno:" + contadoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela:" + contaDaGabriela.saldo);

            bool resultadoTransferencia = contadoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno:" + contadoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela:" + contaDaGabriela.saldo);

            Console.WriteLine("Resultado trasnfência: " + resultadoTransferencia);

            contaDaGabriela.Transferir(100, contadoBruno);

            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine("Saldo do Bruno: " + contadoBruno.saldo);

            Console.ReadLine();
        }
    }
}
