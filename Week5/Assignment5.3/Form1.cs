using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;

namespace Assigntment5._3
{
    public partial class Form1 : Form
    {
        FileStream fileStream;
        BinaryFormatter binaryFormatter;
        DataContractJsonSerializer jsonFormatter;
        SoapFormatter soapFormatter;

        public Form1()
        {
            InitializeComponent();

            Directory.CreateDirectory(@"files");

            binaryFormatter = new BinaryFormatter();
            soapFormatter = new SoapFormatter();

            cmbSerializeSelection.DataSource = Enum.GetValues(typeof(Serialize));
            cmbSerializeSelection.DropDownStyle = ComboBoxStyle.DropDownList;

            RefreshFolderView();
        }

        public int GetIndex()
        {
            string fullname = @"files\i.index";

            if (!File.Exists(fullname)) {
                File.WriteAllText(fullname, "1", Encoding.UTF8);
                return 1;
            }

            int newIndex = 1;

            using (FileStream fs = new FileStream(fullname, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {
                StreamReader sr = new StreamReader(fs);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    newIndex += int.Parse(sr.ReadToEnd());
                    fs.SetLength(0);
                    sw.Write(newIndex);
                }
            }

            return newIndex;
        }

        public void RefreshFolderView()
        {
            lsbFiles.Items.Clear();

            DirectoryInfo dirInfo = new DirectoryInfo(@"files");
            FileInfo[] Files = new string[] { "*.txt", "*.xml", "*.json" }
                                .SelectMany(i => dirInfo.GetFiles(i, SearchOption.AllDirectories))
                                .ToArray();

            foreach (FileInfo file in Files)
            {
                lsbFiles.Items.Add(file.Name);
            }
        }

        public Student NewStudentObject(int index)
        {
            Student student = new Student();
            student.Sid = index;
            student.FirstName = txtInputFName.Text;
            student.LastName = txtInputLName.Text;
            student.comment = txtInputComment.Text;
            student.privateKey = txtInputPrivateKey.Text;

            return student;
        }

        public void DisplayDeserializedData(Student student)
        {
            txtDataFName.Text = student.FirstName;
            txtDataLName.Text = student.LastName;
            txtDataComment.Text = student.comment;
            txtDataSid.Text = student.Sid.ToString();
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtInputFName.Text) || string.IsNullOrEmpty(txtInputLName.Text)) {
                MessageBox.Show("Both first and last name entry is required!", "Input Required");
                return;
            }
            int index = GetIndex();

            string filename = txtInputFName.Text + "_" + txtInputLName.Text + "_" + index;
            Student student = NewStudentObject(index);

            Serialize serializeSelection = (Serialize)cmbSerializeSelection.SelectedIndex;
            switch (serializeSelection)
            {
                case Serialize.XML:
                    fileStream = new FileStream(@"files\XML_" + filename + ".xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    soapFormatter.Serialize(fileStream, student);
                    break;

                case Serialize.JSON:
                    fileStream = new FileStream(@"files\JSON_" + filename + ".json", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    jsonFormatter = new DataContractJsonSerializer(typeof(Student));
                    jsonFormatter.WriteObject(fileStream, student);
                    break;

                default:
                    fileStream = new FileStream(@"files\Binary_" + filename + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    binaryFormatter.Serialize(fileStream, student);
                    break;
            }

            fileStream.Close();

            MessageBox.Show($"Your inputs is serialized as {serializeSelection} data.", "Serialization Successful!");
            RefreshFolderView();
        }

        private void lsbFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbFiles.SelectedIndex == -1)
                return;

            string filename = @"files\" + lsbFiles.SelectedItem.ToString();
            string[] dataType = lsbFiles.SelectedItem.ToString().Split('_');

            if (!File.Exists(filename)) {
                RefreshFolderView();
                return;
            }

            rtbSerializeData.LoadFile(filename, RichTextBoxStreamType.PlainText);
            SerialToObject(filename, dataType[0]);
        }

        private void SerialToObject(string filename, string dataType)
        {
            if (String.IsNullOrEmpty(filename) || String.IsNullOrEmpty(dataType))
                return;

            Student student;

            fileStream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);
            switch (dataType)
            {
                case "Binary":
                    student = (Student) binaryFormatter.Deserialize(fileStream);
                    break;

                case "XML":
                    student = (Student) soapFormatter.Deserialize(fileStream);
                    break;

                case "JSON":
                    jsonFormatter = new DataContractJsonSerializer(typeof(Student));
                    student = (Student) jsonFormatter.ReadObject(fileStream);
                    break;

                default:
                    fileStream.Close();
                    return;
            }
            fileStream.Close();

            DisplayDeserializedData(student);
        }
    }
}
