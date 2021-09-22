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
    public partial class Form_AdminPanel : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        ToolTip toolTip = new ToolTip();
        public Form_AdminPanel()
        {
            InitializeComponent();
            pnl_active.Height = btn_users.Height;
            pnl_active.Top = btn_users.Top;
            usersControl1.BringToFront();
        }

        public void popAlert(string msg, Alert.enmType type)
        {
            Alert al = new Alert();
            al.showAlert(msg, type);
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
            toolTip.SetToolTip(btn_close, "Close");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            pnl_active.Height = btn_users.Height;
            pnl_active.Top = btn_users.Top;
            usersControl1.BringToFront();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Tables_Click(object sender, EventArgs e)
        {
            pnl_active.Height = btn_Tables.Height;
            pnl_active.Top = btn_Tables.Top;
            tableControl1.BringToFront();
        }
    }
}
