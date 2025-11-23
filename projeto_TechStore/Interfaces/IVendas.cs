using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlX.XDevAPI;
using projeto_TechStore.Classes;

namespace projeto_TechStore.Interfaces
{
    internal interface IVendas
    {
        void Editar_Vendas(Vendas vendas);
        void Deletar_Vendas(int codigo_venda);
        DataTable Selecionar_Vendas();
        void Inserir_Vendas(Vendas vendas);
    }
}
