using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new CADASTROEntities();
            var cli = new CLIENTE()
            {
                NomeCliente = "Wesley",
                Email = "wesley@gmail.com"
            };
            var cont1 = new CONTATO()
            {
                Tipo = "EMAIL",
                Contato1 = "wesley@gmail.com",
                CLIENTE = cli
            };
            var cont2 = new CONTATO()
            {
                Tipo = "TELEFONE",
                Contato1 = "9876-9876",
                CLIENTE = cli
            };
            db.CONTATOS.Add(cont1);
            db.CONTATOS.Add(cont2);
            db.SaveChanges();
            Console.WriteLine("Registros inseridos com sucesso");
            Console.ReadLine();
        }
    }
}
