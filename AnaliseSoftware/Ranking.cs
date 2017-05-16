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
    public partial class Ranking : Form
    {
        public int[] vetorSoftware;
        public Ranking()
        {
            InitializeComponent();
        }

        public void formaVetor()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database=dbanalise");


            String sql = "select * from softwares";


            MySqlCommand cnn = new MySqlCommand(sql, conn);

            conn.Open();

            MySqlDataReader dr = cnn.ExecuteReader();
            int contalinha = 0;
            while (dr.Read())
            {
                contalinha++;
            }
            conn.Close();
            MySqlCommand CNN = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader comando = cnn.ExecuteReader();
            vetorSoftware = new int[contalinha];

            while (comando.Read())
            {
                // monta o array de valores...
                object[] values = new object[comando.FieldCount];

                // adiciona as colunas no grid...
                if (dataGridView1.Rows.Count == 0)
                    for (int i = 0; i < comando.FieldCount; i++)
                        dataGridView1.Columns.Add(comando.GetName(i), comando.GetName(i));

                // varre as colunas para preencher os valores...
                for (int i = 0; i < comando.FieldCount; i++)
                {
                    values[i] = comando.GetValue(i);
                }
                for (int i = 0; i < comando.FieldCount; i += 3)
                {
                    vetorSoftware[i] = Convert.ToInt16(comando.GetValue(i));
                    MessageBox.Show("Adicionou: " + vetorSoftware[i]);
                }


                for (int i = 0; i < comando.FieldCount; i += 3)
                {
                    string it = comando.GetValue(i).ToString();
                    // MessageBox.Show(Convert.ToString(dr.FieldCount));
                    //   vetor[i] = dr.GetValue(i);
                }

                // adiciona no grid...
                dataGridView1.Rows.Add(values);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           formaVetor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Software software = new Software(0,null,0);
            software.pegaMedia(2);
        }
    }
}
