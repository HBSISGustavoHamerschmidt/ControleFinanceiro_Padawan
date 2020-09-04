namespace Padawan.Financeiro.View
{
    partial class Inicial
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
            this.btn_Categoria = new System.Windows.Forms.Button();
            this.Financeiro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Categoria
            // 
            this.btn_Categoria.Location = new System.Drawing.Point(138, 175);
            this.btn_Categoria.Name = "btn_Categoria";
            this.btn_Categoria.Size = new System.Drawing.Size(75, 23);
            this.btn_Categoria.TabIndex = 0;
            this.btn_Categoria.Text = "Categoria";
            this.btn_Categoria.UseVisualStyleBackColor = true;
            this.btn_Categoria.Click += new System.EventHandler(this.btn_Categoria_Click);
            // 
            // Financeiro
            // 
            this.Financeiro.Location = new System.Drawing.Point(280, 175);
            this.Financeiro.Name = "Financeiro";
            this.Financeiro.Size = new System.Drawing.Size(75, 23);
            this.Financeiro.TabIndex = 0;
            this.Financeiro.Text = "Financeiro";
            this.Financeiro.UseVisualStyleBackColor = true;
            this.Financeiro.Click += new System.EventHandler(this.Financeiro_Click);
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Financeiro);
            this.Controls.Add(this.btn_Categoria);
            this.Name = "Inicial";
            this.Text = "Inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Categoria;
        private System.Windows.Forms.Button Financeiro;
    }
}