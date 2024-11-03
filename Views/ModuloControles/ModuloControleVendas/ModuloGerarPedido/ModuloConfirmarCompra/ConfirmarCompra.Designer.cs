namespace over {
    partial class ConfirmarCompra {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmarCompra));
            this.comboBoxMetodosDePagamento = new System.Windows.Forms.ComboBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.dataGridViewPedido = new System.Windows.Forms.DataGridView();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.voltarProdutos = new System.Windows.Forms.PictureBox();
            this.labelNomeUsuario = new System.Windows.Forms.Label();
            this.iconPerfil = new System.Windows.Forms.PictureBox();
            this.btnIrParaPagamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltarProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMetodosDePagamento
            // 
            this.comboBoxMetodosDePagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(240)))));
            this.comboBoxMetodosDePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.comboBoxMetodosDePagamento.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxMetodosDePagamento.FormattingEnabled = true;
            this.comboBoxMetodosDePagamento.Items.AddRange(new object[] {
            "PIX",
            "Cartão"});
            this.comboBoxMetodosDePagamento.Location = new System.Drawing.Point(754, 431);
            this.comboBoxMetodosDePagamento.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMetodosDePagamento.Name = "comboBoxMetodosDePagamento";
            this.comboBoxMetodosDePagamento.Size = new System.Drawing.Size(205, 44);
            this.comboBoxMetodosDePagamento.TabIndex = 65;
            this.comboBoxMetodosDePagamento.SelectedIndexChanged += new System.EventHandler(this.comboBoxMetodosDePagamento_SelectedIndexChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Gray;
            this.labelTotal.Location = new System.Drawing.Point(1019, 438);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(120, 29);
            this.labelTotal.TabIndex = 66;
            this.labelTotal.Text = "total";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewPedido
            // 
            this.dataGridViewPedido.AllowUserToAddRows = false;
            this.dataGridViewPedido.AllowUserToDeleteRows = false;
            this.dataGridViewPedido.AllowUserToResizeColumns = false;
            this.dataGridViewPedido.AllowUserToResizeRows = false;
            this.dataGridViewPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewPedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(240)))));
            this.dataGridViewPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPedido.ColumnHeadersHeight = 35;
            this.dataGridViewPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.Produtos,
            this.Quantidade,
            this.PrecoUnit,
            this.TotalCompra});
            this.dataGridViewPedido.EnableHeadersVisualStyles = false;
            this.dataGridViewPedido.Location = new System.Drawing.Point(633, 268);
            this.dataGridViewPedido.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPedido.Name = "dataGridViewPedido";
            this.dataGridViewPedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewPedido.RowHeadersVisible = false;
            this.dataGridViewPedido.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(64)))));
            this.dataGridViewPedido.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPedido.RowTemplate.Height = 24;
            this.dataGridViewPedido.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPedido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewPedido.Size = new System.Drawing.Size(496, 145);
            this.dataGridViewPedido.TabIndex = 67;
            // 
            // IdProduto
            // 
            this.IdProduto.HeaderText = "IdProduto";
            this.IdProduto.MinimumWidth = 6;
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.Visible = false;
            // 
            // Produtos
            // 
            this.Produtos.HeaderText = "Produtos";
            this.Produtos.MinimumWidth = 6;
            this.Produtos.Name = "Produtos";
            this.Produtos.ReadOnly = true;
            this.Produtos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Quantidade
            // 
            dataGridViewCellStyle2.NullValue = null;
            this.Quantidade.DefaultCellStyle = dataGridViewCellStyle2;
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.MinimumWidth = 6;
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PrecoUnit
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.PrecoUnit.DefaultCellStyle = dataGridViewCellStyle3;
            this.PrecoUnit.HeaderText = "Preço Unit.";
            this.PrecoUnit.MinimumWidth = 6;
            this.PrecoUnit.Name = "PrecoUnit";
            this.PrecoUnit.ReadOnly = true;
            // 
            // TotalCompra
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.TotalCompra.DefaultCellStyle = dataGridViewCellStyle4;
            this.TotalCompra.HeaderText = "Total";
            this.TotalCompra.MinimumWidth = 6;
            this.TotalCompra.Name = "TotalCompra";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(762, 518);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(142, 32);
            this.buttonCancelar.TabIndex = 68;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // voltarProdutos
            // 
            this.voltarProdutos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltarProdutos.BackgroundImage")));
            this.voltarProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltarProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltarProdutos.Location = new System.Drawing.Point(584, 161);
            this.voltarProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.voltarProdutos.Name = "voltarProdutos";
            this.voltarProdutos.Size = new System.Drawing.Size(42, 41);
            this.voltarProdutos.TabIndex = 69;
            this.voltarProdutos.TabStop = false;
            this.voltarProdutos.Click += new System.EventHandler(this.voltarProdutos_Click);
            // 
            // labelNomeUsuario
            // 
            this.labelNomeUsuario.AutoSize = true;
            this.labelNomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeUsuario.Location = new System.Drawing.Point(1216, 22);
            this.labelNomeUsuario.Name = "labelNomeUsuario";
            this.labelNomeUsuario.Size = new System.Drawing.Size(66, 24);
            this.labelNomeUsuario.TabIndex = 71;
            this.labelNomeUsuario.Text = "label2";
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
            this.iconPerfil.TabIndex = 70;
            this.iconPerfil.TabStop = false;
            // 
            // btnIrParaPagamento
            // 
            this.btnIrParaPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(160)))), ((int)(((byte)(109)))));
            this.btnIrParaPagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIrParaPagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIrParaPagamento.Enabled = false;
            this.btnIrParaPagamento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(160)))), ((int)(((byte)(109)))));
            this.btnIrParaPagamento.FlatAppearance.BorderSize = 0;
            this.btnIrParaPagamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(160)))), ((int)(((byte)(109)))));
            this.btnIrParaPagamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(160)))), ((int)(((byte)(109)))));
            this.btnIrParaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrParaPagamento.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrParaPagamento.ForeColor = System.Drawing.Color.White;
            this.btnIrParaPagamento.Location = new System.Drawing.Point(950, 518);
            this.btnIrParaPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnIrParaPagamento.Name = "btnIrParaPagamento";
            this.btnIrParaPagamento.Size = new System.Drawing.Size(167, 32);
            this.btnIrParaPagamento.TabIndex = 72;
            this.btnIrParaPagamento.Text = "Confirmar 🔒";
            this.btnIrParaPagamento.UseVisualStyleBackColor = false;
            this.btnIrParaPagamento.Click += new System.EventHandler(this.btnIrParaPagamento_Click);
            // 
            // ConfirmarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::over.Properties.Resources.telaConfirmarCompra;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1305, 635);
            this.Controls.Add(this.btnIrParaPagamento);
            this.Controls.Add(this.labelNomeUsuario);
            this.Controls.Add(this.iconPerfil);
            this.Controls.Add(this.voltarProdutos);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dataGridViewPedido);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.comboBoxMetodosDePagamento);
            this.Name = "ConfirmarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmarCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltarProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxMetodosDePagamento;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridView dataGridViewPedido;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.PictureBox voltarProdutos;
        private System.Windows.Forms.Label labelNomeUsuario;
        private System.Windows.Forms.PictureBox iconPerfil;
        private System.Windows.Forms.Button btnIrParaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCompra;
    }
}