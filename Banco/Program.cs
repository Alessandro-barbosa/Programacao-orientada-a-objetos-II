using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Conta> DicContas = new Dictionary<string, Conta>();
            Banco banco = new Banco(DicContas);

            Conta conta1 = new Conta("Alessandro", 1200);
            Conta conta2 = new Conta("pedro", 100);
            Conta conta3 = new Conta("Marcos", 500);
            Conta conta4 = new Conta("Bruna", 1000);
            Conta conta5 = new Conta("Maria", 2000);

            banco.inserir("1", conta1);
            banco.inserir("2", conta2);
            banco.inserir("3", conta3);
            banco.inserir("4", conta4);
            banco.inserir("5", conta5);
            banco.listarTodasContas();
        }
    }
}
