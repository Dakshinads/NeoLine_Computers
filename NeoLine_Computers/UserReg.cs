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
        public UserReg()
        {
            InitializeComponent();
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
    }
}
