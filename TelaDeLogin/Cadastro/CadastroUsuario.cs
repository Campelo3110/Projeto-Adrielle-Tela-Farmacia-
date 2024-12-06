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
    public partial class CadastroUsuario : Form
    {
        private string connectionString = "Server=SPROA1090\\SQLEXPRESS01;Database=FarmaciaBC;Trusted_Connection=True;TrustServerCertificate=True;";

        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Validação básica dos campos
            if (string.IsNullOrWhiteSpace(txtNomeUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmarSenha.Text) ||
                string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se as senhas coincidem
            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Coleta os dados do formulário
            string nomeUsuario = txtNomeUsuario.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string telefone = txtTelefone.Text;

            try
            {
                // Conecta ao banco de dados e insere os dados
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Query SQL para inserir os dados
                    string query = "INSERT INTO Usuarios (Nome, Email, Senha, Telefone) " +
                                   "VALUES (@Nome, @Email, @Senha, @Telefone)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Define os parâmetros para evitar SQL Injection
                        cmd.Parameters.AddWithValue("@Nome", txtNomeUsuario.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Senha", txtSenha.Text);
                        cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);

                        // Executa o comando
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario cadastrado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparCampos(); // Limpa os campos após salvar
                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar o usuario.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparCampos()
        {
            txtNomeUsuario.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtConfirmarSenha.Clear();
            txtTelefone.Clear();
        }

        private void cmbTelefone_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
