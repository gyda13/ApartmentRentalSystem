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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db5 = new DataClasses1DataContext();
        private void button3_Click(object sender, EventArgs e)
        {

            
            var q = (from row in db5.Users.ToList()
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
            
            var q = (from row in db5.Users.ToList()
                     where textBox2.Text == row.UserID
                     select row).ToList();
            foreach (var elemnt in q)
            {
                elemnt.UserName = Nametext.Text;
                elemnt.UserEmail = Emailtext.Text;
                elemnt.UserPhone = Phonetext.Text;
                elemnt.UserPassword = Passtext.Text;
                elemnt.UserType = Typetext.Text;
                db5.SubmitChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new Form3();
            myForm.Show();

            this.Hide();
        }
    }
}
