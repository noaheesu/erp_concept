namespace WindowsFormsApp1
{
    partial class UserUpdate
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
            this.displayBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.modifyDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.modifiedByComboBox = new System.Windows.Forms.ComboBox();
            this.createByComboBox = new System.Windows.Forms.ComboBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.createNewUserBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.modifiedBy = new System.Windows.Forms.Label();
            this.modifyDate = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 54);
            this.panel1.TabIndex = 0;
            // 
            // displayBox
            // 
            this.displayBox.BackColor = System.Drawing.Color.Gainsboro;
            this.displayBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBox.Location = new System.Drawing.Point(239, 26);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(234, 31);
            this.displayBox.TabIndex = 5;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.deleteBtn.Location = new System.Drawing.Point(756, 21);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(89, 43);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(223, 31);
            this.label13.TabIndex = 2;
            this.label13.Text = "Edit user details -";
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(183)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.saveBtn.Location = new System.Drawing.Point(661, 21);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(89, 43);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.txtUID);
            this.panel2.Controls.Add(this.modifyDateTextBox);
            this.panel2.Controls.Add(this.phoneTextBox);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.modifiedByComboBox);
            this.panel2.Controls.Add(this.createByComboBox);
            this.panel2.Controls.Add(this.stateComboBox);
            this.panel2.Controls.Add(this.countryComboBox);
            this.panel2.Controls.Add(this.createNewUserBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.modifiedBy);
            this.panel2.Controls.Add(this.modifyDate);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.descriptionTextBox);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.faxTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lastNameTextBox);
            this.panel2.Controls.Add(this.companyTextBox);
            this.panel2.Controls.Add(this.addressTextBox);
            this.panel2.Controls.Add(this.address2TextBox);
            this.panel2.Controls.Add(this.zipTextBox);
            this.panel2.Controls.Add(this.cityTextBox);
            this.panel2.Controls.Add(this.firstNameTextBox);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.emailTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 672);
            this.panel2.TabIndex = 1;
            // 
            // txtUID
            // 
            this.txtUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtUID.Location = new System.Drawing.Point(12, 102);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(122, 24);
            this.txtUID.TabIndex = 17;
            this.txtUID.Visible = false;
            // 
            // modifyDateTextBox
            // 
            this.modifyDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.modifyDateTextBox.Location = new System.Drawing.Point(258, 569);
            this.modifyDateTextBox.Mask = "00/00/0000 90:00";
            this.modifyDateTextBox.Name = "modifyDateTextBox";
            this.modifyDateTextBox.ReadOnly = true;
            this.modifyDateTextBox.Size = new System.Drawing.Size(394, 24);
            this.modifyDateTextBox.TabIndex = 70;
            this.modifyDateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(258, 401);
            this.phoneTextBox.Mask = "(999) 000-0000";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(394, 26);
            this.phoneTextBox.TabIndex = 69;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.displayBox);
            this.panel4.Controls.Add(this.deleteBtn);
            this.panel4.Controls.Add(this.saveBtn);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(859, 82);
            this.panel4.TabIndex = 68;
            // 
            // modifiedByComboBox
            // 
            this.modifiedByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modifiedByComboBox.FormattingEnabled = true;
            this.modifiedByComboBox.ItemHeight = 13;
            this.modifiedByComboBox.Location = new System.Drawing.Point(258, 600);
            this.modifiedByComboBox.Name = "modifiedByComboBox";
            this.modifiedByComboBox.Size = new System.Drawing.Size(394, 21);
            this.modifiedByComboBox.TabIndex = 67;
            this.modifiedByComboBox.SelectedIndexChanged += new System.EventHandler(this.modifiedByComboBox_SelectedIndexChanged);
            // 
            // createByComboBox
            // 
            this.createByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.createByComboBox.FormattingEnabled = true;
            this.createByComboBox.ItemHeight = 13;
            this.createByComboBox.Location = new System.Drawing.Point(258, 540);
            this.createByComboBox.Name = "createByComboBox";
            this.createByComboBox.Size = new System.Drawing.Size(394, 21);
            this.createByComboBox.TabIndex = 13;
            this.createByComboBox.SelectedIndexChanged += new System.EventHandler(this.createByComboBox_SelectedIndexChanged);
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.ItemHeight = 13;
            this.stateComboBox.Location = new System.Drawing.Point(258, 369);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(394, 21);
            this.stateComboBox.TabIndex = 9;
            this.stateComboBox.SelectedIndexChanged += new System.EventHandler(this.stateComboBox_SelectedIndexChanged);
            // 
            // countryComboBox
            // 
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.ItemHeight = 13;
            this.countryComboBox.Location = new System.Drawing.Point(258, 342);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(394, 21);
            this.countryComboBox.TabIndex = 8;
            this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.countryComboBox_SelectedIndexChanged);
            // 
            // createNewUserBtn
            // 
            this.createNewUserBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.createNewUserBtn.BackColor = System.Drawing.Color.Chocolate;
            this.createNewUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewUserBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.createNewUserBtn.Location = new System.Drawing.Point(365, 585);
            this.createNewUserBtn.Name = "createNewUserBtn";
            this.createNewUserBtn.Size = new System.Drawing.Size(167, 43);
            this.createNewUserBtn.TabIndex = 6;
            this.createNewUserBtn.Text = "New User";
            this.createNewUserBtn.UseVisualStyleBackColor = false;
            this.createNewUserBtn.Click += new System.EventHandler(this.createNewUserBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 635);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(859, 37);
            this.panel3.TabIndex = 66;
            // 
            // modifiedBy
            // 
            this.modifiedBy.AutoSize = true;
            this.modifiedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.modifiedBy.Location = new System.Drawing.Point(124, 599);
            this.modifiedBy.Name = "modifiedBy";
            this.modifiedBy.Size = new System.Drawing.Size(83, 18);
            this.modifiedBy.TabIndex = 64;
            this.modifiedBy.Text = "Modified by";
            // 
            // modifyDate
            // 
            this.modifyDate.AutoSize = true;
            this.modifyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.modifyDate.Location = new System.Drawing.Point(124, 569);
            this.modifyDate.Name = "modifyDate";
            this.modifyDate.Size = new System.Drawing.Size(84, 18);
            this.modifyDate.TabIndex = 62;
            this.modifyDate.Text = "Modify date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label16.Location = new System.Drawing.Point(130, 539);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 18);
            this.label16.TabIndex = 60;
            this.label16.Text = "Created by";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(258, 461);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(394, 72);
            this.descriptionTextBox.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label15.Location = new System.Drawing.Point(125, 461);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 18);
            this.label15.TabIndex = 58;
            this.label15.Text = "Comments";
            // 
            // faxTextBox
            // 
            this.faxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faxTextBox.Location = new System.Drawing.Point(258, 431);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(394, 24);
            this.faxTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(172, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "Fax";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(258, 162);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(394, 24);
            this.lastNameTextBox.TabIndex = 2;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // companyTextBox
            // 
            this.companyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyTextBox.Location = new System.Drawing.Point(258, 193);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(394, 24);
            this.companyTextBox.TabIndex = 3;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(258, 223);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(394, 24);
            this.addressTextBox.TabIndex = 4;
            // 
            // address2TextBox
            // 
            this.address2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2TextBox.Location = new System.Drawing.Point(258, 253);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(394, 24);
            this.address2TextBox.TabIndex = 5;
            // 
            // zipTextBox
            // 
            this.zipTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipTextBox.Location = new System.Drawing.Point(258, 281);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(394, 24);
            this.zipTextBox.TabIndex = 6;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(258, 311);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(394, 24);
            this.cityTextBox.TabIndex = 7;
            this.cityTextBox.TextChanged += new System.EventHandler(this.cityTextBox_TextChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.firstNameTextBox.Location = new System.Drawing.Point(258, 132);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(394, 24);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label12.Location = new System.Drawing.Point(157, 401);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 18);
            this.label12.TabIndex = 30;
            this.label12.Text = "Phone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label11.Location = new System.Drawing.Point(98, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = "State / province";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label10.Location = new System.Drawing.Point(148, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "Country";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(175, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(91, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Zip / postal code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(134, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Address 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(146, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(95, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Company name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(131, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "First name";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.emailTextBox.Location = new System.Drawing.Point(258, 102);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(394, 24);
            this.emailTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email";
            // 
            // UserUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 726);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserUpdate";
            this.Load += new System.EventHandler(this.userUpdate_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox emailTextBox;
        public System.Windows.Forms.TextBox lastNameTextBox;
        public System.Windows.Forms.TextBox companyTextBox;
        public System.Windows.Forms.TextBox addressTextBox;
        public System.Windows.Forms.TextBox address2TextBox;
        public System.Windows.Forms.TextBox zipTextBox;
        public System.Windows.Forms.TextBox cityTextBox;
        public System.Windows.Forms.TextBox firstNameTextBox;
        public System.Windows.Forms.TextBox displayBox;
        private System.Windows.Forms.Label modifiedBy;
        private System.Windows.Forms.Label modifyDate;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button createNewUserBtn;
        public System.Windows.Forms.ComboBox createByComboBox;
        public System.Windows.Forms.ComboBox stateComboBox;
        public System.Windows.Forms.ComboBox countryComboBox;
        public System.Windows.Forms.ComboBox modifiedByComboBox;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.MaskedTextBox phoneTextBox;
        public System.Windows.Forms.MaskedTextBox modifyDateTextBox;
        public System.Windows.Forms.TextBox txtUID;
        public System.Windows.Forms.Button saveBtn;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button deleteBtn;
    }
}