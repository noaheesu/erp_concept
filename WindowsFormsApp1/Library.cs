using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Linq;

namespace WindowsFormsApp1
{
    public static class Uid
    {
        public static string UserId { get; set; }
    }

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
                        // If the login is successful, retrieve the user's ID
                        cmd.CommandText = "SELECT UID FROM User_Information WHERE Email = @Username";
                        Uid.UserId = cmd.ExecuteScalar().ToString();

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

        //To display picture
        public class DataGridViewImageColumnEx : DataGridViewImageColumn
        {
            public DataGridViewImageColumnEx()
            {
                CellTemplate = new DataGridViewImageCellEx();
            }
        }

        // To resize picture and display URL as image
        public class DataGridViewImageCellEx : DataGridViewImageCell
        {
            // Adjust the size of the image
            public int ImageWidth { get; set; } = 100;
            public int ImageHeight { get; set; } = 100;

            protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
            {
                if (value is string imageUrl)
                {
                    using (var webClient = new WebClient())
                    {
                        try
                        {
                            var imageBytes = webClient.DownloadData(imageUrl);
                            var image = Image.FromStream(new MemoryStream(imageBytes));

                            // Resize the image to fit the specified width and height
                            var resizedImage = ResizeImage(image, ImageWidth, ImageHeight);
                            return resizedImage;
                        }
                        catch (Exception)
                        {
                            // If there's an error downloading the image, return null or a placeholder image
                            return null; // Or return a placeholder image here
                        }
                    }
                }

                return base.GetFormattedValue(value, rowIndex, ref cellStyle, valueTypeConverter, formattedValueTypeConverter, context);
            }

            private Image ResizeImage(Image image, int width, int height)
            {
                var resizedImage = new Bitmap(width, height);
                using (var graphics = Graphics.FromImage(resizedImage))
                {
                    graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    graphics.DrawImage(image, 0, 0, width, height);
                }
                return resizedImage;
            }
        }

        public DataTable LoadProductData(DataGridView productData)
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(
                    "SELECT " +
                    "Picture, ProductName, SKU, Price, StockQuantity, Published, [Description], Categories, [Weight],[Length],Width, Height, CreateDate, ID    " +
                    "FROM Products "
                    //+ "WHERE UserId = @UID"
                    , connection);

                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                productData.Columns["CreateDate"].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss";

                /////////////////////////////////////
                // Remove existing image column (if any)
                var existingImageColumn = productData.Columns.OfType<DataGridViewImageColumnEx>().FirstOrDefault();
                if (existingImageColumn != null)
                {
                    productData.Columns.Remove(existingImageColumn);
                }

                // Create the custom image column
                var pictureColumn = new DataGridViewImageColumnEx
                {
                    DataPropertyName = "Picture",
                    HeaderText = "Picture",
                    Width = 100,
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                };

                // Insert the image column at the desired position
                productData.Columns.Insert(0, pictureColumn);
                /////////////////////////////////////

                productData.DataSource = dt;

