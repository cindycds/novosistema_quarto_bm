namespace novosistema_quarto_bm.telas
{
    partial class CRUDusuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDusuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_nome_sorv = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.txbnome = new System.Windows.Forms.TextBox();
            this.cpf = new System.Windows.Forms.Label();
            this.txbcpf = new System.Windows.Forms.MaskedTextBox();
            this.txbtelefone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.datadenas = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.labelsenha = new System.Windows.Forms.Label();
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.labelendereço = new System.Windows.Forms.Label();
            this.txbendereco = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.mostrar_senha = new System.Windows.Forms.CheckBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnexcluiruser = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.columnHeaderid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadernome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadercpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadertell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderendereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderemail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderdat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lab_nome_sorv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 42);
            this.panel1.TabIndex = 1;
            // 
            // lab_nome_sorv
            // 
            this.lab_nome_sorv.AutoSize = true;
            this.lab_nome_sorv.Font = new System.Drawing.Font("MV Boli", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nome_sorv.Location = new System.Drawing.Point(3, 9);
            this.lab_nome_sorv.Name = "lab_nome_sorv";
            this.lab_nome_sorv.Size = new System.Drawing.Size(288, 29);
            this.lab_nome_sorv.TabIndex = 0;
            this.lab_nome_sorv.Text = "Sorveteria Milkshackper";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(12, 60);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(42, 16);
            this.labelname.TabIndex = 6;
            this.labelname.Text = "NOME";
            // 
            // txbnome
            // 
            this.txbnome.ForeColor = System.Drawing.Color.Black;
            this.txbnome.Location = new System.Drawing.Point(15, 88);
            this.txbnome.Name = "txbnome";
            this.txbnome.Size = new System.Drawing.Size(222, 20);
            this.txbnome.TabIndex = 5;
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf.Location = new System.Drawing.Point(12, 127);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(29, 16);
            this.cpf.TabIndex = 8;
            this.cpf.Text = "CPF";
            // 
            // txbcpf
            // 
            this.txbcpf.Location = new System.Drawing.Point(15, 146);
            this.txbcpf.Mask = "000,000,000-00";
            this.txbcpf.Name = "txbcpf";
            this.txbcpf.Size = new System.Drawing.Size(222, 20);
            this.txbcpf.TabIndex = 9;
            // 
            // txbtelefone
            // 
            this.txbtelefone.Location = new System.Drawing.Point(15, 204);
            this.txbtelefone.Mask = "(00) 00000-0000";
            this.txbtelefone.Name = "txbtelefone";
            this.txbtelefone.Size = new System.Drawing.Size(222, 20);
            this.txbtelefone.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "TELEFONE";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.Location = new System.Drawing.Point(828, 60);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(47, 16);
            this.labelemail.TabIndex = 13;
            this.labelemail.Text = "EMAIL";
            // 
            // txbemail
            // 
            this.txbemail.ForeColor = System.Drawing.Color.Black;
            this.txbemail.Location = new System.Drawing.Point(831, 88);
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(222, 20);
            this.txbemail.TabIndex = 12;
            // 
            // datadenas
            // 
            this.datadenas.Location = new System.Drawing.Point(423, 88);
            this.datadenas.Name = "datadenas";
            this.datadenas.TabIndex = 14;
            this.datadenas.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.datadenas_DateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "DATA DE NASCIMENTO";
            // 
            // labelsenha
            // 
            this.labelsenha.AutoSize = true;
            this.labelsenha.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsenha.Location = new System.Drawing.Point(828, 127);
            this.labelsenha.Name = "labelsenha";
            this.labelsenha.Size = new System.Drawing.Size(49, 16);
            this.labelsenha.TabIndex = 17;
            this.labelsenha.Text = "SENHA";
            // 
            // txbsenha
            // 
            this.txbsenha.ForeColor = System.Drawing.Color.Black;
            this.txbsenha.Location = new System.Drawing.Point(831, 153);
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.Size = new System.Drawing.Size(222, 20);
            this.txbsenha.TabIndex = 16;
            this.txbsenha.TextChanged += new System.EventHandler(this.txbsenha_TextChanged);
            // 
            // labelendereço
            // 
            this.labelendereço.AutoSize = true;
            this.labelendereço.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelendereço.Location = new System.Drawing.Point(828, 202);
            this.labelendereço.Name = "labelendereço";
            this.labelendereço.Size = new System.Drawing.Size(71, 16);
            this.labelendereço.TabIndex = 19;
            this.labelendereço.Text = "ENDEREÇO";
            // 
            // txbendereco
            // 
            this.txbendereco.ForeColor = System.Drawing.Color.Black;
            this.txbendereco.Location = new System.Drawing.Point(831, 239);
            this.txbendereco.Name = "txbendereco";
            this.txbendereco.Size = new System.Drawing.Size(222, 20);
            this.txbendereco.TabIndex = 18;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderid,
            this.columnHeadernome,
            this.columnHeadercpf,
            this.columnHeadertell,
            this.columnHeaderendereco,
            this.columnHeaderemail,
            this.columnHeaderdat});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 384);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1203, 276);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // mostrar_senha
            // 
            this.mostrar_senha.AutoSize = true;
            this.mostrar_senha.Location = new System.Drawing.Point(969, 179);
            this.mostrar_senha.Name = "mostrar_senha";
            this.mostrar_senha.Size = new System.Drawing.Size(93, 17);
            this.mostrar_senha.TabIndex = 21;
            this.mostrar_senha.Text = "Mostrar senha";
            this.mostrar_senha.UseVisualStyleBackColor = true;
            this.mostrar_senha.CheckedChanged += new System.EventHandler(this.mostrar_senha_CheckedChanged);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_cadastrar.Font = new System.Drawing.Font("Palatino Linotype", 12.25F, System.Drawing.FontStyle.Bold);
            this.btn_cadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cadastrar.Image")));
            this.btn_cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cadastrar.Location = new System.Drawing.Point(339, 315);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(170, 63);
            this.btn_cadastrar.TabIndex = 22;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnlimpar.Font = new System.Drawing.Font("Palatino Linotype", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnlimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpar.Image")));
            this.btnlimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlimpar.Location = new System.Drawing.Point(31, 315);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(175, 63);
            this.btnlimpar.TabIndex = 23;
            this.btnlimpar.Text = "LIMPAR";
            this.btnlimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnexcluiruser
            // 
            this.btnexcluiruser.BackColor = System.Drawing.Color.Red;
            this.btnexcluiruser.Font = new System.Drawing.Font("Palatino Linotype", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnexcluiruser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnexcluiruser.Image = ((System.Drawing.Image)(resources.GetObject("btnexcluiruser.Image")));
            this.btnexcluiruser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcluiruser.Location = new System.Drawing.Point(648, 315);
            this.btnexcluiruser.Name = "btnexcluiruser";
            this.btnexcluiruser.Size = new System.Drawing.Size(192, 63);
            this.btnexcluiruser.TabIndex = 24;
            this.btnexcluiruser.Text = "EXCLUIR";
            this.btnexcluiruser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexcluiruser.UseVisualStyleBackColor = false;
            this.btnexcluiruser.Click += new System.EventHandler(this.btnexcluiruser_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnvoltar.Font = new System.Drawing.Font("Palatino Linotype", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnvoltar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnvoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnvoltar.Image")));
            this.btnvoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvoltar.Location = new System.Drawing.Point(942, 315);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(170, 63);
            this.btnvoltar.TabIndex = 25;
            this.btnvoltar.Text = "VOLTAR";
            this.btnvoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // columnHeaderid
            // 
            this.columnHeaderid.Text = "Id";
            this.columnHeaderid.Width = 30;
            // 
            // columnHeadernome
            // 
            this.columnHeadernome.Text = "Nome";
            this.columnHeadernome.Width = 250;
            // 
            // columnHeadercpf
            // 
            this.columnHeadercpf.Text = "Cpf";
            this.columnHeadercpf.Width = 250;
            // 
            // columnHeadertell
            // 
            this.columnHeadertell.Text = "Telefone";
            this.columnHeadertell.Width = 250;
            // 
            // columnHeaderendereco
            // 
            this.columnHeaderendereco.Text = "Endereço";
            this.columnHeaderendereco.Width = 250;
            // 
            // columnHeaderemail
            // 
            this.columnHeaderemail.Text = "Email";
            this.columnHeaderemail.Width = 250;
            // 
            // columnHeaderdat
            // 
            this.columnHeaderdat.Text = "data de nascimento";
            this.columnHeaderdat.Width = 250;
            // 
            // CRUDusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 660);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnexcluiruser);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.mostrar_senha);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelendereço);
            this.Controls.Add(this.txbendereco);
            this.Controls.Add(this.labelsenha);
            this.Controls.Add(this.txbsenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datadenas);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.txbemail);
            this.Controls.Add(this.txbtelefone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbcpf);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbnome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CRUDusuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUDusuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CRUDusuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_nome_sorv;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.TextBox txbnome;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.MaskedTextBox txbcpf;
        private System.Windows.Forms.MaskedTextBox txbtelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.TextBox txbemail;
        private System.Windows.Forms.MonthCalendar datadenas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelsenha;
        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.Label labelendereço;
        private System.Windows.Forms.TextBox txbendereco;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckBox mostrar_senha;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnexcluiruser;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.ColumnHeader columnHeaderid;
        private System.Windows.Forms.ColumnHeader columnHeadernome;
        private System.Windows.Forms.ColumnHeader columnHeadercpf;
        private System.Windows.Forms.ColumnHeader columnHeadertell;
        private System.Windows.Forms.ColumnHeader columnHeaderendereco;
        private System.Windows.Forms.ColumnHeader columnHeaderemail;
        private System.Windows.Forms.ColumnHeader columnHeaderdat;
    }
}