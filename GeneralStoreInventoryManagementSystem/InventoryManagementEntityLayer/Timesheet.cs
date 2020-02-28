using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementEntityLayer
{
    namespace Timesheet
    {
        public class Timesheet
        {
            private String username;
            private String fullName;
            private int numberOfLogIns;
            private decimal averageMinutesPerSession;

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
