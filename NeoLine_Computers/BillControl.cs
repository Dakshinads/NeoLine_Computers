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
    public partial class BillControl : UserControl
    {
        MySqlConnection con;
        DBConnection dbConnect = new DBConnection();
        int totalQty = 0;
        int totalvalue = 0;
        int totaldiscount = 0;
        int availableStock = 0;

        public BillControl()
        {
            InitializeComponent();
            con = dbConnect.getConn();
            getInvoiceNo();
            DateTime dt = DateTime.Now;
            txt_Date.Text = dt.ToString("yyyy-MM-dd");
            loadCmbItemName();
            cmb_type.SelectedIndex = 0;
            cmb_warrantyPeriod.SelectedIndex = 0;

        }
        public void popAlert(string msg, Alert.enmType type)
        {
            Alert al = new Alert();
            al.showAlert(msg, type);
        }

        public void cancelall()
        {
            txt_customerName.Text = "";
            txt_contactno.Text = "";
            cmb_type.SelectedIndex = 0;
            clear();
            dgv_list.Rows.Clear();
            lbl_totdiscount.Text = "..";
            lbl_totqty.Text = "..";
            lbl_totvalue.Text = "..";
        }

        public void clear()
        {
            cmb_type.SelectedIndex = 0;
            cmb_itemName.SelectedIndex = 0;
            cmb_itemName.Enabled = true;

            txt_description.Text = "";
            txt_description.Enabled = false;

            txt_searchitem.Text = "";
            txt_searchitem.Enabled = true;

            txt_qty.Text = "";
            txt_qty.Enabled = true;

            txt_price.Text = "";
            txt_price.Enabled = false;

            cmb_warrantyPeriod.SelectedIndex = 0;
            cmb_warrantyPeriod.Enabled = true;

            txt_discount.Text = "";
            txt_discount.Enabled = true;
        }

        public void getInvoiceNo()
        {
            try
            {
                int invoiceNo = 0;
                string query = "SELECT Invoice_ID FROM invoice ORDER BY Invoice_ID DESC LIMIT 1 ";
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        invoiceNo = Convert.ToInt32(reader["Invoice_ID"]);
                    }
                }
                con.Close();
                txt_invoiceno.Text = (invoiceNo + 1).ToString();
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
                    query = "SELECT Name, Item_ID FROM item WHERE Name LIKE '%" + txt_searchitem.Text + "%' AND Stock > 0 ORDER BY Item_ID";
                }
                else
                {
                    query = "SELECT Name, Item_ID FROM item WHERE Stock > 0  ORDER BY Item_ID";
                }
                DataRow dr;
                //MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter msda = new MySqlDataAdapter(cmd);
                con.Open();
                DataTable dt = new DataTable();
                msda.Fill(dt);
                con.Close();
                cmb_itemName.ValueMember = "Item_ID";
                cmb_itemName.DisplayMember = "Name";
                cmb_itemName.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_type.SelectedIndex == 0)
            {
                cmb_itemName.SelectedIndex = 0;
                cmb_itemName.Enabled = true;

                txt_description.Text = "";
                txt_description.Enabled = false;

                txt_searchitem.Text = "";
                txt_searchitem.Enabled = true;

                txt_qty.Text = "";
                txt_qty.Enabled = true;

                txt_price.Text = "";
                txt_price.Enabled = false;

                cmb_warrantyPeriod.SelectedIndex = 0;
                cmb_warrantyPeriod.Enabled = true;

                txt_discount.Text = "";
                txt_discount.Enabled = true;
            }
            else if (cmb_type.SelectedIndex == 1)
            {
                cmb_itemName.SelectedIndex = 0;
                cmb_itemName.Enabled = false;

                txt_description.Text = "";
                txt_description.Enabled = true;

                txt_searchitem.Text = "";
                txt_searchitem.Enabled = false;

                txt_qty.Text = "";
                txt_qty.Enabled = false;

                txt_price.Text = "";
                txt_price.Enabled = true;

                cmb_warrantyPeriod.SelectedIndex = 0;
                cmb_warrantyPeriod.Enabled = false;

                txt_discount.Text = "";
                txt_discount.Enabled = false;
            }
        }

        private void txt_searchitem_TextChange(object sender, EventArgs e)
        {
            loadCmbItemName();
        }

        private void cmb_itemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int item_id = Convert.ToInt32(cmb_itemName.SelectedValue);
            try
            {
                string query = "SELECT Price, Stock ,Warranty_Period FROM item WHERE item_id= "+item_id;
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        txt_price.Text = reader["Price"].ToString();
                        availableStock = Convert.ToInt32(reader["Stock"]);
                        cmb_warrantyPeriod.Text = reader["Warranty_Period"].ToString();
                        txt_qty.Text = "";
                        txt_discount.Text = "";

                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cancelall();
        }


        private void txt_searchitem_TextChange_1(object sender, EventArgs e)
        {
            loadCmbItemName();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int dis = 0;
            try
            {
                if (cmb_type.SelectedIndex == 0)
                {
                    if (txt_price.Text.Length > 0)
                    {
                        if (txt_qty.Text.Length > 0)
                        {
                            if (int.TryParse(txt_qty.Text, out int ignoreme))
                            {
                                if (Convert.ToInt32(txt_qty.Text) <= availableStock)
                                {
                                    if (txt_discount.Text.Length > 0)
                                    {
                                        if (int.TryParse(txt_discount.Text, out int ignorem))
                                        {
                                            if (Convert.ToInt32(txt_discount.Text) <= Convert.ToInt32(txt_price.Text))
                                            {
                                                dis = Convert.ToInt32(txt_discount.Text);
                                                addToListAndCheck(dis);
                                            }
                                            else
                                            {
                                                popAlert("You cannot give discount more than price", Alert.enmType.Info);
                                            }
                                        }
                                        else
                                        {
                                            popAlert("Entered discount value is invalid", Alert.enmType.Info);
                                        }
                                    }
                                    else
                                    {
                                        addToListAndCheck(dis);
                                    }                                   
                                }
                                else
                                {
                                    popAlert("There are " + availableStock + " stocks in this item. " , Alert.enmType.Info);
                                }
                            }
                            else
                            {
                                popAlert("Entered quantity value is invalid", Alert.enmType.Info);
                            }
                        }
                        else
                        {
                            popAlert("Quantity field cannot be empty", Alert.enmType.Info);
                        }
                    }
                    else
                    {
                        popAlert("Selected item is invalid", Alert.enmType.Info);
                    }
                }
                else
                {
                    if (txt_description.Text.Length > 0)
                    {
                        if (txt_price.Text.Length > 0)
                        {
                            if(int.TryParse(txt_price.Text, out int ign))
                            {
                                dgv_colAction.HeaderText = "";
                                dgv_colAction.Text = "Remove";
                                dgv_colAction.Name = "btn_remove";
                                dgv_colAction.FlatStyle = FlatStyle.Flat;
                                dgv_colAction.UseColumnTextForButtonValue = true;

                                dgv_list.Rows.Add(0,
                                    txt_description.Text,
                                    "-",
                                    "-",
                                    txt_price.Text,
                                    "-",
                                    txt_price.Text
                                    );
                                totalvalue += Convert.ToInt32(txt_price.Text);
                                clear();
                                refreshTot();
                            }
                            else
                            {
                                popAlert("Entered price value is invalid", Alert.enmType.Info);
                            }
                        }
                        else
                        {
                            popAlert("Price field cannot be empty", Alert.enmType.Info);
                        }
                    }
                    else
                    {
                        popAlert("Service Description field cannot be empty", Alert.enmType.Info);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void addToListAndCheck(int dis)
        {
            bool isItemAdded = false;
            for (int i = 0; i < dgv_list.Rows.Count; i++)
            {
                if (cmb_itemName.SelectedValue.Equals(dgv_list.Rows[i].Cells[0].Value))
                {
                    isItemAdded = true;
                    break;
                }
            }

            if (!isItemAdded)
            {
                dgv_colAction.HeaderText = "";
                dgv_colAction.Text = "Remove";
                dgv_colAction.Name = "btn_remove";
                dgv_colAction.FlatStyle = FlatStyle.Flat;
                dgv_colAction.UseColumnTextForButtonValue = true;

                dgv_list.Rows.Add(cmb_itemName.SelectedValue,
                    cmb_itemName.Text,
                    cmb_warrantyPeriod.Text,
                    txt_qty.Text,
                    txt_price.Text,
                    dis,
                    (Convert.ToInt32(txt_qty.Text) * Convert.ToInt32(txt_price.Text)) - dis
                    );
                totalQty += Convert.ToInt32(txt_qty.Text);
                totalvalue += Convert.ToInt32(txt_price.Text) * Convert.ToInt32(txt_qty.Text) - dis;
                totaldiscount += dis;
                clear();
                refreshTot();
            }
            else
            {
                popAlert("This item is already added to the list", Alert.enmType.Info);
            }
        }

        private void refreshTot()
        {
            lbl_totqty.Text = totalQty.ToString();
            lbl_totvalue.Text = totalvalue.ToString();
            lbl_totdiscount.Text = totaldiscount.ToString();
        }


        private void dgv_stockin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                totalQty -= Convert.ToInt32(dgv_list.Rows[e.RowIndex].Cells[3].Value);
                totalvalue -= Convert.ToInt32(dgv_list.Rows[e.RowIndex].Cells[6].Value);
                totaldiscount -= Convert.ToInt32(dgv_list.Rows[e.RowIndex].Cells[5].Value);
                dgv_list.Rows.RemoveAt(e.RowIndex);
                refreshTot();
            }
        }

        private void btn_showinvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_customerName.Text.Length > 0)
                {
                    if (txt_contactno.Text.Length > 0)
                    {
                        if(int.TryParse(txt_contactno.Text, out int ignorme))
                        {
                            if (dgv_list.RowCount > 0)
                            {
                                int cusID = insertAndGetCustomer();

                                for (int i = 0; i < dgv_list.RowCount; i++)
                                {
                                    DateTime dt = DateTime.Now;

                                    string qry = "";
                                    if (Convert.ToInt32(dgv_list.Rows[i].Cells[0].Value) == 0)
                                    {
                                        qry = "INSERT INTO invoice( Invoice_ID, Time, Date, Qty, Selling_Price, Warranty_Period, Discount, Type, Service_description, Item_ID, Customer_ID)" +
                                      " VALUES (" + Convert.ToInt32(txt_invoiceno.Text) + "," +
                                      "'" + dt.ToString("HH:mm:ss") + "','" + txt_Date.Text + "'," +
                                      "" + 0 + "," + Convert.ToInt32(dgv_list.Rows[i].Cells[4].Value) + "," +
                                      "'no'," + 0 + "," +
                                      "'Service','" + dgv_list.Rows[i].Cells[1].Value.ToString() + "',null," +
                                      "" + cusID + ")";

                                    }
                                    else
                                    {
                                        qry = "INSERT INTO invoice( Invoice_ID, Time, Date, Qty, Selling_Price, Warranty_Period, Discount, Type, Service_description, Item_ID, Customer_ID)" +
                                       " VALUES (" + Convert.ToInt32(txt_invoiceno.Text) + "," +
                                       "'" + dt.ToString("HH:mm:ss") + "','" + txt_Date.Text + "'," +
                                       "" + Convert.ToInt32(dgv_list.Rows[i].Cells[3].Value) + "," + Convert.ToInt32(dgv_list.Rows[i].Cells[4].Value) + "," +
                                       "'" + dgv_list.Rows[i].Cells[2].Value + "'," + Convert.ToInt32(dgv_list.Rows[i].Cells[5].Value) + "," +
                                       "'Item',null," + Convert.ToInt32(dgv_list.Rows[i].Cells[0].Value) + "," +
                                       "" + cusID + ")";
                                    }

                                   
                                    MySqlDataReader reader;
                                    con.Open();
                                    MySqlCommand cmd = new MySqlCommand(qry, con);
                                    reader = cmd.ExecuteReader();
                                    con.Close();

                                    if(Convert.ToInt32(dgv_list.Rows[i].Cells[0].Value) != 0)
                                    {
                                        string updateqry = "UPDATE item SET Stock= Stock - " + Convert.ToInt32(dgv_list.Rows[i].Cells[3].Value) + " WHERE Item_ID = " + Convert.ToInt32(dgv_list.Rows[i].Cells[0].Value);
                                        MySqlDataReader reader1;
                                        con.Open();
                                        MySqlCommand cmd1 = new MySqlCommand(updateqry, con);
                                        reader1 = cmd1.ExecuteReader();
                                        con.Close();
                                    }                                    
                                }
                                popAlert("Invoice details Saved Successfully", Alert.enmType.Success);
                                Form_Invoice frmin = new Form_Invoice(Convert.ToInt32(txt_invoiceno.Text));
                                cancelall();
                                getInvoiceNo();
                                frmin.Show();

                            }
                            else
                            {
                                popAlert("You are not added items to the list", Alert.enmType.Info);
                            }
                        }
                        else
                        {
                            popAlert("Entered contact no is invalid", Alert.enmType.Info);
                        }
                    }
                    else
                    {
                        popAlert("Contact No field cannot be empty", Alert.enmType.Info);
                    }
                }
                else
                {
                    popAlert("Customer Name field cannot be empty", Alert.enmType.Info);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int insertAndGetCustomer()
        {
            int customerID=0;

            string qry = "INSERT INTO customer(Name, Contact_No) VALUES ('"+txt_customerName.Text+"',"+Convert.ToInt32(txt_contactno.Text)+")";
            MySqlDataReader reader;
            con.Open();
            MySqlCommand cmd = new MySqlCommand(qry, con);
            reader = cmd.ExecuteReader();
            con.Close();

            string query = "SELECT Customer_ID FROM customer ORDER BY Customer_ID DESC LIMIT 1 ";
            MySqlDataReader reader1;
            MySqlCommand cmd1 = new MySqlCommand(query, con);
            con.Open();
            reader1 = cmd1.ExecuteReader();
            if (reader1.HasRows)
            {
                while (reader1.Read())
                {
                    customerID = Convert.ToInt32(reader1["Customer_ID"]);
                }
            }
            con.Close();
            return customerID;
        }
    }
}
