using formsapp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsapp
{
    public partial class UserControl1 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl1()
        {
            InitializeComponent();
            Tanérlistázás();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Tanérlistázás();

        }

        private void Tanérlistázás()
        {
            var tanárok = from x in context.Instructor
                          where x.Name.Contains(textBox1.Text)
                          select x;

            listBox1.DataSource = tanárok.ToList();
            listBox1.DisplayMember = "Name";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Instructor kiválasztottTanár = (Instructor)listBox1.SelectedItem;

            var órák = from x in context.Lesson
                       where x.InstructorFk == kiválasztottTanár.InstructorSk
                       select new
                       {
                           Kurzus = x.CourseFkNavigation.Name,
                           Idősáv = x.TimeFkNavigation.Name,
                           Terem = x.RoomFkNavigation.Name,
                           Nap = x.DayFkNavigation.Name
                       };

            orakBindingSource.DataSource = órák.ToList();
        }
    }
}
