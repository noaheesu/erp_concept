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
                library.ChangePw(email, existPw, newPw, confirmPw, this);

                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void changePwBtn_Click(object sender, EventArgs e)
        {
            library.ChangePw(email, existPw, newPw, confirmPw, this);
        }
        #endregion Event Handlers
    }
}
