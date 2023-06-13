using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        #region Constructor and Disposer
        public Login()
        {
            InitializeComponent();

            //SKIP LOGIN FOR TESTING
            loginId.Text = "test@gmail.com";
            password.Text = "123";
            login_button(null, EventArgs.Empty);
            this.BringToFront();
        }
        public static string username;
        #endregion Constructor and Disposer

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
                //Library library = new Library();
                //library.LoginUser(loginId, password, this);
                login_button(null, EventArgs.Empty);
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (password.Text != "password")
            {
                password.PasswordChar = '*';
            }
        }

        private void login_button(object sender, EventArgs e)
        {
            Library library = new Library();
            library.LoginUser(loginId, password, this);
            username = loginId.Text;
        }

        private void registerBtn_click(object sender, EventArgs e)
        {
            Form registration = new Registration();
            registration.ShowDialog();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form f4 = new ForgetPw();
            AddOwnedForm(f4);

            f4.Show();
        }

        private void loginId_Enter(object sender, EventArgs e)
        {
            if (loginId.Text == "someone@example.com")
            {
                loginId.Text = "";
                loginId.ForeColor = Color.Black;
            }
        }

        private void loginId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginId.Text))
            {
                loginId.Text = "someone@example.com";
                loginId.ForeColor = Color.Silver;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "password")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "password";
                password.ForeColor = Color.Silver;
            }
        }
        #endregion Event Handlers
    }
}
