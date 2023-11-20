using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using novosistema_quarto_bm.modelo;
using novosistema_quarto_bm.telas;

namespace novosistema_quarto_bm
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        //LIMPAR CAIXINHAS
        private void limpar_Click(object sender, EventArgs e)
        {
            txbsenha.Clear();  //limpa textbox
            txbusuario.Clear();  //limpa textbox
            txbusuario.Focus(); //aparece o pausinho de volta para o usuario
;        }

        //MOSTRA A SENHA
        private void mostrar_senha_CheckedChanged(object sender, EventArgs e)
        {
            if(mostrar_senha.Checked) //se estiver selecionado mostra o icone da senha,senao mostra * 
            {
                txbsenha.PasswordChar = default; // se estiver ativo mostra o icone, defaut deixa padrao
            }
            else
            {
                txbsenha.PasswordChar = '*'; //senao mostra o *
            }
        }


        //toda vez que o texto mudar, coloca o *
        private void txbsenha_TextChanged(object sender, EventArgs e)
        {
            txbsenha.PasswordChar = '*'; //senao mostra o *
        }

        private void button_entrar_Click(object sender, EventArgs e)
        {
            bool vdd;
            string email = txbusuario.Text, senha = txbsenha.Text ;

            UsuarioDAO usuarioDAO = new UsuarioDAO();

            vdd = usuarioDAO.Login(email,senha); // conferira se retornou os dados verdadeiros

            if (vdd)//caso sim,entrara aqui dentro
            {
                MessageBox.Show("Logado com sucesso. Seja bem vindo!"); //me dara uma mensagem de bem vindo
                new menu().Show(); //chama a tela de menu
                this.Hide(); //oculta a tela de login
            }

            else if (txbusuario.Text ==string.Empty || txbsenha.Text == string.Empty)//se caso algum dos campos estiver vazio,entra aqui
            {
                MessageBox.Show("preencha todos os campos vazios!"); //aqui me dara uma mensagem para preencher os campos ja que tem algum vazio
                txbsenha.Clear();  //limpa
                txbusuario.Clear(); //limpa
                txbusuario.Focus();//foca no login novamente

            }
            else //se caso a variavel retornar falsa,que é quando nao entrar no login, significa que nao achou nenhum usuario compativel
            {
                MessageBox.Show("Dados incorretos!\nSeu usuario ou senha estao incorretos"); // me da a mensagem de que os dados estao incorretos
                txbsenha.Clear();
                txbusuario.Clear();
                txbusuario.Focus();
            }


        }
    }
}
