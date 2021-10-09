using System;

namespace Models
{
    public class User
    {
        public String userName { get; set; }
        public String password { get; set; }

        public User()
        {
            userName = "Admin";
            password = "Admin";
        }
    }
    
}