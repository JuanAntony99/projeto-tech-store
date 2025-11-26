using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projeto_TechStore.Classes;
using projeto_TechStore.conexao;
using projeto_TechStore.Interfaces;

namespace projeto_TechStore.DAL
{
    internal class DAL_Clientes : IClientes
    {
        private MySqlConnection _conexao;
        MySqlCommand comando = new MySqlCommand();
        public DAL_Clientes()
        {
            this._conexao = new Connection_Factory().getConection();
        }

        public void Deletar_Clientes(int codigo_cliente)
        {

            try
            {
                _conexao.Open();

                string _sql = "DELETE FROM TB_CLIENTES WHERE ID=@ID";
                MySqlCommand comando = new MySqlCommand(_sql, _conexao);

                comando.CommandText = _sql;
                comando.Connection = _conexao;

                comando.Parameters.AddWithValue("ID", codigo_cliente);

                comando.Prepare();
                int linhas = comando.ExecuteNonQuery();

                if (linhas == 1)
                {
                    MessageBox.Show("Cliente excluido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (linhas == 0)
                {
                    MessageBox.Show("O ID informado não existe.", "Erro ao excluir cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message, "Erro ao excluir cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conexao.State == ConnectionState.Open)
                {
                    _conexao.Close();
                }
            }
        }

        public void Editar_Clientes(Clientes clientes)
        {
            try
            {
                _conexao.Open();

                string _sql = "UPDATE TB_CLIENTES SET nome=@nome,email=@email WHERE id=@id";
                comando = new MySqlCommand(_sql, _conexao);

                comando.CommandText = _sql;
                comando.Connection = _conexao;

                comando.Parameters.AddWithValue("id", clientes.id);
                comando.Parameters.AddWithValue("nome", clientes.nome);
                comando.Parameters.AddWithValue("email", clientes.email);

                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show("Cliente editado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message, "Erro ao editar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conexao.State == ConnectionState.Open)
                {
                    _conexao.Close();
                }
            }
        }

        public void Inserir_Clientes(Clientes clientes)
        {
            try
            {
                _conexao.Open();

                string _sql = "INSERT INTO TB_CLIENTES (nome,email) VALUES (@nome,@email)";
                comando = new MySqlCommand(_sql, _conexao);

                comando.CommandText = _sql;
                comando.Connection = _conexao;

                comando.Parameters.AddWithValue("@nome", clientes.nome);
                comando.Parameters.AddWithValue("@email", clientes.email);

                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show("Cliente inserido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message, "Erro ao inserir cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conexao.State == ConnectionState.Open)
                { 
                    _conexao.Close();
                }
            }
        }

        public DataTable Selecionar_Clientes()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"SELECT * FROM TB_CLIENTES";

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
                if (_conexao.State == ConnectionState.Open)
                {
                    _conexao.Close();
                }
            }
        }

            public DataTable Selecionar_Clientes_porID(int id)
        {
            // A conexão está aberta APENAS para o escopo do MySqlDataAdapter, 
            // então a abertura/fechamento da conexão pode ser omitida aqui ou 
            // feita dentro de um bloco using no MySqlDataAdapter para melhor gerenciamento.

            DataTable dt = new DataTable();
            // A string SQL está correta agora (assumindo que você removeu o 'W' e 'v.')
            string sql = "SELECT * FROM tb_clientes WHERE id = @id";

            using (MySqlCommand comandoSql = new MySqlCommand(sql, _conexao)) // Usando 'using' aqui seria ideal
            {
                // 1. Adicionar o parâmetro com tipo explícito (mais seguro)
                comandoSql.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                // 2. Criar o DataAdapter para executar a query e preencher a tabela
                MySqlDataAdapter sql_relacao = new MySqlDataAdapter(comandoSql);

                try
                {
                    // A abertura da conexão é necessária para o Fill, se a conexão 
                    // não for gerenciada pelo DataAdapter implicitamente.
                    _conexao.Open();

                    sql_relacao.Fill(dt); // Executa a consulta SELECT e preenche o DataTable

                    return dt;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                finally
                {
                    // 3. O fechamento da conexão está correto no finally
                    if (_conexao != null && _conexao.State == ConnectionState.Open)
                    {
                        _conexao.Close();
                    }
                }
            }
        }
    }
    }
