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
    public partial class SignUp : Form 
    {
        public SignUp()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            UserClass us;
            if (textName.Text == null || textEmail.Text == null || textPhone.Text == null ||
                textPass.Text == null || textId.Text == null || radioButton1.Checked == false && radioButton2.Checked == false)
                MessageBox.Show("Please complete your information");
            
             
             else{
                 us = new UserClass("", "", "", "", "", "");
                 if (us.Isvalid(textName.Text, textEmail.Text, textId.Text))
                 {
                     MessageBox.Show("email or user name or ID is alrady exist");
                 }
                 else
                 {

                     string type = "";
                     if (radioButton1.Checked == true)
                     {
                         type = radioButton1.Text;
                         us = new UserClass(textId.Text, textName.Text, textEmail.Text, textPhone.Text, type, textPass.Text);
                         us.InsertUserToDb();
                         var myForm = new Renter();
                         myForm.Show();
                         this.Hide();
                     }
                     if (radioButton2.Checked == true)
                     {
                         type = radioButton2.Text;
                         us = new UserClass(textId.Text, textName.Text, textEmail.Text, textPhone.Text, type, textPass.Text);
                         us.InsertUserToDb();
                         var myForm = new Lessor();
                         myForm.Show();
                         this.Hide();
                     }

                 }
                    
                 
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new SignIn();
            myForm.Show();

            this.Hide();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textPass.PasswordChar = '*';

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
       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
