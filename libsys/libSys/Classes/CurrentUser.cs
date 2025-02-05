using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Classes
{
    public static class CurrentUser
    {
        public static string ContactMethod { get; set; }
        public static string Password { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }
        public static int UserID { get; set; }
    }
}
