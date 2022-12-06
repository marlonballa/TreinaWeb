## Algoritmo de Busca Binária
    * Atua sobre uma lista ordenada
    * Divide o vetor sucessivamente em duas metades, para localizar em qual delas está o elemento buscado. 
        -> faz com que a quantidade de itens a percorrer caia pela metade, em cada iteração. 

    Buscando pelo elemento: 14

    1 2 3 4 5 6 7 8 | 9 10 11 12 13 14 15 16

        * Encontrando o meio do array acima:
            Índice do primeiro ítem (0) + Índice do último ítem (15)
            15 / 2 = 7.5 -> Vamos assumir como meio o próximo inteiro maior que 7.5, nesse caso 8

            14 = 8 ? -> A busca é encerrada
            14 < 8 ? -> A segunda parte é descartada
            14 > 8 ? -> A primeira parte é descartada (realizado)

    9 10 11 12 | 13 14 15 16

        * Encontrando o meio do array acima:
            Índice do primeiro ítem (8) + Índice do último ítem (15)
            23 / 2 = 11.5 -> Vamos assumir como meio o próximo inteiro maior que 11.5, nesse caso 12

            14 = 12 ? -> A busca é encerrada
            14 < 12 ? -> A segunda parte é descartada
            14 > 12 ? -> A primeira parte é descartada (realizado)

    13 14 | 15 16
    
        * Encontrando o meio do array acima:
            Índice do primeiro ítem (12) + Índice do último ítem (15)
            27 / 2 = 13.5 -> Vamos assumir como meio o próximo inteiro maior que 13.5, nesse caso 14

            14 = 14 ? -> A busca é encerrada (realizado)
            14 < 14 ? -> A segunda parte é descartada
            14 > 14 ? -> A primeira parte é descartada 
        
        * Ou seja, o elemento buscado está no índice 13