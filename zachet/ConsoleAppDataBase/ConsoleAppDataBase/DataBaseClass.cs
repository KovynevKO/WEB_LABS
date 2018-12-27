using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDataBase
{
    class DataBaseClass
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public void SelectTown()
        {
            string sqlExpression = "SELECT * FROM cTown";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) 
                {

                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3));

                    while (reader.Read()) 
                    {
                        object id = reader.GetValue(0);
                        object name = reader.GetValue(1);
                        object adress = reader.GetValue(2);
                        object medcard = reader.GetValue(3);
                        Console.WriteLine("{0} \t{1} \t{2} \t{3}", id, name, adress, medcard);
                    }
                }

                reader.Close();
            }
        }

        public void SelectResidentType()
        {
            string sqlExpression = "SELECT * FROM cResidentType";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3));

                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object name = reader.GetValue(1);
                        object adress = reader.GetValue(2);
                        object medcard = reader.GetValue(3);
                        Console.WriteLine("{0} \t{1} \t{2} \t{3}", id, name, adress, medcard);
                    }
                }

                reader.Close();
            }

        }

        public void FirstQuery()
        {
            string sqlExpression = "SELECT * FROM dbo.cResidentType WHERE TownId = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3));

                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object name = reader.GetValue(1);
                        object adress = reader.GetValue(2);
                        object medcard = reader.GetValue(3);
                        Console.WriteLine("{0} \t{1} \t{2} \t{3}", id, name, adress, medcard);
                    }
                }

                reader.Close();
            }

        }

        public void SecondQuery()
        {
            string sqlExpression = "SELECT dbo.cTown.TownId, TownDate, dbo.cTown.Quantity, dbo.cResidentType.ResidentTypeId FROM dbo.cTown RIGHT JOIN dbo.cResidentType ON dbo.cTown.TownId = dbo.cResidentType.TownId WHERE dbo.cResidentType.ResidentTypeId = 1 ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3));

                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object name = reader.GetValue(1);
                        object adress = reader.GetValue(2);
                        object medcard = reader.GetValue(3);
                        Console.WriteLine("{0} \t{1} \t{2} \t{3}", id, name, adress, medcard);
                    }
                }

                reader.Close();
            }

        }

        public void ThirdQuery()
        {
            string sqlExpression = "SELECT dbo.cTown.TownId, dbo.cTown.Quantity, dbo.cResidentType.Name, dbo.cResidentType.Language FROM dbo.cTown RIGHT JOIN dbo.cResidentType ON dbo.cTown.TownId = dbo.cResidentType.TownId WHERE dbo.cTown.Quantity = 45000";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3));

                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object name = reader.GetValue(1);
                        object adress = reader.GetValue(2);
                        object medcard = reader.GetValue(3);
                        Console.WriteLine("{0} \t{1} \t{2} \t{3}", id, name, adress, medcard);
                    }
                }

                reader.Close();
            }

        }

        public void ForthQuery()
        {
            string sqlExpression = "SELECT TOP 1 WITH TIES dbo.cResidentType.Name, dbo.cResidentType.ResidentTypeId, dbo.cResidentType.Language, dbo.cTown.TownDate FROM dbo.cTown RIGHT JOIN dbo.cResidentType ON dbo.cTown.TownId = dbo.cResidentType.TownId ORDER BY dbo.cTown.TownDate";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3));

                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object name = reader.GetValue(1);
                        object adress = reader.GetValue(2);
                        object medcard = reader.GetValue(3);
                        Console.WriteLine("{0} \t{1} \t{2} \t{3}", id, name, adress, medcard);
                    }
                }

                reader.Close();
            }

        }
    }
}
