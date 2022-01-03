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
    public partial class DashboardControl : UserControl
    {
        MySqlConnection con;
        DBConnection dbConnect = new DBConnection();
        ToolTip toolTip = new ToolTip();

        public DashboardControl()
        {
            InitializeComponent();
            con = dbConnect.getConn();
            showChart();
        }


        public void showChart()
        {
            try
            {
                string query = "SELECT c.Name, SUM((i.Selling_Price * i.Qty)-i.Discount) as total FROM invoice as i " +
                    "INNER JOIN item as it ON i.Item_ID=it.Item_ID INNER JOIN category as c ON it.Category_ID = c.Category_ID " +
                    "WHERE i.Date >= DATE(NOW()) - INTERVAL 6 DAY GROUP BY c.Category_ID";
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                reader = cmd.ExecuteReader();
                chart_7dayPieChart.Series["s1"].Points.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        chart_7dayPieChart.Series["s1"].Points.AddXY(reader["Name"], reader["total"]);
                    }                    
                }
                con.Close();

                string query1 = "SELECT i.Date, SUM((i.Selling_Price * i.Qty)-i.Discount) as total FROM invoice as i " +
                    "WHERE i.Date >= DATE(NOW()) - INTERVAL 6 DAY GROUP BY i.Date ORDER BY i.Date asc; ";
                MySqlDataReader reader1;
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                con.Open();
                reader1 = cmd1.ExecuteReader();
                chart_7dayColumn.Series["Sales"].Points.Clear();
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        chart_7dayColumn.Series["Sales"].Points.AddXY(reader1["Date"], reader1["total"]);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_refreshCharts_MouseHover(object sender, EventArgs e)
        {
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btn_refreshCharts, "Refresh Charts ");
        }

        private void btn_refreshCharts_Click(object sender, EventArgs e)
        {
            showChart();
        }
    }
}
