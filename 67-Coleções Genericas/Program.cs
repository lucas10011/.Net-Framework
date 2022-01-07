using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExemploColecoes
{
    public class Aluno
    {
        public int Matricula;
        public string Nome;
        public string Curso;
        public override string ToString()
        {
            return Matricula.ToString() + " - " + Nome + " - " + Curso;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var alunos = new List<Aluno>();
            // adiciona objetos, mas do tipo Aluno
            alunos.Add(new Aluno(){ Matricula = 1, Nome = "Rodrigo", Curso = "CC"});
            alunos.Add(new Aluno(){ Matricula = 2, Nome = "Rudolfo", Curso = "SI"});
            alunos.Add(new Aluno(){ Matricula = 3, Nome = "Guinther", Curso = "CC"});
            alunos.Add(new Aluno() { Matricula = 4, Nome = "Wesley", Curso = "SI" });
            foreach (Aluno aluno in alunos) // recebe um tipo aluno, não Object
                Console.WriteLine(aluno);
            Console.WriteLine("Informe curso (CC ou SI)");
            string curso = Console.ReadLine();
            var qry = from aluno in alunos
                      where aluno.Curso == curso
                      select aluno;
            foreach (Aluno aluno in qry)
                Console.WriteLine(aluno);
        }

        private static void ExemploArrayList()
        {
            var alunos = new ArrayList();
            alunos.Add(1);
            alunos.Add("Guinther");
            alunos.Add(new SqlConnection()); // coloca um object (qualquer coisa)
            foreach (var item in alunos)
                Console.WriteLine(item);
            var obj = alunos[2]; // retira *sempre* um object
            // necessário typecast ou reflexão
            if (obj is SqlConnection)
                (obj as SqlConnection).Open();
        }
    }
}
