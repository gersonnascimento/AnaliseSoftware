using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaliseSoftware
{
    class Usuario
    {
        private int id;
        private String nome;
        private String login;
        private String senha;
        private String empresa;

        public Usuario (int id, String nome, String login, String senha, String empresa)
        {
            this.id = id;
            this.nome = nome;
            this.login = login;
            this.senha = senha;
            this.empresa = empresa;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }

        public void setLogin(string login)
        {
            this.login = login;
        }
        public string getLogin()
        {
            return this.login;
        }

        public void setSenha(string senha)
        {
            this.senha = senha;
        }
        public string getSenha()
        {
            return this.senha;
        }

        public void setEmpresa(string empresa)
        {
            this.empresa = empresa;
        }
        public string getEmpresa()
        {
            return this.empresa;
        }




    }
}
