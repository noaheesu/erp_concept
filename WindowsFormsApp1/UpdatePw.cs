using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UpdatePw : Form
    {
        #region Constructor and Disposer
        public string Email {get { return email.Text; } set { email.Text = value; } }

        public Library library;
        public UpdatePw()
        {
            InitializeComponent();
            library = new Library();
        }
        #endregion Constructor and Disposer

        #region Private Method
        private void PasswordBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.password_Click(null, EventArgs.Empty);
            this.Hide();
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
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Enter)
            {
               // Library library = new Library();
                library.ChangePw(email, existPw, newPw, confirmPw, this);

                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            AddOwnedForm(home);
            home.Show();
            this.Hide();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changePwBtn_Click(object sender, EventArgs e)
        {
           // Library library = new Library();
            library.ChangePw(email, existPw, newPw, confirmPw, this);
        }

        private void back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            AddOwnedForm(home);
            home.Show();
            this.Hide();
        }
        private void accountInfo_Click(object sender, EventArgs e)
        {
            string Email = Login.username;
            library.UserInfoDisplay(Email, this);
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
            Library library = new Library();
            library.OpenUserGridView(this);
        }
        #endregion Event Handlers
    }
}
