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
    public partial class MyApartment : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public MyApartment()
        {
            InitializeComponent();
            var x = db.Apartments;
            dataGridView1.DataSource = x;
        }
        private void MyApartment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apartmentRentalSystemDataSet1.Apartment' table. You can move, or remove it, as needed.
            this.apartmentTableAdapter.Fill(this.apartmentRentalSystemDataSet1.Apartment);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from id in db.Apartments
                                        where id.UserID == textBox1.Text
                                        select id).ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
               
            var myForm = new Lessor();
            myForm.Show();
            this.Hide();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        
       
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
