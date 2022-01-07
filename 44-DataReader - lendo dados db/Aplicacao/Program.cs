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
        //var SQL = "select [IdCliente], [NomeCliente], [EMail] from [CLIENTES]";
        var cmd = con.CreateCommand();
        cmd.CommandText = "SelectClientesProdutos";
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        // SqlDataReader = read-only, forward-only, sem cache
        var dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        // varredura no data reader
        Console.WriteLine("LISTAGEM DE CLIENTES");
        Console.WriteLine("-----------------------------------");
        while (dr.Read())
        {
          Console.WriteLine("ID: " + dr[0].ToString());
          Console.WriteLine("Nome: " + dr[1].ToString());
          Console.WriteLine("EMail: " + dr[2].ToString());
          Console.WriteLine("-----------------------------------");
        }
        dr.NextResult(); // posiciona leitor no próximo result set
        Console.WriteLine("LISTAGEM DE PRODUTOS");
        Console.WriteLine("-----------------------------------");
        while (dr.Read())
        {
          Console.WriteLine("ID: " + dr[0].ToString());
          Console.WriteLine("NomeProduto: " + dr[1].ToString());
          Console.WriteLine("-----------------------------------");
        }
        dr.Close();
      }
    }
  }
}
