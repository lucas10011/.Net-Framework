using System;

namespace Delegacao
{
    // S.O.L.I.D.
    public class Pedido
    {
        // associação
        private FormaPagamento _forma;

        public void Fechar(double valor)
        {
            // delegação polimórfica
            // semelhante a um padrão State
            this._forma.Pagar(valor);
        }

        public Pedido(FormaPagamento forma)
        {
            // guardo internamente a forma de pagamento
            // que foi passada no construtor da classe
            // para que depois seja feita a delegação
            this._forma = forma;
        }
    }

    public abstract class FormaPagamento
    {
        public abstract void Pagar(double valor);
    }

    public class Boleto: FormaPagamento
    {
        public override void Pagar(double valor)
        {
            Console.WriteLine("Pago boleto no valor de " + valor);
        }
    }

    public class Cartao: FormaPagamento
    {
        public override void Pagar(double valor)
        {
            Console.WriteLine("Pago cartão no valor de " + valor);
        }
    }

    public class Cheque : FormaPagamento
    {
        public override void Pagar(double valor)
        {
            Console.WriteLine("Pago no cheque o valor de " + valor);
        }
    }


}
