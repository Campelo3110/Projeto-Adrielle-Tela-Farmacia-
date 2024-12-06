using System;
using System.Windows.Forms;
using TelaDeLogin.Cadastro;

namespace TelaDeLogin
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre a tela de cadastro de clientes
            CadastroClientes cadastroClientes = new CadastroClientes();
            cadastroClientes.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abre a tela de cadastro de usuario
            CadastroUsuario cadastroUsuario = new CadastroUsuario();
            cadastroUsuario.Show();
        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroMedicamento cadastroMedicamento = new CadastroMedicamento();
            cadastroMedicamento.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroVendas cadastroVendas = new CadastroVendas();
            cadastroVendas.Show();  
        }

        // Evento do botão "Sair"
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Fecha o aplicativo
        }

        private void ferramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
