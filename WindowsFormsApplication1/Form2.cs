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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        DataClasses1DataContext db2 = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {


          
                if (IsvalidUser(textBox1.Text, textBox2.Text))
                {
                    var q = (from row in db2.Users.ToList()
                             where textBox1.Text == row.UserName
                             select row.UserType).ToList();
                    foreach (var elemnt in q)
                    {
                        if (elemnt == "Renter")
                        {
                            var myForm = new Form3();
                            myForm.Show();
                            this.Hide();
                        }
                        if (elemnt == "Lessor")
                        {
                            var myForm = new Form4();
                            myForm.Show();
                            this.Hide();
                        }
                    }

                }

                else
                    MessageBox.Show("Invalid username or password");
            

        }
        private bool IsvalidUser(string userName, string password)
        {
           
            var q = from row in db2.Users
                    where row.UserName == textBox1.Text
                    && row.UserPassword == textBox2.Text
                    select row;

            if (q.Any())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new Form1();
            myForm.Show();

            this.Hide();
        }





    }

}
 