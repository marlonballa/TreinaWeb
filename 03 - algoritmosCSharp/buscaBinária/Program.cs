
var buscaBinaria = new int[] {1,3,5,7,9,10,12,14,16,18};
var elementoQueSeraBuscado = 12;
var indiceBuscado = -1;

//Começamos o encontrando o elemento que fará a divisão em duas partes do array.
var indicePrimeiroItem = 0;
var indiceUltimoItem = buscaBinaria.Length - 1;

while ( indicePrimeiroItem <=  indiceUltimoItem)
{
    var metadeDoArray = (int)((indicePrimeiroItem + indiceUltimoItem)/2);

    if (buscaBinaria[metadeDoArray] == elementoQueSeraBuscado) 
    {
        indiceBuscado = metadeDoArray;
        Console.WriteLine($"O elemento buscado: {elementoQueSeraBuscado}, está no índice: { metadeDoArray }");
        break;
    } 
    else if ( buscaBinaria[metadeDoArray] < elementoQueSeraBuscado ) 
    {
        //Neste caso vamos descartar a primeira metade do array
        //Vamos dizer que o indicePrimeiroItem é igual ao valor de metadeDoArray 
        indicePrimeiroItem = metadeDoArray + 1;
    }
    else if ( buscaBinaria[metadeDoArray] > elementoQueSeraBuscado ) 
    {
        //Neste caso vamos descartar a primeira metade do array
        //Vamos dizer que o indiceUltimoItem é igual ao valor de metadeDoArray 
        indiceUltimoItem = metadeDoArray - 1; 
    }

    //Realizamos a adição de +1 e -1, pois o elemento do meio já foi verificado no primeiro IF, logo, não há necessidade de realizar uma nova verificação dele em outras estruturas de decisão.
}

if (indiceBuscado == -1) 
{
    Console.WriteLine($"O elemento: { elementoQueSeraBuscado } não está presente no array. ");
}