
namespace NeoLine_Computers
{
    partial class ItemReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemReg));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_formname = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_name = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_description = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_price = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_warrantyPeriod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_categoryName = new System.Windows.Forms.ComboBox();
            this.btn_action = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(133)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.lbl_formname);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 42);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // lbl_formname
            // 
            this.lbl_formname.AutoSize = true;
            this.lbl_formname.Font = new System.Drawing.Font("Century Gothic", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formname.Location = new System.Drawing.Point(18, 9);
            this.lbl_formname.Name = "lbl_formname";
            this.lbl_formname.Size = new System.Drawing.Size(72, 25);
            this.lbl_formname.TabIndex = 6;
            this.lbl_formname.Text = "name";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::NeoLine_Computers.Properties.Resources.close;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(617, 8);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 6;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_name
            // 
            this.txt_name.AcceptsReturn = false;
            this.txt_name.AcceptsTab = false;
            this.txt_name.AnimationSpeed = 200;
            this.txt_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_name.AutoSizeHeight = true;
            this.txt_name.BackColor = System.Drawing.Color.White;
            this.txt_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_name.BackgroundImage")));
            this.txt_name.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_name.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_name.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_name.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_name.BorderRadius = 1;
            this.txt_name.BorderThickness = 1;
            this.txt_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_name.DefaultText = "";
            this.txt_name.FillColor = System.Drawing.Color.White;
            this.txt_name.HideSelection = true;
            this.txt_name.IconLeft = null;
            this.txt_name.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.IconPadding = 10;
            this.txt_name.IconRight = null;
            this.txt_name.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.Lines = new string[0];
            this.txt_name.Location = new System.Drawing.Point(23, 112);
            this.txt_name.MaxLength = 50;
            this.txt_name.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_name.Modified = false;
            this.txt_name.Multiline = false;
            this.txt_name.Name = "txt_name";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_name.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_name.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_name.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_name.OnIdleState = stateProperties4;
            this.txt_name.Padding = new System.Windows.Forms.Padding(3);
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_name.PlaceholderText = "";
            this.txt_name.ReadOnly = false;
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(260, 41);
            this.txt_name.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_name.TabIndex = 1;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_name.TextMarginBottom = 0;
            this.txt_name.TextMarginLeft = 3;
            this.txt_name.TextMarginTop = 1;
            this.txt_name.TextPlaceholder = "";
            this.txt_name.UseSystemPasswordChar = false;
            this.txt_name.WordWrap = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // txt_description
            // 
            this.txt_description.AcceptsReturn = false;
            this.txt_description.AcceptsTab = false;
            this.txt_description.AnimationSpeed = 200;
            this.txt_description.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_description.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_description.AutoSizeHeight = true;
            this.txt_description.BackColor = System.Drawing.Color.White;
            this.txt_description.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_description.BackgroundImage")));
            this.txt_description.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_description.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_description.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_description.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_description.BorderRadius = 1;
            this.txt_description.BorderThickness = 1;
            this.txt_description.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_description.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_description.DefaultText = "";
            this.txt_description.FillColor = System.Drawing.Color.White;
            this.txt_description.HideSelection = true;
            this.txt_description.IconLeft = null;
            this.txt_description.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_description.IconPadding = 10;
            this.txt_description.IconRight = null;
            this.txt_description.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_description.Lines = new string[0];
            this.txt_description.Location = new System.Drawing.Point(23, 200);
            this.txt_description.MaxLength = 400;
            this.txt_description.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_description.Modified = false;
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_description.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_description.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_description.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_description.OnIdleState = stateProperties8;
            this.txt_description.Padding = new System.Windows.Forms.Padding(3);
            this.txt_description.PasswordChar = '\0';
            this.txt_description.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_description.PlaceholderText = "";
            this.txt_description.ReadOnly = false;
            this.txt_description.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_description.SelectedText = "";
            this.txt_description.SelectionLength = 0;
            this.txt_description.SelectionStart = 0;
            this.txt_description.ShortcutsEnabled = true;
            this.txt_description.Size = new System.Drawing.Size(611, 256);
            this.txt_description.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_description.TabIndex = 3;
            this.txt_description.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_description.TextMarginBottom = 0;
            this.txt_description.TextMarginLeft = 3;
            this.txt_description.TextMarginTop = 1;
            this.txt_description.TextPlaceholder = "";
            this.txt_description.UseSystemPasswordChar = false;
            this.txt_description.WordWrap = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Price";
            // 
            // txt_price
            // 
            this.txt_price.AcceptsReturn = false;
            this.txt_price.AcceptsTab = false;
            this.txt_price.AnimationSpeed = 200;
            this.txt_price.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_price.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_price.AutoSizeHeight = true;
            this.txt_price.BackColor = System.Drawing.Color.White;
            this.txt_price.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_price.BackgroundImage")));
            this.txt_price.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_price.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_price.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_price.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_price.BorderRadius = 1;
            this.txt_price.BorderThickness = 1;
            this.txt_price.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_price.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_price.DefaultText = "";
            this.txt_price.FillColor = System.Drawing.Color.White;
            this.txt_price.HideSelection = true;
            this.txt_price.IconLeft = null;
            this.txt_price.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_price.IconPadding = 10;
            this.txt_price.IconRight = null;
            this.txt_price.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_price.Lines = new string[0];
            this.txt_price.Location = new System.Drawing.Point(23, 506);
            this.txt_price.MaxLength = 6;
            this.txt_price.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_price.Modified = false;
            this.txt_price.Multiline = false;
            this.txt_price.Name = "txt_price";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_price.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_price.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_price.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_price.OnIdleState = stateProperties12;
            this.txt_price.Padding = new System.Windows.Forms.Padding(3);
            this.txt_price.PasswordChar = '\0';
            this.txt_price.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_price.PlaceholderText = "";
            this.txt_price.ReadOnly = false;
            this.txt_price.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_price.SelectedText = "";
            this.txt_price.SelectionLength = 0;
            this.txt_price.SelectionStart = 0;
            this.txt_price.ShortcutsEnabled = true;
            this.txt_price.Size = new System.Drawing.Size(260, 41);
            this.txt_price.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_price.TabIndex = 4;
            this.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_price.TextMarginBottom = 0;
            this.txt_price.TextMarginLeft = 3;
            this.txt_price.TextMarginTop = 1;
            this.txt_price.TextPlaceholder = "";
            this.txt_price.UseSystemPasswordChar = false;
            this.txt_price.WordWrap = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Warranty Period";
            // 
            // cmb_warrantyPeriod
            // 
            this.cmb_warrantyPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_warrantyPeriod.FormattingEnabled = true;
            this.cmb_warrantyPeriod.ItemHeight = 20;
            this.cmb_warrantyPeriod.Items.AddRange(new object[] {
            "No Warranty",
            "03 Months",
            "06 Months",
            "01 Year",
            "02 Years",
            "03 Years",
            "05 Years"});
            this.cmb_warrantyPeriod.Location = new System.Drawing.Point(351, 509);
            this.cmb_warrantyPeriod.Name = "cmb_warrantyPeriod";
            this.cmb_warrantyPeriod.Size = new System.Drawing.Size(282, 28);
            this.cmb_warrantyPeriod.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Category Name";
            // 
            // cmb_categoryName
            // 
            this.cmb_categoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categoryName.FormattingEnabled = true;
            this.cmb_categoryName.ItemHeight = 20;
            this.cmb_categoryName.Items.AddRange(new object[] {
            "No Warranty",
            "03 Months",
            "06 Months",
            "01 Year",
            "02 Years",
            "03 Years",
            "05 Years"});
            this.cmb_categoryName.Location = new System.Drawing.Point(351, 116);
            this.cmb_categoryName.Name = "cmb_categoryName";
            this.cmb_categoryName.Size = new System.Drawing.Size(282, 28);
            this.cmb_categoryName.TabIndex = 2;
            this.cmb_categoryName.SelectedIndexChanged += new System.EventHandler(this.cmb_categoryName_SelectedIndexChanged);
            // 
            // btn_action
            // 
            this.btn_action.AllowAnimations = true;
            this.btn_action.AllowMouseEffects = true;
            this.btn_action.AllowToggling = false;
            this.btn_action.AnimationSpeed = 200;
            this.btn_action.AutoGenerateColors = false;
            this.btn_action.AutoRoundBorders = false;
            this.btn_action.AutoSizeLeftIcon = true;
            this.btn_action.AutoSizeRightIcon = true;
            this.btn_action.BackColor = System.Drawing.Color.Transparent;
            this.btn_action.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_action.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_action.BackgroundImage")));
            this.btn_action.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_action.ButtonText = "Save ";
            this.btn_action.ButtonTextMarginLeft = 0;
            this.btn_action.ColorContrastOnClick = 45;
            this.btn_action.ColorContrastOnHover = 45;
            this.btn_action.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_action.CustomizableEdges = borderEdges1;
            this.btn_action.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_action.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_action.DisabledFillColor = System.Drawing.Color.Empty;
            this.btn_action.DisabledForecolor = System.Drawing.Color.Empty;
            this.btn_action.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_action.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_action.ForeColor = System.Drawing.Color.White;
            this.btn_action.IconLeft = null;
            this.btn_action.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_action.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_action.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_action.IconMarginLeft = 11;
            this.btn_action.IconPadding = 10;
            this.btn_action.IconRight = null;
            this.btn_action.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_action.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_action.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_action.IconSize = 25;
            this.btn_action.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn_action.IdleBorderRadius = 0;
            this.btn_action.IdleBorderThickness = 0;
            this.btn_action.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_action.IdleIconLeftImage = null;
            this.btn_action.IdleIconRightImage = null;
            this.btn_action.IndicateFocus = false;
            this.btn_action.Location = new System.Drawing.Point(217, 574);
            this.btn_action.Name = "btn_action";
            this.btn_action.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_action.OnDisabledState.BorderRadius = 1;
            this.btn_action.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_action.OnDisabledState.BorderThickness = 1;
            this.btn_action.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_action.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_action.OnDisabledState.IconLeftImage = null;
            this.btn_action.OnDisabledState.IconRightImage = null;
            this.btn_action.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_action.onHoverState.BorderRadius = 1;
            this.btn_action.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_action.onHoverState.BorderThickness = 1;
            this.btn_action.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_action.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_action.onHoverState.IconLeftImage = null;
            this.btn_action.onHoverState.IconRightImage = null;
            this.btn_action.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_action.OnIdleState.BorderRadius = 1;
            this.btn_action.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_action.OnIdleState.BorderThickness = 1;
            this.btn_action.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_action.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_action.OnIdleState.IconLeftImage = null;
            this.btn_action.OnIdleState.IconRightImage = null;
            this.btn_action.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_action.OnPressedState.BorderRadius = 1;
            this.btn_action.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_action.OnPressedState.BorderThickness = 1;
            this.btn_action.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_action.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_action.OnPressedState.IconLeftImage = null;
            this.btn_action.OnPressedState.IconRightImage = null;
            this.btn_action.Size = new System.Drawing.Size(201, 44);
            this.btn_action.TabIndex = 6;
            this.btn_action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_action.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_action.TextMarginLeft = 0;
            this.btn_action.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_action.UseDefaultRadiusAndThickness = true;
            this.btn_action.Click += new System.EventHandler(this.btn_action_Click);
            // 
            // ItemReg
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(656, 643);
            this.Controls.Add(this.btn_action);
            this.Controls.Add(this.cmb_categoryName);
            this.Controls.Add(this.cmb_warrantyPeriod);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemReg";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private Bunifu.UI.WinForms.BunifuTextBox txt_name;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox txt_description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_formname;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox txt_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_warrantyPeriod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_categoryName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_action;
    }
}