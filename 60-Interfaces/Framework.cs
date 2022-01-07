using System;

namespace SistemaNotificacao
{
    public interface INotificacao
    {
        void Enviar(string Mensagem);
    }

    public abstract class Notificacao: INotificacao
    {
        public abstract void Enviar(string Mensagem);
    }

    public class EMail : Notificacao, INotificacao
    {
        public override void Enviar(string Mensagem)
        {
            Console.WriteLine("Enviando EMAIL: " + Mensagem);
        }
    }

    public class SMS : Notificacao, INotificacao
    {
        public override void Enviar(string Mensagem)
        {
            Console.WriteLine("Enviando SMS: " + Mensagem);
        }
    }

    public class Pessoa
    {
        public string Nome;
    }

    public class Funcionario : Pessoa, INotificacao
    {
        public void Enviar(string Mensagem)
        {
            Console.WriteLine("Pessoa está notificando: " + Mensagem);
        }
    }

}
