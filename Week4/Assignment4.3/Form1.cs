using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Assignment4._3
{
    public partial class Form1 : Form
    {
        ArrayList studentList;
        int SidCounter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtFirstName.Text) &&
                !String.IsNullOrEmpty(txtLastName.Text) &&
                !String.IsNullOrEmpty(txtSid.Text))
            {
                studentList.Add(new Student() { 
                    Sid = Int32.Parse(txtSid.Text), 
                    FirstName = txtFirstName.Text, 
                    LastName = txtLastName.Text, 
                    Grade = (Grades) cbGrades.SelectedIndex, 
                    MonthOfAdmission = (Months) cbMonth.SelectedIndex 
                });

                RefreshData();

                MessageBox.Show($"Added a new student record: {txtFirstName.Text} {txtLastName.Text}.");

                SidCounter++;

                ClearInputs();
            }
        }

        private void studentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentList = new ArrayList();
            studentList.Add(new Student() { Sid = 1, FirstName = "Tai", LastName = "Huynh", Grade = Grades.A, MonthOfAdmission = Months.January });
            studentList.Add(new Student() { Sid = 2, FirstName = "Drew", LastName = "Berrymore", Grade = Grades.B, MonthOfAdmission = Months.February });
            studentList.Add(new Student() { Sid = 3, FirstName = "David", LastName = "Goliath", Grade = Grades.C, MonthOfAdmission = Months.March });
            studentList.Add(new Student() { Sid = 4, FirstName = "Peter", LastName = "Parker", Grade = Grades.D, MonthOfAdmission = Months.April });

            studentGrid.DataSource = studentList;

            cbMonth.DataSource = Enum.GetValues(typeof(Months));
            cbMonth.DropDownStyle = ComboBoxStyle.DropDownList;

            cbGrades.DataSource = Enum.GetValues(typeof(Grades));
            cbGrades.DropDownStyle = ComboBoxStyle.DropDownList;

            SidCounter = studentList.Count + 1;

            txtSid.Text = SidCounter.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        
        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (studentGrid.RowCount > 0) {
                studentList.RemoveAt(studentGrid.CurrentRow.Index);
                RefreshData();
            }
        }

        private void ClearInputs()
        {
            txtSid.Text = SidCounter.ToString();
            txtFirstName.Clear();
            txtLastName.Clear();
            cbMonth.SelectedItem = (Months) 0;
            cbGrades.SelectedItem = (Grades) 0;
        }

        private void RefreshData()
        {
            studentGrid.DataSource = null;
            studentGrid.DataSource = studentList;
        }

        private void UpdateIcon(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtFirstName.Text) &&
                !String.IsNullOrEmpty(txtLastName.Text))
            {
                pictureBox1.Load($"https://avatars.dicebear.com/api/avataaars/{txtFirstName.Text}%20{txtLastName.Text}.png");
            }
        }
    }
}
