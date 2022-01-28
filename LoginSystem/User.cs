using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem
{
    internal class User
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
        public bool IsAdministrator { get; set; }

        public static List<User> users = new List<User>();
       
        
    }
}
