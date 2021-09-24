
namespace NeoLine_Computers
{
    partial class Form_AdminPanel
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AdminPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_stockIn = new System.Windows.Forms.Button();
            this.btn_Tables = new System.Windows.Forms.Button();
            this.pnl_active = new System.Windows.Forms.Panel();
            this.btn_users = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_w = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.stockInControl1 = new NeoLine_Computers.StockInControl();
            this.tableControl1 = new NeoLine_Computers.TableControl();
            this.usersControl1 = new NeoLine_Computers.UsersControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_stockIn);
            this.panel1.Controls.Add(this.btn_Tables);
            this.panel1.Controls.Add(this.pnl_active);
            this.panel1.Controls.Add(this.btn_users);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 882);
            this.panel1.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DimGray;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_back.Image = global::NeoLine_Computers.Properties.Resources.undo_48px;
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(12, 380);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(220, 54);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Back to Dashboard";
            this.btn_back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_stockIn
            // 
            this.btn_stockIn.BackColor = System.Drawing.Color.DimGray;
            this.btn_stockIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_stockIn.FlatAppearance.BorderSize = 0;
            this.btn_stockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stockIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stockIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_stockIn.Image = global::NeoLine_Computers.Properties.Resources.accounting_50px;
            this.btn_stockIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stockIn.Location = new System.Drawing.Point(12, 320);
            this.btn_stockIn.Name = "btn_stockIn";
            this.btn_stockIn.Size = new System.Drawing.Size(220, 54);
            this.btn_stockIn.TabIndex = 6;
            this.btn_stockIn.Text = "Stock In";
            this.btn_stockIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_stockIn.UseVisualStyleBackColor = false;
            this.btn_stockIn.Click += new System.EventHandler(this.btn_stockIn_Click);
            // 
            // btn_Tables
            // 
            this.btn_Tables.BackColor = System.Drawing.Color.DimGray;
            this.btn_Tables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Tables.FlatAppearance.BorderSize = 0;
            this.btn_Tables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tables.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tables.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Tables.Image = global::NeoLine_Computers.Properties.Resources.grid_50px;
            this.btn_Tables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Tables.Location = new System.Drawing.Point(12, 260);
            this.btn_Tables.Name = "btn_Tables";
            this.btn_Tables.Size = new System.Drawing.Size(220, 54);
            this.btn_Tables.TabIndex = 6;
            this.btn_Tables.Text = "Tables";
            this.btn_Tables.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Tables.UseVisualStyleBackColor = false;
            this.btn_Tables.Click += new System.EventHandler(this.btn_Tables_Click);
            // 
            // pnl_active
            // 
            this.pnl_active.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(133)))), ((int)(((byte)(242)))));
            this.pnl_active.Location = new System.Drawing.Point(0, 200);
            this.pnl_active.Name = "pnl_active";
            this.pnl_active.Size = new System.Drawing.Size(15, 54);
            this.pnl_active.TabIndex = 5;
            // 
            // btn_users
            // 
            this.btn_users.BackColor = System.Drawing.Color.DimGray;
            this.btn_users.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_users.FlatAppearance.BorderSize = 0;
            this.btn_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_users.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_users.Image = global::NeoLine_Computers.Properties.Resources.users_50px;
            this.btn_users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_users.Location = new System.Drawing.Point(12, 200);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(220, 54);
            this.btn_users.TabIndex = 4;
            this.btn_users.Text = "Users";
            this.btn_users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_users.UseVisualStyleBackColor = false;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NeoLine_Computers.Properties.Resources.Screenshot_91;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(133)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.lbl_w);
            this.panel2.Controls.Add(this.btn_minimize);
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(232, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1377, 46);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // lbl_w
            // 
            this.lbl_w.AutoSize = true;
            this.lbl_w.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_w.ForeColor = System.Drawing.Color.White;
            this.lbl_w.Location = new System.Drawing.Point(543, 9);
            this.lbl_w.Name = "lbl_w";
            this.lbl_w.Size = new System.Drawing.Size(160, 26);
            this.lbl_w.TabIndex = 3;
            this.lbl_w.Text = "Admin Panel";
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.BackgroundImage = global::NeoLine_Computers.Properties.Resources.minimize_window_48px;
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Location = new System.Drawing.Point(1299, 11);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_minimize.TabIndex = 4;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            this.btn_minimize.MouseHover += new System.EventHandler(this.btn_minimize_MouseHover);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::NeoLine_Computers.Properties.Resources.close;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(1335, 11);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 3;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.MouseHover += new System.EventHandler(this.btn_close_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(133)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(232, 844);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1377, 38);
            this.panel3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Helvetica Narrow", 11.16364F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(517, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Developed By Dakshina - 2021 ";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.stockInControl1);
            this.panel4.Controls.Add(this.tableControl1);
            this.panel4.Controls.Add(this.usersControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(232, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1377, 798);
            this.panel4.TabIndex = 3;
            // 
            // stockInControl1
            // 
            this.stockInControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockInControl1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockInControl1.Location = new System.Drawing.Point(0, 0);
            this.stockInControl1.Name = "stockInControl1";
            this.stockInControl1.Size = new System.Drawing.Size(1377, 798);
            this.stockInControl1.TabIndex = 2;
            // 
            // tableControl1
            // 
            this.tableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableControl1.Location = new System.Drawing.Point(0, 0);
            this.tableControl1.Name = "tableControl1";
            this.tableControl1.Size = new System.Drawing.Size(1377, 798);
            this.tableControl1.TabIndex = 1;
            // 
            // usersControl1
            // 
            this.usersControl1.AutoSize = true;
            this.usersControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersControl1.Location = new System.Drawing.Point(0, 0);
            this.usersControl1.Name = "usersControl1";
            this.usersControl1.Size = new System.Drawing.Size(1377, 798);
            this.usersControl1.TabIndex = 0;
            // 
            // Form_AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 882);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AdminPanel";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_w;
        private System.Windows.Forms.Panel pnl_active;
        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_stockIn;
        private System.Windows.Forms.Button btn_Tables;
        private System.Windows.Forms.Panel panel4;
        private UsersControl usersControl1;
        private TableControl tableControl1;
        private StockInControl stockInControl1;
    }
}