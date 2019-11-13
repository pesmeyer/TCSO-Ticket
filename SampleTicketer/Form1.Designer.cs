namespace SampleTicketer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOverview = new System.Windows.Forms.Button();
            this.btnNewTicket = new System.Windows.Forms.Button();
            this.btnMyTicket = new System.Windows.Forms.Button();
            this.btnLookupTickets = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnSupport = new System.Windows.Forms.Button();
            this.pnlNewTicket = new System.Windows.Forms.Panel();
            this.lbPersonAssigned = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDateCreated = new System.Windows.Forms.DateTimePicker();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.pnlMyTickets = new System.Windows.Forms.Panel();
            this.dvgTicketViewer = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.ticketNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedPriorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personOriginallyAssignedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personAssignedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionInputDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSpentWorkingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTicketDataSet = new SampleTicketer.ITicketDataSet();
            this.ticketTableAdapter = new SampleTicketer.ITicketDataSetTableAdapters.TicketTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlNewTicket.SuspendLayout();
            this.pnlMyTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTicketViewer)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTicketDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlMyTickets);
            this.splitContainer1.Panel2.Controls.Add(this.pnlNewTicket);
            this.splitContainer1.Size = new System.Drawing.Size(1149, 676);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCSO-ITicket";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.flowLayoutPanel1.Controls.Add(this.btnOverview);
            this.flowLayoutPanel1.Controls.Add(this.btnNewTicket);
            this.flowLayoutPanel1.Controls.Add(this.btnMyTicket);
            this.flowLayoutPanel1.Controls.Add(this.btnLookupTickets);
            this.flowLayoutPanel1.Controls.Add(this.btnStatistics);
            this.flowLayoutPanel1.Controls.Add(this.btnSupport);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 544);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnOverview
            // 
            this.btnOverview.FlatAppearance.BorderSize = 0;
            this.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOverview.Location = new System.Drawing.Point(0, 0);
            this.btnOverview.Margin = new System.Windows.Forms.Padding(0);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(201, 54);
            this.btnOverview.TabIndex = 14;
            this.btnOverview.Text = "Overview";
            this.btnOverview.UseVisualStyleBackColor = true;
            // 
            // btnNewTicket
            // 
            this.btnNewTicket.FlatAppearance.BorderSize = 0;
            this.btnNewTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewTicket.Location = new System.Drawing.Point(0, 54);
            this.btnNewTicket.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewTicket.Name = "btnNewTicket";
            this.btnNewTicket.Size = new System.Drawing.Size(201, 54);
            this.btnNewTicket.TabIndex = 15;
            this.btnNewTicket.Text = "New Ticket";
            this.btnNewTicket.UseVisualStyleBackColor = true;
            this.btnNewTicket.Click += new System.EventHandler(this.btnNewTicket_Click);
            // 
            // btnMyTicket
            // 
            this.btnMyTicket.FlatAppearance.BorderSize = 0;
            this.btnMyTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMyTicket.Location = new System.Drawing.Point(0, 108);
            this.btnMyTicket.Margin = new System.Windows.Forms.Padding(0);
            this.btnMyTicket.Name = "btnMyTicket";
            this.btnMyTicket.Size = new System.Drawing.Size(201, 54);
            this.btnMyTicket.TabIndex = 16;
            this.btnMyTicket.Text = "My Tickets";
            this.btnMyTicket.UseVisualStyleBackColor = true;
            this.btnMyTicket.Click += new System.EventHandler(this.btnMyTicket_Click);
            // 
            // btnLookupTickets
            // 
            this.btnLookupTickets.FlatAppearance.BorderSize = 0;
            this.btnLookupTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookupTickets.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLookupTickets.Location = new System.Drawing.Point(0, 162);
            this.btnLookupTickets.Margin = new System.Windows.Forms.Padding(0);
            this.btnLookupTickets.Name = "btnLookupTickets";
            this.btnLookupTickets.Size = new System.Drawing.Size(201, 54);
            this.btnLookupTickets.TabIndex = 17;
            this.btnLookupTickets.Text = "Lookup Tickets";
            this.btnLookupTickets.UseVisualStyleBackColor = true;
            // 
            // btnStatistics
            // 
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStatistics.Location = new System.Drawing.Point(0, 216);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(0);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(201, 54);
            this.btnStatistics.TabIndex = 18;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            // 
            // btnSupport
            // 
            this.btnSupport.FlatAppearance.BorderSize = 0;
            this.btnSupport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSupport.Location = new System.Drawing.Point(0, 270);
            this.btnSupport.Margin = new System.Windows.Forms.Padding(0);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Size = new System.Drawing.Size(201, 54);
            this.btnSupport.TabIndex = 19;
            this.btnSupport.Text = "Support";
            this.btnSupport.UseVisualStyleBackColor = true;
            // 
            // pnlNewTicket
            // 
            this.pnlNewTicket.AccessibleName = "pnlMyTickets";
            this.pnlNewTicket.Controls.Add(this.lbPersonAssigned);
            this.pnlNewTicket.Controls.Add(this.label2);
            this.pnlNewTicket.Controls.Add(this.lblDueDate);
            this.pnlNewTicket.Controls.Add(this.dtpDueDate);
            this.pnlNewTicket.Controls.Add(this.lblDateCreated);
            this.pnlNewTicket.Controls.Add(this.btnSubmit);
            this.pnlNewTicket.Controls.Add(this.lblDescription);
            this.pnlNewTicket.Controls.Add(this.txtDescription);
            this.pnlNewTicket.Controls.Add(this.label6);
            this.pnlNewTicket.Controls.Add(this.dtpDateCreated);
            this.pnlNewTicket.Controls.Add(this.lblPhoneNumber);
            this.pnlNewTicket.Controls.Add(this.txtPhoneNumber);
            this.pnlNewTicket.Controls.Add(this.lblEmail);
            this.pnlNewTicket.Controls.Add(this.txtEmail);
            this.pnlNewTicket.Controls.Add(this.lblLastName);
            this.pnlNewTicket.Controls.Add(this.txtLastName);
            this.pnlNewTicket.Controls.Add(this.lblFirstName);
            this.pnlNewTicket.Controls.Add(this.txtFirstName);
            this.pnlNewTicket.Location = new System.Drawing.Point(1, 0);
            this.pnlNewTicket.Name = "pnlNewTicket";
            this.pnlNewTicket.Size = new System.Drawing.Size(942, 676);
            this.pnlNewTicket.TabIndex = 34;
            // 
            // lbPersonAssigned
            // 
            this.lbPersonAssigned.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbPersonAssigned.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPersonAssigned.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonAssigned.ForeColor = System.Drawing.SystemColors.Window;
            this.lbPersonAssigned.FormattingEnabled = true;
            this.lbPersonAssigned.ItemHeight = 27;
            this.lbPersonAssigned.Items.AddRange(new object[] {
            "Daniel Lutz",
            "Payton Esmeyer",
            "Austin Cauley"});
            this.lbPersonAssigned.Location = new System.Drawing.Point(694, 265);
            this.lbPersonAssigned.Name = "lbPersonAssigned";
            this.lbPersonAssigned.Size = new System.Drawing.Size(223, 108);
            this.lbPersonAssigned.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(548, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 27);
            this.label2.TabIndex = 49;
            this.label2.Text = "Person Assigned";
            // 
            // lblDueDate
            // 
            this.lblDueDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDueDate.Location = new System.Drawing.Point(548, 169);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(87, 27);
            this.lblDueDate.TabIndex = 48;
            this.lblDueDate.Text = "Due Date";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDueDate.CalendarMonthBackground = System.Drawing.SystemColors.ControlDark;
            this.dtpDueDate.Location = new System.Drawing.Point(671, 169);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(246, 26);
            this.dtpDueDate.TabIndex = 47;
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCreated.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDateCreated.Location = new System.Drawing.Point(548, 91);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(117, 27);
            this.lblDateCreated.TabIndex = 46;
            this.lblDateCreated.Text = "Date Created";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSubmit.CausesValidation = false;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(822, 620);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(95, 36);
            this.btnSubmit.TabIndex = 45;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDescription.Location = new System.Drawing.Point(25, 387);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(102, 27);
            this.lblDescription.TabIndex = 44;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDescription.Location = new System.Drawing.Point(30, 417);
            this.txtDescription.MaxLength = 500;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(887, 171);
            this.txtDescription.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(409, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 34);
            this.label6.TabIndex = 42;
            this.label6.Text = "New Ticket";
            // 
            // dtpDateCreated
            // 
            this.dtpDateCreated.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDateCreated.CalendarMonthBackground = System.Drawing.SystemColors.ControlDark;
            this.dtpDateCreated.Location = new System.Drawing.Point(671, 91);
            this.dtpDateCreated.Name = "dtpDateCreated";
            this.dtpDateCreated.Size = new System.Drawing.Size(246, 26);
            this.dtpDateCreated.TabIndex = 41;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPhoneNumber.Location = new System.Drawing.Point(25, 337);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(77, 27);
            this.lblPhoneNumber.TabIndex = 40;
            this.lblPhoneNumber.Text = "Phone #";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPhoneNumber.Location = new System.Drawing.Point(129, 337);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(174, 23);
            this.txtPhoneNumber.TabIndex = 39;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEmail.Location = new System.Drawing.Point(25, 255);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 27);
            this.lblEmail.TabIndex = 38;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Location = new System.Drawing.Point(129, 255);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 23);
            this.txtEmail.TabIndex = 37;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblLastName.Location = new System.Drawing.Point(25, 171);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(94, 27);
            this.lblLastName.TabIndex = 36;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLastName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLastName.Location = new System.Drawing.Point(129, 173);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(174, 23);
            this.txtLastName.TabIndex = 35;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFirstName.Location = new System.Drawing.Point(25, 91);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(98, 27);
            this.lblFirstName.TabIndex = 34;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFirstName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.Location = new System.Drawing.Point(129, 91);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(174, 23);
            this.txtFirstName.TabIndex = 33;
            // 
            // pnlMyTickets
            // 
            this.pnlMyTickets.AccessibleName = "";
            this.pnlMyTickets.Controls.Add(this.dvgTicketViewer);
            this.pnlMyTickets.Controls.Add(this.panel2);
            this.pnlMyTickets.Location = new System.Drawing.Point(0, 0);
            this.pnlMyTickets.Name = "pnlMyTickets";
            this.pnlMyTickets.Size = new System.Drawing.Size(945, 676);
            this.pnlMyTickets.TabIndex = 52;
            this.pnlMyTickets.Visible = false;
            // 
            // dvgTicketViewer
            // 
            this.dvgTicketViewer.AutoGenerateColumns = false;
            this.dvgTicketViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgTicketViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTicketViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketNumDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.dateDueDataGridViewTextBoxColumn,
            this.assignedPriorityDataGridViewTextBoxColumn,
            this.personOriginallyAssignedDataGridViewTextBoxColumn,
            this.personAssignedDataGridViewTextBoxColumn,
            this.descriptionInputDataGridViewTextBoxColumn,
            this.statusTypeDataGridViewTextBoxColumn,
            this.timeSpentWorkingDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn});
            this.dvgTicketViewer.DataSource = this.ticketBindingSource;
            this.dvgTicketViewer.Location = new System.Drawing.Point(19, 123);
            this.dvgTicketViewer.Name = "dvgTicketViewer";
            this.dvgTicketViewer.Size = new System.Drawing.Size(906, 211);
            this.dvgTicketViewer.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblWelcome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 100);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(346, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "See what\'s been happening:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.Window;
            this.lblWelcome.Location = new System.Drawing.Point(45, 31);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(172, 38);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Hello, Default";
            // 
            // ticketNumDataGridViewTextBoxColumn
            // 
            this.ticketNumDataGridViewTextBoxColumn.DataPropertyName = "ticketNum";
            this.ticketNumDataGridViewTextBoxColumn.HeaderText = "ticketNum";
            this.ticketNumDataGridViewTextBoxColumn.Name = "ticketNumDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "dateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "dateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            // 
            // dateDueDataGridViewTextBoxColumn
            // 
            this.dateDueDataGridViewTextBoxColumn.DataPropertyName = "dateDue";
            this.dateDueDataGridViewTextBoxColumn.HeaderText = "dateDue";
            this.dateDueDataGridViewTextBoxColumn.Name = "dateDueDataGridViewTextBoxColumn";
            // 
            // assignedPriorityDataGridViewTextBoxColumn
            // 
            this.assignedPriorityDataGridViewTextBoxColumn.DataPropertyName = "assignedPriority";
            this.assignedPriorityDataGridViewTextBoxColumn.HeaderText = "assignedPriority";
            this.assignedPriorityDataGridViewTextBoxColumn.Name = "assignedPriorityDataGridViewTextBoxColumn";
            // 
            // personOriginallyAssignedDataGridViewTextBoxColumn
            // 
            this.personOriginallyAssignedDataGridViewTextBoxColumn.DataPropertyName = "personOriginallyAssigned";
            this.personOriginallyAssignedDataGridViewTextBoxColumn.HeaderText = "personOriginallyAssigned";
            this.personOriginallyAssignedDataGridViewTextBoxColumn.Name = "personOriginallyAssignedDataGridViewTextBoxColumn";
            // 
            // personAssignedDataGridViewTextBoxColumn
            // 
            this.personAssignedDataGridViewTextBoxColumn.DataPropertyName = "personAssigned";
            this.personAssignedDataGridViewTextBoxColumn.HeaderText = "personAssigned";
            this.personAssignedDataGridViewTextBoxColumn.Name = "personAssignedDataGridViewTextBoxColumn";
            // 
            // descriptionInputDataGridViewTextBoxColumn
            // 
            this.descriptionInputDataGridViewTextBoxColumn.DataPropertyName = "descriptionInput";
            this.descriptionInputDataGridViewTextBoxColumn.HeaderText = "descriptionInput";
            this.descriptionInputDataGridViewTextBoxColumn.Name = "descriptionInputDataGridViewTextBoxColumn";
            // 
            // statusTypeDataGridViewTextBoxColumn
            // 
            this.statusTypeDataGridViewTextBoxColumn.DataPropertyName = "statusType";
            this.statusTypeDataGridViewTextBoxColumn.HeaderText = "statusType";
            this.statusTypeDataGridViewTextBoxColumn.Name = "statusTypeDataGridViewTextBoxColumn";
            // 
            // timeSpentWorkingDataGridViewTextBoxColumn
            // 
            this.timeSpentWorkingDataGridViewTextBoxColumn.DataPropertyName = "timeSpentWorking";
            this.timeSpentWorkingDataGridViewTextBoxColumn.HeaderText = "timeSpentWorking";
            this.timeSpentWorkingDataGridViewTextBoxColumn.Name = "timeSpentWorkingDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "userName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "userName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.iTicketDataSet;
            // 
            // iTicketDataSet
            // 
            this.iTicketDataSet.DataSetName = "ITicketDataSet";
            this.iTicketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1149, 676);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCSO Tiket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlNewTicket.ResumeLayout(false);
            this.pnlNewTicket.PerformLayout();
            this.pnlMyTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgTicketViewer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTicketDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSupport;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnLookupTickets;
        private System.Windows.Forms.Button btnMyTicket;
        private System.Windows.Forms.Button btnNewTicket;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMyTickets;
        private System.Windows.Forms.DataGridView dvgTicketViewer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlNewTicket;
        private System.Windows.Forms.ListBox lbPersonAssigned;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDateCreated;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private ITicketDataSet iTicketDataSet;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private ITicketDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedPriorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personOriginallyAssignedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personAssignedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionInputDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSpentWorkingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
    }
}

