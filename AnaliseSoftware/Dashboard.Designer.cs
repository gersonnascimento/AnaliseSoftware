namespace AnaliseSoftware
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnAvaliar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRanking = new System.Windows.Forms.Button();
            this.btnMeusDados = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.painel = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.painel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAvaliar
            // 
            this.btnAvaliar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAvaliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvaliar.ForeColor = System.Drawing.Color.White;
            this.btnAvaliar.Location = new System.Drawing.Point(11, 152);
            this.btnAvaliar.Name = "btnAvaliar";
            this.btnAvaliar.Size = new System.Drawing.Size(186, 30);
            this.btnAvaliar.TabIndex = 0;
            this.btnAvaliar.Text = "Avaliar";
            this.btnAvaliar.UseVisualStyleBackColor = false;
            this.btnAvaliar.Click += new System.EventHandler(this.btnAvaliar_Click);
            this.btnAvaliar.MouseHover += new System.EventHandler(this.btnAvaliar_MouseHover);
            this.btnAvaliar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAvaliar_MouseUp);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(39, 307);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(114, 32);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.btnRanking);
            this.panel1.Controls.Add(this.btnMeusDados);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnAvaliar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 362);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnRanking
            // 
            this.btnRanking.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanking.ForeColor = System.Drawing.Color.White;
            this.btnRanking.Location = new System.Drawing.Point(11, 186);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(186, 30);
            this.btnRanking.TabIndex = 10;
            this.btnRanking.Text = "Informações";
            this.btnRanking.UseVisualStyleBackColor = false;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // btnMeusDados
            // 
            this.btnMeusDados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMeusDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeusDados.ForeColor = System.Drawing.Color.White;
            this.btnMeusDados.Location = new System.Drawing.Point(11, 222);
            this.btnMeusDados.Name = "btnMeusDados";
            this.btnMeusDados.Size = new System.Drawing.Size(186, 30);
            this.btnMeusDados.TabIndex = 9;
            this.btnMeusDados.Text = "Meus dados";
            this.btnMeusDados.UseVisualStyleBackColor = false;
            this.btnMeusDados.Click += new System.EventHandler(this.btnMeusDados_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnaliseSoftware.Properties.Resources.Imagem;
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // painel
            // 
            this.painel.Image = global::AnaliseSoftware.Properties.Resources.picture;
            this.painel.Location = new System.Drawing.Point(273, 3);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(392, 382);
            this.painel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.painel.TabIndex = 10;
            this.painel.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(705, 387);
            this.Controls.Add(this.painel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SA Enloogs";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.painel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAvaliar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMeusDados;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.PictureBox painel;
    }
}