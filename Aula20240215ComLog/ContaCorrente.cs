using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aula20240215
{
    internal class ContaCorrente
    {
        StreamWriter writer = new StreamWriter(@"E:\Downloads\UVV\4 Semestre\Programação orientada a objetos II\ResumoProjetoContaCorrente\Aula20240215\log.txt", true);
        public ContaCorrente(Proprietario proprietario, Decimal saldo)
        {
            this.proprietario = proprietario;
            this.saldo = saldo;
        }
        private Proprietario proprietario;
        private Decimal saldo;
        
        public Boolean depositar(Decimal valor){
            this.saldo += valor;
            Console.WriteLine("Deposito feito com sucesso!");
            writer.WriteLine($"Deposito de {valor} Feito com sucesso!");
            writer.Flush();
            return true;
        }
        public Boolean sacar(Decimal valor)
        {            
            if (saldo >= valor)
            {
                this.saldo -= valor;
                Console.WriteLine($"saque de {valor} efetuado com sucesso!");
                writer.WriteLine($"Saque de {valor} efetuado com sucesso!");
                writer.Flush();
                return true; 
            }
            Console.WriteLine($"Erro ao efetuar saque de {valor}");
            writer.WriteLine("Saque de {valor} efetuado com sucesso!");
            writer.Flush();
            return false;
        }

        public Boolean getSaldo()
        {
            Console.WriteLine(this.saldo);
            return true;            
        }                   
    }
}
