namespace DenteBam
{
    partial class frmdentista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdentista));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Cro = new System.Windows.Forms.TextBox();
            this.txt_3 = new System.Windows.Forms.Label();
            this.txt_2 = new System.Windows.Forms.Label();
            this.dvgDados = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instagram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facebook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.twitter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linkedin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chbLinkedin = new System.Windows.Forms.CheckBox();
            this.chbFacebook = new System.Windows.Forms.CheckBox();
            this.chbTwitter = new System.Windows.Forms.CheckBox();
            this.chbInstagram = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDados)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.Minimizar);
            this.panel1.Controls.Add(this.Fechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 32);
            this.panel1.TabIndex = 0;
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimizar.BackgroundImage")));
            this.Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimizar.Location = new System.Drawing.Point(545, -15);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(34, 59);
            this.Minimizar.TabIndex = 5;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Fechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Fechar.BackgroundImage")));
            this.Fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fechar.Location = new System.Drawing.Point(585, -15);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(34, 59);
            this.Fechar.TabIndex = 4;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 640);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 10);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_Nome);
            this.groupBox1.Controls.Add(this.txt_Cro);
            this.groupBox1.Controls.Add(this.txt_3);
            this.groupBox1.Controls.Add(this.txt_2);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 95);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(79, 36);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(448, 20);
            this.txt_Nome.TabIndex = 5;
            // 
            // txt_Cro
            // 
            this.txt_Cro.Location = new System.Drawing.Point(79, 64);
            this.txt_Cro.Name = "txt_Cro";
            this.txt_Cro.Size = new System.Drawing.Size(179, 20);
            this.txt_Cro.TabIndex = 4;
            // 
            // txt_3
            // 
            this.txt_3.AutoSize = true;
            this.txt_3.Location = new System.Drawing.Point(34, 43);
            this.txt_3.Name = "txt_3";
            this.txt_3.Size = new System.Drawing.Size(39, 13);
            this.txt_3.TabIndex = 2;
            this.txt_3.Text = "NOME";
            // 
            // txt_2
            // 
            this.txt_2.AutoSize = true;
            this.txt_2.Location = new System.Drawing.Point(43, 67);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(30, 13);
            this.txt_2.TabIndex = 1;
            this.txt_2.Text = "CRO";
            // 
            // dvgDados
            // 
            this.dvgDados.AllowUserToAddRows = false;
            this.dvgDados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Cro,
            this.Sexo,
            this.Instagram,
            this.facebook,
            this.twitter,
            this.Linkedin});
            this.dvgDados.Location = new System.Drawing.Point(12, 292);
            this.dvgDados.Name = "dvgDados";
            this.dvgDados.Size = new System.Drawing.Size(595, 108);
            this.dvgDados.TabIndex = 8;
            this.dvgDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDados_CellClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Cro
            // 
            this.Cro.HeaderText = "Cro";
            this.Cro.Name = "Cro";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // Instagram
            // 
            this.Instagram.HeaderText = "Instagram";
            this.Instagram.Name = "Instagram";
            // 
            // facebook
            // 
            this.facebook.HeaderText = "Facebook";
            this.facebook.Name = "facebook";
            // 
            // twitter
            // 
            this.twitter.HeaderText = "Twitter";
            this.twitter.Name = "twitter";
            // 
            // Linkedin
            // 
            this.Linkedin.HeaderText = "Linkedin";
            this.Linkedin.Name = "Linkedin";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rbMasculino);
            this.groupBox2.Controls.Add(this.rbFeminino);
            this.groupBox2.Location = new System.Drawing.Point(12, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 78);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(109, 37);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.Text = "&Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Checked = true;
            this.rbFeminino.Location = new System.Drawing.Point(6, 37);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 0;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "&Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.chbLinkedin);
            this.groupBox3.Controls.Add(this.chbFacebook);
            this.groupBox3.Controls.Add(this.chbTwitter);
            this.groupBox3.Controls.Add(this.chbInstagram);
            this.groupBox3.Location = new System.Drawing.Point(229, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 78);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Redes Sociais";
            // 
            // chbLinkedin
            // 
            this.chbLinkedin.AutoSize = true;
            this.chbLinkedin.Location = new System.Drawing.Point(269, 38);
            this.chbLinkedin.Name = "chbLinkedin";
            this.chbLinkedin.Size = new System.Drawing.Size(66, 17);
            this.chbLinkedin.TabIndex = 3;
            this.chbLinkedin.Text = "Linkedin";
            this.chbLinkedin.UseVisualStyleBackColor = true;
            // 
            // chbFacebook
            // 
            this.chbFacebook.AutoSize = true;
            this.chbFacebook.Location = new System.Drawing.Point(188, 38);
            this.chbFacebook.Name = "chbFacebook";
            this.chbFacebook.Size = new System.Drawing.Size(75, 17);
            this.chbFacebook.TabIndex = 2;
            this.chbFacebook.Text = "FaceBook";
            this.chbFacebook.UseVisualStyleBackColor = true;
            // 
            // chbTwitter
            // 
            this.chbTwitter.AutoSize = true;
            this.chbTwitter.Location = new System.Drawing.Point(110, 38);
            this.chbTwitter.Name = "chbTwitter";
            this.chbTwitter.Size = new System.Drawing.Size(58, 17);
            this.chbTwitter.TabIndex = 1;
            this.chbTwitter.Text = "Twitter";
            this.chbTwitter.UseVisualStyleBackColor = true;
            // 
            // chbInstagram
            // 
            this.chbInstagram.AutoSize = true;
            this.chbInstagram.BackColor = System.Drawing.Color.Transparent;
            this.chbInstagram.Location = new System.Drawing.Point(15, 38);
            this.chbInstagram.Name = "chbInstagram";
            this.chbInstagram.Size = new System.Drawing.Size(72, 17);
            this.chbInstagram.TabIndex = 0;
            this.chbInstagram.Text = "Instagram";
            this.chbInstagram.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(424, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dentista";
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(314, 38);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(103, 38);
            this.btn_Editar.TabIndex = 26;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(436, 38);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(103, 38);
            this.btn_Cancelar.TabIndex = 24;
            this.btn_Cancelar.Text = "&Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(194, 38);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(103, 38);
            this.btn_Salvar.TabIndex = 23;
            this.btn_Salvar.Text = "&Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click_1);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(72, 38);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(103, 38);
            this.btn_Novo.TabIndex = 22;
            this.btn_Novo.Text = "&Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // frmdentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(622, 650);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dvgDados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmdentista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dentista";
            this.Load += new System.EventHandler(this.frmdentista_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Cro;
        private System.Windows.Forms.Label txt_3;
        private System.Windows.Forms.Label txt_2;
        private System.Windows.Forms.DataGridView dvgDados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chbLinkedin;
        private System.Windows.Forms.CheckBox chbFacebook;
        private System.Windows.Forms.CheckBox chbTwitter;
        private System.Windows.Forms.CheckBox chbInstagram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Fechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instagram;
        private System.Windows.Forms.DataGridViewTextBoxColumn facebook;
        private System.Windows.Forms.DataGridViewTextBoxColumn twitter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linkedin;
    }
}

