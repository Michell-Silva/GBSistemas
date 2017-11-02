using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBSistemas.MODELO
{
    class FornecedorDTO
    {
        private int idForn;

        public int IdForn
        {
            get { return idForn; }
            set { idForn = value; }
        }
        private string nomeForn;

        public string NomeForn
        {
            get { return nomeForn; }
            set { nomeForn = value; }
        }
        private string cnpj;

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
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
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string contato;

        public string Contato
        {
            get { return contato; }
            set { contato = value; }
        }    

    }
}
