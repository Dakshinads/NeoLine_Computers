
namespace NeoLine_Computers
{
    partial class WarrantyCheckerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarrantyCheckerControl));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_list = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.lbl_time = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_date = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_contactNo = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_customerName = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txt_invoiceNo = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btn_search = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Clear = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvcol_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcol_war = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcol_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcol_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcol_dis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcol_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Warranty Checker";
            // 
            // dgv_list
            // 
            this.dgv_list.AllowCustomTheming = false;
            this.dgv_list.AllowUserToAddRows = false;
            this.dgv_list.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_list.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_list.ColumnHeadersHeight = 40;
            this.dgv_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcol_description,
            this.dgvcol_war,
            this.dgvcol_qty,
            this.dgvcol_price,
            this.dgvcol_dis,
            this.dgvcol_amount});
            this.dgv_list.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_list.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_list.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_list.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_list.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_list.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_list.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_list.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_list.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_list.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_list.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_list.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_list.CurrentTheme.Name = null;
            this.dgv_list.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_list.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_list.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_list.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_list.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_list.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_list.EnableHeadersVisualStyles = false;
            this.dgv_list.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_list.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_list.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_list.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_list.Location = new System.Drawing.Point(28, 284);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.ReadOnly = true;
            this.dgv_list.RowHeadersVisible = false;
            this.dgv_list.RowHeadersWidth = 47;
            this.dgv_list.RowTemplate.Height = 40;
            this.dgv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list.Size = new System.Drawing.Size(1321, 478);
            this.dgv_list.TabIndex = 4;
            this.dgv_list.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // lbl_time
            // 
            this.lbl_time.AllowParentOverrides = false;
            this.lbl_time.AutoEllipsis = false;
            this.lbl_time.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_time.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_time.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_time.Location = new System.Drawing.Point(171, 250);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_time.Size = new System.Drawing.Size(6, 20);
            this.lbl_time.TabIndex = 5;
            this.lbl_time.Text = "..";
            this.lbl_time.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_time.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_date
            // 
            this.lbl_date.AllowParentOverrides = false;
            this.lbl_date.AutoEllipsis = false;
            this.lbl_date.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_date.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_date.Location = new System.Drawing.Point(171, 224);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_date.Size = new System.Drawing.Size(6, 20);
            this.lbl_date.TabIndex = 6;
            this.lbl_date.Text = "..";
            this.lbl_date.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_date.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AllowParentOverrides = false;
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel7.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel7.Location = new System.Drawing.Point(28, 250);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(97, 20);
            this.bunifuLabel7.TabIndex = 7;
            this.bunifuLabel7.Text = "Invoice Time :";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel5.Location = new System.Drawing.Point(28, 224);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(95, 20);
            this.bunifuLabel5.TabIndex = 8;
            this.bunifuLabel5.Text = "Invoice Date :";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_contactNo
            // 
            this.lbl_contactNo.AllowParentOverrides = false;
            this.lbl_contactNo.AutoEllipsis = false;
            this.lbl_contactNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_contactNo.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_contactNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_contactNo.Location = new System.Drawing.Point(170, 205);
            this.lbl_contactNo.Name = "lbl_contactNo";
            this.lbl_contactNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_contactNo.Size = new System.Drawing.Size(6, 20);
            this.lbl_contactNo.TabIndex = 9;
            this.lbl_contactNo.Text = "..";
            this.lbl_contactNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_contactNo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_customerName
            // 
            this.lbl_customerName.AllowParentOverrides = false;
            this.lbl_customerName.AutoEllipsis = false;
            this.lbl_customerName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_customerName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_customerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_customerName.Location = new System.Drawing.Point(170, 179);
            this.lbl_customerName.Name = "lbl_customerName";
            this.lbl_customerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_customerName.Size = new System.Drawing.Size(6, 20);
            this.lbl_customerName.TabIndex = 10;
            this.lbl_customerName.Text = "..";
            this.lbl_customerName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_customerName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(381, 108);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(95, 25);
            this.bunifuLabel1.TabIndex = 8;
            this.bunifuLabel1.Text = "Invoice NO";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.Location = new System.Drawing.Point(28, 202);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(81, 20);
            this.bunifuLabel2.TabIndex = 8;
            this.bunifuLabel2.Text = "Contact NO";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txt_invoiceNo
            // 
            this.txt_invoiceNo.AcceptsReturn = false;
            this.txt_invoiceNo.AcceptsTab = false;
            this.txt_invoiceNo.AnimationSpeed = 200;
            this.txt_invoiceNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_invoiceNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_invoiceNo.AutoSizeHeight = true;
            this.txt_invoiceNo.BackColor = System.Drawing.Color.Transparent;
            this.txt_invoiceNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_invoiceNo.BackgroundImage")));
            this.txt_invoiceNo.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_invoiceNo.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_invoiceNo.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_invoiceNo.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_invoiceNo.BorderRadius = 1;
            this.txt_invoiceNo.BorderThickness = 1;
            this.txt_invoiceNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_invoiceNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_invoiceNo.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_invoiceNo.DefaultText = "";
            this.txt_invoiceNo.FillColor = System.Drawing.Color.White;
            this.txt_invoiceNo.HideSelection = true;
            this.txt_invoiceNo.IconLeft = null;
            this.txt_invoiceNo.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_invoiceNo.IconPadding = 10;
            this.txt_invoiceNo.IconRight = null;
            this.txt_invoiceNo.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_invoiceNo.Lines = new string[0];
            this.txt_invoiceNo.Location = new System.Drawing.Point(482, 100);
            this.txt_invoiceNo.MaxLength = 10;
            this.txt_invoiceNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_invoiceNo.Modified = false;
            this.txt_invoiceNo.Multiline = false;
            this.txt_invoiceNo.Name = "txt_invoiceNo";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_invoiceNo.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_invoiceNo.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_invoiceNo.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_invoiceNo.OnIdleState = stateProperties4;
            this.txt_invoiceNo.Padding = new System.Windows.Forms.Padding(3);
            this.txt_invoiceNo.PasswordChar = '\0';
            this.txt_invoiceNo.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_invoiceNo.PlaceholderText = "";
            this.txt_invoiceNo.ReadOnly = false;
            this.txt_invoiceNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_invoiceNo.SelectedText = "";
            this.txt_invoiceNo.SelectionLength = 0;
            this.txt_invoiceNo.SelectionStart = 0;
            this.txt_invoiceNo.ShortcutsEnabled = true;
            this.txt_invoiceNo.Size = new System.Drawing.Size(260, 41);
            this.txt_invoiceNo.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_invoiceNo.TabIndex = 11;
            this.txt_invoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_invoiceNo.TextMarginBottom = 0;
            this.txt_invoiceNo.TextMarginLeft = 3;
            this.txt_invoiceNo.TextMarginTop = 1;
            this.txt_invoiceNo.TextPlaceholder = "";
            this.txt_invoiceNo.UseSystemPasswordChar = false;
            this.txt_invoiceNo.WordWrap = true;
            // 
            // btn_search
            // 
            this.btn_search.AllowAnimations = true;
            this.btn_search.AllowMouseEffects = true;
            this.btn_search.AllowToggling = false;
            this.btn_search.AnimationSpeed = 200;
            this.btn_search.AutoGenerateColors = false;
            this.btn_search.AutoRoundBorders = false;
            this.btn_search.AutoSizeLeftIcon = true;
            this.btn_search.AutoSizeRightIcon = true;
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_search.ButtonText = "Search";
            this.btn_search.ButtonTextMarginLeft = 0;
            this.btn_search.ColorContrastOnClick = 45;
            this.btn_search.ColorContrastOnHover = 45;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_search.CustomizableEdges = borderEdges1;
            this.btn_search.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_search.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_search.DisabledFillColor = System.Drawing.Color.Empty;
            this.btn_search.DisabledForecolor = System.Drawing.Color.Empty;
            this.btn_search.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.IconLeft = null;
            this.btn_search.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_search.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_search.IconMarginLeft = 11;
            this.btn_search.IconPadding = 10;
            this.btn_search.IconRight = null;
            this.btn_search.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_search.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_search.IconSize = 25;
            this.btn_search.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn_search.IdleBorderRadius = 0;
            this.btn_search.IdleBorderThickness = 0;
            this.btn_search.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_search.IdleIconLeftImage = null;
            this.btn_search.IdleIconRightImage = null;
            this.btn_search.IndicateFocus = false;
            this.btn_search.Location = new System.Drawing.Point(763, 102);
            this.btn_search.Name = "btn_search";
            this.btn_search.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_search.OnDisabledState.BorderRadius = 1;
            this.btn_search.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_search.OnDisabledState.BorderThickness = 1;
            this.btn_search.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_search.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_search.OnDisabledState.IconLeftImage = null;
            this.btn_search.OnDisabledState.IconRightImage = null;
            this.btn_search.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_search.onHoverState.BorderRadius = 1;
            this.btn_search.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_search.onHoverState.BorderThickness = 1;
            this.btn_search.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_search.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_search.onHoverState.IconLeftImage = null;
            this.btn_search.onHoverState.IconRightImage = null;
            this.btn_search.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_search.OnIdleState.BorderRadius = 1;
            this.btn_search.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_search.OnIdleState.BorderThickness = 1;
            this.btn_search.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_search.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_search.OnIdleState.IconLeftImage = null;
            this.btn_search.OnIdleState.IconRightImage = null;
            this.btn_search.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_search.OnPressedState.BorderRadius = 1;
            this.btn_search.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_search.OnPressedState.BorderThickness = 1;
            this.btn_search.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_search.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_search.OnPressedState.IconLeftImage = null;
            this.btn_search.OnPressedState.IconRightImage = null;
            this.btn_search.Size = new System.Drawing.Size(150, 39);
            this.btn_search.TabIndex = 12;
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_search.TextMarginLeft = 0;
            this.btn_search.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_search.UseDefaultRadiusAndThickness = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.AllowAnimations = true;
            this.btn_Clear.AllowMouseEffects = true;
            this.btn_Clear.AllowToggling = false;
            this.btn_Clear.AnimationSpeed = 200;
            this.btn_Clear.AutoGenerateColors = false;
            this.btn_Clear.AutoRoundBorders = false;
            this.btn_Clear.AutoSizeLeftIcon = true;
            this.btn_Clear.AutoSizeRightIcon = true;
            this.btn_Clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_Clear.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_Clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Clear.BackgroundImage")));
            this.btn_Clear.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Clear.ButtonText = "Clear";
            this.btn_Clear.ButtonTextMarginLeft = 0;
            this.btn_Clear.ColorContrastOnClick = 45;
            this.btn_Clear.ColorContrastOnHover = 45;
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_Clear.CustomizableEdges = borderEdges2;
            this.btn_Clear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Clear.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Clear.DisabledFillColor = System.Drawing.Color.Empty;
            this.btn_Clear.DisabledForecolor = System.Drawing.Color.Empty;
            this.btn_Clear.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.IconLeft = null;
            this.btn_Clear.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clear.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Clear.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Clear.IconMarginLeft = 11;
            this.btn_Clear.IconPadding = 10;
            this.btn_Clear.IconRight = null;
            this.btn_Clear.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clear.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Clear.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Clear.IconSize = 25;
            this.btn_Clear.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn_Clear.IdleBorderRadius = 0;
            this.btn_Clear.IdleBorderThickness = 0;
            this.btn_Clear.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_Clear.IdleIconLeftImage = null;
            this.btn_Clear.IdleIconRightImage = null;
            this.btn_Clear.IndicateFocus = false;
            this.btn_Clear.Location = new System.Drawing.Point(933, 102);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Clear.OnDisabledState.BorderRadius = 1;
            this.btn_Clear.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Clear.OnDisabledState.BorderThickness = 1;
            this.btn_Clear.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Clear.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Clear.OnDisabledState.IconLeftImage = null;
            this.btn_Clear.OnDisabledState.IconRightImage = null;
            this.btn_Clear.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.btn_Clear.onHoverState.BorderRadius = 1;
            this.btn_Clear.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Clear.onHoverState.BorderThickness = 1;
            this.btn_Clear.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Clear.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.onHoverState.IconLeftImage = null;
            this.btn_Clear.onHoverState.IconRightImage = null;
            this.btn_Clear.OnIdleState.BorderColor = System.Drawing.Color.Gray;
            this.btn_Clear.OnIdleState.BorderRadius = 1;
            this.btn_Clear.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Clear.OnIdleState.BorderThickness = 1;
            this.btn_Clear.OnIdleState.FillColor = System.Drawing.Color.Gray;
            this.btn_Clear.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.OnIdleState.IconLeftImage = null;
            this.btn_Clear.OnIdleState.IconRightImage = null;
            this.btn_Clear.OnPressedState.BorderColor = System.Drawing.Color.Gray;
            this.btn_Clear.OnPressedState.BorderRadius = 1;
            this.btn_Clear.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Clear.OnPressedState.BorderThickness = 1;
            this.btn_Clear.OnPressedState.FillColor = System.Drawing.Color.Gray;
            this.btn_Clear.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.OnPressedState.IconLeftImage = null;
            this.btn_Clear.OnPressedState.IconRightImage = null;
            this.btn_Clear.Size = new System.Drawing.Size(150, 39);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Clear.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Clear.TextMarginLeft = 0;
            this.btn_Clear.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Clear.UseDefaultRadiusAndThickness = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel3.Location = new System.Drawing.Point(28, 179);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(114, 20);
            this.bunifuLabel3.TabIndex = 8;
            this.bunifuLabel3.Text = "Customer Name";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvcol_description
            // 
            this.dgvcol_description.HeaderText = "Description";
            this.dgvcol_description.MinimumWidth = 6;
            this.dgvcol_description.Name = "dgvcol_description";
            this.dgvcol_description.ReadOnly = true;
            // 
            // dgvcol_war
            // 
            this.dgvcol_war.HeaderText = "Warranty Period";
            this.dgvcol_war.MinimumWidth = 6;
            this.dgvcol_war.Name = "dgvcol_war";
            this.dgvcol_war.ReadOnly = true;
            // 
            // dgvcol_qty
            // 
            this.dgvcol_qty.HeaderText = "QTY";
            this.dgvcol_qty.MinimumWidth = 6;
            this.dgvcol_qty.Name = "dgvcol_qty";
            this.dgvcol_qty.ReadOnly = true;
            // 
            // dgvcol_price
            // 
            this.dgvcol_price.HeaderText = "Price (Rs.)";
            this.dgvcol_price.MinimumWidth = 6;
            this.dgvcol_price.Name = "dgvcol_price";
            this.dgvcol_price.ReadOnly = true;
            // 
            // dgvcol_dis
            // 
            this.dgvcol_dis.HeaderText = "Discount (Rs.)";
            this.dgvcol_dis.MinimumWidth = 6;
            this.dgvcol_dis.Name = "dgvcol_dis";
            this.dgvcol_dis.ReadOnly = true;
            // 
            // dgvcol_amount
            // 
            this.dgvcol_amount.HeaderText = "Amount (Rs.)";
            this.dgvcol_amount.MinimumWidth = 6;
            this.dgvcol_amount.Name = "dgvcol_amount";
            this.dgvcol_amount.ReadOnly = true;
            // 
            // WarrantyCheckerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_invoiceNo);
            this.Controls.Add(this.lbl_contactNo);
            this.Controls.Add(this.lbl_customerName);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.bunifuLabel7);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.dgv_list);
            this.Controls.Add(this.label1);
            this.Name = "WarrantyCheckerControl";
            this.Size = new System.Drawing.Size(1377, 791);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_list;
        private Bunifu.UI.WinForms.BunifuLabel lbl_time;
        private Bunifu.UI.WinForms.BunifuLabel lbl_date;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel lbl_contactNo;
        private Bunifu.UI.WinForms.BunifuLabel lbl_customerName;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuTextBox txt_invoiceNo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_search;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Clear;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcol_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcol_war;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcol_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcol_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcol_dis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcol_amount;
    }
}
