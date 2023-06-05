namespace Cadastro_de_Editora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dadosGrid = new System.Windows.Forms.DataGridView();
            this.colCodEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.txtcodEditora = new System.Windows.Forms.TextBox();
            this.labelCodAutor = new System.Windows.Forms.Label();
            this.labelNomeAutor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.asteriscoInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dadosGrid
            // 
            this.dadosGrid.AllowUserToAddRows = false;
            this.dadosGrid.AllowUserToDeleteRows = false;
            this.dadosGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodEditora,
            this.colNomeEditora});
            this.dadosGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dadosGrid.Location = new System.Drawing.Point(20, 87);
            this.dadosGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dadosGrid.Name = "dadosGrid";
            this.dadosGrid.ReadOnly = true;
            this.dadosGrid.RowHeadersWidth = 51;
            this.dadosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid.Size = new System.Drawing.Size(665, 231);
            this.dadosGrid.TabIndex = 28;
            this.dadosGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dadosGrid_CellDoubleClick);
            // 
            // colCodEditora
            // 
            this.colCodEditora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colCodEditora.FillWeight = 152.2843F;
            this.colCodEditora.HeaderText = "Código";
            this.colCodEditora.MinimumWidth = 6;
            this.colCodEditora.Name = "colCodEditora";
            this.colCodEditora.ReadOnly = true;
            this.colCodEditora.Width = 80;
            // 
            // colNomeEditora
            // 
            this.colNomeEditora.FillWeight = 73.85786F;
            this.colNomeEditora.HeaderText = "Nome editora";
            this.colNomeEditora.MinimumWidth = 6;
            this.colNomeEditora.Name = "colNomeEditora";
            this.colNomeEditora.ReadOnly = true;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Location = new System.Drawing.Point(572, 54);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(113, 27);
            this.btn_Excluir.TabIndex = 27;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(572, 26);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 27);
            this.btnSalvar.TabIndex = 26;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.BackColor = System.Drawing.SystemColors.Info;
            this.txtNomeEditora.Location = new System.Drawing.Point(132, 55);
            this.txtNomeEditora.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.Size = new System.Drawing.Size(281, 22);
            this.txtNomeEditora.TabIndex = 23;
            this.txtNomeEditora.TextChanged += new System.EventHandler(this.txtNomeEditora_TextChanged);
            // 
            // txtcodEditora
            // 
            this.txtcodEditora.BackColor = System.Drawing.SystemColors.Window;
            this.txtcodEditora.Enabled = false;
            this.txtcodEditora.Location = new System.Drawing.Point(132, 27);
            this.txtcodEditora.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodEditora.Name = "txtcodEditora";
            this.txtcodEditora.Size = new System.Drawing.Size(85, 22);
            this.txtcodEditora.TabIndex = 22;
            // 
            // labelCodAutor
            // 
            this.labelCodAutor.AutoSize = true;
            this.labelCodAutor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodAutor.Location = new System.Drawing.Point(-64, 23);
            this.labelCodAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCodAutor.Name = "labelCodAutor";
            this.labelCodAutor.Size = new System.Drawing.Size(58, 20);
            this.labelCodAutor.TabIndex = 21;
            this.labelCodAutor.Text = "Codigo";
            // 
            // labelNomeAutor
            // 
            this.labelNomeAutor.AutoSize = true;
            this.labelNomeAutor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeAutor.Location = new System.Drawing.Point(16, 54);
            this.labelNomeAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeAutor.Name = "labelNomeAutor";
            this.labelNomeAutor.Size = new System.Drawing.Size(102, 20);
            this.labelNomeAutor.TabIndex = 20;
            this.labelNomeAutor.Text = "Nome editora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Código";
            // 
            // asteriscoInfo
            // 
            this.asteriscoInfo.AutoSize = true;
            this.asteriscoInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.asteriscoInfo.ForeColor = System.Drawing.Color.Red;
            this.asteriscoInfo.Location = new System.Drawing.Point(420, 55);
            this.asteriscoInfo.Name = "asteriscoInfo";
            this.asteriscoInfo.Size = new System.Drawing.Size(12, 16);
            this.asteriscoInfo.TabIndex = 30;
            this.asteriscoInfo.Text = "*";
            this.asteriscoInfo.MouseHover += new System.EventHandler(this.asteriscoInfo_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(700, 334);
            this.Controls.Add(this.asteriscoInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dadosGrid);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNomeEditora);
            this.Controls.Add(this.txtcodEditora);
            this.Controls.Add(this.labelCodAutor);
            this.Controls.Add(this.labelNomeAutor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro editora";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dadosGrid;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNomeEditora;
        private System.Windows.Forms.TextBox txtcodEditora;
        private System.Windows.Forms.Label labelCodAutor;
        private System.Windows.Forms.Label labelNomeAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label asteriscoInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeEditora;
    }
}

