using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto_TechStore.DAL;
using projeto_TechStore.Forms;

namespace projeto_TechStore
{
    public partial class FRM_Principal : Form
    {
        private Form frmAtivo;
        public FRM_Principal()
        {
            InitializeComponent();
        }

        //private void PegarIdLinhaSelecionadaNoGrid()
        //{
        //    throw new NotImplementedException();
        //}

        //private void ListarVendas()
        //{
        //    //id_selecionado = 0;
        //    //btn_deletar.Enabled = false;
        //    DAL_Vendas dp = new DAL_Vendas();

        //    dgv_tarefas.DataSource = dp.Selecionar_Vendas();
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveButton(btn_vendas);
            FormShow(new FRM_Vendas());
        }
        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panel_Form.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if(frmAtivo != null )
            {
                frmAtivo.Close();
            }
        }
        private void ActiveButton(Button frmAtivo)
        {
            foreach(Control ctrl in panelPrincipal.Controls)
                ctrl.ForeColor = Color.White;
            
            frmAtivo.ForeColor = Color.Red;
            
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            ActiveButton(btn_home);
            ActiveFormClose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveButton(btn_clientes);
            FormShow(new FRM_Clientes());
        }

        private void panel_Form_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_tarefas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveButton(btn_produtos);
            FormShow(new FRM_Produtos());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRM_Principal_Load_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
