﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// structure
    /// </summary>
    public struct UserInfo
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
        public string txtUID;
        public string displayBox;
    }

    public partial class UserList : Form
    {
        #region Fields and Properties
        private DataTable dt = new DataTable();
        private DataView dv;
        public Library library = new Library();
        #endregion Fields and Properties

        #region Constructor and Disposer
        public UserList()
        {
            InitializeComponent();
            UserData();
        }
        #endregion Constructor and Disposer

        #region Private Method
        private void UserData()
        {
            dt = library.LoadUserData(dataGridView1);    

            //For RowFilter Name Search
            dv = dt.DefaultView;
        }

        private void EditUserInfoByGrid()
        {
            UserUpdate userUpdate = new UserUpdate();

            DataGridViewRow currentRow = dataGridView1.CurrentRow;
            userUpdate.emailTextBox.Text = currentRow.Cells[0].Value?.ToString();
            userUpdate.firstNameTextBox.Text = currentRow.Cells[1].Value?.ToString();
            userUpdate.lastNameTextBox.Text = currentRow.Cells[2].Value?.ToString();
            userUpdate.companyTextBox.Text = currentRow.Cells[3].Value?.ToString();
            userUpdate.addressTextBox.Text = currentRow.Cells[4].Value?.ToString();
            userUpdate.address2TextBox.Text = currentRow.Cells[5].Value?.ToString();
            userUpdate.zipTextBox.Text = currentRow.Cells[6].Value?.ToString();
            userUpdate.cityTextBox.Text = currentRow.Cells[7].Value?.ToString();
            userUpdate.countryComboBox.Text = currentRow.Cells[8].Value?.ToString();
            userUpdate.stateComboBox.Text = currentRow.Cells[9].Value?.ToString();
            userUpdate.phoneTextBox.Text = currentRow.Cells[10].Value?.ToString();
            userUpdate.faxTextBox.Text = currentRow.Cells[11].Value?.ToString();
            userUpdate.descriptionTextBox.Text = currentRow.Cells[12].Value?.ToString();
            userUpdate.createByComboBox.Text = currentRow.Cells[14].Value?.ToString();
            userUpdate.modifyDateTextBox.Text = currentRow.Cells[15].Value?.ToString();
            userUpdate.modifiedByComboBox.Text = currentRow.Cells[16].Value?.ToString();
            userUpdate.txtUID.Text = currentRow.Cells[17].Value?.ToString();

            userUpdate.displayBox.Text = currentRow.Cells[1].Value?.ToString();

            if (!string.IsNullOrEmpty(userUpdate.emailTextBox.Text))
            {
                userUpdate.emailTextBox.ReadOnly = true;
            }

            userUpdate.NewUserButton.Visible = false;

            if (!string.IsNullOrEmpty(userUpdate.createByComboBox.Text))
            {
                userUpdate.createByComboBox.Enabled = false;
            }

            userUpdate.ShowDialog();

            RefreshUserData();
        }

        //Used structure for efficiency
        private void EditUserInfoByStruct()
        {
            DataGridViewRow currentRow = dataGridView1.CurrentRow;
            UserInfo userInfo = new UserInfo();

            userInfo.Email = GetCellValue(currentRow, 0);
            userInfo.FirstName = GetCellValue(currentRow, 1);
            userInfo.LastName = GetCellValue(currentRow, 2);
            userInfo.Company = GetCellValue(currentRow, 3);
            userInfo.Address = GetCellValue(currentRow, 4);
            userInfo.Address2 = GetCellValue(currentRow, 5);
            userInfo.Zip = GetCellValue(currentRow, 6);
            userInfo.City = GetCellValue(currentRow, 7);
            userInfo.Country = GetCellValue(currentRow, 8);
            userInfo.State = GetCellValue(currentRow, 9);
            userInfo.Phone = GetCellValue(currentRow, 10);
            userInfo.Fax = GetCellValue(currentRow, 11);
            userInfo.Description = GetCellValue(currentRow, 12);
            userInfo.CreateBy = GetCellValue(currentRow, 14);
            userInfo.ModifyDate = string.IsNullOrEmpty(GetCellValue(currentRow, 15)) ? "" : Convert.ToDateTime(GetCellValue(currentRow, 15)).ToString("MM/dd/yyyy HH:mm:ss");
            userInfo.ModifiedBy = GetCellValue(currentRow, 16);
            userInfo.txtUID = currentRow.Cells[17].Value?.ToString();

            userInfo.displayBox = currentRow.Cells[1].Value?.ToString();

            UserUpdate userUpdate = new UserUpdate(userInfo);

            userUpdate.ShowDialog();
            RefreshUserData();
        }
        private string GetCellValue(DataGridViewRow row, int columnIndex)
        {
            return row.Cells[columnIndex].Value?.ToString();
        }

        private void CreateNewUser()
        {
            UserUpdate userUpdate = new UserUpdate();

            userUpdate.SaveButton.Visible = false;
            userUpdate.DeleteButton.Visible = false;
            userUpdate.UserUpdateTitle.Text = "Add a new customer";
            userUpdate.DisplayBox.Visible = false;
            userUpdate.ModifiedBy.Visible = false;
            userUpdate.ModifyDate.Visible = false;
            userUpdate.ModifyDateText.Visible = false;
            userUpdate.ModifiedByComboBox.Visible = false;
                
            userUpdate.ShowDialog();

            RefreshUserData();
        }

        private void RefreshUserData()
        {
            UserData();
            library.ResetSearch(firstNameSearch, lastNameSearch, zipSearch, phoneSearch, companySearch, stateSearch);
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
            EditUserInfoByStruct();
        }

        private void newUserBtn_Click(object sender, EventArgs e)
        {
            CreateNewUser();
        }

        public void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshUserData();
        }

        #endregion Event Handlers

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
