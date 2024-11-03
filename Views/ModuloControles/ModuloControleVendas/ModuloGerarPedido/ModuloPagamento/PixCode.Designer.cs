namespace over
{
    partial class PixCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PixCode));
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelInstrucoes = new System.Windows.Forms.Label();
            this.buttonGerarCodigoPix = new System.Windows.Forms.Button();
            this.labelPagamentoRealizado = new System.Windows.Forms.Label();
            this.pictureLoading = new System.Windows.Forms.PictureBox();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(14, 22);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(382, 73);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Valor Total";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInstrucoes
            // 
            this.labelInstrucoes.BackColor = System.Drawing.Color.Transparent;
            this.labelInstrucoes.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstrucoes.Location = new System.Drawing.Point(10, 295);
            this.labelInstrucoes.Name = "labelInstrucoes";
            this.labelInstrucoes.Size = new System.Drawing.Size(386, 72);
            this.labelInstrucoes.TabIndex = 7;
            this.labelInstrucoes.Text = "Instrucoes";
            this.labelInstrucoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGerarCodigoPix
            // 
            this.buttonGerarCodigoPix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonGerarCodigoPix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGerarCodigoPix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGerarCodigoPix.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGerarCodigoPix.Location = new System.Drawing.Point(106, 379);
            this.buttonGerarCodigoPix.Name = "buttonGerarCodigoPix";
            this.buttonGerarCodigoPix.Size = new System.Drawing.Size(193, 53);
            this.buttonGerarCodigoPix.TabIndex = 8;
            this.buttonGerarCodigoPix.Text = "Copiar código do PIX";
            this.buttonGerarCodigoPix.UseVisualStyleBackColor = false;
            this.buttonGerarCodigoPix.Click += new System.EventHandler(this.buttonGerarCodigoPix_Click);
            // 
            // labelPagamentoRealizado
            // 
            this.labelPagamentoRealizado.BackColor = System.Drawing.Color.Transparent;
            this.labelPagamentoRealizado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPagamentoRealizado.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagamentoRealizado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelPagamentoRealizado.Location = new System.Drawing.Point(19, 451);
            this.labelPagamentoRealizado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPagamentoRealizado.Name = "labelPagamentoRealizado";
            this.labelPagamentoRealizado.Size = new System.Drawing.Size(377, 19);
            this.labelPagamentoRealizado.TabIndex = 10;
            this.labelPagamentoRealizado.Text = "Já realizei o pagamento";
            this.labelPagamentoRealizado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPagamentoRealizado.Click += new System.EventHandler(this.labelPagamentoRealizado_Click);
            // 
            // pictureLoading
            // 
            this.pictureLoading.BackColor = System.Drawing.Color.Transparent;
            this.pictureLoading.Image = ((System.Drawing.Image)(resources.GetObject("pictureLoading.Image")));
            this.pictureLoading.Location = new System.Drawing.Point(355, 442);
            this.pictureLoading.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureLoading.Name = "pictureLoading";
            this.pictureLoading.Size = new System.Drawing.Size(36, 36);
            this.pictureLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLoading.TabIndex = 11;
            this.pictureLoading.TabStop = false;
            this.pictureLoading.Visible = false;
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.Location = new System.Drawing.Point(106, 98);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(193, 182);
            this.pictureBoxQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQRCode.TabIndex = 9;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 1000;
            // 
            // PixCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(406, 483);
            this.Controls.Add(this.pictureLoading);
            this.Controls.Add(this.labelPagamentoRealizado);
            this.Controls.Add(this.pictureBoxQRCode);
            this.Controls.Add(this.buttonGerarCodigoPix);
            this.Controls.Add(this.labelInstrucoes);
            this.Controls.Add(this.labelTotal);
            this.Name = "PixCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PixCode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelInstrucoes;
        private System.Windows.Forms.Button buttonGerarCodigoPix;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
        private System.Windows.Forms.Label labelPagamentoRealizado;
        private System.Windows.Forms.PictureBox pictureLoading;
        private System.Windows.Forms.Timer timerLoading;
    }
}