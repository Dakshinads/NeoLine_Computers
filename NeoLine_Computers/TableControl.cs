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
    public partial class TableControl : UserControl
    {
        MySqlConnection con;
        DBConnection dbConnect = new DBConnection();
        public TableControl()
        {
            InitializeComponent();
            con = dbConnect.getConn();

            if (tabControl1.SelectedTab == tabControl1.TabPages["tab_Category"])
            {
                loadCategoryGrid();
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tab_Item"])
            {
                loadItemGrid();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tab_Category"])
            {
                refreshGridC();
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tab_Item"])
            {
                refreshGridI();
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tab_Supplier"])
            {
                MessageBox.Show("supplier");
            }
        }

        public void popAlert(string msg, Alert.enmType type)
        {
            Alert al = new Alert();
            al.showAlert(msg, type);
        }

        private void loadCategoryGrid()
        {
            try
            {
                string query = "SELECT Category_ID, Name, Description from category ";
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dgv_Category.Rows.Add(
                           reader["Category_ID"].ToString(),
                           reader["Name"].ToString(),
                           reader["Description"].ToString()
                           );
                    }

                    DataGridViewButtonColumn btn_updatec = new DataGridViewButtonColumn();
                    dgv_Category.Columns.Add(btn_updatec);
                    btn_updatec.HeaderText = "";
                    btn_updatec.Text = "Update";
                    btn_updatec.Name = "btn_update";
                    btn_updatec.FlatStyle = FlatStyle.Flat;
                    btn_updatec.UseColumnTextForButtonValue = true;

                    DataGridViewButtonColumn btn_delete = new DataGridViewButtonColumn();
                    dgv_Category.Columns.Add(btn_delete);
                    btn_delete.HeaderText = "";
                    btn_delete.Text = "Delete";
                    btn_delete.Name = "btn_delete";
                    btn_delete.FlatStyle = FlatStyle.Flat;
                    btn_delete.UseColumnTextForButtonValue = true;
                }
                else
                {
                    popAlert("No Data", Alert.enmType.Info);
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void loadItemGrid()
        {
            try
            {
                string query = "SELECT i.Item_ID, i.Name, i.Description, i.Stock, i.Price, i.Warranty_Period, c.Name as cat_name FROM item as i INNER JOIN category as c ON i.Category_ID = c.Category_ID ORDER BY c.Category_ID";
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dgv_Item.Rows.Add(
                           reader["Item_ID"].ToString(),
                           reader["Name"].ToString(),
                           reader["Description"].ToString(),
                           reader["Stock"].ToString(),
                           reader["Price"].ToString(),
                           reader["Warranty_Period"].ToString(),
                           reader["cat_name"].ToString()
                           );
                    }

                    DataGridViewButtonColumn btn_updatei = new DataGridViewButtonColumn();
                    dgv_Item.Columns.Add(btn_updatei);
                    btn_updatei.HeaderText = "";
                    btn_updatei.Text = "Update";
                    btn_updatei.Name = "btn_update";
                    btn_updatei.FlatStyle = FlatStyle.Flat;
                    btn_updatei.UseColumnTextForButtonValue = true;

                    DataGridViewButtonColumn btn_deletei = new DataGridViewButtonColumn();
                    dgv_Item.Columns.Add(btn_deletei);
                    btn_deletei.HeaderText = "";
                    btn_deletei.Text = "Delete";
                    btn_deletei.Name = "btn_delete";
                    btn_deletei.FlatStyle = FlatStyle.Flat;
                    btn_deletei.UseColumnTextForButtonValue = true;
                }
                else
                {
                    popAlert("No Data", Alert.enmType.Info);
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void dgv_Category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                CatReg catr = new CatReg(2, Convert.ToInt32(dgv_Category.Rows[e.RowIndex].Cells[0].Value),
                    dgv_Category.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    dgv_Category.Rows[e.RowIndex].Cells[2].Value.ToString()
                    );
                catr.Show();
            }
            else if (e.ColumnIndex == 4)
            {
                ConfirmationPopup confirm = new ConfirmationPopup("Do you want to delete name = " + dgv_Category.Rows[e.RowIndex].Cells[1].Value.ToString() + " ?");
                DialogResult dr = confirm.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    delete(dgv_Category.Rows[e.RowIndex].Cells[0].Value.ToString(),"category","Category_ID");
                }
                confirm.Dispose();
            }
        }

        private void dgv_Item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                ItemReg itemr = new ItemReg(2,
                    Convert.ToInt32(dgv_Item.Rows[e.RowIndex].Cells[0].Value),
                    dgv_Item.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    dgv_Item.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Convert.ToInt32(dgv_Item.Rows[e.RowIndex].Cells[3].Value.ToString()),
                    Convert.ToInt32(dgv_Item.Rows[e.RowIndex].Cells[4].Value.ToString()),
                    dgv_Item.Rows[e.RowIndex].Cells[5].Value.ToString(),
                     dgv_Item.Rows[e.RowIndex].Cells[6].Value.ToString()
                    );
                itemr.Show();
            }
            else if (e.ColumnIndex == 8)
            {
                ConfirmationPopup confirm = new ConfirmationPopup("Do you want to delete item name = " + dgv_Item.Rows[e.RowIndex].Cells[1].Value.ToString() + " ?");
                DialogResult dr = confirm.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    delete(dgv_Item.Rows[e.RowIndex].Cells[0].Value.ToString(),"item","Item_ID");
                }
                confirm.Dispose();
            }
        }


        private void btn_addNewC_Click(object sender, EventArgs e)
        {
            CatReg cat = new CatReg(1);
            cat.Show();
        }

        private void btn_addNewI_Click(object sender, EventArgs e)
        {
            ItemReg itemr = new ItemReg(1);
            itemr.Show();
        }

        private void btn_refreshC_Click(object sender, EventArgs e)
        {
            refreshGridC();
        }

        public void delete(string id, string tableName, string columnName)
        {
            try
            {
                string query = "DELETE FROM "+tableName+" WHERE "+columnName+"='" + id + "'";
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                }
                popAlert("Seccussfully Deleted", Alert.enmType.Delete);
                con.Close();
                if (tableName == "category")
                {
                    refreshGridC();
                }
                else if (tableName == "item")
                {
                    refreshGridI();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void refreshGridC()
        {
            dgv_Category.Rows.Clear();
            dgv_Category.Columns.RemoveAt(4);
            dgv_Category.Columns.RemoveAt(3);
            loadCategoryGrid();
        }

        public void refreshGridI()
        {
            dgv_Item.Rows.Clear();
            if (dgv_Item.ColumnCount > 7)
            {
                dgv_Item.Columns.RemoveAt(8);
                dgv_Item.Columns.RemoveAt(7);
            }
            loadItemGrid();
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string sName = txt_search.Text;
                string query = "SELECT i.Item_ID, i.Name, i.Description, i.Stock, i.Price, i.Warranty_Period, c.Name as cat_name FROM item as i INNER JOIN category as c ON i.Category_ID = c.Category_ID WHERE i.Name LIKE '%"+sName+"%' ORDER BY c.Category_ID";
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                reader = cmd.ExecuteReader();
                dgv_Item.Rows.Clear();
                if (dgv_Item.ColumnCount > 7)
                {
                    dgv_Item.Columns.RemoveAt(8);
                    dgv_Item.Columns.RemoveAt(7);
                }
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dgv_Item.Rows.Add(
                           reader["Item_ID"].ToString(),
                           reader["Name"].ToString(),
                           reader["Description"].ToString(),
                           reader["Stock"].ToString(),
                           reader["Price"].ToString(),
                           reader["Warranty_Period"].ToString(),
                           reader["cat_name"].ToString()
                           );
                    }

                    DataGridViewButtonColumn btn_updatei = new DataGridViewButtonColumn();
                    dgv_Item.Columns.Add(btn_updatei);
                    btn_updatei.HeaderText = "";
                    btn_updatei.Text = "Update";
                    btn_updatei.Name = "btn_update";
                    btn_updatei.FlatStyle = FlatStyle.Flat;
                    btn_updatei.UseColumnTextForButtonValue = true;

                    DataGridViewButtonColumn btn_deletei = new DataGridViewButtonColumn();
                    dgv_Item.Columns.Add(btn_deletei);
                    btn_deletei.HeaderText = "";
                    btn_deletei.Text = "Delete";
                    btn_deletei.Name = "btn_delete";
                    btn_deletei.FlatStyle = FlatStyle.Flat;
                    btn_deletei.UseColumnTextForButtonValue = true;
                }
                else
                {
                    popAlert("No Data", Alert.enmType.Info);
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void btn_clearsearch_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            refreshGridI();
        }

        private void btn_refereshI_Click(object sender, EventArgs e)
        {
            refreshGridI();
        }
    }
}
