using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNotificacao
{
    // UI
    class Program
    {
        // associação concreta
        //private static EMail email = new EMail();
        //private static SMS sms = new SMS();
        // associação para uma abstração
        private static INotificacao notificacao;
 
        static void Main(string[] args)
        {
            string Mensagem = "Ola Mundo";
            notificacao = new EMail();
            notificacao.Enviar(Mensagem); // delegação
            Console.ReadLine();
        }
    }
}
