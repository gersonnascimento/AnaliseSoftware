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
    public partial class Adm : Form
    {
        public Adm()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastro frmCadastro = new FrmCadastro();
            this.Hide();
            frmCadastro.Visible = true;
        }

        private void btnCsoftware_Click(object sender, EventArgs e)
        {
            CadSoft cadSoft = new CadSoft();
            this.Hide();
            cadSoft.Show();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            Ranking ranking = new Ranking();
            this.Hide();
            ranking.Show();
        }
    }
}
