using System;
using novosistema_quarto_bm.modelo;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BCrypt.Net.BCrypt;
using BCrypt.Net;
namespace novosistema_quarto_bm.telas
{
    public partial class CRUDusuario : Form
    {
        private int Id;
        public CRUDusuario()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close(); //fechara somente a tela
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limpar();  //chamando a funçao
        }

        //uma funçao que limpa as txbox
        public void limpar()
        {
            txbnome.Clear();
            txbcpf.Clear();
            txbendereco.Clear();
            txbtelefone.Clear();
            txbsenha.Clear();
            txbemail.Clear();
            txbnome.Focus();
        }

        private void mostrar_senha_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrar_senha.Checked) //se estiver selecionado mostra o icone da senha,senao mostra * 
            {
                txbsenha.PasswordChar = default; // se estiver ativo mostra o icone, defaut deixa padrao
            }
            else
            {
                txbsenha.PasswordChar = '*'; //senao mostra o *
            }
        }

        private void txbsenha_TextChanged(object sender, EventArgs e)
        {
            txbsenha.PasswordChar = '*';//asssim que escrever algo ja sera escrito com *
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            CRUDusuario crud = new CRUDusuario();
            string senhacripto; //string para colocar a senha criptografada
            senhacripto = txbsenha.Text; //passando para a string o valor da txb

            senhacripto = HashPassword(senhacripto,12); //criptografando senha

            DateTime data1 = datadenas.SelectionStart;
            string data2 = data1.ToString();
            try
            {
                Usuario user;

                if (Id == 0) //se id for igual a 0 significa que estou cadastrando 
                {
                    user = new Usuario(
                    txbnome.Text,
                    txbcpf.Text,
                    txbtelefone.Text,
                    data2,
                    txbemail.Text,
                    senhacripto,
                    txbendereco.Text
                    ) ;
                }
                else //para atualizar, caso ja existir um id quer dizer que quero atualizar
                {
                    user = new Usuario(
                    Id,
                   txbnome.Text,
                    txbcpf.Text,
                    txbtelefone.Text,
                    data2,
                    txbemail.Text,
                    senhacripto,
                    txbendereco.Text
                    
                    ); 
                    
                }
                UsuarioDAO usuarioInserir = new UsuarioDAO();

                if (Id == 0)
                    usuarioInserir.Inserir(user);
                else
                    //usuarioInserir.Atualizar(pac);

                MessageBox.Show("Usuário " + user.Nome + (Id == 0 ? " Inserido!" : " Atualizado!"), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                limpar();
                //crud.AtualizarListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datadenas_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
