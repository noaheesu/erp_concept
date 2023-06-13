// Library.cs
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class Library
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["WinformDB"].ConnectionString;
        }

        public void ChangePw(TextBox email, TextBox existPw, TextBox newPw, TextBox confirmPw, Form form)
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string userName = email.Text;
                string password = existPw.Text;

                if (password == "")
                {
                    MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK);
                }
                if (password != "")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT COUNT(*) FROM User_Information WHERE Email = @Username AND Password = @Password";
                    cmd.Parameters.AddWithValue("@Username", userName);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        var newPwd = newPw.Text;
                        var confirmPwd = confirmPw.Text;

                        if (newPwd == confirmPwd && newPwd.Length > 2)
                        {
                            cmd.Parameters.AddWithValue("@newPwd", newPwd);
                            cmd.CommandText = "UPDATE User_Information SET Password = @newPwd WHERE Email = @Username AND Password = @Password";
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Password updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Home home = new Home();
                            //    AddOwnedForm(home);
                            home.Show();
                            form.Hide();
                        }
                        else
                        {
                            MessageBox.Show("New password does not match with confirm password or new password is less than 2 letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
        }

        public void LoginUser(TextBox loginId, TextBox pw, Form form)
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string userName = loginId.Text;
                string password = pw.Text;
                if (userName == "" && password == "" || password == "" || userName == "")
                {
                    MessageBox.Show("Please enter username and password", "Error", MessageBoxButtons.OK);
                }
                if (userName != "" && password != "")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT COUNT(*) FROM User_Information WHERE Email = @Username AND Password = @Password";
                    cmd.Parameters.AddWithValue("@Username", userName);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        Home home = new Home();
                        home.Show();
                        form.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
        }

        public DataTable LoadData(DataGridView grid)
        {
            string connectionString = Library.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(
                    "SELECT " +
                    "Email, UserFirstName, UserLastName, Company, Address1, Address2, ZipPostalCode, City, Country, StateProvinceId, PhoneNumber, FaxNumber, Description, CreateDate ,CreatedBy , ModifyDate, ModifiedBy " +
                    "FROM User_Information", connection);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                grid.Columns["ModifyDate"].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss";
                grid.DataSource = dt;

                return dt;
            }
        }

        public void CountryList(ComboBox country)
        {
            List<string> countries = new List<string>()
                {
                    "Select State",
                    "United States",
                    "China",
                    "Japan",
                    "Germany",
                    "United Kingdom",
                    "France",
                    "Italy",
                    "Canada",
                    "South Korea",
                    "Australia",
                    "Brazil",
                    "India",
                    "Russia",
                    "Mexico",
                    "Indonesia",
                    "Turkey",
                    "Netherlands",
                    "Switzerland",
                    "Sweden",
                    "Saudi Arabia"
                };
            country.Items.AddRange(countries.ToArray());
        }

        public void States(ComboBox state)
        {
            List<string> states = new List<string>()
            {
                "Select State", "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut",
                "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa",
                "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan",
                "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire",
                "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio",
                "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota",
                "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia",
                "Wisconsin", "Wyoming"
            };
            state.Items.AddRange(states.ToArray());
        }

        public void CreatedBy(ComboBox By)
        {
            List<string> createdBy = new List<string>()
            {
                "Select State", "Customer", "Admin", "Manager"
            };
            By.Items.AddRange(createdBy.ToArray());
        }

        public void ModifiedBy(ComboBox By)
        {
            List<string> modifiedBy = new List<string>()
            {
                "Select State", "Admin", "Manager"
            };
            By.Items.AddRange(modifiedBy.ToArray());
        }

        public void OpenCustomerListForm(Form form)
        {
            Customers customers = new Customers();
            customers.Show();
            form.Hide();

            CustomerList customerListForm = new CustomerList();
            customerListForm.Show();
            customerListForm.CustomerData();
            customerListForm.MdiParent = customers;
        }

        public void CapitalizeFirstLetter(TextBox textBox)
        {
            if (textBox.Text.Length <= 0) return;
            string s = textBox.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = textBox.SelectionStart;
                int curSelLength = textBox.SelectionLength;
                textBox.SelectionStart = 0;
                textBox.SelectionLength = 1;
                textBox.SelectedText = s.ToUpper();
                textBox.SelectionStart = curSelStart;
                textBox.SelectionLength = curSelLength;
            }
        }

        public void ComboBoxIndexChange(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex == 0)
            {
                comboBox.SelectedIndex = -1;
            }
        }

        public int CheckExistEmail(SqlCommand sqlCommand, string email)
        {
            sqlCommand.Parameters.Clear();

            sqlCommand.CommandText = "SELECT COUNT(*) FROM User_Information WHERE Email = @Email";
            sqlCommand.Parameters.AddWithValue("@Email", email);

            int checkEmail = (int)sqlCommand.ExecuteScalar();
            return checkEmail;
        }

        public void UserInfoDisplay(string loginId)
        {
            string connectionString = GetConnectionString();
            AccountInfo accountInfo = new AccountInfo();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                connection.Open();

                string userName = loginId;

                cmd.CommandText = "SELECT UserFirstName, UserLastName, Company, PhoneNumber " +
                    "FROM User_Information " +
                    "WHERE Email = @Username";
                cmd.Parameters.AddWithValue("@Username", userName);

                cmd.Connection = connection;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string firstName = reader["UserFirstName"].ToString();
                    string lastName = reader["UserLastName"].ToString();
                    string company = reader["Company"].ToString();
                    string phone = reader["PhoneNumber"].ToString();

                    accountInfo.FirstName = firstName;
                    accountInfo.LastName = lastName;
                    accountInfo.Email = loginId;
                    accountInfo.Company = company;
                    accountInfo.PhoneNumber = phone;
                }


                reader.Close();
            }
            accountInfo.Show();
        }

        public void UserInfoUpdate(string email, TextBox fName, TextBox lName, TextBox companyName, TextBox phoneNumber)
        {
            string connectionString = GetConnectionString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string userName = email;
                    string firstName = fName.Text;
                    string lastName = lName.Text;
                    string company = companyName.Text;
                    string phone = phoneNumber.Text;

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText =
                        "UPDATE User_Information " +
                        "SET UserFirstName = @UserFirstName, UserLastName = @UserLastName, Company = @Company, PhoneNumber = @PhoneNumber" +
                        "  WHERE Email = @Username";

                    cmd.Parameters.AddWithValue("@Username", userName);
                    cmd.Parameters.AddWithValue("@UserFirstName", firstName);
                    cmd.Parameters.AddWithValue("@UserLastName", lastName);
                    cmd.Parameters.AddWithValue("@Company", company);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phone);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Information updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the user information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
