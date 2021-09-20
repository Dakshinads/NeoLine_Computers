using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeoLine_Computers
{
    public partial class UsersControl : UserControl
    {
        MySqlConnection con;
        DBConnection dbConnect = new DBConnection();
        public UsersControl()
        {
            InitializeComponent();
            con = dbConnect.getConn();
            loadgrid();
        }

        public void popAlert(string msg, Alert.enmType type)
        {
            Alert al = new Alert();
            al.showAlert(msg, type);
        }

        public void loadgrid()
        {
            string query = "SELECT NIC, Name, DOB, Address, User_Role,Contact_No, Email, Username from user ";
            MySqlDataReader reader;
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                { 
                    dgv_users.Rows.Add(
                       reader["NIC"].ToString(),
                       reader["Name"].ToString(),
                       reader["DOB"].ToString(),
                       reader["Address"].ToString(),
                       reader["User_Role"].ToString(),
                       reader["Contact_No"].ToString(),
                       reader["Email"].ToString(),
                       reader["Username"].ToString()
                       );
                }
                DataGridViewButtonColumn btn_update = new DataGridViewButtonColumn();               
                dgv_users.Columns.Add(btn_update);
                btn_update.HeaderText = "";
                btn_update.Text = "Update";
                btn_update.Name = "btn_update";
                btn_update.FlatStyle = FlatStyle.Flat;
                btn_update.DefaultCellStyle.BackColor = Color.Yellow;
                btn_update.UseColumnTextForButtonValue = true;

                DataGridViewButtonColumn btn_delete = new DataGridViewButtonColumn();
                dgv_users.Columns.Add(btn_delete);
                btn_delete.HeaderText = "";
                btn_delete.Text = "Delete";
                btn_delete.Name = "btn_delete";
                btn_delete.FlatStyle = FlatStyle.Flat;
                btn_delete.DefaultCellStyle.BackColor = Color.Red;
                btn_delete.UseColumnTextForButtonValue = true;
            }
            else
            {
                popAlert("SQL Error", Alert.enmType.Info);
            }
            con.Close();
        }

        private void dgv_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                MessageBox.Show((e.RowIndex + 1) + " Row " + (e.ColumnIndex + 1) + " Column button clicked");
            }

            else if (e.ColumnIndex == 9)
            {
                MessageBox.Show((e.RowIndex + 1) + " Row " + (e.ColumnIndex + 1) + " Column button clicked");
            }
        }
    }
}
