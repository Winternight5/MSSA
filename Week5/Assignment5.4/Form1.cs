using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookRepositoryDLL;

namespace Assignment5._4
{
    public partial class Form1 : Form
    {
        BookRepository bookRepository;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bookRepository = new BookRepository();
            RefreshData();
        }

        private void RefreshData()
        {
            gridBooks.DataSource = null;
            gridBooks.RowTemplate.Height = 120;

            gridBooks.DataSource = bookRepository.GetBooksList();
            gridBooks.Columns["imageUrl"].Visible = false;
            //gridBooks.Columns["AmazonUrl"].Visible = false;

            foreach (Book book in bookRepository.GetBooksList())
            {
                book.bitmap = GetImageFromUrl(book.imageUrl);
            }
        }

        private DataGridViewCellStyle GetHyperLinkStyleForGridCell()
        {
            {
                DataGridViewCellStyle cell = new DataGridViewCellStyle();
                cell.ForeColor = Color.Blue;
                return cell;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn col = gridBooks.Columns[e.ColumnIndex];
            if (col.Name == "bitmap")
            {
                col.HeaderText = "Book Cover";
                ((DataGridViewImageColumn) gridBooks.Columns[e.ColumnIndex]).ImageLayout = DataGridViewImageCellLayout.Stretch;

            }else if (col.Name == "AmazonUrl") {
                col.DefaultCellStyle = GetHyperLinkStyleForGridCell();
            }
        }

        public static Image GetImageFromUrl(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);

            using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (Stream stream = httpWebReponse.GetResponseStream())
                {
                    return Image.FromStream(stream);
                }
            }
        }

        private void gridBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (gridBooks.Columns[gridBooks.CurrentCell.ColumnIndex].HeaderText.Contains("AmazonUrl"))
            {
                if (!String.IsNullOrWhiteSpace(gridBooks.CurrentCell.EditedFormattedValue.ToString()))
                {
                    System.Diagnostics.Process.Start("https://amazon.com/" + gridBooks.CurrentCell.EditedFormattedValue);
                }
            }
        }

        private void btnShowAddForm_Click(object sender, EventArgs e)
        {
            if (gbAddForm.Visible == true)
            {
                HideAddForm();
            }
            else
            {
                gbAddForm.Visible = true;
                gridBooks.Enabled = false;
            }
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            HideAddForm();
        }

        private void btnDeletedSelected_Click(object sender, EventArgs e)
        {
            int i = gridBooks.CurrentRow.Index;
            if (i != -1)
            {
                bookRepository.DeleteBook(i);
                RefreshData();
            }
        }

        private void btnSubmitAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtInputISBN.Text) ||
                String.IsNullOrEmpty(txtInputBookName.Text) ||
                String.IsNullOrEmpty(txtInputAuthor.Text) ||
                String.IsNullOrEmpty(txtInputAmazonUrl.Text) ||
                String.IsNullOrEmpty(txtInputImageUrl.Text) ||
                String.IsNullOrEmpty(txtInputPrice.Text)
                )
            {
                MessageBox.Show("All fields are required!", "Warning");
                return;
            }

            bookRepository.AddBook(
                new Book() {
                    ISBN10 = txtInputISBN.Text,
                    BookName = txtInputBookName.Text,
                    Author = txtInputAuthor.Text,
                    AmazonUrl = txtInputAmazonUrl.Text,
                    imageUrl = txtInputImageUrl.Text,
                    PublishedDate = dtInputDate.Value,
                    Price = float.Parse(txtInputPrice.Text),
                });

            RefreshData();
            HideAddForm();
        }

        public void HideAddForm()
        {
            gbAddForm.Visible = false;
            gridBooks.Enabled = true;
        }
    }
}
