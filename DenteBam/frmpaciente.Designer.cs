namespace DenteBam
{
    partial class frmpaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpaciente));
            this.label1 = new System.Windows.Forms.Label();
            this.dvgDados = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_TelP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_EndP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CpfP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NomeP = new System.Windows.Forms.TextBox();
            this.txt_3 = new System.Windows.Forms.Label();
            this.txt_2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_CancelarP = new System.Windows.Forms.Button();
            this.btn_SalvarP = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(424, 573);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 38);
            this.label1.TabIndex = 21;
            this.label1.Text = "Paciente";
            // 
            // dvgDados
            // 
            this.dvgDados.AllowUserToAddRows = false;
            this.dvgDados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Cpf,
            this.End,
            this.Tel,
            this.DTNasc});
            this.dvgDados.Location = new System.Drawing.Point(11, 262);
            this.dvgDados.Name = "dvgDados";
            this.dvgDados.Size = new System.Drawing.Size(595, 108);
            this.dvgDados.TabIndex = 18;
            this.dvgDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDados_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Cpf
            // 
            this.Cpf.HeaderText = "Cpf";
            this.Cpf.Name = "Cpf";
            // 
            // End
            // 
            this.End.HeaderText = "Endereço";
            this.End.Name = "End";
            // 
            // Tel
            // 
            this.Tel.HeaderText = "Telefone";
            this.Tel.Name = "Tel";
            // 
            // DTNasc
            // 
            this.DTNasc.HeaderText = "Data Nascimento";
            this.DTNasc.Name = "DTNasc";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txt_TelP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_EndP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_CpfP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_NomeP);
            this.groupBox1.Controls.Add(this.txt_3);
            this.groupBox1.Controls.Add(this.txt_2);
            this.groupBox1.Location = new System.Drawing.Point(11, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 176);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // txt_TelP
            // 
            this.txt_TelP.Location = new System.Drawing.Point(60, 109);
            this.txt_TelP.Name = "txt_TelP";
            this.txt_TelP.Size = new System.Drawing.Size(203, 20);
            this.txt_TelP.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "TEL";
            // 
            // txt_EndP
            // 
            this.txt_EndP.Location = new System.Drawing.Point(328, 109);
            this.txt_EndP.Name = "txt_EndP";
            this.txt_EndP.Size = new System.Drawing.Size(220, 20);
            this.txt_EndP.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "END.";
            // 
            // txt_CpfP
            // 
            this.txt_CpfP.Location = new System.Drawing.Point(328, 76);
            this.txt_CpfP.Name = "txt_CpfP";
            this.txt_CpfP.Size = new System.Drawing.Size(220, 20);
            this.txt_CpfP.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CPF";
            // 
            // txt_NomeP
            // 
            this.txt_NomeP.Location = new System.Drawing.Point(60, 37);
            this.txt_NomeP.Name = "txt_NomeP";
            this.txt_NomeP.Size = new System.Drawing.Size(488, 20);
            this.txt_NomeP.TabIndex = 5;
            // 
            // txt_3
            // 
            this.txt_3.AutoSize = true;
            this.txt_3.Location = new System.Drawing.Point(21, 40);
            this.txt_3.Name = "txt_3";
            this.txt_3.Size = new System.Drawing.Size(39, 13);
            this.txt_3.TabIndex = 2;
            this.txt_3.Text = "NOME";
            // 
            // txt_2
            // 
            this.txt_2.AutoSize = true;
            this.txt_2.Location = new System.Drawing.Point(24, 83);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(36, 13);
            this.txt_2.TabIndex = 1;
            this.txt_2.Text = "NASC";
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
            this.panel1.TabIndex = 12;
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimizar.BackgroundImage")));
            this.Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimizar.Location = new System.Drawing.Point(545, -14);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(34, 59);
            this.Minimizar.TabIndex = 3;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Fechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Fechar.BackgroundImage")));
            this.Fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fechar.Location = new System.Drawing.Point(585, -14);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(34, 59);
            this.Fechar.TabIndex = 2;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 38);
            this.button1.TabIndex = 26;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_CancelarP
            // 
            this.btn_CancelarP.Location = new System.Drawing.Point(444, 38);
            this.btn_CancelarP.Name = "btn_CancelarP";
            this.btn_CancelarP.Size = new System.Drawing.Size(103, 38);
            this.btn_CancelarP.TabIndex = 24;
            this.btn_CancelarP.Text = "&Cancelar";
            this.btn_CancelarP.UseVisualStyleBackColor = true;
            this.btn_CancelarP.Click += new System.EventHandler(this.btn_CancelarP_Click);
            // 
            // btn_SalvarP
            // 
            this.btn_SalvarP.Location = new System.Drawing.Point(202, 38);
            this.btn_SalvarP.Name = "btn_SalvarP";
            this.btn_SalvarP.Size = new System.Drawing.Size(103, 38);
            this.btn_SalvarP.TabIndex = 23;
            this.btn_SalvarP.Text = "&Salvar";
            this.btn_SalvarP.UseVisualStyleBackColor = true;
            this.btn_SalvarP.Click += new System.EventHandler(this.btn_SalvarP_Click_1);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(80, 38);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(103, 38);
            this.btn_Novo.TabIndex = 22;
            this.btn_Novo.Text = "&Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click_1);
            // 
            // frmpaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(622, 650);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_CancelarP);
            this.Controls.Add(this.btn_SalvarP);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgDados);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(412, 267);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmpaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.frmpaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgDados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_NomeP;
        private System.Windows.Forms.Label txt_3;
        private System.Windows.Forms.Label txt_2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_TelP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_EndP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CpfP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_CancelarP;
        private System.Windows.Forms.Button btn_SalvarP;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Fechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn End;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTNasc;
    }
}