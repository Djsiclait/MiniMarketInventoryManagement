using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementEntityLayer
{
    namespace GraphEssentials
    {
        public class BubblePoint
        {
            private String username; // Username of user requesting a session
            private String logInDate; // Date (excludint time) a session was requested
            private String logInTime; // Time (hour and minute) a session was requested
            private int seconds; // Total amount of seconds the user has completed after a successful session request

            #region Getters and Setters
            public string Username { get => username; set => username = value; }
            public string LogInDate { get => logInDate; set => logInDate = value; }
            public string LogInTime { get => logInTime; set => logInTime = value; }
            public int Seconds { get => seconds; set => seconds = value; }
            public decimal Minutes { get => seconds / 60; } // Function to convert the total seconds logged in into minutes
            #endregion
        }
    }
}
