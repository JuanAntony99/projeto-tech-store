using projeto_TechStore.DAL;
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
    public partial class FRM_ProdutosSelect : Form
    {
        public FRM_ProdutosSelect()
        {
            InitializeComponent();
        }

        private void dvg_vendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FRM_ProdutosSelect_Load(object sender, EventArgs e)
        {
            ListarProdutos();
        }
        private void ListarProdutos()
        {
            //id_selecionado = 0;
            //btn_deletar.Enabled = false;
            DAL_Produtos dp = new DAL_Produtos();

            dvg_produtos.DataSource = dp.Selecionar_Produto();
        }
    }
}
