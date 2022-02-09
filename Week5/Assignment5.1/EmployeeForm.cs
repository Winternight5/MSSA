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
    public partial class EmployeeForm : Form
    {
        private Dictionary<int, Employee> employees;
        private Timer t = new Timer();
        private int _CurrentSid = 10000;

        public EmployeeForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            employees = new Dictionary<int, Employee>();

            int sid = _CurrentSid++;
            employees.Add(sid, new Employee()
            {
                Eid = sid,
                FirstName = "Tai",
                LastName = "Huynh",
                Department = Department.Administration,
                Dob = DateTime.Parse("2008-05-01"),
                SSN = "123456789"
            }); 

            lblNotification.Text = "";
            cmbDepartment.DataSource = Enum.GetValues(typeof(Department));
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            RefreshInputData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == String.Empty) {
                DisplayInputErrorMsg("Please input a first name.");
                txtFName.BackColor = Color.Red;
                return;

            } else if (txtFName.Text == String.Empty) {
                DisplayInputErrorMsg("Please input a last name.");
                txtFName.BackColor = Color.Red;
                return;
            }

            int sid = _CurrentSid++;
            employees.Add(sid, new Employee()
            {
                Eid = sid,
                FirstName = txtFName.Text,
                LastName = txtLName.Text,
                Department = (Department)cmbDepartment.SelectedIndex,
                Dob = DateTime.Parse(dtDob.Text),
                SSN = mtxtSSN.Text.Replace("-", "")
            }); ;

            DisplayInputErrorMsg($"Added \"{txtFName.Text}\"!");
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
            txtFName.BackColor = Color.White;
            txtLName.BackColor = Color.White;
            txtFName.Clear();
            txtLName.Clear();
            grdData.DataSource = null;
            grdData.DataSource = employees.Values.ToList();
        }

        private void btnRemoveCoffee_Click(object sender, EventArgs e)
        {
            DisplayDataErrorMsg($"Removed \"{grdData.CurrentRow.Cells[1].Value}\"!");
            employees.Remove((int)grdData.CurrentRow.Cells[0].Value);
            RefreshInputData();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BeverageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void txtFName_Leave(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtFName.Text, "[^a-zA-z ]"))
            {
                txtFName.BackColor = Color.Red;
                txtFName.Focus();
                DisplayInputErrorMsg("Please only input alphabet letters.");

            }
            else
            {
                txtFName.BackColor = Color.White;
            }
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtLName.Text, "[^a-zA-z ]"))
            {
                txtLName.BackColor = Color.Red;
                txtLName.Focus();
                DisplayInputErrorMsg("Please only input alphabet letters.");

            }
            else
            {
                txtFName.BackColor = Color.White;
            }
        }
    }
}
