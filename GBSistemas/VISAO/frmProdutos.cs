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
using GBSistemas.MODELO;

namespace GBSistemas
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        #region BOTAO INSERIR
        private void btnInserir_Click(object sender, EventArgs e)
        {
            ProdutoDTO dto = new ProdutoDTO();

            dto.CodigoCard = Convert.ToInt32(txtCodVenda.Text);
            dto.Descricao = txtDescr.Text;
            dto.Qtd = Convert.ToInt32(txtQuant.Text);
            dto.Precouni = Double.Parse(txtCusto.Text);
            dto.Precovenda = Double.Parse(txtPrecoVenda.Text);

            ProdutoDAO dao = new ProdutoDAO();
            dao.CadastrarProduto(dto);

            try
            {
                MessageBox.Show("Produto Cadastrado com Sucesso");
                Consistencia.limparCampos2(this);
                dataGridProduto.DataSource = dao.ListarTodosProdutos();
                txtCodVenda.Focus();

            }
            catch (Exception erro)
            {
                
                throw erro;
            }
        }
        #endregion


        #region BOTAO ALTERAR
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ProdutoDTO dto = new ProdutoDTO();

            dto.CodigoCard = int.Parse(txtCodVenda.Text);
            dto.Descricao = txtDescr.Text;
            dto.Qtd = int.Parse(txtQuant.Text);
            dto.Precouni = Double.Parse(txtCusto.Text);
            dto.Precovenda = Double.Parse(txtPrecoVenda.Text);
            dto.IdProd = int.Parse(txtId.Text);

            ProdutoDAO dao = new ProdutoDAO();
            dao.AlterarProduto(dto);

            try
            {
                MessageBox.Show("Produto Alterado com Sucesso !");
                Consistencia.limparCampos2(this);
                dataGridProduto.DataSource = dao.ListarTodosProdutos();
                txtCodVenda.Focus();
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;

            }
            catch (Exception erro)
            {                
                throw erro;
            }
            
        }
        #endregion


        #region BOTAO EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ProdutoDTO dto = new ProdutoDTO();

            dto.IdProd = int.Parse(txtId.Text);

            ProdutoDAO dao = new ProdutoDAO();
            dao.ExcluirProduto(dto);
            
            try
            {
                MessageBox.Show("Produto Excluido com Sucesso !");                
                Consistencia.limparCampos2(this);
                dataGridProduto.DataSource = dao.ListarTodosProdutos();
                txtCodVenda.Focus();
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            catch (Exception erro)
            {                
                throw erro;
            }


        }
        #endregion


        #region BOTAO LIMPAR
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Consistencia.limparCampos2(this);
            txtCodVenda.Focus();
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }
        #endregion


        #region BOTAO SAIR
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair do Sistema", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion


        #region CARREGAR GRID NO FORMULARIO
        private void frmProdutos_Load(object sender, EventArgs e)
        {
            ProdutoDAO dao = new ProdutoDAO();
            dataGridProduto.DataSource = dao.ListarTodosProdutos();
        }
        #endregion


        #region PUXAR DADOS DO DATA GRID
        private void dataGridProduto_Click(object sender, EventArgs e)
        {
            txtId.Text=dataGridProduto.CurrentRow.Cells[0].Value.ToString();
            txtCodVenda.Text=dataGridProduto.CurrentRow.Cells[1].Value.ToString();
            txtDescr.Text=dataGridProduto.CurrentRow.Cells[2].Value.ToString();
            txtQuant.Text=dataGridProduto.CurrentRow.Cells[3].Value.ToString();
            txtCusto.Text=dataGridProduto.CurrentRow.Cells[4].Value.ToString();
            txtPrecoVenda.Text=dataGridProduto.CurrentRow.Cells[5].Value.ToString();

            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }
        #endregion


        #region PESQUISA POR NOME
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtpesquisa.Text;
            ProdutoDAO dao = new ProdutoDAO();
            dataGridProduto.DataSource = dao.ConsultarProdutoPorNome(pesquisa);
        }
        #endregion
    }
}
