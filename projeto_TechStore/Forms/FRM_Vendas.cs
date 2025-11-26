using projeto_TechStore.Classes;
using projeto_TechStore.DAL;
using projeto_TechStore.Forms;
using projeto_TechStore.Interfaces;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            DAL_Clientes clientes = new DAL_Clientes();
            comboBox1.DataSource = clientes.Selecionar_Clientes();
            comboBox1.DisplayMember = "nome";
            comboBox1.ValueMember = "id";

            DAL_Produtos produtos = new DAL_Produtos();
            comboBox2.DataSource = produtos.Selecionar_Produto();
            comboBox2.DisplayMember = "nome";
            comboBox2.ValueMember = "id";

            LimparCampos();
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
                tar.ID_Cliente = Convert.ToInt32(comboBox1.SelectedValue);
                tar.ID_Produto = Convert.ToInt32(comboBox2.SelectedValue);
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
            if (string.IsNullOrEmpty(comboBox1.Text) && string.IsNullOrEmpty(comboBox2.Text) && string.IsNullOrEmpty(txt_quantidade.Text) && string.IsNullOrEmpty(txt_dataVenda.Text))
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
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            txt_quantidade.Text = string.Empty;
            comboBox1.Focus();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Vendas tar = new Vendas();
            IVendas itar = new DAL_Vendas();
            if (!(string.IsNullOrWhiteSpace(txt_id.Text)))
            {
                tar.id = int.Parse(txt_id.Text);
                tar.ID_Cliente = Convert.ToInt32(comboBox1.SelectedValue);
                tar.ID_Produto = Convert.ToInt32(comboBox2.SelectedValue);
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FRM_Vendas_Leave(object sender, EventArgs e)
        {

        }

        private void txt_idcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            // rodar funcao para preencher os campos ao digitar o id
            exibirDadosDoID(txt_id.Text);
        }

        private void exibirDadosDoID(string id)
        {
            IVendas itar = new DAL_Vendas();
            DataTable vendadatatable;
            if (string.IsNullOrWhiteSpace(id))
            {
                // Se o ID estiver vazio, limpar os campos e sair
                LimparCampos();
                vendadatatable = null;
            }
            else
            {
                vendadatatable = itar.Selecionar_Vendas_porID(int.Parse(id));
            }
            if (vendadatatable != null && vendadatatable.Rows.Count > 0)
            {
                try
                {
                    DataRow venda = vendadatatable.Rows[0];

                    // 1. Coluna 'id' (correto!)
                    //txt_id.Text = venda["id"].ToString();

                    // 2. Coluna 'ID_Cliente' (ATENÇÃO: I e C maiúsculos)
                    comboBox1.SelectedValue = Convert.ToInt32(venda["ID_Cliente"]);
                    
                    // 3. Coluna 'ID_Produto' (ATENÇÃO: I e P maiúsculos)
                    comboBox2.SelectedValue = Convert.ToInt32(venda["ID_Produto"]);

                    // 4. Coluna 'quantidade' (tudo minúsculo)
                    txt_quantidade.Text = venda["quantidade"].ToString();

                    // 5. Coluna 'dataVenda' (ATENÇÃO: 'V' maiúsculo)
                    // Também, use o Field<T> para garantir que a data seja lida corretamente
                    DateTime data = venda.Field<DateTime>("dataVenda");
                    txt_dataVenda.Text = data.ToShortDateString();
                }
                catch (Exception ex)
                {
                    // O bloco try-catch te ajudará a ver exatamente qual coluna causou o erro 
                    // se o problema for de conversão de tipo (ex: tentar ler uma string como int).
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
            // ... restante
        }
    }
}
