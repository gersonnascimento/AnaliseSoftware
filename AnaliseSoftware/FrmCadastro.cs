using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace AnaliseSoftware
{
    public partial class FrmCadastro : Form
    {
        public void limpaTxt()
        {
            this.txtEmpresa.Text = "";
            this.txtLogin.Text = "";
            this.txtNome.Text = "";
            this.txtSenha.Text = "";
        }


        public Boolean campoVazio()
        {
            if (this.txtSenha.Text == "" || this.txtNome.Text == "" || this.txtLogin.Text == "" || this.txtEmpresa.Text == "")
            {
                return true;
            }
            else return false;
        }


        public FrmCadastro()
        {
            InitializeComponent();
                
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario(0,txtNome.Text,txtLogin.Text,txtSenha.Text, txtEmpresa.Text);


            MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database=dbanalise");
            String sql = "insert into usuarios (nome, login, senha, empresa) values ('"+usuario.getNome()+ "'"+","+"'"+usuario.getLogin()+ "'" + "," + "'" + usuario.getSenha() + "'" + "," + "'" + usuario.getEmpresa() + "')";
            
            MySqlCommand cnn = new MySqlCommand(sql,conn);


            if (!campoVazio())
            {
                conn.Open();
                try
                {

                    cnn.ExecuteNonQuery();
                    cnn.Dispose();
                    conn.Close();
                    MessageBox.Show("Usuário cadastrado com sucesso!!");
                    this.limpaTxt();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível cadastrar");
                    throw;
                }
            }
            else MessageBox.Show("Por favor, preencha todos os campos solicitados.");
           

            
            
        }
    }
}
