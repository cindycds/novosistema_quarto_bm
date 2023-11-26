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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        //botao para sair
        private void button_SAIR_Click(object sender, EventArgs e)
        {
            Application.Exit(); //fecha o app
        }

        //botao cadastrar
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            new CRUDusuario().Show(); //chamando a tela CRUDusuarios
        }

        private void estoque_Click(object sender, EventArgs e)
        {
            new CRUDsorvetes().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUDsorvetes sovertinho = new CRUDsorvetes();

            sovertinho.pdf();
        }
    }
}
