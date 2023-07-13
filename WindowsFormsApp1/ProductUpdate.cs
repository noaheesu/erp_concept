using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ProductUpdate : Form
    {
        #region Fields and Properties
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["WinformDB"].ConnectionString;
        #endregion Fields and Properties

        #region Constructor and Disposer
        public ProductUpdate()
        {
            InitializeComponent();
        }
        #endregion Constructor and Disposer

        #region Private Method
        private bool newProductValidate()
        {
            bool rv = true;

            if (string.IsNullOrWhiteSpace(productNameTextBox.Text))
            {
                MessageBox.Show("Please enter product name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                productNameTextBox.Focus();
                rv = false;
            }
            else if (string.IsNullOrWhiteSpace(priceUpDown.Text))
            {
                MessageBox.Show("Please enter price.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                priceUpDown.Focus();
                rv = false;
            }

            return rv;
        }

        private void CreateNewProduct()
        {
            if (!newProductValidate())
                return;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string uid = Uid.UserId;
                string productName = this.productNameTextBox.Text;
                string sku = this.skuTextBox.Text;
                string price = this.priceUpDown.Text;
                string stockQuantity = this.stockQuantityUpDown.Text;
                string categories = this.categoriesTextBox.Text;
                bool published = this.publishedCheckBox.Checked;
                string weight = this.weightUpDown.Text;
                string length = this.lengthUpDown.Text;
                string width = this.widthUpDown.Text;
                string height = this.heightUpDown.Text;
                string description = this.descriptionTextBox.Text;
                string picture = this.pictureUrlTextBox.Text;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                try
                {
                    //cmd.Parameters.Clear();

                    cmd.CommandText =
                    "INSERT INTO Products ([UserID], ProductName, SKU, Price, StockQuantity, Categories, Published, Weight, Length, Width, Height, Description )" +
                    "VALUES (@UID, @ProductName, @SKU, @Price, @StockQuantity, @Categories, @Published, @Weight, @Length, @Width, @Height, @Description )" +
                    "SELECT @@IDENTITY;";

                    cmd.Parameters.AddWithValue("@UID", uid);
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@SKU", sku);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@StockQuantity", stockQuantity);
                    cmd.Parameters.AddWithValue("@Categories", categories);
                    cmd.Parameters.AddWithValue("@Published", published);
                    cmd.Parameters.AddWithValue("@Weight", weight);
                    cmd.Parameters.AddWithValue("@Length", length);
                    cmd.Parameters.AddWithValue("@Width", width);
                    cmd.Parameters.AddWithValue("@Height", height);
                    cmd.Parameters.AddWithValue("@Description", description);

                   // cmd.ExecuteNonQuery(); //// Execute the INSERT command
                    int newProductId = Convert.ToInt32(cmd.ExecuteScalar());

                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    saveBtn.Visible = true;
                    deleteBtn.Visible = true;
                    createNewUserBtn.Visible = false;
                    createDateTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    productId.Text = newProductId.ToString();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while creating the product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateProductInfo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string productName = productNameTextBox.Text;
                string sku = skuTextBox.Text;
                string price = priceUpDown.Text;
                string quantity = stockQuantityUpDown.Text;
                string categories = categoriesTextBox.Text;
                bool published = this.publishedCheckBox.Checked;
                // string color = COLOR.Text;
                string weight = weightUpDown.Text;
                string length = lengthUpDown.Text;
                string width = widthUpDown.Text;
                string height = heightUpDown.Text;
                string description = descriptionTextBox.Text;
                //string picture = pictureBox.Text;
                string pictureUrl = pictureUrlTextBox.Text;
                string id = productId.Text;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText =
                    "UPDATE Products " +
                    "SET ProductName = @ProductName, SKU = @SKU, Price = @Price, StockQuantity = @Quantity, Categories = @Categories, Published = @Published, [Weight] = @Weight, [Length] = @Length, [Width] = @width, [Height] = @Height, Description = @Description, Picture = @PictureUrl " +
                    "WHERE ID = @Id";

                cmd.Parameters.AddWithValue("@ProductName", productName);
                cmd.Parameters.AddWithValue("@SKU", sku);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Categories", categories);
                cmd.Parameters.AddWithValue("@Published", published);
                cmd.Parameters.AddWithValue("@Weight", weight);
                cmd.Parameters.AddWithValue("@Length", length);
                cmd.Parameters.AddWithValue("@Width", width);
                cmd.Parameters.AddWithValue("@Height", height);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@PictureUrl", pictureUrl);
                cmd.Parameters.AddWithValue("@Id", id);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteProduct()
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string productId = this.productId.Text;

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText =
                        "DELETE FROM Products " +
                        "WHERE ID = @ProductId";

                    cmd.Parameters.AddWithValue("@ProductId", productId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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

        private void createNewUserBtn_Click(object sender, EventArgs e)
        {
            CreateNewProduct();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            UpdateProductInfo();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }
        #endregion Event Handlers
    }
}
