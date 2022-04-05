using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExamSystem
{
    public partial class UserDashboard : Form
        
    {
        public String conString = "Data Source=DESKTOP-FT1PQSN\\SQLEXPRESS;Initial Catalog=ONLINEEXAMSYSTEM;Integrated Security=True";
        SqlConnection con;
        String user;
        public UserDashboard(string user)
        {

            this.user = user;
            
            InitializeComponent();
            Slide.Height = button5.Height;
            Slide.Top = button5.Top;
            panel4.Hide();
            panel3.Hide();
            
            panel6.Hide();
            panel7.Hide();
            panel2.Hide();
            panel5.Hide();
            label14.Text = user;
            fill_comboExam();

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Slide.Height = button1.Height;
            Slide.Top = button1.Top;
            panel3.Show();
            panel4.Hide();
            panel7.Hide();
            panel2.Hide();
            panel5.Hide();
            panel6.Hide();

            con = new SqlConnection(conString);
            con.Open();
            String query = "SELECT * FROM USERDETAILS WHERE USERNAME='"+user+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader DR1 = cmd.ExecuteReader();
            if (DR1.Read())
            {
                
                jMaterialTextbox1.TextName = DR1.GetString(2);
                jMaterialTextbox2.TextName = DR1.GetString(3);
                jMaterialTextbox3.TextName = DR1.GetString(4);
                jMaterialTextbox4.TextName = DR1.GetString(0);
                jMaterialTextbox5.TextName = DR1.GetString(1);
                jMaterialTextbox6.TextName = DR1.GetString(5);
                jMaterialTextbox7.TextName = DR1.GetDateTime(6).ToString();
                jMaterialTextbox8.TextName = DR1.GetString(7);
                jMaterialTextbox9.TextName = DR1.GetString(8);
                

            }
            DR1.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Slide.Height = button3.Height;
            Slide.Top = button3.Top;
            panel2.Show();
            panel6.Show();
            panel3.Show();
            panel5.Hide();
            panel7.Hide();
            panel4.Hide();
            dataGridView1.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Slide.Height = button2.Height;
            Slide.Top = button2.Top;
            panel4.Show();
            panel6.Show();
            panel3.Show();
            panel2.Show();
            panel5.Hide();
            panel7.Show();

            con.Close();
            con.Open();
            String query = "SELECT * FROM RESULT WHERE USERNAME='"+user+"'";
            SqlDataAdapter dp = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            dp.Fill(ds, "RESULT");
            dataGridView1.DataSource = ds.Tables["RESULT"].DefaultView;
            dataGridView1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLoginForm us = new UserLoginForm();
            us.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectLogin st = new SelectLogin();
            st.Show();
        }

       
        int i = 1;
        String ID;
        String TakeExam;
        private void button4_Click(object sender, EventArgs e)
        {
            
            TakeExam = comboBox1.SelectedItem.ToString();
            panel2.Show();
            panel7.Show();
            panel5.Show();
            panel6.Show();
            label12.Text = TakeExam;
            String query = "SELECT COURSE_ID FROM COURSES WHERE COURSE_NAME='"+TakeExam+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader DR1 = cmd.ExecuteReader();
            if (DR1.Read())
            {
                ID = DR1.GetString(0);
            }
            DR1.Close();
            
            ExamStart(i, ID);

        }
        String corr;
        int count = 0;
        void ExamStart(int i, String id)
        {
            con.Close();
            con.Open();
            if (i == 11)
            {
                MessageBox.Show("Submitted");
                this.Hide();
                Result_Card rs = new Result_Card(user,TakeExam,count);
                rs.Show();
            }
            String query = "SELECT * FROM Questions WHERE Q_ID='"+ID+i+"'";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataReader DR1 = cmd.ExecuteReader();
            if (DR1.Read())
            {
                textBox1.Text = DR1.GetString(1);
                radioButton1.Text = DR1.GetString(2);
                radioButton2.Text = DR1.GetString(3);
                radioButton3.Text = DR1.GetString(4);
                radioButton4.Text = DR1.GetString(5);
                corr= DR1.GetString(6); ;

            }
            if (radioButton1.Checked.Equals(corr))
            {
                count += count;
            }
            if (radioButton2.Checked.Equals(corr))
            {
                count += count;
            }
            if (radioButton3.Checked.Equals(corr))
            {
                count += count;
            }
            if (radioButton4.Checked.Equals(corr))
            {
                count += count;
            }

           

            DR1.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Slide.Height = button5.Height;
            Slide.Top = button5.Top;
            panel4.Hide();
            panel3.Hide();
            panel2.Hide();
            panel7.Hide();
            panel6.Hide();
            panel5.Hide();

        }

        private void Slide_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            String fname = jMaterialTextbox1.TextName.ToString();
            String Mname = jMaterialTextbox2.TextName.ToString();
            String Lname = jMaterialTextbox3.TextName.ToString();
            String pass = jMaterialTextbox5.TextName.ToString();
            String email = jMaterialTextbox6.TextName.ToString();
            String dob = jMaterialTextbox7.TextName.ToString();
            String special = jMaterialTextbox8.TextName.ToString();
            String coun = jMaterialTextbox9.TextName.ToString();

            try
            {
                String Updatequery = "UPDATE USERDETAILS SET F_NAME='"+fname+ "',M_NAME='" + Mname + "',L_NAME='" + Lname + "',PASWORD='" + pass + "',EMAIL='" + email + "',DOB='" + dob + "',SPECIALIZATION='" + special + "',COUNTRY='" + coun + "' WHERE USERNAME='"+user+"'";
                SqlCommand cm = new SqlCommand(Updatequery, con);
                cm.CommandType = CommandType.Text;
                cm.ExecuteNonQuery();
                MessageBox.Show("Data Updated");

            }
            catch(Exception ae)
            {
                Console.WriteLine(ae);
            }
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {

        }

        

        void fill_comboExam()
        {
            con = new SqlConnection(conString);
            con.Open();
            String query = "SELECT COURSE_NAME FROM COURSES";
            SqlCommand cm = new SqlCommand(query, con);
            SqlDataReader dt = cm.ExecuteReader();
            while (dt.Read())
            {
                String courseId = dt.GetString(0).ToString();
                comboBox1.Items.Add(courseId);
            }
            dt.Close();
        }

        private void jThinButton2_Click(object sender, EventArgs e)
        {
            
            ++i;
            ExamStart(i, ID);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
