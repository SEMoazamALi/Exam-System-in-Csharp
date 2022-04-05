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
    public partial class Result_Card : Form
    {
       
        public String conString = "Data Source=DESKTOP-FT1PQSN\\SQLEXPRESS;Initial Catalog=ONLINEEXAMSYSTEM;Integrated Security=True";
        SqlConnection con;
        int S;
        public Result_Card()
        {
            InitializeComponent();
        }

        public Result_Card(string user, string takeExam, int count)
        {
            int totalQ=0;
            int Wrong, Totalmark, Omark;
        double per=0;
            con = new SqlConnection(conString);
            con.Open();
            String query = "SELECT * FROM COURSES WHERE COURSE_NAME='" + takeExam + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader DR1 = cmd.ExecuteReader();
            if (DR1.Read())
            {

                totalQ = DR1.GetInt32(1);
                S = DR1.GetInt32(2);

            }
            DR1.Close();
            Wrong = totalQ - count;
            Totalmark = S *totalQ;
            Omark = S * count;
            string message = "user " + user + "\n" + "take exam " + takeExam+"\n"+"wrong "+Wrong+"\n"+"totalmarks " +Totalmark+"\n" +"omarks "+Omark;
            string title = "Result";
            MessageBox.Show(message, title);
            con.Close();
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    query = "INSERT INTO RESULT(USERNAME,TOTAL_QUESTION,WRONG_QUESTION,OBTAINES_MARKS,TOTALMARK,PERCENTAGE,COURSE) VALUES ('" + user + "','" + totalQ + "','" + Wrong + "','" + Omark + "','" + Totalmark + "','" + per + "', '" + takeExam + "')";
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Save");
                }catch(Exception ar)
                {
                    Console.WriteLine(ar);
                }
            }
            
        }


        private void Result_Card_Load(object sender, EventArgs e)
        {

        }

     

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
