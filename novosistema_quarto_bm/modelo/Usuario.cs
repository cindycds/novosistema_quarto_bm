using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novosistema_quarto_bm.modelo
{
    internal class Usuario
    {
        private int _id;
        private string _nome;
        private string _cpf;
        private string _telefone;
        private string _data_nascimento;
        private string _email;
        private string _senha;
        private string _endereco;



        public Usuario(string nome, string cpf, string telefone, string data_nascimento, string email, string senha, string endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Data_nascimento = data_nascimento;
            Email = email;
            Senha = senha;
            Endereco = endereco; 
        } 
        public Usuario(int id, string nome, string cpf, string telefone, string data_nascimento, string email, string senha, string endereco)
        {
            _id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Data_nascimento = data_nascimento;
            Email = email;
            Senha = senha;
            Endereco = endereco; 
        }

        //--------------------------validações--------------------------------------------


        //validar email
        //chamando uma ferramenta para verificra e validar os emails,new System.Net.Mail.MailAddress(Email);
        static bool ValidarEMAIL(string Email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(Email);
                return addr.Address == Email;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //validar telefon, verifica se o telefone digitado é menor que 11 digitos, se sim ele coloca como falço
        static bool validarTELEFONE(string Telefone)
        {

            Telefone = Telefone.Trim();
            Telefone = Telefone.Replace(".", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            if (Telefone.Length < 11)// (12) 99700*0000
                return false;

            return true;
        }

        //cpf peguei na internet
        static bool validarCPF(string Cpf)
        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma = 0;
            int resto;
            Cpf = Cpf.Trim();
            Cpf = Cpf.Replace(".", "").Replace("-", "");
            if (Cpf.Length != 11)
                return false;
            tempCpf = Cpf.Substring(0, 9);


            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return Cpf.EndsWith(digito);
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

        public string Cpf
        {
            get { return _cpf; }
            set
            {
                if (string.IsNullOrEmpty(value)) // verificando se o cpf é nulo ou vazio, se sim, de a mensagem de erro
                    throw new Exception("O CPF informado não é um texto válido");
                _cpf = value;

                if (validarCPF(_cpf) == false) //usando a validaçao que criei sobre o cpf, para verificar se o mesmo é valido
                    throw new ArgumentException("O CPF informado não é um texto válido");
            }
        }

        public string Data_nascimento
        {
            get { return _data_nascimento; }
            set
            {
                if (string.IsNullOrEmpty(value)) // verificando se o dt é nulo ou vazio, se sim, de a mensagem de erro
                    throw new Exception("A data de nascimento informado não é um texto válido");
                _data_nascimento = value;
            }
        }

        public string Endereco
        {
            get { return _endereco; }
            set
            {
                if (string.IsNullOrEmpty(value)) // verificando se o endereço é nulo ou vazio, se sim, de a mensagem de erro
                    throw new Exception("O endereço informado não é um texto válido");
                _endereco = value;
            }
        }


        //Validação do Email
        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrEmpty(value)) // verificando se o email é nulo ou vazio, se sim, de a mensagem de erro
                    throw new Exception("O E-Mail fornecido não é valido!");
                _email = value;

                if (ValidarEMAIL(Email) == false) //chamando a validaçao de email que foi criada na parte de cima
                    throw new ArgumentException("O E-Mail fornecido não é valido!");
            }
        }

        //Validação do Telefone
        public string Telefone
        {
            get { return _telefone; }
            set
            {
                if (string.IsNullOrEmpty(value)) // verificando se o telefone é nulo ou vazio, se sim, de a mensagem de erro
                    throw new Exception("O telefone informado não é um texto válido");
                _telefone = value;

                if (validarTELEFONE(Telefone) == false) // chamando a validaçao do telefone que foi criada na parte de cima
                    throw new ArgumentException("O telefone informado não é um texto válido\nEntre com o DDD mais 9 digitos do telefone");

            }
        }

        public string Senha
        {
            get { return _senha; }
            set
            {
                if (string.IsNullOrEmpty(value)) // verificando se o senha é nulo ou vazio, se sim, de a mensagem de erro
                    throw new Exception("A senha informado não é um texto válido");
                _senha = value;
            }
        }
    }
}
