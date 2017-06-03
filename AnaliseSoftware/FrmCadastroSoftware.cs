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
    public partial class FrmCadastroSoftware : Form
    {
        int cont = 1;
        public int usu;
        public FrmCadastroSoftware()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string q1 = "1 - O sistema apresenta os resultados esperados.";
            string q2 = "2 - Os dados são acessíveis a qualquer usuário do software.";
            string q3 = "3 - Em caso de falha no software você consegue retomar suas \natividades de onde você parou.";
            string q4 = "4 - O software é fácil de fácil utilização.";
            string q5 = "5 - O software é ágil na execução das tarefas.";
            string q6 = "6 - A utilização deste software não compromete a execução das \ndemais tarefas no dispositivo.";
            string q7 = "7 - As atualizações do software não comprometem a sua \nutilização.";
            string q8 = "8 - O Software permite que as atualizações sejam testadas \nantes de serem implantadas.";
            FrmAvaliacao frmAvaliacao = new FrmAvaliacao();
            frmAvaliacao.removeChecked();
            frmAvaliacao.carregaQuest(q1, q2, q3, q4, q5, q6, q7, q8);

                Software software = new Software(0, null, 0);
                frmAvaliacao.setNome(software.pegaSoftware(cmbSoftware.Text).getNome());
                frmAvaliacao.setTipo(software.pegaTipo(software.pegaSoftware(cmbSoftware.Text).getTipo()));
                frmAvaliacao.opera = software.pegaSoftware(cmbSoftware.Text).getTipo();
                frmAvaliacao.setVp(frmAvaliacao.opera);
            


            this.Hide();
    /*        switch (cmbTipo.Text)
            {
                case "Entretenimento": frmAvaliacao.setVp(3);
                    break;
                case "Comercial": frmAvaliacao.setVp(1);
                    break;
                case "Bancário": frmAvaliacao.setVp(2);
                    break;
            }
            */
            frmAvaliacao.usu = this.usu;
            frmAvaliacao.Visible = true;
        }

        private void carregaCmb(int id)
        {
            int cont = 0;
            MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database=dbanalise");
            while (cont == 0)
            {

               
                String sql = "select * from softwares where id =" + id;

                MySqlCommand cnn = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cnn.ExecuteReader();
                if (dr.Read())
                {
                    this.cmbSoftware.Items.Add(dr["nome"].ToString());
                }
                else
                    cont++;
                id++;

                cnn.Dispose();
                conn.Close();
            }
        }
        private void FrmCadastroSoftware_Load(object sender, EventArgs e)
        {
            carregaCmb(1);
        }

    }
}
