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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }          

        #region BOTÃO INSERIR 
        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            UsuarioDTO dto = new UsuarioDTO();           

            dto.Nome = txtNome.Text;
            dto.Email = txtEmail.Text;
            dto.Login = txtLogin.Text;
            dto.Senha = txtSenha.Text;
            dto.Confsenha = txtConfSenha.Text;

            UsuarioDAO dao = new UsuarioDAO();
            dao.objInserir(dto);         

            try
            {               
                MessageBox.Show(" Usuario Cadastrado com Sucesso ");
                Consistencia.limparCampos2(this);
                dataGridUsuario.DataSource = dao.listarTodosUsuario();
                txtNome.Focus();
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
            UsuarioDTO dto = new UsuarioDTO();
            dto.Nome = txtNome.Text;
            dto.Email = txtEmail.Text;
            dto.Login = txtLogin.Text;
            dto.Senha = txtSenha.Text;
            dto.Confsenha = txtConfSenha.Text;
            dto.Id = int.Parse(txtCodigo.Text);

            UsuarioDAO dao = new UsuarioDAO();
            dao.objAlterar(dto);
            try
            {
                MessageBox.Show(" Usuario Alterado com Sucesso ");
                Consistencia.limparCampos2(this);
                dataGridUsuario.DataSource = dao.listarTodosUsuario();
                txtNome.Focus();
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        #endregion

        #region BOTÃO EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            UsuarioDTO dto = new UsuarioDTO();

            dto.Id = int.Parse(txtCodigo.Text);

            UsuarioDAO dao = new UsuarioDAO();
            dao.objExcluir(dto);

            try
            {
                MessageBox.Show(" Usuario Excluido com Sucesso ");
                Consistencia.limparCampos2(this);
                dataGridUsuario.DataSource = dao.listarTodosUsuario();
                txtNome.Focus();
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
        private void frmUsuario_Load(object sender, EventArgs e)
        {

            UsuarioDAO dao = new UsuarioDAO();            
            dataGridUsuario.DataSource = dao.listarTodosUsuario();
            
        }
        #endregion

        #region PESQUISA POR NOME
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;
            UsuarioDAO dao = new UsuarioDAO();
            dataGridUsuario.DataSource = dao.ConsultarUsuarioPorNome(pesquisa);
        }
        #endregion        

        #region PUXAR DADOS DO DATA GRID
        private void dataGridUsuario_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = dataGridUsuario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dataGridUsuario.CurrentRow.Cells[1].Value.ToString();            
            txtEmail.Text = dataGridUsuario.CurrentRow.Cells[2].Value.ToString();
            txtLogin.Text = dataGridUsuario.CurrentRow.Cells[3].Value.ToString();
            txtSenha.Text = dataGridUsuario.CurrentRow.Cells[4].Value.ToString();
            txtConfSenha.Text = dataGridUsuario.CurrentRow.Cells[5].Value.ToString();

            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }
        #endregion

        #region BOTÃO LIMPAR
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Consistencia.limparCampos2(this);
            txtNome.Focus();
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }
        #endregion

        #region BOTÃO SAIR

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair do Sistema", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #endregion
    }
}
