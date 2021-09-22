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
    public partial class ItemReg : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private int type;
        private int item_id;
        private int stock;
        MySqlConnection con;
        DBConnection dbConnect = new DBConnection();

        // type 1 = save,  type 2 = update
        public ItemReg(int type)
        {
            InitializeComponent();
            con = dbConnect.getConn();
            txt_name.Focus();
            loadCmb();
            cmb_categoryName.SelectedIndex = 0;
            cmb_warrantyPeriod.SelectedIndex = 0;
            if (type == 1)
            {
                lbl_formname.Text = "Item Registration";
                btn_action.Text = "Save";
                this.type = type;
            }
            
        }
        public ItemReg(int type, int item_id,string name, string description, int stock, int price, string warrantyperiod, string catname  )
        {
            InitializeComponent();
            con = dbConnect.getConn();
            loadCmb();

            txt_name.Text = name;
            txt_description.Text = description;
            txt_price.Text = price.ToString();
            cmb_categoryName.Text = catname;
            cmb_warrantyPeriod.SelectedItem =warrantyperiod ;
            this.item_id = item_id;
            this.stock = stock;
            this.type = type;

            lbl_formname.Text = "Update Item Details";
            btn_action.Text = "Update";                
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

        public void loadCmb()
        {
            try
            {
                DataRow dr;
                string query = "SELECT Name, Category_ID FROM category ORDER BY Category_ID";
                //MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter msda = new MySqlDataAdapter(cmd);
                con.Open();
                DataTable dt = new DataTable();
                msda.Fill(dt);
                cmb_categoryName.ValueMember = "Category_ID";
                cmb_categoryName.DisplayMember = "Name";
                cmb_categoryName.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_action_Click(object sender, EventArgs e)
        {
            String name, description, warrantyPeriod;
            int price, categoryId;
            try
            {
                if (txt_name.Text.Length > 0 && txt_description.Text.Length > 0 && txt_price.Text.Length > 0)
                {
                    name = txt_name.Text;
                    description = txt_description.Text;
                    int ignorme;
                    warrantyPeriod = cmb_warrantyPeriod.SelectedItem.ToString();
                    categoryId = Convert.ToInt32(cmb_categoryName.SelectedValue);
                    if(int.TryParse(txt_price.Text, out ignorme))
                    {
                        price = Convert.ToInt32(txt_price.Text);
                        if (this.type == 1)
                        {
                            insert(name, description,price,warrantyPeriod,categoryId);
                        }
                        else if (this.type == 2)
                        {
                            update(name, description, price, warrantyPeriod, categoryId);
                        }
                    }
                    else
                    {
                        popAlert("Entered price is invalid ", Alert.enmType.Info);
                    }
                       
                }
                else
                {
                    popAlert("Entered values are invalid ", Alert.enmType.Info);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_categoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(((KeyValuePair)cmb_categoryName.SelectedItem).Key);
        }

        private void insert(string name,string  description,int price, string warrantyPeriod,int categoryId)
        {
            try
            {
                string qry = "INSERT INTO item(Name, Description,Stock,Price,Warranty_Period,Category_ID)" +
                    " VALUES('" + name + "','" + description + "',0 ,'" + price + "','" + warrantyPeriod + "',"+categoryId+" )";
                MySqlDataReader reader;
                con.Open();
                MySqlCommand cmd = new MySqlCommand(qry, con);
                reader = cmd.ExecuteReader();
                popAlert("Successully saved", Alert.enmType.Success);
                con.Close();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update(string name, string description, int price, string warrantyPeriod, int categoryId)
        {
            try
            {
                string qry = "UPDATE item SET Name='" + name + "',Description='" + description + "',Stock=" + this.stock + " ,Price=" + price + ",Warranty_Period='" + warrantyPeriod + "'" +
                    ",Category_ID=" + categoryId + " " +
                    "WHERE Item_ID=" + this.item_id + "";
                MySqlDataReader reader;
                con.Open();
                MySqlCommand cmd = new MySqlCommand(qry, con);
                reader = cmd.ExecuteReader();
                popAlert("Successully updated", Alert.enmType.Update);
                con.Close();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
