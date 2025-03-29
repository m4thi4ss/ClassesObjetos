using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Carro
{
    class CarroEletrico : Carro
    {
        public int bateria;
        public int tempoDeCarga;

        //override - Ele tem a mesma funcao que o virtual, so que usa ele somente para a classe filho
        public override void MostrarInformacoes()
        {
            //Base - ele pega a classe pai e traz com um resumo
            base.MostrarInformacoes();
            //Console.WriteLine("Modelo: " + modelo);
            //Console.WriteLine("Marca" + marca);
            //Console.WriteLine("Quilometragem" + quilometragem);
            Console.WriteLine("Bateria: " + bateria);
            Console.WriteLine("Tempo de carga: " + tempoDeCarga);
        }
    }
}
