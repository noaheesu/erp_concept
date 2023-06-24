using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
        #region Constructor and Disposer
        public Home()
        {
            InitializeComponent();
        }
        #endregion Constructor and Disposer

        #region Event Handlers
        //protected override bool ProcessDialogKey(Keys keyData)
        //{
        //    if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
        //    {
        //        this.Close();
        //        return true;
        //    }
        //    return base.ProcessDialogKey(keyData);
        //}
        private void form3_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void password_Click(object sender, EventArgs e)
        {
            UpdatePw updatePw = new UpdatePw();
           // AddOwnedForm(updatePw);
            updatePw.Show();
           // this.Hide();
           updatePw.MdiParent = this;

            string Email = Login.username;
            updatePw.Email = Email;
        }

        private void accountInfo_Click(object sender, EventArgs e)
        {
            Library library = new Library();
           // AccountInfo accountInfo = new AccountInfo();
            //AddOwnedForm(accountInfo);
            //accountInfo.Show();
            //this.Hide();

            string Email = Login.username;
            library.UserInfoDisplay(Email, this);
           // this.Hide();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Login logOut = new Login();
            AddOwnedForm(logOut);
            logOut.Show();
            this.Hide();
        }

        private void users_Click(object sender, EventArgs e)
        {
            if (panel4.Height == 171)
            {
                panel4.Height = 57;
            }
            else
            {
                panel4.Height = 171;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel4.Height = 57;
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            Library library = new Library();
            library.OpenUserGridView(this);
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            Product products = new Product();
            //AddOwnedForm(accounting);
            products.Show();
            products.MdiParent = this;
            //this.Hide();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            Library library = new Library();
            library.OpenUserListView(this);
        }
        #endregion Event Handlers
    }
}
