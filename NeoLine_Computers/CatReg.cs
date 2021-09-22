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
    public partial class CatReg : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private int type;
        MySqlConnection con;
        DBConnection dbConnect = new DBConnection();
        int id;

        // type 1 = save,  type 2 = update
        public CatReg(int type)
        {
            InitializeComponent();
            txt_name.Focus();
            con = dbConnect.getConn();

            if (type == 1)
            {
                lbl_formname.Text = "Category Registration";
                btn_action.Text = "Save";
                this.type = type;
            }
        }

        public CatReg(int type, int id,string name, string description)
        {
            InitializeComponent();
            con = dbConnect.getConn();
            lbl_formname.Text = "Update Category Details";
            btn_action.Text = "Update";
            this.type = type;

            txt_name.Text = name;
            txt_description.Text = description;
            this.id = id;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
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
            String name, description;
            try
            {
                if(txt_name.Text.Length>0 )
                {
                    name = txt_name.Text;
                    description = txt_description.Text;
                    if (this.type == 1)
                    {
                        insert(name, description);
                    }
                    else if(this.type == 2){
                        update(name, description);
                    }
                }
                else
                {
                    popAlert("Entered values are invalid ", Alert.enmType.Info);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insert(string name,string description)
        {
            try
            {
                string qry = "INSERT INTO category(Name, Description)" +
                    " VALUES('" + name + "','" + description + "')";
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

        private void update(string name, string description)
        {
            try
            {
                string qry = "UPDATE category SET Name='" + name + "',Description='" + description + "' WHERE Category_ID='" + this.id + "'";
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

        private void lbl_formname_Click(object sender, EventArgs e)
        {

        }
    }
}
