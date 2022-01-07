using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegacao
{
    // UI
    class Program
    {
        static void Main(string[] args)
        {
            var valor = 2500;
            // Injeção de dependência (DI) / Inversão de Controle (IoC)
            var pedido = new Pedido(new Cheque()); 
            pedido.Fechar(valor);
            Console.ReadLine();
        }
    }
}
