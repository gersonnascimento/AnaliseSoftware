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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(0, null, txtUsuario.Text, txtSenha.Text, null);


            MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database=dbanalise");
            String sql = "select * from usuarios where login='"+usuario.getLogin()+"' and senha = '"+usuario.getSenha()+"'";

            MySqlCommand cnn = new MySqlCommand(sql, conn);


                conn.Open();

                MySqlDataReader dr = cnn.ExecuteReader();

                if (dr.Read())
                {
                if (txtUsuario.Text == "admin")
                {
                    Adm adm = new Adm();
                    this.Hide();
                    adm.Visible = true;
                }
                else
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.usu = Convert.ToInt16(dr["id"].ToString());
                    dashboard.Visible = true;
                    this.Hide();
                }
            }
                else
                    MessageBox.Show("Usuário ou senha inválidos!");

                
         
            cnn.Dispose();
            conn.Close();
           


            /*
            //Login provisório sem banco de dados
            if (txtUsuario.Text == "gerson" && txtSenha.Text == "123")
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Visible = true;
                this.Hide();
            }
            else MessageBox.Show("Usuário ou senha inválidos");
            */
        }


        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastro frmCadastro = new FrmCadastro();
            frmCadastro.Visible = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnAcessar.PerformClick();
            }
        }
        private void Login_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnAcessar.PerformClick();
            }
        }
    }
}
