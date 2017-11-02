using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBSistemas.MODELO
{
    class ClienteDTO
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        private string cpf;
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }


        private string rua;
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }


        private string numero;
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }


        private string bairro;
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }


        private string cidade;
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }


        private string uf;
        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }


        private string cep;
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }


        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }


        private string celular;
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }


        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    

    }
}
