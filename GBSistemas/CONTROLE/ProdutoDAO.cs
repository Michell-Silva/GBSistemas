using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GBSistemas.MODELO;
using GBSistemas.DAO;
using MySql.Data.MySqlClient;
using System.Data;

namespace GBSistemas.DAO
{
    class ProdutoDAO
    {

        #region INSERIR PRODUTO
        public void CadastrarProduto(ProdutoDTO dto) {

            MySqlConnection conexao = ConexaoDAO.conexaoBanco();

            string sql = @"insert into produto (Codigo,Descricao,Qtd,precoUn,precoVenda)"+
                         " values (@Codigo,@Descricao,@Qtd,@precoUn,@precoVenda)";

            MySqlCommand cmd = new MySqlCommand(sql,conexao);
            cmd.Parameters.AddWithValue("@Codigo", dto.CodigoCard);
            cmd.Parameters.AddWithValue("@Descricao", dto.Descricao);
            cmd.Parameters.AddWithValue("@Qtd", dto.Qtd);
            cmd.Parameters.AddWithValue("@precoUn", dto.Precouni);
            cmd.Parameters.AddWithValue("@precoVenda", dto.Precovenda);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                conexao.Close();            
            }
        }
        #endregion


        #region ALTERAR PRODUTO
        public void AlterarProduto(ProdutoDTO dto) 
        {
            MySqlConnection conexao = ConexaoDAO.conexaoBanco();

            string sql = @"update produto set Codigo = @Codigo, Descricao = @Descricao,Qtd = @Qtd,
                            precoUn = @precoUn,precoVenda = @precoVenda where idProduto = @idProduto";

            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Codigo",dto.CodigoCard);
            cmd.Parameters.AddWithValue("@Descricao", dto.Descricao);
            cmd.Parameters.AddWithValue("@Qtd", dto.Qtd);
            cmd.Parameters.AddWithValue("@precoUn", dto.Precouni);
            cmd.Parameters.AddWithValue("@precoVenda", dto.Precovenda);
            cmd.Parameters.AddWithValue("@idProduto", dto.IdProd);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {                
                throw erro;
            }
            finally
            {
                conexao.Close();
            }       
        }

        #endregion


        #region EXCLUIR PRODUTO
        public void ExcluirProduto(ProdutoDTO dto)
        {
            MySqlConnection conexao = ConexaoDAO.conexaoBanco();
            string sql = @"delete from Produto where idProduto = @idProduto";

            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idProduto",dto.IdProd);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {                
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }
        #endregion


        #region LISTAR TODOS PRODUTOS
        public DataTable ListarTodosProdutos()
        {
            MySqlConnection conexao = ConexaoDAO.conexaoBanco();
            try
            {
                string sql = @"select * from Produto";
                MySqlCommand cmd = new MySqlCommand(sql , conexao);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable tabelaProd = new DataTable();

                da.Fill(tabelaProd);

                return tabelaProd;
            }
            catch (Exception erro)
            {                
                throw erro;
            }
            finally
            {
                conexao.Close();
            }           
        }
        #endregion


        #region PESQUISAR PRODUTO POR NOME
        public DataTable ConsultarProdutoPorNome(string pesquisa)
        {
            MySqlConnection conexao = ConexaoDAO.conexaoBanco();
            try
            {
                string sql = @"select * from Produto where Descricao like '%' @Descricao '%' ";

                MySqlCommand cmd = new MySqlCommand(sql , conexao);
                cmd.Parameters.AddWithValue("@Descricao",pesquisa);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabelaProduto = new DataTable();

                da.Fill(tabelaProduto);

                return tabelaProduto;

            }
            catch (Exception erro) 
            {                
                throw erro;
            }
            finally
            {
                conexao.Close();
            }           
        }
        #endregion


        #region PESQUISAR PRODUTO POR CODIGO
        public DataTable ConsultarProdutoPorCodigo(string pesquisa)
        {
            MySqlConnection conexao = ConexaoDAO.conexaoBanco();
            try
            {
                string sql = @"select * from Produto where like '%' @Codigo ";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Codigo", pesquisa);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabelaProduto = new DataTable();

                da.Fill(tabelaProduto);

                return tabelaProduto;

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            } 
        }
        #endregion


        #region Puxar produtos para tela de vendas
        public ProdutoDTO BuscarProduto(int buscProd)
        {
            ProdutoDTO dto = new ProdutoDTO();
            MySqlConnection conexao = ConexaoDAO.conexaoBanco();
            try
            {
                conexao.Open();
                string sql = @"select Descricao,precoVenda from produto where Codigo = @codigo";
                MySqlCommand cmd = new MySqlCommand(sql,conexao);
                cmd.Parameters.AddWithValue("@codigo", buscProd);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    dto.Descricao = reader.GetString(0);
                    dto.Precovenda = reader.GetDouble(1);
                }                

                return dto;

            }
            catch (Exception erro)
            {
                
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }
        #endregion
    }
}
