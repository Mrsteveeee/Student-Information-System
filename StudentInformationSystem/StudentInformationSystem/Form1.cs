using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dgvStudents.ColumnCount = 8;
            dgvStudents.Columns[0].Name = "Student Number";
            dgvStudents.Columns[1].Name = "Firstname";
            dgvStudents.Columns[2].Name = "Lastname";
            dgvStudents.Columns[3].Name = "Age";
            dgvStudents.Columns[4].Name = "Sex";
            dgvStudents.Columns[5].Name = "Skills";
            dgvStudents.Columns[6].Name = "Birthday";
            dgvStudents.Columns[7].Name = "Year Level";

            DataGridViewImageColumn dgvimg = new DataGridViewImageColumn();
            dgvimg.HeaderText = "Image";
            dgvimg.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvStudents.Columns.Add(dgvimg);

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            img.Image = Image.FromFile("C:\\qwerty");

        }

        private void saveBox_Click(object sender, EventArgs e)
        {
            string sex = " ", skills = " ";
            

            if (rbmale.Checked)
            {
                sex = "Male";
            }
            else if (rbfemale.Checked)
            {
                sex = "Female";
            }

            if (cpp.Checked)
            {
                skills += "C++";
            }
             if (cs.Checked)
            {
                skills += "C#";
            }
             if (php.Checked)
            {
                skills += "PHP";
            }
            if (java.Checked)
            {
                skills += "JAVA";
            }
             if (VSN.Checked)
            {
                skills += "VS.NET";
            }
            if (python.Checked)
            {
                skills += "python";
            }

            dgvStudents.Rows.Add(txtStudentNumber.Text, fName.Text, lName.Text, Age.Value, sex, skills, birthDay.Value, yearLevel.SelectedItem, img.Image);

        }

        private void Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Choose image (*.jpg; *.png; *.gif;) | *.jpg; *.png; *.gif;";

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                img.Image = Image.FromFile(openfile.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (img.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                img.Image.Save(ms, img.Image.RawFormat);
                byte[] imgData = ms.ToArray();
            }
        }
    }
}
