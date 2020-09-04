namespace Padawan.Financeiro.View
{
    partial class FormsBalanco
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_ListaBalanco = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.cmb_Tipo = new System.Windows.Forms.ComboBox();
            this.cmb_Categoria = new System.Windows.Forms.ComboBox();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_ListaBalanco
            // 
            this.txt_ListaBalanco.Location = new System.Drawing.Point(387, 12);
            this.txt_ListaBalanco.Multiline = true;
            this.txt_ListaBalanco.Name = "txt_ListaBalanco";
            this.txt_ListaBalanco.Size = new System.Drawing.Size(510, 178);
            this.txt_ListaBalanco.TabIndex = 0;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(63, 289);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Adicionar.TabIndex = 1;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(13, 167);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(194, 23);
            this.txt_valor.TabIndex = 2;
            // 
            // cmb_Tipo
            // 
            this.cmb_Tipo.FormattingEnabled = true;
            this.cmb_Tipo.Items.AddRange(new object[] {
            "Debito",
            "Credito"});
            this.cmb_Tipo.Location = new System.Drawing.Point(13, 123);
            this.cmb_Tipo.Name = "cmb_Tipo";
            this.cmb_Tipo.Size = new System.Drawing.Size(195, 23);
            this.cmb_Tipo.TabIndex = 3;
            // 
            // cmb_Categoria
            // 
            this.cmb_Categoria.FormattingEnabled = true;
            this.cmb_Categoria.Location = new System.Drawing.Point(239, 77);
            this.cmb_Categoria.Name = "cmb_Categoria";
            this.cmb_Categoria.Size = new System.Drawing.Size(126, 23);
            this.cmb_Categoria.TabIndex = 3;
            this.cmb_Categoria.SelectedIndexChanged += new System.EventHandler(this.cmb_Categoria_SelectedIndexChanged);
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Location = new System.Drawing.Point(13, 77);
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(194, 23);
            this.txt_Descricao.TabIndex = 2;
            // 
            // FormsBalanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 507);
            this.Controls.Add(this.txt_Descricao);
            this.Controls.Add(this.cmb_Categoria);
            this.Controls.Add(this.cmb_Tipo);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.txt_ListaBalanco);
            this.Name = "FormsBalanco";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormsBalanco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ListaBalanco;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.ComboBox cmb_Tipo;
        private System.Windows.Forms.ComboBox cmb_Categoria;
        private System.Windows.Forms.TextBox txt_Descricao;
    }
}

