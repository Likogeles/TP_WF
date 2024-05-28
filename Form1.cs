using System.Xml.Serialization;
using TP.Models;

namespace TP_WF
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        string fileName = "D:\\Projects\\VisualStudioProjects\\goSEXam\\OP\\TP_WF\\file\\students.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length > 0 && surnameTextBox.Text.Length > 0)
            {
                Student new_student = new Student(nameTextBox.Text, surnameTextBox.Text, int.Parse(ageNumericUpDown.Value.ToString()));
                listBox.Items.Add(new_student);
                students.Add(new_student);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                serializer.Serialize(fs, students);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                students = (List<Student>)serializer.Deserialize(fs);
                listBox.Items.Clear();
                foreach (Student student in students)
                {
                    listBox.Items.Add(student);
                }
            }
        }

        private void findAgeButton_Click(object sender, EventArgs e)
        {
            int age = int.Parse(findAgeNumericUpDown.Value.ToString());

            //List<Student> new_students = students.FindAll(s =>  s.Age == age);
            //var max_students = (List<Student>)students.GroupBy(x => x.Age).OrderBy(x => x.Count());

            /*
            IEnumerable<Student> new_students = from student in students
                                                where student.Age > age
                                                select student;
            */

            List<Student> groups = new List<Student>();

            groups.Add(new Student("aa", "aa", 18));
            groups.Add(new Student("bb", "bb", 19));
            groups.Add(new Student("cc", "cc", 20));

            IEnumerable<Student> new_students = from student in students
                                                join gr in groups on student.Age equals gr.Age
                                                select new Student(student.Name, gr.Surname, student.Age);

            Form new_form = new Form2(new_students);
            new_form.ShowDialog();
        }
    }
}
