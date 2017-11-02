using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GBSistemas.DAO;
using GBSistemas.DAO;
using GBSistemas.MODELO;

namespace GBSistemas
{
    public partial class frmFornecedor : Form
    {

        public frmFornecedor()
        {
            InitializeComponent();
        }
        #region CADASTRAR
        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {                
                FornecedorDTO dto = new FornecedorDTO();
                dto.NomeForn = txtNomeRazao.Text;
                dto.Cnpj = txtCnpj.Text;
                dto.Rua = txtRua.Text;
                dto.Numero = txtNumero.Text;
                dto.Bairro = txtBairro.Text;
                dto.Cidade = txtCidade.Text;
                dto.Uf = cmbUF.Text;
                dto.Cep = txtCep.Text;
                dto.Telefone = txtTelefone.Text;
                dto.Email = txtEmail.Text;
                dto.Contato = txtContato.Text;

                FornecedorDAO dao = new FornecedorDAO();

                dao.CadastroFornecedor(dto);

                MessageBox.Show("Fornecedor Cadastrado com Sucesso !");
                Consistencia.limparCampos2(this);
                cmbUF.Text = "";
                dataGridFornecedor.DataSource = dao.ListartodosFornecedor();
                txtNomeRazao.Focus();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Cadastrar o Fornecedor !");
                throw erro;
            }
        }
        #endregion

        #region ALTERAR
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FornecedorDTO dto = new FornecedorDTO();

            dto.NomeForn = txtNomeRazao.Text;
            dto.Cnpj = txtCnpj.Text;
            dto.Rua = txtRua.Text;
            dto.Numero = txtNumero.Text;
            dto.Bairro = txtBairro.Text;
            dto.Cidade = txtCidade.Text;
            dto.Uf = cmbUF.Text;
            dto.Cep = txtCep.Text;
            dto.Telefone = txtTelefone.Text;
            dto.Email = txtEmail.Text;
            dto.Contato = txtContato.Text;
            dto.IdForn = int.Parse(txtCodigo.Text);

            FornecedorDAO dao = new FornecedorDAO();
            dao.AlterarForn(dto);
            try
            {
                MessageBox.Show("Fornecedor Cadastrado com Sucesso !");
                Consistencia.limparCampos2(this);
                cmbUF.Text = "";
                dataGridFornecedor.DataSource = dao.ListartodosFornecedor();
                txtNomeRazao.Focus();
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Cadastrar o Fornecedor " + erro);
            }
        }
        #endregion

        #region EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FornecedorDTO dto = new FornecedorDTO();

            dto.IdForn = int.Parse(txtCodigo.Text);

            FornecedorDAO dao = new FornecedorDAO();
            dao.ExcluirFornecedor(dto);

            try
            {
                MessageBox.Show("Fornecedor Excluido com Sucesso");
                Consistencia.limparCampos2(this);
                cmbUF.Text = "";
                dataGridFornecedor.DataSource = dao.ListartodosFornecedor();
                txtNomeRazao.Focus();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Excluir o Fornecedor " + erro);
            }
        }
        #endregion       

        #region CARREGAR DATAGRID NO FORMULARIO

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();
            dataGridFornecedor.DataSource = dao.ListartodosFornecedor();
        }
        #endregion               

        #region PESQUISAR POR NOME
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisarForn = txtPesquisa.Text;
            FornecedorDAO dao = new FornecedorDAO();
            dataGridFornecedor.DataSource = dao.PesquisarFornecedorPorNome(pesquisarForn);
        }
        #endregion

        #region PUXAR DADOS DO DATAGRID PARA OS CAMPOS
        private void dataGridFornecedor_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = dataGridFornecedor.CurrentRow.Cells[0].Value.ToString();
            txtNomeRazao.Text = dataGridFornecedor.CurrentRow.Cells[1].Value.ToString();
            txtCnpj.Text = dataGridFornecedor.CurrentRow.Cells[2].Value.ToString();
            txtRua.Text = dataGridFornecedor.CurrentRow.Cells[3].Value.ToString();
            txtNumero.Text = dataGridFornecedor.CurrentRow.Cells[4].Value.ToString();
            txtBairro.Text = dataGridFornecedor.CurrentRow.Cells[5].Value.ToString();
            txtCidade.Text = dataGridFornecedor.CurrentRow.Cells[6].Value.ToString();
            cmbUF.Text = dataGridFornecedor.CurrentRow.Cells[7].Value.ToString();
            txtCep.Text = dataGridFornecedor.CurrentRow.Cells[8].Value.ToString();
            txtTelefone.Text = dataGridFornecedor.CurrentRow.Cells[9].Value.ToString();
            txtEmail.Text = dataGridFornecedor.CurrentRow.Cells[10].Value.ToString();
            txtContato.Text = dataGridFornecedor.CurrentRow.Cells[11].Value.ToString();

            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }
        #endregion

        #region SAIR
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair do Sistema", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

        #region LIMPAR
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Consistencia.limparCampos2(this);
            cmbUF.Text = "";
            txtNomeRazao.Focus();
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }
        #endregion        
    }
}
