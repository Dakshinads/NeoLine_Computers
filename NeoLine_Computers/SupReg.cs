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
    public partial class SupReg : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private int type;
        private int sup_id;
        MySqlConnection con;
        DBConnection dbConnect = new DBConnection();

        public SupReg(int type)
        {
            InitializeComponent();
            con = dbConnect.getConn();
            txt_name.Focus();
            this.type = type;
            lbl_formname.Text = "Supplier Registration";
            btn_action.Text = "Save";
        }

        public SupReg(int type,int supid,string name, string email, int contactno, string remark)
        {
            InitializeComponent();
            con = dbConnect.getConn();
            this.type = type;
            txt_name.Text = name;
            txt_email.Text = email;
            txt_contactNo.Text = contactno.ToString();
            txt_remark.Text = remark;
            this.sup_id = supid;

            lbl_formname.Text = "Update Supplier Details";
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



        private void btn_action_Click(object sender, EventArgs e)
        {
            string name, email, remark;
            int contactno, ignorme;
            try
            {
                if (txt_name.Text.Length > 0 && txt_email.Text.Length > 0 && txt_contactNo.Text.Length > 0)
                {
                    name = txt_name.Text;
                    email = txt_email.Text;
                    remark = txt_remark.Text;
                    if(int.TryParse(txt_contactNo.Text, out ignorme))
                    {
                        contactno = Convert.ToInt32(txt_contactNo.Text);
                        if (this.type == 1)
                        {
                            insert(name, email, contactno, remark);
                        }
                        else if(this.type == 2)
                        {
                            update(name, email, contactno, remark);
                        }

                    }
                    else
                    {
                        popAlert("Entered contact no is invalid", Alert.enmType.Info);
                    }
                }
                else
                {
                    popAlert("Entered values are invalid", Alert.enmType.Info);
                }
            }  
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insert(string name, string email, int contactno, string remark)
        {
            try
            {
                string qry = "INSERT INTO supplier(Name, Email,Contact_No,Remark)" +
                    " VALUES('" + name + "','" + email + "'," + contactno+ ",'" +remark + "')";
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
        private void update(string name, string email, int contactno, string remark)
        {
            try
            {
                string qry = "UPDATE supplier SET Name='" + name + "',Email='" + email + "',Contact_No=" + contactno + " ,Remark='" + remark + "' WHERE Supplier_ID=" + this.sup_id + "";
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
