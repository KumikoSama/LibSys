using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace LibrarySystem.Classes
{
    public static class LoadComboBox
    {
        public static void LoadCountryCodes(KryptonComboBox comboBoxCountries)
        {
            // Define country codes with names
            var countryCodes = new List<Country>
            {
                new Country { Name = "PHL", Code = "+63" },
                new Country { Name = "AFG", Code = "+93" },
                new Country { Name = "ARM", Code = "+374" },
                new Country { Name = "AZE", Code = "+994" },
                new Country { Name = "BGD", Code = "+880" },
                new Country { Name = "BHR", Code = "+973" },
                new Country { Name = "BRN", Code = "+673" },
                new Country { Name = "BTN", Code = "+975" },
                new Country { Name = "BLR", Code = "+375" },
                new Country { Name = "KHM", Code = "+855" },
                new Country { Name = "CHN", Code = "+86" },
                new Country { Name = "GEO", Code = "+995" },
                new Country { Name = "IND", Code = "+91" },
                new Country { Name = "IDN", Code = "+62" },
                new Country { Name = "IRQ", Code = "+964" },
                new Country { Name = "IRN", Code = "+98" },
                new Country { Name = "JOR", Code = "+962" },
                new Country { Name = "JPN", Code = "+81" },
                new Country { Name = "KEN", Code = "+254" },
                new Country { Name = "KGZ", Code = "+996" },
                new Country { Name = "KOR", Code = "+82" },
                new Country { Name = "KWT", Code = "+965" },
                new Country { Name = "KAZ", Code = "+7" },
                new Country { Name = "LAO", Code = "+856" },
                new Country { Name = "LBN", Code = "+961" },
                new Country { Name = "MYS", Code = "+60" },
                new Country { Name = "MDV", Code = "+960" },
                new Country { Name = "MNG", Code = "+976" },
                new Country { Name = "MMR", Code = "+95" },
                new Country { Name = "NPL", Code = "+977" },
                new Country { Name = "OMN", Code = "+968" },
                new Country { Name = "PAK", Code = "+92" },
                new Country { Name = "QAT", Code = "+974" },
                new Country { Name = "SAU", Code = "+966" },
                new Country { Name = "SGP", Code = "+65" },
                new Country { Name = "LKA", Code = "+94" },
                new Country { Name = "SYR", Code = "+963" },
                new Country { Name = "TJK", Code = "+992" },
                new Country { Name = "THA", Code = "+66" },
                new Country { Name = "TUR", Code = "+90" },
                new Country { Name = "TKM", Code = "+993" },
                new Country { Name = "ARE", Code = "+971" },
                new Country { Name = "UZB", Code = "+998" },
                new Country { Name = "VNM", Code = "+84" },
                new Country { Name = "YEM", Code = "+967" }
            };

            // Set the DataSource of the ComboBox
            comboBoxCountries.DataSource = countryCodes;
            comboBoxCountries.DisplayMember = "DisplayName"; // Property to display
            comboBoxCountries.ValueMember = "Code"; // Property to use as value
        }

        public static object Genres()
        {
            List<string> genre = new List<string>();

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ListOfGenres", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        genre.Add(reader["Genre"].ToString());
                    }
                }
            }
            return genre;
        }

        public static object Gender()
        {
            List<string> list = new List<string>
            {
                "Female",
                "Male",
                "Rather not say",
                "Others"
            };

            return list;
        }

        public static object ContactMethod()
        {
            List<string> list = new List<string>
            {
                "Email",
                "Phone Number"
            };

            return list;
        }
    }

    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string DisplayName => $"{Name} ({Code})";
    }
}
