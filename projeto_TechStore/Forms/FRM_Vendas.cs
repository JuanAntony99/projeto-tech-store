using System;
using System.Windows.Forms;
using projeto_TechStore.Classes;
using projeto_TechStore.DAL;
using projeto_TechStore.Forms;
using projeto_TechStore.Interfaces;

namespace projeto_TechStore
{
    public partial class FRM_Vendas : Form
    {
        private Form frmAtivo;
        public FRM_Vendas()
        {
            InitializeComponent();
        }

        private void FRM_Tarefas_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            Vendas tar = new Vendas();
            IVendas itar = new DAL_Vendas();
            bool a = Isnull();
            if (string.IsNullOrWhiteSpace(txt_id.Text) && a)
            {
                tar.ID_Cliente = int.Parse(txt_idcliente.Text);
                tar.ID_Produto = int.Parse(txt_idproduto.Text);
                //tar.
                tar.quantidade = int.Parse(txt_quantidade.Text);
                tar.dataVenda = txt_dataVenda.Text;
                itar.Inserir_Vendas(tar);
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
            if (string.IsNullOrEmpty(txt_idcliente.Text) && string.IsNullOrEmpty(txt_idproduto.Text) && string.IsNullOrEmpty(txt_quantidade.Text) && string.IsNullOrEmpty(txt_dataVenda.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_limparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txt_id.Text = string.Empty;
            txt_dataVenda.Text = string.Empty;
            txt_idcliente.Text = string.Empty;
            txt_idproduto.Text = string.Empty;
            txt_quantidade.Text = string.Empty;
            txt_idcliente.Focus();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Vendas tar = new Vendas();
            IVendas itar = new DAL_Vendas();
            if (!(string.IsNullOrWhiteSpace(txt_id.Text)))
            {
                tar.id = int.Parse(txt_id.Text);
                tar.ID_Cliente = int.Parse(txt_idcliente.Text);
                tar.ID_Produto = int.Parse(txt_idproduto.Text);
                //tar.
                tar.quantidade = int.Parse(txt_quantidade.Text);
                tar.dataVenda = txt_dataVenda.Text;
                itar.Editar_Vendas(tar);
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Insira o ID da cartegoria a ser editado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            IVendas itar = new DAL_Vendas();

            if (!(string.IsNullOrWhiteSpace(txt_id.Text)))
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir a venda?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    itar.Deletar_Vendas(int.Parse(txt_id.Text));
                }
            }
            else
            {
                MessageBox.Show("Insira o ID da venda a ser excluida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_idproduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            FRM_VendasSelect f = new FRM_VendasSelect();
            f.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
