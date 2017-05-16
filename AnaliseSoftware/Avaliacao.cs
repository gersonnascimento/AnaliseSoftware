using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaliseSoftware
{
    class Avaliacao
    {
        private Software software;
        private Avaliador avaliador;
        private double nota;
        private String resultado;

        public Avaliacao(Software software, Avaliador avaliador)
        {
            this.software = software;
            this.avaliador = avaliador;
        }

        public void setNota(double nota)
        {
            this.nota = nota;
        }
        public double getNota()
        {
            return this.nota;
        }

        public void setResultado(String resultado)
        {
            this.resultado = resultado;
        }
        public string getResultado()
        {
            return this.resultado;
        }
    }
}
