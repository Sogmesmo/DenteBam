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
    public partial class frmpaciente : Form
    {
        Paciente objPaciente;
        conexao con;
        public frmpaciente()
        {
            InitializeComponent();
            con = new conexao();
        }


        private void btn_Novo_Click(object sender, EventArgs e)
        {
            con.conectar();
            LimparCampos();
            desbloquearCampos();
        }
        private void desbloquearCampos()
        {

            txt_CpfP.ReadOnly = false;
            txt_NomeP.ReadOnly = false;
            txt_EndP.ReadOnly = false;
            txt_TelP.ReadOnly = false;

        }

        private void bloquearCampos()
        {

            txt_CpfP.ReadOnly = true;
            txt_NomeP.ReadOnly = true;
            txt_EndP.ReadOnly = true;
            txt_TelP.ReadOnly = true;
        }

        private void lerDados()
        {
            objPaciente = new Paciente();


            objPaciente.Nome = txt_NomeP.Text;
            objPaciente.Cpf = txt_CpfP.Text;
            objPaciente.End = txt_EndP.Text;
            objPaciente.Tel = txt_TelP.Text;
            objPaciente.DTNasc = dateTimePicker1.Value;




        }

        private void LimparCampos()
        {
            txt_CpfP.Text = "";
            txt_NomeP.Text = "";
            txt_EndP.Text = "";
            txt_TelP.Text = "";

        }


       
      

        private void btn_CancelarP_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        


        private void atualizarGrid()
        {
            List<Paciente> listPaciente = new List<Paciente>();
            con.conectar();

            SqlDataReader reader;

            reader = con.exeConsulta("select * from tb_paciente");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Paciente paciente = new Paciente();
                    paciente.Id = reader.GetInt32(0);
                    paciente.Nome = reader.GetString(1);
                    paciente.Cpf = reader.GetString(2);
                    paciente.End = reader.GetString(3);
                    paciente.Tel = reader.GetString(4);
                    paciente.DTNasc = reader.GetDateTime(5);

                    Console.WriteLine("entrou aqui");

                    dvgDados.Rows.Add(paciente.Id, paciente.Nome, paciente.Cpf, paciente.End, paciente.Tel, paciente.DTNasc);
                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("Não retornou dados");
            }

            dvgDados.DataSource = null;
            
        }

        private void frmpaciente_Load(object sender, EventArgs e)
        {
            atualizarGrid();
            bloquearCampos();
                 
        }

        private void dvgDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_NomeP.Text = dvgDados.CurrentRow.Cells[1].Value.ToString();
            txt_CpfP.Text = dvgDados.CurrentRow.Cells[2].Value.ToString();
            txt_TelP.Text = dvgDados.CurrentRow.Cells[3].Value.ToString();
            txt_EndP.Text = dvgDados.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(dvgDados.CurrentRow.Cells[5].Value.ToString());
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

        private void btn_Novo_Click_1(object sender, EventArgs e)
        {
            con.conectar();
            LimparCampos();
            desbloquearCampos();
        }

        private void btn_SalvarP_Click_1(object sender, EventArgs e)
        {
            lerDados();
            con.conectar();
            String sql = "Insert into tb_paciente " +
                "values (  '" + objPaciente.Nome + "' , '" + objPaciente.Cpf + "', '" + objPaciente.End + "' , '" + objPaciente.Tel + "',convert(date,'" + objPaciente.DTNasc.ToShortDateString() + "', 103)) ";
            Console.WriteLine(sql);
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
