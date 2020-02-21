using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementEntityLayer
{
    namespace Activity
    {
        public class Activity
        {
            private String username; // username of user currently in session
            private String description; // description of the activity
            private String type; // type of the activity
            private DateTime timestamp; // date and time of activity

            #region Constructors
            public Activity()
            {

            }

            public Activity(String username, String description, String type)
            {
                this.username = username;
                this.description = description;
                this.type = type;
            }
            #endregion

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

            public string Description
            {
                get
                {
                    return description;
                }

                set
                {
                    description = value;
                }
            }

            public string Type
            {
                get
                {
                    return type;
                }

                set
                {
                    type = value;
                }
            }

            public DateTime Timestamp
            {
                get
                {
                    return timestamp;
                }

                set
                {
                    timestamp = value;
                }
            }
            #endregion
        }
    }
}
