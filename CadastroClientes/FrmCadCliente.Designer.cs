namespace CadastroClientes
{
    partial class FrmCadCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnalteracao = new System.Windows.Forms.Button();
            this.DataNasc = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCad = new System.Windows.Forms.Button();
            this.Endereco = new System.Windows.Forms.TextBox();
            this.Telefone = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnalteracao);
            this.groupBox1.Controls.Add(this.DataNasc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnCad);
            this.groupBox1.Controls.Add(this.Endereco);
            this.groupBox1.Controls.Add(this.Telefone);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.Nome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 395);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnalteracao
            // 
            this.btnalteracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnalteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalteracao.Location = new System.Drawing.Point(151, 309);
            this.btnalteracao.Name = "btnalteracao";
            this.btnalteracao.Size = new System.Drawing.Size(196, 35);
            this.btnalteracao.TabIndex = 14;
            this.btnalteracao.Text = "Salvar Alterações";
            this.btnalteracao.UseVisualStyleBackColor = true;
            this.btnalteracao.Visible = false;
            this.btnalteracao.Click += new System.EventHandler(this.btnalteracao_Click);
            // 
            // DataNasc
            // 
            this.DataNasc.Location = new System.Drawing.Point(151, 97);
            this.DataNasc.Mask = "00/00/0000";
            this.DataNasc.Name = "DataNasc";
            this.DataNasc.Size = new System.Drawing.Size(139, 20);
            this.DataNasc.TabIndex = 13;
            this.DataNasc.ValidatingType = typeof(System.DateTime);
            this.DataNasc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Endereço";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nascimento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // BtnCad
            // 
            this.BtnCad.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCad.Location = new System.Drawing.Point(460, 309);
            this.BtnCad.Name = "BtnCad";
            this.BtnCad.Size = new System.Drawing.Size(196, 35);
            this.BtnCad.TabIndex = 5;
            this.BtnCad.Text = "Cadastrar";
            this.BtnCad.UseVisualStyleBackColor = false;
            this.BtnCad.Click += new System.EventHandler(this.button1_Click);
            // 
            // Endereco
            // 
            this.Endereco.Location = new System.Drawing.Point(151, 266);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(505, 20);
            this.Endereco.TabIndex = 4;
            // 
            // Telefone
            // 
            this.Telefone.Location = new System.Drawing.Point(151, 199);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(328, 20);
            this.Telefone.TabIndex = 3;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(151, 143);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(428, 20);
            this.Email.TabIndex = 2;
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(151, 40);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(505, 20);
            this.Nome.TabIndex = 0;
            // 
            // FrmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(886, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmCadCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox Telefone;
        public System.Windows.Forms.TextBox Email;
        public System.Windows.Forms.TextBox Nome;
        public System.Windows.Forms.Button BtnCad;
        public System.Windows.Forms.TextBox Endereco;
        public System.Windows.Forms.MaskedTextBox DataNasc;
        public System.Windows.Forms.Button btnalteracao;
    }
}