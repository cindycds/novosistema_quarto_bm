namespace novosistema_quarto_bm
{
    partial class login
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
            this.txbusuario = new System.Windows.Forms.TextBox();
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.txb_login = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txb_usuario = new System.Windows.Forms.Label();
            this.txb_senha = new System.Windows.Forms.Label();
            this.button_entrar = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Label();
            this.mostrar_senha = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbusuario
            // 
            this.txbusuario.ForeColor = System.Drawing.Color.Black;
            this.txbusuario.Location = new System.Drawing.Point(85, 262);
            this.txbusuario.Name = "txbusuario";
            this.txbusuario.Size = new System.Drawing.Size(222, 20);
            this.txbusuario.TabIndex = 0;
            // 
            // txbsenha
            // 
            this.txbsenha.ForeColor = System.Drawing.Color.Black;
            this.txbsenha.Location = new System.Drawing.Point(85, 331);
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.Size = new System.Drawing.Size(222, 20);
            this.txbsenha.TabIndex = 1;
            this.txbsenha.TextChanged += new System.EventHandler(this.txbsenha_TextChanged);
            // 
            // txb_login
            // 
            this.txb_login.AutoSize = true;
            this.txb_login.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_login.Location = new System.Drawing.Point(125, 158);
            this.txb_login.Name = "txb_login";
            this.txb_login.Size = new System.Drawing.Size(128, 43);
            this.txb_login.TabIndex = 2;
            this.txb_login.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::novosistema_quarto_bm.Properties.Resources._31_85302;
            this.pictureBox1.Location = new System.Drawing.Point(133, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 134);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txb_usuario
            // 
            this.txb_usuario.AutoSize = true;
            this.txb_usuario.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_usuario.Location = new System.Drawing.Point(15, 262);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.Size = new System.Drawing.Size(64, 16);
            this.txb_usuario.TabIndex = 4;
            this.txb_usuario.Text = "USUARIO";
            // 
            // txb_senha
            // 
            this.txb_senha.AutoSize = true;
            this.txb_senha.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_senha.Location = new System.Drawing.Point(15, 331);
            this.txb_senha.Name = "txb_senha";
            this.txb_senha.Size = new System.Drawing.Size(49, 16);
            this.txb_senha.TabIndex = 5;
            this.txb_senha.Text = "SENHA";
            // 
            // button_entrar
            // 
            this.button_entrar.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_entrar.Location = new System.Drawing.Point(133, 407);
            this.button_entrar.Name = "button_entrar";
            this.button_entrar.Size = new System.Drawing.Size(125, 52);
            this.button_entrar.TabIndex = 6;
            this.button_entrar.Text = "Entrar";
            this.button_entrar.UseVisualStyleBackColor = true;
            this.button_entrar.Click += new System.EventHandler(this.button_entrar_Click);
            // 
            // limpar
            // 
            this.limpar.AutoSize = true;
            this.limpar.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar.Location = new System.Drawing.Point(157, 462);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(64, 22);
            this.limpar.TabIndex = 7;
            this.limpar.Text = "Limpar";
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // mostrar_senha
            // 
            this.mostrar_senha.AutoSize = true;
            this.mostrar_senha.Location = new System.Drawing.Point(248, 358);
            this.mostrar_senha.Name = "mostrar_senha";
            this.mostrar_senha.Size = new System.Drawing.Size(93, 17);
            this.mostrar_senha.TabIndex = 8;
            this.mostrar_senha.Text = "Mostrar senha";
            this.mostrar_senha.UseVisualStyleBackColor = true;
            this.mostrar_senha.CheckedChanged += new System.EventHandler(this.mostrar_senha_CheckedChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 659);
            this.Controls.Add(this.mostrar_senha);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.button_entrar);
            this.Controls.Add(this.txb_senha);
            this.Controls.Add(this.txb_usuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txb_login);
            this.Controls.Add(this.txbsenha);
            this.Controls.Add(this.txbusuario);
            this.MinimizeBox = false;
            this.Name = "login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbusuario;
        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.Label txb_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txb_usuario;
        private System.Windows.Forms.Label txb_senha;
        private System.Windows.Forms.Button button_entrar;
        private System.Windows.Forms.Label limpar;
        private System.Windows.Forms.CheckBox mostrar_senha;
    }
}

