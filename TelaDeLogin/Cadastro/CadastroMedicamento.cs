using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaDeLogin
{
    public partial class CadastroMedicamento : Form
    {
        public CadastroMedicamento()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeMedicamento.Text) ||
                string.IsNullOrWhiteSpace(txtFabricante.Text) ||
                string.IsNullOrWhiteSpace(txtDosagem.Text) ||
                string.IsNullOrWhiteSpace(cmbCategoria.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Simula o salvamento dos dados
            MessageBox.Show("Medicamento cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpa os campos após salvar
            LimparCampos();
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtCodigoMedicamento.Clear();
            txtNomeMedicamento.Clear();
            txtFabricante.Clear();
            txtDosagem.Clear();
            cmbCategoria.SelectedIndex = -1;
            txtDescricao.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
