using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Contas
{
class ContaPoupansa : ContaBancaria
    {
        public void RenderJurus()
        {
            _saldo = _saldo * 1.05;//Foi colocado o 1.05 por que precisa acrescentar o 5 porcento no valor ja existente. 
        }
    }
}
