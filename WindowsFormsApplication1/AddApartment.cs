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
    public partial class AddApartment : Form
    {
        public AddApartment()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
        bool status=false; 
        private void button1_Click(object sender, EventArgs e)
        {
            ApartmentClass a = new ApartmentClass(textNo.Text, textName.Text, status, comboBox1.Text, comboBox2.Text, textDes.Text, textLoc.Text,textBox1.Text);
            a.InsertApartmentToDb();
            status = true;
            var myForm = new Lessor();
            myForm.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new Lessor();
            myForm.Show();
            this.Hide();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        
    }
}
