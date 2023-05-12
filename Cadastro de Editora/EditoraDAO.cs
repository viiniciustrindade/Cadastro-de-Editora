using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Editora
{
    internal class EditoraDAO
    {
        private SqlConnection Connection { get; }
        public EditoraDAO(SqlConnection connection)
        {
            Connection = connection;
        }
        public void Salvar(EditoraModel codEditora)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    //Excluir(codAutor, t);

                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"INSERT INTO mvtBibEditora(nomeEditora) VALUES(@nome)");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@nome", codEditora.nomeEditora));

                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }

                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }
        public void Alterar(EditoraModel codEditora)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    //Excluir(codAutor, t);

                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"UPDATE mvtBibEditora SET nomeEditora = @nome WHERE codEditora = @codEditora");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@codEditora", codEditora.codEditora);
                    command.Parameters.Add(new SqlParameter("@nome", codEditora.nomeEditora));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }

                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }
        public void Excluir(EditoraModel codEditora, SqlTransaction t = null)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                if (t != null)
                {
                    command.Transaction = t;
                }
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"DELETE FROM mvtBibEditora WHERE codEditora=@codEditora");
                command.CommandText = sql.ToString();
                command.Parameters.Add(new SqlParameter("@codEditora", codEditora.codEditora));
                command.ExecuteNonQuery();
            }
        }
        public List<EditoraModel> GetEditoras()
        {
            List<EditoraModel> editoras = new List<EditoraModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT EDI.codEditora, EDI.nomeEditora FROM mvtBibEditora EDI");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        editoras.Add(PopulateDr(dr));
                    }
                }
            }
            return editoras;
        }
        private EditoraModel PopulateDr(SqlDataReader dr)
        {
            string codEditora = "";
            string nomeEditora = "";
            if (DBNull.Value != dr["codEditora"])
            {
                codEditora = dr["codEditora"] + "";
            }
            if (DBNull.Value != dr["nomeEditora"])
            {
                nomeEditora = dr["nomeEditora"] + "";
            }
            return new EditoraModel()
            {
                codEditora = codEditora,
                nomeEditora = nomeEditora,
            };
        }
    }
}
