using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20240215
{
    internal class ContaCorrente
    {
        public ContaCorrente(Proprietario proprietario, Decimal saldo)
        {
            this.proprietario = proprietario;
            this.saldo = saldo;
        }
        private Proprietario proprietario;
        private Decimal saldo;

        public void depositar(Decimal valor){
            this.saldo += valor;
            Console.WriteLine("Deposito feito com sucesso!");
        }       
        public void sacar(Decimal valor)
        {
            this.saldo -= valor;
            Console.WriteLine("Saldo efetuado com sucesso!");
        }

        public void getSaldo()
        {
            Console.WriteLine(this.saldo);
        }        

    }
}
