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
    public partial class Renter : Form
    {         
        public Renter()
        {
            
            InitializeComponent();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            var myForm = new Profile();
            myForm.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new RentAp();
            myForm.Show();
            this.Hide();
        }

    
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }
        DataClasses1DataContext db3 = new DataClasses1DataContext();
        private void button3_Click(object sender, EventArgs e)
        {
           
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
