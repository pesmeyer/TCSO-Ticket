namespace SampleTicketer
{
    partial class MainForm
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
            System.Windows.Forms.Label assignedPriorityLabel;
            System.Windows.Forms.Label statusTypeLabel;
            System.Windows.Forms.Label personAssignedLabel;
            System.Windows.Forms.Label descriptionInputLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.pnlMyTickets = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTicketDataSet = new SampleTicketer.ITicketDataSet();
            this.btnEditTicket = new System.Windows.Forms.Button();
            this.pnlQuickEdit = new System.Windows.Forms.Panel();
            this.txtAddNotes = new System.Windows.Forms.TextBox();
            this.lblAddNotes = new System.Windows.Forms.Label();
            this.descriptionInputListBox = new System.Windows.Forms.ListBox();
            this.personAssignedComboBox = new System.Windows.Forms.ComboBox();
            this.statusTypeComboBox = new System.Windows.Forms.ComboBox();
            this.assignedPriorityComboBox = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblQuickEdit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalTicketOpen = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
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
            this.ticketTableAdapter = new SampleTicketer.ITicketDataSetTableAdapters.TicketTableAdapter();
            this.tableAdapterManager = new SampleTicketer.ITicketDataSetTableAdapters.TableAdapterManager();
            this.iTicketDataSet1 = new SampleTicketer.ITicketDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            assignedPriorityLabel = new System.Windows.Forms.Label();
            statusTypeLabel = new System.Windows.Forms.Label();
            personAssignedLabel = new System.Windows.Forms.Label();
            descriptionInputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlMyTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTicketDataSet)).BeginInit();
            this.pnlQuickEdit.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlNewTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTicketDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // assignedPriorityLabel
            // 
            assignedPriorityLabel.AutoSize = true;
            assignedPriorityLabel.ForeColor = System.Drawing.SystemColors.Window;
            assignedPriorityLabel.Location = new System.Drawing.Point(486, 58);
            assignedPriorityLabel.Name = "assignedPriorityLabel";
            assignedPriorityLabel.Size = new System.Drawing.Size(63, 23);
            assignedPriorityLabel.TabIndex = 6;
            assignedPriorityLabel.Text = "Priority:";
            // 
            // statusTypeLabel
            // 
            statusTypeLabel.AutoSize = true;
            statusTypeLabel.ForeColor = System.Drawing.SystemColors.Window;
            statusTypeLabel.Location = new System.Drawing.Point(731, 58);
            statusTypeLabel.Name = "statusTypeLabel";
            statusTypeLabel.Size = new System.Drawing.Size(52, 23);
            statusTypeLabel.TabIndex = 7;
            statusTypeLabel.Text = "Status:";
            // 
            // personAssignedLabel
            // 
            personAssignedLabel.AutoSize = true;
            personAssignedLabel.ForeColor = System.Drawing.SystemColors.Window;
            personAssignedLabel.Location = new System.Drawing.Point(183, 58);
            personAssignedLabel.Name = "personAssignedLabel";
            personAssignedLabel.Size = new System.Drawing.Size(121, 23);
            personAssignedLabel.TabIndex = 8;
            personAssignedLabel.Text = "Person Assigned:";
            // 
            // descriptionInputLabel
            // 
            descriptionInputLabel.AutoSize = true;
            descriptionInputLabel.ForeColor = System.Drawing.SystemColors.Window;
            descriptionInputLabel.Location = new System.Drawing.Point(16, 88);
            descriptionInputLabel.Name = "descriptionInputLabel";
            descriptionInputLabel.Size = new System.Drawing.Size(55, 23);
            descriptionInputLabel.TabIndex = 9;
            descriptionInputLabel.Text = "Notes:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
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
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.pnlMyTickets);
            this.splitContainer1.Panel2.Controls.Add(this.pnlNewTicket);
            this.splitContainer1.Size = new System.Drawing.Size(1191, 685);
            this.splitContainer1.SplitterDistance = 201;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 100);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 585);
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
            // pnlMyTickets
            // 
            this.pnlMyTickets.AccessibleName = "";
            this.pnlMyTickets.Controls.Add(this.dataGridView1);
            this.pnlMyTickets.Controls.Add(this.btnEditTicket);
            this.pnlMyTickets.Controls.Add(this.pnlQuickEdit);
            this.pnlMyTickets.Controls.Add(this.label3);
            this.pnlMyTickets.Controls.Add(this.panel2);
            this.pnlMyTickets.Location = new System.Drawing.Point(0, 0);
            this.pnlMyTickets.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMyTickets.Name = "pnlMyTickets";
            this.pnlMyTickets.Size = new System.Drawing.Size(989, 685);
            this.pnlMyTickets.TabIndex = 52;
            this.pnlMyTickets.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 45;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dataGridView1.DataSource = this.ticketBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(898, 209);
            this.dataGridView1.TabIndex = 4;
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
            // btnEditTicket
            // 
            this.btnEditTicket.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEditTicket.FlatAppearance.BorderSize = 0;
            this.btnEditTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTicket.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTicket.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditTicket.Location = new System.Drawing.Point(857, 367);
            this.btnEditTicket.Name = "btnEditTicket";
            this.btnEditTicket.Size = new System.Drawing.Size(86, 41);
            this.btnEditTicket.TabIndex = 3;
            this.btnEditTicket.Text = "Edit";
            this.btnEditTicket.UseVisualStyleBackColor = false;
            this.btnEditTicket.Click += new System.EventHandler(this.btnEditTicket_Click);
            // 
            // pnlQuickEdit
            // 
            this.pnlQuickEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlQuickEdit.Controls.Add(this.txtAddNotes);
            this.pnlQuickEdit.Controls.Add(this.lblAddNotes);
            this.pnlQuickEdit.Controls.Add(descriptionInputLabel);
            this.pnlQuickEdit.Controls.Add(this.descriptionInputListBox);
            this.pnlQuickEdit.Controls.Add(personAssignedLabel);
            this.pnlQuickEdit.Controls.Add(this.personAssignedComboBox);
            this.pnlQuickEdit.Controls.Add(statusTypeLabel);
            this.pnlQuickEdit.Controls.Add(this.statusTypeComboBox);
            this.pnlQuickEdit.Controls.Add(assignedPriorityLabel);
            this.pnlQuickEdit.Controls.Add(this.assignedPriorityComboBox);
            this.pnlQuickEdit.Controls.Add(this.btnUpdate);
            this.pnlQuickEdit.Controls.Add(this.lblQuickEdit);
            this.pnlQuickEdit.Location = new System.Drawing.Point(0, 417);
            this.pnlQuickEdit.Name = "pnlQuickEdit";
            this.pnlQuickEdit.Size = new System.Drawing.Size(988, 267);
            this.pnlQuickEdit.TabIndex = 2;
            // 
            // txtAddNotes
            // 
            this.txtAddNotes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtAddNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddNotes.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAddNotes.Location = new System.Drawing.Point(19, 162);
            this.txtAddNotes.Multiline = true;
            this.txtAddNotes.Name = "txtAddNotes";
            this.txtAddNotes.Size = new System.Drawing.Size(924, 47);
            this.txtAddNotes.TabIndex = 12;
            // 
            // lblAddNotes
            // 
            this.lblAddNotes.AutoSize = true;
            this.lblAddNotes.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAddNotes.Location = new System.Drawing.Point(15, 140);
            this.lblAddNotes.Name = "lblAddNotes";
            this.lblAddNotes.Size = new System.Drawing.Size(86, 23);
            this.lblAddNotes.TabIndex = 11;
            this.lblAddNotes.Text = "Add Notes:";
            // 
            // descriptionInputListBox
            // 
            this.descriptionInputListBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.descriptionInputListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionInputListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ticketBindingSource, "descriptionInput", true));
            this.descriptionInputListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.descriptionInputListBox.FormattingEnabled = true;
            this.descriptionInputListBox.ItemHeight = 23;
            this.descriptionInputListBox.Location = new System.Drawing.Point(19, 114);
            this.descriptionInputListBox.Name = "descriptionInputListBox";
            this.descriptionInputListBox.ScrollAlwaysVisible = true;
            this.descriptionInputListBox.Size = new System.Drawing.Size(924, 23);
            this.descriptionInputListBox.TabIndex = 10;
            // 
            // personAssignedComboBox
            // 
            this.personAssignedComboBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.personAssignedComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "personAssigned", true));
            this.personAssignedComboBox.FormattingEnabled = true;
            this.personAssignedComboBox.Items.AddRange(new object[] {
            "Daniel Lutz",
            "Payton Esmeyer",
            "Austin Cauley"});
            this.personAssignedComboBox.Location = new System.Drawing.Point(326, 55);
            this.personAssignedComboBox.Name = "personAssignedComboBox";
            this.personAssignedComboBox.Size = new System.Drawing.Size(138, 31);
            this.personAssignedComboBox.TabIndex = 9;
            // 
            // statusTypeComboBox
            // 
            this.statusTypeComboBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.statusTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "statusType", true));
            this.statusTypeComboBox.FormattingEnabled = true;
            this.statusTypeComboBox.Items.AddRange(new object[] {
            "Open",
            "Closed"});
            this.statusTypeComboBox.Location = new System.Drawing.Point(805, 55);
            this.statusTypeComboBox.Name = "statusTypeComboBox";
            this.statusTypeComboBox.Size = new System.Drawing.Size(138, 31);
            this.statusTypeComboBox.TabIndex = 8;
            // 
            // assignedPriorityComboBox
            // 
            this.assignedPriorityComboBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.assignedPriorityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "assignedPriority", true));
            this.assignedPriorityComboBox.FormattingEnabled = true;
            this.assignedPriorityComboBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Critical"});
            this.assignedPriorityComboBox.Location = new System.Drawing.Point(571, 55);
            this.assignedPriorityComboBox.Name = "assignedPriorityComboBox";
            this.assignedPriorityComboBox.Size = new System.Drawing.Size(138, 31);
            this.assignedPriorityComboBox.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Location = new System.Drawing.Point(842, 218);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 41);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblQuickEdit
            // 
            this.lblQuickEdit.AutoSize = true;
            this.lblQuickEdit.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.lblQuickEdit.Location = new System.Drawing.Point(13, 14);
            this.lblQuickEdit.Name = "lblQuickEdit";
            this.lblQuickEdit.Size = new System.Drawing.Size(127, 34);
            this.lblQuickEdit.TabIndex = 0;
            this.lblQuickEdit.Text = "Quick Edits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(14, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "See what\'s been happening:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.lblTotalTicketOpen);
            this.panel2.Controls.Add(this.lblWelcome);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 100);
            this.panel2.TabIndex = 0;
            // 
            // lblTotalTicketOpen
            // 
            this.lblTotalTicketOpen.AutoSize = true;
            this.lblTotalTicketOpen.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTicketOpen.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTotalTicketOpen.Location = new System.Drawing.Point(365, 37);
            this.lblTotalTicketOpen.Name = "lblTotalTicketOpen";
            this.lblTotalTicketOpen.Size = new System.Drawing.Size(256, 30);
            this.lblTotalTicketOpen.TabIndex = 1;
            this.lblTotalTicketOpen.Text = "Total Tickets Open: Default";
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
            this.pnlNewTicket.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNewTicket.Name = "pnlNewTicket";
            this.pnlNewTicket.Size = new System.Drawing.Size(988, 676);
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
            this.lblDueDate.Location = new System.Drawing.Point(571, 169);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(87, 27);
            this.lblDueDate.TabIndex = 48;
            this.lblDueDate.Text = "Due Date";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDueDate.CalendarMonthBackground = System.Drawing.SystemColors.ControlDark;
            this.dtpDueDate.Location = new System.Drawing.Point(694, 169);
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
            this.lblDateCreated.Location = new System.Drawing.Point(571, 91);
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
            this.btnSubmit.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSubmit.Location = new System.Drawing.Point(868, 620);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(95, 44);
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
            this.lblDescription.Location = new System.Drawing.Point(48, 387);
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
            this.txtDescription.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDescription.Location = new System.Drawing.Point(76, 417);
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
            this.label6.Location = new System.Drawing.Point(432, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 34);
            this.label6.TabIndex = 42;
            this.label6.Text = "New Ticket";
            // 
            // dtpDateCreated
            // 
            this.dtpDateCreated.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDateCreated.CalendarMonthBackground = System.Drawing.SystemColors.ControlDark;
            this.dtpDateCreated.Location = new System.Drawing.Point(694, 91);
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
            this.lblPhoneNumber.Location = new System.Drawing.Point(48, 337);
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
            this.txtPhoneNumber.Location = new System.Drawing.Point(152, 337);
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
            this.lblEmail.Location = new System.Drawing.Point(48, 255);
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
            this.txtEmail.Location = new System.Drawing.Point(152, 255);
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
            this.lblLastName.Location = new System.Drawing.Point(48, 171);
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
            this.txtLastName.Location = new System.Drawing.Point(152, 173);
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
            this.lblFirstName.Location = new System.Drawing.Point(48, 91);
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
            this.txtFirstName.Location = new System.Drawing.Point(152, 91);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(174, 23);
            this.txtFirstName.TabIndex = 33;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.TicketTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SampleTicketer.ITicketDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iTicketDataSet1
            // 
            this.iTicketDataSet1.DataSetName = "ITicketDataSet";
            this.iTicketDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ticketNum";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ticket Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 136;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fname";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 108;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 105;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "phoneNumber";
            this.dataGridViewTextBoxColumn5.HeaderText = "Phone Number";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 135;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dateCreated";
            this.dataGridViewTextBoxColumn6.HeaderText = "Date Created";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 124;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "dateDue";
            this.dataGridViewTextBoxColumn7.HeaderText = "Date Due";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 99;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "assignedPriority";
            this.dataGridViewTextBoxColumn8.HeaderText = "Assigned Priority";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 146;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "personOriginallyAssigned";
            this.dataGridViewTextBoxColumn9.HeaderText = "Person Originally Assigned";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 210;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "personAssigned";
            this.dataGridViewTextBoxColumn10.HeaderText = "Person Assigned";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 142;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "descriptionInput";
            this.dataGridViewTextBoxColumn11.HeaderText = "Description Input";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 149;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "statusType";
            this.dataGridViewTextBoxColumn12.HeaderText = "Status Type";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 110;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "timeSpentWorking";
            this.dataGridViewTextBoxColumn13.HeaderText = "Time Spent Working";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 172;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "userName";
            this.dataGridViewTextBoxColumn14.HeaderText = "User Name";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            this.dataGridViewTextBoxColumn14.Width = 110;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1191, 685);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCSO-ITicket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlMyTickets.ResumeLayout(false);
            this.pnlMyTickets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTicketDataSet)).EndInit();
            this.pnlQuickEdit.ResumeLayout(false);
            this.pnlQuickEdit.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlNewTicket.ResumeLayout(false);
            this.pnlNewTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTicketDataSet1)).EndInit();
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
        private ITicketDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ITicketDataSet iTicketDataSet1;
        private System.Windows.Forms.Panel pnlMyTickets;
        private System.Windows.Forms.Button btnEditTicket;
        private System.Windows.Forms.Panel pnlQuickEdit;
        private System.Windows.Forms.ComboBox personAssignedComboBox;
        private System.Windows.Forms.ComboBox statusTypeComboBox;
        private System.Windows.Forms.ComboBox assignedPriorityComboBox;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblQuickEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalTicketOpen;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ListBox descriptionInputListBox;
        private System.Windows.Forms.TextBox txtAddNotes;
        private System.Windows.Forms.Label lblAddNotes;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}

