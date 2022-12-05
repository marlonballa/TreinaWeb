using ContasBancarias;
using Personagens;

//O método "new" executa uma chamada ao método construtor da classe, para que seja possível instanciar um objeto.
//Instanciando um objeto da classe ContaBancaria.
//var primeiraConta = new ContaBancaria();
//Console.WriteLine(primeiraConta.InformacoesDaConta());

//var segundaConta = new ContaBancaria("102030", DateTime.Now, 1500);
//Console.WriteLine(segundaConta.InformacoesDaConta());

//O conjunto de valores informados para os atributos de uma classe é chamado de ESTADO.
//Cada alteração nas informações deste objeto, temos um novo Estado, por isso dizemos que o estado é mutável. 

/*
primeiraConta.NumeroConta = "0002";
primeiraConta.DataAberturaConta = DateTime.Today;
primeiraConta.SaldoConta = 0;
*/

/*
Console.WriteLine(primeiraConta.NumeroConta);
Console.WriteLine(primeiraConta.DataAberturaConta);
Console.WriteLine(primeiraConta.SaldoConta);
*/


/*
//Acessando a propriedade estática
Console.WriteLine(ContaBancaria.TaxaRendimentoPoupanca);
Console.WriteLine(ContaBancaria.CalcularRendimento(1000, 15).ToString("C"));
primeiraConta.RealizarEmprestimo(350);
*/

/*
var primeiroCliente = new ClienteBanco("Marlon Jean", "15915511199");
Console.WriteLine(primeiroCliente.InformacoesDoCliente());

//Acessando a informação de CPF
Console.WriteLine(primeiroCliente.CPFCliente);
//Alterando o CPF do Cliente
primeiroCliente.CPFCliente = "123.456.789-55";
Console.WriteLine(primeiroCliente.CPFCliente);
*/

//HERANÇA
var primeiroCavaleiro = new Cavaleiro("Bjornguid", 88);
var primeiroArqueiro = new Arqueiro("Trignort", 97); 

primeiroArqueiro.Atacar();
primeiroCavaleiro.Defender();

primeiroCavaleiro.Atacar();
primeiroArqueiro.Defender();
