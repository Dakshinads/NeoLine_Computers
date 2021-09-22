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
    public partial class StockInControl : UserControl
    {
        MySqlConnection con;
        DBConnection dbConnect = new DBConnection();
        int totalQty = 0;
        int totalvalue = 0;

        public StockInControl()
        {
            InitializeComponent();
            con = dbConnect.getConn();
            getGRNno();
            loadCmbItemName();
            loadCmbSupplierName();
        }

        public void popAlert(string msg, Alert.enmType type)
        {
            Alert al = new Alert();
            al.showAlert(msg, type);
        }

        public void getGRNno()
        {
            try
            {
                int grnno = 0;
                string query = "SELECT GRN_ID FROM grn ORDER BY GRN_ID DESC ";
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
                txt_grnno.Text = (grnno + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadCmbSupplierName()
        {
            try
            {
                DataRow dr;
                string query = "SELECT Name, Supplier_ID FROM supplier ORDER BY Supplier_ID";
                //MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter msda = new MySqlDataAdapter(cmd);
                con.Open();
                DataTable dt = new DataTable();
                msda.Fill(dt);
                cmb_supplierName.ValueMember = "Supplier_ID";
                cmb_supplierName.DisplayMember = "Name";
                cmb_supplierName.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadCmbItemName()
        {
            try
            {
                string query;
                if (txt_searchitem.Text.Length > 0)
                {
                    query = "SELECT Name, Item_ID FROM item WHERE Name LIKE '%" + txt_searchitem.Text + "%' ORDER BY Item_ID";
                }
                else
                {
                    query= "SELECT Name, Item_ID FROM item ORDER BY Item_ID";
                }
                DataRow dr;
                //MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter msda = new MySqlDataAdapter(cmd);
                con.Open();
                DataTable dt = new DataTable();
                msda.Fill(dt);
                cmb_itemName.ValueMember = "Item_ID";
                cmb_itemName.DisplayMember = "Name";
                cmb_itemName.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_searchitem_TextChanged(object sender, EventArgs e)
        {
            loadCmbItemName();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try{

                if (cmb_itemName.Text.Length > 0)
                {
                    int ignorme;
                    if (int.TryParse(txt_qty.Text, out ignorme) && int.TryParse(txt_price.Text, out ignorme))
                    {
                        /*DataGridViewButtonColumn btn_updatei = new DataGridViewButtonColumn();
                        dgv_Item.Columns.Add(btn_updatei);*/

                        dgv_colAction.HeaderText = "";
                        dgv_colAction.Text = "Remove";
                        dgv_colAction.Name = "btn_remove";
                        dgv_colAction.FlatStyle = FlatStyle.Flat;
                        dgv_colAction.UseColumnTextForButtonValue = true;

                        dgv_stockin.Rows.Add(cmb_itemName.SelectedValue,cmb_itemName.Text, txt_qty.Text, txt_price.Text,
                            (Convert.ToInt32(txt_price.Text) * Convert.ToInt32(txt_qty.Text)).ToString()
                            );

                        totalQty += Convert.ToInt32(txt_qty.Text);
                        totalvalue += Convert.ToInt32(txt_price.Text) * Convert.ToInt32(txt_qty.Text);
                        txt_price.Text = "";
                        txt_qty.Text = "";
                        txt_searchitem.Text = "";
                        cmb_itemName.SelectedIndex = 0;
                        refreshTot();


                    }
                    else
                    {
                        popAlert("entered values are invalid", Alert.enmType.Info);
                    }
                }
                else
                {
                    popAlert("Selected item is invalid", Alert.enmType.Info);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgv_stockin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                totalQty -= Convert.ToInt32(dgv_stockin.Rows[e.RowIndex].Cells[2].Value);
                totalvalue -= Convert.ToInt32(dgv_stockin.Rows[e.RowIndex].Cells[4].Value);
                dgv_stockin.Rows.RemoveAt(e.RowIndex);
                refreshTot();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_price.Text = "";
            txt_qty.Text = "";
            txt_searchitem.Text = "";
            cmb_itemName.SelectedIndex = 0;
        }

        private void refreshTot()
        {
            lbl_totqty.Text = totalQty.ToString();
            lbl_totValue.Text = totalvalue.ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ConfirmationPopup confirm = new ConfirmationPopup("Do you want to cancel this GRN? ");
            DialogResult dr = confirm.ShowDialog();
            if (dr == DialogResult.Yes)
            {
                txt_price.Text = "";
                txt_qty.Text = "";
                txt_searchitem.Text = "";
                cmb_itemName.SelectedIndex = 0;
                dgv_stockin.Rows.Clear();
                lbl_totqty.Text = "..";
                lbl_totValue.Text = "..";
                txt_description.Text = "";
                cmb_supplierName.SelectedIndex = 0;


            }
            confirm.Dispose();

        }

        private void btn_updateStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_stockin.RowCount > 0)
                {

                    for (int i = 0; i < dgv_stockin.RowCount; i++)
                    {
                        DateTime dt = DateTime.Now;

                        string qry = "INSERT INTO grn(GRN_ID, Time, Date, Qty, Cost_Price,Stock_Description,Supplier_ID,Item_ID)" +
                        " VALUES(" + Convert.ToInt32(txt_grnno.Text) + ",'" + dt.ToString("HH:mm:ss") + "','" + dt.ToString("yyyy-MM-dd") + "'," +
                        "" + Convert.ToInt32(dgv_stockin.Rows[i].Cells[2].Value) + ","+ Convert.ToInt32(dgv_stockin.Rows[i].Cells[3].Value) + "," +
                        "'"+txt_description.Text+"',"+Convert.ToInt32(cmb_supplierName.SelectedValue)+","+ Convert.ToInt32(dgv_stockin.Rows[i].Cells[0].Value) + " )";
                        MessageBox.Show(qry);
                        MySqlDataReader reader;
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand(qry, con);
                        reader = cmd.ExecuteReader();                        
                        con.Close();
                    }
                    popAlert("Stock Successully Updated", Alert.enmType.Success);
                    txt_price.Text = "";
                    txt_qty.Text = "";
                    txt_searchitem.Text = "";
                    cmb_itemName.SelectedIndex = 0;
                    dgv_stockin.Rows.Clear();
                    lbl_totqty.Text = "..";
                    lbl_totValue.Text = "..";
                    txt_description.Text = "";
                    cmb_supplierName.SelectedIndex = 0;
                    getGRNno();

                }
                else
                {
                    popAlert("You are not added items to the list", Alert.enmType.Info);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
