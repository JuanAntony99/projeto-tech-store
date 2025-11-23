using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_TechStore.Classes
{
    internal class Vendas
    {
        public int id { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Produto { get; set; }
        public int quantidade { get; set; }
        public string dataVenda { get; set; }

    }
}
