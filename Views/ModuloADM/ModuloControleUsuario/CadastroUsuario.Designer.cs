namespace over {
    partial class CadastroUsuario {
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textCPF = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCPFColaborador = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCargo = new System.Windows.Forms.Label();
            this.comboEscolhaCargo = new System.Windows.Forms.ComboBox();
            this.pictureBoxVoltarCadastro = new System.Windows.Forms.PictureBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.labelNomeUsuario = new System.Windows.Forms.Label();
            this.iconPerfil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoltarCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(788, -26);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(13, 10);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-224, -106);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 62);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // textNome
            // 
            this.textNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(240)))));
            this.textNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.textNome.ForeColor = System.Drawing.Color.Gray;
            this.textNome.Location = new System.Drawing.Point(833, 329);
            this.textNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(311, 49);
            this.textNome.TabIndex = 1;
            // 
            // textCPF
            // 
            this.textCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(240)))));
            this.textCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.textCPF.ForeColor = System.Drawing.Color.Gray;
            this.textCPF.Location = new System.Drawing.Point(1217, 329);
            this.textCPF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCPF.Mask = "000,000,000-00";
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(257, 49);
            this.textCPF.TabIndex = 2;
            this.textCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CPFTextBox_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Ivory;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(829, 293);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nome Completo*";
            // 
            // labelCPFColaborador
            // 
            this.labelCPFColaborador.BackColor = System.Drawing.Color.Ivory;
            this.labelCPFColaborador.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelCPFColaborador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelCPFColaborador.Location = new System.Drawing.Point(1215, 288);
            this.labelCPFColaborador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCPFColaborador.Name = "labelCPFColaborador";
            this.labelCPFColaborador.Size = new System.Drawing.Size(87, 30);
            this.labelCPFColaborador.TabIndex = 28;
            this.labelCPFColaborador.Text = "CPF*";
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(240)))));
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.textEmail.ForeColor = System.Drawing.Color.Gray;
            this.textEmail.Location = new System.Drawing.Point(836, 453);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(309, 49);
            this.textEmail.TabIndex = 3;
            // 
            // labelEmail
            // 
            this.labelEmail.BackColor = System.Drawing.Color.Ivory;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelEmail.Location = new System.Drawing.Point(829, 405);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(133, 28);
            this.labelEmail.TabIndex = 30;
            this.labelEmail.Text = "E-mail*";
            // 
            // textSenha
            // 
            this.textSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(240)))));
            this.textSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.textSenha.ForeColor = System.Drawing.Color.Gray;
            this.textSenha.Location = new System.Drawing.Point(1217, 450);
            this.textSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.Size = new System.Drawing.Size(259, 49);
            this.textSenha.TabIndex = 4;
            this.textSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Ivory;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label2.Location = new System.Drawing.Point(1212, 417);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 32;
            this.label2.Text = "Senha*";
            // 
            // labelCargo
            // 
            this.labelCargo.BackColor = System.Drawing.Color.Ivory;
            this.labelCargo.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelCargo.Location = new System.Drawing.Point(829, 524);
            this.labelCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(133, 37);
            this.labelCargo.TabIndex = 33;
            this.labelCargo.Text = "Cargo*";
            // 
            // comboEscolhaCargo
            // 
            this.comboEscolhaCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(240)))));
            this.comboEscolhaCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.comboEscolhaCargo.ForeColor = System.Drawing.Color.Gray;
            this.comboEscolhaCargo.FormattingEnabled = true;
            this.comboEscolhaCargo.Items.AddRange(new object[] {
            "Gerente de Produção",
            "Gerente de Venda",
            "Gerente de RH",
            "Vendedor"});
            this.comboEscolhaCargo.Location = new System.Drawing.Point(835, 561);
            this.comboEscolhaCargo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboEscolhaCargo.Name = "comboEscolhaCargo";
            this.comboEscolhaCargo.Size = new System.Drawing.Size(309, 50);
            this.comboEscolhaCargo.TabIndex = 5;
            // 
            // pictureBoxVoltarCadastro
            // 
            this.pictureBoxVoltarCadastro.BackColor = System.Drawing.Color.Ivory;
            this.pictureBoxVoltarCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxVoltarCadastro.Image = global::over.Properties.Resources.btnVoltar;
            this.pictureBoxVoltarCadastro.Location = new System.Drawing.Point(779, 199);
            this.pictureBoxVoltarCadastro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxVoltarCadastro.Name = "pictureBoxVoltarCadastro";
            this.pictureBoxVoltarCadastro.Size = new System.Drawing.Size(56, 48);
            this.pictureBoxVoltarCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVoltarCadastro.TabIndex = 39;
            this.pictureBoxVoltarCadastro.TabStop = false;
            this.pictureBoxVoltarCadastro.Click += new System.EventHandler(this.pictureBoxVoltarCadastro_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLimpar.FlatAppearance.BorderSize = 0;
            this.buttonLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.ForeColor = System.Drawing.Color.White;
            this.buttonLimpar.Location = new System.Drawing.Point(1189, 649);
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(132, 30);
            this.buttonLimpar.TabIndex = 56;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(1368, 650);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(139, 30);
            this.btnCadastrar.TabIndex = 57;
            this.btnCadastrar.Text = "Cadastrar 🔒";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // labelNomeUsuario
            // 
            this.labelNomeUsuario.AutoSize = true;
            this.labelNomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeUsuario.Location = new System.Drawing.Point(1619, 27);
            this.labelNomeUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeUsuario.Name = "labelNomeUsuario";
            this.labelNomeUsuario.Size = new System.Drawing.Size(85, 29);
            this.labelNomeUsuario.TabIndex = 59;
            this.labelNomeUsuario.Text = "label2";
            this.labelNomeUsuario.Click += new System.EventHandler(this.labelNomeUsuario_Click);
            // 
            // iconPerfil
            // 
            this.iconPerfil.BackColor = System.Drawing.Color.Transparent;
            this.iconPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPerfil.Image = global::over.Properties.Resources.iconPerfil;
            this.iconPerfil.Location = new System.Drawing.Point(1563, 14);
            this.iconPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconPerfil.Name = "iconPerfil";
            this.iconPerfil.Size = new System.Drawing.Size(47, 52);
            this.iconPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPerfil.TabIndex = 58;
            this.iconPerfil.TabStop = false;
            this.iconPerfil.Click += new System.EventHandler(this.iconPerfil_Click);
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::over.Properties.Resources.telaCadastrarUsuario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1740, 782);
            this.Controls.Add(this.labelNomeUsuario);
            this.Controls.Add(this.iconPerfil);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.pictureBoxVoltarCadastro);
            this.Controls.Add(this.comboEscolhaCargo);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelCPFColaborador);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroColaborador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoltarCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.MaskedTextBox textCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCPFColaborador;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.ComboBox comboEscolhaCargo;
        private System.Windows.Forms.PictureBox pictureBoxVoltarCadastro;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label labelNomeUsuario;
        private System.Windows.Forms.PictureBox iconPerfil;
    }
}