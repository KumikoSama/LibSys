using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class GlobalConfig
    {
        public static string ConnectionString { get; } = "Data Source=DESKTOP-LIDTB5Q;Initial Catalog=LibrarySystemDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
    }
}
