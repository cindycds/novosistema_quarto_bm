using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using novosistema_quarto_bm.modelo;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace novosistema_quarto_bm.telas
{
    public partial class CRUDsorvetes : Form
    {
        private int Id;
        private int ID = -1;
        public CRUDsorvetes()
        {
            InitializeComponent();
        }



        private void labelname_Click(object sender, EventArgs e)
        {

        }

        private void txbnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void data_val_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                Estoque estoque;

                if (Id == 0) //se id for igual a 0 significa que estou cadastrando 
                {
                    estoque = new Estoque(
                    txbnomedosorvete.Text,
                    data_val.Text,
                    data_fabri.Text,
                    txbquantidade.Text
                    );
                }
                else //para atualizar, caso ja existir um id quer dizer que quero atualizar
                {
                    estoque = new Estoque(
                    Id,
                   txbnomedosorvete.Text,
                    data_val.Text,
                    data_fabri.Text,
                    txbquantidade.Text

                    );

                }
                EstoqueDAO estoqueInserir = new EstoqueDAO();

                if (Id == 0)
                {
                    estoqueInserir.Inserir(estoque);
                    MessageBox.Show("sorvete inserido com sucesso!!!");
                }
                else
                    estoqueInserir.Atualizar(estoque);

                MessageBox.Show("Estoque " + estoque.Nome + (Id == 0 ? " Inserido!" : " Atualizado!"), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);


                limpar();
                AtualizarListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        //uma funçao que limpa as txbox
        public void limpar()
        {
            txbnomedosorvete.Clear();
            txbquantidade.Clear();
            txbnomedosorvete.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CRUDsorvetes_Load(object sender, EventArgs e)
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
        public void AtualizarListView()
        {
            EstoqueDAO EstoqueDao = new EstoqueDAO();
            listView1.Items.Clear();


            List<Estoque> estoque = EstoqueDao.ListarEstoque();
            if (estoque.Count > 0)
            {
                foreach (var est in estoque )
                {
                    ListViewItem lv = new ListViewItem(est.Id.ToString());
                    lv.SubItems.Add(est.Nome);
                    lv.SubItems.Add(est.Quantidade);
                    lv.SubItems.Add(est.Data_fabricacao);
                    lv.SubItems.Add(est.Data_validade);


                    listView1.Items.Add(lv);  //Adiciona a linha criada ao listView.
                }
            }
            // Se não houver elementos, mesclar as colunas e exibir apenas um texto para o usuário.
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
                        new EstoqueDAO().Excluir(ID);
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
            txbnomedosorvete.Text = listView1.Items[index].SubItems[1].Text;
            txbquantidade.Text = listView1.Items[index].SubItems[4].Text;
        }

        public void pdf()
        {
            EstoqueDAO estoqueDAO = new EstoqueDAO();
            List<Estoque> estoque = estoqueDAO.ListarEstoque();

            Document doc = new Document(PageSize.A4.Rotate());
            doc.SetMargins(5, 5, 15, 15);
            doc.AddCreationDate();

            string caminho = @"C:\Users\gabri\" + "estoque.pdf";

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
            doc.Open();

            string dados = "";



            Paragraph paragrafo = new Paragraph();
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add("Estoque da sorveteria\n\n");

            doc.Add(paragrafo);
            PdfPTable table = new PdfPTable(4);

          


            PdfPCell celula = new PdfPCell();

            celula.Phrase = new Phrase("Nome do produto");
            celula.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            table.AddCell(celula);

            celula.Phrase = new Phrase("Data de validade");
            celula.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            table.AddCell(celula);

            celula.Phrase = new Phrase("Data de fabricação");
            celula.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            table.AddCell(celula);

            celula.Phrase = new Phrase("Quantidade");
            celula.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            table.AddCell(celula);


            foreach (var esto in estoque)
            {
                celula.Phrase = new Phrase(Convert.ToString(esto.Nome));
                celula.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED;
                table.AddCell(celula);

                celula.Phrase = new Phrase(Convert.ToString(esto.Quantidade));
                celula.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED;
                table.AddCell(celula);

                celula.Phrase = new Phrase(Convert.ToString(esto.Data_fabricacao));
                celula.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED;
                table.AddCell(celula);

                celula.Phrase = new Phrase(Convert.ToString(esto.Data_validade));
                celula.HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED;
                table.AddCell(celula);

            }

            doc.Add(table);
            doc.Close();
            //System.Diagnostics.Process.Start(caminho);
        }
    }
}
