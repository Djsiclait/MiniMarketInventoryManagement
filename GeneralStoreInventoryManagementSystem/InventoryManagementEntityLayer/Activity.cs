using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementEntityLayer
{
    public class Activity
    {
        private String username;
        private String description;
        private String type;
        private DateTime timestamp;

        public Activity()
        {

        }

        public Activity(String username, String description, String type)
        {
            this.username = username;
            this.description = description;
            this.type = type;
        }

        // Getters and Setters
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
    }
}
