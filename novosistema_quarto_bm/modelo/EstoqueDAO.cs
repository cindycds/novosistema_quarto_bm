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
    internal class EstoqueDAO
    {
        private conexao Con { get; set; } //criando uma variavel para chamar uma conexao com o banco d dados
        private SqlCommand Cmd { get; set; }//comandos do sql
        public EstoqueDAO()
        {
            Con = new conexao();
            Cmd = new SqlCommand();
        }

        public SqlDataReader rd; //lendo o sql
        
        public void Inserir(Estoque  estoque)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO estoque(nome, quantidade, data_fabricacao, data_validade) VALUES(@Nome, @Quantidade, @Data_fabricacao, @Data_validade)";

            Cmd.Parameters.AddWithValue("@Nome", estoque.Nome);
            Cmd.Parameters.AddWithValue("@Quantidade", estoque.Quantidade);
            Cmd.Parameters.AddWithValue("@Data_fabricacao", estoque.Data_fabricacao);
            Cmd.Parameters.AddWithValue("@Data_validade", estoque.Data_validade);
           

            try
            {
                //Executa query definida acima.
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir sorvete no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }



        public void Atualizar(Estoque estoque)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"Update estoque set nome = @Nome, quantidade = @Quantidade,data_fabricacao = @Data_fabricacao, data_validade = @Data_validade  WHERE id = @Id";

            Cmd.Parameters.AddWithValue("@Id", estoque.Id);
            Cmd.Parameters.AddWithValue("@Nome", estoque.Nome);
            Cmd.Parameters.AddWithValue("@Quantidade", estoque.Quantidade);
            Cmd.Parameters.AddWithValue("@Data_fabricacao", estoque.Data_fabricacao);
            Cmd.Parameters.AddWithValue("@Data_validade", estoque.Data_validade );

            try
            {
                //Executa query definida acima.
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir estoque no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }


        public List<Estoque> ListarEstoque()
        {

            Cmd.Connection = Con.ReturnConnection();

            Cmd.CommandText = "SELECT * FROM Estoque"; //fazendo um select na tabela

            List<Estoque> listaDeEstoque = new List<Estoque>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Estoque estoque = new Estoque((int)rd["id"], (string)rd["Nome"],
                        (string)rd["quantidade"], (string)rd["data_fabricacao"], (string)rd["data_validade"]);
                        
                    listaDeEstoque.Add(estoque);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de sorvetes no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

            return listaDeEstoque;
        }
        public void Excluir(int Id)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE FROM estoque WHERE id = @id";
            Cmd.Parameters.AddWithValue("@id", Id);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir sorvete no banco\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
    }
}
