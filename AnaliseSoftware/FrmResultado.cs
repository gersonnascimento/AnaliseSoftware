using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AnaliseSoftware
{
    public partial class FrmResultado : Form
    {
        private string nome;
        private string tipo;
        public int idSoft;
        private int codSoftware;
        private int[] notas;
        private double media;
        public int usu;


        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }
        public string getTipo()
        {
            return this.tipo;
        }

        public void setNotas(int[] notas)
        {
            this.notas = notas;
        }
        public int[] getNotas()
        {
            return this.notas;
        }

        public FrmResultado()
        {
            InitializeComponent();
        }

        public double calcMediaPonderada(int[] vetor,int[] peso)
        {
            double media=0;
            int somaTudo=0;
            int somaPesos=0;
           


            for (int i = 0; i < 12; i++)
            {
                
                //texto += ("\n\nsomaTudo: " + somaTudo + "/ soma pesos: " + somaPesos + " Nota desta : " + vetor[i] + "/ peso desta: " + peso[i]);
                somaTudo += vetor[i] * peso[i];
                somaPesos += peso[i];
            }
            //só para logs:
            //MessageBox.Show(texto);

            media = (Convert.ToDouble(somaTudo) / somaPesos);
            return media;

        }

        public double calcMedia()
        {
            double soma=0;
        for (int i = 0; i < 12; i++)
            {
                soma += notas[i];
            }
            return soma / 12.0;
        }
        public void alteraLabels(string software, string tipo, string nota,string resultado)
        {
            lblSoftware.Text = software;
            lblTipo.Text = tipo;
            double ajudaNota = Convert.ToDouble(nota);
            lblNota.Text = String.Format("{0:0.00}", ajudaNota);
            lblResultado.Text = resultado;
        }

        public bool registraNoBanco()
        {
            Software software = new Software(0, null, 0);
            idSoft = software.pegaSoftware(nome).getCodSoftware();

            MessageBox.Show(" para corrigir segunda avaliação Usuario: " + usu);
            MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database=dbanalise");
            string data;
            data = DateTime.Now.ToShortDateString();
            String sql = "insert into testeav (idUsuario, idSoftware, nota, data) values (" + this.usu + "," + idSoft + ",'"+Convert.ToDouble(lblNota.Text)+"','"+ data+ "')";
            MessageBox.Show(sql);
            MySqlCommand cnn = new MySqlCommand(sql, conn);

            conn.Open();
            try
            {

                cnn.ExecuteNonQuery();
                cnn.Dispose();
                conn.Close();
                MessageBox.Show(data);
                return true;

            }
            catch (Exception)
            {
                MessageBox.Show("Erro do Sistema.");
                MessageBox.Show(sql);
                throw;
            }
            return false;
        }

        public string defineResultado()
        {
            if (calcMedia() < 2.1)
                return "Muito Ruim";
            else if (calcMedia() < 4.1)
                return "Ruim";
            else if (calcMedia() < 6.1)
                return "Regular";
            else if (calcMedia() < 8.1)
                return "Bom";
            else return "Ótimo";
        }
        

        private void FrmResultado_Load(object sender, EventArgs e)
        {
            this.registraNoBanco();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard();
            dash.usu = this.usu;
            dash.Visible = true;
        }
    }
}
