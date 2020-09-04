﻿using Padawan.Financeiro.Negocio.Model;
using System;

namespace Padawan.Financeiro.Negocio.Interfaces
{
    public interface IOperacao
    {
        string Descricao { get; set; }
        double Valor { get; set; }
        DateTime Data { get; set; }
        Categoria Categoria { get; set; }
    }
}