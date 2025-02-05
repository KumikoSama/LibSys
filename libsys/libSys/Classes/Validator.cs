using ComponentFactory.Krypton.Toolkit;
using libSys.Properties;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibrarySystem.Classes
{
    public class Validator
    {
        static bool isValid = false;

        public static bool ValidateName(KryptonTextBox textBox, Label errorName)
        {
            string input = textBox.Text;

            try
            {
                if (string.IsNullOrEmpty(textBox.Text))
                    throw new FormatException();

                string[] inputParts = input.Split(' ');

                foreach (string part in inputParts)
                {
                    if (string.IsNullOrWhiteSpace(part))
                        continue;

                    if (part.All(char.IsLetter) && part.Length <= 15)
                    {
                        isValid = true;
                        ErrorTextBoxes(true, errorName, textBox);
                    }
                    else throw new FormatException();
                }
            }
            catch (FormatException)
            {
                isValid = false;
                ErrorTextBoxes(false, errorName, textBox);
            }
            return isValid;
        }

        public static bool ValidateGender(KryptonComboBox comboBox, Label errorGender)
        {
            string gender = comboBox.SelectedItem.ToString();

            try
            {
                if (!string.IsNullOrWhiteSpace(gender) && comboBox.Items.Contains(gender))
                {
                    return true;
                }
                else throw new FormatException();
            }
            catch (FormatException)
            {
                ErrorTextBoxes(false, errorGender);
                return false;
            }
        }

        public static bool ValidatePhoneNum(KryptonTextBox textBox, Label errorPhoneNum)
        {
            string phoneNum = textBox.Text;

            try
            {
                if (string.IsNullOrEmpty(textBox.Text))
                    throw new FormatException();

                string phonenumpattern = @"^\+?[1-9]\d{0,2}[-. ]?\(?\d{1,4}\)?[-. ]?\d{1,4}[-. ]?\d{1,9}$";

                if (Regex.IsMatch(phoneNum, phonenumpattern))
                {
                    ErrorTextBoxes(true, errorPhoneNum, textBox);
                    return true;
                }
                else throw new FormatException("Invalid phone number");
            }
            catch (FormatException)
            {
                ErrorTextBoxes(false, errorPhoneNum, textBox);
                return false;
            }
        }

        public static bool ValidateEmail(KryptonTextBox textBox, Label errorEmail)
        {
            string email = textBox.Text;

            try
            {
                if (string.IsNullOrEmpty(textBox.Text))
                    throw new FormatException();

                string emailpattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                if (string.IsNullOrEmpty(email))
                    throw new FormatException("Input cannot be empty.");

                if (Regex.IsMatch(email, emailpattern))
                {
                    ErrorTextBoxes(true, errorEmail, textBox);
                    return true;
                }
                else
                    throw new FormatException("Invalid email address");
            }
            catch (FormatException)
            {
                ErrorTextBoxes(false, errorEmail, textBox);
                return false;
            }
        }

        public static bool ValidatePassword(KryptonTextBox textBox, Label errorPassword)
        {
            string password = textBox.Text;

            try
            {
                if (string.IsNullOrEmpty(textBox.Text))
                    throw new FormatException();

                string passwordpattern = @"^(?=.*\d)[A-Za - z\d]{ 8,}$";

                if (string.IsNullOrEmpty(password))
                    throw new FormatException();

                if (Regex.IsMatch(password, passwordpattern))
                {
                    ErrorTextBoxes(true, errorPassword, textBox);
                    isValid = true;
                }
                else throw new FormatException();
            }
            catch (FormatException)
            {
                ErrorTextBoxes(false, errorPassword, textBox);
                isValid = false;
            }
            return isValid;
        }

        public static bool ValidateUsername(KryptonTextBox textBox, Label errorUsername)
        {
            string input = textBox.Text;

            try
            {
                if (string.IsNullOrEmpty(textBox.Text))
                    throw new FormatException();

                if (!string.IsNullOrEmpty(input) && input.Length >= 8)
                {
                    ErrorTextBoxes(true, errorUsername, textBox);
                    return true;
                }
                else throw new FormatException();
            }
            catch (FormatException)
            {
                ErrorTextBoxes(false, errorUsername, textBox);
                return false;
            }
        }

        public static bool ValidateAge(KryptonComboBox cmbbxage, Label errorAge)
        {
            string age = cmbbxage.SelectedItem.ToString();

            try
            {
                if (cmbbxage.Items.Contains(age))
                {
                    ErrorTextBoxes(true, errorAge);
                    return true;
                }
                else throw new FormatException();
            }
            catch (FormatException)
            {
                ErrorTextBoxes(false, errorAge);
                return false;
            }
        }

        public static bool ValidateCredentials(KryptonTextBox txtbxcontactmethod, KryptonTextBox txtbxpass, string query, Label errorContactMethod, Label errorPassword)
        {
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                string parsePass, parseContactMethod;
                
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ContactMethod", CurrentUser.ContactMethod);
                    cmd.Parameters.AddWithValue("@Password", CurrentUser.Password);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            parseContactMethod = reader.GetString(0);
                            parsePass = reader.GetString(1);

                            if (parsePass == CurrentUser.Password || parseContactMethod == CurrentUser.ContactMethod)
                            {
                                isValid = true;
                                ErrorTextBoxes(isValid, errorPassword, txtbxpass);
                                ErrorTextBoxes(isValid, errorContactMethod, txtbxcontactmethod);
                            }

                            if (parseContactMethod != CurrentUser.ContactMethod)
                            {
                                isValid = false;
                                ErrorTextBoxes(isValid, errorContactMethod, txtbxcontactmethod);
                            }
                            if (parsePass != CurrentUser.Password)
                            {
                                isValid = false;
                                ErrorTextBoxes(isValid, errorPassword, txtbxpass);
                            }
                        }
                        else
                        {
                            isValid = false;
                            ErrorTextBoxes(isValid, errorPassword, txtbxpass);
                            ErrorTextBoxes(isValid, errorContactMethod, txtbxcontactmethod);
                            SideForms.CustomMessageBox.ShowOK("No accounts matched.", "Error", Resources.information);
                        }
                    }
                    return isValid;
                }
            }
        }

        private static void ErrorTextBoxes(bool isValid, Label errorLabel, params KryptonTextBox[] control)
        {
            foreach (KryptonTextBox textBox in control)
            {
                if (isValid)
                {
                    errorLabel.Visible = false;
                    textBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(78, 36, 38);
                }
                else
                {
                    errorLabel.Visible = true;
                    textBox.StateCommon.Border.Color1 = System.Drawing.Color.Red;
                }
            }
        }

        public static string CapitalizeFirstLetter(string input)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(input.ToLower());
        }
    }
}
