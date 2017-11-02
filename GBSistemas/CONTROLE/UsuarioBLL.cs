using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using GBSistemas.MODELO;
using GBSistemas.DAL;
using System.Data;

namespace GBSistemas.DAL

{
    class UsuarioBLL
    {
        
        #region INSERT USUARIO
        public object objInsert(UsuarioDTO objusuario)
        {
            MySqlConnection objConexao = ConexaoDAL.conexaoBanco();

            objConexao.Open();
            MySqlCommand cmd = new MySqlCommand("insert into usuario (nome,email,login,senha,confsenha)"+
                " value (@nome,@email,@login,@senha,@confsenha)",objConexao);

            cmd.Parameters.AddWithValue("@nome",objusuario.Nome);
            cmd.Parameters.AddWithValue("@email",objusuario.Email);
            cmd.Parameters.AddWithValue("@login",objusuario.Login);
            cmd.Parameters.AddWithValue("@senha",objusuario.Senha);
            cmd.Parameters.AddWithValue("@confsenha",objusuario.Confsenha);

            object stringRetorno = cmd.ExecuteScalar();

            return stringRetorno;
        }
        #endregion

        
        //public DataTable SelecionarUsuarioTotal()
        //{

        //    MySqlConnection objConexao = ConexaoDAL.conexaoBanco();

        //    try
        //    {
        //        objConexao.Open();
        //        MySqlCommand objComando = new MySqlCommand("select * from usuario ", objConexao);

        //        MySqlDataAdapter objAd = new MySqlDataAdapter(objComando);

        //        DataTable objTabelaDados = new DataTable();

        //        objAd.Fill(objTabelaDados);
                

        //        return objTabelaDados;

        //    }
        //    catch (Exception erro)
        //    {
        //        System.Windows.Forms.MessageBox.Show("Erro ao conectar " + erro);
        //        throw erro;
        //    }
        //    finally
        //    {
        //        objConexao.Close();
        //    }
        //}

        //public DataTable SelecionarUsuario(string nome)
        //{

        //    MySqlConnection objconexao = ConexaoDAL.conexaoBanco();

        //    try
        //    {
        //        MySqlCommand objComando = new MySqlCommand("select * from usuario where nome_usu like'%" + nome + "%'", objconexao);
        //        MySqlDataAdapter objdataAd = new MySqlDataAdapter(objComando);
        //        DataTable DT = new DataTable();

        //        objdataAd.Fill(DT);

        //        return DT;
        //    }
        //    catch (Exception erro)
        //    {

        //        throw erro;
        //    }


        //}
            
       

    }
}
