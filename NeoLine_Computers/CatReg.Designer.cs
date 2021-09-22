
namespace NeoLine_Computers
{
    partial class CatReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatReg));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_formname = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_name = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_description = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(657, 36);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // lbl_formname
            // 
            this.lbl_formname.AutoSize = true;
            this.lbl_formname.Font = new System.Drawing.Font("Century Gothic", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formname.Location = new System.Drawing.Point(19, 4);
            this.lbl_formname.Name = "lbl_formname";
            this.lbl_formname.Size = new System.Drawing.Size(72, 25);
            this.lbl_formname.TabIndex = 6;
            this.lbl_formname.Text = "name";
            this.lbl_formname.Click += new System.EventHandler(this.lbl_formname_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::NeoLine_Computers.Properties.Resources.close;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(621, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 5;
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
            this.txt_name.Location = new System.Drawing.Point(24, 106);
            this.txt_name.MaxLength = 30;
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
            this.label2.Location = new System.Drawing.Point(20, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 4;
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
            this.txt_description.Location = new System.Drawing.Point(24, 197);
            this.txt_description.MaxLength = 150;
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
            this.txt_description.Size = new System.Drawing.Size(611, 101);
            this.txt_description.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_description.TabIndex = 2;
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
            this.label4.Location = new System.Drawing.Point(20, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
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
            this.btn_action.Location = new System.Drawing.Point(216, 326);
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
            this.btn_action.TabIndex = 3;
            this.btn_action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_action.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_action.TextMarginLeft = 0;
            this.btn_action.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_action.UseDefaultRadiusAndThickness = true;
            this.btn_action.Click += new System.EventHandler(this.btn_action_Click);
            // 
            // CatReg
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(657, 382);
            this.Controls.Add(this.btn_action);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CatReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CatReg";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_formname;
        private Bunifu.UI.WinForms.BunifuTextBox txt_name;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox txt_description;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_action;
    }
}