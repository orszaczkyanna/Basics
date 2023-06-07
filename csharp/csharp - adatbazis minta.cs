using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Minta_Console
{
    internal class Adatbazis
    {
        MySqlConnection connection = null;
        MySqlCommand cmd = null;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Clear();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "minta";

            connection = new MySqlConnection(sb.ConnectionString);

            try
            {
                connection.Open();
                cmd = connection.CreateCommand();
                connection.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
                connection.Close();
                Environment.Exit(0);
            }

        }   




        // --------------- Adatbázis műveletek ---------------


        // -- Select --
        public List<Valami> GetValamikLista()
        {
            List<Valami> valamik = new List<Valami>();
            cmd.CommandText = "SELECT id, nev, szam, datum FROM dolgok;";

            try
            {
                connection.Open();
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while(dr.Read())
                    {
                        Valami ujValami = new Valami(
                            dr.GetUInt32("id"),
                            dr.IsDBNull(dr.GetOrdinal("nev")) ? null : dr.GetString("nev"),
                            dr.IsDBNull(dr.GetOrdinal("szam")) ? 0 : dr.GetInt32("szam"),
                            dr.GetDateTime("datum")
                        );
                        valamik.Add( ujValami );
                    }
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
                connection.Close();
                Environment.Exit(0);
            }

            return valamik;
        }

        // -- Insert --
        public void InsertValami(Valami valami)
        {
            string datum = valami.Datum.ToString("yyyy-MM-dd");
            cmd.CommandText = $"INSERT INTO dolgok(id, nev, szam, datum) VALUES (NULL,'{valami.Nev}','{valami.Szam}','{datum}');";

            try
            {
                connection.Open();
                int affectedRows = cmd.ExecuteNonQuery();
                VegrehajtasEllenorzese(affectedRows, "hozzáadás");
                connection.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

        }

        // -- Update --
        // -- Delete --





        // --------------- Adatbázis műveletek ---------------


        // -- Select --

        cmd.CommandText = "SELECT id, nev, szam, datum FROM dolgok;";
        connection.Open();
        using (MySqlDataReader dr = cmd.ExecuteReader())
        {
            while(dr.Read()){}
        }
        connection.Close();

        // -- Insert --
        cmd.CommandText = $"INSERT INTO dolgok(id, nev, szam, datum) VALUES (NULL,'{valami.Nev}','{valami.Szam}','{datum}');";
        connection.Open();
        int affectedRows = cmd.ExecuteNonQuery();


        // -- Update --
        // -- Delete --


    }
}
