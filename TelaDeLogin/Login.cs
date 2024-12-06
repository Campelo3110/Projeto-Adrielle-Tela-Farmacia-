using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace TelaDeLogin
{
    public partial class Login : Form
    {
        // String de conexão com o banco de dados
        private string connectionString = "Server=SPROA1090\\SQLEXPRESS01;Database=FarmaciaBC;Trusted_Connection=True;\r\n";

        public Login()
        {
            InitializeComponent();
        }

        // Evento do botão Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            // Validação simples
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                lblMensagem.Text = "Por favor, preencha todos os campos.";
                lblMensagem.ForeColor = System.Drawing.Color.Red;
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Abre a conexão
                    conn.Open();

                    // Query para verificar as credenciais
                    string query = "SELECT COUNT(1) FROM Usuarios WHERE Nome = @Usuario AND Senha = @Senha";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Define os parâmetros
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@Senha", senha);

                        // Executa o comando
                        int result = (int)cmd.ExecuteScalar();

                        if (result == 1)
                        {
                            lblMensagem.Text = "Login realizado com sucesso!";
                            lblMensagem.ForeColor = System.Drawing.Color.Green;

                            // Abre o Menu Principal e fecha o formulário de login
                            MenuPrincipal menu = new MenuPrincipal();
                            menu.Show();
                            this.Hide();

                            MessageBox.Show("Bem-vindo ao sistema!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            lblMensagem.Text = "Usuário ou senha inválidos.";
                            lblMensagem.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibe mensagem de erro caso algo dê errado
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
