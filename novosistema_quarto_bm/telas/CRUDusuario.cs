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
        private int ID = -1;
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
                {
                    usuarioInserir.Inserir(user);
                    MessageBox.Show("Usuario inserido com sucesso!!!");
                }
                else
                    usuarioInserir.Atualizar(user );

                    MessageBox.Show("Usuário " + user.Nome + (Id == 0 ? " Inserido!" : " Atualizado!"), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                limpar();
                AtualizarListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datadenas_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void AtualizarListView()
        {
            UsuarioDAO UsuarioDao = new UsuarioDAO();
            listView1.Items.Clear();


            List<Usuario> usuarios = UsuarioDao.ListarTodosUsuarios();
            if (usuarios.Count > 0)
            {
                foreach (var user in usuarios)
                {
                    ListViewItem lv = new ListViewItem(user.Id.ToString());
                    lv.SubItems.Add(user.Nome);
                    lv.SubItems.Add(user.Cpf);
                    lv.SubItems.Add(user.Telefone);
                    lv.SubItems.Add(user.Email);
                    lv.SubItems.Add(user.Endereco);
                    lv.SubItems.Add(user.Data_nascimento );
                   

                    listView1.Items.Add(lv);  //Adiciona a linha criada ao listView.
                }
            }
            // Se não houver elementos, mesclar as colunas e exibir apenas um texto para o usuário.
        }

        private void CRUDusuario_Load(object sender, EventArgs e)
        {
            try
            {
                AtualizarListView();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnexcluiruser_Click(object sender, EventArgs e)
        {
            if (ID != -1)
            {
                DialogResult resultado = MessageBox.Show("Deseja excluir?", "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        new UsuarioDAO().Excluir(ID);
                    }

                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Aviso de erro!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    AtualizarListView();
                }
            }
            else
            {
                MessageBox.Show("Erro! nada selecionado...");
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            ID = int.Parse(listView1.Items[index].SubItems[0].Text);
            //muda o valor do id de -1´para o valor de focus
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;

            Id = int.Parse(listView1.Items[index].SubItems[0].Text);
            txbnome.Text = listView1.Items[index].SubItems[1].Text;
            txbcpf.Text = listView1.Items[index].SubItems[2].Text;
            txbtelefone.Text = listView1.Items[index].SubItems[3].Text;
            txbendereco.Text = listView1.Items[index].SubItems[5].Text;
            txbemail.Text = listView1.Items[index].SubItems[4].Text;
            datadenas.Text = listView1.Items[index].SubItems[6].Text;

        }
    }
}
