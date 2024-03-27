using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Banco
    {
        Dictionary<string, Conta> contas;
        public Banco(Dictionary<string, Conta> contas) { 
            this.contas = new Dictionary<string, Conta>();
        }
        public void inserir(string cod, Conta conta) {
            contas.Add(cod, conta);
        }
        public void buscar(string cod)
        {
            if (contas.ContainsKey(cod))
                Console.WriteLine("Conta achada!");
            else
                Console.WriteLine("Conta não achada!");
        }
        public void listarTodasContas()
        {
            foreach(var contas in contas)
            {
                Console.WriteLine("Código conta: " + contas.Key + " Nome: " + contas.Value.nome + " Saldo: " + contas.Value.saldo);
            }
        }

        public void remover(string cod)
        {
            if (contas.Remove(cod))
                Console.WriteLine("Removido com sucesso");
            else
                Console.WriteLine("Não foi removido");
        }

    }
}