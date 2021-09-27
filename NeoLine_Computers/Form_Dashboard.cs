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
    public partial class Form_Dashboard : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        string username;
        string userrole;
        string nic;

        MySqlConnection con;
        DBConnection dbConnect = new DBConnection();

        ToolTip toolTip = new ToolTip();
        

        public Form_Dashboard(string nic, string userName, string userRole)
        {
            InitializeComponent();
            con = dbConnect.getConn();
            this.username = userName;
            this.userrole = userRole;
            this.nic = nic;
            lbl_welcome.Text = "Welcome "+username  ;
            popAlert("Welcome " + userName, Alert.enmType.Success);
            btn_profileSetting.Location = new Point(lbl_welcome.Location.X+lbl_welcome.Width,6);
            pnl_active.Height = btn_dashboard.Height;
            pnl_active.Top = btn_dashboard.Top;
            dashboardControl1.BringToFront();

        }

        public void popAlert(string msg, Alert.enmType type)
        {
            Alert al = new Alert();
            al.showAlert(msg, type);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmationPopup confirm = new ConfirmationPopup("Do you want to Logout ?");
            DialogResult dr=confirm.ShowDialog();
            if(dr== DialogResult.Yes)
            {
                login_form log = new login_form();
                log.Show();
                this.Close();
            }
            confirm.Dispose();
            
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

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {

        }        

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_minimize_MouseHover(object sender, EventArgs e)
        {
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btn_minimize, "Minimize");
        }


        private void btn_close_MouseHover(object sender, EventArgs e)
        {
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btn_close, "Log out");
        }

        private void btn_profileSetting_MouseHover(object sender, EventArgs e)
        {
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btn_profileSetting, "Profile Setting");
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            pnl_active.Height = btn_dashboard.Height;
            pnl_active.Top = btn_dashboard.Top;
            dashboardControl1.BringToFront();
            dashboardControl1.showChart();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            pnl_active.Height = btn_stock.Height;
            pnl_active.Top = btn_stock.Top;
            stockControl1.BringToFront();
            stockControl1.refreshGrid();
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            pnl_active.Height = btn_bill.Height;
            pnl_active.Top = btn_bill.Top;
            billControl1.BringToFront();
        }

        private void btn_warrantyChecker_Click(object sender, EventArgs e)
        {
            pnl_active.Height = btn_warrantyChecker.Height;
            pnl_active.Top = btn_warrantyChecker.Top;
            warrantyCheckerControl1.BringToFront();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            if(userrole =="Admin" || userrole == "Manager")
            {
                pnl_active.Height = btn_report.Height;
                pnl_active.Top = btn_report.Top;
                reporControl1.BringToFront();
            }
            else
            {
                popAlert("You cannot access to the report", Alert.enmType.Delete);
            }
           
        }

        private void btn_adminPanel_Click(object sender, EventArgs e)
        {
            if (userrole == "Admin")
            {
                Form_AdminPanel adp = new Form_AdminPanel();
                adp.Show();
            }
            else
            {
                popAlert("You cannot access to admin panel", Alert.enmType.Delete);
            }           
        }

        public void btn_profileSetting_Click(object sender, EventArgs e)
        {
            try{
                string query = "SELECT * from user WHERE nic='"+ this.nic + "'";
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                reader = cmd.ExecuteReader();

                String nic="", name = "", dob = "", address = "", userrole = "", email = "", username = "";
                int contactno=0;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        nic = reader["NIC"].ToString();
                        name = reader["Name"].ToString();
                        dob = reader["DOB"].ToString();
                        address = reader["Address"].ToString();
                        userrole = reader["User_Role"].ToString();
                        contactno = Convert.ToInt32(reader["Contact_No"]);
                        email = reader["Email"].ToString();
                        username = reader["Username"].ToString();

                    }
                    con.Close();
                    UserReg userg = new UserReg(3, nic, name, dob, address, userrole, contactno, email, username);
                    userg.Show();
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
