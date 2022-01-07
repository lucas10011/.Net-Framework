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
      // entrada de dados
      Console.WriteLine("Informe Nome do Cliente:");
      var NomeCliente = Console.ReadLine();
      Console.WriteLine("Informe EMail do Cliente:");
      var EMail = Console.ReadLine();
      // gravação dos dados
      var ConStr = ConfigurationManager.ConnectionStrings["CADASTRO"].ConnectionString;
      var con = new SqlConnection(ConStr);
      //var SQL = "insert into CLIENTES(NomeCliente,EMail) values (@NomeCliente,@EMail);";
      var SQL = "InsertCliente";
      var cmd = new SqlCommand(SQL, con);
      cmd.CommandType = CommandType.StoredProcedure;
      cmd.Parameters.AddWithValue("@NomeCliente", NomeCliente);
      cmd.Parameters.AddWithValue("@EMail", EMail);
      con.Open();
      try
      {
        cmd.ExecuteNonQuery();
        Console.WriteLine("Registro inserido com sucesso");
      }
      finally
      {
        con.Close();
      }


    }
  }
}
