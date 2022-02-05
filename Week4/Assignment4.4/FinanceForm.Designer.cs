namespace Assignment4._4
{
    partial class FinanceForm
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
            this.grpActDetails = new System.Windows.Forms.GroupBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblInputNotification = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAddTransction = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnActNum = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNotification = new System.Windows.Forms.Label();
            this.grdTransactionHistory = new System.Windows.Forms.DataGridView();
            this.grpActDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.lblHeading.Location = new System.Drawing.Point(80, 8);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(847, 69);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Finance Management System";
            // 
            // grpActDetails
            // 
            this.grpActDetails.BackColor = System.Drawing.Color.LightBlue;
            this.grpActDetails.Controls.Add(this.cmbType);
            this.grpActDetails.Controls.Add(this.lblInputNotification);
            this.grpActDetails.Controls.Add(this.txtAmount);
            this.grpActDetails.Controls.Add(this.btnAddTransction);
            this.grpActDetails.Controls.Add(this.lblBalance);
            this.grpActDetails.Controls.Add(this.btnActNum);
            this.grpActDetails.Location = new System.Drawing.Point(16, 96);
            this.grpActDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpActDetails.Name = "grpActDetails";
            this.grpActDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpActDetails.Size = new System.Drawing.Size(360, 237);
            this.grpActDetails.TabIndex = 2;
            this.grpActDetails.TabStop = false;
            this.grpActDetails.Text = "Account Details";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(136, 80);
            this.cmbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 24);
            this.cmbType.TabIndex = 15;
            // 
            // lblInputNotification
            // 
            this.lblInputNotification.AutoSize = true;
            this.lblInputNotification.BackColor = System.Drawing.Color.Transparent;
            this.lblInputNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInputNotification.ForeColor = System.Drawing.Color.DarkRed;
            this.lblInputNotification.Location = new System.Drawing.Point(24, 24);
            this.lblInputNotification.Name = "lblInputNotification";
            this.lblInputNotification.Size = new System.Drawing.Size(175, 20);
            this.lblInputNotification.TabIndex = 14;
            this.lblInputNotification.Text = "Add a new transaction";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(136, 48);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 22);
            this.txtAmount.TabIndex = 8;
            this.txtAmount.Leave += new System.EventHandler(this.txtBalance_Leave);
            // 
            // btnAddTransction
            // 
            this.btnAddTransction.Location = new System.Drawing.Point(192, 184);
            this.btnAddTransction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTransction.Name = "btnAddTransction";
            this.btnAddTransction.Size = new System.Drawing.Size(150, 35);
            this.btnAddTransction.TabIndex = 3;
            this.btnAddTransction.Text = "Approve Transaction";
            this.btnAddTransction.UseVisualStyleBackColor = true;
            this.btnAddTransction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblBalance.Location = new System.Drawing.Point(16, 51);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(52, 16);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "Amount";
            // 
            // btnActNum
            // 
            this.btnActNum.AutoSize = true;
            this.btnActNum.BackColor = System.Drawing.Color.Transparent;
            this.btnActNum.Location = new System.Drawing.Point(16, 83);
            this.btnActNum.Name = "btnActNum";
            this.btnActNum.Size = new System.Drawing.Size(113, 16);
            this.btnActNum.TabIndex = 3;
            this.btnActNum.Text = "Transcation Type";
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
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "🢀";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.lblNotification);
            this.groupBox1.Controls.Add(this.grdTransactionHistory);
            this.groupBox1.Location = new System.Drawing.Point(400, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 240);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction History";
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
            // grdTransactionHistory
            // 
            this.grdTransactionHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdTransactionHistory.BackgroundColor = System.Drawing.Color.MistyRose;
            this.grdTransactionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTransactionHistory.Location = new System.Drawing.Point(16, 56);
            this.grdTransactionHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdTransactionHistory.Name = "grdTransactionHistory";
            this.grdTransactionHistory.RowHeadersWidth = 62;
            this.grdTransactionHistory.RowTemplate.Height = 28;
            this.grdTransactionHistory.Size = new System.Drawing.Size(584, 168);
            this.grdTransactionHistory.TabIndex = 2;
            // 
            // FinanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1091, 358);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.grpActDetails);
            this.Controls.Add(this.lblHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FinanceForm";
            this.Text = "Finance Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FinanceForm_FormClosing);
            this.Load += new System.EventHandler(this.FinanceForm_Load);
            this.grpActDetails.ResumeLayout(false);
            this.grpActDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox grpActDetails;
        private System.Windows.Forms.Button btnAddTransction;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label btnActNum;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblInputNotification;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.DataGridView grdTransactionHistory;
        private System.Windows.Forms.ComboBox cmbType;
    }
}