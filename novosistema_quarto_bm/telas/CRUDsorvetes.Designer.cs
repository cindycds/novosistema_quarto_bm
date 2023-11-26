namespace novosistema_quarto_bm.telas
{
    partial class CRUDsorvetes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDsorvetes));
            this.labelnamesor = new System.Windows.Forms.Label();
            this.txbnomedosorvete = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.data_val = new System.Windows.Forms.DateTimePicker();
            this.data_fabri = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbquantidade = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnexcluiruser = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.columnHeadernome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderquantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderdtvfabricacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderdtvali = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelnamesor
            // 
            this.labelnamesor.AutoSize = true;
            this.labelnamesor.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnamesor.Location = new System.Drawing.Point(9, 9);
            this.labelnamesor.Name = "labelnamesor";
            this.labelnamesor.Size = new System.Drawing.Size(42, 16);
            this.labelnamesor.TabIndex = 8;
            this.labelnamesor.Text = "NOME";
            // 
            // txbnomedosorvete
            // 
            this.txbnomedosorvete.ForeColor = System.Drawing.Color.Black;
            this.txbnomedosorvete.Location = new System.Drawing.Point(12, 39);
            this.txbnomedosorvete.Name = "txbnomedosorvete";
            this.txbnomedosorvete.Size = new System.Drawing.Size(222, 20);
            this.txbnomedosorvete.TabIndex = 7;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(880, 131);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(133, 16);
            this.labelname.TabIndex = 12;
            this.labelname.Text = "DATA DE VALIDADE";
            this.labelname.Click += new System.EventHandler(this.labelname_Click);
            // 
            // data_val
            // 
            this.data_val.Location = new System.Drawing.Point(886, 158);
            this.data_val.Name = "data_val";
            this.data_val.Size = new System.Drawing.Size(200, 20);
            this.data_val.TabIndex = 13;
            this.data_val.ValueChanged += new System.EventHandler(this.data_val_ValueChanged);
            // 
            // data_fabri
            // 
            this.data_fabri.Location = new System.Drawing.Point(886, 58);
            this.data_fabri.Name = "data_fabri";
            this.data_fabri.Size = new System.Drawing.Size(200, 20);
            this.data_fabri.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(883, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "DATA DE FABRICAÇAO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "QUANTIDADE";
            // 
            // txbquantidade
            // 
            this.txbquantidade.ForeColor = System.Drawing.Color.Black;
            this.txbquantidade.Location = new System.Drawing.Point(12, 158);
            this.txbquantidade.Name = "txbquantidade";
            this.txbquantidade.Size = new System.Drawing.Size(222, 20);
            this.txbquantidade.TabIndex = 16;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderid,
            this.columnHeadernome,
            this.columnHeaderdtvali,
            this.columnHeaderdtvfabricacao,
            this.columnHeaderquantidade});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 512);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1178, 213);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_cadastrar.Font = new System.Drawing.Font("Palatino Linotype", 12.25F, System.Drawing.FontStyle.Bold);
            this.btn_cadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cadastrar.Image")));
            this.btn_cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cadastrar.Location = new System.Drawing.Point(12, 382);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(170, 63);
            this.btn_cadastrar.TabIndex = 23;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(454, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 161);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnlimpar.Font = new System.Drawing.Font("Palatino Linotype", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnlimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpar.Image")));
            this.btnlimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlimpar.Location = new System.Drawing.Point(322, 382);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(175, 63);
            this.btnlimpar.TabIndex = 24;
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
            this.btnexcluiruser.Location = new System.Drawing.Point(621, 382);
            this.btnexcluiruser.Name = "btnexcluiruser";
            this.btnexcluiruser.Size = new System.Drawing.Size(192, 63);
            this.btnexcluiruser.TabIndex = 25;
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
            this.btnvoltar.Location = new System.Drawing.Point(943, 382);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(170, 63);
            this.btnvoltar.TabIndex = 26;
            this.btnvoltar.Text = "VOLTAR";
            this.btnvoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // columnHeadernome
            // 
            this.columnHeadernome.Text = "Nome";
            this.columnHeadernome.Width = 250;
            // 
            // columnHeaderquantidade
            // 
            this.columnHeaderquantidade.Text = "quantidade";
            this.columnHeaderquantidade.Width = 250;
            // 
            // columnHeaderdtvfabricacao
            // 
            this.columnHeaderdtvfabricacao.Text = "data_fabricação";
            this.columnHeaderdtvfabricacao.Width = 250;
            // 
            // columnHeaderdtvali
            // 
            this.columnHeaderdtvali.Text = "Data_validade";
            this.columnHeaderdtvali.Width = 250;
            // 
            // columnHeaderid
            // 
            this.columnHeaderid.Text = "Id";
            this.columnHeaderid.Width = 30;
            // 
            // CRUDsorvetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 725);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnexcluiruser);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbquantidade);
            this.Controls.Add(this.data_fabri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_val);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.labelnamesor);
            this.Controls.Add(this.txbnomedosorvete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUDsorvetes";
            this.Text = "CRUDsorvetes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CRUDsorvetes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnamesor;
        private System.Windows.Forms.TextBox txbnomedosorvete;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.DateTimePicker data_val;
        private System.Windows.Forms.DateTimePicker data_fabri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbquantidade;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnexcluiruser;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.ColumnHeader columnHeaderid;
        private System.Windows.Forms.ColumnHeader columnHeadernome;
        private System.Windows.Forms.ColumnHeader columnHeaderquantidade;
        private System.Windows.Forms.ColumnHeader columnHeaderdtvfabricacao;
        private System.Windows.Forms.ColumnHeader columnHeaderdtvali;
    }
}