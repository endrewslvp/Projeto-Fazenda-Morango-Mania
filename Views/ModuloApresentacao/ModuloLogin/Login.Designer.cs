namespace over {
    partial class Login {
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CPFTextBox = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextPassword = new System.Windows.Forms.MaskedTextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, -53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // CPFTextBox
            // 
            this.CPFTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(240)))));
            this.CPFTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.CPFTextBox.ForeColor = System.Drawing.Color.Gray;
            this.CPFTextBox.Location = new System.Drawing.Point(614, 310);
            this.CPFTextBox.Mask = "000,000,000-00";
            this.CPFTextBox.Name = "CPFTextBox";
            this.CPFTextBox.Size = new System.Drawing.Size(512, 41);
            this.CPFTextBox.TabIndex = 10;
            this.CPFTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CPFTextBox_MaskInputRejected);
            // 
            // maskedTextPassword
            // 
            this.maskedTextPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(240)))));
            this.maskedTextPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.maskedTextPassword.ForeColor = System.Drawing.Color.Gray;
            this.maskedTextPassword.Location = new System.Drawing.Point(614, 418);
            this.maskedTextPassword.Name = "maskedTextPassword";
            this.maskedTextPassword.Size = new System.Drawing.Size(512, 41);
            this.maskedTextPassword.TabIndex = 12;
            this.maskedTextPassword.UseSystemPasswordChar = true;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Enabled = false;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(1017, 516);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(94, 33);
            this.btnEntrar.TabIndex = 58;
            this.btnEntrar.Text = "Entrar 🔒";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::over.Properties.Resources.telaLogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1305, 635);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.maskedTextPassword);
            this.Controls.Add(this.CPFTextBox);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox CPFTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextPassword;
        private System.Windows.Forms.Button btnEntrar;
    }
}