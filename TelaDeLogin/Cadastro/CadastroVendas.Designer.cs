namespace TelaDeLogin.Cadastro
{
    partial class CadastroVendas
    {
        // Componentes
        private Label lblCodigoProduto;
        private TextBox txtCodigoProduto;
        private Button btnBuscarProduto;
        private Label lblNomeProduto;
        private TextBox txtNomeProduto;
        private Label lblPrecoUnitario;
        private TextBox txtPrecoUnitario;
        private Label lblQuantidade;
        private NumericUpDown nudQuantidade;
        private Label lblSubtotal;
        private TextBox txtSubtotal;
        private DataGridView dgvItens;
        private TextBox txtTotalGeral;
        private Button btnAdicionar;
        private Button btnRemover;
        private Button btnFinalizar;
        private Button btnCancelar;

        // Inicialização
        private void InitializeComponent()
        {
            lblCodigoProduto = new Label();
            txtCodigoProduto = new TextBox();
            btnBuscarProduto = new Button();
            lblNomeProduto = new Label();
            txtNomeProduto = new TextBox();
            lblPrecoUnitario = new Label();
            txtPrecoUnitario = new TextBox();
            lblQuantidade = new Label();
            nudQuantidade = new NumericUpDown();
            lblSubtotal = new Label();
            txtSubtotal = new TextBox();
            dgvItens = new DataGridView();
            txtTotalGeral = new TextBox();
            btnAdicionar = new Button();
            btnRemover = new Button();
            btnFinalizar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItens).BeginInit();
            SuspendLayout();
            // 
            // lblCodigoProduto
            // 
            lblCodigoProduto.Location = new Point(20, 20);
            lblCodigoProduto.Name = "lblCodigoProduto";
            lblCodigoProduto.Size = new Size(141, 23);
            lblCodigoProduto.TabIndex = 0;
            lblCodigoProduto.Text = "Código do Produto:";
            // 
            // txtCodigoProduto
            // 
            txtCodigoProduto.Location = new Point(167, 20);
            txtCodigoProduto.Name = "txtCodigoProduto";
            txtCodigoProduto.Size = new Size(100, 27);
            txtCodigoProduto.TabIndex = 1;
            // 
            // btnBuscarProduto
            // 
            btnBuscarProduto.Location = new Point(300, 20);
            btnBuscarProduto.Name = "btnBuscarProduto";
            btnBuscarProduto.Size = new Size(75, 27);
            btnBuscarProduto.TabIndex = 2;
            btnBuscarProduto.Text = "Buscar";
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.Location = new Point(20, 60);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(136, 23);
            lblNomeProduto.TabIndex = 3;
            lblNomeProduto.Text = "Nome do Produto:";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(167, 60);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(100, 27);
            txtNomeProduto.TabIndex = 4;
            // 
            // lblPrecoUnitario
            // 
            lblPrecoUnitario.Location = new Point(20, 100);
            lblPrecoUnitario.Name = "lblPrecoUnitario";
            lblPrecoUnitario.Size = new Size(100, 23);
            lblPrecoUnitario.TabIndex = 5;
            lblPrecoUnitario.Text = "Preço Unitário:";
            // 
            // txtPrecoUnitario
            // 
            txtPrecoUnitario.Location = new Point(167, 100);
            txtPrecoUnitario.Name = "txtPrecoUnitario";
            txtPrecoUnitario.Size = new Size(100, 27);
            txtPrecoUnitario.TabIndex = 6;
            txtPrecoUnitario.TextChanged += txtPrecoUnitario_TextChanged;
            // 
            // lblQuantidade
            // 
            lblQuantidade.Location = new Point(20, 140);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(100, 23);
            lblQuantidade.TabIndex = 7;
            lblQuantidade.Text = "Quantidade:";
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new Point(167, 140);
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(120, 27);
            nudQuantidade.TabIndex = 8;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Location = new Point(20, 180);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(100, 23);
            lblSubtotal.TabIndex = 9;
            lblSubtotal.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(167, 177);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(100, 27);
            txtSubtotal.TabIndex = 10;
            // 
            // dgvItens
            // 
            dgvItens.ColumnHeadersHeight = 29;
            dgvItens.Location = new Point(20, 220);
            dgvItens.Name = "dgvItens";
            dgvItens.RowHeadersWidth = 51;
            dgvItens.Size = new Size(600, 200);
            dgvItens.TabIndex = 11;
            // 
            // txtTotalGeral
            // 
            txtTotalGeral.Location = new Point(500, 440);
            txtTotalGeral.Name = "txtTotalGeral";
            txtTotalGeral.ReadOnly = true;
            txtTotalGeral.Size = new Size(100, 27);
            txtTotalGeral.TabIndex = 16;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(20, 440);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 32);
            btnAdicionar.TabIndex = 12;
            btnAdicionar.Text = "Adicionar";
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(120, 440);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 32);
            btnRemover.TabIndex = 13;
            btnRemover.Text = "Remover";
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(212, 440);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(75, 32);
            btnFinalizar.TabIndex = 14;
            btnFinalizar.Text = "Finalizar";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(320, 440);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 32);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            // 
            // CadastroVendas
            // 
            ClientSize = new Size(682, 484);
            Controls.Add(lblCodigoProduto);
            Controls.Add(txtCodigoProduto);
            Controls.Add(btnBuscarProduto);
            Controls.Add(lblNomeProduto);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblPrecoUnitario);
            Controls.Add(txtPrecoUnitario);
            Controls.Add(lblQuantidade);
            Controls.Add(nudQuantidade);
            Controls.Add(lblSubtotal);
            Controls.Add(txtSubtotal);
            Controls.Add(dgvItens);
            Controls.Add(btnAdicionar);
            Controls.Add(btnRemover);
            Controls.Add(btnFinalizar);
            Controls.Add(btnCancelar);
            Controls.Add(txtTotalGeral);
            Name = "CadastroVendas";
            Text = "Tela de Vendas";
            Load += CadastroVendas_Load;
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}