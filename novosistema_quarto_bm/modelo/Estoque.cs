using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace novosistema_quarto_bm.modelo
{
    internal class Estoque
    {
        private int _id;
        private string _nome;
        private string _data_validade;
        private string _data_fabricacao;
        private string _quantidade;

        public Estoque(string nome, string data_validade, string data_fabricacao, string quantidade)
        {
            Nome = nome;
            Data_validade = data_validade;
            Data_fabricacao = data_fabricacao;
            Quantidade = quantidade;

        }
        public Estoque(int id, string nome, string data_validade, string data_fabricacao, string quantidade)
        { 
            _id = id;
            Nome = nome;
            Data_validade = data_validade;
            Data_fabricacao = data_fabricacao;
            Quantidade = quantidade;
        }

        //id
        public int Id
        {
            get { return _id; }
        }
        //Validação do Nome.
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value)) // verificando se o nome é nulo ou vazio, se sim, de a mensagem de erro
                    throw new Exception("O nome informado não é um texto válido");
                _nome = value;
            }
        }


        public string Data_validade
        {
            get { return _data_validade; }
            set
            {
                if (string.IsNullOrEmpty(value)) // verificando se o nome é nulo ou vazio, se sim, de a mensagem de erro
                    throw new Exception("O data de validade informado não é um texto válido");
                _data_validade = value;
            }
        }


        public string Data_fabricacao
        {
            get { return _data_fabricacao; }
            set
            {
                if (string.IsNullOrEmpty(value)) // verificando se o nome é nulo ou vazio, se sim, de a mensagem de erro
                    throw new Exception("O data de fabricação informado não é um texto válido");
                _data_fabricacao = value;
            }
        }


        public string Quantidade
        {
            get { return _quantidade; }
            set
            {
                if (string.IsNullOrEmpty(value)) // verificando se o nome é nulo ou vazio, se sim, de a mensagem de erro
                    throw new Exception("A quantidade informada não é um texto válido");
                _quantidade = value;
            }
        }



    }


}
