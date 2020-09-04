using Padawan.Financeiro.Negocio.Interfaces;
using System;

namespace Padawan.Financeiro.Negocio.Models
{
    public class Credito : IOperacao
    {
        public Credito()
        {
        }

        public Credito(double valor, DateTime data, Categoria categoria, string descricao)
        {
            Valor = valor;
            Data = data;
            Categoria = categoria;
            Descricao = descricao;
        }

        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public Categoria Categoria { get; set; }
        public string Descricao { get; set; }
    }
}