﻿using System;
using System.Windows.Forms;

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

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroMedicamento cadastroMedicamento = new CadastroMedicamento();
            cadastroMedicamento.Show();
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
