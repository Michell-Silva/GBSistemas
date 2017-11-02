using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using GBSistemas.MODELO;
using GBSistemas.DAL;
using GBSistemas;


namespace GBSistemas.DAL
{
    class UsuarioBLL
    {
        ConexaoDAO ConexaoMySql = new ConexaoDAO();

        #region INSERT USUARIO
        public object objInsert(UsuarioDTO objusuario)
        {
            MySqlConnection objConexao = ConexaoMySql.conexaoSql();

            objConexao.Open();
            MySqlCommand cmd = new MySqlCommand("insert into Usuario (nome,email,login,senha,conf_senha) values (@nome,@email,@login,@senha,@conf_senha)",objConexao);

            cmd.Parameters.AddWithValue("@nome",objusuario.Nome);
            cmd.Parameters.AddWithValue("@email",objusuario.Email);
            cmd.Parameters.AddWithValue("@login",objusuario.Login);
            cmd.Parameters.AddWithValue("@senha",objusuario.Senha);
            cmd.Parameters.AddWithValue("@conf_senha",objusuario.Conf_senha);

            object stringRetorno = cmd.ExecuteScalar();

            return stringRetorno;
        }
        #endregion




    }
}
