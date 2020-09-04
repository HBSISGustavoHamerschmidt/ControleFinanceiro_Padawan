﻿using LiteDB;
using System.Collections.Generic;
using System.Linq;

namespace Padawan.Financeiro.Negocio.Banco
{
    public class Banco<T>
    {
        public List<T> Listar()
        {
            using (var db = new LiteDatabase(@"C:\Users\joschua.silva\Documents\GitHub\ControleFinanceiro_Padawan\Banco\Banco.db"))
            {
                return db.GetCollection<T>().FindAll().ToList();
            }

        }
    }
}