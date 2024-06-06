using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFormContato
{
    public class Contato
    {
        public string id { get; set; }
        public string nome{ get; set; }
        public string numero { get; set; }
        public Contato(string id, string nome, string numero  )
        {
            this.id = id;
            this.nome = nome;
            this.numero = numero;
        }
    }
}
