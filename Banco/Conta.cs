using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Conta
    {
        public string nome { get; set; }
        public double saldo { get; set; }

        public Conta(string nome, double saldo)
        {
            this.nome = nome;
            this.saldo = saldo;
        }
    }
}
