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
    public partial class CadSoft : Form
    {
        public Boolean campoVazio()
        {
            if (txtNome.Text =="" || cmbSoftware.Text == "")
                return true;
            else return false;    
        }
        public void limpaTxt()
        {
            this.txtNome.Text = "";
            this.cmbSoftware.Text = "";
        }
        public CadSoft()
        {
            InitializeComponent();
        }

        private void CadSoft_Load(object sender, EventArgs e)
        {
            {
                int id = 1;
                int cont = 0;
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database=dbanalise");
                while (cont == 0)
                {


                    String sql = "select * from tiposoftware where id =" + id;

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int tipo= 0;
            switch (cmbSoftware.Text)
            {
                case "Comercial":
                    tipo = 1;
                    break;
                case "Bancário":
                    tipo = 2;
                    break;
                case "Entretenimento":
                    tipo = 3;
                    break;   
            }
           


            MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database=dbanalise");
            String sql = "insert into softwares (idTipo,nome) values ("+ tipo +",'"+txtNome.Text+"')";

            MySqlCommand cnn = new MySqlCommand(sql, conn);


            if (!campoVazio())
            {
                conn.Open();
                try
                {

                    cnn.ExecuteNonQuery();
                    cnn.Dispose();
                    conn.Close();
                    MessageBox.Show("Software cadastrado com sucesso!!");
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adm adm = new Adm();
            adm.Visible = true;
        }
    }
}
