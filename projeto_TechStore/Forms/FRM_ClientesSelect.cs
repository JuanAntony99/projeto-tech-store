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
    public partial class FRM_ClientesSelect : Form
    {
        public FRM_ClientesSelect()
        {
            InitializeComponent();
        }

        private void FRM_ClientesSelect_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }
        private void ListarClientes()
        {
            //id_selecionado = 0;
            //btn_deletar.Enabled = false;
            DAL_Clientes dp = new DAL_Clientes();

            dvg_clientes.DataSource = dp.Selecionar_Clientes();
        }
    }
}
