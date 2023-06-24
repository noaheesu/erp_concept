using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AccountInfo : Form
    {
        #region Constructor and Disposer
        public Library library;
        public AccountInfo()
        {
            InitializeComponent();
            library = new Library();
        }

        public string Email
        {
            get { return email.Text; }
            set { email.Text = value; }
        }
        public string FirstName
        {
            get { return firstName.Text; }
            set { firstName.Text = value; }
        }
        public string LastName
        {
            get { return lastName.Text; }
            set { lastName.Text = value; }
        }
        public string Company
        {
            get { return company.Text; }
            set { company.Text = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber.Text; }
            set { phoneNumber.Text = value; }
        }

        #endregion Constructor and Disposer

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

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            AddOwnedForm(home);
            home.Show();
            this.Hide();
        }

        private void password_Click(object sender, EventArgs e)
        {
            UpdatePw updatePw = new UpdatePw();
            AddOwnedForm(updatePw);
            updatePw.Show();
            this.Hide();

            string Email = Login.username;
            updatePw.Email = Email;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            AddOwnedForm(home);
            home.Show();
            this.Hide();
        }
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (panel5.Height == 114)
        //    {
        //        panel5.Height = 57;
        //    }
        //    else
        //    {
        //        panel5.Height = 114;
        //    }
        //}
        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{
        //    panel5.Height = 57;
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            library.OpenUserGridView(this);
        }

        private void changeProfile_Click(object sender, EventArgs e)
        {
            string Email = Login.username;
            library.UserInfoUpdate(Email, firstName, lastName, company, phoneNumber);
        }

        private void AccountInfoBtn_Click(object sender, EventArgs e)
        {
            string Email = Login.username;
            library.UserInfoDisplay(Email, this);
            this.Hide();
        }
        #endregion
    }
}
