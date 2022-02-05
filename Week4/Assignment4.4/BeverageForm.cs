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
    public partial class BeverageForm : Form
    {
        private List<Coffee> coffeeList;
        private Timer t = new Timer();

        public BeverageForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            coffeeList = new List<Coffee>();

            coffeeList.Add(new Coffee()
            {
                Name = "Expresso",
                Price = 4.49,
                Size = BeverageSize.Tall
            });
            coffeeList.Add(new Coffee()
            {
                Name = "Americano",
                Price = 3.49,
                Size = BeverageSize.Tall
            });
            coffeeList.Add(new Coffee()
            {
                Name = "Cafe Latte",
                Price = 4.29,
                Size = BeverageSize.Tall
            });
            coffeeList.Add(new Coffee()
            {
                Name = "Cappuccino",
                Price = 4.99,
                Size = BeverageSize.Tall
            });

            lblNotification.Text = "";
            cmbSize.DataSource = Enum.GetValues(typeof(BeverageSize));
            cmbSize.DropDownStyle = ComboBoxStyle.DropDownList;
            RefreshInputData();
        }

        private void btnAddCoffee_Click(object sender, EventArgs e)
        {
            if (txtName.Text == String.Empty) {
                DisplayInputErrorMsg("Please input a beverage name.");
                txtName.BackColor = Color.Red;
                return;

            } else if (txtPrice.Text == String.Empty) {
                DisplayInputErrorMsg("Please input a price for this beverage.");
                txtPrice.BackColor = Color.Red;
                return;
            }

            coffeeList.Add(new Coffee()
            {
                Name = txtName.Text,
                Price = Double.Parse(txtPrice.Text),
                Size = (BeverageSize)cmbSize.SelectedIndex
            });

            DisplayInputErrorMsg($"Added \"{txtName.Text}\"!");
            RefreshInputData();
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
            t.Interval = (10000);
            t.Tick += new EventHandler(ClearDataErrorMsg);
            t.Start();
        }

        private void ClearDataErrorMsg(object sender, EventArgs e)
        {
            lblNotification.Text = String.Empty;
        }

        private void RefreshInputData()
        {
            txtName.BackColor = Color.White;
            txtPrice.BackColor = Color.White;
            txtName.Clear();
            txtPrice.Clear();
            grdCoffee.DataSource = null;
            grdCoffee.DataSource = coffeeList;
        }

        private void btnRemoveCoffee_Click(object sender, EventArgs e)
        {
            DisplayDataErrorMsg($"Removed \"{grdCoffee.CurrentRow.Cells[1].Value}\"!");
            coffeeList.RemoveAt(grdCoffee.CurrentRow.Index);
            RefreshInputData();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPrice.Text, "[^0-9.,]"))
            {
                txtPrice.BackColor = Color.Red;
                txtPrice.Focus();
                DisplayInputErrorMsg("Please enter only numbers.");

            } else {
                txtPrice.BackColor = Color.White;
            }
        }

        private void BeverageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtName.Text, "[^a-zA-z ]"))
            {
                txtName.BackColor = Color.Red;
                txtName.Focus();
                DisplayInputErrorMsg("Please input a beverage name.");

            }
            else
            {
                txtName.BackColor = Color.White;
            }
        }
    }
}
