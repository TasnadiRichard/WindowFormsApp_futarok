using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp_Futarok
{
    internal class Database
    {
        private MySqlConnection connection;
        private MySqlCommand command;

        public Database() 
        {
            MySqlConnectionStringBuilder futar = new MySqlConnectionStringBuilder();
            futar.Server = "localhost";
            futar.UserID = "root";
            futar.Password = "";
            futar.Database = "pizza";
            futar.CharacterSet = "utf8";

            connection = new MySqlConnection(futar.ConnectionString);
            command = connection.CreateCommand();
        }

        public void Lekeres(string fnev)
        {
            command.CommandText = "SELECT pizza.fazon FROM futar WHERE futar.fnev=@fnev";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@fnev", fnev);
            MySqlDataReader reader = command.ExecuteReader();
        }

        public void Modositas (int ftel, string fazon)
        {
            connection.Open();
            command.CommandText = "UPDATE `futar` SET `ftel` = ftel - @ftel WHERE `fazon` = @fazon";
            command.Parameters.AddWithValue("@ftel", ftel);
            command.Parameters.AddWithValue("@fazon", fazon);
            command.ExecuteNonQuery();
            connection.Close();
        }      
    }
}
