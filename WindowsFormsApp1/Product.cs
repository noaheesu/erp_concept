using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Product : Form
    {
        #region Fields and Properties
        private DataTable dt = new DataTable();
        private DataView dv;
        public Library library = new Library();
        #endregion Fields and Properties

        #region Constructor and Disposer
        public Product()
        {
            InitializeComponent();
            ProductData();
        }
        #endregion Constructor and Disposer

        #region Private Method
        private void ProductData()
        {
            dt = library.LoadProductData(dataGridView1);

            //For RowFilter Name Search
            dv = dt.DefaultView;
        }

        private void EditProductInfo()
        {
            ProductUpdate productUpdate = new ProductUpdate();

            DataGridViewRow currentRow = dataGridView1.CurrentRow;
            productUpdate.productId.Text = GetCellValue(currentRow, 13);
            productUpdate.productNameTextBox.Text = GetCellValue(currentRow, 1);
            productUpdate.skuTextBox.Text = GetCellValue(currentRow, 2);
            productUpdate.priceUpDown.Text = GetCellValue(currentRow, 3);
            productUpdate.stockQuantityUpDown.Text = GetCellValue(currentRow, 4);
            productUpdate.categoriesTextBox.Text = GetCellValue(currentRow, 7);
            bool value = Convert.ToBoolean(currentRow.Cells[5].Value);
            productUpdate.publishedCheckBox.Checked = value;
            productUpdate.weightUpDown.Text = GetCellValue(currentRow, 8);
            productUpdate.lengthUpDown.Text = GetCellValue(currentRow, 9);
            productUpdate.widthUpDown.Text = GetCellValue(currentRow, 10);
            productUpdate.heightUpDown.Text = GetCellValue(currentRow, 11);
            productUpdate.descriptionTextBox.Text = GetCellValue(currentRow, 6);
            productUpdate.createDateTextBox.Text = string.IsNullOrEmpty(GetCellValue(currentRow, 12))
                ? ""
                : Convert.ToDateTime(GetCellValue(currentRow, 12)).ToString("MM/dd/yyyy HH:mm:ss");

            // Display picture
            string imageUrl = currentRow.Cells[0].Value.ToString();
            using (var webClient = new System.Net.WebClient())
            {
                try
                {
                    byte[] imageData = webClient.DownloadData(imageUrl);
                    using (var memoryStream = new MemoryStream(imageData))
                    {
                        productUpdate.pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Set the SizeMode to Zoom

                        productUpdate.pictureBox.Image = Image.FromStream(memoryStream);
                    }
                }
                catch (Exception ex)
                {
                    // Handle the error if the image cannot be downloaded or loaded
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            productUpdate.pictureUrlTextBox.Text = GetCellValue(currentRow, 0);

           // productUpdate.pictureUrlTextBox.Visible = false;
            productUpdate.createNewUserBtn.Visible = false;

            productUpdate.ShowDialog();

            RefreshUserData();
        }

        private void RefreshUserData()
        {
            ProductData();
            ResetSearch();
        }

        public void ResetSearch()
        {
            productNameSearch.Clear();
            categorySearch.Clear();
            publishedSearch.Clear();
            skuSearch.Clear();
        }

        private string GetCellValue(DataGridViewRow currentRow, int columnIndex)
        {
            return currentRow.Cells[columnIndex].Value?.ToString();
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditProductInfo();
        }

        private void newProductBtn_Click(object sender, EventArgs e)
        {
            ProductUpdate newProduct = new ProductUpdate();
            newProduct.saveBtn.Visible = false;
            newProduct.deleteBtn.Visible = false;
            newProduct.createDateLabel.Visible = false;
            newProduct.createDateTextBox.Visible = false;
            newProduct.createNewUserBtn.Location = new Point(617, 21);
            newProduct.pictureBox.Visible = false;
            newProduct.pictureUrlTextBox.Location = new Point(258, 509);
            newProduct.label13.Location = new Point(152, 512);
            newProduct.Size = new Size(837, 669);
            newProduct.ShowDialog();

            RefreshUserData();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshUserData();
        }
        #endregion Event Handlers
    }
}
