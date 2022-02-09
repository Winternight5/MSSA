namespace Assignment5._1
{
    partial class EmployeeForm
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.btnRemoveCoffee = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblNotification = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblInputNotification = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.grpBevDetails = new System.Windows.Forms.GroupBox();
            this.dtDob = new System.Windows.Forms.DateTimePicker();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtSSN = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpBevDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.lblHeading.Location = new System.Drawing.Point(96, 8);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(901, 69);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Employee Management System";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdData
            // 
            this.grdData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdData.BackgroundColor = System.Drawing.Color.MistyRose;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(16, 56);
            this.grdData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdData.MultiSelect = false;
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.RowHeadersWidth = 62;
            this.grdData.RowTemplate.Height = 28;
            this.grdData.Size = new System.Drawing.Size(624, 201);
            this.grdData.TabIndex = 2;
            // 
            // btnRemoveCoffee
            // 
            this.btnRemoveCoffee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveCoffee.Location = new System.Drawing.Point(440, 272);
            this.btnRemoveCoffee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveCoffee.Name = "btnRemoveCoffee";
            this.btnRemoveCoffee.Size = new System.Drawing.Size(199, 42);
            this.btnRemoveCoffee.TabIndex = 8;
            this.btnRemoveCoffee.Text = "Remove Selected Person";
            this.btnRemoveCoffee.UseVisualStyleBackColor = false;
            this.btnRemoveCoffee.Click += new System.EventHandler(this.btnRemoveCoffee_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(8, 8);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(64, 72);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "🢀";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.BackColor = System.Drawing.Color.Transparent;
            this.lblNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNotification.Location = new System.Drawing.Point(8, 24);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(139, 20);
            this.lblNotification.TabIndex = 12;
            this.lblNotification.Text = "Notification Label";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.lblNotification);
            this.groupBox1.Controls.Add(this.btnRemoveCoffee);
            this.groupBox1.Controls.Add(this.grdData);
            this.groupBox1.Location = new System.Drawing.Point(392, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 328);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Data";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(18, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "First Name";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(120, 56);
            this.txtFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(208, 22);
            this.txtFName.TabIndex = 7;
            this.txtFName.Leave += new System.EventHandler(this.txtFName_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(192, 272);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 42);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Confirm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblInputNotification
            // 
            this.lblInputNotification.AutoSize = true;
            this.lblInputNotification.BackColor = System.Drawing.Color.Transparent;
            this.lblInputNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInputNotification.ForeColor = System.Drawing.Color.DarkRed;
            this.lblInputNotification.Location = new System.Drawing.Point(16, 24);
            this.lblInputNotification.Name = "lblInputNotification";
            this.lblInputNotification.Size = new System.Drawing.Size(165, 20);
            this.lblInputNotification.TabIndex = 13;
            this.lblInputNotification.Text = "Add a new Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(18, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Last Name";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(120, 88);
            this.txtLName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(208, 22);
            this.txtLName.TabIndex = 17;
            this.txtLName.TextChanged += new System.EventHandler(this.txtLName_TextChanged);
            // 
            // grpBevDetails
            // 
            this.grpBevDetails.BackColor = System.Drawing.Color.MistyRose;
            this.grpBevDetails.Controls.Add(this.mtxtSSN);
            this.grpBevDetails.Controls.Add(this.label1);
            this.grpBevDetails.Controls.Add(this.dtDob);
            this.grpBevDetails.Controls.Add(this.txtLName);
            this.grpBevDetails.Controls.Add(this.label2);
            this.grpBevDetails.Controls.Add(this.lblInputNotification);
            this.grpBevDetails.Controls.Add(this.cmbDepartment);
            this.grpBevDetails.Controls.Add(this.btnAdd);
            this.grpBevDetails.Controls.Add(this.txtFName);
            this.grpBevDetails.Controls.Add(this.lblPrice);
            this.grpBevDetails.Controls.Add(this.lblSize);
            this.grpBevDetails.Controls.Add(this.lblName);
            this.grpBevDetails.Location = new System.Drawing.Point(24, 96);
            this.grpBevDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBevDetails.Name = "grpBevDetails";
            this.grpBevDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBevDetails.Size = new System.Drawing.Size(352, 328);
            this.grpBevDetails.TabIndex = 1;
            this.grpBevDetails.TabStop = false;
            this.grpBevDetails.Text = "Employee Details";
            // 
            // dtDob
            // 
            this.dtDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDob.Location = new System.Drawing.Point(120, 184);
            this.dtDob.MaxDate = new System.DateTime(2022, 2, 8, 0, 0, 0, 0);
            this.dtDob.Name = "dtDob";
            this.dtDob.Size = new System.Drawing.Size(200, 22);
            this.dtDob.TabIndex = 18;
            this.dtDob.Value = new System.DateTime(2022, 2, 8, 0, 0, 0, 0);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(120, 152);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(208, 24);
            this.cmbDepartment.TabIndex = 12;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Location = new System.Drawing.Point(18, 187);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(79, 16);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Date of Birth";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.Transparent;
            this.lblSize.Location = new System.Drawing.Point(18, 156);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(77, 16);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "SSN";
            // 
            // mtxtSSN
            // 
            this.mtxtSSN.Location = new System.Drawing.Point(120, 120);
            this.mtxtSSN.Mask = "000-00-0000";
            this.mtxtSSN.Name = "mtxtSSN";
            this.mtxtSSN.Size = new System.Drawing.Size(208, 22);
            this.mtxtSSN.TabIndex = 20;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1085, 438);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.grpBevDetails);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeForm";
            this.Text = "Employee Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BeverageForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBevDetails.ResumeLayout(false);
            this.grpBevDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.Button btnRemoveCoffee;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblInputNotification;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.GroupBox grpBevDetails;
        private System.Windows.Forms.DateTimePicker dtDob;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.MaskedTextBox mtxtSSN;
        private System.Windows.Forms.Label label1;
    }
}

