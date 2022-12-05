using Newtonsoft.Json;
using GerenciamentoDePacotescomNuGet;

var primeiroProduto = new Produto
{
    NomeProduto = "Notebook",
    QuantidadeProduto = 10,
    ValorProduto = 3000
};

//Vamos transformar essa instância da classe produto em uma string no formato JSON
var resultJson = JsonConvert.SerializeObject(primeiroProduto); 

Console.WriteLine(resultJson);

/*
    - Adicionar pacotes:
        dotnet add package nameOfPackage

    - Remover pacotes:
        dotnet remove package nameOfPackage
*/