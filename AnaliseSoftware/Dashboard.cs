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
    public partial class Dashboard : Form
    {
        public int usu;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnAvaliar_Click(object sender, EventArgs e)
        {

            FrmCadastroSoftware a = new FrmCadastroSoftware();
            a.usu = this.usu;
            
            a.Visible = true;
            this.Hide();

           
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastroSoftware frmCadastroSoftware = new FrmCadastroSoftware();
            this.Hide();
            frmCadastroSoftware.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMeusDados_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão Alpha não permite alteração ou consulta dos dados.");
        }

        private void btnAvaliar_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void btnAvaliar_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O usuário 'admin' pode adicionar novos usuários, adicionar novos softwares e também consultar o ranking dos softwares melhor avaliados\nenquanto os outros usuários podem apenas selecionar os softwares já cadastrados e avaliá-los.\nAs notas das avaliações são calculadas de acordo com a média ponderada, considerando cada questão com o seu determinado peso de acordo com o tipo de software.");
        }
    }
}
