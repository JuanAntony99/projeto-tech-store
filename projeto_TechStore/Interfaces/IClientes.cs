using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_TechStore.Classes;

namespace projeto_TechStore.Interfaces
{
    internal interface IClientes
    {
        void Editar_Clientes(Clientes clientes);
        void Deletar_Clientes(int codigo_cliente);
        DataTable Selecionar_Clientes();
        void Inserir_Clientes(Clientes clientes);
    }
}
