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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void button3_Click(object sender, EventArgs e)
        {        
            var q = (from row in db.Users.ToList()
                     where textBox2.Text == row.UserID
                     select row).ToList();
            foreach (var elemnt in q)
            {
                Nametext.Text = elemnt.UserName;
                Emailtext.Text = elemnt.UserEmail;
                Phonetext.Text = elemnt.UserPhone;
                Passtext.Text = elemnt.UserPassword;
                Typetext.Text = elemnt.UserType;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {     
            var q = (from row in db.Users.ToList()
                     where textBox2.Text == row.UserID
                     select row).ToList();
            foreach (var elemnt in q)
            {
                elemnt.UserName = Nametext.Text;
                elemnt.UserEmail = Emailtext.Text;
                elemnt.UserPhone = Phonetext.Text;
                elemnt.UserPassword = Passtext.Text;
                elemnt.UserType = Typetext.Text;
                db.SubmitChanges();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (Typetext.Text == "Renter")
            {
                var myForm = new Renter();
                myForm.Show();
            }
            if (Typetext.Text == "Lessor")
            {
                var myForm = new Lessor();
                myForm.Show();
            }
            this.Hide();
        }
    }
}
