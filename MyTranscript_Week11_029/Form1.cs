using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTranscript_Week11_029
{
    public partial class Form1 : Form
    {
        List<Course> year1Sem1;
        List<Course> year1Sem2;
        public Form1()
        {
            InitializeComponent();
            year1Sem1 = new List<Course>();
            year1Sem2 = new List<Course>();
        }

        class Course
        {
            public string CourseID { get; set; }
            public string CourseName { get; set; }
            public string CourseCredit { get; set; }
            public string Grade { get; set; }
            public override string ToString()
            {
                return CourseID + "," + CourseName + "," + CourseCredit + "," + Grade;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddGrade(object sender, EventArgs e)
        {
            Course newCourse = new Course();
            newCourse.CourseID = textBoxCourseID.Text;
            newCourse.CourseName = textBoxCourseName.Text;
            newCourse.CourseCredit = textBoxCourseCredit.Text;
            newCourse.Grade = textBoxGrade.Text;

            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    dataGridViewY1S1.DataSource = null;
                    year1Sem1.Add(newCourse);
                    dataGridViewY1S1.DataSource = year1Sem1;
                    break;
                case 1:
                    dataGridViewY1S2.DataSource = null;
                    year1Sem2.Add(newCourse);
                    dataGridViewY1S2.DataSource = year1Sem2;
                    break;
            }
        }

        private void SaveFile(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int counter;
            //// prepare data

            // write header
            sb.AppendLine(labelUniversityName.Text);
            sb.AppendLine(labelFacultyName.Text);


            // Year 1 Semester 1

            if (year1Sem1.Count > 0) // เขียนลงไฟล์เมื่อมีข้อมูลใน list เท่านั้น
            {
                sb.AppendLine("");
                sb.AppendLine("Year 1 Semester 1");
                sb.AppendLine("No, Course ID, Course Name, Credit, Grade");
                counter = 1;
                foreach (var item in year1Sem1)
                {
                    sb.AppendLine(counter.ToString() + ", " + item.ToString());
                    counter++;
                }
            }

            // Year 1 Semester 2
            if (year1Sem2.Count > 0) // เขียนลงไฟล์เมื่อมีข้อมูลใน list เท่านั้น
            {
                sb.AppendLine("");
                sb.AppendLine("Year 1 Semester 2");
                sb.AppendLine("No, Course ID, Course Name, Credit, Grade");
                counter = 1;
                foreach (var item in year1Sem2)
                {
                    sb.AppendLine(counter.ToString() + ", " + item.ToString());
                    counter++;
                }
            }

            // Year 2 Semester 1
            // สามารถคัดลอกประโยค if มาทั้งหมด แล้วเปลี่ยนขื่อ  list 
            // ให้เป็นหน้าที่ของนักศึกษาในการทำเพิ่ม

            // Year 2 Semester 2

            // Year 3 Semester 1

            // Year 3 Semester 2

            // Year 4 Semester 1

            // Year 4 Semester 2

            string filename = "mygrade.csv";
            WriteToFile(filename, sb);

        }
        private void WriteToFile(string filename, StringBuilder sb)
        {
            Console.WriteLine(sb.ToString());
            System.IO.File.WriteAllText(filename, sb.ToString());
        }
    }
}
