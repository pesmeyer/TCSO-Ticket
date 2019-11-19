namespace SampleTicketer
{
    partial class editForm
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
            System.Windows.Forms.Label fnameLabel;
            System.Windows.Forms.Label lnameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label dateCreatedLabel;
            System.Windows.Forms.Label dateDueLabel;
            System.Windows.Forms.Label assignedPriorityLabel;
            System.Windows.Forms.Label personAssignedLabel;
            System.Windows.Forms.Label lblNotesEdit;
            System.Windows.Forms.Label statusTypeLabel;
            System.Windows.Forms.Label timeSpentWorkingLabel;
            this.iTicketDataSet = new SampleTicketer.ITicketDataSet();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTableAdapter = new SampleTicketer.ITicketDataSetTableAdapters.TicketTableAdapter();
            this.tableAdapterManager = new SampleTicketer.ITicketDataSetTableAdapters.TableAdapterManager();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.dateCreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateDueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.assignedPriorityComboBox = new System.Windows.Forms.ComboBox();
            this.personAssignedComboBox = new System.Windows.Forms.ComboBox();
            this.statusTypeComboBox = new System.Windows.Forms.ComboBox();
            this.timeSpentWorkingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descriptionInputListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnUpdateEdit = new System.Windows.Forms.Button();
            fnameLabel = new System.Windows.Forms.Label();
            lnameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            dateCreatedLabel = new System.Windows.Forms.Label();
            dateDueLabel = new System.Windows.Forms.Label();
            assignedPriorityLabel = new System.Windows.Forms.Label();
            personAssignedLabel = new System.Windows.Forms.Label();
            lblNotesEdit = new System.Windows.Forms.Label();
            statusTypeLabel = new System.Windows.Forms.Label();
            timeSpentWorkingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iTicketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpentWorkingNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fnameLabel.ForeColor = System.Drawing.SystemColors.Window;
            fnameLabel.Location = new System.Drawing.Point(17, 40);
            fnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new System.Drawing.Size(106, 24);
            fnameLabel.TabIndex = 1;
            fnameLabel.Text = "First Name:";
            // 
            // lnameLabel
            // 
            lnameLabel.AutoSize = true;
            lnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lnameLabel.ForeColor = System.Drawing.SystemColors.Window;
            lnameLabel.Location = new System.Drawing.Point(17, 89);
            lnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new System.Drawing.Size(104, 24);
            lnameLabel.TabIndex = 3;
            lnameLabel.Text = "Last Name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.SystemColors.Window;
            emailLabel.Location = new System.Drawing.Point(17, 137);
            emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(62, 24);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneNumberLabel.ForeColor = System.Drawing.SystemColors.Window;
            phoneNumberLabel.Location = new System.Drawing.Point(17, 190);
            phoneNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(145, 24);
            phoneNumberLabel.TabIndex = 7;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // dateCreatedLabel
            // 
            dateCreatedLabel.AutoSize = true;
            dateCreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateCreatedLabel.ForeColor = System.Drawing.SystemColors.Window;
            dateCreatedLabel.Location = new System.Drawing.Point(17, 246);
            dateCreatedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dateCreatedLabel.Name = "dateCreatedLabel";
            dateCreatedLabel.Size = new System.Drawing.Size(124, 24);
            dateCreatedLabel.TabIndex = 9;
            dateCreatedLabel.Text = "Date Created:";
            // 
            // dateDueLabel
            // 
            dateDueLabel.AutoSize = true;
            dateDueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateDueLabel.ForeColor = System.Drawing.SystemColors.Window;
            dateDueLabel.Location = new System.Drawing.Point(446, 248);
            dateDueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dateDueLabel.Name = "dateDueLabel";
            dateDueLabel.Size = new System.Drawing.Size(93, 24);
            dateDueLabel.TabIndex = 11;
            dateDueLabel.Text = "Due Date:";
            // 
            // assignedPriorityLabel
            // 
            assignedPriorityLabel.AutoSize = true;
            assignedPriorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            assignedPriorityLabel.ForeColor = System.Drawing.SystemColors.Window;
            assignedPriorityLabel.Location = new System.Drawing.Point(446, 42);
            assignedPriorityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            assignedPriorityLabel.Name = "assignedPriorityLabel";
            assignedPriorityLabel.Size = new System.Drawing.Size(155, 24);
            assignedPriorityLabel.TabIndex = 13;
            assignedPriorityLabel.Text = "Assigned Priority:";
            // 
            // personAssignedLabel
            // 
            personAssignedLabel.AutoSize = true;
            personAssignedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            personAssignedLabel.ForeColor = System.Drawing.SystemColors.Window;
            personAssignedLabel.Location = new System.Drawing.Point(446, 91);
            personAssignedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            personAssignedLabel.Name = "personAssignedLabel";
            personAssignedLabel.Size = new System.Drawing.Size(159, 24);
            personAssignedLabel.TabIndex = 15;
            personAssignedLabel.Text = "Person Assigned:";
            // 
            // lblNotesEdit
            // 
            lblNotesEdit.AutoSize = true;
            lblNotesEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNotesEdit.ForeColor = System.Drawing.SystemColors.Window;
            lblNotesEdit.Location = new System.Drawing.Point(17, 300);
            lblNotesEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNotesEdit.Name = "lblNotesEdit";
            lblNotesEdit.Size = new System.Drawing.Size(64, 24);
            lblNotesEdit.TabIndex = 17;
            lblNotesEdit.Text = "Notes:";
            // 
            // statusTypeLabel
            // 
            statusTypeLabel.AutoSize = true;
            statusTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statusTypeLabel.ForeColor = System.Drawing.SystemColors.Window;
            statusTypeLabel.Location = new System.Drawing.Point(446, 139);
            statusTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            statusTypeLabel.Name = "statusTypeLabel";
            statusTypeLabel.Size = new System.Drawing.Size(113, 24);
            statusTypeLabel.TabIndex = 19;
            statusTypeLabel.Text = "Status Type:";
            // 
            // timeSpentWorkingLabel
            // 
            timeSpentWorkingLabel.AutoSize = true;
            timeSpentWorkingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            timeSpentWorkingLabel.ForeColor = System.Drawing.SystemColors.Window;
            timeSpentWorkingLabel.Location = new System.Drawing.Point(446, 190);
            timeSpentWorkingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            timeSpentWorkingLabel.Name = "timeSpentWorkingLabel";
            timeSpentWorkingLabel.Size = new System.Drawing.Size(187, 24);
            timeSpentWorkingLabel.TabIndex = 21;
            timeSpentWorkingLabel.Text = "Time Spent Working:";
            // 
            // iTicketDataSet
            // 
            this.iTicketDataSet.DataSetName = "ITicketDataSet";
            this.iTicketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.iTicketDataSet;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TicketTableAdapter = this.ticketTableAdapter;
            this.tableAdapterManager.UpdateOrder = SampleTicketer.ITicketDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "fname", true));
            this.fnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.fnameTextBox.Location = new System.Drawing.Point(179, 42);
            this.fnameTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(173, 22);
            this.fnameTextBox.TabIndex = 2;
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "lname", true));
            this.lnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.lnameTextBox.Location = new System.Drawing.Point(179, 91);
            this.lnameTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(173, 22);
            this.lnameTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.emailTextBox.Location = new System.Drawing.Point(179, 139);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(173, 22);
            this.emailTextBox.TabIndex = 6;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.phoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "phoneNumber", true));
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(179, 192);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(173, 22);
            this.phoneNumberTextBox.TabIndex = 8;
            // 
            // dateCreatedDateTimePicker
            // 
            this.dateCreatedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ticketBindingSource, "dateCreated", true));
            this.dateCreatedDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCreatedDateTimePicker.Location = new System.Drawing.Point(179, 243);
            this.dateCreatedDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateCreatedDateTimePicker.Name = "dateCreatedDateTimePicker";
            this.dateCreatedDateTimePicker.Size = new System.Drawing.Size(175, 29);
            this.dateCreatedDateTimePicker.TabIndex = 10;
            // 
            // dateDueDateTimePicker
            // 
            this.dateDueDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ticketBindingSource, "dateDue", true));
            this.dateDueDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDueDateTimePicker.Location = new System.Drawing.Point(655, 249);
            this.dateDueDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateDueDateTimePicker.Name = "dateDueDateTimePicker";
            this.dateDueDateTimePicker.Size = new System.Drawing.Size(194, 29);
            this.dateDueDateTimePicker.TabIndex = 12;
            // 
            // assignedPriorityComboBox
            // 
            this.assignedPriorityComboBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.assignedPriorityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "assignedPriority", true));
            this.assignedPriorityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedPriorityComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.assignedPriorityComboBox.FormattingEnabled = true;
            this.assignedPriorityComboBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Critical"});
            this.assignedPriorityComboBox.Location = new System.Drawing.Point(655, 40);
            this.assignedPriorityComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.assignedPriorityComboBox.Name = "assignedPriorityComboBox";
            this.assignedPriorityComboBox.Size = new System.Drawing.Size(194, 32);
            this.assignedPriorityComboBox.TabIndex = 14;
            // 
            // personAssignedComboBox
            // 
            this.personAssignedComboBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.personAssignedComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "personAssigned", true));
            this.personAssignedComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personAssignedComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.personAssignedComboBox.FormattingEnabled = true;
            this.personAssignedComboBox.Items.AddRange(new object[] {
            "Daniel Lutz",
            "Payton Esmeyer",
            "Austin Cauley"});
            this.personAssignedComboBox.Location = new System.Drawing.Point(655, 88);
            this.personAssignedComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.personAssignedComboBox.Name = "personAssignedComboBox";
            this.personAssignedComboBox.Size = new System.Drawing.Size(194, 32);
            this.personAssignedComboBox.TabIndex = 16;
            // 
            // statusTypeComboBox
            // 
            this.statusTypeComboBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.statusTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "statusType", true));
            this.statusTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTypeComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.statusTypeComboBox.FormattingEnabled = true;
            this.statusTypeComboBox.Items.AddRange(new object[] {
            "Open",
            "Closed"});
            this.statusTypeComboBox.Location = new System.Drawing.Point(655, 137);
            this.statusTypeComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.statusTypeComboBox.Name = "statusTypeComboBox";
            this.statusTypeComboBox.Size = new System.Drawing.Size(194, 32);
            this.statusTypeComboBox.TabIndex = 20;
            // 
            // timeSpentWorkingNumericUpDown
            // 
            this.timeSpentWorkingNumericUpDown.BackColor = System.Drawing.SystemColors.ControlDark;
            this.timeSpentWorkingNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ticketBindingSource, "timeSpentWorking", true));
            this.timeSpentWorkingNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSpentWorkingNumericUpDown.ForeColor = System.Drawing.SystemColors.Window;
            this.timeSpentWorkingNumericUpDown.Location = new System.Drawing.Point(655, 191);
            this.timeSpentWorkingNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.timeSpentWorkingNumericUpDown.Name = "timeSpentWorkingNumericUpDown";
            this.timeSpentWorkingNumericUpDown.Size = new System.Drawing.Size(192, 29);
            this.timeSpentWorkingNumericUpDown.TabIndex = 22;
            // 
            // descriptionInputListBox
            // 
            this.descriptionInputListBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.descriptionInputListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionInputListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ticketBindingSource, "descriptionInput", true));
            this.descriptionInputListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionInputListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.descriptionInputListBox.FormattingEnabled = true;
            this.descriptionInputListBox.ItemHeight = 20;
            this.descriptionInputListBox.Location = new System.Drawing.Point(19, 331);
            this.descriptionInputListBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.descriptionInputListBox.Name = "descriptionInputListBox";
            this.descriptionInputListBox.ScrollAlwaysVisible = true;
            this.descriptionInputListBox.Size = new System.Drawing.Size(830, 40);
            this.descriptionInputListBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(19, 396);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Add Notes:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(19, 427);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(830, 77);
            this.textBox1.TabIndex = 25;
            // 
            // btnUpdateEdit
            // 
            this.btnUpdateEdit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdateEdit.FlatAppearance.BorderSize = 0;
            this.btnUpdateEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdateEdit.Location = new System.Drawing.Point(766, 532);
            this.btnUpdateEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdateEdit.Name = "btnUpdateEdit";
            this.btnUpdateEdit.Size = new System.Drawing.Size(83, 44);
            this.btnUpdateEdit.TabIndex = 26;
            this.btnUpdateEdit.Text = "Update";
            this.btnUpdateEdit.UseVisualStyleBackColor = false;
            this.btnUpdateEdit.Click += new System.EventHandler(this.btnUpdateEdit_Click);
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(3F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(882, 596);
            this.Controls.Add(this.btnUpdateEdit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionInputListBox);
            this.Controls.Add(fnameLabel);
            this.Controls.Add(this.fnameTextBox);
            this.Controls.Add(lnameLabel);
            this.Controls.Add(this.lnameTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(dateCreatedLabel);
            this.Controls.Add(this.dateCreatedDateTimePicker);
            this.Controls.Add(dateDueLabel);
            this.Controls.Add(this.dateDueDateTimePicker);
            this.Controls.Add(assignedPriorityLabel);
            this.Controls.Add(this.assignedPriorityComboBox);
            this.Controls.Add(personAssignedLabel);
            this.Controls.Add(this.personAssignedComboBox);
            this.Controls.Add(lblNotesEdit);
            this.Controls.Add(statusTypeLabel);
            this.Controls.Add(this.statusTypeComboBox);
            this.Controls.Add(timeSpentWorkingLabel);
            this.Controls.Add(this.timeSpentWorkingNumericUpDown);
            this.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "editForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Ticket";
            this.Load += new System.EventHandler(this.editForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTicketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpentWorkingNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ITicketDataSet iTicketDataSet;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private ITicketDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
        private ITicketDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateEdit;
        public System.Windows.Forms.TextBox fnameTextBox;
        public System.Windows.Forms.TextBox lnameTextBox;
        public System.Windows.Forms.TextBox emailTextBox;
        public System.Windows.Forms.TextBox phoneNumberTextBox;
        public System.Windows.Forms.DateTimePicker dateCreatedDateTimePicker;
        public System.Windows.Forms.DateTimePicker dateDueDateTimePicker;
        public System.Windows.Forms.ComboBox assignedPriorityComboBox;
        public System.Windows.Forms.ComboBox personAssignedComboBox;
        public System.Windows.Forms.ComboBox statusTypeComboBox;
        public System.Windows.Forms.NumericUpDown timeSpentWorkingNumericUpDown;
        public System.Windows.Forms.ListBox descriptionInputListBox;
        public System.Windows.Forms.TextBox textBox1;
    }
}