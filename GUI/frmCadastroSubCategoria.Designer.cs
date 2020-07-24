namespace GUI
{
    partial class frmCadastroSubCategoria
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbCatCod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtScatCod = new System.Windows.Forms.TextBox();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.txtScatCod);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.cbCatCod);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            // 
            // btSalvar
            // 
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da Subcategoria";
            // 
            // cbCatCod
            // 
            this.cbCatCod.FormattingEnabled = true;
            this.cbCatCod.Location = new System.Drawing.Point(10, 151);
            this.cbCatCod.Name = "cbCatCod";
            this.cbCatCod.Size = new System.Drawing.Size(294, 21);
            this.cbCatCod.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome da Categoria";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 95);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(712, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtScatCod
            // 
            this.txtScatCod.Enabled = false;
            this.txtScatCod.Location = new System.Drawing.Point(7, 38);
            this.txtScatCod.Name = "txtScatCod";
            this.txtScatCod.Size = new System.Drawing.Size(116, 20);
            this.txtScatCod.TabIndex = 5;
            // 
            // frmCadastroSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmCadastroSubCategoria";
            this.Text = "Cadastro de Subcategoria";
            this.Load += new System.EventHandler(this.frmCadastroSubCategoria_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtScatCod;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCatCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
