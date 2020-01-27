using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DenteBam
{
    class conexao
    {
        private String dadosCon = @"server=LAB604-20;DATABASE=DenteBam; INTEGRATED SECURITY = TRUE;";

        private SqlConnection sqlCon;

        public void conectar()
        {
            sqlCon = new SqlConnection(dadosCon);

            try
            {
                sqlCon.Open();
                Console.WriteLine("Conectado!");
            }
            catch (SqlException sqlE)
            {
                Console.WriteLine("Erro: " + sqlE);
            }
        }

        public void desconectar()
        {
            sqlCon.Close();
        }

        public int executar(String sql)
        {
            SqlCommand sqlc = new SqlCommand(sql, sqlCon);
            return sqlc.ExecuteNonQuery();
        }

        public SqlDataReader exeConsulta(String sql)
        {
            SqlCommand sqlc = new SqlCommand(sql, sqlCon);
            return sqlc.ExecuteReader();
        }
        public static void EditarDentista(Dentista dentista)
        {
            conexao conexao = new conexao();
            conexao.conectar();

           

            int linhas = conexao.executar("UPDATE tb_dentista SET nome = '" + dentista.Nome + "' WHERE id =" + dentista.Id);
            int linhas1 = conexao.executar("UPDATE tb_dentista SET cro = '" + dentista.Cro + "' WHERE id =" + dentista.Id);
            int linhas2 = conexao.executar("UPDATE tb_dentista SET sexo = '" + dentista.Sexo + "' WHERE id =" + dentista.Id);           
            int linhas3 = conexao.executar("UPDATE tb_dentista SET instagram = '" + dentista.instagram + "' WHERE id =" + dentista.Id);
            int linhas4 = conexao.executar("UPDATE tb_dentista SET linkedin = '" + dentista.linkedin + "' WHERE id =" + dentista.Id);
            int linhas5 = conexao.executar("UPDATE tb_dentista SET facebook = '" + dentista.facebook + "' WHERE id =" + dentista.Id);
            int linhas6 = conexao.executar("UPDATE tb_dentista SET twitter = '" + dentista.twitter + "' WHERE id =" + dentista.id);
        }
    }

}