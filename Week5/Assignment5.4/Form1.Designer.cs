namespace Assignment5._4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridBooks = new System.Windows.Forms.DataGridView();
            this.btnShowAddForm = new System.Windows.Forms.Button();
            this.btnDeletedSelected = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.gbAddForm = new System.Windows.Forms.GroupBox();
            this.txtInputISBN = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtInputBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInputAmazonUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInputImageUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInputPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtInputDate = new System.Windows.Forms.DateTimePicker();
            this.btnSubmitAdd = new System.Windows.Forms.Button();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).BeginInit();
            this.gbAddForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridBooks
            // 
            this.gridBooks.AllowUserToAddRows = false;
            this.gridBooks.AllowUserToDeleteRows = false;
            this.gridBooks.AllowUserToResizeColumns = false;
            this.gridBooks.AllowUserToResizeRows = false;
            this.gridBooks.BackgroundColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridBooks.Location = new System.Drawing.Point(8, 48);
            this.gridBooks.Name = "gridBooks";
            this.gridBooks.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridBooks.RowHeadersWidth = 51;
            this.gridBooks.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.gridBooks.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBooks.Size = new System.Drawing.Size(1048, 440);
            this.gridBooks.TabIndex = 0;
            this.gridBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBooks_CellContentClick);
            this.gridBooks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // btnShowAddForm
            // 
            this.btnShowAddForm.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnShowAddForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShowAddForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAddForm.Location = new System.Drawing.Point(920, 8);
            this.btnShowAddForm.Name = "btnShowAddForm";
            this.btnShowAddForm.Size = new System.Drawing.Size(64, 31);
            this.btnShowAddForm.TabIndex = 1;
            this.btnShowAddForm.Text = "Add";
            this.btnShowAddForm.UseVisualStyleBackColor = false;
            this.btnShowAddForm.Click += new System.EventHandler(this.btnShowAddForm_Click);
            // 
            // btnDeletedSelected
            // 
            this.btnDeletedSelected.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeletedSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeletedSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletedSelected.Location = new System.Drawing.Point(992, 8);
            this.btnDeletedSelected.Name = "btnDeletedSelected";
            this.btnDeletedSelected.Size = new System.Drawing.Size(64, 31);
            this.btnDeletedSelected.TabIndex = 2;
            this.btnDeletedSelected.Text = "Delete";
            this.btnDeletedSelected.UseVisualStyleBackColor = false;
            this.btnDeletedSelected.Click += new System.EventHandler(this.btnDeletedSelected_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeading.Location = new System.Drawing.Point(8, 8);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(229, 31);
            this.lblHeading.TabIndex = 4;
            this.lblHeading.Text = "Book Repository";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbAddForm
            // 
            this.gbAddForm.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gbAddForm.Controls.Add(this.btnCancelAdd);
            this.gbAddForm.Controls.Add(this.btnSubmitAdd);
            this.gbAddForm.Controls.Add(this.dtInputDate);
            this.gbAddForm.Controls.Add(this.txtInputPrice);
            this.gbAddForm.Controls.Add(this.label6);
            this.gbAddForm.Controls.Add(this.label5);
            this.gbAddForm.Controls.Add(this.txtInputImageUrl);
            this.gbAddForm.Controls.Add(this.label4);
            this.gbAddForm.Controls.Add(this.txtInputAmazonUrl);
            this.gbAddForm.Controls.Add(this.label3);
            this.gbAddForm.Controls.Add(this.txtInputAuthor);
            this.gbAddForm.Controls.Add(this.label2);
            this.gbAddForm.Controls.Add(this.txtInputBookName);
            this.gbAddForm.Controls.Add(this.label1);
            this.gbAddForm.Controls.Add(this.txtInputISBN);
            this.gbAddForm.Controls.Add(this.lbl1);
            this.gbAddForm.Location = new System.Drawing.Point(656, 40);
            this.gbAddForm.Name = "gbAddForm";
            this.gbAddForm.Size = new System.Drawing.Size(328, 288);
            this.gbAddForm.TabIndex = 5;
            this.gbAddForm.TabStop = false;
            this.gbAddForm.Text = "Add a new book";
            this.gbAddForm.Visible = false;
            // 
            // txtInputISBN
            // 
            this.txtInputISBN.Location = new System.Drawing.Point(112, 24);
            this.txtInputISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputISBN.Name = "txtInputISBN";
            this.txtInputISBN.Size = new System.Drawing.Size(208, 22);
            this.txtInputISBN.TabIndex = 9;
            this.txtInputISBN.Text = "0156027321";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl1.Location = new System.Drawing.Point(10, 27);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(62, 16);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "ISBN 10";
            // 
            // txtInputBookName
            // 
            this.txtInputBookName.Location = new System.Drawing.Point(112, 56);
            this.txtInputBookName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputBookName.Name = "txtInputBookName";
            this.txtInputBookName.Size = new System.Drawing.Size(208, 22);
            this.txtInputBookName.TabIndex = 11;
            this.txtInputBookName.Text = "The Life of Pi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(10, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Book Name";
            // 
            // txtInputAuthor
            // 
            this.txtInputAuthor.Location = new System.Drawing.Point(112, 88);
            this.txtInputAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputAuthor.Name = "txtInputAuthor";
            this.txtInputAuthor.Size = new System.Drawing.Size(208, 22);
            this.txtInputAuthor.TabIndex = 13;
            this.txtInputAuthor.Text = "Yann Martel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(10, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Authors";
            // 
            // txtInputAmazonUrl
            // 
            this.txtInputAmazonUrl.Location = new System.Drawing.Point(112, 120);
            this.txtInputAmazonUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputAmazonUrl.Name = "txtInputAmazonUrl";
            this.txtInputAmazonUrl.Size = new System.Drawing.Size(208, 22);
            this.txtInputAmazonUrl.TabIndex = 15;
            this.txtInputAmazonUrl.Text = "Life-Pi-Yann-Martel/dp/0156027321";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(10, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Amazon Url";
            // 
            // txtInputImageUrl
            // 
            this.txtInputImageUrl.Location = new System.Drawing.Point(112, 152);
            this.txtInputImageUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputImageUrl.Name = "txtInputImageUrl";
            this.txtInputImageUrl.Size = new System.Drawing.Size(208, 22);
            this.txtInputImageUrl.TabIndex = 17;
            this.txtInputImageUrl.Text = "https://images-na.ssl-images-amazon.com/images/I/51rxEvLljUL._SX322_BO1,204,203,2" +
    "00_.jpg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(10, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Image Url";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(10, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Publish Date";
            // 
            // txtInputPrice
            // 
            this.txtInputPrice.Location = new System.Drawing.Point(112, 216);
            this.txtInputPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputPrice.Name = "txtInputPrice";
            this.txtInputPrice.Size = new System.Drawing.Size(208, 22);
            this.txtInputPrice.TabIndex = 19;
            this.txtInputPrice.Text = "8.99";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(10, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Price";
            // 
            // dtInputDate
            // 
            this.dtInputDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInputDate.Location = new System.Drawing.Point(112, 184);
            this.dtInputDate.Name = "dtInputDate";
            this.dtInputDate.Size = new System.Drawing.Size(208, 22);
            this.dtInputDate.TabIndex = 18;
            // 
            // btnSubmitAdd
            // 
            this.btnSubmitAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnSubmitAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubmitAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitAdd.Location = new System.Drawing.Point(160, 248);
            this.btnSubmitAdd.Name = "btnSubmitAdd";
            this.btnSubmitAdd.Size = new System.Drawing.Size(72, 31);
            this.btnSubmitAdd.TabIndex = 20;
            this.btnSubmitAdd.Text = "Submit";
            this.btnSubmitAdd.UseVisualStyleBackColor = false;
            this.btnSubmitAdd.Click += new System.EventHandler(this.btnSubmitAdd_Click);
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAdd.Location = new System.Drawing.Point(248, 248);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(72, 31);
            this.btnCancelAdd.TabIndex = 21;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = false;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1061, 495);
            this.Controls.Add(this.gbAddForm);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnDeletedSelected);
            this.Controls.Add(this.btnShowAddForm);
            this.Controls.Add(this.gridBooks);
            this.Name = "Form1";
            this.Text = "Book Repository";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).EndInit();
            this.gbAddForm.ResumeLayout(false);
            this.gbAddForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBooks;
        private System.Windows.Forms.Button btnShowAddForm;
        private System.Windows.Forms.Button btnDeletedSelected;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox gbAddForm;
        private System.Windows.Forms.Button btnSubmitAdd;
        private System.Windows.Forms.DateTimePicker dtInputDate;
        private System.Windows.Forms.TextBox txtInputPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInputImageUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInputAmazonUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInputAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInputBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputISBN;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnCancelAdd;
    }
}

