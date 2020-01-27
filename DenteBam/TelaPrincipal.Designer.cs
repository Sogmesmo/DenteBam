namespace DenteBam
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porDentistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dentistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnconsulta = new System.Windows.Forms.Button();
            this.btnpaciente = new System.Windows.Forms.Button();
            this.btndentista = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            resources.ApplyResources(this.sairToolStripMenuItem, "sairToolStripMenuItem");
            // 
            // porDentistaToolStripMenuItem
            // 
            this.porDentistaToolStripMenuItem.Name = "porDentistaToolStripMenuItem";
            resources.ApplyResources(this.porDentistaToolStripMenuItem, "porDentistaToolStripMenuItem");
            // 
            // porPacienteToolStripMenuItem
            // 
            this.porPacienteToolStripMenuItem.Name = "porPacienteToolStripMenuItem";
            resources.ApplyResources(this.porPacienteToolStripMenuItem, "porPacienteToolStripMenuItem");
            // 
            // porDataToolStripMenuItem
            // 
            this.porDataToolStripMenuItem.Name = "porDataToolStripMenuItem";
            resources.ApplyResources(this.porDataToolStripMenuItem, "porDataToolStripMenuItem");
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porDataToolStripMenuItem,
            this.porPacienteToolStripMenuItem,
            this.porDentistaToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            resources.ApplyResources(this.consultaToolStripMenuItem, "consultaToolStripMenuItem");
            // 
            // cadastrarToolStripMenuItem2
            // 
            this.cadastrarToolStripMenuItem2.Name = "cadastrarToolStripMenuItem2";
            resources.ApplyResources(this.cadastrarToolStripMenuItem2, "cadastrarToolStripMenuItem2");
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            resources.ApplyResources(this.cadastrarToolStripMenuItem1, "cadastrarToolStripMenuItem1");
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            resources.ApplyResources(this.ajudaToolStripMenuItem, "ajudaToolStripMenuItem");
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem1,
            this.cadastrarToolStripMenuItem2});
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            resources.ApplyResources(this.pacienteToolStripMenuItem, "pacienteToolStripMenuItem");
            // 
            // fixaToolStripMenuItem
            // 
            this.fixaToolStripMenuItem.Name = "fixaToolStripMenuItem";
            resources.ApplyResources(this.fixaToolStripMenuItem, "fixaToolStripMenuItem");
            // 
            // dentistaToolStripMenuItem
            // 
            this.dentistaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fixaToolStripMenuItem,
            this.cadastrarToolStripMenuItem});
            this.dentistaToolStripMenuItem.Name = "dentistaToolStripMenuItem";
            resources.ApplyResources(this.dentistaToolStripMenuItem, "dentistaToolStripMenuItem");
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            resources.ApplyResources(this.cadastrarToolStripMenuItem, "cadastrarToolStripMenuItem");
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dentistaToolStripMenuItem,
            this.pacienteToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // btnconsulta
            // 
            resources.ApplyResources(this.btnconsulta, "btnconsulta");
            this.btnconsulta.Name = "btnconsulta";
            this.btnconsulta.UseVisualStyleBackColor = true;
            this.btnconsulta.Click += new System.EventHandler(this.btnconsulta_Click);
            // 
            // btnpaciente
            // 
            resources.ApplyResources(this.btnpaciente, "btnpaciente");
            this.btnpaciente.Name = "btnpaciente";
            this.btnpaciente.UseVisualStyleBackColor = true;
            this.btnpaciente.Click += new System.EventHandler(this.btnpaciente_Click);
            // 
            // btndentista
            // 
            resources.ApplyResources(this.btndentista, "btndentista");
            this.btndentista.Name = "btndentista";
            this.btndentista.UseVisualStyleBackColor = true;
            this.btndentista.Click += new System.EventHandler(this.btndentista_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Minimizar);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.Fechar);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Minimizar, "Minimizar");
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Fechar, "Fechar");
            this.Fechar.Name = "Fechar";
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.btnpaciente);
            this.panel2.Controls.Add(this.btndentista);
            this.panel2.Controls.Add(this.btnconsulta);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Name = "label1";
            // 
            // TelaPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porDentistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dentistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnconsulta;
        private System.Windows.Forms.Button btnpaciente;
        private System.Windows.Forms.Button btndentista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Fechar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}