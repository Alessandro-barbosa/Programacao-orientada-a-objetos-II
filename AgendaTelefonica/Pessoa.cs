using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    internal class Pessoa
    {
        public string nome { get; set; }
        public string telefone { get; set; }
        public string tipo { get; set; }

        public Pessoa(string nome, string telefone, string tipo)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.tipo = tipo;
        }

        public string getNome
        {
            get
            {
                return nome;
            }
        }

        public string getTelefone
        {
            get
            {
               return telefone;
            }
        }
        public string getTipo
        {
            get
            {
                return tipo;
            }
        }

    }
}
