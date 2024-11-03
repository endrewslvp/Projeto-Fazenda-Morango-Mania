namespace over.Views.ModuloControles.ModuloControleVendas.ModuloClientes
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExportarDados = new System.Windows.Forms.PictureBox();
            this.labelVoltar = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.labelClientes = new System.Windows.Forms.Label();
            this.labelNomeUsuario = new System.Windows.Forms.Label();
            this.iconPerfil = new System.Windows.Forms.PictureBox();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._databasefazenda_1DataSet = new over._databasefazenda_1DataSet();
            this.clientesTableAdapter = new over._databasefazenda_1DataSetTableAdapters.ClientesTableAdapter();
            this.labelPesquisarPorNome = new System.Windows.Forms.Label();
            this.textBoxPesquisaPorNome = new System.Windows.Forms.TextBox();
            this.labelPesquisarPorCNPJ = new System.Windows.Forms.Label();
            this.textBoxPesquisaPorCNPJ = new System.Windows.Forms.TextBox();
            this.labelPesquisarPorCEP = new System.Windows.Forms.Label();
            this.textBoxPesquisaPorCEP = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.PictureBox();
            this.btnCadastrarCliente = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportarDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._databasefazenda_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportarDados
            // 
            this.btnExportarDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportarDados.Image = global::over.Properties.Resources.Captura_de_tela_2024_11_02_194810;
            this.btnExportarDados.Location = new System.Drawing.Point(138, 179);
            this.btnExportarDados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExportarDados.Name = "btnExportarDados";
            this.btnExportarDados.Size = new System.Drawing.Size(296, 34);
            this.btnExportarDados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExportarDados.TabIndex = 71;
            this.btnExportarDados.TabStop = false;
            this.btnExportarDados.Click += new System.EventHandler(this.btnExportarDados_Click);
            // 
            // labelVoltar
            // 
            this.labelVoltar.AutoSize = true;
            this.labelVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(240)))));
            this.labelVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVoltar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelVoltar.Location = new System.Drawing.Point(135, 246);
            this.labelVoltar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVoltar.Name = "labelVoltar";
            this.labelVoltar.Size = new System.Drawing.Size(56, 21);
            this.labelVoltar.TabIndex = 74;
            this.labelVoltar.Text = "Voltar";
            this.labelVoltar.Click += new System.EventHandler(this.labelVoltar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(111, 246);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(23, 24);
            this.btnVoltar.TabIndex = 73;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // labelClientes
            // 
            this.labelClientes.AutoSize = true;
            this.labelClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(240)))));
            this.labelClientes.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelClientes.Location = new System.Drawing.Point(158, 266);
            this.labelClientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(168, 31);
            this.labelClientes.TabIndex = 72;
            this.labelClientes.Text = "labelClientes";
            // 
            // labelNomeUsuario
            // 
            this.labelNomeUsuario.AutoSize = true;
            this.labelNomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeUsuario.Location = new System.Drawing.Point(1215, 22);
            this.labelNomeUsuario.Name = "labelNomeUsuario";
            this.labelNomeUsuario.Size = new System.Drawing.Size(66, 24);
            this.labelNomeUsuario.TabIndex = 76;
            this.labelNomeUsuario.Text = "label2";
            this.labelNomeUsuario.Click += new System.EventHandler(this.labelNomeUsuario_Click);
            // 
            // iconPerfil
            // 
            this.iconPerfil.BackColor = System.Drawing.Color.Transparent;
            this.iconPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPerfil.Image = global::over.Properties.Resources.iconPerfil;
            this.iconPerfil.Location = new System.Drawing.Point(1174, 11);
            this.iconPerfil.Name = "iconPerfil";
            this.iconPerfil.Size = new System.Drawing.Size(35, 42);
            this.iconPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPerfil.TabIndex = 75;
            this.iconPerfil.TabStop = false;
            this.iconPerfil.Click += new System.EventHandler(this.iconPerfil_Click);
            // 
            // gridClientes
            // 
            this.gridClientes.AllowUserToAddRows = false;
            this.gridClientes.AllowUserToDeleteRows = false;
            this.gridClientes.AllowUserToResizeColumns = false;
            this.gridClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridClientes.AutoGenerateColumns = false;
            this.gridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(240)))));
            this.gridClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridClientes.CausesValidation = false;
            this.gridClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridClientes.ColumnHeadersHeight = 35;
            this.gridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cNPJDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn,
            this.ruaDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.complementoDataGridViewTextBoxColumn});
            this.gridClientes.DataSource = this.clientesBindingSource;
            this.gridClientes.EnableHeadersVisualStyles = false;
            this.gridClientes.Location = new System.Drawing.Point(117, 337);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridClientes.RowHeadersVisible = false;
            this.gridClientes.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(64)))));
            this.gridClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridClientes.RowTemplate.Height = 24;
            this.gridClientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridClientes.Size = new System.Drawing.Size(1113, 255);
            this.gridClientes.TabIndex = 77;
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
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // cNPJDataGridViewTextBoxColumn
            // 
            this.cNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cNPJDataGridViewTextBoxColumn.Name = "cNPJDataGridViewTextBoxColumn";
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            // 
            // ruaDataGridViewTextBoxColumn
            // 
            this.ruaDataGridViewTextBoxColumn.DataPropertyName = "Rua";
            this.ruaDataGridViewTextBoxColumn.HeaderText = "Rua";
            this.ruaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ruaDataGridViewTextBoxColumn.Name = "ruaDataGridViewTextBoxColumn";
            this.ruaDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.Visible = false;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.Visible = false;
            // 
            // complementoDataGridViewTextBoxColumn
            // 
            this.complementoDataGridViewTextBoxColumn.DataPropertyName = "Complemento";
            this.complementoDataGridViewTextBoxColumn.HeaderText = "Complem.";
            this.complementoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.complementoDataGridViewTextBoxColumn.Name = "complementoDataGridViewTextBoxColumn";
            this.complementoDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this._databasefazenda_1DataSet;
            // 
            // _databasefazenda_1DataSet
            // 
            this._databasefazenda_1DataSet.DataSetName = "_databasefazenda_1DataSet";
            this._databasefazenda_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // labelPesquisarPorNome
            // 
            this.labelPesquisarPorNome.AutoSize = true;
            this.labelPesquisarPorNome.BackColor = System.Drawing.Color.Transparent;
            this.labelPesquisarPorNome.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisarPorNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPesquisarPorNome.Location = new System.Drawing.Point(149, 136);
            this.labelPesquisarPorNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPesquisarPorNome.Name = "labelPesquisarPorNome";
            this.labelPesquisarPorNome.Size = new System.Drawing.Size(161, 21);
            this.labelPesquisarPorNome.TabIndex = 79;
            this.labelPesquisarPorNome.Text = "Pesquisar por Nome";
            // 
            // textBoxPesquisaPorNome
            // 
            this.textBoxPesquisaPorNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(160)))), ((int)(((byte)(109)))));
            this.textBoxPesquisaPorNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisaPorNome.ForeColor = System.Drawing.Color.White;
            this.textBoxPesquisaPorNome.Location = new System.Drawing.Point(138, 128);
            this.textBoxPesquisaPorNome.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPesquisaPorNome.Name = "textBoxPesquisaPorNome";
            this.textBoxPesquisaPorNome.Size = new System.Drawing.Size(420, 35);
            this.textBoxPesquisaPorNome.TabIndex = 78;
            this.textBoxPesquisaPorNome.TextChanged += new System.EventHandler(this.textBoxPesquisaPorNome_TextChanged);
            // 
            // labelPesquisarPorCNPJ
            // 
            this.labelPesquisarPorCNPJ.AutoSize = true;
            this.labelPesquisarPorCNPJ.BackColor = System.Drawing.Color.Transparent;
            this.labelPesquisarPorCNPJ.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisarPorCNPJ.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPesquisarPorCNPJ.Location = new System.Drawing.Point(581, 136);
            this.labelPesquisarPorCNPJ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPesquisarPorCNPJ.Name = "labelPesquisarPorCNPJ";
            this.labelPesquisarPorCNPJ.Size = new System.Drawing.Size(154, 21);
            this.labelPesquisarPorCNPJ.TabIndex = 81;
            this.labelPesquisarPorCNPJ.Text = "Pesquisar por CNPJ";
            // 
            // textBoxPesquisaPorCNPJ
            // 
            this.textBoxPesquisaPorCNPJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(160)))), ((int)(((byte)(109)))));
            this.textBoxPesquisaPorCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisaPorCNPJ.ForeColor = System.Drawing.Color.White;
            this.textBoxPesquisaPorCNPJ.Location = new System.Drawing.Point(570, 128);
            this.textBoxPesquisaPorCNPJ.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPesquisaPorCNPJ.Name = "textBoxPesquisaPorCNPJ";
            this.textBoxPesquisaPorCNPJ.Size = new System.Drawing.Size(254, 35);
            this.textBoxPesquisaPorCNPJ.TabIndex = 80;
            this.textBoxPesquisaPorCNPJ.TextChanged += new System.EventHandler(this.textBoxPesquisaPorCNPJ_TextChanged);
            // 
            // labelPesquisarPorCEP
            // 
            this.labelPesquisarPorCEP.AutoSize = true;
            this.labelPesquisarPorCEP.BackColor = System.Drawing.Color.Transparent;
            this.labelPesquisarPorCEP.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisarPorCEP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPesquisarPorCEP.Location = new System.Drawing.Point(854, 136);
            this.labelPesquisarPorCEP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPesquisarPorCEP.Name = "labelPesquisarPorCEP";
            this.labelPesquisarPorCEP.Size = new System.Drawing.Size(145, 21);
            this.labelPesquisarPorCEP.TabIndex = 83;
            this.labelPesquisarPorCEP.Text = "Pesquisar por CEP";
            // 
            // textBoxPesquisaPorCEP
            // 
            this.textBoxPesquisaPorCEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(160)))), ((int)(((byte)(109)))));
            this.textBoxPesquisaPorCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisaPorCEP.ForeColor = System.Drawing.Color.White;
            this.textBoxPesquisaPorCEP.Location = new System.Drawing.Point(842, 128);
            this.textBoxPesquisaPorCEP.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPesquisaPorCEP.Name = "textBoxPesquisaPorCEP";
            this.textBoxPesquisaPorCEP.Size = new System.Drawing.Size(254, 35);
            this.textBoxPesquisaPorCEP.TabIndex = 82;
            this.textBoxPesquisaPorCEP.TextChanged += new System.EventHandler(this.textBoxPesquisaPorCEP_TextChanged);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(822, 258);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(176, 41);
            this.btnAtualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAtualizar.TabIndex = 84;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarCliente.Image = global::over.Properties.Resources.btnCadastrarCliente;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(1002, 258);
            this.btnCadastrarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(213, 41);
            this.btnCadastrarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCadastrarCliente.TabIndex = 85;
            this.btnCadastrarCliente.TabStop = false;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::over.Properties.Resources.telaVendas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1305, 635);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.labelPesquisarPorCEP);
            this.Controls.Add(this.textBoxPesquisaPorCEP);
            this.Controls.Add(this.labelPesquisarPorCNPJ);
            this.Controls.Add(this.textBoxPesquisaPorCNPJ);
            this.Controls.Add(this.labelPesquisarPorNome);
            this.Controls.Add(this.textBoxPesquisaPorNome);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.labelNomeUsuario);
            this.Controls.Add(this.iconPerfil);
            this.Controls.Add(this.labelVoltar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.labelClientes);
            this.Controls.Add(this.btnExportarDados);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExportarDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._databasefazenda_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnExportarDados;
        private System.Windows.Forms.Label labelVoltar;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.Label labelClientes;
        private System.Windows.Forms.Label labelNomeUsuario;
        private System.Windows.Forms.PictureBox iconPerfil;
        private System.Windows.Forms.DataGridView gridClientes;
        private _databasefazenda_1DataSet _databasefazenda_1DataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private _databasefazenda_1DataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.Label labelPesquisarPorNome;
        private System.Windows.Forms.TextBox textBoxPesquisaPorNome;
        private System.Windows.Forms.Label labelPesquisarPorCNPJ;
        private System.Windows.Forms.TextBox textBoxPesquisaPorCNPJ;
        private System.Windows.Forms.Label labelPesquisarPorCEP;
        private System.Windows.Forms.TextBox textBoxPesquisaPorCEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox btnAtualizar;
        private System.Windows.Forms.PictureBox btnCadastrarCliente;
    }
}