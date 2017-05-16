using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaliseSoftware
{
    class Avaliador
    {
        private string nome;
        private string empresa;
        private string senha;


        public Avaliador(string nome, string empresa, string senha)
        {
            this.nome = nome;
            this.empresa = empresa;
            this.senha = senha;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public String getNome()
        {
            return this.nome;
        }

        public void setEmpresa (string empresa)
        {
            this.empresa = empresa;
        }
        public String getEmpresa()
        {
            return this.empresa;
        }
        public void setSenha(string senha)
        {
            this.senha = senha;
        }
        public string getSenha()
        {
            return this.senha;
        }



    }
}
