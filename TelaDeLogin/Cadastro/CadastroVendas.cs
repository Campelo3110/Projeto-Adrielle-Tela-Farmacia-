using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TelaDeLogin.Cadastro
{
    public partial class CadastroVendas : Form
    {
        private string connectionString = "Server=SPROA1090\\SQLEXPRESS01;Database=FarmaciaBC;Trusted_Connection=True;TrustServerCertificate=True;";

        public CadastroVendas()
        {
            InitializeComponent();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoProduto.Text) ||
                string.IsNullOrWhiteSpace(txtNomeProduto.Text) ||
                string.IsNullOrWhiteSpace(txtPrecoUnitario.Text) ||
                nudQuantidade.Value <= 0)
            {
                MessageBox.Show("Preencha todos os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcula o subtotal
            decimal precoUnitario = Convert.ToDecimal(txtPrecoUnitario.Text);
            int quantidade = (int)nudQuantidade.Value;
            decimal subtotal = precoUnitario * quantidade;

            // Adiciona ao DataGridView
            dgvItens.Rows.Add(txtCodigoProduto.Text, txtNomeProduto.Text, quantidade, precoUnitario, subtotal);

            // Atualiza o total geral
            AtualizarTotalGeral();

            // Limpa os campos para nova entrada
            LimparCampos();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvItens.SelectedRows.Count > 0)
            {
                dgvItens.Rows.Remove(dgvItens.SelectedRows[0]);
                AtualizarTotalGeral();
            }
            else
            {
                MessageBox.Show("Selecione um item para remover!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (dgvItens.Rows.Count == 0)
            {
                MessageBox.Show("Adicione itens antes de finalizar a venda!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Venda finalizada com sucesso!\nTotal Geral: R$ {txtTotalGeral.Text}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpa os campos e a lista de itens
            dgvItens.Rows.Clear();
            txtTotalGeral.Text = "0,00";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar a venda?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvItens.Rows.Clear();
                txtTotalGeral.Text = "0,00";
                LimparCampos();
            }
        }

        private void AtualizarTotalGeral()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvItens.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }

            txtTotalGeral.Text = total.ToString("F2");
        }

        private void LimparCampos()
        {
            txtCodigoProduto.Clear();
            txtNomeProduto.Clear();
            txtPrecoUnitario.Clear();
            nudQuantidade.Value = 1;
        }

        private void CadastroVendas_Load(object sender, EventArgs e)
        {

        }

        private void txtPrecoUnitario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
