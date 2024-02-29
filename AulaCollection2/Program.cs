using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contato> contato = new List<Contato>();
            AgendaTelefonica agenda = new AgendaTelefonica(contato);          
            agenda.inserir("ale", "222");
            agenda.inserir("a", "3");
            agenda.inserir("b", "4");
            agenda.inserir("c", "5");
            agenda.inserir("o", "10");
            //string status = agenda.buscarNumero("11");            
            Console.WriteLine("Tamanho do array anterior a remoção: " + agenda.tamanho());
            agenda.remover("ale");

            Console.WriteLine("Tamanho do array após a remoção: " + agenda.tamanho());
            Console.WriteLine(agenda.tamanho());

            Console.ReadLine();
        }
    }
}
