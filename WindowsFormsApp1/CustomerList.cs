using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public struct CustomerInfo
    {
        public string Email;
        public string FirstName;
        public string LastName;
        public string Company;
        public string Address;
        public string Address2;
        public string Zip;
        public string City;
        public string Country;
        public string State;
        public string Phone;
        public string Fax;
        public string Description;
        public string CreateBy;
        public string ModifyDate;
        public string ModifiedBy;
    }

    public partial class CustomerList : Form
    {
        #region Fields and Properties
        private DataTable dt = new DataTable();
        private DataView dv;
        #endregion Fields and Properties

        #region Constructor and Disposer
        public CustomerList()
        {
            InitializeComponent();
        }
        #endregion Constructor and Disposer

        #region Public Method
        public void CustomerData()
        {
            Library library = new Library();
            library.LoadData(dataGridView1);
            dt = library.LoadData(dataGridView1);
            dv = dt.DefaultView;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(109, 122, 224);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 12);
            dataGridView1.RowHeadersDefaultCellStyle.Font = new Font(dataGridView1.RowHeadersDefaultCellStyle.Font.FontFamily, 10);
        }
        public void ResetSearch()
        {
            firstNameSearch.Clear();
            lastNameSearch.Clear();
            zipSearch.Clear();
            phoneSearch.Clear();
            companySearch.Clear();
            stateSearch.Clear();
        }

        public void EditCustomerInfoByGrid()
        {
            CustomerUpdate customerUpdate = new CustomerUpdate();

            DataGridViewRow currentRow = dataGridView1.CurrentRow;
            customerUpdate.emailTextBox.Text = currentRow.Cells[0].Value?.ToString();
            customerUpdate.firstNameTextBox.Text = currentRow.Cells[1].Value?.ToString();
            customerUpdate.lastNameTextBox.Text = currentRow.Cells[2].Value?.ToString();
            customerUpdate.companyTextBox.Text = currentRow.Cells[3].Value?.ToString();
            customerUpdate.addressTextBox.Text = currentRow.Cells[4].Value?.ToString();
            customerUpdate.address2TextBox.Text = currentRow.Cells[5].Value?.ToString();
            customerUpdate.zipTextBox.Text = currentRow.Cells[6].Value?.ToString();
            customerUpdate.cityTextBox.Text = currentRow.Cells[7].Value?.ToString();
            customerUpdate.countryComboBox.Text = currentRow.Cells[8].Value?.ToString();
            customerUpdate.stateComboBox.Text = currentRow.Cells[9].Value?.ToString();
            customerUpdate.phoneTextBox.Text = currentRow.Cells[10].Value?.ToString();
            customerUpdate.faxTextBox.Text = currentRow.Cells[11].Value?.ToString();
            customerUpdate.descriptionTextBox.Text = currentRow.Cells[12].Value?.ToString();
            customerUpdate.createByComboBox.Text = currentRow.Cells[14].Value?.ToString();
            customerUpdate.modifyDateTextBox.Text = currentRow.Cells[15].Value?.ToString();
            customerUpdate.modifiedByComboBox.Text = currentRow.Cells[16].Value?.ToString();

            customerUpdate.displayBox.Text = currentRow.Cells[1].Value?.ToString();

            if (!string.IsNullOrEmpty(customerUpdate.emailTextBox.Text))
            {
                customerUpdate.emailTextBox.ReadOnly = true;
            }

            customerUpdate.NewCustomerButton.Visible = false;

            if (!string.IsNullOrEmpty(customerUpdate.createByComboBox.Text))
            {
                customerUpdate.createByComboBox.Enabled = false;
            }

            customerUpdate.ShowDialog();

            RefreshCustomerData();
        }

        public void EditCustomerInfoByStruct()
        {
            DataGridViewRow currentRow = dataGridView1.CurrentRow;
            CustomerInfo customerInfo = new CustomerInfo();

            customerInfo.Email = GetCellValue(currentRow, 0);
            customerInfo.FirstName = GetCellValue(currentRow, 1);
            customerInfo.LastName = GetCellValue(currentRow, 2);
            customerInfo.Company = GetCellValue(currentRow, 3);
            customerInfo.Address = GetCellValue(currentRow, 4);
            customerInfo.Address2 = GetCellValue(currentRow, 5);
            customerInfo.Zip = GetCellValue(currentRow, 6);
            customerInfo.City = GetCellValue(currentRow, 7);
            customerInfo.Country = GetCellValue(currentRow, 8);
            customerInfo.State = GetCellValue(currentRow, 9);
            customerInfo.Phone = GetCellValue(currentRow, 10);
            customerInfo.Fax = GetCellValue(currentRow, 11);
            customerInfo.Description = GetCellValue(currentRow, 12);
            customerInfo.CreateBy = GetCellValue(currentRow, 14);
            //customerInfo.ModifyDate = Convert.ToDateTime?(GetCellValue(currentRow, 15)).ToString("MM/dd/yyyy HH:mm:ss");
            customerInfo.ModifyDate = string.IsNullOrEmpty(GetCellValue(currentRow, 15)) ? "Default Value" : Convert.ToDateTime(GetCellValue(currentRow, 15)).ToString("MM/dd/yyyy HH:mm:ss");
            customerInfo.ModifiedBy = GetCellValue(currentRow, 16);

            CustomerUpdate customerUpdate = new CustomerUpdate(customerInfo);

            customerUpdate.ShowDialog();
            RefreshCustomerData();
        }
        private string GetCellValue(DataGridViewRow row, int columnIndex)
        {
            return row.Cells[columnIndex].Value?.ToString();
        }

        public void CreateNewCustomer()
        {
            CustomerUpdate customerUpdate = new CustomerUpdate();

            customerUpdate.SaveButton.Visible = false;
            customerUpdate.DeleteButton.Visible = false;
            customerUpdate.CustomerUpdateTitle.Text = "Add a new customer";
            customerUpdate.DisplayBox.Visible = false;
            customerUpdate.ModifiedBy.Visible = false;
            customerUpdate.ModifyDate.Visible = false;
            customerUpdate.ModifyDateText.Visible = false;
            customerUpdate.ModifiedByComboBox.Visible = false;
                
            customerUpdate.ShowDialog();

            RefreshCustomerData();
        }

        public void RefreshCustomerData()
        {
            CustomerData();
            ResetSearch();
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

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }

        private void firstNameSearch_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "UserFirstName LIKE '%" + firstNameSearch.Text + "%'";
        }

        private void lastNameSearch_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "UserLastName LIKE '%" + lastNameSearch.Text + "%'";
        }

        private void zipSearch_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "ZipPostalCode LIKE '%" + zipSearch.Text + "%'";
        }

        private void phoneSearch_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "PhoneNumber LIKE '%" + phoneSearch.Text + "%'";
        }

        private void companySearch_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "Company LIKE '%" + companySearch.Text + "%'";
        }

        private void stateSearch_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "StateProvinceId LIKE '%" + stateSearch.Text + "%'";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // EditCustomerInfoByGrid();
            EditCustomerInfoByStruct();
        }

        private void newCustomerBtn_Click(object sender, EventArgs e)
        {
            CreateNewCustomer();
        }

        public void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshCustomerData();
        }

        #endregion Event Handlers
    }
}
