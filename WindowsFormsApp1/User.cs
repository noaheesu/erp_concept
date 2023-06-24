using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class User : Form
    {
        #region Constructor and Disposer
        public Library library;
        public User()
        {
            InitializeComponent();
            library = new Library();
        }
        private UserList form;
        #endregion

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (form == null || form.IsDisposed)
            {
                form = new UserList();
                form.MdiParent = this;
                //form.CustomerData();
                form.FormClosed += Dt_FormClosed;
                form.StartPosition = FormStartPosition.Manual;
                form.Show();
            }
            else
            {
                form.BringToFront();
            }
        }
        private void Dt_FormClosed(object sender, FormClosedEventArgs e)
        {
            form = null; // Set the registration object to null when the form is closed
        }

        private void userBtn_Click(object sender, EventArgs e)
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

        private void accountInfoBtn_Click(object sender, EventArgs e)
        {
            string Email = Login.username;
            library.UserInfoDisplay(Email, this);
            this.Hide();
        }

        private void passwordBtn_Click(object sender, EventArgs e)
        {
            UpdatePw updatePw = new UpdatePw();
            AddOwnedForm(updatePw);
            updatePw.Show();
            this.Hide();

            string Email = Login.username;
            updatePw.Email = Email;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Library library = new Library();
            library.OpenUserListView(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Library library = new Library();
            library.OpenUserGridView(this);
        }
        #endregion
    }
}
