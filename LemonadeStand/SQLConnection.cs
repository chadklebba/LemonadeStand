using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LemonadeStand
{
    class SQLConnection
    {

        public SQLConnection()
        {
            
        }
        public void InsertHS(double totalProfit, string name)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server = DESKTOP-T1USI43; Database = LSHighscores; Trusted_Connection=true";
                conn.Open();
                SqlCommand insert = new SqlCommand("INSERT INTO High_Scores VALUES ('"+ totalProfit + "','" + name + "');", conn);
                insert.ExecuteScalar();
            }
        }

        public void DisplayHS()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                Console.Clear();
                Console.WriteLine("High Scores:" + "\n");
                conn.ConnectionString = "Server = DESKTOP-T1USI43; Database = LSHighscores; Trusted_Connection=true";
                conn.Open();
                using (SqlCommand command = new SqlCommand("SELECT TOP 10 Score, Player_Name FROM High_Scores ORDER BY Score DESC", conn))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var score = reader.GetDouble(0);
                        string name = reader.GetString(1);
                        Console.WriteLine("{0}   {1}", score, name);

                    }
              
                }
                Console.ReadLine();
            }
        }
    }
}
