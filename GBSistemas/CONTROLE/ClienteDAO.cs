using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using GBSistemas.MODELO;
using GBSistemas.DAO;
using System.Data;
using System.Windows.Forms;

namespace GBSistemas.DAO
{
    class ClienteDAO
    {
        #region Inserir        
        public void objInsert(ClienteDTO dto) {

            MySqlConnection objConexao = ConexaoDAO.conexaoBanco();

            
            string sql = @"insert into cliente (Nome,CPF,Rua,Numero,Bairro,Cid,UF,CEP,Telefone,Celular,Email)" +
            "values (@Nome,@CPF,@Rua,@Numero,@Bairro,@Cid,@UF,@CEP,@Telefone,@Celular,@Email)";

            MySqlCommand cmd = new MySqlCommand(sql,objConexao);

            cmd.Parameters.AddWithValue("@Nome", dto.Nome);
            cmd.Parameters.AddWithValue("@CPF", dto.Cpf);
            cmd.Parameters.AddWithValue("@Rua", dto.Rua);
            cmd.Parameters.AddWithValue("@Numero", dto.Numero);
            cmd.Parameters.AddWithValue("@Bairro", dto.Bairro);
            cmd.Parameters.AddWithValue("@Cid", dto.Cidade);
            cmd.Parameters.AddWithValue("@UF", dto.Uf);
            cmd.Parameters.AddWithValue("@CEP", dto.Cep);
            cmd.Parameters.AddWithValue("@Telefone", dto.Telefone);
            cmd.Parameters.AddWithValue("@Celular", dto.Celular);
            cmd.Parameters.AddWithValue("@Email", dto.Email);

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
                objConexao.Clone();
            }
        }
        #endregion


        #region Alterar
        public void objAlterar(ClienteDTO dto)
        {
            MySqlConnection objConexao = ConexaoDAO.conexaoBanco();

            string sql = @"update cliente set Nome = @Nome, CPF = @CPF, Rua = @rua, Numero = @Numero, Bairro = @Bairro, Cid = @Cid,
                            UF= @UF, CEP = @CEP, Telefone = @Telefone, Celular = @Celular, Email = @Email where idCliente = @idCliente ";

            MySqlCommand cmd = new MySqlCommand(sql, objConexao);

            cmd.Parameters.AddWithValue("@Nome", dto.Nome);
            cmd.Parameters.AddWithValue("@CPF", dto.Cpf);
            cmd.Parameters.AddWithValue("@Rua", dto.Rua);
            cmd.Parameters.AddWithValue("@Numero", dto.Numero);
            cmd.Parameters.AddWithValue("@Bairro", dto.Bairro);
            cmd.Parameters.AddWithValue("@Cid", dto.Cidade);
            cmd.Parameters.AddWithValue("@UF", dto.Uf);
            cmd.Parameters.AddWithValue("@CEP", dto.Cep);
            cmd.Parameters.AddWithValue("@Telefone", dto.Telefone);
            cmd.Parameters.AddWithValue("@Celular", dto.Celular);
            cmd.Parameters.AddWithValue("@Email", dto.Email);
            cmd.Parameters.AddWithValue("@idCliente", dto.Id);

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
                objConexao.Clone();
            }
        }
        #endregion


        #region Excluir
        public void objExcluir(ClienteDTO dto) {

            MySqlConnection conexao = ConexaoDAO.conexaoBanco();

            string sql = @"delete from cliente where idCliente = @Id";

            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Id",dto.Id).Value.ToString();

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                
            }
            finally
            {
                conexao.Close();
            }       
        
        }
        #endregion


        #region Listar todos Clientes

        public DataTable ListarTodosClientes()
        {
            MySqlConnection conexao = ConexaoDAO.conexaoBanco();

            try
            {
                string sql = @"select * from Cliente ";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable tabelaCliente = new DataTable();

                da.Fill(tabelaCliente);

                return tabelaCliente;              

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                throw;             
            }
            finally
            {
                conexao.Close();
            }
            
        }

        #endregion


        #region Pesquisar Cliente por nome

        public DataTable ListarClientePorNome(string pesquisa)
        {
            MySqlConnection conexao = ConexaoDAO.conexaoBanco();
            try
            {
                string sql = @"select * from cliente where nome like '%' @nome '%' ";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome",pesquisa );
                               
                conexao.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabelaCliente = new DataTable();
                da.Fill(tabelaCliente);

                return tabelaCliente;                
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
