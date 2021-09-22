using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NeoLine_Computers
{
    public partial class login_form : Form
    {
        
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private bool showPassword = false;
        MySqlConnection con;
        MD5Encryption md5 = new MD5Encryption();
        DBConnection dbConnect = new DBConnection();

        

        public login_form()
        {
            InitializeComponent();
            con = dbConnect.getConn();

        }


        private void close_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void login_form_Shown(object sender, EventArgs e)
        {
            txt_username.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_password.Text.Length>0 && txt_username.Text.Length > 0)
                {
                    string username = txt_username.Text;
                    string password = md5.getMD5(txt_password.Text);
                   
                    
                    string query = "SELECT NIC,User_Role from user WHERE Username ='" + username + "' AND Password ='" + password + "'";
                    MySqlDataReader reader;
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    reader = cmd.ExecuteReader();                    
                    string role="";
                    String nic = "";

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            nic = reader["NIC"].ToString();
                            role = reader["User_Role"].ToString();
                        }
                        UserDetails userD = new UserDetails();
                        userD.setUserName(username);
                        userD.setUserRole(role);
                        userD.setnic(nic);
                        
                        Form_Dashboard dashboard = new Form_Dashboard(userD.getnic(),userD.getUserName(), userD.getUserRole());
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        popAlert("Username or Password incorrect", Alert.enmType.Info);
                    }
                    con.Close();
                }
                else
                {
                    popAlert("Username or Password incorrect",Alert.enmType.Info);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message) ;
            }
        }

       /* public void insert()
        {
            try
            {
                string qry = "INSERT INTO user(NIC,Name,DOB,Address,User_Role,Contact_No,Email,Username,Password)" +
                    " VALUES('982890659V','Dakshina','1998-10-15','Gampaha','Admin', 0719015133,'dakshina@gmail.com','dakshina','e10adc3949ba59abbe56e057f20f883e')";
                MySqlDataReader reader;
                con.Open();
                MySqlCommand cmd = new MySqlCommand(qry, con);
                reader = cmd.ExecuteReader();
                MessageBox.Show("Save Data");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txt_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';
            }
        }

        public void popAlert(string msg, Alert.enmType type)
        {
            Alert al = new Alert();
            al.showAlert(msg,type);
        }

    }
}
