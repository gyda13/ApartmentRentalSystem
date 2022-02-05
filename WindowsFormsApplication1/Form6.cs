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
    public partial class RentAp : Form
    {
        public RentAp()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void RentAp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apartmentRentalSystemDataSet4.Apartment' table. You can move, or remove it, as needed.
            this.apartmentTableAdapter1.Fill(this.apartmentRentalSystemDataSet4.Apartment);
            var x = db.Apartments;
            dataGridView1.DataSource = x;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            // TODO: This line of code loads data into the 'apartmentRentalSystemDataSet3.Apartment' table. You can move, or remove it, as needed.
            this.apartmentTableAdapter.Fill(this.apartmentRentalSystemDataSet3.Apartment);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox1.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = (from c in db.Apartments
                                                where c.Category.ToLower().StartsWith("FlatSharing")
                                                select c).ToList();
                    break;
                case 1:
                    dataGridView1.DataSource = (from c in db.Apartments
                                                where c.Category.ToLower().StartsWith("Studio")
                                                select c).ToList();
                    break;
                case 2:
                    dataGridView1.DataSource = (from c in db.Apartments
                                                where c.Category.ToLower().StartsWith("Condo")
                                                select c).ToList();
                    break;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox2.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = (from c in db.Apartments
                                                where c.Price.ToLower().StartsWith("less than 15000 yearly")
                                                select c).ToList();
                    break;
                case 1:
                    dataGridView1.DataSource = (from c in db.Apartments
                                                where c.Price.ToLower().StartsWith("15000-35000 yearly")
                                                select c).ToList();
                    break;
                case 2:
                    dataGridView1.DataSource = (from c in db.Apartments
                                                where c.Price.ToLower().StartsWith("higher than 35000 yearly")
                                                select c).ToList();
                    break;
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {


            var myForm = new Renter();
            myForm.Show();
            this.Hide();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
 
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
          

        }
    }
}
