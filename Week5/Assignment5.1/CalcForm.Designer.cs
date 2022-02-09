namespace Assignment5._1
{
    partial class CalcForm
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
            this.btnClear = new System.Windows.Forms.Button();
            this.lblHolder = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.lblInputNotification = new System.Windows.Forms.Label();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxHistoryLog = new System.Windows.Forms.RichTextBox();
            this.grpActDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.lblHeading.Location = new System.Drawing.Point(64, 8);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(322, 69);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "iCalculator";
            // 
            // grpActDetails
            // 
            this.grpActDetails.BackColor = System.Drawing.Color.CornflowerBlue;
            this.grpActDetails.Controls.Add(this.btnClear);
            this.grpActDetails.Controls.Add(this.lblHolder);
            this.grpActDetails.Controls.Add(this.btnCalculate);
            this.grpActDetails.Controls.Add(this.btnDivide);
            this.grpActDetails.Controls.Add(this.btnMultiply);
            this.grpActDetails.Controls.Add(this.btnSubtract);
            this.grpActDetails.Controls.Add(this.lblInputNotification);
            this.grpActDetails.Controls.Add(this.txtInput1);
            this.grpActDetails.Controls.Add(this.btnAdd);
            this.grpActDetails.Location = new System.Drawing.Point(8, 280);
            this.grpActDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpActDetails.Name = "grpActDetails";
            this.grpActDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpActDetails.Size = new System.Drawing.Size(400, 237);
            this.grpActDetails.TabIndex = 2;
            this.grpActDetails.TabStop = false;
            this.grpActDetails.Text = "Standard Calculator";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Bisque;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(80, 176);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClear.Size = new System.Drawing.Size(112, 45);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblHolder
            // 
            this.lblHolder.AutoSize = true;
            this.lblHolder.BackColor = System.Drawing.Color.White;
            this.lblHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblHolder.ForeColor = System.Drawing.Color.Gray;
            this.lblHolder.Location = new System.Drawing.Point(32, 56);
            this.lblHolder.Name = "lblHolder";
            this.lblHolder.Size = new System.Drawing.Size(162, 31);
            this.lblHolder.TabIndex = 20;
            this.lblHolder.Text = "PlaceHolder";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(208, 176);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCalculate.Size = new System.Drawing.Size(112, 45);
            this.btnCalculate.TabIndex = 19;
            this.btnCalculate.Text = "=";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(272, 112);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDivide.Size = new System.Drawing.Size(50, 45);
            this.btnDivide.TabIndex = 18;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(208, 112);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(50, 45);
            this.btnMultiply.TabIndex = 17;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(144, 112);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(50, 45);
            this.btnSubtract.TabIndex = 16;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // lblInputNotification
            // 
            this.lblInputNotification.AutoSize = true;
            this.lblInputNotification.BackColor = System.Drawing.Color.Transparent;
            this.lblInputNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInputNotification.ForeColor = System.Drawing.Color.DarkRed;
            this.lblInputNotification.Location = new System.Drawing.Point(24, 24);
            this.lblInputNotification.Name = "lblInputNotification";
            this.lblInputNotification.Size = new System.Drawing.Size(45, 20);
            this.lblInputNotification.TabIndex = 14;
            this.lblInputNotification.Text = "Input";
            // 
            // txtInput1
            // 
            this.txtInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput1.Location = new System.Drawing.Point(24, 48);
            this.txtInput1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(352, 45);
            this.txtInput1.TabIndex = 8;
            this.txtInput1.Text = "0";
            this.txtInput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(80, 112);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 45);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddTransaction_Click);
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
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.rtxHistoryLog);
            this.groupBox1.Location = new System.Drawing.Point(8, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 184);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input History";
            // 
            // rtxHistoryLog
            // 
            this.rtxHistoryLog.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rtxHistoryLog.Location = new System.Drawing.Point(8, 24);
            this.rtxHistoryLog.Name = "rtxHistoryLog";
            this.rtxHistoryLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtxHistoryLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxHistoryLog.Size = new System.Drawing.Size(384, 152);
            this.rtxHistoryLog.TabIndex = 0;
            this.rtxHistoryLog.Text = "";
            this.rtxHistoryLog.TextChanged += new System.EventHandler(this.rtxHistoryLog_TextChanged);
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(415, 539);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.grpActDetails);
            this.Controls.Add(this.lblHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CalcForm";
            this.Text = "iCalculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FinanceForm_FormClosing);
            this.Load += new System.EventHandler(this.FinanceForm_Load);
            this.grpActDetails.ResumeLayout(false);
            this.grpActDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox grpActDetails;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblInputNotification;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Label lblHolder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxHistoryLog;
    }
}