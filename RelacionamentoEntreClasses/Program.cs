using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionamentoEntreClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> relacaoCodigos = new List<int>();
            Disciplina introducaoComputacao = new Disciplina("Introducao", 10);
            Disciplina calculo = new Disciplina("Calculo", 30);
            Disciplina calculoII = new Disciplina("Calculo II", 30);
            Disciplina redes = new Disciplina("redes", 20);

            redes.addPreRequisitos(introducaoComputacao);
            redes.addPreRequisitos(calculo);
            redes.addPreRequisitos(calculoII);

            Console.WriteLine("Mostrando o código das disciplinas que são pre-requisitos" +
                "para cursar essa disciplina:");
            foreach (int codigoDisciplina in redes.preRequisitos){
                Console.WriteLine($"{codigoDisciplina}");
            }
            Console.ReadLine();
        }
    }
}
