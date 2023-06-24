using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserListView : Form
    {
        #region Fields and Properties
        private DataTable dt = new DataTable();
        private DataView dv;
        public Library library = new Library();
        #endregion Fields and Properties

        #region Constructor and Disposer
        public UserListView()
        {
            InitializeComponent();
            UserListData();
        }
        #endregion Constructor and Disposer

        #region Private Method
        private void UserListData()
        {
            //listView1 = library.LoadListData(listView1);

            library.LoadListData(ref listView1);

            //dt = library.LoadListData(listView1);
            //dv = dt.DefaultView;
        }

        private void EditUserInfoByStructListView()
        {
            if (listView1.SelectedItems.Count == 0)
            {
                // No item selected, handle the error accordingly
                return;
            }

            ListViewItem selectedItem = listView1.SelectedItems[0];

            UserUpdateListView view = new UserUpdateListView();

            view.emailTextBox.Text = selectedItem.SubItems[0].Text;
            view.firstNameTextBox.Text = selectedItem.SubItems[1].Text;
            view.lastNameTextBox.Text = selectedItem.SubItems[2].Text;
            view.companyTextBox.Text = selectedItem.SubItems[3].Text;
            view.phoneTextBox.Text = selectedItem.SubItems[10].Text;
            view.faxTextBox.Text = selectedItem.SubItems[5].Text;
            view.descriptionTextBox.Text = selectedItem.SubItems[12].Text;
            view.createByComboBox.Text = selectedItem.SubItems[14].Text;
            view.modifiedByComboBox.Text = selectedItem.SubItems[16].Text;
            view.modifyDateTextBox.Text = selectedItem.SubItems[15].Text;
            view.addressTextBox.Text = selectedItem.SubItems[4].Text;
            view.address2TextBox.Text = selectedItem.SubItems[11].Text;
            view.zipTextBox.Text = selectedItem.SubItems[6].Text;
            view.cityTextBox.Text = selectedItem.SubItems[7].Text;
            view.countryComboBox.Text = selectedItem.SubItems[8].Text;
            view.stateComboBox.Text = selectedItem.SubItems[9].Text;

            view.txtUID.Text = selectedItem.SubItems[17].Text;

            view.displayBox.Text = selectedItem.SubItems[1].Text;

            view.createNewUserBtn.Visible = false;
            view.emailTextBox.ReadOnly = true;

            view.ShowDialog();

            RefreshUserData();
        }

        private void RefreshUserData()
        {
            UserListData();
            library.ResetSearch(firstNameSearch, lastNameSearch, zipSearch, phoneSearch, companySearch, stateSearch);
        }

        private void CreateNewUserListView()
        {
            UserUpdateListView userUpdate = new UserUpdateListView();

            userUpdate.saveBtn.Visible = false;
            userUpdate.deleteBtn.Visible = false;
            userUpdate.label13.Text = "Add a new user";
            userUpdate.displayBox.Visible = false;
            userUpdate.modifiedBy.Visible = false;
            userUpdate.modifyDate.Visible = false;
            userUpdate.modifyDateTextBox.Visible = false;
            userUpdate.modifiedByComboBox.Visible = false;
            userUpdate.createNewUserBtn.Location = new Point(680, 20);
            userUpdate.ShowDialog();

            RefreshUserData();
        }

        private void SearchWith(string name, TextBox text)
        {
            dv.RowFilter = $"{name} LIKE '%" + text.Text + "%'";
            listView1.Items.Clear(); // Clear the ListView

            foreach (DataRowView rowView in dv)
            {
                DataRow row = rowView.Row;
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
                item.SubItems.Add(row["ModifyDate"].ToString());
                item.SubItems.Add(row["ModifiedBy"].ToString());
                item.SubItems.Add(row["UID"].ToString());

                listView1.Items.Add(item); // Add the item to the ListView
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

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            EditUserInfoByStructListView();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshUserData();
        }

        private void newUserBtn_Click(object sender, EventArgs e)
        {
            CreateNewUserListView();
        }

        private void firstNameSearch_TextChanged(object sender, EventArgs e)
        {
            SearchWith("UserFirstName", firstNameSearch);
        }

        private void lastNameSearch_TextChanged(object sender, EventArgs e)
        {
            SearchWith("UserLastName", lastNameSearch);
        }

        private void zipSearch_TextChanged(object sender, EventArgs e)
        {
            SearchWith("ZipPostalCode", zipSearch);
        }

        private void phoneSearch_TextChanged(object sender, EventArgs e)
        {
            SearchWith("PhoneNumber", phoneSearch);
        }

        private void companySearch_TextChanged(object sender, EventArgs e)
        {
            SearchWith("Company", companySearch);
        }

        private void stateSearch_TextChanged(object sender, EventArgs e)
        {
            SearchWith("StateProvinceId", stateSearch);
        }
        #endregion Event Handlers
    }
}