                return dt;
            }
        }

        public DataTable LoadUserData(DataGridView grid)
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(
                    "SELECT " +
                    "Email, UserFirstName, UserLastName, Company, Address1, Address2, ZipPostalCode, City, Country, StateProvinceId, PhoneNumber, FaxNumber, Description, CreateDate ,CreatedBy , ModifyDate, ModifiedBy,UID " +
                    "FROM User_Information", connection);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                grid.Columns["ModifyDate"].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss";
                grid.DataSource = dt;

                return dt;
            }
        }

        //Use this instead of ref, need to return dv for RowFilter erarch name.
        public DataView LoadUserListData(ListView list)
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(
                    "SELECT " +
                    "Email, UserFirstName, UserLastName, Company, Address1, Address2, ZipPostalCode, City, Country, StateProvinceId, PhoneNumber, FaxNumber, Description, CreateDate, CreatedBy, ModifyDate, ModifiedBy, UID " +
                    "FROM User_Information", connection);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);

                list.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row["Email"].ToString());
                    item.SubItems.Add(row["UserFirstName"].ToString());
                    item.SubItems.Add(row["UserLastName"].ToString());
                    item.SubItems.Add(row["Company"].ToString());
                    item.SubItems.Add(row["Address1"].ToString());
                    item.SubItems.Add(row["Address2"].ToString());
                    item.SubItems.Add(row["ZipPostalCode"].ToString());
                    item.SubItems.Add(row["City"].ToString());
                    item.SubItems.Add(row["Country"].ToString());
                    item.SubItems.Add(row["StateProvinceId"].ToString());
                    item.SubItems.Add(row["PhoneNumber"].ToString());
                    item.SubItems.Add(row["FaxNumber"].ToString());
                    item.SubItems.Add(row["Description"].ToString());
                    item.SubItems.Add(row["CreateDate"].ToString());
                    item.SubItems.Add(row["CreatedBy"].ToString());
                    DateTime modifyDate;
                    if (DateTime.TryParse(row["ModifyDate"].ToString(), out modifyDate))
                    {
                        item.SubItems.Add(modifyDate.ToString("MM/dd/yyyy HH:mm"));
                    }
                    else
                    {
                        item.SubItems.Add("");
                    }
                    item.SubItems.Add(row["ModifiedBy"].ToString());
                    item.SubItems.Add(row["UID"].ToString());

                    list.Items.Add(item);
                }
                DataView dv = new DataView(dt);
                return dv;
            }
        }

        //public void LoadListData(ref ListView list)
        //{
        //    string connectionString = GetConnectionString();

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        SqlDataAdapter sqlDa = new SqlDataAdapter(
        //            "SELECT " +
        //            "Email, UserFirstName, UserLastName, Company, Address1, Address2, ZipPostalCode, City, Country, StateProvinceId, PhoneNumber, FaxNumber, Description, CreateDate, CreatedBy, ModifyDate, ModifiedBy, UID " +
        //            "FROM User_Information", connection);
        //        DataTable dt = new DataTable();
        //        sqlDa.Fill(dt);

        //        //dt.Columns.Add("UserFirstName");

        //        list.Items.Clear();

        //        foreach (DataRow row in dt.Rows)
        //        {
        //            ListViewItem item = new ListViewItem(row["Email"].ToString());
        //            item.SubItems.Add(row["UserFirstName"].ToString());
        //            item.SubItems.Add(row["UserLastName"].ToString());
        //            item.SubItems.Add(row["Company"].ToString());
        //            item.SubItems.Add(row["Address1"].ToString());
        //            item.SubItems.Add(row["Address2"].ToString());
        //            item.SubItems.Add(row["ZipPostalCode"].ToString());
        //            item.SubItems.Add(row["City"].ToString());
        //            item.SubItems.Add(row["Country"].ToString());
        //            item.SubItems.Add(row["StateProvinceId"].ToString());
        //            item.SubItems.Add(row["PhoneNumber"].ToString());
        //            item.SubItems.Add(row["FaxNumber"].ToString());
        //            item.SubItems.Add(row["Description"].ToString());
        //            item.SubItems.Add(row["CreateDate"].ToString());
        //            item.SubItems.Add(row["CreatedBy"].ToString());
        //            DateTime modifyDate;
        //            if (DateTime.TryParse(row["ModifyDate"].ToString(), out modifyDate))
        //            {
        //                item.SubItems.Add(modifyDate.ToString("MM/dd/yyyy HH:mm"));
        //            }
        //            else
        //            {
        //                item.SubItems.Add("");
        //            }
        //            item.SubItems.Add(row["ModifiedBy"].ToString());
        //            item.SubItems.Add(row["UID"].ToString());

        //            list.Items.Add(item);
        //        }
        //    }
        //}

        public DataTable LoadInvoiceData(DataGridView grid)
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(
                    "SELECT " +
                    "UserID, " +
                    "InvoiceNumber, " +
                    "ContactName, " +
                    "ServiceList, " +
                    "TotalAmount, " +
                    "PaymentStatus, " +
                    "PaymentDate, " +
                    "PaymentMethod, " +
                    "BillingAddress, " +
                    "BillingAddress2, " +
                    "ZipPostalCode, " +
                    "City, " +
                    "Country, " +
                    "StateProvinceId, " +
                    "PhoneNumber,  " +
                    "Note, " +
                    "InvoiceDate, " +
                    "DueDate, " +
                    "CreateDate, " +
                    "ModifyDate, " +
                    "ModifiedBy, " +
                    "ID " +
                    "FROM Invoice", connection);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                grid.Columns["ModifyDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
                grid.DataSource = dt;

                return dt;
            }
        }

        public void CountryList(ComboBox country)
        {
            List<string> countries = new List<string>()
                {
                    "Select country",
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
                "Select state", "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut",
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
                "Select creator", "User", "Admin", "Manager"
            };
            By.Items.AddRange(createdBy.ToArray());
        }

        public void ModifiedBy(ComboBox By)
        {
            List<string> modifiedBy = new List<string>()
            {
                "Select modifier", "Admin", "Manager"
            };
            By.Items.AddRange(modifiedBy.ToArray());
        }

        public void OpenForm<T>(Form form) where T : Form, new()
        {
            T openedForm = null;

            for (int i = 0; i < form.MdiChildren.Length; i++)
            {
                if (form.MdiChildren[i] is T && form.MdiChildren[i].Name == typeof(T).Name)
                {
                    openedForm = (T)form.MdiChildren[i];
                    openedForm.Focus();
                    openedForm.Activate();
                    openedForm.WindowState = FormWindowState.Normal;
                    break;
                }
            }

            if (openedForm == null)
            {
                openedForm = new T();
                openedForm.MdiParent = form;
                openedForm.Show();
            }
        }

        public void OpenUserGridView(Form form)
        {
            UserList userListForm = new UserList();
            userListForm.Show();
            userListForm.MdiParent = form;
        }

        public void OpenUserListView(Form form)
        {
            userListView userListForm = new userListView();
            userListForm.Show();
            userListForm.MdiParent = form;
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

        public int CheckExistInvoice(SqlCommand sqlCommand, string invoice)
        {
            sqlCommand.Parameters.Clear();

            sqlCommand.CommandText = "SELECT COUNT(*) FROM Invoice WHERE InvoiceNumber = @Invoice";
            sqlCommand.Parameters.AddWithValue("@Invoice", invoice);

            int checkInvoice = (int)sqlCommand.ExecuteScalar();
            return checkInvoice;
        }

        //public void OpenAccountInfo(Form form, string loginId)
        //{
        //    string connectionString = GetConnectionString();
        //    AccountInfo accountInfo = new AccountInfo();

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        connection.Open();

        //        string userName = loginId;

        //        cmd.CommandText = "SELECT UserFirstName, UserLastName, Company, PhoneNumber " +
        //            "FROM User_Information " +
        //            "WHERE Email = @Username";
        //        cmd.Parameters.AddWithValue("@Username", userName);

        //        cmd.Connection = connection;

        //        SqlDataReader reader = cmd.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            string firstName = reader["UserFirstName"].ToString();
        //            string lastName = reader["UserLastName"].ToString();
        //            string company = reader["Company"].ToString();
        //            string phone = reader["PhoneNumber"].ToString();

        //            accountInfo.FirstName = firstName;
        //            accountInfo.LastName = lastName;
        //            accountInfo.Email = loginId;
        //            accountInfo.Company = company;
        //            accountInfo.PhoneNumber = phone;
        //        }

        //        reader.Close();
        //    }
        //    accountInfo.Show();
        //    accountInfo.MdiParent = form;
        //}

        private AccountInfo accountInfo = null;

        public void OpenAccountInfo(Form form, string loginId)
        {
            if (accountInfo == null)
            {
                string connectionString = GetConnectionString();
                accountInfo = new AccountInfo();

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
                accountInfo.FormClosed += AccountInfo_FormClosed;
                accountInfo.MdiParent = form;
            }

            accountInfo.Show();
            accountInfo.Focus();
        }

        private void AccountInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            accountInfo = null;
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
                        "SET UserFirstName = @UserFirstName, UserLastName = @UserLastName, Company = @Company, PhoneNumber = @PhoneNumber " +
                        "WHERE Email = @Username";

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

        public void ResetSearch(TextBox fName, TextBox lName, TextBox zip, TextBox phone, TextBox company, TextBox state)
        {
            fName.Clear();
            lName.Clear();
            zip.Clear();
            phone.Clear();
            company.Clear();
            state.Clear();
        }
    }
}
