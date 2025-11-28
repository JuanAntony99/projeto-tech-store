using projeto_TechStore.Classes;
using projeto_TechStore.DAL;
using projeto_TechStore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_TechStore.Forms
{
    public partial class FRM_Clientes : Form
    {
        public FRM_Clientes()
        {
            InitializeComponent();
        }

        private void btn_limparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txt_id.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_nome.Text = string.Empty;
            txt_nome.Focus();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            IClientes itar = new DAL_Clientes();

            if (!(string.IsNullOrWhiteSpace(txt_id.Text)))
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o cliente?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if ((result == DialogResult.Yes))
                {
                    itar.Deletar_Clientes(int.Parse(txt_id.Text));
                }
            }
            else
            {
                MessageBox.Show("Insira o ID do cliente a ser excluido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ListarClientes();
        }
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            Clientes tar = new Clientes();
            IClientes itar = new DAL_Clientes();
            bool a = Isnull();
            if (string.IsNullOrWhiteSpace(txt_id.Text) && a)
            {
                tar.nome = txt_nome.Text;
                tar.email = txt_email.Text;
                tar.telefone = string.IsNullOrWhiteSpace(txt_telefone.Text) ? null : txt_telefone.Text;
                tar.cpf = string.IsNullOrWhiteSpace(txt_cpf.Text) ? null : txt_cpf.Text;

                itar.Inserir_Clientes(tar);
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
            ListarClientes();
        }
        //private void btn_adicionar_Click(object sender, EventArgs e)
        //{
        //    Clientes tar = new Clientes();
        //    IClientes itar = new DAL_Clientes();
        //    bool a = Isnull();
        //    if (string.IsNullOrWhiteSpace(txt_id.Text) && a)
        //    {
        //        tar.nome = txt_nome.Text;
        //        tar.email = txt_email.Text;
        //        itar.Inserir_Clientes(tar);
        //        LimparCampos();
        //    }
        //    else if (!string.IsNullOrWhiteSpace(txt_id.Text))
        //    {
        //        MessageBox.Show("O campo ID só é usado para o método Editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else if (!a)
        //    {
        //        MessageBox.Show("Insira dados para completar a operação", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    ListarClientes();
        //}


        private bool Isnull()
        {
            if (string.IsNullOrEmpty(txt_nome.Text) && string.IsNullOrEmpty(txt_email.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Clientes tar = new Clientes();
            IClientes itar = new DAL_Clientes();
            if (!(string.IsNullOrWhiteSpace(txt_id.Text)))
            {
                tar.id = int.Parse(txt_id.Text);
                tar.nome = txt_nome.Text;
                tar.email = txt_email.Text;
                itar.Editar_Clientes(tar);
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Insira o ID do cliente a ser editado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ListarClientes();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            FRM_ClientesSelect f = new FRM_ClientesSelect();
            f.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FRM_Clientes_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            // rodar funcao para preencher os campos ao digitar o id
            exibirDadosDoID(txt_id.Text);
        }

        private void exibirDadosDoID(string id)
        {
            IClientes itar = new DAL_Clientes();
            DataTable clientesdatatable;
            if (string.IsNullOrWhiteSpace(id))
            {
                // Se o ID estiver vazio, limpar os campos e sair
                LimparCampos();
                clientesdatatable = null;
            }
            else
            {
                clientesdatatable = itar.Selecionar_Clientes_porID(int.Parse(id));
            }
            if (clientesdatatable != null && clientesdatatable.Rows.Count > 0)
            {
                try
                {
                    DataRow clientes = clientesdatatable.Rows[0];

                    txt_nome.Text = clientes["nome"].ToString();
                    txt_email.Text = clientes["email"].ToString();
                    // aqui vai dar erro pq ainda nao tem essas colunas no db,
                    // nao precisa mudar a dal ela ta fazendo select *
                    txt_telefone.Text = clientes["telefone"].ToString();
                    txt_cpf.Text = clientes["cpf"].ToString();

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

        private void ListarClientes()
        {
            DAL_Clientes dp = new DAL_Clientes();

            dvg_clientes.DataSource = dp.Selecionar_Clientes();
        }

        private void txt_telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_telefone_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_cpf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
