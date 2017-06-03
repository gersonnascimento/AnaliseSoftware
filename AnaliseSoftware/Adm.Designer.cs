namespace AnaliseSoftware
{
    partial class Adm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adm));
            this.btnCusuario = new System.Windows.Forms.Button();
            this.btnCsoftware = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCusuario
            // 
            this.btnCusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusuario.Location = new System.Drawing.Point(24, 27);
            this.btnCusuario.Name = "btnCusuario";
            this.btnCusuario.Size = new System.Drawing.Size(173, 80);
            this.btnCusuario.TabIndex = 0;
            this.btnCusuario.Text = "Cadastrar Usuário";
            this.btnCusuario.UseVisualStyleBackColor = true;
            this.btnCusuario.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCsoftware
            // 
            this.btnCsoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCsoftware.Location = new System.Drawing.Point(220, 27);
            this.btnCsoftware.Name = "btnCsoftware";
            this.btnCsoftware.Size = new System.Drawing.Size(173, 80);
            this.btnCsoftware.TabIndex = 1;
            this.btnCsoftware.Text = "Cadastrar Software";
            this.btnCsoftware.UseVisualStyleBackColor = true;
            this.btnCsoftware.Click += new System.EventHandler(this.btnCsoftware_Click);
            // 
            // btnRanking
            // 
            this.btnRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanking.Location = new System.Drawing.Point(419, 27);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(173, 80);
            this.btnRanking.TabIndex = 2;
            this.btnRanking.Text = "Ranking de Softwares";
            this.btnRanking.UseVisualStyleBackColor = true;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(245, 140);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(122, 39);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(604, 191);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.btnCsoftware);
            this.Controls.Add(this.btnCusuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Adm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador - SA Enloogs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCusuario;
        private System.Windows.Forms.Button btnCsoftware;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Button btnSair;
    }
}