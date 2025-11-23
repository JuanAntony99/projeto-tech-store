using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using projeto_TechStore.Classes;
using projeto_TechStore.conexao;
using projeto_TechStore.Interfaces;

namespace projeto_TechStore.DAL
{
    internal class DAL_Vendas:IVendas
    {
        private MySqlConnection _conexao;
        MySqlCommand comando = new MySqlCommand();
        public DAL_Vendas()
        {
            this._conexao = new Connection_Factory().getConection();
        }

        public void Deletar_Vendas(int codigo_cliente)
        {
            _conexao.Open();
            try
            {
                string _sql = "DELETE FROM TB_VENDAS WHERE ID=@ID";
                MySqlCommand comando = new MySqlCommand(_sql, _conexao);

                comando.CommandText = _sql;
                comando.Connection = _conexao;

                comando.Parameters.AddWithValue("ID", codigo_cliente);

                comando.Prepare();
                int linhas = comando.ExecuteNonQuery();

                if (linhas == 1)
                {
                    MessageBox.Show("Venda excluida com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _conexao.Close();
                }

                if (linhas == 0)
                {
                    MessageBox.Show("O id informado não existe", "Erro ao excluir Venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message, "Erro ao excluir Venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _conexao.Close();
            }
        }

        public void Editar_Vendas(Vendas tarefa)
        {
            _conexao.Open();
            try
            {
                string _sql = "UPDATE TB_VENDAS SET ID_Cliente=@ID_Cliente,ID_Produto=@ID_Produto,quantidade=@quantidade,dataVenda=@dataVenda WHERE id=@id";
                comando = new MySqlCommand(_sql, _conexao);

                comando.CommandText = _sql;
                comando.Connection = _conexao;

                comando.Parameters.AddWithValue("id", tarefa.id);
                comando.Parameters.AddWithValue("ID_Cliente", tarefa.ID_Cliente);
                comando.Parameters.AddWithValue("ID_Produto", tarefa.ID_Produto);
                comando.Parameters.AddWithValue("quantidade", tarefa.quantidade);
                comando.Parameters.AddWithValue("dataVenda", tarefa.dataVenda);

                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show("Venda editada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _conexao.Close();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message, "Erro ao editar Venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _conexao.Close();
            }
        }

        public void Inserir_Vendas(Vendas tarefa)
        {
            _conexao.Open();
            try
            {
                string _sql = "INSERT INTO TB_VENDAS (ID_Cliente,ID_Produto,quantidade,dataVenda) VALUES (@ID_Cliente,@ID_Produto,@quantidade,@dataVenda)";
                comando = new MySqlCommand(_sql, _conexao);

                comando.CommandText = _sql;
                comando.Connection = _conexao;

                comando.Parameters.AddWithValue("ID_Cliente", tarefa.ID_Cliente);
                comando.Parameters.AddWithValue("ID_Produto", tarefa.ID_Produto);
                comando.Parameters.AddWithValue("quantidade", tarefa.quantidade);
                comando.Parameters.AddWithValue("dataVenda", tarefa.dataVenda);

                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show("Venda inserida com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _conexao.Close();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message, "Erro ao inserir Venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _conexao.Close();
            }
        }

        public DataTable Selecionar_Vendas()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"SELECT v.id,c.nome AS Cliente,p.nome AS Produto,v.quantidade,v.dataVenda FROM tb_vendas v JOIN tb_produtos p ON p.id=v.ID_Produto
JOIN tb_clientes c ON c.id=v.ID_Cliente";

                MySqlCommand comandosql = new MySqlCommand(sql, _conexao);

                _conexao.Open();
                comandosql.ExecuteNonQuery();

                MySqlDataAdapter sql_relacao = new MySqlDataAdapter(comandosql);
                sql_relacao.Fill(dt);

                return dt;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                _conexao.Close();
            }
        }
    }
}
