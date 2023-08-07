using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace PadariaCarmel
{
    public partial class frmFuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);


        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }
        //desabilitar campos
        public void desabilitarCampos()
        {
            txtBairro.Enabled = false;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEmail.Enabled = false;


            mskCep.Enabled = false;
            mskCPF.Enabled = false;
            mskTelefone.Enabled = false;


            cbbEstado.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }

        public void habilitarCampos()
        {
            txtBairro.Enabled = false;
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEmail.Enabled = true;


            mskCep.Enabled = true;
            mskCPF.Enabled = true;
            mskTelefone.Enabled = true;


            cbbEstado.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;

            txtNome.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            desabilitarCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            desabilitarCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            desabilitarCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastrado com Sucesso", "Mensagem do sistema.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            desabilitarCampos();
            btnNovo.Enabled = true;
            limparCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        public void limparCampos()
        {
            txtBairro.Enabled = false;
            txtNome.Clear();
            txtEndereco.Clear(); 
            txtBairro.Clear();
            txtCidade.Clear();
            txtEmail.Clear();


            mskCep.Clear();
            mskCPF.Clear();
            mskTelefone.Clear();


            cbbEstado.Text = "";

            //btnCadastrar.Clear();
            //btnAlterar.Clear();
            //btnExcluir.Clear();
           /// btnLimpar.Clear();
            //btnNovo.Clear();

            txtNome.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
