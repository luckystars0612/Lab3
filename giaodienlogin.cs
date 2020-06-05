using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Lập_trình_mạng___Lab3
{
    public partial class giaodienlogin : Form
    {
        public giaodienlogin()
        {
            InitializeComponent();
        }

        private void signup_bt_Click(object sender, EventArgs e)
        {
            signup su = new signup();
            su.Show();
            this.Hide();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F5RQISV\SQLEXPRESS;Initial Catalog=information;Integrated Security=True");
        private void login_bt_Click(object sender, EventArgs e)
        {
            string user = username_tb.Text;
            string pass = password_tb.Text;
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from thongtindangnhap where username='" + username_tb.Text + "'and password='" + password_tb.Text+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {
                MessageBox.Show("Login successfully, connecting to roomchat....");
                giaodien_roomchat n = new giaodien_roomchat();
                n.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
            con.Close();
        }
    }
}
