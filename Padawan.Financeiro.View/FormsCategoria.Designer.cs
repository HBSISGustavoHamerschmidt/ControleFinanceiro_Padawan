namespace Padawan.Financeiro.View
{
    partial class FormsCategoria
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
            this.txt_Categoria = new System.Windows.Forms.TextBox();
            this.btn_AdicionarCategoria = new System.Windows.Forms.Button();
            this.btn_RemoverDaLista = new System.Windows.Forms.Button();
            this.list_Categoria = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_Categoria
            // 
            this.txt_Categoria.Location = new System.Drawing.Point(78, 77);
            this.txt_Categoria.Name = "txt_Categoria";
            this.txt_Categoria.Size = new System.Drawing.Size(158, 23);
            this.txt_Categoria.TabIndex = 0;
            // 
            // btn_AdicionarCategoria
            // 
            this.btn_AdicionarCategoria.Location = new System.Drawing.Point(78, 124);
            this.btn_AdicionarCategoria.Name = "btn_AdicionarCategoria";
            this.btn_AdicionarCategoria.Size = new System.Drawing.Size(158, 23);
            this.btn_AdicionarCategoria.TabIndex = 2;
            this.btn_AdicionarCategoria.Text = "Adicionar";
            this.btn_AdicionarCategoria.UseVisualStyleBackColor = true;
            this.btn_AdicionarCategoria.Click += new System.EventHandler(this.btn_AdicionarCategoria_Click);
            // 
            // btn_RemoverDaLista
            // 
            this.btn_RemoverDaLista.Location = new System.Drawing.Point(339, 245);
            this.btn_RemoverDaLista.Name = "btn_RemoverDaLista";
            this.btn_RemoverDaLista.Size = new System.Drawing.Size(198, 23);
            this.btn_RemoverDaLista.TabIndex = 3;
            this.btn_RemoverDaLista.Text = "Remover";
            this.btn_RemoverDaLista.UseVisualStyleBackColor = true;
            this.btn_RemoverDaLista.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // list_Categoria
            // 
            this.list_Categoria.FormattingEnabled = true;
            this.list_Categoria.ItemHeight = 15;
            this.list_Categoria.Location = new System.Drawing.Point(339, 53);
            this.list_Categoria.Name = "list_Categoria";
            this.list_Categoria.Size = new System.Drawing.Size(198, 154);
            this.list_Categoria.TabIndex = 4;
            this.list_Categoria.SelectedIndexChanged += new System.EventHandler(this.list_Categoria_SelectedIndexChanged);
            // 
            // FormsCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list_Categoria);
            this.Controls.Add(this.btn_RemoverDaLista);
            this.Controls.Add(this.btn_AdicionarCategoria);
            this.Controls.Add(this.txt_Categoria);
            this.Name = "FormsCategoria";
            this.Text = "Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Categoria;
        private System.Windows.Forms.Button btn_AdicionarCategoria;
        private System.Windows.Forms.Button btn_RemoverDaLista;
        private System.Windows.Forms.ListBox list_Categoria;
    }
}