using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DenteBam
{
    public partial class frmdentista : Form
    {
        Dentista objDentista;
        conexao con = new conexao();
        public frmdentista ()
        {
            InitializeComponent();
            con = new conexao(); 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            con.conectar();
            limparCampos();
            desbloquearCampos();
        }

       

        private void desbloquearCampos()
        {
           
            txt_Cro.ReadOnly = false;
            txt_Nome.ReadOnly = false;
        }

        private void bloquearCampos()
        {
           
            txt_Cro.ReadOnly = true;
            txt_Nome.ReadOnly = true;
        }

        private void lerDados()
        {
            objDentista = new Dentista();

            //objDentista.Id = int.Parse(txt_Id.Text.Trim());
            objDentista.Nome = txt_Nome.Text;
            objDentista.Cro = txt_Cro.Text;

            objDentista.instagram = chbInstagram.Checked ? 1 : 0;
            objDentista.twitter = chbTwitter.Checked ? 1 : 0;
            objDentista.linkedin = chbLinkedin.Checked ? 1 : 0;
            objDentista.facebook= chbFacebook.Checked ? 1 : 0;

            //objDentista.sexo = rbFeminino.Checked ? "F" : "M" ;
             if (rbFeminino.Checked)
            {
                objDentista.Sexo = "F";
            }
            else
            {
                objDentista.Sexo = "M";
            }
        }

        private void limparCampos()
        {
            
            txt_Cro.Text = "";
            txt_Nome.Text = "";
        }

        private void atualizarGrid()
        {
            List<Dentista> listDentista = new List<Dentista>();
            con.conectar();

            SqlDataReader reader;
            dvgDados.Rows.Clear();

            reader = con.exeConsulta("select * from tb_dentista");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Dentista dentista = new Dentista();
              
                    dentista.Nome = reader.GetString(1);
                    dentista.Cro = reader.GetString(2);
                    dentista.Sexo = reader.GetValue(3) == null ? "" : reader.GetValue(3).ToString();
                    dentista.instagram = reader.GetValue(4).ToString() == "True" ? 1 : 0;
                    dentista.facebook = reader.GetValue(5).ToString() == "True" ? 1 : 0;
                    dentista.twitter = reader.GetValue(6).ToString() == "True" ? 1 : 0;
                    dentista.linkedin = reader.GetValue(7).ToString() == "True" ? 1 : 0;


                    dvgDados.Rows.Add(dentista.Nome, dentista.Cro, dentista.Sexo, dentista.instagram, dentista.facebook, dentista.twitter, dentista.linkedin);
                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("Não retornou dados");
            }

            
         
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        

        private void dvgDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            desbloquearCampos(); 
            txt_Nome.Text = dvgDados.CurrentRow.Cells[0].Value.ToString();
            txt_Cro.Text = dvgDados.CurrentRow.Cells[1].Value.ToString();
            rbFeminino.Checked = dvgDados.CurrentRow.Cells[2].Value.Equals("F");
            rbMasculino.Checked = dvgDados.CurrentRow.Cells[2].Value.Equals("M");
            chbInstagram.Checked = dvgDados.CurrentRow.Cells[3].Value.Equals(1) ? true : false;
            chbTwitter.Checked = dvgDados.CurrentRow.Cells[4].Value.Equals(1) ? true : false;
            chbFacebook.Checked = dvgDados.CurrentRow.Cells[5].Value.Equals(1) ? true : false;
            chbLinkedin.Checked = dvgDados.CurrentRow.Cells[6].Value.Equals(1) ? true : false;
        }

       
        

        private void frmdentista_Load(object sender, EventArgs e)
        {
            bloquearCampos();
            atualizarGrid();
          

          

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

      

        private void btn_Editar_Click(object sender, EventArgs e)
        {   
           
            Dentista dentista = new Dentista();
            
            dentista.Nome = txt_Nome.Text;
            dentista.Cro = txt_Cro.Text;
            dentista.Sexo = rbFeminino.Text;
            dentista.Sexo = rbMasculino.Text;



            if (chbInstagram.Checked)
            {
                dentista.instagram = 1;
            }
            else
            {
                dentista.instagram = 0;
            }

            if (chbLinkedin.Checked)
            {
                dentista.linkedin = 1;
            }
            else
            {
                dentista.linkedin = 0;
            }

            if (chbTwitter.Checked)
            {
                dentista.twitter = 1;
            }
            else
            {
                dentista.twitter = 0;
            }

            if (chbFacebook.Checked)
            {
                dentista.facebook = 1;
            }
            else
            {
                dentista.facebook = 0;
            }


            conexao.EditarDentista(dentista);
            atualizarGrid();


        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            con.conectar();
            limparCampos();
            desbloquearCampos();
        }

        private void btn_Salvar_Click_1(object sender, EventArgs e)
        {
            lerDados();
            con.conectar();
            String sql = 
                "Insert into tb_dentista " +
                "values (  '" +
                objDentista.Nome + "' , '" +
                objDentista.Cro + "' , '" +
                objDentista.Sexo + "' , " +
                objDentista.instagram + " , " +
                objDentista.facebook + " , " +
                objDentista.twitter + " , " +
                objDentista.linkedin + ") ";
            var ex = MessageBox.Show("Deseja Salvar informaçoes ?", "DenteBam", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (con.executar(sql) == 1)
            {
                MessageBox.Show("Dados salvos com sucesso!");
            }
            else
            {
                MessageBox.Show("Dados não foram salvos !");
            }
            atualizarGrid();
        }

    }
}
