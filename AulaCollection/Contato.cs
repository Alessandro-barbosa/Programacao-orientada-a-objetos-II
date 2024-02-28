using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCollection
{
    internal class Contato
    {
        public Contato(string nome, string telefone){        
            this.nome = nome;
            this.telefone = telefone;   
        }
        public string nome { get; set; }
        public string telefone { get; set; }
    }
}
