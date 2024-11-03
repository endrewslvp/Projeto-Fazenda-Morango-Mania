namespace over.Views.ModuloControles.ModuloControleVendas.ModuloGerarPedido
{
    partial class EspecificarQuantidade
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
            this.labelProduto = new System.Windows.Forms.Label();
            this.textQuantidade = new System.Windows.Forms.TextBox();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelProduto
            // 
            this.labelProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduto.Location = new System.Drawing.Point(12, 40);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(266, 22);
            this.labelProduto.TabIndex = 0;
            this.labelProduto.Text = "labelProduto";
            this.labelProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textQuantidade
            // 
            this.textQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQuantidade.Location = new System.Drawing.Point(12, 69);
            this.textQuantidade.Name = "textQuantidade";
            this.textQuantidade.Size = new System.Drawing.Size(74, 38);
            this.textQuantidade.TabIndex = 1;
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidade.Location = new System.Drawing.Point(12, 8);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(266, 32);
            this.labelQuantidade.TabIndex = 3;
            this.labelQuantidade.Text = "Quantidade";
            this.labelQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(160)))), ((int)(((byte)(109)))));
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(92, 66);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(186, 45);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar 🔒";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // EspecificarQuantidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 120);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.textQuantidade);
            this.Controls.Add(this.labelProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EspecificarQuantidade";
            this.Text = "EspecificarQuantidade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EspecificarQuantidade_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.TextBox textQuantidade;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.Button btnConfirmar;
    }
}