using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 2500;
            var pedido = new Pedido();
            //Pedido eu sei que vc tem um evento que vc vai chamar pois vc é um ponteiro, e pra qm vc vai apontar esse evento
            // pedido.PagarEvent += new PagarNotify(PagarBoleto);
            pedido.PagarEvent += v => Console.WriteLine("Pago no cartão valor de " + v);
            pedido.Pagar(valor);
            Console.ReadLine();
        }

        //public static void PagarBoleto(double valor)
        //{
        //    Console.WriteLine("Pago no boleto valor de " + valor);
        //}
      
    }
}
