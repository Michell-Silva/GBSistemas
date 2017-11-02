using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GBSistemas.MODELO;
using GBSistemas.DAO;
using GBSistemas.DAO;

namespace GBSistemas
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        #region BOTÃO INSERIR
        private void btnInserir_Click(object sender, EventArgs e)
        {
            ClienteDTO dto = new ClienteDTO();

            dto.Nome = txtNome.Text;
            dto.Cpf = txtCpf.Text;
            dto.Rua = txtRua.Text;
            dto.Numero = txtNumero.Text;
            dto.Bairro = txtBairro.Text;
            dto.Cidade = txtCidade.Text;
            dto.Uf = cmbUF.Text;
            dto.Cep = txtCep.Text;
            dto.Telefone = txtCep.Text;
            dto.Celular = txtCelular.Text;
            dto.Email = txtEmail.Text;

            ClienteDAO dao = new ClienteDAO();

            dao.objInsert(dto);
            try
            {
                MessageBox.Show("Cliente Cadastrado com Sucesso");
                Consistencia.limparCampos2(this);
                cmbUF.Text = "";
                dataGridCliente.DataSource = dao.ListarTodosClientes();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                throw;
            }
        }
        #endregion

        #region BOTÃO ALTERAR
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ClienteDTO dto = new ClienteDTO();

            dto.Nome = txtNome.Text;
            dto.Cpf = txtCpf.Text;
            dto.Rua = txtRua.Text;
            dto.Numero = txtNumero.Text;
            dto.Bairro = txtBairro.Text;
            dto.Cidade = txtCidade.Text;
            dto.Uf = cmbUF.Text;
            dto.Cep = txtCep.Text;
            dto.Telefone = txtCep.Text;
            dto.Celular = txtCelular.Text;
            dto.Email = txtEmail.Text;
            dto.Id = int.Parse(txtCodigo.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.objAlterar(dto);

            try
            {
                MessageBox.Show("Cliente Alterado com Sucesso !");
                Consistencia.limparCampos2(this);
                cmbUF.Text = "";
                dataGridCliente.DataSource = dao.ListarTodosClientes();
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                throw erro;
            }

        }
        #endregion

        #region BOTÃO EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ClienteDTO dto = new ClienteDTO();

            dto.Id = int.Parse(txtCodigo.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.objExcluir(dto);

            try
            {
                MessageBox.Show(" Cliente Excluido com Sucesso ");
                Consistencia.limparCampos2(this);
                cmbUF.Text = "";
                dataGridCliente.DataSource = dao.ListarTodosClientes();
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        #endregion       

        #region CARREGAR GRID NO FORMULARIO
        private void frmClientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            dataGridCliente.DataSource = dao.ListarTodosClientes();          
        }
        #endregion

        #region PESQUISAR POR NOME
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;
            ClienteDAO dao = new ClienteDAO();
            dataGridCliente.DataSource = dao.ListarClientePorNome(pesquisa);
        }
        #endregion

        #region PUXAR DADOS DO DATAGRID
        private void dataGridCliente_Click(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Text = dataGridCliente.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dataGridCliente.CurrentRow.Cells[1].Value.ToString();
                txtCpf.Text = dataGridCliente.CurrentRow.Cells[2].Value.ToString();
                txtRua.Text = dataGridCliente.CurrentRow.Cells[3].Value.ToString();
                txtNumero.Text = dataGridCliente.CurrentRow.Cells[4].Value.ToString();
                txtBairro.Text = dataGridCliente.CurrentRow.Cells[5].Value.ToString();
                txtCidade.Text = dataGridCliente.CurrentRow.Cells[6].Value.ToString();
                cmbUF.Text = dataGridCliente.CurrentRow.Cells[7].Value.ToString();
                txtCep.Text = dataGridCliente.CurrentRow.Cells[8].Value.ToString();
                txtTelefone.Text = dataGridCliente.CurrentRow.Cells[9].Value.ToString();
                txtCelular.Text = dataGridCliente.CurrentRow.Cells[10].Value.ToString();
                txtEmail.Text = dataGridCliente.CurrentRow.Cells[11].Value.ToString();

                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro);
            }

        }
        #endregion

        #region BOTÃO LIMPAR
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Consistencia.limparCampos2(this);
            cmbUF.Text = "";
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;

        }
        #endregion

        #region BOTÃO SAIR
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair Sistema", "Atenção", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

        
    }
}
