namespace TelaDeLogin.Cadastro
{
    partial class CadastroFornecedor
    {
        private Label lblNome;
        private TextBox txtNome;
        private Label lblCNPJ;
        private TextBox txtCNPJ;
        private Label lblTelefone;
        private MaskedTextBox maskedTxtTelefone;
        private Label lblEndereco;
        private RichTextBox richTxtEndereco;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnFechar;

        private void InitializeComponent()
        {
            lblNome = new Label();
            txtNome = new TextBox();
            lblCNPJ = new Label();
            txtCNPJ = new TextBox();
            lblTelefone = new Label();
            maskedTxtTelefone = new MaskedTextBox();
            lblEndereco = new Label();
            richTxtEndereco = new RichTextBox();
            btnSalvar = new Button();
            btnLimpar = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Location = new Point(20, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(156, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome do Fornecedor:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(173, 20);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(250, 27);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // lblCNPJ
            // 
            lblCNPJ.Location = new Point(20, 60);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(100, 23);
            lblCNPJ.TabIndex = 2;
            lblCNPJ.Text = "CNPJ:";
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(173, 57);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(250, 27);
            txtCNPJ.TabIndex = 3;
            // 
            // lblTelefone
            // 
            lblTelefone.Location = new Point(20, 100);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(100, 23);
            lblTelefone.TabIndex = 4;
            lblTelefone.Text = "Telefone:";
            // 
            // maskedTxtTelefone
            // 
            maskedTxtTelefone.Location = new Point(173, 100);
            maskedTxtTelefone.Mask = "(00) 00000-0000";
            maskedTxtTelefone.Name = "maskedTxtTelefone";
            maskedTxtTelefone.Size = new Size(250, 27);
            maskedTxtTelefone.TabIndex = 5;
            // 
            // lblEndereco
            // 
            lblEndereco.Location = new Point(20, 140);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(100, 23);
            lblEndereco.TabIndex = 6;
            lblEndereco.Text = "Endereço:";
            // 
            // richTxtEndereco
            // 
            richTxtEndereco.Location = new Point(173, 140);
            richTxtEndereco.Name = "richTxtEndereco";
            richTxtEndereco.Size = new Size(250, 80);
            richTxtEndereco.TabIndex = 7;
            richTxtEndereco.Text = "";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(45, 287);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 30);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(144, 287);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 30);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(244, 287);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 30);
            btnFechar.TabIndex = 10;
            btnFechar.Text = "Fechar";
            btnFechar.Click += btnFechar_Click;
            // 
            // CadastroFornecedor
            // 
            ClientSize = new Size(450, 350);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblCNPJ);
            Controls.Add(txtCNPJ);
            Controls.Add(lblTelefone);
            Controls.Add(maskedTxtTelefone);
            Controls.Add(lblEndereco);
            Controls.Add(richTxtEndereco);
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(btnFechar);
            Name = "CadastroFornecedor";
            Text = "Cadastro de Fornecedores";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}