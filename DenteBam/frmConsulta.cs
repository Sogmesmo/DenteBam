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
    public partial class frmConsulta : Form
    {
       
        Consulta objConsulta;
        conexao con;
        public frmConsulta()
        {
            InitializeComponent();
            con = new conexao();
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            con.conectar();
            desbloquearCampos();
        }



        private void desbloquearCampos()
        {

            txt_IdC.ReadOnly = false;
            txt_Motivo.ReadOnly = false;
            txt_Diagnostico.ReadOnly = false;
            txt_Receita.ReadOnly = false;
            txt_Retorno.ReadOnly = false;
        }

        private void bloquearCampos()
        {

            txt_IdC.ReadOnly = true;
            txt_Motivo.ReadOnly = true;
            txt_Diagnostico.ReadOnly = true;
            txt_Receita.ReadOnly = true;
            txt_Retorno.ReadOnly = true;
        }

        private void lerDados()
        {
            objConsulta = new Consulta();

            objConsulta.Id = int.Parse(txt_IdC.Text.Trim());
            objConsulta.IdDentista = int.Parse(cmd_DentistaC.SelectedValue.ToString());
            objConsulta.IdPaciente = int.Parse(cmd_PacienteC.SelectedValue.ToString());
            objConsulta.Motivo = txt_Motivo.Text;
            objConsulta.Diagnostico = txt_Diagnostico.Text;
            objConsulta.Receita = txt_Receita.Text;
            objConsulta.Retorno = txt_Retorno.Text;
            objConsulta.DTConsulta = dtp_Consulta.Value;
            objConsulta.DTRetorno = dtp_Retorno.Value;


        }

        private void limparCampos()
        {

            txt_IdC.Text = "";
            txt_Motivo.Text = "";
            txt_Diagnostico.Text = "";
            txt_Receita.Text = "";
            txt_Retorno.Text = "";
        }

        private void atualizarGrid()
        {
            List<Consulta> listConsulta = new List<Consulta>();
            con.conectar();

            SqlDataReader reader;
            dvgDados.Rows.Clear();
            reader = con.exeConsulta("select tb_consulta.id,[tb_paciente].[nome] as ' Nome Pacinete', [Motivo],[diagnostico],[receita],motivo_retorno,dt_consulta,dt_retorno,[tb_dentista].[nome] as ' Nome Dentista' from tb_consulta INNER JOIN tb_paciente ON tb_paciente.id = tb_consulta.id_paciente INNER JOIN tb_dentista ON tb_dentista.id = tb_consulta.id_dentista");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Consulta consulta = new Consulta();
                    consulta.Id = reader.GetInt32(0);
                    consulta.nomePaciente = reader.GetString(1);
                    consulta.Motivo = reader.GetString(2);
                    consulta.Diagnostico = reader.GetString(3);
                    consulta.Receita = reader.GetString(4);
                    consulta.Retorno = reader.GetString(5);
                    consulta.DTConsulta = reader.GetDateTime(6);
                    consulta.DTRetorno = reader.GetDateTime(7);
                    consulta.nomeDentista = reader.GetString(8);

                    Console.WriteLine("entrou aqui");

                  dvgDados.Rows.Add(consulta.Id,consulta.nomePaciente, consulta.nomeDentista, consulta.Motivo, consulta.Diagnostico, consulta.Receita, consulta.Retorno, consulta.DTConsulta.ToShortDateString(), consulta.DTRetorno.ToShortDateString());

                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("Não retornou dados");
            }

          
           
        }



        private void frmConsulta_Load(object sender, EventArgs e)
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

                    listPaciente.Add(paciente);
                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("Não retornou dados");
            }
            cmd_PacienteC.DataSource = listPaciente;
            cmd_PacienteC.ValueMember = "Id";
            cmd_PacienteC.DisplayMember = "Nome";

            List<Dentista> listDentista = new List<Dentista>();
            con.conectar();

            SqlDataReader reader2;

            reader2 = con.exeConsulta("select * from tb_dentista");

            if (reader2.HasRows)
            {
                while (reader2.Read())
                {
                    Dentista dentista = new Dentista();
                    dentista.Id = reader2.GetInt32(0);
                    dentista.Nome = reader2.GetString(1);
                    dentista.Cro = reader2.GetString(2);
                    dentista.Sexo = reader2.GetValue(3) == null ? "" : reader2.GetValue(3).ToString();
                    dentista.instagram = reader2.GetValue(4).ToString() == "True" ? 1 : 0;
                    dentista.facebook = reader2.GetValue(5).ToString() == "True" ? 1 : 0;
                    dentista.twitter = reader2.GetValue(6).ToString() == "True" ? 1 : 0;
                    dentista.linkedin = reader2.GetValue(7).ToString() == "True" ? 1 : 0;


                    listDentista.Add(dentista);
                }
                reader2.Close();
            }
            else
            {
                Console.WriteLine("Não retornou dados");
            }

            cmd_DentistaC.DataSource = listDentista;
            cmd_DentistaC.ValueMember = "Id";
            cmd_DentistaC.DisplayMember = "Nome";

            atualizarGrid();
            bloquearCampos();

        }



        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            lerDados();
            con.conectar();
            String sql = "Insert into tb_consulta (id,id_paciente,id_dentista,motivo,diagnostico,receita,motivo_retorno,dt_consulta,dt_retorno) " +
                "values (  " +
                objConsulta.Id + " , " +
                objConsulta.IdPaciente + " , " +
                objConsulta.IdDentista + " , '" +
                objConsulta.Motivo + "' , '" +
                objConsulta.Diagnostico + "' , '" +
                objConsulta.Receita + "' , '" +
                objConsulta.Retorno + "'  ,convert(date,'" + objConsulta.DTConsulta.ToShortDateString() + "', 103) " +
                 ",convert(date,'" + objConsulta.DTRetorno.ToShortDateString() + "', 103)) ";
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

        private void btn_Novo_Click(object sender, EventArgs e)
        {

            con.conectar();
            limparCampos();
            desbloquearCampos();
        }

        private void dvgDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IdC.Text = dvgDados.CurrentRow.Cells[0].Value.ToString();
            cmd_PacienteC.Text = dvgDados.CurrentRow.Cells[1].Value.ToString();
            cmd_DentistaC.Text = dvgDados.CurrentRow.Cells[2].Value.ToString();
            txt_Motivo.Text = dvgDados.CurrentRow.Cells[3].Value.ToString();
            txt_Diagnostico.Text = dvgDados.CurrentRow.Cells[4].Value.ToString();
            txt_Receita.Text = dvgDados.CurrentRow.Cells[5].Value.ToString();
            txt_Retorno.Text = dvgDados.CurrentRow.Cells[6].Value.ToString();
            dtp_Consulta.Value = DateTime.Parse(dvgDados.CurrentRow.Cells[7].Value.ToString());
            dtp_Retorno.Value = DateTime.Parse(dvgDados.CurrentRow.Cells[8].Value.ToString());
        
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

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            var ex = MessageBox.Show("Deseja excluir informaçoes ?", "DenteBão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ex == DialogResult.No)
            {
                bloquearCampos();
                btn_Excluir.Enabled = true;
                btn_Novo.Enabled = true;
                btn_Salvar.Enabled = false;
                btn_Cancelar.Enabled = false;
            }
            else
            {
                String id = dvgDados.CurrentRow.Cells[0].Value.ToString();
                String sql = "delete from tb_consulta where id = " + id;


                btn_Salvar.Enabled = false;
                btn_Cancelar.Enabled = false;
                con.executar(sql);
                atualizarGrid();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

         
}



