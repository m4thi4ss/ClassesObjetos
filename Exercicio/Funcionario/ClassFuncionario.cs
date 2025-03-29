using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Funcionario
{
    class Funcionario
    {
        protected double _salario;

        public void SetSalario(double valor)
        {
            _salario = valor;
        }

        public double GetSalario()
        {
            return _salario;
        }
    }
}
