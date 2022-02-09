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
    public partial class CalcForm : Form
    {
        private Timer t = new Timer();
        private Calculator calc;
        private float _total = 0;
        private float _tmpNum = 0;
        private char _type = '0';
        public CalcForm()
        {
            InitializeComponent();
        }

        private void FinanceForm_Load(object sender, EventArgs e)
        {
            calc = new Calculator();
            lblInputNotification.Text = "";
            lblHolder.Text = "";
            rtxHistoryLog.SelectionAlignment = HorizontalAlignment.Right;
            RefreshInputData();
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            _type = '1';
            DoCalculation();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            _type = '2';
            DoCalculation();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            _type = '3';
            DoCalculation();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            _type = '4';
            DoCalculation();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (FormNotValidated())
                return;

            if (_type != '0') {
                DoCalculation();
                lblHolder.Text = "";
                rtxHistoryLog.Text += "= " + _total.ToString() + "\n---------------\n";
                _total = 0;
                _type = '0';
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblHolder.Text = "";
            rtxHistoryLog.Text = "";
            _total = 0;
            _type = '0';
            RefreshInputData();
        }

        private void DoCalculation()
        {
            if (_type == 0)
                return;

            string _t = "";

            switch (_type) {
                case '1':
                    _t = "+";
                    if (StoreTmp(_t) == 2)
                    {
                        calc.number = _total;
                        _total = calc.addition(_tmpNum);
                    }
                    break;

                case '2':
                    _t = "-";
                    if (StoreTmp(_t) == 2)
                    {
                        calc.number = _total;
                        _total = calc.subtraction(_tmpNum);
                    }
                    break;

                case '3':
                    _t = "×";
                    if (StoreTmp(_t) == 2)
                    {
                        calc.number = _total;
                        _total = calc.multiplication(_tmpNum);
                    }
                    break;

                case '4':
                    if (FormNotValidated() || float.Parse(txtInput1.Text) == 0)
                    {
                        DisplayInputErrorMsg("Cannot divide by zero.");
                        return;
                    }

                    _t = "÷";
                    if (StoreTmp(_t) == 2)
                    {
                        calc.number = _total;
                        _total = calc.division(_tmpNum);
                    }
                    break;
            }

            lblHolder.Text = _total.ToString() + " "+_t;
        }

        private int StoreTmp(string _t)
        {
            if (FormNotValidated())
                return 0;

            _tmpNum = float.Parse(txtInput1.Text);

            if (_total == 0)
            {
                _total = _tmpNum;
                RefreshInputDataWithResult("");
                return 1;
            }

            RefreshInputDataWithResult(_t);
            return 2;
        }

        private bool FormNotValidated()
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtInput1.Text, "[^0-9]") || txtInput1.Text == String.Empty)
            {
                DisplayInputErrorMsg("Please enter only numbers.");
                return true;

            }
            lblInputNotification.Text = String.Empty;
            return false;
        }
        private void RefreshInputData()
        {
            txtInput1.Clear();
            txtInput1.Focus();
        }
        private void RefreshInputDataWithResult(string _t = "+")
        {
            txtInput1.Clear();
            txtInput1.Focus();
            rtxHistoryLog.Text += _t+" "+_tmpNum.ToString() + "\n";
        }

        private void DisplayInputErrorMsg(string msg)
        {
            txtInput1.Focus();
            lblInputNotification.Text = msg;
            t.Interval = (10000);
            t.Tick += new EventHandler(ClearInputErrorMsg);
            t.Start();
        }

        private void ClearInputErrorMsg(object sender, EventArgs e)
        {
            lblInputNotification.Text = String.Empty;
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

        private void rtxHistoryLog_TextChanged(object sender, EventArgs e)
        {
            rtxHistoryLog.SelectionStart = rtxHistoryLog.Text.Length;
            rtxHistoryLog.ScrollToCaret();
        }
    }
}