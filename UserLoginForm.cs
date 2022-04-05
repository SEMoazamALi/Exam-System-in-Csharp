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
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void jImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectLogin st = new SelectLogin();
            st.Show();
        }

        private void jFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm rg = new RegistrationForm();
            rg.Show();
        }

        public String conString = "Data Source=DESKTOP-FT1PQSN\\SQLEXPRESS;Initial Catalog=ONLINEEXAMSYSTEM;Integrated Security=True";

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            String user = jMaterialTextbox1.TextName.ToString();
            String pas = jMaterialTextbox2.TextName.ToString();
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                String query = "SELECT * FROM USERDETAILS WHERE USERNAME='"+user+"' and PASWORD='"+pas+"'";
                SqlDataAdapter sd = new SqlDataAdapter(query, con);
                DataTable dtb = new DataTable();
                sd.Fill(dtb);
                if (dtb.Rows.Count == 1)
                {
                    this.Hide();
                    UserDashboard ud = new UserDashboard();
                    ud.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!");
                }
            }
            catch (Exception ae)
            {
                Console.WriteLine(ae);
            }

        }

        private void jMaterialTextbox2_Load(object sender, EventArgs e)
        {

        }
    }
}
