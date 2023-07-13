using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InvoiceUpdate : Form
    {
        #region Fields and Properties
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["WinformDB"].ConnectionString;
        public Library library = new Library();
        #endregion Fields and Properties


        public InvoiceUpdate()
        {
            InitializeComponent();

            library.CountryList(countryComboBox);
            library.States(stateComboBox);
            library.ModifiedBy(modifiedByComboBox);
            userIdComboBox.DataSource = UserIdList();
            userIdComboBox.DisplayMember = "ToString";

        }

        private void stateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stateComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            library.ComboBoxIndexChange(stateComboBox);
        }

        private void countryComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            library.ComboBoxIndexChange(countryComboBox);
        }

        private void modifiedByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            library.ComboBoxIndexChange(modifiedByComboBox);
        }

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
            UpdateInvoiceInfo();
        }


        private void UpdateInvoiceInfo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string txtID = txtId.Text;
                string userId = userIdComboBox.Text;
                string invoiceNo = invoiceNumberTextBox.Text;
                string contactName = contactNametextBox.Text;
                string service = serviceComboBox.Text;
                string totalAmount = totalAmountUpDown.Text;
                string status = statusComboBox.Text;
                string paymentDate = Convert.ToDateTime(paymentDatePicker.Text).ToString("MM/dd/yyyy HH:mm:ss");
                string paymentMethod = paymentMethodComboBox.Text;
                string address1 = addressTextBox.Text;
                string address2 = address2TextBox.Text;
                string zip = zipTextBox.Text;
                string city = cityTextBox.Text;
                string country = countryComboBox.Text;
                string state = stateComboBox.Text;
                string phone = phoneTextBox.Text;
                string note = noteTextBox.Text;
                string invoiceDate = Convert.ToDateTime(invoiceDatePicker.Text).ToString("MM/dd/yyyy HH:mm:ss");
                string dueDate = Convert.ToDateTime(dueDatePicker.Text).ToString("MM/dd/yyyy HH:mm:ss");
                DateTime modifyDate = DateTime.Now;
                string modifiedBy = modifiedByComboBox.Text;



                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText =
                    "UPDATE Invoice " +
                    "SET UserID = @UserID, " +
                    "InvoiceNumber = @InvoiceNo, " +
                    "ContactName = @ContactName, " +
                    "ServiceList = @Service, " +
                    "TotalAmount = @TotalAmount, " +
                    "PaymentStatus = @Status, " +
                    "PaymentDate = @PaymentDate, " +
                    "PaymentMethod = @PaymentMethod, " +
                    "BillingAddress = @Address1, " +
                    "BillingAddress2 = @Address2, " +
                    "ZipPostalCode = @Zip, " +
                    "City = @City, " +
                    "Country = @Country, " +
                    "StateProvinceId = @State, " +
                    "PhoneNumber = @Phone, " +
                    "[Note] = @Note, " +
                    "InvoiceDate = @InvoiceDate, " +
                    "DueDate = @DueDate, " +
                    "ModifyDate = @ModifyDate, " +
                    "ModifiedBy = @ModifiedBy " +
                    "WHERE UserID = @UserID AND ID = TxtId";

                cmd.Parameters.AddWithValue("@TxtId", txtID);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@InvoiceNo", invoiceNo);
                cmd.Parameters.AddWithValue("@ContactName", contactName);
                cmd.Parameters.AddWithValue("@Service", service);
                cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@PaymentDate", paymentDate);
                cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                cmd.Parameters.AddWithValue("@Address1", address1);
                cmd.Parameters.AddWithValue("@Address2", address2);
                cmd.Parameters.AddWithValue("@Zip", zip);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Country", country);
                cmd.Parameters.AddWithValue("@State", state);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Note", note);
                cmd.Parameters.AddWithValue("@InvoiceDate", invoiceDate);
                cmd.Parameters.AddWithValue("@DueDate", dueDate);
                cmd.Parameters.AddWithValue("@ModifyDate", modifyDate);
                cmd.Parameters.AddWithValue("@ModifiedBy", modifiedBy);


                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update invoice information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void paymentDateTextBox_ValueChanged(object sender, EventArgs e)
        {
            paymentDatePicker.CustomFormat = "MM/dd/yyyy";
        }

        private void dueDateTextBox_ValueChanged(object sender, EventArgs e)
        {
            dueDatePicker.CustomFormat = "MM/dd/yyyy";
        }

        private void invoiceDateTextBox_ValueChanged(object sender, EventArgs e)
        {
            invoiceDatePicker.CustomFormat = "MM/dd/yyyy";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteInvoice();
        }

        private void DeleteInvoice()
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this invoice?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string invoiceNumber = this.invoiceNumberTextBox.Text;

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText =
                        "DELETE FROM Invoice " +
                        "WHERE InvoiceNumber = @InvoiceNumber";

                    cmd.Parameters.AddWithValue("@InvoiceNumber", invoiceNumber);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Invoice deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            CreateNewInvoice();
        }

        private void CreateNewInvoice()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Retrieve the current maximum invoice number from the database
                SqlCommand getMaxInvoiceNoCmd = new SqlCommand("SELECT MAX(InvoiceNumber) FROM Invoice", connection);
                string maxInvoiceNo = getMaxInvoiceNoCmd.ExecuteScalar()?.ToString();
                int autoIncrease = 1;

                if (!string.IsNullOrEmpty(maxInvoiceNo))
                {
                    // Parse the numeric portion of the invoice number
                    string numericPart = maxInvoiceNo.Replace("INV-", "");
                    if (int.TryParse(numericPart, out int lastInvoiceNumber))
                    {
                        // Increment the numeric portion by 1
                        autoIncrease = lastInvoiceNumber + 1;
                    }
                }

                string invoiceNo = $"INV-{autoIncrease.ToString("D3")}";

                string userId = userIdComboBox.Text;
                string contactName = contactNametextBox.Text;
                string service = serviceComboBox.Text;
                string totalAmount = totalAmountUpDown.Text;
                string status = statusComboBox.Text;
                string paymentDate = paymentDatePicker.Value.Year == 9998 ? null : paymentDatePicker.Value.ToString("MM/dd/yyyy");
                string paymentMethod = paymentMethodComboBox.Text;
                string address1 = addressTextBox.Text;
                string address2 = address2TextBox.Text;
                string zip = zipTextBox.Text;
                string city = cityTextBox.Text;
                string country = countryComboBox.Text;
                string state = stateComboBox.Text;
                string phone = phoneTextBox.Text;
                string note = noteTextBox.Text;
                string invoiceDate = invoiceDatePicker.Value.Year == 9998 ? null : invoiceDatePicker.Value.ToString("MM/dd/yyyy");
                string dueDate = dueDatePicker.Value.Year == 9998 ? null : dueDatePicker.Value.ToString("MM/dd/yyyy");
                DateTime createDate = DateTime.Now;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                int checkInvoice = library.CheckExistInvoice(cmd, invoiceNo);

                if (checkInvoice > 0)
                {
                    MessageBox.Show("Invoice already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd.Parameters.Clear();

                    cmd.CommandText =
                    "INSERT INTO Invoice (UserID, InvoiceNumber, [ContactName], [ServiceList], TotalAmount, PaymentStatus, PaymentDate, PaymentMethod, BillingAddress, BillingAddress2, ZipPostalCode, City, Country, StateProvinceId, PhoneNumber, [Note], InvoiceDate, DueDate, CreateDate )" +
                    "VALUES (@UserID, @InvoiceNo, @ContactName, @Service, @TotalAmount, @Status, @PaymentDate, @PaymentMethod, @Address1, @Address2, @Zip, @City, @Country, @State, @Phone, @Note, @InvoiceDate, @DueDate, @CreateDate )" +
                    "SELECT @@IDENTITY;";

                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@InvoiceNo", invoiceNo);
                    cmd.Parameters.AddWithValue("@ContactName", contactName);
                    cmd.Parameters.AddWithValue("@Service", service);
                    cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@PaymentDate", paymentDate);
                    cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                    cmd.Parameters.AddWithValue("@Address1", address1);
                    cmd.Parameters.AddWithValue("@Address2", address2);
                    cmd.Parameters.AddWithValue("@Zip", zip);
                    cmd.Parameters.AddWithValue("@City", city);
                    cmd.Parameters.AddWithValue("@Country", country);
                    cmd.Parameters.AddWithValue("@State", state);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Note", note);
                    cmd.Parameters.AddWithValue("@InvoiceDate", invoiceDate);
                    cmd.Parameters.AddWithValue("@DueDate", dueDate);
                    cmd.Parameters.AddWithValue("@CreateDate", createDate);

                    int newInvoiceId = Convert.ToInt32(cmd.ExecuteScalar());

                    if (newInvoiceId > 0)
                    {
                        txtId.Text = newInvoiceId.ToString();
                        MessageBox.Show("Invoice created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        saveBtn.Visible = true;
                        deleteBtn.Visible = true;
                        newBtn.Visible = false;
                        label14.Text = "Invoice #";
                        label16.Visible = true;
                        createdDateTextBox.Visible = true;
                        modifyDate.Visible = true;
                        modifyDatePicker.Visible = true;
                        modifiedBy.Visible = true;
                        modifiedByComboBox.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Failed to create invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void userIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetContactName();
        }

        private List<string> UserIdList()
        {
            List<string> userIds = new List<string>();

            // Add null as the default value
            userIds.Add("Select user");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand getUserIdCmd = new SqlCommand("SELECT UserID FROM Invoice", connection);

                SqlDataReader reader = getUserIdCmd.ExecuteReader();

                while (reader.Read())
                {
                    int userId = reader.GetInt32(0);
                    userIds.Add(userId.ToString());
                }

                reader.Close();
            }

            return userIds;
        }

        //preset the name that matched the User ID
        private void SetContactName()
        {
            string userId = userIdComboBox.SelectedValue?.ToString();

            if (!string.IsNullOrEmpty(userId))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand getContactNameCmd = new SqlCommand("SELECT UserFirstName FROM User_Information WHERE UID = @UserId", connection);
                    getContactNameCmd.Parameters.AddWithValue("@UserId", userId);

                    object result = getContactNameCmd.ExecuteScalar();

                    if (result != null)
                    {
                        string contactName = result.ToString();
                        contactNametextBox.Text = contactName;
                    }
                    else
                    {
                        contactNametextBox.Text = string.Empty;
                    }
                }
            }
            else
            {
                contactNametextBox.Text = string.Empty;
            }
        }
    }
}
