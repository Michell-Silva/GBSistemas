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
    class ClienteBLL {

        public object objInsert(ClienteDTO objCliente) {

            MySqlConnection objConexao = ConexaoDAL.conexaoBanco();

            objConexao.Open();

            string sql = "insert into cliente (Nome,CPF,Rua,Numero,Bairro,Cid,UF,CEP,Telefone,Celular,Email)" +
            "values (@Nome,@CPF,@Rua,@Numero,@Bairro,@Cid,@UF,@CEP,@Telefone,@Celular,@Email)";

            MySqlCommand cmd = new MySqlCommand(sql,objConexao);

            cmd.Parameters.AddWithValue("@Nome", objCliente.Nome);
            cmd.Parameters.AddWithValue("@CPF", objCliente.Cpf);
            cmd.Parameters.AddWithValue("@Rua", objCliente.Rua);
            cmd.Parameters.AddWithValue("@Numero", objCliente.Numero);
            cmd.Parameters.AddWithValue("@Bairro", objCliente.Bairro);
            cmd.Parameters.AddWithValue("@Cid", objCliente.Cidade);
            cmd.Parameters.AddWithValue("@UF", objCliente.Uf);
            cmd.Parameters.AddWithValue("@CEP", objCliente.Cep);
            cmd.Parameters.AddWithValue("@Telefone", objCliente.Telefone);
            cmd.Parameters.AddWithValue("@Celular", objCliente.Celular);
            cmd.Parameters.AddWithValue("@Email", objCliente.Email);
             
            object stringRetorno = cmd.ExecuteScalar();
            return stringRetorno;

        }
    
    }
}
