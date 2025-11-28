using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto_TechStore.Classes;
using projeto_TechStore.DAL;
using projeto_TechStore.Forms;
using projeto_TechStore.Interfaces;

namespace projeto_TechStore
{
    public partial class FRM_Produtos : Form
    {
        public FRM_Produtos()
        {
            InitializeComponent();
        }

        private void txt_idcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_limparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txt_id.Text = string.Empty;
            txt_preco.Text = string.Empty;
            txt_nome.Text = string.Empty;
            txt_nome.Focus();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            IProdutos itar = new DAL_Produtos();

            if (!(string.IsNullOrWhiteSpace(txt_id.Text)))
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o produto?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    itar.Deletar_Produto(int.Parse(txt_id.Text));
                }
            }
            else
            {
                MessageBox.Show("Insira o ID do produto a ser excluído", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Produtos tar = new Produtos();
            IProdutos itar = new DAL_Produtos();
            if (!(string.IsNullOrWhiteSpace(txt_id.Text)))
            {
                tar.id = int.Parse(txt_id.Text);
                tar.nome = txt_nome.Text;
                tar.preco = decimal.Parse(txt_preco.Text);
                itar.Editar_Produto(tar);
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Insira o id da cartegoria a ser editado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            Produtos produto = new Produtos();
            IProdutos dal_produtos = new DAL_Produtos();
            bool a = Isnull();
            if (string.IsNullOrWhiteSpace(txt_id.Text) && a)
            {
                produto.nome = txt_nome.Text;
                produto.preco = decimal.Parse(txt_preco.Text);
                dal_produtos.Inserir_Produto(produto);
                LimparCampos();
            }
            else if (!string.IsNullOrWhiteSpace(txt_id.Text))
            {
                MessageBox.Show("O campo ID só é usado para o método Editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!a)
            {
                MessageBox.Show("Insira dados para completar a operação", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Isnull()
        {
            if (string.IsNullOrEmpty(txt_nome.Text) && string.IsNullOrEmpty(txt_preco.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ProdutosSelect f = new FRM_ProdutosSelect();
            f.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
