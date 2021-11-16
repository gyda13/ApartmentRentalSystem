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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        
        

    

        DataClasses1DataContext db1 = new DataClasses1DataContext();
       
        private void button1_Click(object sender, EventArgs e)
        {



            if (textBox1.Text == null || textBox2.Text == null || textBox3.Text == null ||
                 textBox4.Text == null || textBox5.Text == null || radioButton1.Checked == false && radioButton2.Checked == false)
                MessageBox.Show("Please complete your information");

               
            else
            {
                if (Isvalid(textBox1.Text, textBox2.Text,textBox5.Text))
                {
                    MessageBox.Show("email or user name or ID is alrady exist");
                }
                else
                {
                    var t = new User();
                        t.UserID = Convert.ToString(textBox5.Text);
                        t.UserName = Convert.ToString(textBox1.Text);
                        t.UserEmail = Convert.ToString(textBox2.Text);
                        t.UserPhone = Convert.ToString(textBox3.Text);
                        t.UserPassword = Convert.ToString(textBox4.Text);
                        if (radioButton1.Checked == true)
                        {
                            t.UserType = Convert.ToString(radioButton1.Text);
                        }
                        if (radioButton2.Checked == true)
                        {
                            t.UserType = Convert.ToString(radioButton2.Text);
                        }
                        db1.Users.InsertOnSubmit(t);
                        db1.SubmitChanges();
                 

                    if (radioButton1.Checked == true)
                    {
                       
                        var myForm = new Form3();
                        myForm.Show();
                        this.Hide();
                    }
                    if (radioButton2.Checked == true)
                    {
                       
                        var myForm = new Form4();
                        myForm.Show();
                        this.Hide();
                    }
                }
            }
            
    
        }
        private bool Isvalid(string userName, string email,string id)
        {

            var q = from row in db1.Users
                    where row.UserName == textBox1.Text
                    || row.UserEmail == textBox2.Text
                    || row.UserID == textBox5.Text
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
            var myForm = new Form2();
            myForm.Show();

            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '*';

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
