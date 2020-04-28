namespace TestSql
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_email = new System.Windows.Forms.TextBox();
            this.text_senha = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.Nova_Conta_link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // text_email
            // 
            this.text_email.Location = new System.Drawing.Point(150, 77);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(100, 20);
            this.text_email.TabIndex = 0;
            // 
            // text_senha
            // 
            this.text_senha.Location = new System.Drawing.Point(150, 117);
            this.text_senha.Name = "text_senha";
            this.text_senha.Size = new System.Drawing.Size(100, 20);
            this.text_senha.TabIndex = 1;
            this.text_senha.TextChanged += new System.EventHandler(this.text_senha_TextChanged);
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(53, 84);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(32, 13);
            this.lb_email.TabIndex = 2;
            this.lb_email.Text = "Email";
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Location = new System.Drawing.Point(47, 124);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(38, 13);
            this.lb_senha.TabIndex = 3;
            this.lb_senha.Text = "Senha";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(132, 184);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(118, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Nova_Conta_link
            // 
            this.Nova_Conta_link.AutoSize = true;
            this.Nova_Conta_link.Location = new System.Drawing.Point(369, 203);
            this.Nova_Conta_link.Name = "Nova_Conta_link";
            this.Nova_Conta_link.Size = new System.Drawing.Size(64, 13);
            this.Nova_Conta_link.TabIndex = 5;
            this.Nova_Conta_link.TabStop = true;
            this.Nova_Conta_link.Text = "Nova Conta";
            this.Nova_Conta_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 228);
            this.Controls.Add(this.Nova_Conta_link);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.text_senha);
            this.Controls.Add(this.text_email);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.TextBox text_senha;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel Nova_Conta_link;
    }
}

