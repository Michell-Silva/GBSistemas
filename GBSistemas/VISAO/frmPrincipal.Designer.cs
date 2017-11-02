namespace GBSistemas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasPorPeriodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasPorProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.barra_status = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbreCaixa = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnAlteraProduto = new System.Windows.Forms.Button();
            this.btnFechaCaixa = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.btnBilheteria = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.Barra_de_Status = new System.Windows.Forms.StatusStrip();
            this.lblGbSistema = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.Barra_de_Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.movimentoToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroUsuarioToolStripMenuItem,
            this.cadastroProdutosToolStripMenuItem,
            this.cadastroClientesToolStripMenuItem,
            this.cadastroFornecedoresToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.cadastroToolStripMenuItem.Text = "Ca&dastro";
            // 
            // cadastroUsuarioToolStripMenuItem
            // 
            this.cadastroUsuarioToolStripMenuItem.Name = "cadastroUsuarioToolStripMenuItem";
            this.cadastroUsuarioToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.cadastroUsuarioToolStripMenuItem.Text = "Cadastro Usuario";
            this.cadastroUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cadastroUsuarioToolStripMenuItem_Click);
            // 
            // cadastroProdutosToolStripMenuItem
            // 
            this.cadastroProdutosToolStripMenuItem.Name = "cadastroProdutosToolStripMenuItem";
            this.cadastroProdutosToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.cadastroProdutosToolStripMenuItem.Text = "Cadastro Produto";
            this.cadastroProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastroProdutosToolStripMenuItem_Click);
            // 
            // cadastroClientesToolStripMenuItem
            // 
            this.cadastroClientesToolStripMenuItem.Name = "cadastroClientesToolStripMenuItem";
            this.cadastroClientesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.cadastroClientesToolStripMenuItem.Text = "Cadastro Cliente";
            this.cadastroClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastroClientesToolStripMenuItem_Click);
            // 
            // cadastroFornecedoresToolStripMenuItem
            // 
            this.cadastroFornecedoresToolStripMenuItem.Name = "cadastroFornecedoresToolStripMenuItem";
            this.cadastroFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.cadastroFornecedoresToolStripMenuItem.Text = "Cadastro Fornecedor";
            this.cadastroFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.cadastroFornecedoresToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.fornecedoresToolStripMenuItem1});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.consultaToolStripMenuItem.Text = "Con&sulta";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.produtosToolStripMenuItem.Text = "Produto";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.fornecedoresToolStripMenuItem.Text = "Usuario";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.clientesToolStripMenuItem.Text = "Cliente";
            // 
            // fornecedoresToolStripMenuItem1
            // 
            this.fornecedoresToolStripMenuItem1.Name = "fornecedoresToolStripMenuItem1";
            this.fornecedoresToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.fornecedoresToolStripMenuItem1.Text = "Fornecedor";
            // 
            // movimentoToolStripMenuItem
            // 
            this.movimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.fechaCaixaToolStripMenuItem});
            this.movimentoToolStripMenuItem.Name = "movimentoToolStripMenuItem";
            this.movimentoToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.movimentoToolStripMenuItem.Text = "Cai&xa";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.aToolStripMenuItem.Text = "Abre Caixa";
            // 
            // fechaCaixaToolStripMenuItem
            // 
            this.fechaCaixaToolStripMenuItem.Name = "fechaCaixaToolStripMenuItem";
            this.fechaCaixaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.fechaCaixaToolStripMenuItem.Text = "Fecha Caixa";
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasPorPeriodoToolStripMenuItem,
            this.vendasPorProdutoToolStripMenuItem});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.relatórioToolStripMenuItem.Text = "&Relatório";
            // 
            // vendasPorPeriodoToolStripMenuItem
            // 
            this.vendasPorPeriodoToolStripMenuItem.Name = "vendasPorPeriodoToolStripMenuItem";
            this.vendasPorPeriodoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.vendasPorPeriodoToolStripMenuItem.Text = "Vendas por periodo";
            // 
            // vendasPorProdutoToolStripMenuItem
            // 
            this.vendasPorProdutoToolStripMenuItem.Name = "vendasPorProdutoToolStripMenuItem";
            this.vendasPorProdutoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.vendasPorProdutoToolStripMenuItem.Text = "Vendas por Produto";
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.blocoDeNotasToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(96, 21);
            this.ferramentasToolStripMenuItem.Text = "Ferra&mentas";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            this.blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            this.blocoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.blocoDeNotasToolStripMenuItem.Text = "Bloco de Notas";
            this.blocoDeNotasToolStripMenuItem.Click += new System.EventHandler(this.blocoDeNotasToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualUsuarioToolStripMenuItem,
            this.sobreSistemaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.barra_status});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // manualUsuarioToolStripMenuItem
            // 
            this.manualUsuarioToolStripMenuItem.Name = "manualUsuarioToolStripMenuItem";
            this.manualUsuarioToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.manualUsuarioToolStripMenuItem.Text = "Manual Usuario";
            // 
            // sobreSistemaToolStripMenuItem
            // 
            this.sobreSistemaToolStripMenuItem.Name = "sobreSistemaToolStripMenuItem";
            this.sobreSistemaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.sobreSistemaToolStripMenuItem.Text = "Sobre Sistema";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 6);
            // 
            // barra_status
            // 
            this.barra_status.Checked = true;
            this.barra_status.CheckOnClick = true;
            this.barra_status.CheckState = System.Windows.Forms.CheckState.Checked;
            this.barra_status.Name = "barra_status";
            this.barra_status.Size = new System.Drawing.Size(173, 22);
            this.barra_status.Text = "Status";
            this.barra_status.Click += new System.EventHandler(this.barra_status_Click);
            // 
            // btnAbreCaixa
            // 
            this.btnAbreCaixa.BackColor = System.Drawing.Color.Transparent;
            this.btnAbreCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAbreCaixa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAbreCaixa.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAbreCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbreCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbreCaixa.ForeColor = System.Drawing.Color.Transparent;
            this.btnAbreCaixa.Image = global::GBSistemas.Properties.Resources.if_cash_register_17219__1_;
            this.btnAbreCaixa.Location = new System.Drawing.Point(82, 105);
            this.btnAbreCaixa.Name = "btnAbreCaixa";
            this.btnAbreCaixa.Size = new System.Drawing.Size(130, 106);
            this.btnAbreCaixa.TabIndex = 0;
            this.btnAbreCaixa.Text = "Caixa";
            this.btnAbreCaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbreCaixa.UseVisualStyleBackColor = false;
            this.btnAbreCaixa.Click += new System.EventHandler(this.btnAbreCaixa_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProduto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProduto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto.ForeColor = System.Drawing.Color.Transparent;
            this.btnProduto.Image = global::GBSistemas.Properties.Resources.if_shopping_basket_add_63149;
            this.btnProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProduto.Location = new System.Drawing.Point(266, 105);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(130, 106);
            this.btnProduto.TabIndex = 2;
            this.btnProduto.Text = "Cadastro de Produto";
            this.btnProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduto.UseVisualStyleBackColor = false;
            this.btnProduto.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRelatorio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRelatorio.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.Transparent;
            this.btnRelatorio.Image = global::GBSistemas.Properties.Resources.if_edit_paste_38992__1_;
            this.btnRelatorio.Location = new System.Drawing.Point(450, 105);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(130, 106);
            this.btnRelatorio.TabIndex = 4;
            this.btnRelatorio.Text = "Relatórios";
            this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRelatorio.UseVisualStyleBackColor = false;
            // 
            // btnAlteraProduto
            // 
            this.btnAlteraProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnAlteraProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlteraProduto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlteraProduto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAlteraProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlteraProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlteraProduto.ForeColor = System.Drawing.Color.Transparent;
            this.btnAlteraProduto.Image = global::GBSistemas.Properties.Resources.if_shopping_basket_refresh_63153;
            this.btnAlteraProduto.Location = new System.Drawing.Point(266, 249);
            this.btnAlteraProduto.Name = "btnAlteraProduto";
            this.btnAlteraProduto.Size = new System.Drawing.Size(130, 106);
            this.btnAlteraProduto.TabIndex = 3;
            this.btnAlteraProduto.Text = "Alterar Produto";
            this.btnAlteraProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlteraProduto.UseVisualStyleBackColor = false;
            this.btnAlteraProduto.Click += new System.EventHandler(this.btnAlteraProduto_Click);
            // 
            // btnFechaCaixa
            // 
            this.btnFechaCaixa.BackColor = System.Drawing.Color.Transparent;
            this.btnFechaCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechaCaixa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechaCaixa.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnFechaCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechaCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechaCaixa.ForeColor = System.Drawing.Color.Transparent;
            this.btnFechaCaixa.Image = global::GBSistemas.Properties.Resources.if_Finance_loan_money_1889199;
            this.btnFechaCaixa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFechaCaixa.Location = new System.Drawing.Point(82, 249);
            this.btnFechaCaixa.Name = "btnFechaCaixa";
            this.btnFechaCaixa.Size = new System.Drawing.Size(130, 106);
            this.btnFechaCaixa.TabIndex = 1;
            this.btnFechaCaixa.Text = "Fechamento do Caixa";
            this.btnFechaCaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFechaCaixa.UseVisualStyleBackColor = false;
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalculadora.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCalculadora.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadora.ForeColor = System.Drawing.Color.Transparent;
            this.btnCalculadora.Image = global::GBSistemas.Properties.Resources.if_calculator_43665__1_;
            this.btnCalculadora.Location = new System.Drawing.Point(450, 249);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(130, 106);
            this.btnCalculadora.TabIndex = 5;
            this.btnCalculadora.Text = "Calculadora";
            this.btnCalculadora.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalculadora.UseVisualStyleBackColor = false;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // btnBilheteria
            // 
            this.btnBilheteria.BackColor = System.Drawing.Color.Transparent;
            this.btnBilheteria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBilheteria.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBilheteria.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnBilheteria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBilheteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilheteria.ForeColor = System.Drawing.Color.Transparent;
            this.btnBilheteria.Image = global::GBSistemas.Properties.Resources.if_tickets_49628;
            this.btnBilheteria.Location = new System.Drawing.Point(629, 105);
            this.btnBilheteria.Name = "btnBilheteria";
            this.btnBilheteria.Size = new System.Drawing.Size(130, 106);
            this.btnBilheteria.TabIndex = 6;
            this.btnBilheteria.Text = "Bilheteria";
            this.btnBilheteria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBilheteria.UseVisualStyleBackColor = false;
            this.btnBilheteria.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = global::GBSistemas.Properties.Resources.if_xfce_system_exit_23651;
            this.btnSair.Location = new System.Drawing.Point(629, 249);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(130, 106);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Barra_de_Status
            // 
            this.Barra_de_Status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barra_de_Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblGbSistema,
            this.lblData,
            this.lblHora,
            this.lblUsuario});
            this.Barra_de_Status.Location = new System.Drawing.Point(0, 434);
            this.Barra_de_Status.Name = "Barra_de_Status";
            this.Barra_de_Status.Size = new System.Drawing.Size(840, 22);
            this.Barra_de_Status.TabIndex = 9;
            this.Barra_de_Status.Text = "BarraDeStatus";
            // 
            // lblGbSistema
            // 
            this.lblGbSistema.BackColor = System.Drawing.Color.Lavender;
            this.lblGbSistema.Name = "lblGbSistema";
            this.lblGbSistema.Size = new System.Drawing.Size(127, 17);
            this.lblGbSistema.Text = "toolStripStatusLabel1";
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.Color.Lavender;
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(127, 17);
            this.lblData.Text = "toolStripStatusLabel2";
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.Color.Lavender;
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(127, 17);
            this.lblHora.Text = "toolStripStatusLabel3";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.Lavender;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(127, 17);
            this.lblUsuario.Text = "toolStripStatusLabel4";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = global::GBSistemas.Properties.Resources.thumb_1920_535390__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 456);
            this.Controls.Add(this.Barra_de_Status);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnBilheteria);
            this.Controls.Add(this.btnCalculadora);
            this.Controls.Add(this.btnFechaCaixa);
            this.Controls.Add(this.btnAlteraProduto);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnAbreCaixa);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Barra_de_Status.ResumeLayout(false);
            this.Barra_de_Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasPorPeriodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasPorProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaCaixaToolStripMenuItem;
        private System.Windows.Forms.Button btnAbreCaixa;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnAlteraProduto;
        private System.Windows.Forms.Button btnFechaCaixa;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.Button btnBilheteria;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.StatusStrip Barra_de_Status;
        private System.Windows.Forms.ToolStripStatusLabel lblGbSistema;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem sobreSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem barra_status;
    }
}

