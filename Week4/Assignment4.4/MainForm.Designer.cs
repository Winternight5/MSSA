namespace Assignment4._4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBeverages = new System.Windows.Forms.Button();
            this.btnBank = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(749, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digital Tiga System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(0, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(774, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "A point-of-sale database for Beverages and Finance management";
            // 
            // btnBeverages
            // 
            this.btnBeverages.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnBeverages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBeverages.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnBeverages.Location = new System.Drawing.Point(432, 168);
            this.btnBeverages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBeverages.Name = "btnBeverages";
            this.btnBeverages.Size = new System.Drawing.Size(251, 150);
            this.btnBeverages.TabIndex = 2;
            this.btnBeverages.Text = "Beverages Management System";
            this.btnBeverages.UseVisualStyleBackColor = false;
            this.btnBeverages.Click += new System.EventHandler(this.btnBeverages_Click);
            // 
            // btnBank
            // 
            this.btnBank.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnBank.Location = new System.Drawing.Point(128, 168);
            this.btnBank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(251, 150);
            this.btnBank.TabIndex = 3;
            this.btnBank.Text = "Finance Management System";
            this.btnBank.UseVisualStyleBackColor = false;
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Khaki;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnExit.Location = new System.Drawing.Point(688, 328);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 403);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBank);
            this.Controls.Add(this.btnBeverages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Digital Tiga System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBeverages;
        private System.Windows.Forms.Button btnBank;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}