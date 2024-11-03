namespace over.Views.ModuloControles.ModuloControleVendas.ModuloVendas
{
    partial class Vendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelNomeUsuario = new System.Windows.Forms.Label();
            this.iconPerfil = new System.Windows.Forms.PictureBox();
            this.labelVendas = new System.Windows.Forms.Label();
            this.labelVoltar = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._databasefazenda_1DataSet = new over._databasefazenda_1DataSet();
            this.vendasTableAdapter = new over._databasefazenda_1DataSetTableAdapters.VendasTableAdapter();
            this.btnExportarDados = new System.Windows.Forms.PictureBox();
            this.labelPesquisarPorCodigoDeCompra = new System.Windows.Forms.Label();
            this.textBoxPesquisaPorCodigo = new System.Windows.Forms.TextBox();
            this.textBoxPesquisaIDProduto = new System.Windows.Forms.TextBox();
            this.labelPesquisaPorIDProduto = new System.Windows.Forms.Label();
            this.labelPesquisaPorIDCliente = new System.Windows.Forms.Label();
            this.textBoxPesquisaIDCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._databasefazenda_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportarDados)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomeUsuario
            // 
            this.labelNomeUsuario.AutoSize = true;
            this.labelNomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeUsuario.Location = new System.Drawing.Point(1212, 22);
            this.labelNomeUsuario.Name = "labelNomeUsuario";
            this.labelNomeUsuario.Size = new System.Drawing.Size(66, 24);
            this.labelNomeUsuario.TabIndex = 56;
            this.labelNomeUsuario.Text = "label2";
            this.labelNomeUsuario.Click += new System.EventHandler(this.labelNomeUsuario_Click);
            // 
            // iconPerfil
            // 
            this.iconPerfil.BackColor = System.Drawing.Color.Transparent;
            this.iconPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPerfil.Image = global::over.Properties.Resources.iconPerfil;
            this.iconPerfil.Location = new System.Drawing.Point(1171, 11);
            this.iconPerfil.Name = "iconPerfil";
            this.iconPerfil.Size = new System.Drawing.Size(35, 42);
            this.iconPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPerfil.TabIndex = 55;
            this.iconPerfil.TabStop = false;
            this.iconPerfil.Click += new System.EventHandler(this.iconPerfil_Click);
            // 
            // labelVendas
            // 
            this.labelVendas.AutoSize = true;
            this.labelVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(240)))));
            this.labelVendas.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelVendas.Location = new System.Drawing.Point(157, 266);
            this.labelVendas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVendas.Name = "labelVendas";
            this.labelVendas.Size = new System.Drawing.Size(161, 31);
            this.labelVendas.TabIndex = 57;
            this.labelVendas.Text = "labelVendas";
            // 
            // labelVoltar
            // 
            this.labelVoltar.AutoSize = true;
            this.labelVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(240)))));
            this.labelVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVoltar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelVoltar.Location = new System.Drawing.Point(134, 246);
            this.labelVoltar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVoltar.Name = "labelVoltar";
            this.labelVoltar.Size = new System.Drawing.Size(56, 21);
            this.labelVoltar.TabIndex = 68;
            this.labelVoltar.Text = "Voltar";
            this.labelVoltar.Click += new System.EventHandler(this.labelVoltar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(110, 246);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(23, 24);
            this.btnVoltar.TabIndex = 67;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // gridProdutos
            // 
            this.gridProdutos.AllowUserToAddRows = false;
            this.gridProdutos.AllowUserToDeleteRows = false;
            this.gridProdutos.AllowUserToResizeColumns = false;
            this.gridProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProdutos.AutoGenerateColumns = false;
            this.gridProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(240)))));
            this.gridProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridProdutos.CausesValidation = false;
            this.gridProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridProdutos.ColumnHeadersHeight = 35;
            this.gridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDClienteDataGridViewTextBoxColumn,
            this.iDProdutoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.totalCompraDataGridViewTextBoxColumn,
            this.codigoCompraDataGridViewTextBoxColumn,
            this.metodoPagamentoDataGridViewTextBoxColumn});
            this.gridProdutos.DataSource = this.vendasBindingSource;
            this.gridProdutos.EnableHeadersVisualStyles = false;
            this.gridProdutos.Location = new System.Drawing.Point(119, 333);
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridProdutos.RowHeadersVisible = false;
            this.gridProdutos.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(64)))));
            this.gridProdutos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridProdutos.RowTemplate.Height = 24;
            this.gridProdutos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProdutos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridProdutos.Size = new System.Drawing.Size(1107, 255);
            this.gridProdutos.TabIndex = 69;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDClienteDataGridViewTextBoxColumn
            // 
            this.iDClienteDataGridViewTextBoxColumn.DataPropertyName = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.HeaderText = "ID Cliente";
            this.iDClienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDClienteDataGridViewTextBoxColumn.Name = "iDClienteDataGridViewTextBoxColumn";
            // 
            // iDProdutoDataGridViewTextBoxColumn
            // 
            this.iDProdutoDataGridViewTextBoxColumn.DataPropertyName = "ID_Produto";
            this.iDProdutoDataGridViewTextBoxColumn.HeaderText = "ID Produto";
            this.iDProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDProdutoDataGridViewTextBoxColumn.Name = "iDProdutoDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // totalCompraDataGridViewTextBoxColumn
            // 
            this.totalCompraDataGridViewTextBoxColumn.DataPropertyName = "TotalCompra";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.totalCompraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalCompraDataGridViewTextBoxColumn.HeaderText = "Total Compra";
            this.totalCompraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalCompraDataGridViewTextBoxColumn.Name = "totalCompraDataGridViewTextBoxColumn";
            // 
            // codigoCompraDataGridViewTextBoxColumn
            // 
            this.codigoCompraDataGridViewTextBoxColumn.DataPropertyName = "CodigoCompra";
            this.codigoCompraDataGridViewTextBoxColumn.HeaderText = "Cod. da Compra";
            this.codigoCompraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoCompraDataGridViewTextBoxColumn.Name = "codigoCompraDataGridViewTextBoxColumn";
            // 
            // metodoPagamentoDataGridViewTextBoxColumn
            // 
            this.metodoPagamentoDataGridViewTextBoxColumn.DataPropertyName = "MetodoPagamento";
            this.metodoPagamentoDataGridViewTextBoxColumn.HeaderText = "Met. de Pagamen.";
            this.metodoPagamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.metodoPagamentoDataGridViewTextBoxColumn.Name = "metodoPagamentoDataGridViewTextBoxColumn";
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "Vendas";
            this.vendasBindingSource.DataSource = this._databasefazenda_1DataSet;
            // 
            // _databasefazenda_1DataSet
            // 
            this._databasefazenda_1DataSet.DataSetName = "_databasefazenda_1DataSet";
            this._databasefazenda_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // btnExportarDados
            // 
            this.btnExportarDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportarDados.Image = global::over.Properties.Resources.Captura_de_tela_2024_11_02_194810;
            this.btnExportarDados.Location = new System.Drawing.Point(138, 179);
            this.btnExportarDados.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportarDados.Name = "btnExportarDados";
            this.btnExportarDados.Size = new System.Drawing.Size(296, 34);
            this.btnExportarDados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExportarDados.TabIndex = 70;
            this.btnExportarDados.TabStop = false;
            this.btnExportarDados.Click += new System.EventHandler(this.btnExportarDados_Click);
            // 
            // labelPesquisarPorCodigoDeCompra
            // 
            this.labelPesquisarPorCodigoDeCompra.AutoSize = true;
            this.labelPesquisarPorCodigoDeCompra.BackColor = System.Drawing.Color.Transparent;
            this.labelPesquisarPorCodigoDeCompra.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisarPorCodigoDeCompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPesquisarPorCodigoDeCompra.Location = new System.Drawing.Point(149, 132);
            this.labelPesquisarPorCodigoDeCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPesquisarPorCodigoDeCompra.Name = "labelPesquisarPorCodigoDeCompra";
            this.labelPesquisarPorCodigoDeCompra.Size = new System.Drawing.Size(260, 21);
            this.labelPesquisarPorCodigoDeCompra.TabIndex = 72;
            this.labelPesquisarPorCodigoDeCompra.Text = "Pesquisar por Código de Compra";
            // 
            // textBoxPesquisaPorCodigo
            // 
            this.textBoxPesquisaPorCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(160)))), ((int)(((byte)(109)))));
            this.textBoxPesquisaPorCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisaPorCodigo.ForeColor = System.Drawing.Color.White;
            this.textBoxPesquisaPorCodigo.Location = new System.Drawing.Point(138, 125);
            this.textBoxPesquisaPorCodigo.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPesquisaPorCodigo.Name = "textBoxPesquisaPorCodigo";
            this.textBoxPesquisaPorCodigo.Size = new System.Drawing.Size(420, 35);
            this.textBoxPesquisaPorCodigo.TabIndex = 71;
            this.textBoxPesquisaPorCodigo.TextChanged += new System.EventHandler(this.textBoxPesquisaProdutos_TextChanged);
            // 
            // textBoxPesquisaIDProduto
            // 
            this.textBoxPesquisaIDProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(160)))), ((int)(((byte)(109)))));
            this.textBoxPesquisaIDProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisaIDProduto.ForeColor = System.Drawing.Color.White;
            this.textBoxPesquisaIDProduto.Location = new System.Drawing.Point(574, 125);
            this.textBoxPesquisaIDProduto.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPesquisaIDProduto.Name = "textBoxPesquisaIDProduto";
            this.textBoxPesquisaIDProduto.Size = new System.Drawing.Size(198, 35);
            this.textBoxPesquisaIDProduto.TabIndex = 73;
            this.textBoxPesquisaIDProduto.TextChanged += new System.EventHandler(this.textBoxPesquisaIDProduto_TextChanged);
            // 
            // labelPesquisaPorIDProduto
            // 
            this.labelPesquisaPorIDProduto.AutoSize = true;
            this.labelPesquisaPorIDProduto.BackColor = System.Drawing.Color.Transparent;
            this.labelPesquisaPorIDProduto.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisaPorIDProduto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPesquisaPorIDProduto.Location = new System.Drawing.Point(580, 132);
            this.labelPesquisaPorIDProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPesquisaPorIDProduto.Name = "labelPesquisaPorIDProduto";
            this.labelPesquisaPorIDProduto.Size = new System.Drawing.Size(120, 21);
            this.labelPesquisaPorIDProduto.TabIndex = 74;
            this.labelPesquisaPorIDProduto.Text = "Por ID Produto";
            // 
            // labelPesquisaPorIDCliente
            // 
            this.labelPesquisaPorIDCliente.AutoSize = true;
            this.labelPesquisaPorIDCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelPesquisaPorIDCliente.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisaPorIDCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPesquisaPorIDCliente.Location = new System.Drawing.Point(794, 132);
            this.labelPesquisaPorIDCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPesquisaPorIDCliente.Name = "labelPesquisaPorIDCliente";
            this.labelPesquisaPorIDCliente.Size = new System.Drawing.Size(112, 21);
            this.labelPesquisaPorIDCliente.TabIndex = 76;
            this.labelPesquisaPorIDCliente.Text = "Por ID Cliente";
            // 
            // textBoxPesquisaIDCliente
            // 
            this.textBoxPesquisaIDCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(160)))), ((int)(((byte)(109)))));
            this.textBoxPesquisaIDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisaIDCliente.ForeColor = System.Drawing.Color.White;
            this.textBoxPesquisaIDCliente.Location = new System.Drawing.Point(788, 125);
            this.textBoxPesquisaIDCliente.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPesquisaIDCliente.Name = "textBoxPesquisaIDCliente";
            this.textBoxPesquisaIDCliente.Size = new System.Drawing.Size(187, 35);
            this.textBoxPesquisaIDCliente.TabIndex = 75;
            this.textBoxPesquisaIDCliente.TextChanged += new System.EventHandler(this.textBoxPesquisaIDCliente_TextChanged);
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::over.Properties.Resources.telaVendas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1305, 635);
            this.Controls.Add(this.labelPesquisaPorIDCliente);
            this.Controls.Add(this.textBoxPesquisaIDCliente);
            this.Controls.Add(this.labelPesquisaPorIDProduto);
            this.Controls.Add(this.textBoxPesquisaIDProduto);
            this.Controls.Add(this.labelPesquisarPorCodigoDeCompra);
            this.Controls.Add(this.textBoxPesquisaPorCodigo);
            this.Controls.Add(this.btnExportarDados);
            this.Controls.Add(this.gridProdutos);
            this.Controls.Add(this.labelVoltar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.labelVendas);
            this.Controls.Add(this.labelNomeUsuario);
            this.Controls.Add(this.iconPerfil);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._databasefazenda_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportarDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeUsuario;
        private System.Windows.Forms.PictureBox iconPerfil;
        private System.Windows.Forms.Label labelVendas;
        private System.Windows.Forms.Label labelVoltar;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.DataGridView gridProdutos;
        private _databasefazenda_1DataSet _databasefazenda_1DataSet;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private _databasefazenda_1DataSetTableAdapters.VendasTableAdapter vendasTableAdapter;
        private System.Windows.Forms.PictureBox btnExportarDados;
        private System.Windows.Forms.Label labelPesquisarPorCodigoDeCompra;
        private System.Windows.Forms.TextBox textBoxPesquisaPorCodigo;
        private System.Windows.Forms.TextBox textBoxPesquisaIDProduto;
        private System.Windows.Forms.Label labelPesquisaPorIDProduto;
        private System.Windows.Forms.Label labelPesquisaPorIDCliente;
        private System.Windows.Forms.TextBox textBoxPesquisaIDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodoPagamentoDataGridViewTextBoxColumn;
    }
}