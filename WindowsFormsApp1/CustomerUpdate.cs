﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CustomerUpdate : Form
    {
        #region Fields and Properties
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["WinformDB"].ConnectionString;
        private CustomerInfo customerInfo;
        public Library library = new Library();
        public Button SaveButton => saveBtn;
        public Button DeleteButton => deleteBtn;
        public Button NewCustomerButton => newCustomerBtn;
        public Label CustomerUpdateTitle => label13;
        public TextBox DisplayBox => displayBox;
        public Label ModifyDate => modifyDate;
        public MaskedTextBox ModifyDateText => modifyDateTextBox;
        public Label ModifiedBy => modifiedBy;
        public ComboBox ModifiedByComboBox => modifiedByComboBox;
        #endregion Fields and Properties

        #region Constructor and Disposer
        public CustomerUpdate()
        {
            InitializeComponent();

            library.CountryList(countryComboBox);
            countryComboBox.SelectedIndexChanged += countryComboBox_SelectedIndexChanged;

            library.States(stateComboBox);
            stateComboBox.SelectedIndexChanged += stateComboBox_SelectedIndexChanged;

            library.CreatedBy(createByComboBox);
            createByComboBox.SelectedIndexChanged += createByComboBox_SelectedIndexChanged;

            library.ModifiedBy(modifiedByComboBox);
            modifiedByComboBox.SelectedIndexChanged += modifiedByComboBox_SelectedIndexChanged;
        }

        public CustomerUpdate(CustomerInfo customerInfo)
        {
            InitializeComponent();

            library.CountryList(countryComboBox);
            countryComboBox.SelectedIndexChanged += countryComboBox_SelectedIndexChanged;

            library.States(stateComboBox);
            stateComboBox.SelectedIndexChanged += stateComboBox_SelectedIndexChanged;

            library.CreatedBy(createByComboBox);
            createByComboBox.SelectedIndexChanged += createByComboBox_SelectedIndexChanged;

            library.ModifiedBy(modifiedByComboBox);
            modifiedByComboBox.SelectedIndexChanged += modifiedByComboBox_SelectedIndexChanged;


            SetCustomerInfo(customerInfo);
        }

        //public CustomerUpdate(string sCustomerName)
        //{
        //    InitializeComponent();

        //    firstNameTextBox.Text = sCustomerName;
        //    lastNameTextBox.Text = sCustomerName;


        //    library.CountryList(countryComboBox);
        //    countryComboBox.SelectedIndexChanged += countryComboBox_SelectedIndexChanged;

        //    library.States(stateComboBox);
        //    stateComboBox.SelectedIndexChanged += stateComboBox_SelectedIndexChanged;

        //    library.CreatedBy(createByComboBox);
        //    createByComboBox.SelectedIndexChanged += createByComboBox_SelectedIndexChanged;

        //    library.ModifiedBy(modifiedByComboBox);
        //    modifiedByComboBox.SelectedIndexChanged += modifiedByComboBox_SelectedIndexChanged;
        //}

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void SetCustomerInfo(CustomerInfo info)
        {
            customerInfo = info;

            emailTextBox.Text = customerInfo.Email;
            firstNameTextBox.Text = customerInfo.FirstName;
            lastNameTextBox.Text = customerInfo.LastName;
            companyTextBox.Text = customerInfo.Company;
            addressTextBox.Text = customerInfo.Address;
            address2TextBox.Text = customerInfo.Address2;
            zipTextBox.Text = customerInfo.Zip;
            cityTextBox.Text = customerInfo.City;
            countryComboBox.Text = customerInfo.Country;
            stateComboBox.Text = customerInfo.State;
            phoneTextBox.Text = customerInfo.Phone;
            faxTextBox.Text = customerInfo.Fax;
            descriptionTextBox.Text = customerInfo.Description;
            createByComboBox.Text = customerInfo.CreateBy;
            modifyDateTextBox.Text = customerInfo.ModifyDate;
            modifiedByComboBox.Text = customerInfo.ModifiedBy;

            if (!string.IsNullOrEmpty(emailTextBox.Text))
            {
                emailTextBox.ReadOnly = true;
            }

            NewCustomerButton.Visible = false;

            if (customerInfo.CreateBy != "")
            {
                createByComboBox.Enabled = false;
            }
        }
        #endregion Constructor and Disposer

        #region Public Method
        public void DeleteCustomer()
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
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
                        MessageBox.Show("Failed delete user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void UpdateCustomerInfo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

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
                    "WHERE Email = @Email";

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
                    MessageBox.Show("Failed update user information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void CreateNewCustomer()
        {
            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("Please enter email address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                MessageBox.Show("Please enter first name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                firstNameTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                MessageBox.Show("Please enter last name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lastNameTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(companyTextBox.Text))
            {
                MessageBox.Show("Please enter company.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                companyTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(addressTextBox.Text))
            {
                MessageBox.Show("Please enter address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                addressTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(zipTextBox.Text))
            {
                MessageBox.Show("Please enter zip/postalCode.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                zipTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cityTextBox.Text))
            {
                MessageBox.Show("Please enter city.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cityTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(countryComboBox.Text))
            {
                MessageBox.Show("Please enter country.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                countryComboBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(stateComboBox.Text))
            {
                MessageBox.Show("Please enter state.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                stateComboBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(phoneTextBox.Text))
            {
                MessageBox.Show("Please enter phone number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phoneTextBox.Focus();
                return;
            }

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
                string password = "0000";
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
                    //"INSERT INTO User_Information (UserFirstName, UserLastName, Email, Company, Address1, Address2, ZipPostalCode, City, Country, StateProvinceId, PhoneNumber, FaxNumber, [Password] , Description, CreatedBy)" +
                    //"VALUES (@FirstName, @LastName, @Email, @Company, @Address1, @Address2, @ZipCode, @City, @Country, @State, @Phone, @Fax, @Password, @Description, @CreatedBy)";
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

                    // int rowsAffected = cmd.ExecuteNonQuery();
                    int newUserId = Convert.ToInt32(cmd.ExecuteScalar());

                    // if (rowsAffected > 0)
                    if (newUserId > 0)
                    {
                        MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.Close();
                        saveBtn.Visible = true;
                        deleteBtn.Visible = true;
                        newCustomerBtn.Visible = false;
                        ModifiedBy.Visible = true;
                        ModifyDate.Visible = true;
                        ModifyDateText.Visible = true;
                        ModifiedByComboBox.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Failed to register user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }     
            }
        }
        #endregion Public Method

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
            UpdateCustomerInfo();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
        }

        private void newCustomerBtn_Click(object sender, EventArgs e)
        {
            CreateNewCustomer();
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
        private void customerUpdate_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }
        #endregion Event Handlers

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
