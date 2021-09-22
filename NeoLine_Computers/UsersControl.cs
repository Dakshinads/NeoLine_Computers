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
            try
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
                    btn_update.UseColumnTextForButtonValue = true;

                    DataGridViewButtonColumn btn_delete = new DataGridViewButtonColumn();
                    dgv_users.Columns.Add(btn_delete);
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

        private void dgv_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                UserReg usrg=new UserReg(2,dgv_users.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    dgv_users.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    dgv_users.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    dgv_users.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    dgv_users.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    Convert.ToInt32(dgv_users.Rows[e.RowIndex].Cells[5].Value),
                    dgv_users.Rows[e.RowIndex].Cells[6].Value.ToString(),
                    dgv_users.Rows[e.RowIndex].Cells[7].Value.ToString()
                    );
                usrg.Show();

            }

            else if (e.ColumnIndex == 9)
            {
                ConfirmationPopup confirm = new ConfirmationPopup("Do you want to delete nic = "+dgv_users.Rows[e.RowIndex].Cells[0].Value.ToString()+" ?");
                DialogResult dr = confirm.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    delete(dgv_users.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
                confirm.Dispose();
                //MessageBox.Show((e.RowIndex + 1) + " Row " + (e.ColumnIndex + 1) + " Column button clicked");
            }
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            UserReg usrForm = new UserReg(1);
            usrForm.Show();

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refreshGrid();
        }

        public void delete(string nic)
        {
            try
            {
                string query = "DELETE FROM user WHERE nic='"+nic+"'";
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                }
                popAlert("Seccussfully Deleted", Alert.enmType.Delete);
                con.Close();
                refreshGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void refreshGrid()
        {
            dgv_users.Rows.Clear();
            dgv_users.Columns.RemoveAt(9);
            dgv_users.Columns.RemoveAt(8);
            loadgrid();
        }
    }
}
