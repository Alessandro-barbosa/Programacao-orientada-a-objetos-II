using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20240215
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proprietario cliente1 = new Proprietario("Alessandro");            

            ContaCorrente conta1 = new ContaCorrente(cliente1, 1000);


            int opcao = 0;
            do
            {
                Console.WriteLine("Menu\n" +
               "(1) Depositar\n" +
               "(2) Sacar\n" +
               "(3) Saldo\n" +
               "(0) Sair");

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        
                        Console.WriteLine("Insira o valor do depósito: ");
                        Decimal valor = Convert.ToDecimal(Console.ReadLine());
                        conta1.depositar(valor);
                        break;
                        
                    case 2:
                        Console.WriteLine("Insira o valor para sacar: ");
                        Decimal valor2 = Convert.ToDecimal(Console.ReadLine());
                        conta1.sacar(valor2);
                        break;
                        
                    case 3:
                        conta1.getSaldo();
                        break;
                        
                    case 0:
                        Console.WriteLine("Saindo!");
                        break;
                    default:
                        Console.WriteLine("Nenhuma opção escolhida!");
                        break;
                }
            } while (opcao != 0);
        }
    }
}
