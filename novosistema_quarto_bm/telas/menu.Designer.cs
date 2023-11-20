namespace novosistema_quarto_bm.telas
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_nome_sorv = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_SAIR = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lab_nome_sorv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 42);
            this.panel1.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.btn_cadastrar);
            this.panel2.Controls.Add(this.button_SAIR);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 626);
            this.panel2.TabIndex = 1;
            // 
            // button_SAIR
            // 
            this.button_SAIR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_SAIR.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SAIR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_SAIR.Location = new System.Drawing.Point(69, 568);
            this.button_SAIR.Name = "button_SAIR";
            this.button_SAIR.Size = new System.Drawing.Size(140, 58);
            this.button_SAIR.TabIndex = 0;
            this.button_SAIR.Text = "SAIR";
            this.button_SAIR.UseVisualStyleBackColor = false;
            this.button_SAIR.Click += new System.EventHandler(this.button_SAIR_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::novosistema_quarto_bm.Properties.Resources._12345;
            this.pictureBox2.Location = new System.Drawing.Point(291, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(805, 626);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_cadastrar.Font = new System.Drawing.Font("Palatino Linotype", 12.25F, System.Drawing.FontStyle.Bold);
            this.btn_cadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cadastrar.Image")));
            this.btn_cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cadastrar.Location = new System.Drawing.Point(29, 41);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(215, 60);
            this.btn_cadastrar.TabIndex = 1;
            this.btn_cadastrar.Text = "Cadastrar usuarios";
            this.btn_cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 668);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_nome_sorv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_SAIR;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_cadastrar;
    }
}