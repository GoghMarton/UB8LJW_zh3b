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
    public partial class UserControl2 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl2()
        {
            InitializeComponent();
            instructorBindingSource.DataSource = context.Instructor.ToList();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                Instructor instructor = new Instructor();
                instructor.Name = form2.textBoxName.Text;
                instructor.Salutation = form2.textBoxSalutation.Text;

                context.Instructor.Add(instructor);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                instructorBindingSource.DataSource = context.Instructor.ToList();

                MessageBox.Show("OK-val zárult");
            }
            else
            {
                MessageBox.Show("Nem OK-val zárult");
            }
        }
    }
}
