//Listas
//string[] nomes = new string[5];

//Generico
using POO;

List<string> listaDeNomes = new List<string>(); //Codigo da lista completo 
List<string> listaDeNomes2 = new (); //Codigo da lista abreviado.


//Para adicionar nomes na lista so seguir o procedimento abaixo.
listaDeNomes.Add("Vinicio"); //listaDeNomes - Esse e o nome da lista; .Add - Aqui voce ta informando que vai ser adicionando uma informacao.
listaDeNomes.Add("Fulano");
listaDeNomes.Add("Cicrano");

//SOLICITANDO NO CONSOLE O NOMES QUE FORAM SOLICITADOS

foreach (var item in listaDeNomes)
{
    Console.WriteLine(item);
}

//Solicitando a retirada do Vinicio.

listaDeNomes.Remove("Vinicio");




// POO - Programcao Orientada a Objetos

// Programcao Etruturada 

// Objetivo da cricao do POO - Aproximar a Programacao do Mundo real e estava ficando muito grande os codigos quando foi criado era menores comecou a ficar muito grande e eles criaram a POO, para deixar os codigos em Partes menores

//Classes e Objetos 

//Classe - Definicao (item da vida real representado em codigo), toda classe pode ter atributos de um item fazendo com que faca uma modelagem do item que seria a classe mais precisa a vida real. Seria uma definicao explicando para o sistema o aquele item e e o que ele faz.
//Como pro exemplo um carro. Os ATRIBUTOS seria (caracteristicas) do item que vai ser informado na classe - METODOS (Acoes) Sao o que o item pode fazer,  lembrando que metodos sao funcoes.


//OBJETO - Instancia de uma classe (Seria uma informacao especifica da classe) Como por exemplo carro, e dentro da classe carro tem o HB20 cadastrado ele seria o objeto.

Carro carro  = new Carro(); //Aqui ele quer falar de algo especifo, criando um carro dentro da classe, essa criacao seria o objeto 

//pARA ACESSAR INFORMACOES DO oBJETO EU USO O "."
carro.modelo = "HB20";
carro.marca = "Hyundai";
carro.anoFabricacao = 2024;

carro.Andar();

carro.Parar();

//Crie mais 2 carros (Objetos)

Carro carro1 = new Carro(); // O Carro - Seria a classe. carro1 - Seria o objeto.

carro1.modelo = "Mobi";
carro1.marca = "Fiat";
carro1.anoFabricacao = 2020;

carro1.Andar();
carro1.Parar(); 

Carro carro2 = new Carro();

carro2.modelo = "Kwid";
carro2.marca = "renault";
carro2.anoFabricacao = 2025;

//Juncao de lista com class e objeto 

List<Carro> carros = new List<Carro>(); 

carros.Add(carro1);
carros.Add(carro2);
carros.Add(carro);

// 4 Pilares da POO

//Classe e Objeto
//Classe - Definicao (Molde)
//Objeto - Instancia da Classe 

//Ferramentas - Formas de Trabalho com POO

//Encapsulamento e Heranca

//Abstracao e Polimorfismo - Amanha

//Encapsulamento - Ele serve para esconder comprotamento e atributos, ele serve para esconder tudo aquilo que nao pode ser mechido e nem olhado. Ele serve tambem para esconder para que nada possa ser acessado diretamente 
//Por exemplo: Nas informacoes do carro, nao quero que mecha no nome dele ou otra informacao, voce cria o encapsulamento, para esconder as informacoes do objeto que voce quer que outra pessoa nao veja.
//Por exemplo2: 
//(Colocar o exemplo da conta e do saldo deposito)
//Conta Bancaria (Saldo)
//Sacar() - DEpositar() ppodem acessar o saldo

//conta.saldo = 300000;

//public - Que qualquer um pode acessar a aquela informacao, ele pode ser usado para atributos/metodo/classe.
//ex:  public string marca;

//private - Nem todo mundo pode acessar essa informacao que esta dentro desse objeto, podendo ser acessado somente dentro dele mesmo entrando dentro da classe e indo modificar la. usado nos atributos/metodo/classe. No private voce pode criar uma regra de como a pessoa vai mudar os atributos e pode esconder os atributos.Lembrando que e uma ferramenta em momentos necessarios. So e necessario colocar private no atributo, e no metodo so se for uma informacao que ninguem precisa saber, como o cambio do carro como ele funciona, precisa ter mas ninguem precisa saber
//Todo atributo privado comeca com sumblinhado "_"
//ex:  private string modelo;
//ex como mudar informacao: public void AlternarModelo( string mod ){
//if(mod == "Fiesta" || mod == "Hb20"){
//modelo = mod;
//}else{Console.WriteLine("Alteracao invalida")}}

//Protected/internal - Esse atributo/metodo/classe so pode ser acessado por ele mesmo e por sua classe pai

//Get e set - O set ele serve para mudar um nome de um metodo e atributos private e so um padrao para mostra que altera o campo privado, mas ele nao altera nada, so para mostrar que foi alterado, so pode usar o set se tiver regra se nao tiver nao precisa. E o Get ele serve para mostrar as informacao dos atributos que estao private.

//set 
//public void SetModelo(string mod)
//carro1.SerModelo("Hb20");

//get
//Console.WriteLine(carro1.GetModelo());
//public string GetModelo()
//{
//    return _modelo;
//}

