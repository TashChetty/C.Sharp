using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MyMyDBConnection
{
    public static class dbcon
    {
        static string connectionstring = "server=localhost;port=3306;uid=ifundiuser;" +
        "pwd=Belle123#; database=ifundi; charset=utf8; sslmode=none;";

        static MySqlConnection conn = new MySqlConnection(connectionstring);

        public static void Main(string[] args)
        {
            Console.WriteLine("Connect to MySql Database. \n");
            using (conn)
            {
                try
                {
                    conn.Open();
                    MySqlCommand command =  conn.CreateCommand();
                    command.CommandType=System.Data.CommandType.Text;
                    command.CommandText="Select * from customer";

                    MySqlDataReader reader = command.ExecuteReader();
                
                    var data=""; 
                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            data = data + reader.GetString(0) + "\t" + reader.GetString(0) + "\t" + reader.GetString(0) + "\t" + reader.GetString(0);
                        }
                        Console.WriteLine(data);
                    }
                    else{
                    Console.WriteLine("No records found in the table");
                    }
                    conn.Close();
                    System.Console.WriteLine("Connection is : " + conn.State.ToString() + Environment.NewLine);
                }catch(MySql.Data.MySqlClient.MySqlException ex){
                    System.Console.WriteLine("Error: " + ex.Message.ToString());
                }finally {
                    System.Console.WriteLine("Press any key to Exit...");
                    Console.ReadKey();
                }
            }
        }
    }
}