using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vagas_de_Estágio.DTO
{
    public class CandidaturaDTO
    {
        private int id;
        private string nome;
        private string descricao;
        private string telefone;
        private string email;
        private string escola;
        private string curso;
        private string vaga;
        private string foto;

        public int Id
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string Nome
        {
            set { this.nome = value; }
            get { return this.nome; }
        }

        public string Descricao
        {
            set { this.descricao = value; }
            get { return this.descricao; }
        }
        public string telefone
        {
            set { this.telefone = value; }
            get { return this.telefone; }
        }

        public string email
        {
            set { this.email = value; }
            get { return this.email; }
        }

        public string escola
        {
            set { this.escola = value; }
            get { return this.escola; }
        }
        public string curso
        {
            set { this.curso = value; }
            get { return this.curso; }
        }

        public string vaga
        {
            set { this.vaga = value; }
            get { return this.vaga; }
        }

    }
}