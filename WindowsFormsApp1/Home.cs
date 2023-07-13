using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
        #region Fields and Properties
        public Library library = new Library();
        #endregion Fields and Properties

        #region Constructor and Disposer
        public Home()
        {
            InitializeComponent();
        }
        #endregion Constructor and Disposer

        #region Event Handlers
        private void form3_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private UpdatePw updatePw = null;
        public void password_Click(object sender, EventArgs e)
        {
            //UpdatePw updatePw = new UpdatePw();
            //updatePw.Show();
            //updatePw.MdiParent = this;

            //string Email = Login.username;
            //updatePw.Email = Email;
            if (updatePw == null)
            {
                updatePw = new UpdatePw();
                updatePw.MdiParent = this;

                string email = Login.username;
                updatePw.Email = email;

                updatePw.FormClosed += UpdatePw_FormClosed;
            }

            updatePw.Show();
            updatePw.Focus();
        }
        private void UpdatePw_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Set the updatePw variable to null when the form is closed
            updatePw = null;
        }

        private void accountInfo_Click(object sender, EventArgs e)
        {
           // library.OpenForm<AccountInfo>(this);
           // Library library = new Library();

            string email = Login.username;
            library.OpenAccountInfo(this, email);       
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

        private void userListGrid_Click(object sender, EventArgs e)
        {
            //library.OpenUserGridView(this);
            library.OpenForm<UserList>(this);
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            library.OpenForm<Product>(this);


            //Product products = new Product();

           // products.Show();
           // products.MdiParent = this;
        }

        public void userListView_Click(object sender, EventArgs e)
        {
            //library.OpenUserListView(this);
            library.OpenForm<userListView>(this);
        }
        #endregion Event Handlers

        private void invoiceBtn_Click(object sender, EventArgs e)
        {
            library.OpenForm<Invoice>(this);
        }
    }
}
