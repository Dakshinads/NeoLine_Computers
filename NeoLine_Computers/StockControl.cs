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
    public partial class StockControl : UserControl
    {
        MySqlConnection con;
        DBConnection dbConnect = new DBConnection();

        public StockControl()
        {
            InitializeComponent();
            cmb_search.SelectedIndex = 0;
            con = dbConnect.getConn();
            refreshGrid();
        }

        public void popAlert(string msg, Alert.enmType type)
        {
            Alert al = new Alert();
            al.showAlert(msg, type);
        }

        public void loadGrid()
        {
            try
            {
                string query = "SELECT  i.Name, i.Description, i.Stock, i.Price, i.Warranty_Period, c.Name as cat_name FROM item as i INNER JOIN category as c ON i.Category_ID = c.Category_ID ORDER BY c.Category_ID";
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dgv_Item.Rows.Add(
                           reader["cat_name"].ToString(),
                           reader["Name"].ToString(),
                           reader["Description"].ToString(),
                           reader["Stock"].ToString(),
                           reader["Price"].ToString(),
                           reader["Warranty_Period"].ToString()                           
                           );
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

        public void refreshGrid()
        {
            dgv_Item.Rows.Clear();
            loadGrid();
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string sName = txt_search.Text;
                String query = "";
                if (cmb_search.SelectedIndex == 0)
                {
                    query = "SELECT i.Name, i.Description, i.Stock, i.Price, i.Warranty_Period, c.Name as cat_name FROM item as i INNER JOIN category as c ON i.Category_ID = c.Category_ID WHERE c.Name LIKE '%" + sName + "%' ";
                }
                else
                {
                    query = "SELECT i.Name, i.Description, i.Stock, i.Price, i.Warranty_Period, c.Name as cat_name FROM item as i INNER JOIN category as c ON i.Category_ID = c.Category_ID WHERE i.Name LIKE '%" + sName + "%' ";
                }
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                reader = cmd.ExecuteReader();
                dgv_Item.Rows.Clear();
                string stock = "";
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (Convert.ToInt32(reader["Stock"]) > 0)
                        {
                            stock = reader["Stock"].ToString();
                        }
                        else
                        {
                            stock = "Out of Stock";
                        }
                        dgv_Item.Rows.Add(
                           reader["cat_name"].ToString(),
                           reader["Name"].ToString(),
                           reader["Description"].ToString(),
                           stock,
                           reader["Price"].ToString(),
                           reader["Warranty_Period"].ToString()
                           );
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_clearsearch_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            cmb_search.SelectedIndex = 0;
            refreshGrid();
        }
    }
}
