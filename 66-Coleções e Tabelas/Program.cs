using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploColecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            var alunos = new Hashtable();
            alunos.Add("1", "Guinther");
            alunos.Add("2", "Rudolfo");
            alunos.Add("3", "Wesley");
            alunos.Add("4", "Rodrigo");
            foreach (var aluno in alunos.Keys)
                Console.WriteLine(aluno);
            foreach (var aluno in alunos.Values)
                Console.WriteLine(aluno);
            foreach (DictionaryEntry aluno in alunos)
                Console.WriteLine(aluno.Key + " - " + aluno.Value);
            Console.WriteLine("Informe posição a ser lida:");
            string pos = Console.ReadLine();
            // int pos = Convert.ToInt32(str);
            if (alunos.ContainsKey(pos))
                Console.WriteLine("O valor para esta chave é: " + alunos[pos]);
            else
                Console.WriteLine("Não existe valor para esta chave");
            Console.WriteLine("Informe letra ou parte a pesquisar no nome:");
            string str = Console.ReadLine();
            var qry = from string aluno in alunos.Values
                      where aluno.Contains(str)
                      select aluno;
            foreach (string aluno in qry)
                Console.WriteLine(aluno);
        }
    }
}
