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
                itar.Deletar_Clientes(int.Parse(txt_id.Text));
            }
            else
            {
                MessageBox.Show("Insira o id da venda a ser excluida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            Clientes tar = new Clientes();
            IClientes itar = new DAL_Clientes();
            if (string.IsNullOrWhiteSpace(txt_id.Text))
            {
                tar.nome = txt_nome.Text;
                tar.email = txt_email.Text;
                itar.Inserir_Clientes(tar);
                LimparCampos();
            }
            else
            {
                MessageBox.Show("O campo Id só é usado para o metodo Editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                MessageBox.Show("Insira o id da cartegoria a ser editado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            FRM_ClientesSelect f = new FRM_ClientesSelect();
            f.ShowDialog();
        }
    }
}
