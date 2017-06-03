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
        int contalinhafixo = 0;
        string ranking;
        public Objeto[] gravaPos;
        public Ranking()
        {
            InitializeComponent();
        }
        public class Objeto
        {
           public double media;
            public string nome;
        } 

  
public static Objeto[] OrdenaVetor(Objeto[] vetor)
{
    int i, j;
    Objeto atual;
    Objeto ajudaTroca;
    for (i = 0; i<vetor.Length; i++)
    {
        atual = vetor[i];
        j = i;
        while ((j > 0) && (vetor[j - 1].media < atual.media))
        {
            ajudaTroca = vetor[j];
            vetor[j] = vetor[j - 1];
            vetor[j - 1] = ajudaTroca;
            j = j - 1;
        }
        vetor[j] = atual;
    }
    return vetor;
}

        public void formaVetor()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database=dbanalise");
            int contalinha = 0;

            String sql = "select id,nome from softwares";

            MySqlCommand cnn = new MySqlCommand(sql, conn);

            conn.Open();

            MySqlDataReader dr = cnn.ExecuteReader();
            
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
                {
                    //for (int i = 0; i < comando.FieldCount; i++)
                    dataGridView1.Columns.Add("Posição", "Posição");
                    dataGridView1.Columns.Add("Software", "Software");
                    dataGridView1.Columns.Add("Média", "Média");
                }

                // varre as colunas para preencher os valores...
                for (int i = 0; i < comando.FieldCount; i++)
                {
                    values[i] = comando.GetValue(i);
                }
                for (int i = 0; i < comando.FieldCount; i += 3)
                {
                    vetorSoftware[i] = Convert.ToInt16(comando.GetValue(i));
                    //MessageBox.Show("Adicionou: " + vetorSoftware[i]);
                }


                for (int i = 0; i < comando.FieldCount; i += 3)
                {
                    string it = comando.GetValue(i).ToString();
                    // MessageBox.Show(Convert.ToString(dr.FieldCount));
                    //   vetor[i] = dr.GetValue(i);
                }
                // adiciona no grid...
                dataGridView1.Rows.Add(values);
                contalinhafixo = contalinha;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adm adm = new Adm();
            this.Hide();
            adm.Show();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Ranking_Load(object sender, EventArgs e)
        {
            formaVetor();
            gravaPos = new Objeto[contalinhafixo];
            Software software = new Software(0, null, 0);
            for (int i = 1; i <= contalinhafixo; i++)
            {
                ranking += software.pegaNome(i);
                ranking += ": " + software.pegaMedia(i) + "\n";
                gravaPos[i - 1] = new Objeto();
                gravaPos[i - 1].media = software.pegaMedia(i);
                gravaPos[i - 1].nome = software.pegaNome(i);
            }
            OrdenaVetor(gravaPos);
            ranking = "";
            for (int i = 1; i <= contalinhafixo; i++)
            {
                ranking += (gravaPos[i - 1].nome + " : " + Convert.ToString(gravaPos[i - 1].media + "\n"));
            }
             for (int i = 0; i < contalinhafixo; i++)
            {
                dataGridView1.Rows[i].Cells[1].Value = gravaPos[i].nome;
                dataGridView1.Rows[i].Cells[2].Value = gravaPos[i].media;
            }
            
         
        }
    }
}
