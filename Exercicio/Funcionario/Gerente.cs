using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Funcionario
{
    class Gerente : Funcionario
    {
        public void Bonificar() //Sempre que for uma classe que e private, sempre tem que ser um void
        {
            _salario = _salario * 1.10;
        }
    }
}
