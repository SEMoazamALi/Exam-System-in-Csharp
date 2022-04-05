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


    public partial class AdminDashbord : Form
    {
        public String conString = "Data Source=DESKTOP-FT1PQSN\\SQLEXPRESS;Initial Catalog=ONLINEEXAMSYSTEM;Integrated Security=True";
        SqlConnection con;
        SqlCommand cm;
        public AdminDashbord()
        {
            InitializeComponent();
            Slide.Height = btnHome.Height;
            Slide.Top = btnHome.Top;
            Home.Show();
            Home.SetBounds(153, 120, 2000, 2000);
            UserResult.Hide();
            panel4.Hide();
            ResultPanel.Hide();
            panel7.Hide();
            coursePanel.Hide();
            panel8.Hide();
            courseQues.Hide();

            fil_combo2();
            fill_combo4();
            fill_combo5();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            Slide.Height = btnHome.Height;
            Slide.Top = btnHome.Top;
            Home.Show();
            Home.SetBounds(153, 145, 2000, 2000);
            panel4.Hide();
            courseQues.Hide();
            panel7.Hide();
            ResultPanel.Hide();
            coursePanel.Hide();
            panel8.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Slide.Height = btnRexult.Height;
            Slide.Top = btnRexult.Top;
            ResultPanel.Show();
            ResultPanel.SetBounds(140, 120, 2000, 2000);
            panel7.Hide();
            Home.Hide();
            UserResult.Hide();
            panel4.Hide();
            coursePanel.Hide();
            courseQues.Hide();

            con.Close();
            con.Open();
            String query = "SELECT * FROM RESULT";
            SqlDataAdapter dp = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            dp.Fill(ds, "RESULT");
            dataGridView1.DataSource = ds.Tables["RESULT"].DefaultView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserResult.Show();
            UserResult.SetBounds(153, 120, 2000, 2000);
            Slide.Height = btnProfile.Height;
            Slide.Top = btnProfile.Top;
            Home.Hide();
            panel7.Hide();
            panel4.Hide();
            coursePanel.Hide();
            ResultPanel.Hide();
            courseQues.Hide();

           

        }

        void fill_combo5()
        {
            con = new SqlConnection(conString);
            con.Open();
            String query = "SELECT USERNAME FROM USERDETAILS";
            cm = new SqlCommand(query, con);
            SqlDataReader dt = cm.ExecuteReader();
            while (dt.Read())
            {
                String username = dt.GetString(0).ToString();
                comboBox5.Items.Add(username);
            }
            dt.Close();
        }
        void fil_combo2()
        {
            con = new SqlConnection(conString);
            con.Open();
            String query = "SELECT COURSE_NAME FROM COURSES";
            cm = new SqlCommand(query, con);
            SqlDataReader dt = cm.ExecuteReader();
            while (dt.Read())
            {
                String courseName = dt.GetString(0).ToString();
                comboBox2.Items.Add(courseName);
            }
            dt.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coursePanel.Show();
            coursePanel.SetBounds(153, 120, 2000, 2000);
            panel7.Hide();
            Slide.Height = btnCourse.Height;
            Slide.Top = btnCourse.Top;
            panel4.Hide();
            ResultPanel.Hide();
            courseQues.Hide();
            Home.Hide();



        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            Slide.Height = btnQues.Height;
            Slide.Top = btnQues.Top;
            courseQues.Show();
            courseQues.SetBounds(153, 120, 2000, 2000);
            panel4.Hide();
            Home.Hide();
            panel7.Hide();
            coursePanel.Hide();
            ResultPanel.Hide();

        }

       


        private void updPass_Click(object sender, EventArgs e)
        {

            String AD = "ADMIN";
            String pas = jMaterialTextbox1.TextName.ToString();
            String newPas = jMaterialTextbox2.TextName.ToString();
            try
            {

                con = new SqlConnection(conString);
                con.Open();
                String query = "SELECT PASWORD FROM ADMIN WHERE ADMINNAME='" + AD + "'";
                cm = new SqlCommand(query, con);
                SqlDataReader DR2 = cm.ExecuteReader();
                if (DR2.Read())
                {
                    jMaterialTextbox1.TextName = DR2.GetString(0);

                    if (pas != newPas)
                    {
                        DR2.Close();
                        try
                        {
                            String Updatequery = "UPDATE ADMIN SET PASWORD='" + newPas + "' WHERE ADMINNAME='" + AD + "'";
                            cm = new SqlCommand(Updatequery, con);
                            cm.CommandType = CommandType.Text;
                            cm.ExecuteNonQuery();
                            MessageBox.Show("Password change!");

                        }


                        catch (Exception aee)
                        {
                            Console.WriteLine(aee);
                        }

                    }

                    else
                    {
                        MessageBox.Show("cannot enter previous password");
                    }
                    con.Close();
                }
            }
            catch (Exception ae)
            {
                Console.WriteLine(ae);
            }
        }

       

        private void jThinButton4_Click(object sender, EventArgs e)
        {
            panel4.Show();
            coursePanel.Show();
            ResultPanel.Hide();
            courseQues.Hide();
            Home.Hide();
            panel7.Hide();


        }

        private void jThinButton5_Click(object sender, EventArgs e)
        {
            con.Close();
            String Cid = jMaterialTextbox12.TextName.ToString();
            String CName = jMaterialTextbox13.TextName.ToString();
            int TMArk = Convert.ToInt32(this.jMaterialTextbox14.TextName);
            int QMARK = Convert.ToInt32(this.jMaterialTextbox15.TextName);

            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {

                    String query = "INSERT INTO COURSES(COURSE_NAME,TOTAL_QUESTION,QUESTION_MARKS,COURSE_ID) VALUES ('" + CName + "','" + TMArk + "','" + QMARK + "','" + Cid + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully!");
                }
            }
            catch (Exception ae)
            {
                Console.WriteLine(ae);
            }
        }

        

        public String selectcOURSE;
        private void jThinButton1_Click(object sender, EventArgs e)
        {

            panel7.Show();
            coursePanel.Show();
            panel4.Show();
            ResultPanel.Hide();
            courseQues.Hide();
            Home.Hide();


            if (comboBox2.SelectedIndex >= 0)
            {
                selectcOURSE = comboBox2.SelectedItem.ToString();
                String query2 = "SELECT * FROM COURSES WHERE COURSE_NAME='" + selectcOURSE + "'";
                SqlCommand cmd = new SqlCommand(query2, con);
                SqlDataReader DR1 = cmd.ExecuteReader();
                if (DR1.Read())
                {

                    jMaterialTextbox19.TextName = DR1.GetString(3);
                    jMaterialTextbox18.TextName = DR1.GetString(0);
                    jMaterialTextbox17.TextName = DR1.GetInt32(1).ToString();
                    jMaterialTextbox16.TextName = DR1.GetInt32(2).ToString();


                }
                DR1.Close();
            }
        }

       

      

        void fill_combo4()
        {
            con = new SqlConnection(conString);
            con.Open();
            String query = "SELECT COURSE_ID FROM COURSES";
            cm = new SqlCommand(query, con);
            SqlDataReader dt = cm.ExecuteReader();
            while (dt.Read())
            {
                String courseId = dt.GetString(0).ToString();
                comboBox4.Items.Add(courseId);
            }
            dt.Close();
        }

        String CID;
        private void jThinButton8_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            if (comboBox4.SelectedIndex >= 0)
            {
                con.Open();
                String Qno = textBox7.Text.ToString();
                String QSt = textBox1.Text.ToString();
                String op1 = textBox2.Text.ToString();
                String op2 = textBox3.Text.ToString();
                String op3 = textBox4.Text.ToString();
                String op4 = textBox5.Text.ToString();
                String corr = textBox6.Text.ToString();
                String ids = CID;
                

                if (con.State == System.Data.ConnectionState.Open)
                {
                    try
                    {
                        String query2 = "INSERT INTO QUESTIONS(Q_ID,Q_STATEMENT,OP_1,OP_2,OP_3,OP_4,CORRECT_OP,COURSE_ID) VALUES('" + Qno + "','" + QSt + "','" + op1 + "','" + op2 + "','" + op3 + "','" + op4 + "','" + corr + "','" + ids + "')";
                        cm = new SqlCommand(query2, con);
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Add Question Successfully!");
                    }catch(Exception ad)
                    {
                        MessageBox.Show("Question Number is also exist");
                        Console.WriteLine(ad);
                    }

                }
            }
        }

       
        String ID;
        int i = 1;
        private void jThinButton7_Click(object sender, EventArgs e)
        {
            try
            {
                this.i = 1;
                CID = comboBox4.SelectedItem.ToString();
                MessageBox.Show("Course Selected");
                ExamStart(1);
            } catch(Exception aee)
            {

            }
        }

            void ExamStart(int x)
        {
           
            con.Close();
            con.Open();
            String query = "SELECT * FROM Questions WHERE Q_ID='" + CID + x + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader DR1 = cmd.ExecuteReader();
            if (DR1.Read())
            {
                comboBox3.Text= DR1.GetString(0);
                textBox8.Text = DR1.GetString(1);
                textBox9.Text = DR1.GetString(2);
                textBox10.Text = DR1.GetString(3);
                textBox11.Text = DR1.GetString(4);
                textBox12.Text = DR1.GetString(5);
                textBox13.Text = DR1.GetString(6);

            }
            DR1.Close();
        }

        private void jThinButton11_Click(object sender, EventArgs e)
        {
            ++this.i;
            ExamStart(i);
        }

        private void jThinButton9_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            String qno = comboBox3.Text.ToString();
            String qstmt = textBox8.Text.ToString();
            String op1 = textBox9.Text.ToString();
            String op2 = textBox10.Text.ToString();
            String op3 = textBox11.Text.ToString();
            String op4 = textBox12.Text.ToString();
            String corr = textBox13.Text.ToString();

            try
            {
                String Updatequery = "UPDATE USERDETAILS SET Q_ID='" + qno + "',Q_SATEMENT='" + qstmt + "',OP_1='" + op1 + "',OP_2='" + op2 + "',OP_3='" + op3 + "',OP_4='" + op4 + "',CORRECR_OP='" + corr + "' WHERE COURSE_ID='" + ID+i+ "'";
                SqlCommand cm = new SqlCommand(Updatequery, con);
                cm.CommandType = CommandType.Text;
                cm.ExecuteNonQuery();
                MessageBox.Show("Data Updated");

            }
            catch (Exception ae)
            {
                Console.WriteLine(ae);
            }
        }

        private void jThinButton10_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            String delquery = "DELETE QUESTIONS WHERE COURSE_ID='" + ID+i+ "'";
            cm = new SqlCommand(delquery, con);
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            MessageBox.Show("QUESTION Deleted!");

            con.Close();
        }

        

        private void jThinButton13_Click_1(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            String delquery = "DELETE COURSES WHERE COURSE_NAME='" + selectcOURSE + "'";
            cm = new SqlCommand(delquery, con);
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            MessageBox.Show("Course Deleted!");

            con.Close();
        }

        private void jThinButton12_Click_1(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            String Cid = jMaterialTextbox19.TextName.ToString();
            String CName = jMaterialTextbox18.TextName.ToString();
            int TMArk = Convert.ToInt32(this.jMaterialTextbox17.TextName);
            int QMARK = Convert.ToInt32(this.jMaterialTextbox16.TextName);

            String updquerr = "UPDATE COURSES SET COURSENAME='" + CName + "',TOTAL_QUESTION='" + TMArk + "', QUESTION_MARKS='" + QMARK + "',COURSE_ID='" + Cid + "' WHERE COURSE_NAME='" + selectcOURSE + "'";
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            MessageBox.Show("Course Updated");
        }

 
        private void jThinButton14_Click(object sender, EventArgs e)
        {

            String select = comboBox3.SelectedItem.ToString();
            String query2 = "SELECT * FROM QUESTIONS WHERE Q_ID='" + select + "'";
            SqlCommand cmd = new SqlCommand(query2, con);
            SqlDataReader DR1 = cmd.ExecuteReader();
            if (DR1.Read())
            {
                textBox8.Text= DR1.GetString(1); ;
                 textBox9.Text = DR1.GetString(2); ;
               textBox10.Text= DR1.GetString(3); ;
               textBox11.Text = DR1.GetString(4);
                textBox12.Text = DR1.GetString(5);
                textBox13.Text = DR1.GetString(6);
              


            }
            DR1.Close();
        }

        

        private void ovalShape2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashbord ad = new AdminDashbord();
            ad.Show();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex >= 0)
            {
                String select = comboBox5.SelectedItem.ToString();
                String query2 = "SELECT * FROM USERDETAILS WHERE USERNAME='" + select + "'";
                SqlCommand cmd = new SqlCommand(query2, con);
                SqlDataReader DR1 = cmd.ExecuteReader();
                if (DR1.Read())
                {

                    jMaterialTextbox28.TextName = DR1.GetString(2);
                    jMaterialTextbox27.TextName = DR1.GetString(3);
                    jMaterialTextbox26.TextName = DR1.GetString(4);
                    jMaterialTextbox25.TextName = DR1.GetString(0);
                    jMaterialTextbox24.TextName = DR1.GetString(1);
                    jMaterialTextbox23.TextName = DR1.GetString(5);
                    jMaterialTextbox22.TextName = DR1.GetDateTime(6).ToString();
                    jMaterialTextbox21.TextName = DR1.GetString(7);
                    jMaterialTextbox20.TextName = DR1.GetString(8);


                }
                DR1.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectLogin lg = new SelectLogin();
            lg.Show();
        }
    }
}