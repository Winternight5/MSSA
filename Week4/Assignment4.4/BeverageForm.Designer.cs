namespace Assignment4._4
{
    partial class BeverageForm
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
            this.grpBevDetails = new System.Windows.Forms.GroupBox();
            this.lblInputNotification = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.btnCreateCoffee = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grdCoffee = new System.Windows.Forms.DataGridView();
            this.btnRemoveCoffee = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblNotification = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBevDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCoffee)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.lblHeading.Location = new System.Drawing.Point(96, 8);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(922, 69);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Beverages Management System";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBevDetails
            // 
            this.grpBevDetails.BackColor = System.Drawing.Color.MistyRose;
            this.grpBevDetails.Controls.Add(this.lblInputNotification);
            this.grpBevDetails.Controls.Add(this.cmbSize);
            this.grpBevDetails.Controls.Add(this.btnCreateCoffee);
            this.grpBevDetails.Controls.Add(this.txtPrice);
            this.grpBevDetails.Controls.Add(this.txtName);
            this.grpBevDetails.Controls.Add(this.lblPrice);
            this.grpBevDetails.Controls.Add(this.lblSize);
            this.grpBevDetails.Controls.Add(this.lblName);
            this.grpBevDetails.Location = new System.Drawing.Point(24, 96);
            this.grpBevDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBevDetails.Name = "grpBevDetails";
            this.grpBevDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBevDetails.Size = new System.Drawing.Size(360, 328);
            this.grpBevDetails.TabIndex = 1;
            this.grpBevDetails.TabStop = false;
            this.grpBevDetails.Text = "Beverage Details";
            // 
            // lblInputNotification
            // 
            this.lblInputNotification.AutoSize = true;
            this.lblInputNotification.BackColor = System.Drawing.Color.Transparent;
            this.lblInputNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInputNotification.ForeColor = System.Drawing.Color.DarkRed;
            this.lblInputNotification.Location = new System.Drawing.Point(16, 24);
            this.lblInputNotification.Name = "lblInputNotification";
            this.lblInputNotification.Size = new System.Drawing.Size(141, 20);
            this.lblInputNotification.TabIndex = 13;
            this.lblInputNotification.Text = "Add a new Coffee";
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(72, 120);
            this.cmbSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(135, 24);
            this.cmbSize.TabIndex = 12;
            // 
            // btnCreateCoffee
            // 
            this.btnCreateCoffee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateCoffee.Location = new System.Drawing.Point(192, 272);
            this.btnCreateCoffee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateCoffee.Name = "btnCreateCoffee";
            this.btnCreateCoffee.Size = new System.Drawing.Size(143, 42);
            this.btnCreateCoffee.TabIndex = 6;
            this.btnCreateCoffee.Text = "Add Item";
            this.btnCreateCoffee.UseVisualStyleBackColor = false;
            this.btnCreateCoffee.Click += new System.EventHandler(this.btnAddCoffee_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(72, 88);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(135, 22);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 56);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 22);
            this.txtName.TabIndex = 7;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Location = new System.Drawing.Point(18, 91);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 16);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.Transparent;
            this.lblSize.Location = new System.Drawing.Point(18, 124);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(36, 16);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Size:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(18, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // grdCoffee
            // 
            this.grdCoffee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdCoffee.BackgroundColor = System.Drawing.Color.MistyRose;
            this.grdCoffee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCoffee.Location = new System.Drawing.Point(16, 56);
            this.grdCoffee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdCoffee.Name = "grdCoffee";
            this.grdCoffee.RowHeadersWidth = 62;
            this.grdCoffee.RowTemplate.Height = 28;
            this.grdCoffee.Size = new System.Drawing.Size(584, 201);
            this.grdCoffee.TabIndex = 2;
            // 
            // btnRemoveCoffee
            // 
            this.btnRemoveCoffee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveCoffee.Location = new System.Drawing.Point(432, 272);
            this.btnRemoveCoffee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveCoffee.Name = "btnRemoveCoffee";
            this.btnRemoveCoffee.Size = new System.Drawing.Size(167, 42);
            this.btnRemoveCoffee.TabIndex = 8;
            this.btnRemoveCoffee.Text = "Remove Selected Item";
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
            this.groupBox1.Controls.Add(this.grdCoffee);
            this.groupBox1.Location = new System.Drawing.Point(416, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 328);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beverage Data";
            // 
            // BeverageForm
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
            this.Name = "BeverageForm";
            this.Text = "Beverages Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BeverageForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBevDetails.ResumeLayout(false);
            this.grpBevDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCoffee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox grpBevDetails;
        private System.Windows.Forms.DataGridView grdCoffee;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCreateCoffee;
        private System.Windows.Forms.Button btnRemoveCoffee;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Label lblInputNotification;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

