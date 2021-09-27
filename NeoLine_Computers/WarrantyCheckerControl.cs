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
    public partial class WarrantyCheckerControl : UserControl
    {

        MySqlConnection con;
        DBConnection dbConnect = new DBConnection();

        public WarrantyCheckerControl()
        {
            InitializeComponent();
            con = dbConnect.getConn();
        }

        public void popAlert(string msg, Alert.enmType type)
        {
            Alert al = new Alert();
            al.showAlert(msg, type);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lbl_contactNo.Text = "";
            lbl_customerName.Text = "";
            lbl_date.Text = "";
            lbl_time.Text = "";
            txt_invoiceNo.Text = "";
            dgv_list.Rows.Clear();
        }

        private void showDetails(int invoiceNo)
        {
            try
            {
                string query = "SELECT i.Invoice_ID, i.Time, i.Date, i.Qty, i.Selling_Price, i.Warranty_Period, i.Discount, i.Type ,i.Service_description," +
                    " it.Name as iName, c.Name as cName,  c.Contact_No FROM `invoice` as i INNER JOIN customer c ON i.Customer_ID=c.Customer_ID LEFT JOIN item it ON i.Item_ID=it.Item_ID" +
                    " WHERE Invoice_ID=" + invoiceNo + "";
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                reader = cmd.ExecuteReader();
                int total = 0;
                dgv_list.Rows.Clear();
                lbl_contactNo.Text = "";
                lbl_customerName.Text = "";
                lbl_date.Text = "";
                lbl_time.Text = "";
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lbl_date.Text = reader["Date"].ToString();
                        lbl_time.Text = reader["Time"].ToString();
                        lbl_customerName.Text = reader["cName"].ToString();
                        lbl_contactNo.Text = reader["Contact_No"].ToString();

                        if (reader["Service_description"].ToString().Length <= 0)
                        {
                            dgv_list.Rows.Add(
                                reader["iName"].ToString(),
                                reader["Warranty_Period"].ToString(),
                                reader["Qty"].ToString(),
                                reader["Selling_Price"].ToString(),
                                reader["Discount"].ToString(),
                                (Convert.ToInt32(reader["Qty"]) * Convert.ToInt32(reader["Selling_Price"])) - Convert.ToInt32(reader["Discount"])
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
                }
                else
                {
                    popAlert("No Data", Alert.enmType.Info);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_invoiceNo.Text.Length > 0)
                {
                    if (int.TryParse(txt_invoiceNo.Text, out int d))
                    {
                        showDetails(Convert.ToInt32(txt_invoiceNo.Text));
                    }
                    else
                    {
                        popAlert("Invalid invoice no", Alert.enmType.Info);
                        lbl_contactNo.Text = "";
                        lbl_customerName.Text = "";
                        lbl_date.Text = "";
                        lbl_time.Text = "";
                    }
                }
                else
                {
                    popAlert("Invoice No field is required", Alert.enmType.Info);
                    lbl_contactNo.Text = "";
                    lbl_customerName.Text = "";
                    lbl_date.Text = "";
                    lbl_time.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                                
        }
    }
}
