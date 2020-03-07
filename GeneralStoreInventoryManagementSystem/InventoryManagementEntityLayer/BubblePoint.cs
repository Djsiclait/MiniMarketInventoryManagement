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
            private String username;
            private String logInDate;
            private String logInTime;
            private int seconds;

            #region Getters and Setters
            public string Username { get => username; set => username = value; }
            public string LogInDate { get => logInDate; set => logInDate = value; }
            public string LogInTime { get => logInTime; set => logInTime = value; }
            public int Seconds { get => seconds; set => seconds = value; }
            public decimal Minutes { get => seconds / 60; }
            #endregion
        }
    }
}
