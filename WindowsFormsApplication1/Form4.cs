using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Lessor : Form
    {
        public Lessor()
        {
            InitializeComponent();         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new Profile();
            myForm.Show();
            this.Hide();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new MyApartment();
            myForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myForm = new AddApartment();
            myForm.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            var myForm = new YourRequest();
            myForm.Show();
            this.Hide();
        }

        private void Lessor_Load(object sender, EventArgs e)
        {

        }

       
    }
}
