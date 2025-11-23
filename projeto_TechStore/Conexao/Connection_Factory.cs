using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projeto_TechStore.conexao
{
    internal class Connection_Factory
    {
        public MySqlConnection getConection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["conexao_dbprojetoengenhariadesoftware"].ConnectionString;
            return new MySqlConnection(conexao);
        }
    }
}
