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

namespace TelaDeLogin
{
    public partial class CadastroMedicamento : Form
    {
        private string connectionString = "Server=SPROA1090\\SQLEXPRESS01;Database=FarmaciaBC;Trusted_Connection=True;TrustServerCertificate=True;";

        public CadastroMedicamento()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos obrigatórios estão preenchidos
            if (string.IsNullOrWhiteSpace(txtNomeMedicamento.Text) ||
                string.IsNullOrWhiteSpace(txtFabricante.Text) ||
                string.IsNullOrWhiteSpace(txtDosagem.Text) ||
                string.IsNullOrWhiteSpace(cmbCategoria.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Coleta os dados do formulário
            string nomeMedicamento = txtNomeMedicamento.Text;
            string fabricante = txtFabricante.Text;
            string dosagem = txtDosagem.Text;
            string categoria = cmbCategoria.Text;
            string descricao = txtDescricao.Text;

            try
            {
                // Conecta ao banco de dados e insere os dados
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Query SQL para inserir os dados
                    string query = "INSERT INTO Medicamentos (Nome, Fabricante, Dosagem, Categoria, Descricao) " +
                                   "VALUES (@Nome, @Fabricante, @Dosagem, @Categoria, @Descricao)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Define os parâmetros para evitar SQL Injection
                        cmd.Parameters.AddWithValue("@Nome", nomeMedicamento);
                        cmd.Parameters.AddWithValue("@Fabricante", fabricante);
                        cmd.Parameters.AddWithValue("@Dosagem", dosagem);
                        cmd.Parameters.AddWithValue("@Categoria", categoria);
                        cmd.Parameters.AddWithValue("@Descricao", descricao);

                        // Executa o comando
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Medicamento cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparCampos(); // Limpa os campos após salvar
                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar o medicamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro caso algo dê errado
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
