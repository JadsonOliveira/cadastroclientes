namespace CadastroClientes
{
    partial class Frmconsulta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlteracao2 = new System.Windows.Forms.Button();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.DgResultado = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgResultado)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnExcluir);
            this.groupBox1.Controls.Add(this.BtnAlteracao2);
            this.groupBox1.Controls.Add(this.BtnConsulta);
            this.groupBox1.Controls.Add(this.DgResultado);
            this.groupBox1.Location = new System.Drawing.Point(2, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 641);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnExcluir.BackColor = System.Drawing.Color.Red;
            this.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(618, 524);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(256, 106);
            this.BtnExcluir.TabIndex = 4;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            // 
            // BtnAlteracao2
            // 
            this.BtnAlteracao2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAlteracao2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAlteracao2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAlteracao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlteracao2.Location = new System.Drawing.Point(0, 524);
            this.BtnAlteracao2.Name = "BtnAlteracao2";
            this.BtnAlteracao2.Size = new System.Drawing.Size(256, 106);
            this.BtnAlteracao2.TabIndex = 2;
            this.BtnAlteracao2.Text = "Alterar";
            this.BtnAlteracao2.UseVisualStyleBackColor = false;
            this.BtnAlteracao2.Click += new System.EventHandler(this.BtnAlteracao2_Click);
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnConsulta.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnConsulta.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BtnConsulta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.BtnConsulta.Location = new System.Drawing.Point(3, 524);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(874, 114);
            this.BtnConsulta.TabIndex = 1;
            this.BtnConsulta.Text = "Consultar";
            this.BtnConsulta.UseVisualStyleBackColor = false;
            this.BtnConsulta.UseWaitCursor = true;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // DgResultado
            // 
            this.DgResultado.AllowUserToAddRows = false;
            this.DgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgResultado.ContextMenuStrip = this.contextMenuStrip1;
            this.DgResultado.Location = new System.Drawing.Point(0, 0);
            this.DgResultado.Name = "DgResultado";
            this.DgResultado.ReadOnly = true;
            this.DgResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgResultado.Size = new System.Drawing.Size(871, 527);
            this.DgResultado.TabIndex = 0;
            this.DgResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgResultado_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.alterarToolStripMenuItem.Text = "Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.AlterarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consulta de Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Frmconsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(872, 664);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmconsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Frmconsulta";
            this.Load += new System.EventHandler(this.Frmconsulta_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgResultado)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        public System.Windows.Forms.Button BtnExcluir;
        public System.Windows.Forms.Button BtnAlteracao2;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        public System.Windows.Forms.Button BtnConsulta;
        public System.Windows.Forms.DataGridView DgResultado;
    }
}