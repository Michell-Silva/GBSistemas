using System;
using MySql.Data.MySqlClient;
using GBSistemas.MODELO;
using System.Data;
using System.Windows.Forms;
using GBSistemas.DAO;

namespace GBSistemas.DAO
{
    class UsuarioDAO
    {

        #region INSERIR USUARIO
        public void objInserir(UsuarioDTO dto)
        {
            MySqlConnection conexao = ConexaoDAO.conexaoBanco();

            string sql = @"insert into usuario (nome, login, email, senha, confsenha)" +
                                       "values (@nome, @login, @email, @senha, @confsenha)";

            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", dto.Nome);
            cmd.Parameters.AddWithValue("@login", dto.Login);
            cmd.Parameters.AddWithValue("@email", dto.Email);
            cmd.Parameters.AddWithValue("@senha", dto.Senha);
            cmd.Parameters.AddWithValue("@confsenha", dto.Confsenha);
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



        #region ALTERAR USUARIO
        public void objAlterar(UsuarioDTO dto)
        {

            MySqlConnection conexao = ConexaoDAO.conexaoBanco();

            string sql = @"update usuario set nome = @nome, email = @email, login = @login, senha = @senha,
                                                  confsenha = @confsenha where idUsuario = @idUsuario";

            MySqlCommand cmd = new MySqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@nome", dto.Nome);
            cmd.Parameters.AddWithValue("@email", dto.Email);
            cmd.Parameters.AddWithValue("@login", dto.Login);
            cmd.Parameters.AddWithValue("@senha", dto.Senha);
            cmd.Parameters.AddWithValue("@confsenha", dto.Confsenha);
            cmd.Parameters.AddWithValue("@idUsuario", dto.Id);
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



        #region EXCLUIR USUARIO

        public void objExcluir(UsuarioDTO objUsuario)
        {

            MySqlConnection conexao = ConexaoDAO.conexaoBanco();
            try
            {               
                string sql = @"delete from usuario where idUsuario = @idUsuario";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@idUsuario", objUsuario.Id).Value.ToString();

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



        #region LISTAR TODOS OS USUARIOS
        public DataTable listarTodosUsuario()
        {
            MySqlConnection conexao = ConexaoDAO.conexaoBanco();
            try
            {
                string sql = @"select* from usuario ";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable tabelaUsuario = new DataTable();

                da.Fill(tabelaUsuario);

                return tabelaUsuario;
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



        #region PESQUISAR POR NOME
        public DataTable ConsultarUsuarioPorNome(string pesquisa)
        {
            MySqlConnection conexao = ConexaoDAO.conexaoBanco();
            try
            {
                string sql = @"select * from usuario where nome like '%' @nome '%' " ;

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome",pesquisa);
            
                conexao.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable tabelaUsuario = new DataTable();

                da.Fill(tabelaUsuario);

                return tabelaUsuario;
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


        #region LOGIN 
        public Boolean efetualogin(UsuarioDTO dto)
        {

            MySqlConnection conexao = ConexaoDAO.conexaoBanco();
            try
            {
                string sql = @"select * from Usuario where login = @login and senha = @senha";
                
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@login", dto.Login).Value.ToString();
                cmd.Parameters.AddWithValue("@senha", dto.Senha).Value.ToString();
                
                conexao.Open();
                MySqlDataReader dr =  cmd.ExecuteReader();

                if (dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        } 
          
       #endregion
    }

}

