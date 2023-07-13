namespace WindowsFormsApp1
{
    partial class InvoiceUpdate
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.paymentMethodComboBox = new System.Windows.Forms.ComboBox();
            this.totalAmountUpDown = new System.Windows.Forms.NumericUpDown();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.invoiceNumberTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.createdDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.modifiedByComboBox = new System.Windows.Forms.ComboBox();
            this.modifiedBy = new System.Windows.Forms.Label();
            this.modifyDate = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.contactNametextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.invoiceTitleTextBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.newBtn = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.paymentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.invoiceDatePicker = new System.Windows.Forms.DateTimePicker();
            this.modifyDatePicker = new System.Windows.Forms.DateTimePicker();
            this.userIdComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalAmountUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 54);
            this.panel1.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtId.Location = new System.Drawing.Point(23, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(48, 24);
            this.txtId.TabIndex = 26;
            this.txtId.Text = "ID";
            this.txtId.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 606);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(753, 37);
            this.panel3.TabIndex = 70;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 552);
            this.panel2.TabIndex = 71;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(753, 470);
            this.tabControl1.TabIndex = 69;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.invoiceDatePicker);
            this.tabPage1.Controls.Add(this.dueDatePicker);
            this.tabPage1.Controls.Add(this.paymentDatePicker);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.serviceComboBox);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.paymentMethodComboBox);
            this.tabPage1.Controls.Add(this.totalAmountUpDown);
            this.tabPage1.Controls.Add(this.statusComboBox);
            this.tabPage1.Controls.Add(this.noteTextBox);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.invoiceNumberTextBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(745, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Payment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.ItemHeight = 18;
            this.serviceComboBox.Items.AddRange(new object[] {
            "Select service",
            "Merchant",
            "Service",
            "Consulting",
            "Product",
            "Subscription",
            "Repair",
            "Training",
            "Development"});
            this.serviceComboBox.Location = new System.Drawing.Point(190, 115);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(394, 26);
            this.serviceComboBox.TabIndex = 89;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label19.Location = new System.Drawing.Point(117, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 18);
            this.label19.TabIndex = 90;
            this.label19.Text = "Service";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label17.Location = new System.Drawing.Point(137, 300);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 18);
            this.label17.TabIndex = 88;
            this.label17.Text = "Note";
            // 
            // paymentMethodComboBox
            // 
            this.paymentMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethodComboBox.FormattingEnabled = true;
            this.paymentMethodComboBox.ItemHeight = 18;
            this.paymentMethodComboBox.Items.AddRange(new object[] {
            "Select payment method",
            "Visa",
            "Master",
            "Cash",
            "Check",
            "CC",
            "Paypal",
            "Bank Transfer"});
            this.paymentMethodComboBox.Location = new System.Drawing.Point(190, 177);
            this.paymentMethodComboBox.Name = "paymentMethodComboBox";
            this.paymentMethodComboBox.Size = new System.Drawing.Size(394, 26);
            this.paymentMethodComboBox.TabIndex = 23;
            // 
            // totalAmountUpDown
            // 
            this.totalAmountUpDown.DecimalPlaces = 2;
            this.totalAmountUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountUpDown.Location = new System.Drawing.Point(190, 147);
            this.totalAmountUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.totalAmountUpDown.Name = "totalAmountUpDown";
            this.totalAmountUpDown.Size = new System.Drawing.Size(394, 24);
            this.totalAmountUpDown.TabIndex = 22;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.ItemHeight = 18;
            this.statusComboBox.Items.AddRange(new object[] {
            "Pending",
            "Paid",
            "Void"});
            this.statusComboBox.Location = new System.Drawing.Point(190, 82);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(394, 26);
            this.statusComboBox.TabIndex = 21;
            // 
            // noteTextBox
            // 
            this.noteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTextBox.Location = new System.Drawing.Point(190, 301);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.noteTextBox.Size = new System.Drawing.Size(394, 72);
            this.noteTextBox.TabIndex = 73;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label15.Location = new System.Drawing.Point(110, 243);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 18);
            this.label15.TabIndex = 77;
            this.label15.Text = "Due date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(79, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 76;
            this.label4.Text = "Payment date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label12.Location = new System.Drawing.Point(54, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 18);
            this.label12.TabIndex = 75;
            this.label12.Text = "Payment method";
            // 
            // invoiceNumberTextBox
            // 
            this.invoiceNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.invoiceNumberTextBox.Location = new System.Drawing.Point(190, 50);
            this.invoiceNumberTextBox.Name = "invoiceNumberTextBox";
            this.invoiceNumberTextBox.Size = new System.Drawing.Size(394, 24);
            this.invoiceNumberTextBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(79, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Total amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(124, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Invoice number";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.userIdComboBox);
            this.tabPage2.Controls.Add(this.modifyDatePicker);
            this.tabPage2.Controls.Add(this.createdDateTextBox);
            this.tabPage2.Controls.Add(this.modifiedByComboBox);
            this.tabPage2.Controls.Add(this.modifiedBy);
            this.tabPage2.Controls.Add(this.modifyDate);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.phoneTextBox);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.contactNametextBox);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(745, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contact";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // createdDateTextBox
            // 
            this.createdDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.createdDateTextBox.Location = new System.Drawing.Point(190, 148);
            this.createdDateTextBox.Mask = "00/00/0000 90:00";
            this.createdDateTextBox.Name = "createdDateTextBox";
            this.createdDateTextBox.Size = new System.Drawing.Size(394, 24);
            this.createdDateTextBox.TabIndex = 103;
            this.createdDateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // modifiedByComboBox
            // 
            this.modifiedByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modifiedByComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifiedByComboBox.FormattingEnabled = true;
            this.modifiedByComboBox.ItemHeight = 18;
            this.modifiedByComboBox.Items.AddRange(new object[] {
            "Admin",
            "Manager"});
            this.modifiedByComboBox.Location = new System.Drawing.Point(190, 210);
            this.modifiedByComboBox.Name = "modifiedByComboBox";
            this.modifiedByComboBox.Size = new System.Drawing.Size(394, 26);
            this.modifiedByComboBox.TabIndex = 101;
            this.modifiedByComboBox.SelectedIndexChanged += new System.EventHandler(this.modifiedByComboBox_SelectedIndexChanged);
            // 
            // modifiedBy
            // 
            this.modifiedBy.AutoSize = true;
            this.modifiedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.modifiedBy.Location = new System.Drawing.Point(88, 213);
            this.modifiedBy.Name = "modifiedBy";
            this.modifiedBy.Size = new System.Drawing.Size(83, 18);
            this.modifiedBy.TabIndex = 100;
            this.modifiedBy.Text = "Modified by";
            // 
            // modifyDate
            // 
            this.modifyDate.AutoSize = true;
            this.modifyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.modifyDate.Location = new System.Drawing.Point(87, 182);
            this.modifyDate.Name = "modifyDate";
            this.modifyDate.Size = new System.Drawing.Size(84, 18);
            this.modifyDate.TabIndex = 99;
            this.modifyDate.Text = "Modify date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label16.Location = new System.Drawing.Point(79, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 18);
            this.label16.TabIndex = 98;
            this.label16.Text = "Created date";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(190, 117);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(394, 24);
            this.phoneTextBox.TabIndex = 96;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label13.Location = new System.Drawing.Point(120, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 18);
            this.label13.TabIndex = 97;
            this.label13.Text = "Phone";
            // 
            // contactNametextBox
            // 
            this.contactNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.contactNametextBox.Location = new System.Drawing.Point(190, 84);
            this.contactNametextBox.Name = "contactNametextBox";
            this.contactNametextBox.Size = new System.Drawing.Size(394, 24);
            this.contactNametextBox.TabIndex = 94;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(70, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 18);
            this.label18.TabIndex = 95;
            this.label18.Text = "Contact name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 93;
            this.label1.Text = "User ID";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.stateComboBox);
            this.tabPage3.Controls.Add(this.countryComboBox);
            this.tabPage3.Controls.Add(this.addressTextBox);
            this.tabPage3.Controls.Add(this.address2TextBox);
            this.tabPage3.Controls.Add(this.zipTextBox);
            this.tabPage3.Controls.Add(this.cityTextBox);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(745, 444);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Address";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.ItemHeight = 18;
            this.stateComboBox.Location = new System.Drawing.Point(190, 209);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(394, 26);
            this.stateComboBox.TabIndex = 48;
            this.stateComboBox.SelectedIndexChanged += new System.EventHandler(this.stateComboBox_SelectedIndexChanged_1);
            // 
            // countryComboBox
            // 
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.ItemHeight = 18;
            this.countryComboBox.Location = new System.Drawing.Point(190, 177);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(394, 26);
            this.countryComboBox.TabIndex = 47;
            this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.countryComboBox_SelectedIndexChanged_1);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(190, 50);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(394, 24);
            this.addressTextBox.TabIndex = 43;
            // 
            // address2TextBox
            // 
            this.address2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2TextBox.Location = new System.Drawing.Point(190, 82);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(394, 24);
            this.address2TextBox.TabIndex = 44;
            // 
            // zipTextBox
            // 
            this.zipTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipTextBox.Location = new System.Drawing.Point(190, 115);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(394, 24);
            this.zipTextBox.TabIndex = 45;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(190, 147);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(394, 24);
            this.cityTextBox.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label11.Location = new System.Drawing.Point(64, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 18);
            this.label11.TabIndex = 49;
            this.label11.Text = "State / province";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label10.Location = new System.Drawing.Point(114, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 54;
            this.label10.Text = "Country";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(141, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 18);
            this.label9.TabIndex = 53;
            this.label9.Text = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(59, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 18);
            this.label8.TabIndex = 52;
            this.label8.Text = "Zip / postal code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(59, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "Billing address 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(71, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 50;
            this.label6.Text = "Billing address";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.invoiceTitleTextBox);
            this.panel5.Controls.Add(this.deleteBtn);
            this.panel5.Controls.Add(this.saveBtn);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.newBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(753, 82);
            this.panel5.TabIndex = 68;
            // 
            // invoiceTitleTextBox
            // 
            this.invoiceTitleTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.invoiceTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.invoiceTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceTitleTextBox.Location = new System.Drawing.Point(142, 29);
            this.invoiceTitleTextBox.Name = "invoiceTitleTextBox";
            this.invoiceTitleTextBox.Size = new System.Drawing.Size(183, 28);
            this.invoiceTitleTextBox.TabIndex = 5;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.deleteBtn.Location = new System.Drawing.Point(650, 21);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(89, 43);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(183)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.saveBtn.Location = new System.Drawing.Point(555, 21);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(89, 43);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 31);
            this.label14.TabIndex = 2;
            this.label14.Text = "Invoice #";
            // 
            // newBtn
            // 
            this.newBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newBtn.BackColor = System.Drawing.Color.Chocolate;
            this.newBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.newBtn.Location = new System.Drawing.Point(382, 20);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(167, 43);
            this.newBtn.TabIndex = 71;
            this.newBtn.Text = "New Invoice";
            this.newBtn.UseVisualStyleBackColor = false;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label20.Location = new System.Drawing.Point(91, 272);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 18);
            this.label20.TabIndex = 91;
            this.label20.Text = "Invoice date";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.Control;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label21.Location = new System.Drawing.Point(523, 148);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 20);
            this.label21.TabIndex = 93;
            this.label21.Text = "USD";
            // 
            // paymentDatePicker
            // 
            this.paymentDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentDatePicker.CustomFormat = " ";
            this.paymentDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.paymentDatePicker.Location = new System.Drawing.Point(190, 210);
            this.paymentDatePicker.Name = "paymentDatePicker";
            this.paymentDatePicker.Size = new System.Drawing.Size(394, 24);
            this.paymentDatePicker.TabIndex = 94;
            this.paymentDatePicker.Value = new System.DateTime(9998, 9, 9, 0, 0, 0, 0);
            this.paymentDatePicker.ValueChanged += new System.EventHandler(this.paymentDateTextBox_ValueChanged);
            // 
            // dueDatePicker
            // 
            this.dueDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDatePicker.CustomFormat = " ";
            this.dueDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dueDatePicker.Location = new System.Drawing.Point(190, 241);
            this.dueDatePicker.Name = "dueDatePicker";
            this.dueDatePicker.Size = new System.Drawing.Size(394, 24);
            this.dueDatePicker.TabIndex = 95;
            this.dueDatePicker.Value = new System.DateTime(9998, 9, 9, 0, 0, 0, 0);
            this.dueDatePicker.ValueChanged += new System.EventHandler(this.dueDateTextBox_ValueChanged);
            // 
            // invoiceDatePicker
            // 
            this.invoiceDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceDatePicker.CustomFormat = " ";
            this.invoiceDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.invoiceDatePicker.Location = new System.Drawing.Point(190, 271);
            this.invoiceDatePicker.Name = "invoiceDatePicker";
            this.invoiceDatePicker.Size = new System.Drawing.Size(394, 24);
            this.invoiceDatePicker.TabIndex = 96;
            this.invoiceDatePicker.Value = new System.DateTime(9998, 9, 9, 0, 0, 0, 0);
            this.invoiceDatePicker.ValueChanged += new System.EventHandler(this.invoiceDateTextBox_ValueChanged);
            // 
            // modifyDatePicker
            // 
            this.modifyDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyDatePicker.CustomFormat = " ";
            this.modifyDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.modifyDatePicker.Location = new System.Drawing.Point(190, 180);
            this.modifyDatePicker.Name = "modifyDatePicker";
            this.modifyDatePicker.Size = new System.Drawing.Size(394, 24);
            this.modifyDatePicker.TabIndex = 104;
            this.modifyDatePicker.Value = new System.DateTime(9998, 9, 9, 0, 0, 0, 0);
            // 
            // userIdComboBox
            // 
            this.userIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdComboBox.FormattingEnabled = true;
            this.userIdComboBox.ItemHeight = 18;
            this.userIdComboBox.Items.AddRange(new object[] {
            "Admin",
            "Manager"});
            this.userIdComboBox.Location = new System.Drawing.Point(190, 50);
            this.userIdComboBox.Name = "userIdComboBox";
            this.userIdComboBox.Size = new System.Drawing.Size(394, 26);
            this.userIdComboBox.TabIndex = 105;
            this.userIdComboBox.SelectedIndexChanged += new System.EventHandler(this.userIdComboBox_SelectedIndexChanged);
            // 
            // InvoiceUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 643);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "InvoiceUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InvoiceUpdate";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalAmountUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox invoiceNumberTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Button deleteBtn;
        public System.Windows.Forms.Button saveBtn;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Button newBtn;
        public System.Windows.Forms.ComboBox statusComboBox;
        public System.Windows.Forms.ComboBox paymentMethodComboBox;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.NumericUpDown totalAmountUpDown;
        public System.Windows.Forms.TextBox invoiceTitleTextBox;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.MaskedTextBox createdDateTextBox;
        public System.Windows.Forms.ComboBox modifiedByComboBox;
        public System.Windows.Forms.Label modifiedBy;
        public System.Windows.Forms.Label modifyDate;
        public System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox contactNametextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox stateComboBox;
        public System.Windows.Forms.ComboBox countryComboBox;
        public System.Windows.Forms.TextBox addressTextBox;
        public System.Windows.Forms.TextBox address2TextBox;
        public System.Windows.Forms.TextBox zipTextBox;
        public System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox serviceComboBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.DateTimePicker paymentDatePicker;
        public System.Windows.Forms.DateTimePicker invoiceDatePicker;
        public System.Windows.Forms.DateTimePicker dueDatePicker;
        public System.Windows.Forms.DateTimePicker modifyDatePicker;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox userIdComboBox;
    }
}