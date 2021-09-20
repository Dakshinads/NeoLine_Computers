
namespace NeoLine_Computers
{
    partial class Form_Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_active = new System.Windows.Forms.Panel();
            this.btn_adminPanel = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_warrantyChecker = new System.Windows.Forms.Button();
            this.btn_bill = new System.Windows.Forms.Button();
            this.btn_stock = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_profileSetting = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(116)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.pnl_active);
            this.panel1.Controls.Add(this.btn_adminPanel);
            this.panel1.Controls.Add(this.btn_report);
            this.panel1.Controls.Add(this.btn_warrantyChecker);
            this.panel1.Controls.Add(this.btn_bill);
            this.panel1.Controls.Add(this.btn_stock);
            this.panel1.Controls.Add(this.btn_dashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 882);
            this.panel1.TabIndex = 0;
            // 
            // pnl_active
            // 
            this.pnl_active.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(133)))), ((int)(((byte)(242)))));
            this.pnl_active.Location = new System.Drawing.Point(0, 199);
            this.pnl_active.Name = "pnl_active";
            this.pnl_active.Size = new System.Drawing.Size(15, 54);
            this.pnl_active.TabIndex = 3;
            // 
            // btn_adminPanel
            // 
            this.btn_adminPanel.BackColor = System.Drawing.Color.DimGray;
            this.btn_adminPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adminPanel.FlatAppearance.BorderSize = 0;
            this.btn_adminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adminPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adminPanel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_adminPanel.Image = global::NeoLine_Computers.Properties.Resources.administrative_tools_50px;
            this.btn_adminPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_adminPanel.Location = new System.Drawing.Point(12, 498);
            this.btn_adminPanel.Name = "btn_adminPanel";
            this.btn_adminPanel.Size = new System.Drawing.Size(220, 54);
            this.btn_adminPanel.TabIndex = 1;
            this.btn_adminPanel.Text = "Admin Panel";
            this.btn_adminPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_adminPanel.UseVisualStyleBackColor = false;
            this.btn_adminPanel.Click += new System.EventHandler(this.btn_adminPanel_Click);
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.DimGray;
            this.btn_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_report.FlatAppearance.BorderSize = 0;
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_report.Image = global::NeoLine_Computers.Properties.Resources.report_file_50px;
            this.btn_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_report.Location = new System.Drawing.Point(12, 438);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(220, 54);
            this.btn_report.TabIndex = 1;
            this.btn_report.Text = "Report";
            this.btn_report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_warrantyChecker
            // 
            this.btn_warrantyChecker.BackColor = System.Drawing.Color.DimGray;
            this.btn_warrantyChecker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_warrantyChecker.FlatAppearance.BorderSize = 0;
            this.btn_warrantyChecker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_warrantyChecker.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_warrantyChecker.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_warrantyChecker.Image = global::NeoLine_Computers.Properties.Resources.warranty_50px;
            this.btn_warrantyChecker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_warrantyChecker.Location = new System.Drawing.Point(12, 378);
            this.btn_warrantyChecker.Name = "btn_warrantyChecker";
            this.btn_warrantyChecker.Size = new System.Drawing.Size(220, 54);
            this.btn_warrantyChecker.TabIndex = 1;
            this.btn_warrantyChecker.Text = "Warranty Checker";
            this.btn_warrantyChecker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_warrantyChecker.UseVisualStyleBackColor = false;
            this.btn_warrantyChecker.Click += new System.EventHandler(this.btn_warrantyChecker_Click);
            // 
            // btn_bill
            // 
            this.btn_bill.BackColor = System.Drawing.Color.DimGray;
            this.btn_bill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_bill.FlatAppearance.BorderSize = 0;
            this.btn_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bill.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_bill.Image = global::NeoLine_Computers.Properties.Resources.bill_50px;
            this.btn_bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bill.Location = new System.Drawing.Point(12, 318);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Size = new System.Drawing.Size(220, 54);
            this.btn_bill.TabIndex = 1;
            this.btn_bill.Text = "Bill";
            this.btn_bill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_bill.UseVisualStyleBackColor = false;
            this.btn_bill.Click += new System.EventHandler(this.btn_bill_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.BackColor = System.Drawing.Color.DimGray;
            this.btn_stock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_stock.FlatAppearance.BorderSize = 0;
            this.btn_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_stock.Image = global::NeoLine_Computers.Properties.Resources.scan_stock_50px;
            this.btn_stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stock.Location = new System.Drawing.Point(12, 258);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(220, 54);
            this.btn_stock.TabIndex = 1;
            this.btn_stock.Text = "Stock";
            this.btn_stock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_stock.UseVisualStyleBackColor = false;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.DimGray;
            this.btn_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_dashboard.Image = global::NeoLine_Computers.Properties.Resources.dashboard_50px;
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(12, 200);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(220, 54);
            this.btn_dashboard.TabIndex = 1;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NeoLine_Computers.Properties.Resources.Screenshot_91;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(133)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.btn_profileSetting);
            this.panel2.Controls.Add(this.btn_minimize);
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Controls.Add(this.lbl_welcome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(232, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1377, 53);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // btn_profileSetting
            // 
            this.btn_profileSetting.BackColor = System.Drawing.Color.Transparent;
            this.btn_profileSetting.BackgroundImage = global::NeoLine_Computers.Properties.Resources.settings_48px;
            this.btn_profileSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_profileSetting.FlatAppearance.BorderSize = 0;
            this.btn_profileSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profileSetting.Location = new System.Drawing.Point(145, 6);
            this.btn_profileSetting.Name = "btn_profileSetting";
            this.btn_profileSetting.Size = new System.Drawing.Size(40, 40);
            this.btn_profileSetting.TabIndex = 2;
            this.btn_profileSetting.UseVisualStyleBackColor = false;
            this.btn_profileSetting.MouseHover += new System.EventHandler(this.btn_profileSetting_MouseHover);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.BackgroundImage = global::NeoLine_Computers.Properties.Resources.minimize_window_48px;
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Location = new System.Drawing.Point(1301, 12);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_minimize.TabIndex = 2;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            this.btn_minimize.MouseHover += new System.EventHandler(this.btn_minimize_MouseHover);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::NeoLine_Computers.Properties.Resources.logout_rounded_up_60px;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(1337, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 1;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.button1_Click);
            this.btn_close.MouseHover += new System.EventHandler(this.btn_close_MouseHover);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.White;
            this.lbl_welcome.Location = new System.Drawing.Point(14, 15);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(125, 26);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome";
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
            this.label6.Location = new System.Drawing.Point(494, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Developed By Dakshina - 2021 ";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(232, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1377, 791);
            this.panel4.TabIndex = 3;
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1609, 882);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Dashboard";
            this.Load += new System.EventHandler(this.Form_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_warrantyChecker;
        private System.Windows.Forms.Button btn_bill;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.Button btn_adminPanel;
        private System.Windows.Forms.Button btn_profileSetting;
        private System.Windows.Forms.Panel pnl_active;
        private System.Windows.Forms.Panel panel4;
    }
}