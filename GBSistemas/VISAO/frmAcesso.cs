using System;
using System.Windows.Forms;
using GBSistemas.MODELO;
using GBSistemas.DAO;

namespace GBSistemas
{
    public partial class frmAcesso : Form
    {
        public frmAcesso()
        {
            InitializeComponent();
        }

        private void btnCadastrarnovo_Click(object sender, EventArgs e)
        {
            if (true)
            {
                //cadastrar novo usuario
            }
            frmUsuario frmusuario = new frmUsuario();
            frmusuario.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDTO dto = new UsuarioDTO();
                dto.Login = txtLogin.Text;
                dto.Senha = txtSenha.Text;

                UsuarioDAO dao = new UsuarioDAO();
                
                if (dao.efetualogin(dto))
                {
                    MessageBox.Show("Seja bem vindo " + dto.Login);
                    
                    frmPrincipal frmPrinc = new frmPrincipal(dto.Login);
                    frmPrinc.ShowDialog();
                    this.Dispose();

                    txtLogin.Clear();                   
                    txtSenha.Clear();
                    txtLogin.Focus();
                }
                else
                {
                    MessageBox.Show("Login ou Senha incorreto");
                    btnCadastrarnovo.Enabled = true;
                    txtLogin.Clear();
                    txtSenha.Clear();
                    txtLogin.Focus();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                throw erro;
            }            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair do Sistema", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
