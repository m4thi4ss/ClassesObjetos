// Heranca - Classe que herda de outra. Ele serve para que uma classe pegue os atributos e metodos de outra classe herdando essa classe. 

//Carro - Modelo, Marca, Quilometragem
//CarroEletrico - Bateria, TempoDeCarga
//CarroCombustao - Combustivel

//Por exemplo:

//using Heranca;

//CarroEletrico carroC = new CarroEletrico();
//carroC.marca = "Tesla";

//CarroCombustao carroE = new CarroCombustao();

//carroE.marca = "Fiat";

//Carro meuCarro;

//Console.WriteLine("Digite E - para Eletrico ou Digite C - para Combustao");
//string opcao = Console.ReadLine();

//if (opcao == "E")
//{
//    meuCarro = new CarroEletrico();
//}
//else
//{
//    meuCarro = new CarroCombustao();
//}

//--------------------------------------------------------------------------------------------------------------------

using Heranca;

Pessoa p1 = new Pessoa();
p1.nome = "Larissa";
Console.WriteLine(p1.nome);

PessoaFisica pF = new PessoaFisica();
pF.nome = "Larissa";
pF.cpf = "492.338.942-45";
Console.WriteLine(pF.nome);
Console.WriteLine(pF.cpf);

PessoaJuridica pJ = new PessoaJuridica();
pJ.nome = "Larissa";
pJ.cnpj = "433.544.478.1414";
Console.WriteLine(pJ.nome);
Console.WriteLine(pJ.cnpj);