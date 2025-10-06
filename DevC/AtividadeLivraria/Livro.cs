using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeLivraria
{
    internal class Livro
    {
        protected string titulo;
        protected string autor;
        protected int ano;
        protected string publicacao;
        protected bool status = true;

        public Livro(string titulo, string autor, int ano, string publicacao)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.ano = ano;
            this.publicacao = publicacao;
        }

        public void Detalhes()
        {
            Console.WriteLine("Título: " + titulo);
            Console.WriteLine("Autor: " + autor);
            Console.WriteLine("Ano: " + ano);
            Console.WriteLine("Publicação: " + publicacao);
        }

        public Boolean Emprestado()
        {
            return status = false;
        }

        public Boolean Devolvido()
        {
            return status = true;
        }

        public string Status()
        {
            if (status)
            {
                return "Status: Disponível";
            }
            else
            {
                return "Status: Emprestado";
            }
        }
    }
}
