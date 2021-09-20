
namespace NeoLine_Computers
{
    partial class UsersControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_users = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btn_addNew = new System.Windows.Forms.Button();
            this.dgvcol_nic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcol_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcol_dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcol_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcol_userrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcol_contactno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcol_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcol_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users";
            // 
            // dgv_users
            // 
            this.dgv_users.AllowCustomTheming = false;
            this.dgv_users.AllowUserToAddRows = false;
            this.dgv_users.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_users.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_users.ColumnHeadersHeight = 40;
            this.dgv_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcol_nic,
            this.dgvcol_name,
            this.dgvcol_dob,
            this.dgvcol_address,
            this.dgvcol_userrole,
            this.dgvcol_contactno,
            this.dgvcol_email,
            this.dgvcol_username});
            this.dgv_users.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_users.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_users.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_users.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_users.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_users.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_users.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_users.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_users.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_users.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_users.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_users.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_users.CurrentTheme.Name = null;
            this.dgv_users.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_users.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_users.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_users.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_users.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_users.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_users.EnableHeadersVisualStyles = false;
            this.dgv_users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_users.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_users.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_users.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_users.Location = new System.Drawing.Point(12, 78);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.ReadOnly = true;
            this.dgv_users.RowHeadersVisible = false;
            this.dgv_users.RowHeadersWidth = 47;
            this.dgv_users.RowTemplate.Height = 40;
            this.dgv_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_users.Size = new System.Drawing.Size(1351, 648);
            this.dgv_users.TabIndex = 1;
            this.dgv_users.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgv_users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_users_CellContentClick);
            // 
            // btn_addNew
            // 
            this.btn_addNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(132)))), ((int)(((byte)(232)))));
            this.btn_addNew.FlatAppearance.BorderSize = 0;
            this.btn_addNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNew.Location = new System.Drawing.Point(12, 745);
            this.btn_addNew.Name = "btn_addNew";
            this.btn_addNew.Size = new System.Drawing.Size(105, 36);
            this.btn_addNew.TabIndex = 2;
            this.btn_addNew.Text = "Add New";
            this.btn_addNew.UseVisualStyleBackColor = false;
            // 
            // dgvcol_nic
            // 
            this.dgvcol_nic.HeaderText = "NIC";
            this.dgvcol_nic.MinimumWidth = 6;
            this.dgvcol_nic.Name = "dgvcol_nic";
            this.dgvcol_nic.ReadOnly = true;
            // 
            // dgvcol_name
            // 
            this.dgvcol_name.HeaderText = "Name";
            this.dgvcol_name.MinimumWidth = 6;
            this.dgvcol_name.Name = "dgvcol_name";
            this.dgvcol_name.ReadOnly = true;
            // 
            // dgvcol_dob
            // 
            this.dgvcol_dob.HeaderText = "DOB";
            this.dgvcol_dob.MinimumWidth = 6;
            this.dgvcol_dob.Name = "dgvcol_dob";
            this.dgvcol_dob.ReadOnly = true;
            // 
            // dgvcol_address
            // 
            this.dgvcol_address.HeaderText = "Address";
            this.dgvcol_address.MinimumWidth = 6;
            this.dgvcol_address.Name = "dgvcol_address";
            this.dgvcol_address.ReadOnly = true;
            // 
            // dgvcol_userrole
            // 
            this.dgvcol_userrole.HeaderText = "User Role";
            this.dgvcol_userrole.MinimumWidth = 6;
            this.dgvcol_userrole.Name = "dgvcol_userrole";
            this.dgvcol_userrole.ReadOnly = true;
            // 
            // dgvcol_contactno
            // 
            this.dgvcol_contactno.HeaderText = "Contact No";
            this.dgvcol_contactno.MinimumWidth = 6;
            this.dgvcol_contactno.Name = "dgvcol_contactno";
            this.dgvcol_contactno.ReadOnly = true;
            // 
            // dgvcol_email
            // 
            this.dgvcol_email.HeaderText = "Email";
            this.dgvcol_email.MinimumWidth = 6;
            this.dgvcol_email.Name = "dgvcol_email";
            this.dgvcol_email.ReadOnly = true;
            // 
            // dgvcol_username
            // 
            this.dgvcol_username.HeaderText = "Username";
            this.dgvcol_username.MinimumWidth = 6;
            this.dgvcol_username.Name = "dgvcol_username";
            this.dgvcol_username.ReadOnly = true;
            // 
            // UsersControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.Controls.Add(this.btn_addNew);
            this.Controls.Add(this.dgv_users);
            this.Controls.Add(this.label1);
            this.Name = "UsersControl";
            this.Size = new System.Drawing.Size(1377, 798);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_users;
        private System.Windows.Forms.Button btn_addNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcol_nic;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcol_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcol_dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcol_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcol_userrole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcol_contactno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcol_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcol_username;
    }
}
