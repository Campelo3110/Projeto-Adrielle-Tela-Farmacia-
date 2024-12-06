using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaDeLogin.Cadastro
{
    public partial class CadastroFornecedor : Form
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Validação básica dos campos
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCNPJ.Text) ||
                string.IsNullOrWhiteSpace(maskedTxtTelefone.Text) ||
                string.IsNullOrWhiteSpace(richTxtEndereco.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Exibe uma mensagem de sucesso (simulação de cadastro)
            MessageBox.Show("Fornecedor cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpar os campos após salvar
            LimparCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtCNPJ.Clear();
            maskedTxtTelefone.Clear();
            richTxtEndereco.Clear();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
