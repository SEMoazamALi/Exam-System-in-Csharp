using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamSystem
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void jImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLoginForm us = new UserLoginForm();
            us.Show();

        }

        public String conString ="Data Source=DESKTOP-FT1PQSN\\SQLEXPRESS;Initial Catalog=ONLINEEXAMSYSTEM;Integrated Security=True";

        private void jThinButton2_Click(object sender, EventArgs e){

           
            String FName = jMetroTextBox1.TextName.ToString();
            String MName = jMetroTextBox2.TextName.ToString();
            String LName = jMetroTextBox3.TextName.ToString();
            String UserName = jMetroTextBox4.TextName.ToString();
            String pass = jMetroTextBox5.TextName.ToString();
            String email = jMetroTextBox6.TextName.ToString();
            String dob = jMetroTextBox7.TextName.ToString();
            String spec = jMetroTextBox8.TextName.ToString();
            String country = jMetroTextBox9.TextName.ToString();

            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {

                    String query = "INSERT INTO USERDETAILS(USERNAME,PASWORD, F_NAME,M_NAME,L_NAME,EMAIL,DOB,SPECIALIZATION,COUNTRY) VALUES ('"+UserName+ "','" + pass + "','" + FName + "','" + MName + "','" + LName + "','" + email + "','" + dob + "','" + spec + "','" + country + "')";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Successfully!");
                }
            } catch(Exception ae)
            {
                Console.WriteLine(ae);
            }



        }
}
}
