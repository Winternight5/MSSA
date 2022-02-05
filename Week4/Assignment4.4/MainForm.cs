using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4._4
{
    public partial class MainForm : Form
    {
        BeverageForm f1;
        FinanceForm f2;

        public MainForm()
        {
            InitializeComponent();

            f1 = new BeverageForm();
            f2 = new FinanceForm();
        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {
            f1.Show();
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            f2.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
                Application.Exit();
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
