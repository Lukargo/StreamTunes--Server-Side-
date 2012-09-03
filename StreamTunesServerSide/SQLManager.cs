using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using MySql.Data.MySqlClient;


namespace StreamTunesServerSide
{
    public static class SQLManager
    {

        private static String ConnectionString { get; set; }
        public static String CurrentIP { get; set; }
        
        static SQLManager()
        {
            ConnectionString = "SERVER=SQL09.FREEMYSQL.NET;" +
                "DATABASE=streamtunes;" +
                "UID=lukargo;" +
                "PASSWORD=lovepigs;";

            EstablishCurrentIP();
        }

        public static void WriteCurrentIP()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = connection.CreateCommand();


                if (CheckForStoredIP())
                    command.CommandText = "UPDATE IP SET CurrentIP = @ip";
                else              
                    command.CommandText = "INSERT INTO IP Value(@ip)";

                MySqlParameter param = new MySqlParameter() { ParameterName = "@ip", Value = CurrentIP };
                command.Parameters.Add(param);
                connection.Open();
                command.ExecuteNonQuery();
            }
          
            //MySqlDataReader Reader;
            //Reader = command.ExecuteReader();
            /* while (Reader.Read())
             {
                 string thisrow = "";
                 for (int i = 0; i < Reader.FieldCount; i++)
                     thisrow += Reader.GetValue(i).ToString() + ",";
                 listBox1.Items.Add(thisrow);
             }*/
            
        }

        private static bool CheckForStoredIP()
        {

            String ip;
            
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT CurrentIP FROM IP";
                connection.Open();
                ip = command.ExecuteScalar().ToString();
            }

            if (ip == null)
                return false;

            return true;

        }

        private static void EstablishCurrentIP()
        {
            String ip;
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            {

                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    ip = stream.ReadToEnd();
                }

            }

            int first = ip.IndexOf("Address: ") + 9;
            int last = ip.LastIndexOf("</body>");
            ip = ip.Substring(first, last - first);

            CurrentIP = ip;

        }
    }
}
