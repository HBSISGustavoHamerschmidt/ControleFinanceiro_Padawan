using LiteDB;

namespace Padawan.Financeiro.Negocio.Models
{
    public class Categoria
    {
        private string text;

        public Categoria()
        {
        }

        public Categoria(string text)
        {
            this.text = text;
        }

        public string Descricao { get; set; }

        //public void Add(CategoriaModel operacao)
        //{
        //    using (var db = new LiteDatabase(@"C:\Users\joschua.silva\Documents\GitHub\ControleFinanceiro_Padawan\Banco\Banco.db"))
        //    {
        //        var teste = db.GetCollection<CategoriaModel>();
        //        teste.Insert(operacao);
        //    }
        //}


    }
    public class CategoriaModel
    {
        public string Descricao { get; set; }

    }



}