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
    public partial class Form_Dashboard : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        string username;
        string password;

        ToolTip toolTip = new ToolTip();
        

        public Form_Dashboard(string userName, string userRole)
        {
            InitializeComponent();
            this.username = userName;
            this.password = userRole;
            lbl_welcome.Text = "Welcome "+username  ;
            popAlert("Welcome " + userName, Alert.enmType.Success);
            btn_profileSetting.Location = new Point(lbl_welcome.Location.X+lbl_welcome.Width,6);
            pnl_active.Height = btn_dashboard.Height;
            pnl_active.Top = btn_dashboard.Top;
            //dashboardControl1.BringToFront();

        }

        public void popAlert(string msg, Alert.enmType type)
        {
            Alert al = new Alert();
            al.showAlert(msg, type);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login_form log = new login_form();
            log.Show();
            this.Close();
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
           // dashboardControl1.BringToFront();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            pnl_active.Height = btn_stock.Height;
            pnl_active.Top = btn_stock.Top;
          //  stockControl1.BringToFront();
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            pnl_active.Height = btn_bill.Height;
            pnl_active.Top = btn_bill.Top;
          //  billControl1.BringToFront();
        }

        private void btn_warrantyChecker_Click(object sender, EventArgs e)
        {
            pnl_active.Height = btn_warrantyChecker.Height;
            pnl_active.Top = btn_warrantyChecker.Top;
          //  warrantyCheckerControl1.BringToFront();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            pnl_active.Height = btn_report.Height;
            pnl_active.Top = btn_report.Top;
          //  reporControl1.BringToFront();
        }

        private void btn_adminPanel_Click(object sender, EventArgs e)
        {
           /* pnl_active.Height = btn_adminPanel.Height;
            pnl_active.Top = btn_adminPanel.Top;*/
            Form_AdminPanel adp = new Form_AdminPanel();
            adp.Show();
            // view admin panel
        }

    }
}
