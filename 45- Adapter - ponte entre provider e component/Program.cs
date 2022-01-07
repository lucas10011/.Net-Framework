using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // DataSet
using System.Data.SqlClient; // provider para o SQL Server

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            var constr = @"Data Source=(localdb)\ProjectsV12;Initial Catalog=CADASTRO;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            var con = new SqlConnection(constr);
            var SQL = "select * from CLIENTES";
            var cmd = new SqlCommand(SQL, con);
            var ds = new DataSet("CADASTRO");
            var da = new SqlDataAdapter(cmd);
            da.Fill(ds,"CLIENTES");
            var dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("ID Cliente: " + row[0].ToString());
                Console.WriteLine("Nome Cliente: " + row[1].ToString());
                Console.WriteLine("EMail: " + row[2].ToString());
            }
            dt.WriteXml("dados.xml");
            Console.ReadLine();
        }
    }
}
