using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace novosistema_quarto_bm.telas
{
    public partial class CRUDusuario : Form
    {
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
            txbendereço.Clear();
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
    }
}
