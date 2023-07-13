using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WindowsFormsApp1
{
    public partial class Invoice : Form
    {
        #region Fields and Properties
        private DataTable dt;
        private DataView dv;
        public Library library = new Library();
        #endregion Fields and Properties

        #region Constructor and Disposer
        public Invoice()
        {
            InitializeComponent();
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
            dt = new DataTable();
            dv = new DataView(dt);
            InvoiceData();
        }
        #endregion Constructor and Disposer


        #region Private Method

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["PaymentStatus"].Index)
            {
                string paymentStatus = e.Value?.ToString();
                if (paymentStatus == "Pending")
                {
                    e.CellStyle.BackColor = Color.FromArgb(228, 215, 179);
                }
                if (paymentStatus == "Void")
                {
                    e.CellStyle.BackColor = Color.FromArgb(190, 126, 151);
                }
                if (paymentStatus == "Paid")
                {
                    e.CellStyle.BackColor = Color.FromArgb(93, 126, 151);
                }

            }
        }

        private void InvoiceData()
        {
            dt = library.LoadInvoiceData(dataGridView1);

            //For RowFilter Name Search
            dv = dt.DefaultView;

        }

        #endregion Private Method

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditInvoice();
        }

        private void EditInvoice()
        {
            DataGridViewRow currentRow = dataGridView1.CurrentRow;
            InvoiceUpdate invoice = new InvoiceUpdate();
            invoice.invoiceTitleTextBox.Text = GetCellValue(currentRow, 1);

            invoice.userIdComboBox.Text = GetCellValue(currentRow, 0);
            invoice.invoiceNumberTextBox.Text = GetCellValue(currentRow, 1);
            invoice.contactNametextBox.Text = GetCellValue(currentRow, 2);
            invoice.serviceComboBox.Text = GetCellValue(currentRow, 3);
            invoice.totalAmountUpDown.Text = GetCellValue(currentRow, 4);
            invoice.statusComboBox.Text = GetCellValue(currentRow, 5);
            invoice.paymentDatePicker.Value = GetDateValue(currentRow, 6);
            invoice.paymentMethodComboBox.Text = GetCellValue(currentRow, 7);
            invoice.addressTextBox.Text = GetCellValue(currentRow, 8);
            invoice.address2TextBox.Text = GetCellValue(currentRow, 9);
            invoice.zipTextBox.Text = GetCellValue(currentRow, 10);
            invoice.cityTextBox.Text = GetCellValue(currentRow, 11);
            invoice.countryComboBox.Text = GetCellValue(currentRow, 12);
            invoice.stateComboBox.Text = GetCellValue(currentRow, 13);
            invoice.phoneTextBox.Text = GetCellValue(currentRow, 14);
            invoice.noteTextBox.Text = GetCellValue(currentRow, 15);
            invoice.invoiceDatePicker.Value = GetDateValue(currentRow, 16);
            invoice.dueDatePicker.Value = GetDateValue(currentRow, 17);
            invoice.createdDateTextBox.Text = string.IsNullOrEmpty(GetCellValue(currentRow, 18)) ? "" : Convert.ToDateTime(GetCellValue(currentRow, 18)).ToString("MM/dd/yyyy HH:mm:ss");
            invoice.modifyDatePicker.Value = GetDateValue(currentRow, 19);
            invoice.modifiedByComboBox.Text = GetCellValue(currentRow, 20);
            invoice.txtId.Text = GetCellValue(currentRow, 21);

            invoice.newBtn.Visible = false;
            invoice.createdDateTextBox.ReadOnly = true;

            invoice.ShowDialog();
            RefreshUserData();
        }

        private string GetCellValue(DataGridViewRow row, int columnIndex)
        {
            return row.Cells[columnIndex].Value?.ToString();
        }

        private DateTime GetDateValue(DataGridViewRow row, int columnIndex)
        {
            string cellValue = GetCellValue(row, columnIndex);
            if (DateTime.TryParse(cellValue, out DateTime dateValue))
            {
                return dateValue;
            }
            return DateTime.Now; // Default value if parsing fails
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void newInvoiceBtn_Click(object sender, EventArgs e)
        {
           
            CreateNewInvoice();
     
        }



        private void CreateNewInvoice()
        {
            InvoiceUpdate invoice = new InvoiceUpdate();

            invoice.saveBtn.Visible = false;
            invoice.deleteBtn.Visible = false;
            invoice.label14.Text = "Add a new invoice";
            invoice.invoiceTitleTextBox.Visible = false;
            invoice.newBtn.Location = new Point(572, 21);
            invoice.label2.Visible = false;
            invoice.invoiceNumberTextBox.Visible = false;
            invoice.statusComboBox.SelectedItem = "Pending";
            invoice.label16.Visible = false;
            invoice.createdDateTextBox.Visible = false;
            invoice.modifyDate.Visible = false;
            invoice.modifyDatePicker.Visible = false;
            invoice.modifiedBy.Visible = false;
            invoice.modifiedByComboBox.Visible = false;

            invoice.ShowDialog();

            RefreshUserData();
        }

        private void RefreshUserData()
        {
            InvoiceData();
            library.ResetSearch(firstNameSearch, lastNameSearch, invoiceSearch, phoneSearch, companySearch, statusSearch);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshUserData();
        }
    }
}
