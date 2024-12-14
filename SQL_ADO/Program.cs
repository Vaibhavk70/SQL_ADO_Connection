using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace SQL_ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.Connection();
            Console.ReadLine();
        }

        static void Connection()
        {
            //string cs = "Data Source = LAPTOP-OUNKEU6V\\SQLEXPRESS; Initial Catalog = Student_db; Integrated security = true;";
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = null;
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        Console.WriteLine("Conncetion has been made successfully..");
                        
                    }
                }
            }
            catch(SqlException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
