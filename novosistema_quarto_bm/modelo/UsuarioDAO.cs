using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using novosistema_quarto_bm.utilidade;

namespace novosistema_quarto_bm.modelo
{
    internal class UsuarioDAO
    {
        private conexao Con { get; set; } //criando uma variavel para chamar uma conexao com o banco d dados
        private SqlCommand Cmd { get; set; }//comandos do sql
        public UsuarioDAO()
        {
            Con = new conexao();
            Cmd = new SqlCommand();
        }

        public SqlDataReader rd; //lendo o sql
        public bool Login(string email, string senha) 
        {
            //uma função boleana, ou verdadeira ou falsa, se caso nao der resultado, entao é falso e nao deixara logar
            bool vdd = false, tem = false;
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"SELECT * FROM usuarios WHERE email = @Email";
            Cmd.Parameters.AddWithValue("@Email", email);

            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(Cmd);
                da.Fill(dt);
                da.Dispose();

                string senhaveri = "";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    senhaveri = dt.Rows[i]["senha"].ToString();
                }

                if (!(senhaveri == ""))
                    vdd= BCrypt.Net.BCrypt.Verify(senha, senhaveri);

                rd = Cmd.ExecuteReader();
                if (vdd)
                {
                    if (rd.HasRows)
                        tem = true;
                }

            }
            catch (SqlException err)
            {
                throw new Exception("Erro: Problemas no banco de dados.\n" + err.Message);
            }
            rd.Close();

            return tem;
        }
        public void Inserir(Usuario  usuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO usuarios(email, senha, nome, cpf, telefone, endereco, data_nascimento) VALUES(@Email, @Senha, @Nome, @Cpf, @Telefone, @Endereco, @Data_nascimento)";

            Cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
            Cmd.Parameters.AddWithValue("@CPF", usuario.Cpf);
            Cmd.Parameters.AddWithValue("@Data_nascimento", usuario.Data_nascimento);
            Cmd.Parameters.AddWithValue("@Endereco", usuario.Endereco);
            Cmd.Parameters.AddWithValue("@Email", usuario.Email);
            Cmd.Parameters.AddWithValue("@Telefone", usuario.Telefone);
            Cmd.Parameters.AddWithValue("@Senha", usuario.Senha);

            try
            {
                //Executa query definida acima.
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir usuario no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
    }
}
