namespace WindowsFormsApp1
{
    partial class userListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.stateSearch = new System.Windows.Forms.TextBox();
            this.companySearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneSearch = new System.Windows.Forms.TextBox();
            this.zipSearch = new System.Windows.Forms.TextBox();
            this.lastNameSearch = new System.Windows.Forms.TextBox();
            this.firstNameSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newUserBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ZipCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModifyDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModifiedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.stateSearch);
            this.panel1.Controls.Add(this.companySearch);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.phoneSearch);
            this.panel1.Controls.Add(this.zipSearch);
            this.panel1.Controls.Add(this.lastNameSearch);
            this.panel1.Controls.Add(this.firstNameSearch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.newUserBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 76);
            this.panel1.TabIndex = 3;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.ForeColor = System.Drawing.Color.White;
            this.refreshBtn.Location = new System.Drawing.Point(10, 6);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(72, 67);
            this.refreshBtn.TabIndex = 18;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // stateSearch
            // 
            this.stateSearch.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.stateSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stateSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateSearch.ForeColor = System.Drawing.Color.White;
            this.stateSearch.Location = new System.Drawing.Point(570, 46);
            this.stateSearch.Name = "stateSearch";
            this.stateSearch.Size = new System.Drawing.Size(100, 19);
            this.stateSearch.TabIndex = 17;
            this.stateSearch.TextChanged += new System.EventHandler(this.stateSearch_TextChanged);
            // 
            // companySearch
            // 
            this.companySearch.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.companySearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.companySearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companySearch.ForeColor = System.Drawing.Color.White;
            this.companySearch.Location = new System.Drawing.Point(570, 12);
            this.companySearch.Name = "companySearch";
            this.companySearch.Size = new System.Drawing.Size(100, 19);
            this.companySearch.TabIndex = 16;
            this.companySearch.TextChanged += new System.EventHandler(this.companySearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(532, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(513, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Company";
            // 
            // phoneSearch
            // 
            this.phoneSearch.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.phoneSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneSearch.ForeColor = System.Drawing.Color.White;
            this.phoneSearch.Location = new System.Drawing.Point(366, 46);
            this.phoneSearch.Name = "phoneSearch";
            this.phoneSearch.Size = new System.Drawing.Size(100, 19);
            this.phoneSearch.TabIndex = 13;
            this.phoneSearch.TextChanged += new System.EventHandler(this.phoneSearch_TextChanged);
            // 
            // zipSearch
            // 
            this.zipSearch.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.zipSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zipSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipSearch.ForeColor = System.Drawing.Color.White;
            this.zipSearch.Location = new System.Drawing.Point(366, 12);
            this.zipSearch.Name = "zipSearch";
            this.zipSearch.Size = new System.Drawing.Size(100, 19);
            this.zipSearch.TabIndex = 12;
            this.zipSearch.TextChanged += new System.EventHandler(this.zipSearch_TextChanged);
            // 
            // lastNameSearch
            // 
            this.lastNameSearch.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lastNameSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameSearch.ForeColor = System.Drawing.Color.White;
            this.lastNameSearch.Location = new System.Drawing.Point(170, 46);
            this.lastNameSearch.Name = "lastNameSearch";
            this.lastNameSearch.Size = new System.Drawing.Size(100, 19);
            this.lastNameSearch.TabIndex = 11;
            this.lastNameSearch.TextChanged += new System.EventHandler(this.lastNameSearch_TextChanged);
            // 
            // firstNameSearch
            // 
            this.firstNameSearch.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.firstNameSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameSearch.ForeColor = System.Drawing.Color.White;
            this.firstNameSearch.Location = new System.Drawing.Point(170, 12);
            this.firstNameSearch.Name = "firstNameSearch";
            this.firstNameSearch.Size = new System.Drawing.Size(100, 18);
            this.firstNameSearch.TabIndex = 10;
            this.firstNameSearch.TextChanged += new System.EventHandler(this.firstNameSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(322, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(310, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Zip Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(106, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // newUserBtn
            // 
            this.newUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newUserBtn.BackColor = System.Drawing.Color.Chocolate;
            this.newUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserBtn.ForeColor = System.Drawing.Color.White;
            this.newUserBtn.Location = new System.Drawing.Point(701, 39);
            this.newUserBtn.Name = "newUserBtn";
            this.newUserBtn.Size = new System.Drawing.Size(102, 31);
            this.newUserBtn.TabIndex = 0;
            this.newUserBtn.Text = "New User";
            this.newUserBtn.UseVisualStyleBackColor = false;
            this.newUserBtn.Click += new System.EventHandler(this.newUserBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 437);
            this.panel2.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Email,
            this.FirstName,
            this.LastName,
            this.CompanyName,
            this.Address,
            this.Address2,
            this.ZipCode,
            this.City,
            this.Country,
            this.State,
            this.Phone,
            this.Fax,
            this.Description,
            this.CreateDate,
            this.CreateBy,
            this.ModifyDate,
            this.ModifiedBy,
            this.UID});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(816, 437);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Email
            // 
            this.Email.Text = "Email";
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 80;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 80;
            // 
            // CompanyName
            // 
            this.CompanyName.Text = "Company Name";
            this.CompanyName.Width = 80;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 80;
            // 
            // Address2
            // 
            this.Address2.Text = "Address2";
            this.Address2.Width = 80;
            // 
            // ZipCode
            // 
            this.ZipCode.Text = "Zip Code";
            // 
            // City
            // 
            this.City.Text = "City";
            // 
            // Country
            // 
            this.Country.Text = "Country";
            // 
            // State
            // 
            this.State.Text = "State";
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            // 
            // Fax
            // 
            this.Fax.Text = "Fax";
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 80;
            // 
            // CreateDate
            // 
            this.CreateDate.Text = "Create Date";
            this.CreateDate.Width = 80;
            // 
            // CreateBy
            // 
            this.CreateBy.Text = "Create by";
            // 
            // ModifyDate
            // 
            this.ModifyDate.Text = "Modify Date";
            this.ModifyDate.Width = 80;
            // 
            // ModifiedBy
            // 
            this.ModifiedBy.Text = "Modified by";
            this.ModifiedBy.Width = 80;
            // 
            // UID
            // 
            this.UID.Text = "UID";
            this.UID.Width = 0;
            // 
            // userListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(816, 513);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "userListView";
            this.Text = "UserListView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.TextBox stateSearch;
        private System.Windows.Forms.TextBox companySearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneSearch;
        private System.Windows.Forms.TextBox zipSearch;
        private System.Windows.Forms.TextBox lastNameSearch;
        private System.Windows.Forms.TextBox firstNameSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newUserBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader CompanyName;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Address2;
        private System.Windows.Forms.ColumnHeader ZipCode;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader Country;
        private System.Windows.Forms.ColumnHeader State;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader CreateDate;
        private System.Windows.Forms.ColumnHeader ModifyDate;
        private System.Windows.Forms.ColumnHeader ModifiedBy;
        private System.Windows.Forms.ColumnHeader UID;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Fax;
        private System.Windows.Forms.ColumnHeader CreateBy;
    }
}