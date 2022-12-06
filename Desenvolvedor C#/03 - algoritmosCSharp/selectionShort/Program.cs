
var selectionSort = new int[] {14,10,511,30,21, 63, 8, 5,3, 12, 15, 28};
int menor = 0;
for (int contExterno = 0; contExterno < selectionSort.Length; contExterno++)
{
    //O primeiro passo é assumir que o menor item é aquele da iteração atual
    //Para que seja possível fazer isso, logo na primeira iteração, devemos informar a variável menor o indice do array.
    menor = contExterno;

    for (int contInterno = contExterno + 1; contInterno < selectionSort.Length; contInterno++)
    {
        //Estamos comparando se o valor contido no laço interno é menor do que o que está contido no laço externo
        //Como assumimos que o primeiro valor é o menor, caso nesta comparação ele seja maior do que o valor seguinte, devemos informar o indice do menor valor para a variável "menor"
        if (selectionSort[contInterno] < selectionSort[menor])
        {
            menor = contInterno;
        }
    }

        //Verifica se houve alteração no valor da variável menor. 
        //Caso tenha acontecido, realiza a troca de posição dentro do array, colocando o menor valor a esquerda e o maior valor no lugar do outro. 

        if (menor != contExterno)
        {
            var armazenaContExterno = selectionSort[menor];
            selectionSort[menor] = selectionSort[contExterno];
            selectionSort[contExterno] = armazenaContExterno;
        }
}

//Imprime o resultado na tela 
for (int imprimeResultado = 0; imprimeResultado < selectionSort.Length; imprimeResultado++)
{
    Console.Write($"{ selectionSort[imprimeResultado]} ");
}