using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment6._2
{
    public partial class Form1 : Form
    {
        CarRepository carsRepo;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            carsRepo = new CarRepository();
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = carsRepo.GetCars();

            if (dataGridView1.Rows.Count == 0)
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        public void EmptyDataEntries()
        {
            txtVIN.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtPrice.Clear();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            EmptyDataEntries();
            carDetailBox.Visible = true;
            btnSubmit.Text = "Submit";
            carDetailForm.Text = "Add a new car";
            txtVIN.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            carDetailBox.Visible = true;
            btnSubmit.Text = "Update";
            carDetailForm.Text = "Update Car:";
            txtVIN.Enabled = false;
            try
            {
                Car curCar = carsRepo.FindByVIN(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                txtVIN.Text = curCar.VIN;
                txtMake.Text = curCar.Make;
                txtModel.Text = curCar.Model;
                txtYear.Text = curCar.Year;
                txtPrice.Text = curCar.Price.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selectedItem = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (!String.IsNullOrEmpty(selectedItem))
            {
                DialogResult dialogResult = MessageBox.Show($"Delete from record? VIN: {selectedItem}?", "Delete VIN", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    var obj = carsRepo.FindByVIN(selectedItem);
                    carsRepo.DeleteRecord(obj);
                    RefreshGrid();
                    MessageBox.Show("Record is deleted");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool formIsValid = FormValidation();

            if (!formIsValid)
                return;

            Car car = new Car();
            car.VIN = txtVIN.Text;
            car.Make = txtMake.Text;
            car.Model = txtModel.Text;
            car.Year = txtYear.Text;
            car.Price = decimal.Parse(txtPrice.Text);

            if (btnSubmit.Text == "Submit")
            {
                string newItem = carsRepo.AddRecord(txtVIN.Text, car);

                if (String.IsNullOrEmpty(newItem))
                    MessageBox.Show($"VIN: {txtVIN.Text} record added to repository.");
                else
                {
                    MessageBox.Show($"VIN: {txtVIN.Text} record already exist.");
                }
            }
            else if (btnSubmit.Text == "Update")
            {
                carsRepo.UpdateRecord(txtVIN.Text, car);
                MessageBox.Show($"VIN: {txtVIN.Text} record is updated.");
            }

            RefreshGrid();
            carDetailBox.Visible = false;
        }

        private bool FormValidation()
        {
            TextBox[] txtBoxes = new TextBox[] { txtVIN, txtMake, txtModel, txtPrice };

            foreach (TextBox txtBox in txtBoxes)
            {
                if (String.IsNullOrEmpty(txtBox.Text))
                {
                    MessageBox.Show($"{txtBox.Tag} cannot be empty!");
                    return false;
                }
            }

            if (String.IsNullOrEmpty(txtYear.Text) || !txtYear.Text.All(c => Char.IsNumber(c)) || txtYear.Text.Length > 4)
            {
                MessageBox.Show("Year can only contain digits and no more than 4 digits long!");
                return false;
            }

            Decimal value;
            if (!Decimal.TryParse(txtPrice.Text, out value))
            {
                MessageBox.Show($"Price can only contain finance digits!");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carDetailBox.Visible = false;
        }
    }
}
