﻿namespace WindowsFormsApp1
{
    partial class UserList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZipPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateProvinceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Email,
            this.UserFirstName,
            this.UserLastName,
            this.Company,
            this.Address1,
            this.Address2,
            this.ZipPostalCode,
            this.City,
            this.Country,
            this.StateProvinceId,
            this.PhoneNumber,
            this.CreateDate,
            this.ModifyDate,
            this.ModifiedBy,
            this.uid});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(0, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.DividerHeight = 3;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(830, 456);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 70;
            // 
            // UserFirstName
            // 
            this.UserFirstName.DataPropertyName = "UserFirstName";
            this.UserFirstName.HeaderText = "First Name";
            this.UserFirstName.MinimumWidth = 8;
            this.UserFirstName.Name = "UserFirstName";
            this.UserFirstName.ReadOnly = true;
            this.UserFirstName.Width = 109;
            // 
            // UserLastName
            // 
            this.UserLastName.DataPropertyName = "UserLastName";
            this.UserLastName.HeaderText = "Last Name";
            this.UserLastName.Name = "UserLastName";
            this.UserLastName.ReadOnly = true;
            this.UserLastName.Width = 107;
            // 
            // Company
            // 
            this.Company.DataPropertyName = "Company";
            this.Company.HeaderText = "Company name";
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            this.Company.Width = 141;
            // 
            // Address1
            // 
            this.Address1.DataPropertyName = "Address1";
            this.Address1.HeaderText = "Address";
            this.Address1.Name = "Address1";
            this.Address1.ReadOnly = true;
            this.Address1.Width = 89;
            // 
            // Address2
            // 
            this.Address2.DataPropertyName = "Address2";
            this.Address2.HeaderText = "Address 2";
            this.Address2.Name = "Address2";
            this.Address2.ReadOnly = true;
            this.Address2.Width = 102;
            // 
            // ZipPostalCode
            // 
            this.ZipPostalCode.DataPropertyName = "ZipPostalCode";
            this.ZipPostalCode.HeaderText = "Zip Code";
            this.ZipPostalCode.Name = "ZipPostalCode";
            this.ZipPostalCode.ReadOnly = true;
            this.ZipPostalCode.Width = 93;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 59;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            this.Country.Width = 89;
            // 
            // StateProvinceId
            // 
            this.StateProvinceId.DataPropertyName = "StateProvinceId";
            this.StateProvinceId.HeaderText = "State";
            this.StateProvinceId.Name = "StateProvinceId";
            this.StateProvinceId.ReadOnly = true;
            this.StateProvinceId.Width = 68;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Phone";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 76;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "Create Date";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            this.CreateDate.Width = 114;
            // 
            // ModifyDate
            // 
            this.ModifyDate.DataPropertyName = "ModifyDate";
            this.ModifyDate.HeaderText = "Modify Date";
            this.ModifyDate.Name = "ModifyDate";
            this.ModifyDate.ReadOnly = true;
            this.ModifyDate.Width = 119;
            // 
            // ModifiedBy
            // 
            this.ModifiedBy.DataPropertyName = "ModifiedBy";
            this.ModifiedBy.HeaderText = "Modified by";
            this.ModifiedBy.Name = "ModifiedBy";
            this.ModifiedBy.ReadOnly = true;
            this.ModifiedBy.Width = 116;
            // 
            // uid
            // 
            this.uid.DataPropertyName = "UID";
            this.uid.HeaderText = "uid";
            this.uid.Name = "uid";
            this.uid.ReadOnly = true;
            this.uid.Visible = false;
            this.uid.Width = 56;
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
            this.panel1.Size = new System.Drawing.Size(830, 76);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.label4.Location = new System.Drawing.Point(320, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(308, 15);
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
            this.label1.Location = new System.Drawing.Point(107, 15);
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
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(830, 532);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "UserList";
            this.Text = "UserList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newUserBtn;
        private System.Windows.Forms.TextBox firstNameSearch;
        private System.Windows.Forms.TextBox phoneSearch;
        private System.Windows.Forms.TextBox zipSearch;
        private System.Windows.Forms.TextBox lastNameSearch;
        private System.Windows.Forms.TextBox stateSearch;
        private System.Windows.Forms.TextBox companySearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZipPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateProvinceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn uid;
    }
}