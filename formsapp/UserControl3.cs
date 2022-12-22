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
    public partial class UserControl3 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl3()
        {
            InitializeComponent();
            Tanárlistázás();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var kiválasztottTanár = (Instructor)instructorBindingSource.Current;

            var törlendőTanár = (from x in context.Instructor
                                 where x.InstructorSk == kiválasztottTanár.InstructorSk
                                 select x).FirstOrDefault();

            context.Instructor.Remove(törlendőTanár);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            Tanárlistázás();
        }

        private void Tanárlistázás()
        {
            var tanárok = from x in context.Instructor
                          select x;

            instructorBindingSource.DataSource = tanárok.ToList();
        }
    }
}
