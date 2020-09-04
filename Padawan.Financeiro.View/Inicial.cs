using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Padawan.Financeiro.View
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void btn_Categoria_Click(object sender, EventArgs e)
        {
            FormsCategoria formsCategoria = new FormsCategoria();
            formsCategoria.ShowDialog();
        }

        private void Financeiro_Click(object sender, EventArgs e)
        {
            FormsBalanco formsFinanceiro = new FormsBalanco();
            formsFinanceiro.ShowDialog();
        }
    }
}
