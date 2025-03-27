using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Carro
    {
        //  Atributos
        public string marca;
        public string modelo;
        public int anoFabricacao;

        //  Metodos
       
        public void Andar() //O metodo da classe seria uma funcao, lembrando que pode fazer com retorno ou sem retorno.
        {
            Console.WriteLine("Carro esta andando!");
        }
        public void Parar()
        {
            Console.WriteLine("Carro esta parando!");
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Ano de fabricacao: {anoFabricacao}");
        }
    }

}
