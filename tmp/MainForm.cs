using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Runtime.Serialization.Json;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Project1
{
    public partial class MainForm : MaterialForm
    {
        FileStream fileStream;
        DataContractJsonSerializer jsonFormatter;
        DataTable dt;
        private string fileDirectory = @"files";

        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            Directory.CreateDirectory(fileDirectory);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt = new DataTable() { TableName = "StockList" };
            LoadRecentData();
        }

        public void LoadRecentData()
        {
            var directory = new DirectoryInfo(fileDirectory);
            var myFile = directory.GetFiles()
                .OrderByDescending(f => f.LastWriteTime)
                .First().ToString();

            fileStream = new FileStream($"{fileDirectory}/{myFile}", FileMode.OpenOrCreate, FileAccess.Read);
            jsonFormatter = new DataContractJsonSerializer(typeof(DataTable));
            dt = (DataTable)jsonFormatter.ReadObject(fileStream);
            fileStream.Close();
            ReloadDataGrid();
        }

        public void ReloadDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
            /*for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }*/
            foreach (DataGridViewColumn dgvc in dataGridView1.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public void LoadHTML()
        {
            dt = new DataTable() { TableName = "UnusualStockList" };
            var web = new HtmlWeb();
            var doc = web.Load("https://finviz.com/screener.ashx?v=111&s=ta_unusualvolume&f=geo_usa,sh_curvol_o100&o=-change");

            foreach (var row in doc.DocumentNode.SelectNodes("//table[contains(@class, 'table-light')]//tr"))
            {
                var nodes = row.SelectNodes("td");
                string[] nodeRow = new string[11];

                if (nodes == null)
                    continue;

                if (nodes[0].InnerText == "No.")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        dt.Columns.Add(nodes[i].InnerText, typeof(string));
                    }
                }
                
                if (nodes[0].InnerText != "No.")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        nodeRow[i] = nodes[i].InnerText;
                    }
                    dt.Rows.Add(nodeRow);
                }
            }
            ReloadDataGrid();
        }

        public void SaveToJSON()
        {
            fileStream = new FileStream(@"files\"+ DateTime.Now.ToString("yyyyMMdd_HHmm")+".json", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            jsonFormatter = new DataContractJsonSerializer(typeof(DataTable));
            jsonFormatter.WriteObject(fileStream, dt);
            fileStream.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedSymbol = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            webView.CoreWebView2.Navigate($"https://www.tradingview.com/chart/?symbol={selectedSymbol}");
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadHTML();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private DialogResult CloseFormPrompt()
        {
            var window = MessageBox.Show(
            "Exit application?",
            "Closing the application...",
            MessageBoxButtons.YesNo);

            return window;
        }

        private void saveListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveToJSON();
            MessageBox.Show("Data is saved as the latest file in your directory.","Data is Saved");
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog openFileDialog = new CommonOpenFileDialog();
            openFileDialog.InitialDirectory = fileDirectory;

            if (openFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                fileStream = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate, FileAccess.Read);
                jsonFormatter = new DataContractJsonSerializer(typeof(DataTable));
                dt = (DataTable)jsonFormatter.ReadObject(fileStream);
                fileStream.Close();
                ReloadDataGrid();
            }
        }

        private void mostRecentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadRecentData();
        }
    }
}
