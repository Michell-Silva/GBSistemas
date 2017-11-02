using GBSistemas.MODELO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GBSistemas.DAO;
using System.Data;

namespace GBSistemas.DAO
{
    class FornecedorDAO
    {

        #region Cadastrar
        public void CadastroFornecedor(FornecedorDTO dto) {

            MySqlConnection objConexao = ConexaoDAO.conexaoBanco();

            string sql = @"insert into Fornecedor(NomeForn,CNPJ,Rua,Numero,Bairro,Cidade,UF,CEP,Telefone,Email,Contato)" +
                        "values(@NomeForn, @CNPJ, @Rua, @Numero, @Bairro, @Cidade, @UF, @CEP, @Telefone, @Email, @Contato)";

            MySqlCommand cmd = new MySqlCommand(sql, objConexao);

            cmd.Parameters.AddWithValue("@NomeForn", dto.NomeForn);
            cmd.Parameters.AddWithValue("@CNPJ",dto.Cnpj);
            cmd.Parameters.AddWithValue("@Rua",dto.Rua);
            cmd.Parameters.AddWithValue("@Numero",dto.Numero);
            cmd.Parameters.AddWithValue("@Bairro", dto.Bairro);
            cmd.Parameters.AddWithValue("@Cidade", dto.Cidade);
            cmd.Parameters.AddWithValue("@UF",dto.Uf);
            cmd.Parameters.AddWithValue("@CEP",dto.Cep);
            cmd.Parameters.AddWithValue("@Telefone",dto.Telefone);
            cmd.Parameters.AddWithValue("@Email",dto.Email);
            cmd.Parameters.AddWithValue("@Contato",dto.Contato);

            try
            {
                objConexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                objConexao.Close();            
            }
        }
        #endregion

        #region Alterar
        public void AlterarForn(FornecedorDTO dto) {

            MySqlConnection conexao = ConexaoDAO.conexaoBanco();

            string sql = @"update fornecedor set NomeForn=@NomeForn,CNPJ=@CNPJ,Rua=@Rua,Numero=@Numero," +
                "Bairro=@Bairro,Cidade=@Cidade,UF=@UF,CEP=@CEP,Telefone=@Telefone,Email=@Email,Contato=@Contato"+
                " where idFornecedor=@idFornecedor "; 

            MySqlCommand cmd = new MySqlCommand(sql,conexao);

            cmd.Parameters.AddWithValue("@NomeForn", dto.NomeForn);
            cmd.Parameters.AddWithValue("@CNPJ", dto.Cnpj);
            cmd.Parameters.AddWithValue("@Rua", dto.Rua);
            cmd.Parameters.AddWithValue("@Numero", dto.Numero);
            cmd.Parameters.AddWithValue("@Bairro", dto.Bairro);
            cmd.Parameters.AddWithValue("@Cidade", dto.Cidade);
            cmd.Parameters.AddWithValue("@UF", dto.Uf);
            cmd.Parameters.AddWithValue("@CEP", dto.Cep);
            cmd.Parameters.AddWithValue("@Telefone", dto.Telefone);
            cmd.Parameters.AddWithValue("@Email", dto.Email);
            cmd.Parameters.AddWithValue("@Contato", dto.Contato);
            cmd.Parameters.AddWithValue("@idFornecedor", dto.IdForn);

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

        #region Excluir

        public void ExcluirFornecedor(FornecedorDTO dto)
        {
            MySqlConnection conexao = ConexaoDAO.conexaoBanco();

            string sql = "delete from fornecedor where idFornecedor = @idFornecedor";

            MySqlCommand cmd = new MySqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@idFornecedor", dto.IdForn);

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

        #region Listar todos Fornecedores
        public DataTable ListartodosFornecedor()
        {
            MySqlConnection conexao = ConexaoDAO.conexaoBanco();
            try
            {
                string sql = @"select * from fornecedor";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                conexao.Open();

                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable tabelaFornecedor = new DataTable();

                da.Fill(tabelaFornecedor);

                return tabelaFornecedor;
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

        #region Pesquisar Fornecedor por Nome
        public DataTable PesquisarFornecedorPorNome(string pesquisaFornecedor)
        {
            MySqlConnection conexao = ConexaoDAO.conexaoBanco();

            try
            {
                string sql = "select * from fornecedor where NomeForn like '%' @NomeForn '%' ";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@NomeForn", pesquisaFornecedor);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable tabelaForn = new DataTable();

                da.Fill(tabelaForn);

                return tabelaForn;
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
