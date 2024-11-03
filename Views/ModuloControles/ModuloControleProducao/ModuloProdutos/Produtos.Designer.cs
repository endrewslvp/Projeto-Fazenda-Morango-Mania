namespace over
{
    partial class Produtos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databasefazenda1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._databasefazenda_1DataSet = new over._databasefazenda_1DataSet();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelProdutos = new System.Windows.Forms.Label();
            this.textBoxPesquisaProdutos = new System.Windows.Forms.TextBox();
            this.labelPesquisarProduto = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.PictureBox();
            this.btnCadastrarProduto = new System.Windows.Forms.PictureBox();
            this.btnExportarDados = new System.Windows.Forms.PictureBox();
            this.produtosTableAdapter1 = new over._databasefazenda_1DataSetTableAdapters.ProdutosTableAdapter();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.labelNomeUsuario = new System.Windows.Forms.Label();
            this.iconPerfil = new System.Windows.Forms.PictureBox();
            this.labelVoltar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasefazenda1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._databasefazenda_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrarProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportarDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPerfil)).BeginInit();
            this.SuspendLayout();
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
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.qtdProdutoDataGridViewTextBoxColumn,
            this.validadeDataGridViewTextBoxColumn});
            this.gridProdutos.DataSource = this.produtosBindingSource1;
            this.gridProdutos.EnableHeadersVisualStyles = false;
            this.gridProdutos.Location = new System.Drawing.Point(130, 334);
            this.gridProdutos.Margin = new System.Windows.Forms.Padding(0);
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
            this.gridProdutos.Size = new System.Drawing.Size(1052, 255);
            this.gridProdutos.TabIndex = 0;
            this.gridProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutos_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.precoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            this.precoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // qtdProdutoDataGridViewTextBoxColumn
            // 
            this.qtdProdutoDataGridViewTextBoxColumn.DataPropertyName = "QtdProduto";
            this.qtdProdutoDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.qtdProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtdProdutoDataGridViewTextBoxColumn.Name = "qtdProdutoDataGridViewTextBoxColumn";
            // 
            // validadeDataGridViewTextBoxColumn
            // 
            this.validadeDataGridViewTextBoxColumn.DataPropertyName = "Validade";
            this.validadeDataGridViewTextBoxColumn.HeaderText = "Validade";
            this.validadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.validadeDataGridViewTextBoxColumn.Name = "validadeDataGridViewTextBoxColumn";
            // 
            // produtosBindingSource1
            // 
            this.produtosBindingSource1.DataMember = "Produtos";
            this.produtosBindingSource1.DataSource = this.databasefazenda1DataSetBindingSource;
            // 
            // databasefazenda1DataSetBindingSource
            // 
            this.databasefazenda1DataSetBindingSource.DataSource = this._databasefazenda_1DataSet;
            this.databasefazenda1DataSetBindingSource.Position = 0;
            // 
            // _databasefazenda_1DataSet
            // 
            this._databasefazenda_1DataSet.DataSetName = "_databasefazenda_1DataSet";
            this._databasefazenda_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            // 
            // labelProdutos
            // 
            this.labelProdutos.AutoSize = true;
            this.labelProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(240)))));
            this.labelProdutos.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelProdutos.Location = new System.Drawing.Point(146, 270);
            this.labelProdutos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProdutos.Name = "labelProdutos";
            this.labelProdutos.Size = new System.Drawing.Size(184, 31);
            this.labelProdutos.TabIndex = 1;
            this.labelProdutos.Text = "labelProdutos";
            // 
            // textBoxPesquisaProdutos
            // 
            this.textBoxPesquisaProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(214)))), ((int)(((byte)(140)))));
            this.textBoxPesquisaProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisaProdutos.ForeColor = System.Drawing.Color.White;
            this.textBoxPesquisaProdutos.Location = new System.Drawing.Point(152, 141);
            this.textBoxPesquisaProdutos.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPesquisaProdutos.Name = "textBoxPesquisaProdutos";
            this.textBoxPesquisaProdutos.Size = new System.Drawing.Size(420, 35);
            this.textBoxPesquisaProdutos.TabIndex = 2;
            this.textBoxPesquisaProdutos.TextChanged += new System.EventHandler(this.textBoxPesquisaProdutos_TextChanged);
            // 
            // labelPesquisarProduto
            // 
            this.labelPesquisarProduto.AutoSize = true;
            this.labelPesquisarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(214)))), ((int)(((byte)(140)))));
            this.labelPesquisarProduto.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisarProduto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPesquisarProduto.Location = new System.Drawing.Point(163, 149);
            this.labelPesquisarProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPesquisarProduto.Name = "labelPesquisarProduto";
            this.labelPesquisarProduto.Size = new System.Drawing.Size(144, 21);
            this.labelPesquisarProduto.TabIndex = 3;
            this.labelPesquisarProduto.Text = "Pesquisar Produto";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(719, 263);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(176, 41);
            this.btnAtualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarProduto.Image = global::over.Properties.Resources.btnCadastrarProduto__2_;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(899, 263);
            this.btnCadastrarProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(272, 41);
            this.btnCadastrarProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCadastrarProduto.TabIndex = 6;
            this.btnCadastrarProduto.TabStop = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // btnExportarDados
            // 
            this.btnExportarDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportarDados.Image = global::over.Properties.Resources.btnExportarDados;
            this.btnExportarDados.Location = new System.Drawing.Point(152, 184);
            this.btnExportarDados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExportarDados.Name = "btnExportarDados";
            this.btnExportarDados.Size = new System.Drawing.Size(273, 32);
            this.btnExportarDados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExportarDados.TabIndex = 8;
            this.btnExportarDados.TabStop = false;
            this.btnExportarDados.Click += new System.EventHandler(this.btnExportarDados_Click);
            // 
            // produtosTableAdapter1
            // 
            this.produtosTableAdapter1.ClearBeforeFill = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(130, 249);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(23, 24);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // labelNomeUsuario
            // 
            this.labelNomeUsuario.AutoSize = true;
            this.labelNomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeUsuario.Location = new System.Drawing.Point(1185, 24);
            this.labelNomeUsuario.Name = "labelNomeUsuario";
            this.labelNomeUsuario.Size = new System.Drawing.Size(66, 24);
            this.labelNomeUsuario.TabIndex = 65;
            this.labelNomeUsuario.Text = "label2";
            this.labelNomeUsuario.Click += new System.EventHandler(this.labelNomeUsuario_Click);
            // 
            // iconPerfil
            // 
            this.iconPerfil.BackColor = System.Drawing.Color.Transparent;
            this.iconPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPerfil.Image = global::over.Properties.Resources.iconPerfil;
            this.iconPerfil.Location = new System.Drawing.Point(1144, 13);
            this.iconPerfil.Name = "iconPerfil";
            this.iconPerfil.Size = new System.Drawing.Size(35, 42);
            this.iconPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPerfil.TabIndex = 64;
            this.iconPerfil.TabStop = false;
            this.iconPerfil.Click += new System.EventHandler(this.iconPerfil_Click);
            // 
            // labelVoltar
            // 
            this.labelVoltar.AutoSize = true;
            this.labelVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(240)))));
            this.labelVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVoltar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelVoltar.Location = new System.Drawing.Point(152, 250);
            this.labelVoltar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVoltar.Name = "labelVoltar";
            this.labelVoltar.Size = new System.Drawing.Size(56, 21);
            this.labelVoltar.TabIndex = 66;
            this.labelVoltar.Text = "Voltar";
            this.labelVoltar.Click += new System.EventHandler(this.labelVoltar_Click);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1305, 635);
            this.Controls.Add(this.labelVoltar);
            this.Controls.Add(this.labelNomeUsuario);
            this.Controls.Add(this.iconPerfil);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExportarDados);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.labelPesquisarProduto);
            this.Controls.Add(this.textBoxPesquisaProdutos);
            this.Controls.Add(this.labelProdutos);
            this.Controls.Add(this.gridProdutos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasefazenda1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._databasefazenda_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrarProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportarDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProdutos;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private System.Windows.Forms.Label labelProdutos;
        private System.Windows.Forms.TextBox textBoxPesquisaProdutos;
        private System.Windows.Forms.Label labelPesquisarProduto;
        private System.Windows.Forms.PictureBox btnAtualizar;
        private System.Windows.Forms.PictureBox btnCadastrarProduto;
        private System.Windows.Forms.PictureBox btnExportarDados;
        private System.Windows.Forms.BindingSource databasefazenda1DataSetBindingSource;
        private _databasefazenda_1DataSet _databasefazenda_1DataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource1;
        private _databasefazenda_1DataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter1;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.Label labelNomeUsuario;
        private System.Windows.Forms.PictureBox iconPerfil;
        private System.Windows.Forms.Label labelVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validadeDataGridViewTextBoxColumn;
    }
}