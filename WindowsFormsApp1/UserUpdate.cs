using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserUpdate : Form
    {
        #region Fields and Properties
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["WinformDB"].ConnectionString;
        private UserInfo userInfo;
        public Library library = new Library();
        public Button SaveButton => saveBtn;
        public Button DeleteButton => deleteBtn;
        public Button NewUserButton => createNewUserBtn;
        public Label UserUpdateTitle => label13;
        public TextBox DisplayBox => displayBox;
        public Label ModifyDate => modifyDate;
        public MaskedTextBox ModifyDateText => modifyDateTextBox;
        public Label ModifiedBy => modifiedBy;
        public ComboBox ModifiedByComboBox => modifiedByComboBox;
        #endregion Fields and Properties

        #region Constructor and Disposer
        public UserUpdate()
        {
            InitializeComponent();

            library.CountryList(countryComboBox);
            library.States(stateComboBox);
            library.CreatedBy(createByComboBox);
            library.ModifiedBy(modifiedByComboBox);
        }

        public UserUpdate(UserInfo userInfo)
        {
            InitializeComponent();

            library.CountryList(countryComboBox);
            library.States(stateComboBox);
            library.CreatedBy(createByComboBox);
            library.ModifiedBy(modifiedByComboBox);

            SetUserInfo(userInfo);
        }

        private void SetUserInfo(UserInfo info)
        {
            userInfo = info;

            emailTextBox.Text = userInfo.Email;
            firstNameTextBox.Text = userInfo.FirstName;
            lastNameTextBox.Text = userInfo.LastName;
            companyTextBox.Text = userInfo.Company;
            addressTextBox.Text = userInfo.Address;
            address2TextBox.Text = userInfo.Address2;
            zipTextBox.Text = userInfo.Zip;
            cityTextBox.Text = userInfo.City;
            countryComboBox.Text = userInfo.Country;
            stateComboBox.Text = userInfo.State;
            phoneTextBox.Text = userInfo.Phone;
            faxTextBox.Text = userInfo.Fax;
            descriptionTextBox.Text = userInfo.Description;
            createByComboBox.Text = userInfo.CreateBy;
            modifyDateTextBox.Text = userInfo.ModifyDate;
            modifiedByComboBox.Text = userInfo.ModifiedBy;
            txtUID.Text = userInfo.txtUID;
            displayBox.Text = userInfo.displayBox;

            if (!string.IsNullOrEmpty(emailTextBox.Text))
            {
                emailTextBox.ReadOnly = true;
            }

            NewUserButton.Visible = false;

            if (userInfo.CreateBy != "")
            {
                createByComboBox.Enabled = false;
            }
        }
        #endregion Constructor and Disposer

        #region Private Method
        private void DeleteUser()
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string email = this.emailTextBox.Text;

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText =
                        "DELETE FROM User_Information " +
                        "WHERE Email = @Email";

                    cmd.Parameters.AddWithValue("@Email", email);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void UpdateUserInfo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string uid = txtUID.Text;
                string email = emailTextBox.Text;
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string companyName = companyTextBox.Text;
                string streetAddress1 = addressTextBox.Text;
                string streetAddress2 = address2TextBox.Text;
                string zipCode = zipTextBox.Text;
                string city = cityTextBox.Text;
                string country = countryComboBox.Text;
                string state = stateComboBox.Text;
                string phone = phoneTextBox.Text;
                string fax = faxTextBox.Text;
                string description = descriptionTextBox.Text;
                string createdBy = createByComboBox.Text;
                string modifyDate = modifyDateTextBox.Text;
                string modifiedBy = ModifiedByComboBox.Text;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText =
                    "UPDATE User_Information " +
                    "SET UserFirstName = @FirstName, UserLastName = @LastName, Company = @Company, Address1 = @Address1, Address2 = @Address2, ZipPostalCode = @ZipCode, City = @City, Country = @Country, StateProvinceId = @State, PhoneNumber = @Phone, FaxNumber = @Fax, Description = @Description, CreatedBy = @CreatedBy, ModifyDate = @ModifyDate, ModifiedBy = @ModifiedBy " +
                    "WHERE UID = @UID";

                cmd.Parameters.AddWithValue("@UID", uid);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Company", companyName);
                cmd.Parameters.AddWithValue("@Address1", streetAddress1);
                cmd.Parameters.AddWithValue("@Address2", streetAddress2);
                cmd.Parameters.AddWithValue("@ZipCode", zipCode);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Country", country);
                cmd.Parameters.AddWithValue("@State", state);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Fax", fax);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@CreatedBy", createdBy);
                cmd.Parameters.AddWithValue("@ModifyDate", modifyDate);
                cmd.Parameters.AddWithValue("@ModifiedBy", modifiedBy);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update user information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool DataValidate()
        {
            bool rv = true;

            string email = emailTextBox.Text.Trim();

            // Email format validation using regular expression
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailTextBox.Focus();
                rv = false;
            }
            else if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                MessageBox.Show("Please enter first name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                firstNameTextBox.Focus();
                rv = false;
            }
            else if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                MessageBox.Show("Please enter last name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lastNameTextBox.Focus();
                rv = false;
            }
            else if (string.IsNullOrWhiteSpace(companyTextBox.Text))
            {
                MessageBox.Show("Please enter company.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                companyTextBox.Focus();
                rv = false;
            }
            else if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                MessageBox.Show("Please enter address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                addressTextBox.Focus();
                rv = false;
            }
            else if (string.IsNullOrWhiteSpace(zipTextBox.Text))
            {
                MessageBox.Show("Please enter zip/postalCode.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                zipTextBox.Focus();
                rv = false;
            }
            else if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                MessageBox.Show("Please enter city.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cityTextBox.Focus();
                rv = false;
            }
            else if (string.IsNullOrEmpty(countryComboBox.Text))
            {
                MessageBox.Show("Please enter country.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                countryComboBox.Focus();
                rv = false;
            }
            else if (string.IsNullOrEmpty(stateComboBox.Text))
            {
                MessageBox.Show("Please enter state.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                stateComboBox.Focus();
                rv = false;
            }
            else if (string.IsNullOrWhiteSpace(phoneTextBox.Text))
            {
                MessageBox.Show("Please enter phone number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phoneTextBox.Focus();
                rv = false;
            }
            return rv;
        }

        private void CreateNewUser()
        {
            if (!DataValidate())
                return;
          
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string email = this.emailTextBox.Text;
                string firstName = this.firstNameTextBox.Text;
                string lastName = this.lastNameTextBox.Text;
                string companyName = this.companyTextBox.Text;
                string streetAddress1 = this.addressTextBox.Text;
                string streetAddress2 = this.address2TextBox.Text;
                string zipCode = this.zipTextBox.Text;
                string city = this.cityTextBox.Text;
                string country = this.countryComboBox.Text;
                string state = this.stateComboBox.Text;
                string phone = this.phoneTextBox.Text;
                string fax = this.faxTextBox.Text;
                string password = "";
                string description = this.descriptionTextBox.Text;
                string createdBy = this.createByComboBox.Text;

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
                    "INSERT INTO User_Information (UserFirstName, UserLastName, Email, Company, Address1, Address2, ZipPostalCode, City, Country, StateProvinceId, PhoneNumber, FaxNumber, [Password] , Description, CreatedBy)" +
                    "VALUES (@FirstName, @LastName, @Email, @Company, @Address1, @Address2, @ZipCode, @City, @Country, @State, @Phone, @Fax, @Password, @Description, @CreatedBy)" +
                    "SELECT @@IDENTITY;";

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
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@CreatedBy", createdBy);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int newUserId = Convert.ToInt32(cmd.ExecuteScalar());

                    if (newUserId > 0)
                    {
                        MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        saveBtn.Visible = true;
                        deleteBtn.Visible = true;
                        createNewUserBtn.Visible = false;
                        ModifiedBy.Visible = true;
                        ModifyDate.Visible = true;
                        ModifyDateText.Visible = true;
                        ModifiedByComboBox.Visible = true;
                        txtUID.Text = newUserId.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Failed to register user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }     
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
            return base.ProcessDialogKey(keyData);
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            modifyDateTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            UpdateUserInfo();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void createNewUserBtn_Click(object sender, EventArgs e)
        {
            CreateNewUser();
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            library.ComboBoxIndexChange(countryComboBox);
        }

        private void stateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            library.ComboBoxIndexChange(stateComboBox);
        }

        private void createByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            library.ComboBoxIndexChange(createByComboBox);
        }

        private void modifiedByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            library.ComboBoxIndexChange(modifiedByComboBox);
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            library.CapitalizeFirstLetter(firstNameTextBox);
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            library.CapitalizeFirstLetter(lastNameTextBox);
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            library.CapitalizeFirstLetter(cityTextBox);
        }
        private void userUpdate_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }
        #endregion Event Handlers
    }
}
