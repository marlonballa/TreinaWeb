namespace Itens
{
    public interface IColecionavel
    {
        //Dentro de uma interface não temos a implementação de métodos, mas apenas a sua assinatura. 
        //Entende-se que todos os métodos em uma interface são públicos e por isso não é nbecessário colocar o modificador de acesso.
        //Quando uma classe herda métodos de uma interface, dizemos que ela está implementando a interface. 
        void Colecionar();
    }
}