using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AnaliseSoftware
{
    class Software
    {
        private int codSoftware;
        private int tipo;
        private string nome;
        private string fabricante;
        private double media;//verificar futuramente para na consulta do software, mostrar a média de todas as avaliações.
        public Software(int cod, string nome, int tipo)
        {
            this.codSoftware = cod;// verificar ainda
            this.nome = nome;
            this.tipo = tipo;
            this.media = 0;
        }
        public void setTipo(int tipo)
        {
            this.tipo = tipo;
        }
        public int getTipo()
        {
            return this.tipo;
        }
        public void setcodSoftware(int cod)
        {
            this.codSoftware = cod;
        }

        public int getCodSoftware()
        {
            return this.codSoftware;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setFabricante(string fabricante)
        {
            this.fabricante = fabricante;
        }
        public string getFabricante()
        {
            return this.fabricante;
        }
        public void setMedia(double media)
        {
            this.media = media;
        }
        public double getMedia()
        {
            return this.media;
        }
        public Software pegaSoftware(String nome)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database=dbanalise");
            String sql = "select * from softwares where nome='" + nome + "'";

            MySqlCommand cnn = new MySqlCommand(sql, conn);


            conn.Open();

            MySqlDataReader dr = cnn.ExecuteReader();
            dr.Read();

            Software software = new Software(Convert.ToInt16(dr["id"]),dr["nome"].ToString(), Convert.ToInt16(dr["idTipo"]));
            cnn.Dispose();
            conn.Close();

            return software;
        }

        /*public String pegaTipo(string nome)
        {
            Software software = new Software(0,null,0);
            return software.pegaTipo(pegaSoftware(nome).getTipo());//falta um método banco de dados tipo
        }*/
        public string pegaTipo(int id)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database=dbanalise");
            String sql = "select * from tiposoftware where id="+id;
            //MessageBox.Show(sql);

            MySqlCommand cnn = new MySqlCommand(sql, conn);

            conn.Open();

            MySqlDataReader dr = cnn.ExecuteReader();
            // if (dr.Read())
            //   MessageBox.Show(dr["nome"].ToString());
            dr.Read();
            string retorno = dr["nome"].ToString();
            cnn.Dispose();
            conn.Close();

            return retorno;
        }

        public string pegaNome(int id)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database=dbanalise");
            String sql = "select * from softwares where id=" + id;
            //MessageBox.Show(sql);

            MySqlCommand cnn = new MySqlCommand(sql, conn);

            conn.Open();

            MySqlDataReader dr = cnn.ExecuteReader();
            // if (dr.Read())
            //   MessageBox.Show(dr["nome"].ToString());
            dr.Read();
            string retorno = dr["nome"].ToString();
            cnn.Dispose();
            conn.Close();
            
            return retorno;
            
        }

        //O próximo passo é criar um método para buscar as notas de todas as avaliações do software e
        //calcular a média
        //Feito!
        public double pegaMedia(int cod)
        {
            double media = 0;
            int soma = 0;
            MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database=dbanalise");
            String sql = "select * from testeav where idsoftware="+cod;
         

            MySqlCommand cnn = new MySqlCommand(sql, conn);

            conn.Open();

            MySqlDataReader dr = cnn.ExecuteReader();

            while (dr.Read()) {
                soma++;
                media += Convert.ToDouble(dr["nota"]);
            }

            if (soma != 0)
                media /= soma;
            else media = 0;
            
            cnn.Dispose();
            conn.Close();
            return media;
            
        }
    }
}
