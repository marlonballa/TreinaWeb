using System;
using System.Linq;
using System.Collections.Generic;

namespace RealizandoConsultasLINQComQuerySintax
{
    class Program
    {

        /* ESTE CÓDIGO FOI UTILIZADO PARA EXPLICAR CONSULTAS LINQ, UTILIZANDO FILTROS.
        private static List<Despesa> despesas = new List<Despesa>
        {
            new Despesa { Descricao = "Internet", Valor = 100, Vencimento = new DateTime(2022, 12, 10)},
            new Despesa { Descricao = "Celular", Valor = 80, Vencimento = new DateTime(2022, 12, 9)},
            new Despesa { Descricao = "Energia Elétrica", Valor = 250, Vencimento = new DateTime(2022, 12, 15)},
            new Despesa { Descricao = "Água", Valor = 35, Vencimento = new DateTime(2022, 12, 5)},
            new Despesa { Descricao = "Aluguel", Valor = 400, Vencimento = new DateTime(2022, 12, 1)},
            new Despesa { Descricao = "Vivo", Valor = 57, Vencimento = new DateTime(2022, 12, 25)},
            new Despesa { Descricao = "Mercado", Valor = 580, Vencimento = new DateTime(2022, 12, 18)},
            new Despesa { Descricao = "Ratinho Lanches", Valor = 625, Vencimento = new DateTime(2022, 12, 23)},
            new Despesa { Descricao = "Prepara Cursos", Valor = 400, Vencimento = new DateTime(2022, 12, 30)}

        };

        static void Main(string[] args)
        {
            //Estamos realizando uma consulta no objeto local "despesas", que visa retornar aquelas que já estão vencidas

            //desp -> Variável de interação
            //despesas -> Fonte de dados
            //select -> forma de retorno
            var despesasVencidas = from desp in despesas
                                    //Adicionando filtros
                                    //Condição que deve ser atendida por todo registro "desp", para que seja retornado
                                    //Condição booleana
                                   where desp.Valor < 50 || desp.Valor >= 250
                                   //Podemos realizar a ordenação dos dados que serão retornados
                                   orderby desp.Valor ascending, desp.Vencimento descending
                                   select desp;

                                   ** Caso queira retornar apenas colunas específicas, basta no select fazermos:
                                    select desp.Descricao;
                                        * Retorna apenas a descrição da despesa. 

                                        * Criamos um objeto dinâmico que contém apenas duas propriedades do objeto original. 

                                    select new {
                                        desp.Descricao,
                                        desp.Valor
                                    }

                                        * Podemos também acrescentar informações, desde que sejam baseadas nas colunas existentes. 

                                    select new {
                                        desp.Descricao,
                                        valorComDesconto = desp.Valor * 0.9
                                    }

            foreach (var desp in despesasVencidas)
            {
                Console.WriteLine(desp);
            }
        }
            */

        public static List<Produto> produtos = new List<Produto>
        {
            new Produto { Nome = "Notebook", Preco = 7500, Categoria = "Informática"},
            new Produto { Nome = "Monitor", Preco = 2000, Categoria = "Informática"},
            new Produto { Nome = "Calculadora Científica", Preco = 250, Categoria = "Material Escolar"},
            new Produto { Nome = "Caderno Escolar", Preco = 10, Categoria = "Material Escolar"},
            new Produto { Nome = "Mochila infantil", Preco = 260.33, Categoria = "Material Escolar"},
            new Produto { Nome = "Salgadinho ElmaChips", Preco = 5.20, Categoria = "Alimentação"},
            new Produto { Nome = "Luminária Led", Preco = 122.99, Categoria = "Decoração"},
            new Produto { Nome = "Kombi Decorativa", Preco = 250.90, Categoria = "Decoração"},
            new Produto { Nome = "Ratatouile Action Figure", Preco = 2753.66, Categoria = "Decoração"},
            new Produto { Nome = "SmartTv Samsung", Preco = 4758.60, Categoria = "Informática"},
        };


        private static List<Promocao> promocoes = new List<Promocao>
        {
            new Promocao { Categoria = "Informática", Desconto = 10},
            new Promocao { Categoria = "Decoração", Desconto = 33},
            new Promocao { Categoria = "Alimentação", Desconto = 50},
            new Promocao { Categoria = "Material Escolar", Desconto = 8},

        };

        /*
            Podemos realizar consultas entre diferentes coleções de dados e unir os valores de cada uma delas,
            atráves de um valor em comum existente nas duas. 

            from var1 in colecao1
            join var2 in colecao2 on var1.Propriedade equals var2.Propriedade
            select...
        */

        static void Main(string[] args)
        {
            var resultado = from produto in produtos
                            join promocao in promocoes on produto.Categoria equals promocao.Categoria
                            select new {
                                produto.Nome,
                                produto.Categoria,
                                valorComDesconto = (produto.Preco*(1 - promocao.Desconto/100)).ToString("C")
                            };
                            //Criamos um objeto dinâmico acima
            foreach (var prodDesc in resultado) 
            {
                Console.WriteLine($"{prodDesc.Nome} - {prodDesc.Categoria} - {prodDesc.valorComDesconto}");
            }
        }
    }
}
