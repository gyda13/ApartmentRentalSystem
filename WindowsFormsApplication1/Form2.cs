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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textPass.PasswordChar = '*';
        }
        DataClasses1DataContext db2 = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {         
                if (IsvalidUser(textName.Text, textPass.Text))
                {
                    var q = (from row in db2.Users.ToList()
                             where textName.Text == row.UserName
                             select row.UserType).ToList();
                    foreach (var elemnt in q)
                    {
                        if (elemnt == "Renter")
                        {
                            var myForm = new Renter();
                            myForm.Show();
                            this.Hide();
                        }
                        if (elemnt == "Lessor")
                        {
                            var myForm = new Lessor();
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
                    where row.UserName == textName.Text
                    && row.UserPassword == textPass.Text
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
            var myForm = new SignUp();
            myForm.Show();

            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }





    }

}
 