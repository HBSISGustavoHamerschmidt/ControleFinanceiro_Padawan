using LiteDB;
using Padawan.Financeiro.Negocio.Interfaces;
using Padawan.Financeiro.Negocio.Models;
using System.Collections.Generic;
using System.Linq;

namespace Padawan.Financeiro.Negocio
{
    public class Balanco : IBalanco
    {
        public double Saldo { get => CalcularSaldo(); }
        public List<IOperacao> Operacoes { get; } = new List<IOperacao>();

        public double CalcularSaldo()
        {
            double result = 0;

            using (var db = new LiteDatabase(@"C:\Users\joschua.silva\Documents\GitHub\ControleFinanceiro_Padawan\Banco\Banco.db"))
            {
                var teste = db.GetCollection<IOperacao>();
                var colecao = teste.FindAll();

                colecao.ToList().ForEach(p =>
                {
                    if (p is Debito)
                    {
                        result -= p.Valor;
                    }
                    if (p is Credito)
                    {
                        result += p.Valor;
                    }
                });
            }
            return result;
        }

        //public void Add(IOperacao operacao)
        //{
        //    using (var db = new LiteDatabase(@"C:\Users\joschua.silva\Documents\GitHub\ControleFinanceiro_Padawan\Banco\Banco.db"))
        //    {
        //        var teste = db.GetCollection<IOperacao>();
        //        teste.Insert(operacao);
        //    }
        //}

        public void Delete(IOperacao operacao)
        {
            using (var db = new LiteDatabase(@"C:\Users\joschua.silva\Documents\GitHub\ControleFinanceiro_Padawan\Banco\Banco.db"))
            {
                var teste = db.GetCollection<IOperacao>();
                // teste.Delete()
            }
        }

    }
}
