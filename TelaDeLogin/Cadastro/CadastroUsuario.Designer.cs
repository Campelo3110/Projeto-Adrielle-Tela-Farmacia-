namespace TelaDeLogin
{
    partial class CadastroUsuario
    {
        private Label lblNomeUsuario;
        private TextBox txtNomeUsuario;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblSenha;
        private TextBox txtSenha;
        private Label lblConfirmarSenha;
        private TextBox txtConfirmarSenha;
        private Label lblTipoUsuario;
        private ComboBox cmbTipoUsuario;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnFechar;

        private void InitializeComponent()
        {
            lblNomeUsuario = new Label();
            txtNomeUsuario = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            lblConfirmarSenha = new Label();
            txtConfirmarSenha = new TextBox();
            lblTipoUsuario = new Label();
            cmbTipoUsuario = new ComboBox();
            btnSalvar = new Button();
            btnLimpar = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.Location = new Point(20, 20);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(131, 23);
            lblNomeUsuario.TabIndex = 0;
            lblNomeUsuario.Text = "Nome do Usuário:";
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Location = new Point(150, 20);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(250, 27);
            txtNomeUsuario.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(20, 60);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-mail:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 60);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 3;
            // 
            // lblSenha
            // 
            lblSenha.Location = new Point(20, 100);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(100, 23);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(150, 100);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(250, 27);
            txtSenha.TabIndex = 5;
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.Location = new Point(20, 140);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(100, 23);
            lblConfirmarSenha.TabIndex = 6;
            lblConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(150, 140);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.Size = new Size(250, 27);
            txtConfirmarSenha.TabIndex = 7;
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.Location = new Point(20, 180);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(131, 23);
            lblTipoUsuario.TabIndex = 8;
            lblTipoUsuario.Text = "Tipo de Usuário:";
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.Items.AddRange(new object[] { "Administrador", "Usuário Comum" });
            cmbTipoUsuario.Location = new Point(150, 180);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(250, 28);
            cmbTipoUsuario.TabIndex = 9;
            cmbTipoUsuario.SelectedIndexChanged += cmbTipoUsuario_SelectedIndexChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(50, 230);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(150, 230);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 11;
            btnLimpar.Text = "Limpar";
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(250, 230);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 12;
            btnFechar.Text = "Fechar";
            btnFechar.Click += btnFechar_Click;
            // 
            // CadastroUsuario
            // 
            ClientSize = new Size(450, 300);
            Controls.Add(lblNomeUsuario);
            Controls.Add(txtNomeUsuario);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblSenha);
            Controls.Add(txtSenha);
            Controls.Add(lblConfirmarSenha);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(lblTipoUsuario);
            Controls.Add(cmbTipoUsuario);
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(btnFechar);
            Name = "CadastroUsuario";
            Text = "Cadastro de Usuários";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}