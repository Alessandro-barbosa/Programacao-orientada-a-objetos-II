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
                    return $"O número {telefone} foi encontrado";                            
            }           
                return $"O número {telefone} não foi encontrado";
        }
        public void remover(string nome)
        {
            int index = 0;
            foreach (Contato contato in listaContatos)
            {
                index += 1;
                if (contato.nome.Contains(nome))
                    break;
                else
                    return;
            }
            listaContatos.RemoveAt(index);
        }
        public int tamanho() { return listaContatos.Count; }
    }
}
//AgendaTelefonica
//- coleção lista

//+ inserir(nome: String, numero: string) : void
//+ buscarNumero(nome: string) : string
//+ remover(nome: string): void
//+ tamanho(): int

// Contato
//- nome
//- telefone