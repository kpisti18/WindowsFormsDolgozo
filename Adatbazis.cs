using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsDolgozo
{
    internal class Adatbazis
    {
        MySqlConnection connection = null;
        MySqlCommand command = null;

        public Adatbazis(string host="localhost", string user="root", string password="", string database="dolgozok")//így alapértelmezetté tettük a konstruktor paramétereiben az adatbázis beállításokat
        {
            //kapcsolat előkészítése
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server=host;
            builder.Database=database;
            builder.UserID=user;
            builder.Password=password;

            connection = new MySqlConnection(builder.ConnectionString); //előkészítettük a kapcsolatot
            connection.Open(); //leteszteljük a kapcsolatot

            command = connection.CreateCommand(); //parancsokat ezzel hívjuk majd meg

            connection.Close(); //zárjuk le a kapcsolatot!!!
        }

        public List<Dolgozo> osszesDolgozo() //ezt a listát más osztályban is el kell majd érnem
        {
            List<Dolgozo> osszes = new List<Dolgozo>();
            command.CommandText = "SELECT `id`, `nev`, `szuletett`, `fizetes` FROM `dolgozo`;"; //meghívjuk a command-ot az osztályból

            connection.Open();
            try
            {
                using (MySqlDataReader dr = command.ExecuteReader()) //létrehozom az sql olvasását
                {
                    while (dr.Read())
                    {
                        //a GetUInt64 az az unsinged int 64
                        osszes.Add(new Dolgozo(dr.GetUInt64("id"), dr.GetString("nev"), dr.GetDateTime("szuletett"), dr.GetDecimal("fizetes")));
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();

            return osszes;
        }

        public void ujDolgozo(Dolgozo dolgozo) //új dolgozó létrehozásához
        {
            try
            {
                connection.Open();

                command.CommandText = $"INSERT INTO `dolgozo`(`id`, `nev`, `szuletett`, `fizetes`) VALUES (NULL, '{dolgozo.Nev}','{dolgozo.Szuletett.ToString("u")}','{dolgozo.Fizetes}')";

                command.ExecuteNonQuery(); // nem lekérdezést futtat le, ami a CommandText-ben van

                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        public void updateDolgozo(Dolgozo dolgozo) //új dolgozó adatainak frissítése
        {
            try
            {
                connection.Open();

                command.CommandText = $"UPDATE `dolgozo` SET `nev`='{dolgozo.Nev}',`szuletett`='{dolgozo.Szuletett.ToString("u")}',`fizetes`='{dolgozo.Fizetes.ToString()}' WHERE `id`='{dolgozo.Id}';";

                command.ExecuteNonQuery(); // nem lekérdezést futtat le, ami a CommandText-ben van

                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteDolgozo(Dolgozo dolgozo)
        {
            try
            {
                connection.Open();

                command.CommandText = $"DELETE FROM `dolgozo` WHERE `id`='{dolgozo.Id}'";

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
