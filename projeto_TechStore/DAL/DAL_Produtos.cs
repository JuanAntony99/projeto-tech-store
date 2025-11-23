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
    internal class DAL_Produtos:IProdutos
    {
        private MySqlConnection _conexao;
        MySqlCommand comando = new MySqlCommand();
        public DAL_Produtos()
        {
            this._conexao = new Connection_Factory().getConection();
        }

        public void Deletar_Produto(int codigo_produto)
        {
            _conexao.Open();
            try
            {
                string _sql = "DELETE FROM TB_PRODUTOS WHERE ID=@ID";
                MySqlCommand comando = new MySqlCommand(_sql, _conexao);

                comando.CommandText = _sql;
                comando.Connection = _conexao;

                comando.Parameters.AddWithValue("ID", codigo_produto);

                comando.Prepare();
                int linhas = comando.ExecuteNonQuery();

                if (linhas == 1)
                {
                    MessageBox.Show("Produto excluida com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _conexao.Close();
                }

                if (linhas == 0)
                {
                    MessageBox.Show("O id informado não existe", "Erro ao excluir Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message, "Erro ao excluir Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _conexao.Close();
            }
        }

        public void Editar_Produto(Produtos produtos)
        {
            _conexao.Open();
            try
            {
                string _sql = "UPDATE TB_PRODUTOS SET nome=@nome,preco=@preco WHERE id=@id";
                comando = new MySqlCommand(_sql, _conexao);

                comando.CommandText = _sql;
                comando.Connection = _conexao;

                comando.Parameters.AddWithValue("id", produtos.id);
                comando.Parameters.AddWithValue("nome", produtos.nome);
                comando.Parameters.AddWithValue("preco", produtos.preco);

                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show("Produto editado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _conexao.Close();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message, "Erro ao editar Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _conexao.Close();
            }
        }

        public void Inserir_Produto(Produtos produtos)
        {
            _conexao.Open();
            try
            {
                string _sql = "INSERT INTO TB_PRODUTOS (nome,preco) VALUES (@nome,@preco)";
                comando = new MySqlCommand(_sql, _conexao);

                comando.CommandText = _sql;
                comando.Connection = _conexao;

                comando.Parameters.AddWithValue("nome", produtos.nome);
                comando.Parameters.AddWithValue("preco", produtos.preco);

                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show("Produto inserido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _conexao.Close();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message, "Erro ao inserir Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _conexao.Close();
            }
        }

        public DataTable Selecionar_Produto()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"SELECT * FROM TB_PRODUTOS";

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
