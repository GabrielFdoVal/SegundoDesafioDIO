using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoDesafioDIO
{
    public class Serie : EntidadeBase
    {
        private string titulo;
        private string descricao;
        private int ano;
        private Genero genero;
        private bool excluido;

        public Serie(string titulo, string descricao, int ano, Genero genero, int id)
        {
            this.titulo = titulo;  
            this.descricao = descricao;
            this.ano = ano;
            this.genero = genero;
            this.id = id;
            this.excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Título: " + this.titulo;
            retorno += "\nGênero: " + this.genero;
            retorno += "\nDescrição: " + this.descricao;
            retorno += "\nAno: " + this.ano;
            return retorno;
        }

        public string getTitulo()
        {
            return this.titulo;
        }

        public int getID()
        {
            return this.id;
        }

        public bool estaVazio()
        {
            if(this.titulo == null && Convert.ToString(this.id) == null){
                return true;
            }
            return false;
        }

        public void Excluir()
        {
            this.excluido = true;
        }
    }
}
