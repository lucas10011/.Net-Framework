using System;

namespace Lambda
{
    public delegate void PagarNotify (double valor);
    public class Pedido
    {
        // PagarEvent é um ponteiro para um método e PagarNotify é o tipo de parametro que esse Ponteiro vai receber
        // forma de injetar código no meu framework
        // código da implementação vem de fora
        public event PagarNotify PagarEvent; // Vai me apontar para algum metodo que seja do msm tipo de PagarNotify, ou seja recebe um valor double
        public void Pagar(double valor)
        {
            //Na hora que for pagar ela chama o evento PagarEvent mas ele nao me diz como é que paga, ele ta chamando o ponteiro para um metodo
            // delegação
            //quando estou chamando esse metodo na vdd estaria chamando esse aqui no programcs new PagarNotify(PagarBoleto); ou a expressao lambda
            this.PagarEvent(valor);         
        }
    }
   
}
