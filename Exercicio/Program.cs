//### **1 - Criando uma Classe "Livro" e Instanciando um Objeto**

//Crie uma classe chamada `Livro` com os seguintes atributos:

//- `titulo` (tipo `string`)
//- `autor` (tipo `string`)
//- `paginas` (tipo `int`)

//Depois, instancie um objeto da classe `Livro`, atribua valores aos atributos e exiba as informações no console.

using System;
using Exercicio;

//Livro livro1 = new Livro();

//livro1.titulo = "A Branca de neve";
//livro1.paginas = 5;
//livro1.autor = "A moca que trabalha na dinsey";

//    Console.WriteLine($"Titulo:{livro1.titulo}, tem {livro1.paginas} paginas, e o nome do autor e {livro1.autor}");
//--------------------------------------------------------------------------------------------

//Crie uma classe chamada `Aluno` com os seguintes atributos:

//- `nome` (tipo `string`)
//- `idade` (tipo `int`)
//- `notaFinal` (tipo `double`)

//Depois, crie dois objetos da classe `Aluno`, atribua valores a eles e exiba os detalhes de ambos.

//Aluno informacao = new Aluno();

//informacao.nome = "Vinicius Moreira";
//informacao.idade = 18;
//informacao.notaFinal = 10;

//Aluno informacao2 = new Aluno();

//informacao2.nome = "Ana Clara";
//informacao2.idade = 18;
//informacao2.notaFinal = 10;

//Console.WriteLine($"Vinicius Moreira, tem {informacao.idade} anos e tirou {informacao.notaFinal}!!!");
//Console.WriteLine($"Ana Clara, tem {informacao2.idade} anos e tirou {informacao2.notaFinal}!!!");

//--------------------------------------------------------------------------------------------------------------------------------------------

//Crie uma classe chamada `Produto` com os seguintes atributos:

//- `nome` (tipo `string`)
//- `preco` (tipo `double`)
//- `quantidadeEmEstoque` (tipo `int`)

//Também crie o seguinte método:

//- `CalcularTotal` que retorna o total da `quantidadeEmEstoque` *  `preco`

//Depois, crie um objeto da classe `Produto`, altere os valores dos atributos e imprima as informações antes e depois da alteração, também imprima o resultado do método CalcularTotal.

//Produto calculo = new Produto();

//calculo.nome = "Camiseta";
//calculo.preco = 20.00;
//calculo.quantidadeEmEstoque = 10;

//calculo.calcularTotal();

//Console.WriteLine($"Vendo {calculo.nome}, o preco dela seria {calculo.preco}, com uma quantidade de {calculo.quantidadeEmEstoque} pecas. Calculando preco total de todas as pecas de {calculo.nome} ficaria no valor de R${calculo.calcularTotal()}");
//--------------------------------------------------------------------------------------------------------------------------------------------
//### **1. Classe ContaBancaria**

//Crie uma classe chamada `ContaBancaria` que tenha:

//-Um atributo privado `_saldo` (com valor padrão de 0).
//- Um método público `Depositar(double valor)`, que adiciona um valor ao saldo.
//- Um método público `Sacar(double valor)`, que subtrai um valor do saldo (se houver saldo suficiente).
//- Um método público `VerSaldo()`, que retorna o saldo atual.

//Crie um objeto dessa classe e faça algumas operações de depósito e saque.

ContaBancaria conta1  = new ContaBancaria();

conta1.Depositar(10);
Console.WriteLine(conta1.VerSaldo());
conta1.Sacar(5);
Console.WriteLine(conta1.VerSaldo()); 

//-------------------------------------------------------------------------------------------------------------------------------------------

//### **2. Classe Funcionario**

//Crie uma classe `Funcionario` com:

//-Um atributo privado `_salario`.
//- Métodos `SetSalario(valor)` e `GetSalario()`
//    - **SetSalario** → Modifica o salario com o valor fornecido pelo usuario
//    - **GetSalario** → Retorna o Salario

//Crie um objeto, defina um salário e exiba o valor usando `GetSalario()`.

Funcionario s1 = new Funcionario();


Console.WriteLine("Qual e seu salario?");
double salario = double.Parse(Console.ReadLine());
s1.SetSalario(salario);
Console.WriteLine(s1.GetSalario);


