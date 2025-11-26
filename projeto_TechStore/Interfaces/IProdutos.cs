using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_TechStore.Classes;

namespace projeto_TechStore.Interfaces
{
    internal interface IProdutos
    {
        void Editar_Produto(Produtos produtos);
        void Deletar_Produto(int codigo_produto);
        DataTable Selecionar_Produto();
        DataTable Selecionar_Produtos_porID(int id);
        void Inserir_Produto(Produtos produtos);
    }
}
