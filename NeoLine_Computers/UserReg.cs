using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeoLine_Computers
{
    public partial class UserReg : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private int type;
        MySqlConnection con;
        MD5Encryption md5 = new MD5Encryption();
        DBConnection dbConnect = new DBConnection();

        // type 1 = save,  type 2 = update, type 3 =update user
        public UserReg( int type)
        {
            InitializeComponent();
            cmb_userrole.SelectedIndex = 0;
            txt_nic.Focus();
            con = dbConnect.getConn();

            if (type==1)
            {
                lbl_formname.Text = "User Registration";
                btn_action.Text = "Save";
                this.type = type;
            }

        }

        public UserReg(int type,string nic, string name,string dob, string address,string userrole, int contactno,string email, string username)
        {
            InitializeComponent();
            con = dbConnect.getConn();
            lbl_formname.Text = "Update Details";
            btn_action.Text = "Update";
            this.type = type;

            txt_nic.Text = nic;
            txt_nic.Enabled = false;
            txt_name.Text = name;
            date_dob.Text = dob;
            txt_address.Text = address;
            cmb_userrole.SelectedItem = userrole;            
            txt_contact_no.Text = contactno.ToString();
            txt_email.Text = email;
            txt_username.Text = username;
            if (type == 3)
            {
                cmb_userrole.Enabled = false;
            }
            else
            {
                cmb_userrole.Enabled = true;
            }
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void popAlert(string msg, Alert.enmType type)
        {
            Alert al = new Alert();
            al.showAlert(msg, type);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void btn_action_Click(object sender, EventArgs e)
        {
            string nic,userrole,name,dob,address,email,username, password;
            int contactno;
            try
            {
                if (txt_password.Text == txt_confirmPassword.Text && txt_password.Text.Length > 0)
                {
                    password = txt_password.Text;
                    if (txt_nic.Text.Length > 0 && txt_name.Text.Length > 0 && txt_address.Text.Length > 0 && txt_email.Text.Length > 0 && txt_contact_no.Text.Length > 0 && txt_username.Text.Length>0)
                    {
                        nic = txt_nic.Text;
                        name = txt_name.Text;
                        address = txt_address.Text;
                        email = txt_email.Text;
                        int ignorme;
                        userrole = cmb_userrole.SelectedItem.ToString();
                        username = txt_username.Text;
                        dob = date_dob.Text;
                        if(int.TryParse(txt_contact_no.Text,out ignorme))
                        {
                            contactno = Convert.ToInt32(txt_contact_no.Text);
                            if (this.type == 1)
                            {
                                insert(nic, name, dob, userrole, address, contactno, email, username, password);
                            }
                            else if(this.type == 2 || this.type == 3)
                            {
                                update(nic, name, dob, userrole, address, contactno, email, username, password);
                            }

                        }
                        else
                        {
                            popAlert("Entered Contact no is invlalid",Alert.enmType.Info);
                        }

                    }
                    else
                    {
                        popAlert("Entered values are invalid ", Alert.enmType.Info);
                    }
                }
                else
                {
                    popAlert("Please enter same password", Alert.enmType.Info);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insert(string nic, string name, string dob, string userrole, string address, int contactno, string email, string username, string password )
        {
            password = md5.getMD5(password);
            try
            {
                string qry = "INSERT INTO user(NIC,Name,DOB,Address,User_Role,Contact_No,Email,Username,Password)" +
                    " VALUES('"+nic+ "','" + name + "','" + dob + "','" + address + "','" + userrole + "', "+contactno+ ",'" + email + "','" + username + "','" + password + "')";
                MySqlDataReader reader;
                con.Open();
                MySqlCommand cmd = new MySqlCommand(qry, con);
                reader = cmd.ExecuteReader();
                popAlert("Successully saved", Alert.enmType.Success);           
                con.Close();
                this.Hide();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update(string nic, string name, string dob, string userrole, string address, int contactno, string email, string username, string password)
        {
            password = md5.getMD5(password);
            try
            {
                string qry = "UPDATE user SET Name='" + name + "',DOB='" + dob + "',Address='" + address + "',User_Role='" + userrole + "',Contact_No=" + contactno + ",Email='" + email + "',Username='" + username + "',Password='" + password + "' WHERE NIC='"+nic+"'";
                MySqlDataReader reader;
                con.Open();
                MySqlCommand cmd = new MySqlCommand(qry, con);
                reader = cmd.ExecuteReader();
                popAlert("Successully updated", Alert.enmType.Update);
                con.Close();
                UsersControl usc = new UsersControl();
                usc.refreshGrid();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
