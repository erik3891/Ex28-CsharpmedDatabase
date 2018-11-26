using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28_CsharpmedDatabase
{

        public class Menu
        {

            public void Show()
            {
                bool running = true;
                do
                {
                    ShowMenu();
                    string choice = GetUserChoice();
                    switch (choice)
                    {
                        case "0":
                            running = false;
                            break;
                        case "1":
                            InsurtPet();
                            break;
                        case "2":
                            Visallekæledyr();
                            break;
                        default:
                            Console.WriteLine("Ugyldigt valg.");
                            Console.ReadLine();
                            break;
                    }
                } while (running);
            }

            private void ShowMenu()
            {
                Console.WriteLine("Ex28");
                Console.WriteLine();
                Console.WriteLine("1. Insurt Pet");
                Console.WriteLine("2. Vis alle kæledyr");
                Console.WriteLine("");
                Console.WriteLine("0. Exit");
            }
        private string GetUserChoice()
        {
            Console.WriteLine();
            Console.Write("Indtast dit valg: ");
            return Console.ReadLine();
        }
        private string Visallekæledyr()
        {
            Console.WriteLine();
            Console.Write("Indtast dit valg: ");
            return Console.ReadLine();
        }
        private string InsurtPet()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=[Server:EALSQL1.eal.local]; Database=[[C_DB06_2018]];Trusted_Connection=true";
                // using the code here...
            }
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "connection_string";
            conn.Open();

            // use the connection here

            conn.Close();
            conn.Dipose();
            // remember, there is no method to flush a connection.
            Console.WriteLine();
            Console.Write("Indtast dit valg: ");
            return Console.ReadLine();
        }
    }
}
