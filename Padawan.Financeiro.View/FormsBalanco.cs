using Padawan.Financeiro.Negocio;
using Padawan.Financeiro.Negocio.Banco;
using Padawan.Financeiro.Negocio.Interfaces;
using Padawan.Financeiro.Negocio.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Padawan.Financeiro.View
{

    public partial class FormsBalanco : Form
    {
        private Balanco balanco;
        private readonly Banco<CategoriaModel> banco;
        private readonly Categoria categoria;
        private readonly Banco<IOperacao> banco2;

        public FormsBalanco()
        {

            //como pego a lista ja instaciada na outra tela 
            InitializeComponent();
            balanco = new Balanco();
            categoria = new Categoria();
            banco = new Banco<CategoriaModel>();
            banco2 = new Banco<IOperacao>();
            txt_ListaBalanco.Text = Convert.ToString(balanco.CalcularSaldo());
            CarregaCombCategoria();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            AdicionarButton();
            txt_ListaBalanco.Text = Convert.ToString(balanco.CalcularSaldo());
           
        }

        public void CarregaCombCategoria()
        {
            cmb_Categoria.Items.AddRange(banco.Listar().Select(q => q.Descricao).ToArray());
        }

        private void cmb_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormsBalanco_Load(object sender, EventArgs e)
        {

        }

        public void AdicionarButton()
        {
            // como faço isso por tipo e nao passando a string que ela ali dentro pra eu nao fazer if toda vez que eu adicionar algo
            if (cmb_Tipo.Text == "Credito")
            {
                banco2.Add(new Credito()
                {
                    Descricao = txt_Descricao.Text,
                    Valor = double.Parse(txt_valor.Text),
                    Categoria = new Categoria(cmb_Categoria.Text),
                    Data = DateTime.Today

                });
            }
            if (cmb_Tipo.Text == "Debito")
            {
                 banco2.Add(new Debito()
                {
                    Descricao = txt_Descricao.Text,
                    Valor = double.Parse(txt_valor.Text),
                    Categoria = new Categoria(cmb_Categoria.Text),
                    Data = DateTime.Today

                });

            }

        }
    }
}