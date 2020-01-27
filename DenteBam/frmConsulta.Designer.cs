namespace DenteBam
{
    partial class frmConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_Retorno = new System.Windows.Forms.DateTimePicker();
            this.dtp_Consulta = new System.Windows.Forms.DateTimePicker();
            this.txt_Retorno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmd_DentistaC = new System.Windows.Forms.ComboBox();
            this.cmd_PacienteC = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.txt_Receita = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Diagnostico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Motivo = new System.Windows.Forms.TextBox();
            this.txt_IdC = new System.Windows.Forms.TextBox();
            this.txt_3 = new System.Windows.Forms.Label();
            this.txt_2 = new System.Windows.Forms.Label();
            this.txt_1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvgDados = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDentista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTRetorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(380, 38);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(103, 38);
            this.btn_Cancelar.TabIndex = 18;
            this.btn_Cancelar.Text = "&Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(138, 38);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(103, 38);
            this.btn_Salvar.TabIndex = 17;
            this.btn_Salvar.Text = "&Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(268, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Data Retorno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Data Consulta";
            // 
            // dtp_Retorno
            // 
            this.dtp_Retorno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Retorno.Location = new System.Drawing.Point(379, 465);
            this.dtp_Retorno.Name = "dtp_Retorno";
            this.dtp_Retorno.Size = new System.Drawing.Size(200, 20);
            this.dtp_Retorno.TabIndex = 18;
            // 
            // dtp_Consulta
            // 
            this.dtp_Consulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Consulta.Location = new System.Drawing.Point(379, 439);
            this.dtp_Consulta.Name = "dtp_Consulta";
            this.dtp_Consulta.Size = new System.Drawing.Size(200, 20);
            this.dtp_Consulta.TabIndex = 17;
            // 
            // txt_Retorno
            // 
            this.txt_Retorno.Location = new System.Drawing.Point(79, 237);
            this.txt_Retorno.Multiline = true;
            this.txt_Retorno.Name = "txt_Retorno";
            this.txt_Retorno.Size = new System.Drawing.Size(448, 43);
            this.txt_Retorno.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Retorno";
            // 
            // cmd_DentistaC
            // 
            this.cmd_DentistaC.FormattingEnabled = true;
            this.cmd_DentistaC.Location = new System.Drawing.Point(454, 19);
            this.cmd_DentistaC.Name = "cmd_DentistaC";
            this.cmd_DentistaC.Size = new System.Drawing.Size(121, 21);
            this.cmd_DentistaC.TabIndex = 14;
            // 
            // cmd_PacienteC
            // 
            this.cmd_PacienteC.FormattingEnabled = true;
            this.cmd_PacienteC.Location = new System.Drawing.Point(255, 18);
            this.cmd_PacienteC.Name = "cmd_PacienteC";
            this.cmd_PacienteC.Size = new System.Drawing.Size(121, 21);
            this.cmd_PacienteC.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 640);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 10);
            this.panel2.TabIndex = 14;
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
            this.panel1.TabIndex = 15;
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimizar.BackgroundImage")));
            this.Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimizar.Location = new System.Drawing.Point(545, -14);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(34, 59);
            this.Minimizar.TabIndex = 7;
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
            this.Fechar.TabIndex = 6;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // txt_Receita
            // 
            this.txt_Receita.Location = new System.Drawing.Point(79, 177);
            this.txt_Receita.Multiline = true;
            this.txt_Receita.Name = "txt_Receita";
            this.txt_Receita.Size = new System.Drawing.Size(448, 45);
            this.txt_Receita.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Receita";
            // 
            // txt_Diagnostico
            // 
            this.txt_Diagnostico.Location = new System.Drawing.Point(79, 121);
            this.txt_Diagnostico.Multiline = true;
            this.txt_Diagnostico.Name = "txt_Diagnostico";
            this.txt_Diagnostico.Size = new System.Drawing.Size(448, 41);
            this.txt_Diagnostico.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Diagnostico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dentista";
            // 
            // txt_Motivo
            // 
            this.txt_Motivo.Location = new System.Drawing.Point(79, 59);
            this.txt_Motivo.Multiline = true;
            this.txt_Motivo.Name = "txt_Motivo";
            this.txt_Motivo.Size = new System.Drawing.Size(448, 39);
            this.txt_Motivo.TabIndex = 5;
            // 
            // txt_IdC
            // 
            this.txt_IdC.Location = new System.Drawing.Point(58, 18);
            this.txt_IdC.Name = "txt_IdC";
            this.txt_IdC.ShortcutsEnabled = false;
            this.txt_IdC.Size = new System.Drawing.Size(109, 20);
            this.txt_IdC.TabIndex = 3;
            // 
            // txt_3
            // 
            this.txt_3.AutoSize = true;
            this.txt_3.Location = new System.Drawing.Point(34, 62);
            this.txt_3.Name = "txt_3";
            this.txt_3.Size = new System.Drawing.Size(39, 13);
            this.txt_3.TabIndex = 2;
            this.txt_3.Text = "Motivo";
            // 
            // txt_2
            // 
            this.txt_2.AutoSize = true;
            this.txt_2.Location = new System.Drawing.Point(186, 26);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(52, 13);
            this.txt_2.TabIndex = 1;
            this.txt_2.Text = " Paciente";
            // 
            // txt_1
            // 
            this.txt_1.AutoSize = true;
            this.txt_1.Location = new System.Drawing.Point(34, 27);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(18, 13);
            this.txt_1.TabIndex = 0;
            this.txt_1.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dvgDados);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtp_Retorno);
            this.groupBox1.Controls.Add(this.dtp_Consulta);
            this.groupBox1.Controls.Add(this.txt_Retorno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmd_DentistaC);
            this.groupBox1.Controls.Add(this.cmd_PacienteC);
            this.groupBox1.Controls.Add(this.txt_Receita);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Diagnostico);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Motivo);
            this.groupBox1.Controls.Add(this.txt_IdC);
            this.groupBox1.Controls.Add(this.txt_3);
            this.groupBox1.Controls.Add(this.txt_2);
            this.groupBox1.Controls.Add(this.txt_1);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 497);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // dvgDados
            // 
            this.dvgDados.AllowUserToAddRows = false;
            this.dvgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nomePaciente,
            this.nomeDentista,
            this.Motivo,
            this.Diagnostico,
            this.Receita,
            this.Retorno,
            this.DTConsulta,
            this.DTRetorno});
            this.dvgDados.Location = new System.Drawing.Point(15, 286);
            this.dvgDados.Name = "dvgDados";
            this.dvgDados.Size = new System.Drawing.Size(564, 147);
            this.dvgDados.TabIndex = 21;
            this.dvgDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDados_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id Consulta";
            this.Id.Name = "Id";
            // 
            // nomePaciente
            // 
            this.nomePaciente.HeaderText = "Nome Paciente";
            this.nomePaciente.Name = "nomePaciente";
            // 
            // nomeDentista
            // 
            this.nomeDentista.HeaderText = "Nome Dentista";
            this.nomeDentista.Name = "nomeDentista";
            // 
            // Motivo
            // 
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            // 
            // Diagnostico
            // 
            this.Diagnostico.HeaderText = "Diagnostico";
            this.Diagnostico.Name = "Diagnostico";
            // 
            // Receita
            // 
            this.Receita.HeaderText = "Receita";
            this.Receita.Name = "Receita";
            // 
            // Retorno
            // 
            this.Retorno.HeaderText = "Retorno";
            this.Retorno.Name = "Retorno";
            // 
            // DTConsulta
            // 
            this.DTConsulta.HeaderText = "DT Consulta";
            this.DTConsulta.Name = "DTConsulta";
            // 
            // DTRetorno
            // 
            this.DTRetorno.HeaderText = "DT Retorno";
            this.DTRetorno.Name = "DTRetorno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(440, 583);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Consulta";
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(16, 38);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(103, 38);
            this.btn_Novo.TabIndex = 16;
            this.btn_Novo.Text = "&Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 38);
            this.button1.TabIndex = 21;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(498, 38);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(103, 38);
            this.btn_Excluir.TabIndex = 19;
            this.btn_Excluir.Text = "&Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(622, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Novo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(412, 267);
            this.Name = "frmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_Retorno;
        private System.Windows.Forms.DateTimePicker dtp_Consulta;
        private System.Windows.Forms.TextBox txt_Retorno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmd_DentistaC;
        private System.Windows.Forms.ComboBox cmd_PacienteC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Receita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Diagnostico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Motivo;
        private System.Windows.Forms.TextBox txt_IdC;
        private System.Windows.Forms.Label txt_3;
        private System.Windows.Forms.Label txt_2;
        private System.Windows.Forms.Label txt_1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.DataGridView dvgDados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Fechar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDentista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Retorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTRetorno;
    }
}