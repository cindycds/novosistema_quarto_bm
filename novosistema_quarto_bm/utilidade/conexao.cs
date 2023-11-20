using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novosistema_quarto_bm.utilidade
{
    internal class conexao
    

        //conectando com o banco de dados
        {
        private readonly SqlConnection con;
        private readonly string DataBase = "sorveteria_milkshackper";
        public conexao()                            
        {
            string stringConnection = @"Data Source=" + "DESKTOP-KHGPJOE;Initial Catalog=" + DataBase + ";Integrated Security=true";

            con = new SqlConnection(stringConnection);
            con.Open();   //Abrir a conexão com o banco de dados
        }

        //Tenta fechar a conexão com o banco
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        //Retorna a conexão que foi aberta
        public SqlConnection ReturnConnection()
        {
            return con;
        }
    
}
}
