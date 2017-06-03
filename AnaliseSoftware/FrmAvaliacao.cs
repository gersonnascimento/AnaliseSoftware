using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnaliseSoftware
{
    public partial class FrmAvaliacao : Form
    {
        public int opera;
        public void removeChecked()
        {
            this.Op1Q1.Checked = false;
        }
        public void setVp(int op)//preencher o vetor de pesos
            //1- Comercial
            //2- Bancário 
            //3-Entretenimento
        {
        if (op == 1)//Comercial
            {
                vp[0] = 3;
                vp[1] = 2;
                vp[2] = 4;
                vp[3] = 2;
                vp[4] = 3;
                vp[5] = 1;
                vp[6] = 4;
                vp[7] = 3;
                vp[8] = 2;
                vp[9] = 4;
                vp[10] = 4;
                vp[11] = 3;
            }

        else if (op == 2)//Bancário
            {
                vp[0] = 4;
                vp[1] = 4;
                vp[2] = 2;
                vp[3] = 4;
                vp[4] = 3;
                vp[5] = 2;
                vp[6] = 3;
                vp[7] = 3;
                vp[8] = 4;
                vp[9] = 4;
                vp[10] = 4;
                vp[11] = 4;
            }
        else if (op == 3)//Entretenimento
            {
                vp[0] = 4;
                vp[1] = 2;
                vp[2] = 4;
                vp[3] = 4;
                vp[4] = 4;
                vp[5] = 3;
                vp[6] = 2;
                vp[7] = 1;
                vp[8] = 2;
                vp[9] = 3;
                vp[10] = 3;
                vp[11] = 2;
            }
           /* else if (op == 4)
            {
                vp[0] =
                vp[1] =
                vp[2] =
                vp[3] =
                vp[4] =
                vp[5] =
                vp[6] =
                vp[7] =
                vp[8] =
                vp[9] =
                vp[10] =
                vp[11] =
            }*/
        }
        public int usu;
        private int codSoftware;
        private string nome;
        private string tipo;
        public string resultado;
        private int[] notas = new int[12];
        private int[] vp = new int[12];


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
        //Carregar as questões na página.
        public void carregaQuest(string q1,string q2, string q3, string q4, string q5, string q6, string q7, string q8)
        {
            this.lblQ1.Text = q1;
            this.lblQ2.Text = q2;
            this.lblQ3.Text = q3;
            this.lblQ4.Text = q4;
            this.lblQ5.Text = q5;
            this.lblQ6.Text = q6;
            this.lblQ7.Text = q7;
            this.lblQ8.Text = q8;
        }
        

        //calcular nota;
        public void contaNotas()
        {
            //vai contar a pontuação das questões da primeira página e jogar para o vetor estático do form;
        }

        //Carregar as questões da segunda página
        public void carregaQuest2(string q1, string q2, string q3, string q4)
        {
            this.lblQ1.Text = q1;
            this.lblQ2.Text = q2;
            this.lblQ3.Text = q3;
            this.lblQ4.Text = q4;
            this.panel9.Visible = false;
            this.panel10.Visible = false;
            this.panel11.Visible = false;
            this.panel12.Visible = false;
            this.panel13.Visible = false;
            this.panel14.Visible = false;
            this.panel15.Visible = false;
            this.panel16.Visible = false;
        }

        //Vai retornar o vetor com as respostas escolhidas (as respostas têm os valores de 1 a 5(inteiros para serem tratados em um método mais específico)).
        public int[] pegaVetor()
        {
            return notas;
        }

        //Vai receber a resposta de cada questão de acordo com os RadioButtons
        public int pegaResposta(bool r1, bool r2, bool r3, bool r4, bool r5)
        {
            if (r1)
                return 2;
            else if (r2)
                return 4;
            else if (r3)
                return 6;
            else if (r4)
                return 8;
            else if (r5)
                return 10;
            else return 0;// Prestar atenção nisso, nada definido ainda para o caso deste Método retornar zero!!!
        }
        public FrmAvaliacao()
        {
            InitializeComponent();
        }

        private void FrmAvaliacao_Load(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProxPagina_Click(object sender, EventArgs e)
        {

       


            notas[0] = pegaResposta(Op1Q1.Checked, Op2Q1.Checked, Op3Q1.Checked, Op4Q1.Checked, Op5Q1.Checked);
            notas[1] = pegaResposta(Op1Q2.Checked, Op2Q2.Checked, Op3Q2.Checked, Op4Q2.Checked, Op5Q2.Checked);
            notas[2] = pegaResposta(Op1Q3.Checked, Op2Q3.Checked, Op3Q3.Checked, Op4Q3.Checked, Op5Q3.Checked);
            notas[3] = pegaResposta(Op1Q4.Checked, Op2Q4.Checked, Op3Q4.Checked, Op4Q4.Checked, Op5Q4.Checked);
            notas[4] = pegaResposta(Op1Q5.Checked, Op2Q5.Checked, Op3Q5.Checked, Op4Q5.Checked, Op5Q5.Checked);
            notas[5] = pegaResposta(Op1Q6.Checked, Op2Q6.Checked, Op3Q6.Checked, Op4Q6.Checked, Op5Q6.Checked);
            notas[6] = pegaResposta(Op1Q7.Checked, Op2Q7.Checked, Op3Q7.Checked, Op4Q7.Checked, Op5Q7.Checked);
            notas[7] = pegaResposta(Op1Q8.Checked, Op2Q8.Checked, Op3Q8.Checked, Op4Q8.Checked, Op5Q8.Checked);


            //case of firt option
            this.Op1Q1.Checked = false;
            this.Op1Q2.Checked = false;
            this.Op1Q3.Checked = false;
            this.Op1Q4.Checked = false;

            //case of second option
            this.Op2Q1.Checked = false;
            this.Op2Q2.Checked = false;
            this.Op2Q3.Checked = false;
            this.Op2Q4.Checked = false;

            //third
            this.Op3Q1.Checked = false;
            this.Op3Q2.Checked = false;
            this.Op3Q3.Checked = false;
            this.Op3Q4.Checked = false;

            //fourth

            this.Op4Q1.Checked = false;
            this.Op4Q2.Checked = false;
            this.Op4Q3.Checked = false;
            this.Op4Q4.Checked = false;

            //fiveth

            this.Op5Q1.Checked = false;
            this.Op5Q2.Checked = false;
            this.Op5Q3.Checked = false;
            this.Op5Q4.Checked = false;

            btnFinalizar.Visible = true;

            string q1 = "9 - Não foi necessária a instalação de outro software para a \nultilização deste.";
            string q2 = "10 - Não houve problemas de compatibilidade com seu sistema \noperacional.";
            string q3 = "11 - Não houve atrasos ou falhas na execução das tarefas pois \no sistema funcionou corretamente.";
            string q4 = "12 - Não houve vazamento de informações pessoais armazenadas no \nsoftware.";
            carregaQuest2(q1, q2, q3, q4);
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Op4Q8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            notas[8] = pegaResposta(Op1Q1.Checked, Op2Q1.Checked, Op3Q1.Checked, Op4Q1.Checked, Op5Q1.Checked);
            notas[9] = pegaResposta(Op1Q2.Checked, Op2Q2.Checked, Op3Q2.Checked, Op4Q2.Checked, Op5Q2.Checked);
            notas[10] = pegaResposta(Op1Q3.Checked, Op2Q3.Checked, Op3Q3.Checked, Op4Q3.Checked, Op5Q3.Checked);
            notas[11] = pegaResposta(Op1Q4.Checked, Op2Q4.Checked, Op3Q4.Checked, Op4Q4.Checked, Op5Q4.Checked);


            FrmResultado frmResultado = new FrmResultado();
            frmResultado.usu = this.usu;
            frmResultado.setNotas(notas);
            this.Hide();
            frmResultado.alteraLabels(nome,tipo,Convert.ToString(frmResultado.calcMediaPonderada(notas,vp)),frmResultado.defineResultado());
            frmResultado.setNome(this.nome);
            frmResultado.setTipo(this.tipo);
            frmResultado.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
