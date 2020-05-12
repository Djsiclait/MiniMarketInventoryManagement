using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementEntityLayer
{
    namespace Error
    {
        public class Error
        {
            // Fields
            private String code;
            private String username;
            private String description;
            private DateTime timestamp;

            // Constructors 
            public Error()
            {

            }

            public Error(String code, String description, String username)
            {
                this.code = code;
                this.description = description;
                this.username = username;
            }

            // Getters and Setters
            public string Code { get => code; set => code = value; }
            public string Username { get => username; set => username = value; }
            public string Description { get => description; set => description = value; }
            public DateTime Timestamp { get => timestamp; set => timestamp = value; }
        }
    }
}
