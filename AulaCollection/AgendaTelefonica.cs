using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCollection
{
    internal class AgendaTelefonica
    {
        List<Contato> listaContatos;
        public AgendaTelefonica(List<Contato> listaContatos)
        {
            listaContatos = new List<Contato>();
            this.listaContatos = listaContatos;
        }

        public bool inserir(string nome, string numero)
        {
            Contato contato = new Contato(nome,numero);
            listaContatos.Add(contato);
            return true;
        }
        public string buscarNumero(string telefone)
        {
            foreach (var contatos in listaContatos)
            {
                if (contatos.telefone.Contains(telefone))
                    return "Encontrado";                            
            }           
                return "Não encontrado";
        }
        public void remover(string nome)
        {
            foreach (Contato contato in listaContatos)
            {
                if (contato.nome.Contains(nome))           
                    listaContatos.Remove(contato);                
            }
        }
        public int tamanho() { return listaContatos.Count; }
    }
}
//AgendaTelefonica
//- coleção lista

//+ inserir(nome: String, numero: string _ void
//+ buscarNumero(nome: string) : string
//+ remover(nome: string): void
//+ tamanho(): int

//Contato
//- nome
//- telefone