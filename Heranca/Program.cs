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

//using Heranca;

//Pessoa p1 = new Pessoa();
//p1.nome = "Larissa";
//Console.WriteLine(p1.nome);

//PessoaFisica pF = new PessoaFisica();
//pF.nome = "Larissa";
//pF.cpf = "492.338.942-45";
//Console.WriteLine(pF.nome);
//Console.WriteLine(pF.cpf);

//PessoaJuridica pJ = new PessoaJuridica();
//pJ.nome = "Larissa";
//pJ.cnpj = "433.544.478.1414";
//Console.WriteLine(pJ.nome);
//Console.WriteLine(pJ.cnpj);

//-----------------------------------------------------------------------------------------------------------------------------

using Heranca.Carro;

Carro carro1 = new Carro();

CarroEletrico carroE = new CarroEletrico();

carro1.modelo = "Fusca";
carro1.marca = "Volkswagen";
carro1.quilometragem = 3000;

carroE.modelo = "Tesla Model S";
carroE.marca = "Tesla";
carroE.quilometragem = 1000;
carroE.bateria = 200;
carroE.tempoDeCarga = 50;

carroE.MostrarInformacoes();