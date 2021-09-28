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
    public partial class ReporControl : UserControl
    {
        MySqlConnection con;
        DBConnection dbConnect = new DBConnection();
        public ReporControl()
        {
            InitializeComponent();
            con = dbConnect.getConn();
            date_fromInvoice.Value = DateTime.Now.Date;
            date_toInvoice.Value = DateTime.Now.Date;
            date_fromCategory.Value = DateTime.Now.Date;
            date_toCategory.Value = DateTime.Now.Date;
            date_fromItem.Value = DateTime.Now.Date;
            date_toItem.Value = DateTime.Now.Date;
            date_fromGRN.Value = DateTime.Now.Date;
            date_toGRN.Value = DateTime.Now.Date;
        }

        public void popAlert(string msg, Alert.enmType type)
        {
            Alert al = new Alert();
            al.showAlert(msg, type);
        }

        private void btn_searchInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (date_fromInvoice.Value.Date <= date_toInvoice.Value.Date)
                {
                    int total = 0;
                    string query = "SELECT Invoice_ID,Date, SUM(Qty) as qty, SUM((Selling_Price*IF(Qty=0,1,Qty))-Discount) as total from invoice " +
                        "WHERE Date BETWEEN '"+date_fromInvoice.Text+"' AND '"+date_toInvoice.Text+"' GROUP BY Invoice_ID ";
                    MySqlDataReader reader;
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    reader = cmd.ExecuteReader();
                    dgv_Invoice.Rows.Clear();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dgv_Invoice.Rows.Add(
                                reader["Invoice_ID"].ToString(),
                                reader["Date"].ToString(),
                                reader["qty"].ToString(),
                                reader["total"].ToString()
                                ); 
                            total+=Convert.ToInt32(reader["total"]);
                        }
                        lbl_titleInvoice.Text = "Sales by Invoice (" + date_fromInvoice.Text + " - " + date_toInvoice.Text + ")";
                        lbl_totalInvoice.Text = total.ToString();
                    }
                    con.Close();
                }
                else
                {
                    popAlert("FROM date cannot be grater than TO date", Alert.enmType.Info);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }


        private void btn_ClearInvoice_Click(object sender, EventArgs e)
        {
            date_fromInvoice.Value = DateTime.Now.Date;
            date_toInvoice.Value = DateTime.Now.Date;
            lbl_titleInvoice.Text = "..";
            lbl_totalInvoice.Text = "..";
            dgv_Invoice.Rows.Clear();
        }       

        private void btn_searchCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (date_fromCategory.Value.Date <= date_toCategory.Value.Date)
                {
                    int total = 0;
                    string query = "SELECT c.Name, SUM(i.Qty) as totalqty, SUM((i.Selling_Price* i.Qty)-i.Discount) as total FROM invoice as i " +
                        "INNER JOIN item as it ON i.Item_ID=it.Item_ID INNER JOIN category as c ON it.Category_ID=c.Category_ID" +
                        " WHERE i.Date BETWEEN '"+date_fromCategory.Text+"' AND '"+date_toCategory.Text+"' GROUP BY c.Category_ID;";
                    MySqlDataReader reader;
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    reader = cmd.ExecuteReader();
                    dgv_Category.Rows.Clear();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dgv_Category.Rows.Add(
                                reader["Name"].ToString(),
                                reader["totalqty"].ToString(),
                                reader["total"].ToString()
                                );
                            total += Convert.ToInt32(reader["total"]);
                        }
                        lbl_titleCategory.Text = "Sales by Category (" + date_fromCategory.Text + " - " + date_toCategory.Text + ")";
                        lbl_totalCategory.Text = total.ToString();
                    }
                    con.Close();
                }
                else
                {
                    popAlert("FROM date cannot be grater than TO date", Alert.enmType.Info);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_clearCategory_Click(object sender, EventArgs e)
        {
            date_fromCategory.Value = DateTime.Now.Date;
            date_toCategory.Value = DateTime.Now.Date;
            lbl_titleCategory.Text = "..";
            lbl_totalCategory.Text = "..";
            dgv_Category.Rows.Clear();
        }

        private void btn_searchItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (date_fromItem.Value.Date <= date_toItem.Value.Date)
                {
                    int total = 0;
                    string query = "SELECT it.Name,SUM(i.Qty) as totalqty, SUM((i.Selling_Price * i.Qty)-i.Discount) as total FROM invoice as i " +
                        "INNER JOIN item as it ON i.Item_ID=it.Item_ID WHERE i.Date BETWEEN '"+date_fromItem.Text+"' AND '"+date_toItem.Text+"' GROUP BY it.Item_ID;";
                    MySqlDataReader reader;
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    reader = cmd.ExecuteReader();
                    dgv_item.Rows.Clear();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dgv_item.Rows.Add(
                                reader["Name"].ToString(),
                                reader["totalqty"].ToString(),
                                reader["total"].ToString()
                                );
                            total += Convert.ToInt32(reader["total"]);
                        }
                        lbl_titleItem.Text = "Sales by Item (" + date_fromItem.Text + " - " + date_toItem.Text + ")";
                        lbl_totalItem.Text = total.ToString();
                    }
                    con.Close();
                }
                else
                {
                    popAlert("FROM date cannot be grater than TO date", Alert.enmType.Info);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_clearItem_Click(object sender, EventArgs e)
        {
            date_fromItem.Value = DateTime.Now.Date;
            date_toItem.Value = DateTime.Now.Date;
            lbl_titleItem.Text = "..";
            lbl_totalItem.Text = "..";
            dgv_item.Rows.Clear();
        }

        private void btn_searchGRN_Click(object sender, EventArgs e)
        {
            try
            {
                if (date_fromGRN.Value.Date <= date_toGRN.Value.Date)
                {
                    string query = "SELECT g.GRN_ID, g.Date, g.Qty, g.Cost_Price, s.Name as sup_name, i.Name as item_name FROM grn as g " +
                        "INNER JOIN supplier as s ON g.Supplier_ID=s.Supplier_ID INNER JOIN item as i ON g.Item_ID=i.Item_ID " +
                        "WHERE g.Date BETWEEN '"+ date_fromGRN .Text+ "' AND '"+ date_toGRN .Text+ "';";
                    MySqlDataReader reader;
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    reader = cmd.ExecuteReader();
                    dgv_GRN.Rows.Clear();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dgv_GRN.Rows.Add(
                                reader["GRN_ID"].ToString(),
                                reader["sup_name"].ToString(),
                                reader["item_name"].ToString(),
                                reader["Date"].ToString(),
                                reader["Qty"].ToString(),
                                reader["Cost_Price"].ToString()
                                );
                        }
                        lbl_titleGRN.Text = "GRN (" + date_fromGRN.Text + " - " + date_toGRN.Text + ")";
                    }
                    con.Close();
                }
                else
                {
                    popAlert("FROM date cannot be grater than TO date", Alert.enmType.Info);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_clearGRN_Click(object sender, EventArgs e)
        {
            date_fromGRN.Value = DateTime.Now.Date;
            date_toGRN.Value = DateTime.Now.Date;
            lbl_titleGRN.Text = "..";
            dgv_GRN.Rows.Clear();
        }
    }
}
