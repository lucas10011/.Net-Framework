using System;

namespace Pedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido(new Cartao()); // injeto a dependência
            double valor = 2000;
            pedido.Pagar(valor);
            Console.ReadLine();
        }
    }
}
