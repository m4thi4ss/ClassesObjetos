﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Contas
{
    class ContaBancaria
    {
        protected double _saldo = 0;

        public void Depositar(double valor)
        {
            _saldo += valor;
        }
        public void Sacar(double valor)
        {
            _saldo -= valor;
        }
        public double VerSaldo()
        {
            return _saldo;
        }
    }
}
