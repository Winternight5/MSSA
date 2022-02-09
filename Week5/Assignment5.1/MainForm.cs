using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5._1
{
    public partial class MainForm : Form
    {
        EmployeeForm f1;
        CalcForm f2;

        public MainForm()
        {
            InitializeComponent();

            f1 = new EmployeeForm();
            f2 = new CalcForm();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            f1.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            f2.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (CloseFormPrompt() == DialogResult.No);
        }

        private DialogResult CloseFormPrompt()
        {
            var window = MessageBox.Show(
            "Exit application?",
            "Closing the application...",
            MessageBoxButtons.YesNo);

            return window;
        }
    }
}
