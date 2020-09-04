using Padawan.Financeiro.Negocio.Interfaces;
using System;

namespace Padawan.Financeiro.Negocio.Models
{
    public class Debito : IOperacao
    {
        public Debito() { }
        public Debito(double valor)
        {
            Valor = valor;
        }

        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public Categoria Categoria { get; set; }
        public string Descricao { get; set; }
    }
}