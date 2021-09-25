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
    public partial class Form_Invoice : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        MySqlConnection con;
        DBConnection dbConnect = new DBConnection();

        public Form_Invoice(int invoiceNo)
        {
            InitializeComponent();
            con = dbConnect.getConn();
            //showDetails(invoiceNo);
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
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


        private void showDetails(int invoiceNo)
        {
            try
            {
                int grnno = 0;
                string query = "SELECT GRN_ID FROM grn ORDER BY GRN_ID DESC LIMIT 1 ";
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        grnno = Convert.ToInt32(reader["GRN_ID"]);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
