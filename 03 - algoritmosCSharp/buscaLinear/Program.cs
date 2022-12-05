static int BuscarItem(int[] array, int numeroBuscado) 
{
    for (int contador = 0; contador < array.Length; contador++) 
    {
        Console.WriteLine(contador);
        if (array[contador] == numeroBuscado)
        {
            return contador;
        }
    }
    return -1;
}

var numerosInteiros = new int[] {1, 2, 3, 4, 5};
var numeroBuscado = 6;

BuscarItem(numerosInteiros, numeroBuscado);