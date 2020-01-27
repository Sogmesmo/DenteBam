using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenteBam
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btndentista_Click(object sender, EventArgs e)
        {
            frmdentista fd = new frmdentista();
            fd.Show();
        }

        private void btnpaciente_Click(object sender, EventArgs e)
        {
            frmpaciente fp = new frmpaciente();
            fp.Show();
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            frmConsulta fc = new frmConsulta();
            fc.Show();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();

        }

      

        private void Minimizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }

            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        
    }
}
