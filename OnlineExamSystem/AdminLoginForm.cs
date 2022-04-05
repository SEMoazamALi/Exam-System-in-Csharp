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
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void jImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectLogin st = new SelectLogin();
            st.Show();
        }


      public  String conString = "Data Source=DESKTOP-FT1PQSN\\SQLEXPRESS;Initial Catalog=ONLINEEXAMSYSTEM;Integrated Security=True";


        private void jThinButton1_Click(object sender, EventArgs e)
        {

            String username = jMaterialTextbox1.TextName.ToString();
            String passw = jMaterialTextbox2.TextName.ToString();
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String query = "SELECT * FROM ADMIN WHERE ADMINNAME='" + username + "'and PASWORD='" + passw + "'";
                SqlDataAdapter sad = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sad.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    AdminDashbord ad = new AdminDashbord();
                    ad.Show();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }

        
    }
}
