using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Funcionario
    {
        private double _salario;

        public void SetSalario(double valor)
        {
            _salario = valor;
        }

        public double GetSalario(double valor)
        {
            return _salario;
        }
    }
}
