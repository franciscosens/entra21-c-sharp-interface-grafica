namespace WindowsFormsApp1
{
    partial class CadastroPessoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSexoFeminino = new System.Windows.Forms.RadioButton();
            this.rbSexoMasculino = new System.Windows.Forms.RadioButton();
            this.cbNacionalidade = new System.Windows.Forms.ComboBox();
            this.cbEuLiOsTermos = new System.Windows.Forms.CheckBox();
            this.cbEuAceitoOsTermos = new System.Windows.Forms.CheckBox();
            this.rbStatusReprovado = new System.Windows.Forms.RadioButton();
            this.rbStatusAprovado = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(54, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(708, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(54, 46);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(158, 20);
            this.txtIdade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Idade";
            // 
            // rbSexoFeminino
            // 
            this.rbSexoFeminino.AutoSize = true;
            this.rbSexoFeminino.Location = new System.Drawing.Point(7, 30);
            this.rbSexoFeminino.Name = "rbSexoFeminino";
            this.rbSexoFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbSexoFeminino.TabIndex = 4;
            this.rbSexoFeminino.TabStop = true;
            this.rbSexoFeminino.Text = "Feminino";
            this.rbSexoFeminino.UseVisualStyleBackColor = true;
            // 
            // rbSexoMasculino
            // 
            this.rbSexoMasculino.AutoSize = true;
            this.rbSexoMasculino.Location = new System.Drawing.Point(7, 54);
            this.rbSexoMasculino.Name = "rbSexoMasculino";
            this.rbSexoMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbSexoMasculino.TabIndex = 5;
            this.rbSexoMasculino.TabStop = true;
            this.rbSexoMasculino.Text = "Masculino";
            this.rbSexoMasculino.UseVisualStyleBackColor = true;
            // 
            // cbNacionalidade
            // 
            this.cbNacionalidade.FormattingEnabled = true;
            this.cbNacionalidade.Items.AddRange(new object[] {
            "Alemão",
            "Americano",
            "Argentino",
            "Brasileiro",
            ""});
            this.cbNacionalidade.Location = new System.Drawing.Point(218, 209);
            this.cbNacionalidade.Name = "cbNacionalidade";
            this.cbNacionalidade.Size = new System.Drawing.Size(544, 21);
            this.cbNacionalidade.TabIndex = 6;
            // 
            // cbEuLiOsTermos
            // 
            this.cbEuLiOsTermos.AutoSize = true;
            this.cbEuLiOsTermos.Location = new System.Drawing.Point(12, 189);
            this.cbEuLiOsTermos.Name = "cbEuLiOsTermos";
            this.cbEuLiOsTermos.Size = new System.Drawing.Size(94, 17);
            this.cbEuLiOsTermos.TabIndex = 7;
            this.cbEuLiOsTermos.Text = "Eu li os termos";
            this.cbEuLiOsTermos.UseVisualStyleBackColor = true;
            // 
            // cbEuAceitoOsTermos
            // 
            this.cbEuAceitoOsTermos.AutoSize = true;
            this.cbEuAceitoOsTermos.Location = new System.Drawing.Point(12, 213);
            this.cbEuAceitoOsTermos.Name = "cbEuAceitoOsTermos";
            this.cbEuAceitoOsTermos.Size = new System.Drawing.Size(119, 17);
            this.cbEuAceitoOsTermos.TabIndex = 8;
            this.cbEuAceitoOsTermos.Text = "Eu aceito os termos";
            this.cbEuAceitoOsTermos.UseVisualStyleBackColor = true;
            // 
            // rbStatusReprovado
            // 
            this.rbStatusReprovado.AutoSize = true;
            this.rbStatusReprovado.Location = new System.Drawing.Point(16, 54);
            this.rbStatusReprovado.Name = "rbStatusReprovado";
            this.rbStatusReprovado.Size = new System.Drawing.Size(78, 17);
            this.rbStatusReprovado.TabIndex = 11;
            this.rbStatusReprovado.TabStop = true;
            this.rbStatusReprovado.Text = "Reprovado";
            this.rbStatusReprovado.UseVisualStyleBackColor = true;
            // 
            // rbStatusAprovado
            // 
            this.rbStatusAprovado.AutoSize = true;
            this.rbStatusAprovado.Location = new System.Drawing.Point(16, 31);
            this.rbStatusAprovado.Name = "rbStatusAprovado";
            this.rbStatusAprovado.Size = new System.Drawing.Size(71, 17);
            this.rbStatusAprovado.TabIndex = 10;
            this.rbStatusAprovado.TabStop = true;
            this.rbStatusAprovado.Text = "Aprovado";
            this.rbStatusAprovado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSexoFeminino);
            this.groupBox1.Controls.Add(this.rbSexoMasculino);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbStatusReprovado);
            this.groupBox2.Controls.Add(this.rbStatusAprovado);
            this.groupBox2.Location = new System.Drawing.Point(218, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nacionalidade";
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.Location = new System.Drawing.Point(12, 268);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.Size = new System.Drawing.Size(750, 136);
            this.rtbDescricao.TabIndex = 17;
            this.rtbDescricao.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Descrição";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(608, 410);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(154, 28);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(12, 410);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(154, 28);
            this.btnLimpar.TabIndex = 20;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(260, 42);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(158, 20);
            this.txtAltura.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Altura";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(475, 42);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(158, 20);
            this.txtPeso.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Peso";
            // 
            // rtbResultado
            // 
            this.rtbResultado.Enabled = false;
            this.rtbResultado.Location = new System.Drawing.Point(437, 93);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.Size = new System.Drawing.Size(325, 109);
            this.rtbResultado.TabIndex = 25;
            this.rtbResultado.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Resultado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(43, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "*";
            // 
            // CadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtbResultado);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbEuAceitoOsTermos);
            this.Controls.Add(this.cbEuLiOsTermos);
            this.Controls.Add(this.cbNacionalidade);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "CadastroPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroPessoa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbSexoFeminino;
        private System.Windows.Forms.RadioButton rbSexoMasculino;
        private System.Windows.Forms.ComboBox cbNacionalidade;
        private System.Windows.Forms.CheckBox cbEuLiOsTermos;
        private System.Windows.Forms.CheckBox cbEuAceitoOsTermos;
        private System.Windows.Forms.RadioButton rbStatusReprovado;
        private System.Windows.Forms.RadioButton rbStatusAprovado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}