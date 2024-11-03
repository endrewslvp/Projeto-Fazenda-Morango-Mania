namespace over {
    partial class GerarPedido {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerarPedido));
            this.maskedCNPJVenda = new System.Windows.Forms.MaskedTextBox();
            this.checkedListBoxProdutos = new System.Windows.Forms.CheckedListBox();
            this.voltarProdutos = new System.Windows.Forms.PictureBox();
            this.btnIrParaPagamento = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelNomeUsuario = new System.Windows.Forms.Label();
            this.iconPerfil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.voltarProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedCNPJVenda
            // 
            this.maskedCNPJVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(240)))));
            this.maskedCNPJVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.maskedCNPJVenda.ForeColor = System.Drawing.Color.Gray;
            this.maskedCNPJVenda.Location = new System.Drawing.Point(626, 265);
            this.maskedCNPJVenda.Mask = "00,000,000/0000-00";
            this.maskedCNPJVenda.Name = "maskedCNPJVenda";
            this.maskedCNPJVenda.Size = new System.Drawing.Size(489, 41);
            this.maskedCNPJVenda.TabIndex = 49;
            // 
            // checkedListBoxProdutos
            // 
            this.checkedListBoxProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(240)))));
            this.checkedListBoxProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxProdutos.CheckOnClick = true;
            this.checkedListBoxProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListBoxProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxProdutos.ForeColor = System.Drawing.Color.Gray;
            this.checkedListBoxProdutos.FormattingEnabled = true;
            this.checkedListBoxProdutos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkedListBoxProdutos.Location = new System.Drawing.Point(626, 360);
            this.checkedListBoxProdutos.Margin = new System.Windows.Forms.Padding(0);
            this.checkedListBoxProdutos.Name = "checkedListBoxProdutos";
            this.checkedListBoxProdutos.Size = new System.Drawing.Size(488, 138);
            this.checkedListBoxProdutos.TabIndex = 58;
            this.checkedListBoxProdutos.UseTabStops = false;
            this.checkedListBoxProdutos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxProdutos_ItemCheck);
            // 
            // voltarProdutos
            // 
            this.voltarProdutos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltarProdutos.BackgroundImage")));
            this.voltarProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltarProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltarProdutos.Location = new System.Drawing.Point(581, 161);
            this.voltarProdutos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.voltarProdutos.Name = "voltarProdutos";
            this.voltarProdutos.Size = new System.Drawing.Size(42, 41);
            this.voltarProdutos.TabIndex = 61;
            this.voltarProdutos.TabStop = false;
            this.voltarProdutos.Click += new System.EventHandler(this.voltarProdutos_Click);
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
            this.btnIrParaPagamento.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrParaPagamento.ForeColor = System.Drawing.Color.White;
            this.btnIrParaPagamento.Location = new System.Drawing.Point(946, 518);
            this.btnIrParaPagamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIrParaPagamento.Name = "btnIrParaPagamento";
            this.btnIrParaPagamento.Size = new System.Drawing.Size(180, 32);
            this.btnIrParaPagamento.TabIndex = 62;
            this.btnIrParaPagamento.Text = "Ir para Pagamento 🔒";
            this.btnIrParaPagamento.UseVisualStyleBackColor = false;
            this.btnIrParaPagamento.Click += new System.EventHandler(this.btnIrParaPagamento_Click);
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
            this.buttonCancelar.Location = new System.Drawing.Point(766, 517);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(140, 32);
            this.buttonCancelar.TabIndex = 63;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelNomeUsuario
            // 
            this.labelNomeUsuario.AutoSize = true;
            this.labelNomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeUsuario.Location = new System.Drawing.Point(1209, 21);
            this.labelNomeUsuario.Name = "labelNomeUsuario";
            this.labelNomeUsuario.Size = new System.Drawing.Size(66, 24);
            this.labelNomeUsuario.TabIndex = 69;
            this.labelNomeUsuario.Text = "label2";
            this.labelNomeUsuario.Click += new System.EventHandler(this.labelNomeUsuario_Click);
            // 
            // iconPerfil
            // 
            this.iconPerfil.BackColor = System.Drawing.Color.Transparent;
            this.iconPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPerfil.Image = global::over.Properties.Resources.iconPerfil;
            this.iconPerfil.Location = new System.Drawing.Point(1168, 10);
            this.iconPerfil.Name = "iconPerfil";
            this.iconPerfil.Size = new System.Drawing.Size(35, 42);
            this.iconPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPerfil.TabIndex = 68;
            this.iconPerfil.TabStop = false;
            this.iconPerfil.Click += new System.EventHandler(this.iconPerfil_Click);
            // 
            // GerarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::over.Properties.Resources.telaGerarPedidos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1305, 635);
            this.Controls.Add(this.labelNomeUsuario);
            this.Controls.Add(this.iconPerfil);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.btnIrParaPagamento);
            this.Controls.Add(this.voltarProdutos);
            this.Controls.Add(this.checkedListBoxProdutos);
            this.Controls.Add(this.maskedCNPJVenda);
            this.Name = "GerarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerarPedido";
            ((System.ComponentModel.ISupportInitialize)(this.voltarProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedCNPJVenda;
        private System.Windows.Forms.CheckedListBox checkedListBoxProdutos;
        private System.Windows.Forms.PictureBox voltarProdutos;
        private System.Windows.Forms.Button btnIrParaPagamento;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelNomeUsuario;
        private System.Windows.Forms.PictureBox iconPerfil;
    }
}