namespace over.Views.ModuloControles.ModuloControleVendas
{
    partial class PedidoFinalizado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelNomeUsuario = new System.Windows.Forms.Label();
            this.iconPerfil = new System.Windows.Forms.PictureBox();
            this.dataGridViewPedido = new System.Windows.Forms.DataGridView();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelMetodoDePagamento = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.labelCodigoDeCompra = new System.Windows.Forms.Label();
            this.btnVoltarParaOInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomeUsuario
            // 
            this.labelNomeUsuario.AutoSize = true;
            this.labelNomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeUsuario.Location = new System.Drawing.Point(1215, 20);
            this.labelNomeUsuario.Name = "labelNomeUsuario";
            this.labelNomeUsuario.Size = new System.Drawing.Size(66, 24);
            this.labelNomeUsuario.TabIndex = 71;
            this.labelNomeUsuario.Text = "label2";
            this.labelNomeUsuario.Click += new System.EventHandler(this.labelNomeUsuario_Click);
            // 
            // iconPerfil
            // 
            this.iconPerfil.BackColor = System.Drawing.Color.Transparent;
            this.iconPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPerfil.Image = global::over.Properties.Resources.iconPerfil;
            this.iconPerfil.Location = new System.Drawing.Point(1173, 9);
            this.iconPerfil.Name = "iconPerfil";
            this.iconPerfil.Size = new System.Drawing.Size(35, 42);
            this.iconPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPerfil.TabIndex = 70;
            this.iconPerfil.TabStop = false;
            this.iconPerfil.Click += new System.EventHandler(this.iconPerfil_Click);
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
            this.dataGridViewPedido.Location = new System.Drawing.Point(261, 290);
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
            this.dataGridViewPedido.Size = new System.Drawing.Size(466, 207);
            this.dataGridViewPedido.TabIndex = 72;
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
            // labelMetodoDePagamento
            // 
            this.labelMetodoDePagamento.AutoSize = true;
            this.labelMetodoDePagamento.BackColor = System.Drawing.Color.Transparent;
            this.labelMetodoDePagamento.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetodoDePagamento.Location = new System.Drawing.Point(746, 299);
            this.labelMetodoDePagamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMetodoDePagamento.Name = "labelMetodoDePagamento";
            this.labelMetodoDePagamento.Size = new System.Drawing.Size(279, 31);
            this.labelMetodoDePagamento.TabIndex = 73;
            this.labelMetodoDePagamento.Text = "Método de Pagamento";
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelValorTotal.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotal.Location = new System.Drawing.Point(888, 374);
            this.labelValorTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(158, 32);
            this.labelValorTotal.TabIndex = 74;
            this.labelValorTotal.Text = "Total";
            this.labelValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCodigoDeCompra
            // 
            this.labelCodigoDeCompra.BackColor = System.Drawing.Color.Transparent;
            this.labelCodigoDeCompra.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoDeCompra.Location = new System.Drawing.Point(844, 450);
            this.labelCodigoDeCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodigoDeCompra.Name = "labelCodigoDeCompra";
            this.labelCodigoDeCompra.Size = new System.Drawing.Size(203, 32);
            this.labelCodigoDeCompra.TabIndex = 75;
            this.labelCodigoDeCompra.Text = "Código";
            this.labelCodigoDeCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoltarParaOInicio
            // 
            this.btnVoltarParaOInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(160)))), ((int)(((byte)(109)))));
            this.btnVoltarParaOInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVoltarParaOInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltarParaOInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(160)))), ((int)(((byte)(109)))));
            this.btnVoltarParaOInicio.FlatAppearance.BorderSize = 0;
            this.btnVoltarParaOInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(160)))), ((int)(((byte)(109)))));
            this.btnVoltarParaOInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(160)))), ((int)(((byte)(109)))));
            this.btnVoltarParaOInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarParaOInicio.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarParaOInicio.ForeColor = System.Drawing.Color.White;
            this.btnVoltarParaOInicio.Location = new System.Drawing.Point(820, 532);
            this.btnVoltarParaOInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltarParaOInicio.Name = "btnVoltarParaOInicio";
            this.btnVoltarParaOInicio.Size = new System.Drawing.Size(266, 32);
            this.btnVoltarParaOInicio.TabIndex = 76;
            this.btnVoltarParaOInicio.Text = "Voltar para o início";
            this.btnVoltarParaOInicio.UseVisualStyleBackColor = false;
            this.btnVoltarParaOInicio.Click += new System.EventHandler(this.btnVoltarParaOInicio_Click);
            // 
            // PedidoFinalizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::over.Properties.Resources.telaPedidoFinalizado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1305, 635);
            this.Controls.Add(this.btnVoltarParaOInicio);
            this.Controls.Add(this.labelCodigoDeCompra);
            this.Controls.Add(this.labelValorTotal);
            this.Controls.Add(this.labelMetodoDePagamento);
            this.Controls.Add(this.dataGridViewPedido);
            this.Controls.Add(this.labelNomeUsuario);
            this.Controls.Add(this.iconPerfil);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PedidoFinalizado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PedidoFinalizado";
            ((System.ComponentModel.ISupportInitialize)(this.iconPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeUsuario;
        private System.Windows.Forms.PictureBox iconPerfil;
        private System.Windows.Forms.DataGridView dataGridViewPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCompra;
        private System.Windows.Forms.Label labelMetodoDePagamento;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.Label labelCodigoDeCompra;
        private System.Windows.Forms.Button btnVoltarParaOInicio;
    }
}