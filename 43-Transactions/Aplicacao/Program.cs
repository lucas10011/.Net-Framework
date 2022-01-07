/*
Sobre o autor:
Guinther Pauli
Cursos Treinamentos Consultoria
Delphi Certified Professional - 3,5,6,7,2005,2006,Delphi Web,Kylix,XE
Microsoft Certified Professional - MCP,MCAD,MCSD.NET,MCTS,MCPD (C#, ASP.NET, Arquitetura)
Colaborador Editorial Revistas .net Magazine e ClubeDelphi
MVP (Most Valuable Professional)
Emails: guintherpauli@gmail.com / guinther@gpauli.com
http://www.gpauli.com
http://www.guintherpauli.blogspot.com.br
http://www.facebook.com/guintherpauli
http://www.twitter.com/guintherpauli
http://br.linkedin.com/in/guintherpauli
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Aplicacao
{
  class Program
  {
    static void Main(string[] args)
    {
      var ConStr = ConfigurationManager.ConnectionStrings["CADASTRO"].ConnectionString;
      using (var con = new SqlConnection(ConStr))
      {
        con.Open();
        var trans = con.BeginTransaction();
        try
        {
          //var sql1 = "insert into CLIENTES(NomeCliente,EMail) values (@NomeCliente,@EMail);";
          var sql1 = "delete CLIENTES where IDCliente=1003";
          var sql2 = "insert into CLIENTES(NomeCliente) values (@NomeCliente);";
          var cmd1 = con.CreateCommand();
          cmd1.CommandText = sql1;
          cmd1.Transaction = trans;
          var cmd2 = con.CreateCommand();
          cmd2.CommandText = sql2;
          cmd2.Transaction = trans;
          cmd2.Parameters.AddWithValue("@NomeCliente", "José3");
          //cmd1.Parameters.AddWithValue("@EMail", "jose@gmail.com");
          // exectuados em uma única transação
          cmd1.ExecuteNonQuery();
          cmd2.ExecuteNonQuery();
          // efetiva operações no BD
          trans.Commit();
          Console.WriteLine("Comandos executados com sucesso");
        }
        catch (Exception E)
        {
          trans.Rollback();
          Console.WriteLine("Erro ao executar transação");
          Console.WriteLine(E.GetType());
          Console.WriteLine(E.Message);
        }
      }
    }
  }
}
