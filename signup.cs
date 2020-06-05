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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F5RQISV\SQLEXPRESS;Initial Catalog=information;Integrated Security=True");

        private void signup_bt_Click(object sender, EventArgs e)
        {
            con.Open();
            if(con.State==System.Data.ConnectionState.Open)
            {
                SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from thongtindangnhap where username='" + username_tb.Text + "'", con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("The username has already existed , connecting to roomchat....");
                    giaodien_roomchat n = new giaodien_roomchat();
                    n.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO thongtindangnhap(username,password,firstname,lastname,email)values('" + username_tb.Text + "','" + password_tb.Text + "','" + firstname_tb.Text + "','" + lastname_tb.Text + "','" + phonenb_tb.Text + "')", con);
                sda.SelectCommand.ExecuteNonQuery();
                
                con.Close();
                MessageBox.Show("Signing in successfully, connecting roomchat......");
                giaodien_roomchat gdrc = new giaodien_roomchat();
                gdrc.Show();
                this.Hide();
                con.Close();
            }
        }
    }
}
