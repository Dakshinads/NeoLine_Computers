
namespace NeoLine_Computers
{
    partial class login_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.t = new System.Windows.Forms.Panel();
            this.txt_password = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txt_username = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.t.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.t);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 652);
            this.panel1.TabIndex = 10;
            // 
            // t
            // 
            this.t.BackColor = System.Drawing.Color.White;
            this.t.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("t.BackgroundImage")));
            this.t.Controls.Add(this.txt_password);
            this.t.Controls.Add(this.txt_username);
            this.t.Controls.Add(this.panel3);
            this.t.Controls.Add(this.btn_login);
            this.t.Controls.Add(this.checkBox1);
            this.t.Controls.Add(this.label7);
            this.t.Controls.Add(this.label4);
            this.t.Controls.Add(this.label5);
            this.t.Controls.Add(this.label6);
            this.t.Controls.Add(this.btn_exit);
            this.t.Dock = System.Windows.Forms.DockStyle.Left;
            this.t.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(0, 0);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(1020, 652);
            this.t.TabIndex = 10;
            this.t.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.t.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.t.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // txt_password
            // 
            this.txt_password.AcceptsReturn = false;
            this.txt_password.AcceptsTab = false;
            this.txt_password.AnimationSpeed = 200;
            this.txt_password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_password.AutoSizeHeight = true;
            this.txt_password.BackColor = System.Drawing.Color.Transparent;
            this.txt_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_password.BackgroundImage")));
            this.txt_password.BorderColorActive = System.Drawing.Color.Black;
            this.txt_password.BorderColorDisabled = System.Drawing.Color.Gray;
            this.txt_password.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_password.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_password.BorderRadius = 1;
            this.txt_password.BorderThickness = 1;
            this.txt_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_password.DefaultText = "";
            this.txt_password.FillColor = System.Drawing.Color.White;
            this.txt_password.HideSelection = true;
            this.txt_password.IconLeft = null;
            this.txt_password.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.IconPadding = 10;
            this.txt_password.IconRight = null;
            this.txt_password.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.Lines = new string[0];
            this.txt_password.Location = new System.Drawing.Point(670, 387);
            this.txt_password.MaxLength = 32767;
            this.txt_password.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_password.Modified = false;
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            stateProperties1.BorderColor = System.Drawing.Color.Black;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_password.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Gray;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_password.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_password.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_password.OnIdleState = stateProperties4;
            this.txt_password.Padding = new System.Windows.Forms.Padding(3);
            this.txt_password.PasswordChar = '*';
            this.txt_password.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_password.PlaceholderText = "";
            this.txt_password.ReadOnly = false;
            this.txt_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.ShortcutsEnabled = true;
            this.txt_password.Size = new System.Drawing.Size(293, 47);
            this.txt_password.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_password.TabIndex = 1;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.TextMarginBottom = 0;
            this.txt_password.TextMarginLeft = 3;
            this.txt_password.TextMarginTop = 1;
            this.txt_password.TextPlaceholder = "";
            this.txt_password.UseSystemPasswordChar = false;
            this.txt_password.WordWrap = true;
            // 
            // txt_username
            // 
            this.txt_username.AcceptsReturn = false;
            this.txt_username.AcceptsTab = false;
            this.txt_username.AnimationSpeed = 200;
            this.txt_username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_username.AutoSizeHeight = true;
            this.txt_username.BackColor = System.Drawing.Color.Transparent;
            this.txt_username.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_username.BackgroundImage")));
            this.txt_username.BorderColorActive = System.Drawing.Color.Black;
            this.txt_username.BorderColorDisabled = System.Drawing.Color.Gray;
            this.txt_username.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_username.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_username.BorderRadius = 1;
            this.txt_username.BorderThickness = 1;
            this.txt_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.DefaultFont = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_username.DefaultText = "";
            this.txt_username.FillColor = System.Drawing.Color.White;
            this.txt_username.HideSelection = true;
            this.txt_username.IconLeft = null;
            this.txt_username.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.IconPadding = 10;
            this.txt_username.IconRight = null;
            this.txt_username.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.Lines = new string[0];
            this.txt_username.Location = new System.Drawing.Point(670, 300);
            this.txt_username.MaxLength = 32767;
            this.txt_username.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_username.Modified = false;
            this.txt_username.Multiline = false;
            this.txt_username.Name = "txt_username";
            stateProperties5.BorderColor = System.Drawing.Color.Black;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_username.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Gray;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_username.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_username.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_username.OnIdleState = stateProperties8;
            this.txt_username.Padding = new System.Windows.Forms.Padding(3);
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_username.PlaceholderText = "";
            this.txt_username.ReadOnly = false;
            this.txt_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_username.SelectedText = "";
            this.txt_username.SelectionLength = 0;
            this.txt_username.SelectionStart = 0;
            this.txt_username.ShortcutsEnabled = true;
            this.txt_username.Size = new System.Drawing.Size(293, 47);
            this.txt_username.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_username.TabIndex = 0;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_username.TextMarginBottom = 0;
            this.txt_username.TextMarginLeft = 3;
            this.txt_username.TextMarginTop = 1;
            this.txt_username.TextPlaceholder = "";
            this.txt_username.UseSystemPasswordChar = false;
            this.txt_username.WordWrap = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(770, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(112, 100);
            this.panel3.TabIndex = 6;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(133)))), ((int)(((byte)(242)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 12.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.Location = new System.Drawing.Point(670, 489);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(293, 41);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "LOG IN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(670, 432);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(145, 25);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(133)))), ((int)(((byte)(242)))));
            this.label7.Location = new System.Drawing.Point(665, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(133)))), ((int)(((byte)(242)))));
            this.label4.Location = new System.Drawing.Point(665, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24.87273F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(133)))), ((int)(((byte)(242)))));
            this.label5.Location = new System.Drawing.Point(762, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 49);
            this.label5.TabIndex = 1;
            this.label5.Text = "Log In";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Helvetica Narrow", 11.16364F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(142, 623);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Developed By Dakshina - 2021 ";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(968, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 36);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(133)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(665, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 25.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(133)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(762, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Log In";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Helvetica Narrow", 11.16364F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 623);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Developed By Dakshina - 2021 ";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(968, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(40, 36);
            this.btn_close.TabIndex = 10;
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 652);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.Shown += new System.EventHandler(this.login_form_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.t.ResumeLayout(false);
            this.t.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel t;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_login;
        private Bunifu.UI.WinForms.BunifuTextBox txt_username;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuTextBox txt_password;
    }
}

