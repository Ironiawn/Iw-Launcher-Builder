using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace IwLauncher_Builder
{
    public static class IwConnector
    {
        static string svr_psw = "DB_PW";
        static string svr_dba = "DB_NAME";
        static string svr_usr = "DB_USER";
        static string svr = "DB_HOST";

       static MySqlConnection connection = new MySqlConnection($"server={svr};uid={svr_usr};password={svr_psw};database={svr_dba}");

        /// <summary>
        /// Request a determined value through the server
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string RequireValue(string value)
        {
            try
            {
                // Create a temporary string that will hold the readed value
                string t = "";

                // Connects to the database
                connection.Open();

                // Execute REQUEST command
                var cmd = new MySqlCommand($"SELECT * FROM USERS WHERE EMAIL='{IwMemoryVariables.Usermail.ToLower()}'", connection);

                // Create a datareader to read the value
                MySqlDataReader rdr = cmd.ExecuteReader();

                // Read the acquired value
                while (rdr.Read())
                    // Sets the value to the 't' var
                    t = rdr.GetString(value);

                // Closes the connection
                connection.Close();                

                // Return the acquired value
                return t;
            }
            catch
            {
                // Close the DB connection
                connection.Close();

                // Shows a error message
                MessageBox.Show($"Error while connecting to the Ironiawn Servers!\nTry Again later.", "IwLauncher Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        /// <summary>
        /// Verify if the provided ACP key is valid
        /// </summary>
        /// <param name="key">Given key</param>
        /// <returns></returns>
        public static bool ValidACPKey(string key)
        {
            try
            {
                // Create a temporary bool that will hold the readed value
                bool bt = true;

                // Connects to the database
                connection.Open();

                // Execute REQUEST command
                var cmd = new MySqlCommand($"SELECT * FROM PRODUCTS WHERE ACPKEY='{key.ToUpper()}'", connection);

                // Create a datareader to read the value
                MySqlDataReader rdr = cmd.ExecuteReader();

                // Verify if the current logged in user is the holder of the key
                while(rdr.Read())
                {
                    // Verify the holder
                    if ((string)rdr["USERADMIN"] != IwMemoryVariables.ProjectBuilder)
                        // Invalidate the key
                        bt = false;
                }

                // Closes the connection
                connection.Close();

                // Return the acquired value
                return bt;

            }
            catch
            {
                // Returns false value, error while connecting
                return false;
            }
        }
    }
}
