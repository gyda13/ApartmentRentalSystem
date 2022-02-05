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
    public partial class YourRequest : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public YourRequest()
        {
            InitializeComponent();
            var x = db.Requests;
            dataGridView1.DataSource = x;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from id in db.Requests
                                        where id.UserID == textBox1.Text
                                        select id).ToList();
            var s = new Request();
            if (radioButton1.Checked) {
                s.RequestStatus = true;
            }
            if (radioButton2.Checked)
            {
                s.RequestStatus = false;
            }
        }
        private void YourRequest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apartmentRentalSystemDataSet7.Request' table. You can move, or remove it, as needed.
            this.requestTableAdapter1.Fill(this.apartmentRentalSystemDataSet7.Request);
            // TODO: This line of code loads data into the 'apartmentRentalSystemDataSet6.Request' table. You can move, or remove it, as needed.
            this.requestTableAdapter.Fill(this.apartmentRentalSystemDataSet6.Request);

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
