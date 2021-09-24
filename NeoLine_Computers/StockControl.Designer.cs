
namespace NeoLine_Computers
{
    partial class StockControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockControl));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clearsearch = new System.Windows.Forms.Button();
            this.dgv_Item = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_search = new Bunifu.UI.WinForms.BunifuTextBox();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            this.dgvI_catname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvI_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvI_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvI_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvI_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvI_warrantyperiod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock";
            // 
            // btn_clearsearch
            // 
            this.btn_clearsearch.BackColor = System.Drawing.Color.Silver;
            this.btn_clearsearch.FlatAppearance.BorderSize = 0;
            this.btn_clearsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearsearch.Location = new System.Drawing.Point(817, 97);
            this.btn_clearsearch.Name = "btn_clearsearch";
            this.btn_clearsearch.Size = new System.Drawing.Size(105, 36);
            this.btn_clearsearch.TabIndex = 10;
            this.btn_clearsearch.Text = "Clear";
            this.btn_clearsearch.UseVisualStyleBackColor = false;
            this.btn_clearsearch.Click += new System.EventHandler(this.btn_clearsearch_Click);
            // 
            // dgv_Item
            // 
            this.dgv_Item.AllowCustomTheming = false;
            this.dgv_Item.AllowUserToAddRows = false;
            this.dgv_Item.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dgv_Item.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Item.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Item.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Item.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Item.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Item.ColumnHeadersHeight = 40;
            this.dgv_Item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvI_catname,
            this.dgvI_name,
            this.dgvI_description,
            this.dgvI_stock,
            this.dgvI_price,
            this.dgvI_warrantyperiod});
            this.dgv_Item.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_Item.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_Item.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Item.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_Item.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_Item.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_Item.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_Item.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_Item.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_Item.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Item.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_Item.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Item.CurrentTheme.Name = null;
            this.dgv_Item.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Item.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_Item.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Item.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_Item.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Item.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Item.EnableHeadersVisualStyles = false;
            this.dgv_Item.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_Item.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_Item.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_Item.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Item.Location = new System.Drawing.Point(42, 143);
            this.dgv_Item.Name = "dgv_Item";
            this.dgv_Item.ReadOnly = true;
            this.dgv_Item.RowHeadersVisible = false;
            this.dgv_Item.RowHeadersWidth = 47;
            this.dgv_Item.RowTemplate.Height = 40;
            this.dgv_Item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Item.Size = new System.Drawing.Size(1293, 619);
            this.dgv_Item.TabIndex = 9;
            this.dgv_Item.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filter by:";
            // 
            // txt_search
            // 
            this.txt_search.AcceptsReturn = false;
            this.txt_search.AcceptsTab = false;
            this.txt_search.AnimationSpeed = 200;
            this.txt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_search.AutoSizeHeight = true;
            this.txt_search.BackColor = System.Drawing.Color.Transparent;
            this.txt_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_search.BackgroundImage")));
            this.txt_search.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_search.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_search.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_search.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_search.BorderRadius = 1;
            this.txt_search.BorderThickness = 1;
            this.txt_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_search.DefaultText = "";
            this.txt_search.FillColor = System.Drawing.Color.White;
            this.txt_search.HideSelection = true;
            this.txt_search.IconLeft = null;
            this.txt_search.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.IconPadding = 10;
            this.txt_search.IconRight = null;
            this.txt_search.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.Lines = new string[0];
            this.txt_search.Location = new System.Drawing.Point(512, 92);
            this.txt_search.MaxLength = 32767;
            this.txt_search.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_search.Modified = false;
            this.txt_search.Multiline = false;
            this.txt_search.Name = "txt_search";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_search.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_search.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_search.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_search.OnIdleState = stateProperties12;
            this.txt_search.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_search.PlaceholderText = "Enter a search text";
            this.txt_search.ReadOnly = false;
            this.txt_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_search.SelectedText = "";
            this.txt_search.SelectionLength = 0;
            this.txt_search.SelectionStart = 0;
            this.txt_search.ShortcutsEnabled = true;
            this.txt_search.Size = new System.Drawing.Size(284, 41);
            this.txt_search.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_search.TabIndex = 8;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_search.TextMarginBottom = 0;
            this.txt_search.TextMarginLeft = 3;
            this.txt_search.TextMarginTop = 1;
            this.txt_search.TextPlaceholder = "Enter a search text";
            this.txt_search.UseSystemPasswordChar = false;
            this.txt_search.WordWrap = true;
            this.txt_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyUp);
            // 
            // cmb_search
            // 
            this.cmb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Items.AddRange(new object[] {
            "Category",
            "Item"});
            this.cmb_search.Location = new System.Drawing.Point(254, 97);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(238, 30);
            this.cmb_search.TabIndex = 11;
            // 
            // dgvI_catname
            // 
            this.dgvI_catname.HeaderText = "Category Name";
            this.dgvI_catname.MinimumWidth = 6;
            this.dgvI_catname.Name = "dgvI_catname";
            this.dgvI_catname.ReadOnly = true;
            // 
            // dgvI_name
            // 
            this.dgvI_name.HeaderText = "Name";
            this.dgvI_name.MinimumWidth = 6;
            this.dgvI_name.Name = "dgvI_name";
            this.dgvI_name.ReadOnly = true;
            // 
            // dgvI_description
            // 
            this.dgvI_description.HeaderText = "Description";
            this.dgvI_description.MinimumWidth = 6;
            this.dgvI_description.Name = "dgvI_description";
            this.dgvI_description.ReadOnly = true;
            // 
            // dgvI_stock
            // 
            this.dgvI_stock.HeaderText = "Stock";
            this.dgvI_stock.MinimumWidth = 6;
            this.dgvI_stock.Name = "dgvI_stock";
            this.dgvI_stock.ReadOnly = true;
            // 
            // dgvI_price
            // 
            this.dgvI_price.HeaderText = "Price (Rs.)";
            this.dgvI_price.MinimumWidth = 6;
            this.dgvI_price.Name = "dgvI_price";
            this.dgvI_price.ReadOnly = true;
            // 
            // dgvI_warrantyperiod
            // 
            this.dgvI_warrantyperiod.HeaderText = "Warranty Period";
            this.dgvI_warrantyperiod.MinimumWidth = 6;
            this.dgvI_warrantyperiod.Name = "dgvI_warrantyperiod";
            this.dgvI_warrantyperiod.ReadOnly = true;
            // 
            // StockControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.cmb_search);
            this.Controls.Add(this.btn_clearsearch);
            this.Controls.Add(this.dgv_Item);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StockControl";
            this.Size = new System.Drawing.Size(1377, 791);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clearsearch;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvI_catname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvI_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvI_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvI_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvI_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvI_warrantyperiod;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox txt_search;
        private System.Windows.Forms.ComboBox cmb_search;
    }
}
