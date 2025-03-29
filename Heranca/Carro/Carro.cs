using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Carro
{
    class Carro
    {
        public string modelo;
        public string marca;
        public int quilometragem;

        // Virtual - Esse metodo pode ser sobrescrito. Ele para usar o mesmo metodo da heranca pai mas de modo diferente.
        public virtual void MostrarInformacoes()
        {
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Marca " + marca);
            Console.WriteLine("Quilometragem " + quilometragem);
        } 

        //Um metodo com mesmo nome ele pode receber coisa diferente, como por exemplo com um parametro diferente. Tem que ter parametro diferente, o tipo tambem nao pode ser igual, tem que ser diferente do outro metodo.
        public void MostrarInformacoes(string nome)
        {
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Marca " + marca);
            Console.WriteLine("Quilometragem " + quilometragem);
            Console.WriteLine("Nome: " + nome);
        }
    }
}
