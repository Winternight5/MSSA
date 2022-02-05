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
    public partial class FinanceForm : Form
    {
        private Timer t = new Timer();
        AccountBalancer account;
        private List<FinanceTransaction> transactionHistory;

        public FinanceForm()
        {
            InitializeComponent();
        }
        private void FinanceForm_Load(object sender, EventArgs e)
        {
            account = new AccountBalancer();
            account.LowBalance += AccountLowBalance;
            account.withdrawable = true;

            transactionHistory = new List<FinanceTransaction>();

            transactionHistory.Add(new FinanceTransaction()
            {
                amount = 400,
                transactionType = TransactionType.Deposit,
            });
            transactionHistory.Add(new FinanceTransaction()
            {
                amount = 100,
                transactionType = TransactionType.Withdrawal,
            });
            transactionHistory.Add(new FinanceTransaction()
            {
                amount = 50,
                transactionType = TransactionType.Withdrawal,
            });

            foreach (var transaction in transactionHistory)
            {
                account.Balance += (transaction.transactionType == TransactionType.Deposit) ? transaction.amount : transaction.amount * -1;
            }

            cmbType.DataSource = Enum.GetValues(typeof(TransactionType));
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            lblNotification.Text = "";
            RefreshInputData();
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == String.Empty) {
                DisplayInputErrorMsg("Please input an amount");
                txtAmount.BackColor = Color.Red;
                return;
            }

            double transactionAmount = Double.Parse(txtAmount.Text);
            TransactionType transactionType = (TransactionType)cmbType.SelectedIndex;


            account.Balance += (transactionType == TransactionType.Deposit) ? transactionAmount : transactionAmount * -1;

            if (account.withdrawable || transactionType == TransactionType.Deposit) {
                transactionHistory.Add(new FinanceTransaction()
                {
                    amount = transactionAmount,
                    transactionType = transactionType,
                });

                DisplayInputErrorMsg($"{transactionType} of {transactionAmount.ToString("$#.#")} logged!");
            }

            RefreshInputData();
        }

        private void RefreshInputData()
        {

            txtAmount.BackColor = Color.White;
            txtAmount.Clear();
            grdTransactionHistory.DataSource = null;
            grdTransactionHistory.DataSource = transactionHistory;

            if (account.Balance > 200)
                DisplayDataErrorMsg($"Balance: {account.Balance.ToString("$#.#")}");
            else
                DisplayDataErrorMsg($"Balance: {account.Balance.ToString("$#.#")} (Low Balance!)");
        }

        private void AccountLowBalance()
        {
            MessageBox.Show($"Warning! Your balance is below $200 limit! Please deposit immediately");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FinanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void txtBalance_Leave(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAmount.Text, "[^0-9.,]"))
            {
                txtAmount.BackColor = Color.Red;
                txtAmount.Focus();
                DisplayInputErrorMsg("Please enter only numbers.");

            }
            else
            {
                txtAmount.BackColor = Color.White;
            }
        }

        private void DisplayInputErrorMsg(string msg)
        {
            lblInputNotification.Text = msg;
            t.Interval = (10000);
            t.Tick += new EventHandler(ClearInputErrorMsg);
            t.Start();
        }

        private void ClearInputErrorMsg(object sender, EventArgs e)
        {
            lblInputNotification.Text = String.Empty;
        }

        private void DisplayDataErrorMsg(string msg)
        {
            lblNotification.Text = msg;
        }
    }
}