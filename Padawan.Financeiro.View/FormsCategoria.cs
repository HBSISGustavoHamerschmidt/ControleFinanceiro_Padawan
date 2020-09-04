using LiteDB;
using Padawan.Financeiro.Negocio.Banco;
using Padawan.Financeiro.Negocio.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Padawan.Financeiro.View
{
    public partial class FormsCategoria : Form
    {
        private readonly Banco<CategoriaModel> banco;
        private readonly Categoria categoria;
        public FormsCategoria()
        {
            InitializeComponent();
            categoria = new Categoria();
            banco = new Banco<CategoriaModel>();
            CarregaLista();
        }

        private void CarregaLista()
        {
            list_Categoria.Items.Clear();
            list_Categoria.Items.AddRange(banco.Listar().Select(q => q.Descricao).ToArray());
        }

        private void btn_AdicionarCategoria_Click(object sender, EventArgs e)
        {
            banco.Add(new CategoriaModel()
            {
                Descricao = txt_Categoria.Text
            });

            CarregaLista();

        }
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {

        }

        private void list_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}