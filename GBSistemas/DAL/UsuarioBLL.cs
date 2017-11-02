using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using GBSistemas.MODELO;
using GBSistemas.DAL;
namespace GBSistemas.DAL
{
    class UsuarioBLL
    {
        ConexaoDAL ConexaoMySql = new ConexaoDAL();

        #region INSERT USUARIO
        public object objInsert(UsuarioDTO objusuario)
        {
            MySqlConnection objConexao = ConexaoMySql.conexaoSql();

            objConexao.Open();
            MySqlCommand cmd = new MySqlCommand("insert into usuario (nome,email,login,senha,confsenha) value (@nome,@email,@login,@senha,@confsenha)",objConexao);

            cmd.Parameters.AddWithValue("@nome",objusuario.Nome);
            cmd.Parameters.AddWithValue("@email",objusuario.Email);
            cmd.Parameters.AddWithValue("@login",objusuario.Login);
            cmd.Parameters.AddWithValue("@senha",objusuario.Senha);
            cmd.Parameters.AddWithValue("@confsenha",objusuario.Confsenha);

            object stringRetorno = cmd.ExecuteScalar();

            return stringRetorno;
        }
        #endregion




    }
}
