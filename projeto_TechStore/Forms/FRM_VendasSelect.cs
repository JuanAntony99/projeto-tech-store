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
    public partial class FRM_VendasSelect : Form
    {
        public FRM_VendasSelect()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FRM_VendasSelect_Load(object sender, EventArgs e)
        {
            ListarVendas();
        }
        private void ListarVendas()
        {
            //id_selecionado = 0;
            //btn_deletar.Enabled = false;
            DAL_Vendas dp = new DAL_Vendas();

            dvg_vendas.DataSource = dp.Selecionar_Vendas();
        }

        private void dvg_vendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
