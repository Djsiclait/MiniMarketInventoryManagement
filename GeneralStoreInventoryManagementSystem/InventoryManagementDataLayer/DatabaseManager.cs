using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementDataLayer
{
    public static class DatabaseManager
    {
        // Data source to locate database and retrieve/transmit information
        private static string dataSource =
            "Data Source=" + System.Environment.MachineName + // Username of PC Owner
            ";Initial Catalog=DBGENERALSTORE" + // Database where everythiing can be found and stored
            ";User id=generalstoremanager" + // user profile used to access the database
            ";password=admin"; // password for the user profile

        // Database connector to store and fetch data
        private static SqlConnection activeSqlConnection = new SqlConnection(dataSource);
        
        /// <summary>
        /// Function used to establish an active connection with the database
        /// </summary>
        private static void ConnectToDatabase()
        {
            // If any previous function had any use of this connect, this will close the unattended connetion
            if (activeSqlConnection.State == ConnectionState.Open)
                DisconnectToDatabase();

            activeSqlConnection.Open();
        }

        /// <summary>
        /// Function used to end an active connection with the database
        /// </summary>
        public static void DisconnectToDatabase()
        {
            activeSqlConnection.Close();
        }

        // Getter to the active connection variable
        public static SqlConnection ActiveSqlConnection
        {
            get
            {
                ConnectToDatabase(); // opening an active connection before hand

                return activeSqlConnection; // returns an opened active connection
            }
        }
    }
}
