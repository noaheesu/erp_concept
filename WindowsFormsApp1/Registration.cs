using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Registration : Form
    {
        #region Fields and Properties
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["WinformDB"].ConnectionString;
        public Library library = new Library();
        #endregion Fields and Properties

        #region Constructor and Disposer
        public Registration()
        {
            InitializeComponent();

            library.CountryList(country);
            country.SelectedIndexChanged += country_SelectedIndexChanged;

            library.States(state);
            state.SelectedIndexChanged += state_SelectedIndexChanged;
        }
        #endregion Constructor and Disposer

        #region Private Method
        private void CreateNewUser()
        {
            string password1 = confirmPassword.Text;
            string password2 = password.Text;

            if (string.IsNullOrEmpty(firstName.Text))
            {
                MessageBox.Show("Please enter first name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                firstName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(lastName.Text))
            {
                MessageBox.Show("Please enter last name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lastName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(email.Text))
            {
                MessageBox.Show("Please enter email address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                email.Focus();
                return;
            }
            if (string.IsNullOrEmpty(address1.Text))
            {
                MessageBox.Show("Please enter address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                address1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(postalCode.Text))
            {
                MessageBox.Show("Please enter zip/postalCode.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                postalCode.Focus();
                return;
            }
            if (string.IsNullOrEmpty(city.Text))
            {
                MessageBox.Show("Please enter city.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                city.Focus();
                return;
            }
            if (string.IsNullOrEmpty(phone.Text))
            {
                MessageBox.Show("Please enter phone number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phone.Focus();
                return;
            }
            if (privacyPolicy.Checked != true)
            {
                MessageBox.Show("Please read and check the Privacy Policy.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password1 == password2 && password1 != "")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string firstName = this.firstName.Text;
                    string lastName = this.lastName.Text;
                    string email = this.email.Text;
                    string companyName = this.company.Text;
                    string streetAddress1 = this.address1.Text;
                    string streetAddress2 = this.address2.Text;
                    string zipCode = this.postalCode.Text;
                    string city = this.city.Text;
                    string country = this.country.Text;
                    string state = this.state.Text;
                    string phone = this.phone.Text;
                    string fax = this.fax.Text;
                    string password = this.password.Text;
                    string createdBy = "User";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    int checkEmail = library.CheckExistEmail(cmd, email);

                    if (checkEmail > 0)
                    {
                        MessageBox.Show("Email already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cmd.Parameters.Clear();

                        cmd.CommandText =
                        "INSERT INTO User_Information (UserFirstName, UserLastName, Email, Company, Address1, Address2, ZipPostalCode, City, Country, StateProvinceId, PhoneNumber, FaxNumber, [Password], CreatedBy)" +
                        "VALUES (@FirstName, @LastName, @Email, @Company, @Address1, @Address2, @ZipCode, @City, @Country, @State, @Phone, @Fax, @Password, @CreatedBy)";

                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Company", companyName);
                        cmd.Parameters.AddWithValue("@Address1", streetAddress1);
                        cmd.Parameters.AddWithValue("@Address2", streetAddress2);
                        cmd.Parameters.AddWithValue("@ZipCode", zipCode);
                        cmd.Parameters.AddWithValue("@City", city);
                        cmd.Parameters.AddWithValue("@Country", country);
                        cmd.Parameters.AddWithValue("@State", state);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Fax", fax);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@CreatedBy", createdBy);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to register user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion Private Method

        #region Event Handlers
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Enter)
            {
                CreateNewUser();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void form2_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            CreateNewUser();
        }

        private void country_SelectedIndexChanged(object sender, EventArgs e)
        {
            library.ComboBoxIndexChange(country);
        }

        private void state_SelectedIndexChanged(object sender, EventArgs e)
        {
            library.ComboBoxIndexChange(state);
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            var policyMessage = "Account means a unique account created for You to access our Service or parts of our Service.\r\n\r\nBusiness, for the purpose of the CCPA (California Consumer Privacy Act), refers to the Company as the legal entity that collects Consumers' personal information and determines the purposes and means of the processing of Consumers' personal information, or on behalf of which such information is collected and that alone, or jointly with others, determines the purposes and means of the processing of consumers' personal information, that does business in the State of California.\r\n\r\nCompany (referred to as either \"the Company\", \"We\", \"Us\" or \"Our\" in this Agreement) refers to America Cryo LLC, 51575 avenida navarro La Quinta CA 92253.";

            MessageBox.Show(policyMessage, "Policy Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            library.CapitalizeFirstLetter(firstName);
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            library.CapitalizeFirstLetter(lastName);
        }

        private void city_TextChanged(object sender, EventArgs e)
        {
            library.CapitalizeFirstLetter(city);
        }
        #endregion Event Handlers
    }
}
