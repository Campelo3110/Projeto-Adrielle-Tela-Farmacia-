namespace TelaDeLogin
{
    partial class CadastroMedicamento
    {
        // Componentes
        private Label lblCodigoMedicamento;
        private TextBox txtCodigoMedicamento;
        private Label lblNomeMedicamento;
        private TextBox txtNomeMedicamento;
        private Label lblFabricante;
        private TextBox txtFabricante;
        private Label lblDosagem;
        private TextBox txtDosagem;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private Label lblDescricao;
        private TextBox txtDescricao;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnCancelar;
        private ComboBox cmbFornecedor;
        private Label lblPreco;
        private TextBox txtPreco;

        // Inicialização
        private void InitializeComponent()
        {
            lblCodigoMedicamento = new Label();
            txtCodigoMedicamento = new TextBox();
            lblNomeMedicamento = new Label();
            txtNomeMedicamento = new TextBox();
            lblFabricante = new Label();
            txtFabricante = new TextBox();
            lblDosagem = new Label();
            txtDosagem = new TextBox();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            btnSalvar = new Button();
            btnLimpar = new Button();
            btnCancelar = new Button();
            cmbFornecedor = new ComboBox();
            lblPreco = new Label();  
            txtPreco = new TextBox();

            SuspendLayout();

            // 
            // lblCodigoMedicamento
            // 
            lblCodigoMedicamento.Location = new Point(20, 20);
            lblCodigoMedicamento.Name = "lblCodigoMedicamento";
            lblCodigoMedicamento.Size = new Size(100, 23);
            lblCodigoMedicamento.TabIndex = 0;
            lblCodigoMedicamento.Text = "Código:";
            // 
            // txtCodigoMedicamento
            // 
            txtCodigoMedicamento.Location = new Point(150, 20);
            txtCodigoMedicamento.Name = "txtCodigoMedicamento";
            txtCodigoMedicamento.Size = new Size(100, 27);
            txtCodigoMedicamento.TabIndex = 1;

            // 
            // lblNomeMedicamento
            // 
            lblNomeMedicamento.Location = new Point(20, 60);
            lblNomeMedicamento.Name = "lblNomeMedicamento";
            lblNomeMedicamento.Size = new Size(100, 23);
            lblNomeMedicamento.TabIndex = 2;
            lblNomeMedicamento.Text = "Nome:";
            // 
            // txtNomeMedicamento
            // 
            txtNomeMedicamento.Location = new Point(150, 60);
            txtNomeMedicamento.Name = "txtNomeMedicamento";
            txtNomeMedicamento.Size = new Size(100, 27);
            txtNomeMedicamento.TabIndex = 3;

            // 
            // lblFabricante
            // 
            lblFabricante.Location = new Point(20, 100);
            lblFabricante.Name = "lblFabricante";
            lblFabricante.Size = new Size(100, 23);
            lblFabricante.TabIndex = 4;
            lblFabricante.Text = "Fabricante:";
            // 
            // txtFabricante
            // 
            txtFabricante.Location = new Point(150, 100);
            txtFabricante.Name = "txtFabricante";
            txtFabricante.Size = new Size(100, 27);
            txtFabricante.TabIndex = 5;

            // 
            // lblDosagem
            // 
            lblDosagem.Location = new Point(20, 140);
            lblDosagem.Name = "lblDosagem";
            lblDosagem.Size = new Size(100, 23);
            lblDosagem.TabIndex = 6;
            lblDosagem.Text = "Dosagem:";
            // 
            // txtDosagem
            // 
            txtDosagem.Location = new Point(150, 140);
            txtDosagem.Name = "txtDosagem";
            txtDosagem.Size = new Size(100, 27);
            txtDosagem.TabIndex = 7;

            // 
            // lblCategoria
            // 
            lblCategoria.Location = new Point(20, 180);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(100, 23);
            lblCategoria.TabIndex = 8;
            lblCategoria.Text = "Categoria:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.Items.AddRange(new object[] { "Analgésico", "Antibiótico", "Antidepressivo", "Anti-inflamatório", "Outros" });
            cmbCategoria.Location = new Point(150, 180);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 28);
            cmbCategoria.TabIndex = 9;

            // 
            // lblDescricao
            // 
            lblDescricao.Location = new Point(20, 220);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(100, 23);
            lblDescricao.TabIndex = 10;
            lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(150, 220);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(200, 100);
            txtDescricao.TabIndex = 11;

            // 
            // lblPreco
            // 
            lblPreco.Location = new Point(20, 340);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(100, 23);
            lblPreco.TabIndex = 12;
            lblPreco.Text = "Preço:";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(150, 340);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 27);
            txtPreco.TabIndex = 13;

            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(20, 380);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 33);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;

            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(120, 380);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 33);
            btnLimpar.TabIndex = 15;
            btnLimpar.Text = "Limpar";
            btnLimpar.Click += btnLimpar_Click;

            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(220, 380);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 33);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;

            // 
            // CadastroMedicamento
            // 
            ClientSize = new Size(382, 423);
            Controls.Add(lblCodigoMedicamento);
            Controls.Add(txtCodigoMedicamento);
            Controls.Add(lblNomeMedicamento);
            Controls.Add(txtNomeMedicamento);
            Controls.Add(lblFabricante);
            Controls.Add(txtFabricante);
            Controls.Add(lblDosagem);
            Controls.Add(txtDosagem);
            Controls.Add(lblCategoria);
            Controls.Add(cmbCategoria);
            Controls.Add(lblDescricao);
            Controls.Add(txtDescricao);
            Controls.Add(lblPreco);  // Adicionando o Label Preço
            Controls.Add(txtPreco);  // Adicionando o TextBox Preço
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(btnCancelar);
            Name = "CadastroMedicamento";
            Text = "Cadastro de Medicamento";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
