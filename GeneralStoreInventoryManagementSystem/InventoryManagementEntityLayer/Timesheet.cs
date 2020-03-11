using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementEntityLayer
{
    namespace ReportEssentials
    {
        public class Timesheet
        {
            private String username; // Username of logged in user
            private String fullName; // A combination of the user's firast and last name
            private int numberOfLogIns; // Number of times the user has logged inon a given period of time
            private decimal averageMinutesPerSession; // Average amount of minutes a user spends per session

            #region Getters and Setters
            public string Username
            {
                get
                {
                    return username;
                }

                set
                {
                    username = value;
                }
            }

            public string FullName
            {
                get
                {
                    return fullName;
                }

                set
                {
                    fullName = value;
                }
            }

            public int NumberOfLogIns
            {
                get
                {
                    return numberOfLogIns;
                }

                set
                {
                    numberOfLogIns = value;
                }
            }

            public decimal AverageMinutesPerSession
            {
                get
                {
                    return averageMinutesPerSession;
                }

                set
                {
                    averageMinutesPerSession = value;
                }
            }
            #endregion
        }
    }
}
