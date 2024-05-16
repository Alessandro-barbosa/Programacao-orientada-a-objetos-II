using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    class Pessoa
    {
        public string nome { get; set; }
        public string telefone { get; set; }
        public string trabalho { get; set; }
        public string tipo { get; set; }

        public Pessoa(string nome, string telefone, string trabalho, string tipo)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.trabalho = trabalho;
            this.tipo = tipo;
        }
    }
}
