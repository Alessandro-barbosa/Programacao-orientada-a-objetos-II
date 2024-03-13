using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionamentoEntreClasses
{
    internal class Disciplina
    {
        private int codigo;
        public string nome { private get; set; }
        public Professor professor { get; set; }
        public List<int> preRequisitos { get; set; }
        public Disciplina(string nome, int codigo){
            this.nome = nome;
            this.codigo = codigo;
            this.preRequisitos = new List<int>();
        }
        public void addPreRequisitos(Disciplina c) { 
            preRequisitos.Add(c.codigo);
        }
    }
}
