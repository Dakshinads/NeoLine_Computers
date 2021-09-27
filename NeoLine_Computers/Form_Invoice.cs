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
            showDetails(invoiceNo);
            
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
                string query = "SELECT i.Invoice_ID, i.Time, i.Date, i.Qty, i.Selling_Price, i.Warranty_Period, i.Discount, i.Type ,i.Service_description," +
                    " it.Name as iName, c.Name as cName,  c.Contact_No FROM `invoice` as i INNER JOIN customer c ON i.Customer_ID=c.Customer_ID LEFT JOIN item it ON i.Item_ID=it.Item_ID" +
                    " WHERE Invoice_ID="+invoiceNo+"";
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                reader = cmd.ExecuteReader();
                int total = 0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lbl_invoiceno.Text = reader["Invoice_ID"].ToString();
                        lbl_date.Text = reader["Date"].ToString();
                        lbl_time.Text = reader["Time"].ToString();
                        lbl_customerName.Text = reader["cName"].ToString();
                        lbl_contactNo.Text= reader["Contact_No"].ToString();

                        if (reader["Service_description"].ToString().Length<=0){
                            dgv_list.Rows.Add(
                                reader["iName"].ToString(),
                                reader["Warranty_Period"].ToString(),
                                reader["Qty"].ToString(),
                                reader["Selling_Price"].ToString(),
                                reader["Discount"].ToString(),
                                (Convert.ToInt32(reader["Qty"])* Convert.ToInt32(reader["Selling_Price"]))- Convert.ToInt32(reader["Discount"])
                                );
                            total += (Convert.ToInt32(reader["Qty"]) * Convert.ToInt32(reader["Selling_Price"])) - Convert.ToInt32(reader["Discount"]);
                        }
                        else
                        {
                            dgv_list.Rows.Add(
                                reader["Service_description"].ToString(),
                                "",
                                "",
                                reader["Selling_Price"].ToString(),
                                "",
                                reader["Selling_Price"].ToString()
                                );
                            total += Convert.ToInt32(reader["Selling_Price"]);
                        }
                    }
                    lbl_Total.Text = total.ToString();
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
