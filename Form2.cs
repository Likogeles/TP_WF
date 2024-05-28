using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP.Models;

namespace TP_WF
{
    public partial class Form2 : Form
    {
        public Form2(IEnumerable<Student> students)
        {
            InitializeComponent();
            foreach (var student in students)
            {
                listBox1.Items.Add(student);
            }
        }
    }
}
