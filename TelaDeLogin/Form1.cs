using System;
using System.Windows.Forms;

namespace TelaDeLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento do bot�o Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            // Valida��o simples
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                lblMensagem.Text = "Por favor, preencha todos os campos.";
                lblMensagem.ForeColor = System.Drawing.Color.Red;
            }
            else if (usuario == "admin" && senha == "1234") // Credenciais fixas para teste
            {
                lblMensagem.Text = "Login realizado com sucesso!";
                lblMensagem.ForeColor = System.Drawing.Color.Green;

                // Abre o Menu Principal e fecha o formul�rio de login
                MenuPrincipal menu = new MenuPrincipal();
                menu.Show();
                this.Hide(); // Esconde o formul�rio de login

                // Aqui voc� pode redirecionar para outra janela, se necess�rio.
                MessageBox.Show("Bem-vindo ao sistema!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblMensagem.Text = "Usu�rio ou senha inv�lidos.";
                lblMensagem.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
