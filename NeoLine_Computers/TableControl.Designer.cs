
namespace NeoLine_Computers
{
    partial class TableControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableControl));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Category = new System.Windows.Forms.TabPage();
            this.btn_refreshC = new System.Windows.Forms.Button();
            this.btn_addNewC = new System.Windows.Forms.Button();
            this.dgv_Category = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dgvC_catid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvC_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvC_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Item = new System.Windows.Forms.TabPage();
            this.btn_refereshI = new System.Windows.Forms.Button();
            this.btn_clearsearch = new System.Windows.Forms.Button();
            this.btn_addNewI = new System.Windows.Forms.Button();
            this.dgv_Item = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dgvI_itemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvI_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvI_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvI_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvI_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvI_warrantyperiod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvI_catname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_search = new Bunifu.UI.WinForms.BunifuTextBox();
            this.tab_Supplier = new System.Windows.Forms.TabPage();
            this.btn_refreshS = new System.Windows.Forms.Button();
            this.btn_addNewS = new System.Windows.Forms.Button();
            this.dgv_supplier = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dgvs_supplierid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvs_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvs_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvs_contactno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvs_remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tab_Category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).BeginInit();
            this.tab_Item.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Item)).BeginInit();
            this.tab_Supplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tables";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Category);
            this.tabControl1.Controls.Add(this.tab_Item);
            this.tabControl1.Controls.Add(this.tab_Supplier);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(23, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1341, 715);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tab_Category
            // 
            this.tab_Category.Controls.Add(this.btn_refreshC);
            this.tab_Category.Controls.Add(this.btn_addNewC);
            this.tab_Category.Controls.Add(this.dgv_Category);
            this.tab_Category.Font = new System.Drawing.Font("Century Gothic", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Category.Location = new System.Drawing.Point(4, 31);
            this.tab_Category.Name = "tab_Category";
            this.tab_Category.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Category.Size = new System.Drawing.Size(1333, 680);
            this.tab_Category.TabIndex = 0;
            this.tab_Category.Text = "Category";
            this.tab_Category.UseVisualStyleBackColor = true;
            // 
            // btn_refreshC
            // 
            this.btn_refreshC.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_refreshC.BackgroundImage = global::NeoLine_Computers.Properties.Resources.update1;
            this.btn_refreshC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refreshC.FlatAppearance.BorderSize = 0;
            this.btn_refreshC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refreshC.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_refreshC.Location = new System.Drawing.Point(147, 636);
            this.btn_refreshC.Name = "btn_refreshC";
            this.btn_refreshC.Size = new System.Drawing.Size(30, 30);
            this.btn_refreshC.TabIndex = 5;
            this.btn_refreshC.UseVisualStyleBackColor = false;
            this.btn_refreshC.Click += new System.EventHandler(this.btn_refreshC_Click);
            this.btn_refreshC.MouseHover += new System.EventHandler(this.btn_refreshC_MouseHover);
            // 
            // btn_addNewC
            // 
            this.btn_addNewC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(132)))), ((int)(((byte)(232)))));
            this.btn_addNewC.FlatAppearance.BorderSize = 0;
            this.btn_addNewC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addNewC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNewC.Location = new System.Drawing.Point(22, 632);
            this.btn_addNewC.Name = "btn_addNewC";
            this.btn_addNewC.Size = new System.Drawing.Size(105, 36);
            this.btn_addNewC.TabIndex = 4;
            this.btn_addNewC.Text = "Add New";
            this.btn_addNewC.UseVisualStyleBackColor = false;
            this.btn_addNewC.Click += new System.EventHandler(this.btn_addNewC_Click);
            // 
            // dgv_Category
            // 
            this.dgv_Category.AllowCustomTheming = false;
            this.dgv_Category.AllowUserToAddRows = false;
            this.dgv_Category.AllowUserToDeleteRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            this.dgv_Category.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgv_Category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Category.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Category.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgv_Category.ColumnHeadersHeight = 40;
            this.dgv_Category.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvC_catid,
            this.dgvC_name,
            this.dgvC_description});
            this.dgv_Category.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_Category.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_Category.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Category.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_Category.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_Category.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_Category.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_Category.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_Category.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_Category.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Category.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_Category.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Category.CurrentTheme.Name = null;
            this.dgv_Category.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Category.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_Category.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Category.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_Category.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Category.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgv_Category.EnableHeadersVisualStyles = false;
            this.dgv_Category.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_Category.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_Category.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_Category.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Category.Location = new System.Drawing.Point(22, 32);
            this.dgv_Category.Name = "dgv_Category";
            this.dgv_Category.ReadOnly = true;
            this.dgv_Category.RowHeadersVisible = false;
            this.dgv_Category.RowHeadersWidth = 47;
            this.dgv_Category.RowTemplate.Height = 40;
            this.dgv_Category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Category.Size = new System.Drawing.Size(1293, 592);
            this.dgv_Category.TabIndex = 0;
            this.dgv_Category.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgv_Category.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Category_CellContentClick);
            // 
            // dgvC_catid
            // 
            this.dgvC_catid.HeaderText = "Category ID";
            this.dgvC_catid.MinimumWidth = 6;
            this.dgvC_catid.Name = "dgvC_catid";
            this.dgvC_catid.ReadOnly = true;
            // 
            // dgvC_name
            // 
            this.dgvC_name.HeaderText = "Name";
            this.dgvC_name.MinimumWidth = 6;
            this.dgvC_name.Name = "dgvC_name";
            this.dgvC_name.ReadOnly = true;
            // 
            // dgvC_description
            // 
            this.dgvC_description.HeaderText = "Description";
            this.dgvC_description.MinimumWidth = 6;
            this.dgvC_description.Name = "dgvC_description";
            this.dgvC_description.ReadOnly = true;
            // 
            // tab_Item
            // 
            this.tab_Item.Controls.Add(this.btn_refereshI);
            this.tab_Item.Controls.Add(this.btn_clearsearch);
            this.tab_Item.Controls.Add(this.btn_addNewI);
            this.tab_Item.Controls.Add(this.dgv_Item);
            this.tab_Item.Controls.Add(this.label2);
            this.tab_Item.Controls.Add(this.txt_search);
            this.tab_Item.Location = new System.Drawing.Point(4, 31);
            this.tab_Item.Name = "tab_Item";
            this.tab_Item.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Item.Size = new System.Drawing.Size(1333, 680);
            this.tab_Item.TabIndex = 1;
            this.tab_Item.Text = "Item";
            this.tab_Item.UseVisualStyleBackColor = true;
            // 
            // btn_refereshI
            // 
            this.btn_refereshI.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_refereshI.BackgroundImage = global::NeoLine_Computers.Properties.Resources.update1;
            this.btn_refereshI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refereshI.FlatAppearance.BorderSize = 0;
            this.btn_refereshI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refereshI.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_refereshI.Location = new System.Drawing.Point(145, 635);
            this.btn_refereshI.Name = "btn_refereshI";
            this.btn_refereshI.Size = new System.Drawing.Size(30, 30);
            this.btn_refereshI.TabIndex = 7;
            this.btn_refereshI.UseVisualStyleBackColor = false;
            this.btn_refereshI.Click += new System.EventHandler(this.btn_refereshI_Click);
            this.btn_refereshI.MouseHover += new System.EventHandler(this.btn_refereshI_MouseHover);
            // 
            // btn_clearsearch
            // 
            this.btn_clearsearch.BackColor = System.Drawing.Color.Silver;
            this.btn_clearsearch.FlatAppearance.BorderSize = 0;
            this.btn_clearsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearsearch.Location = new System.Drawing.Point(795, 28);
            this.btn_clearsearch.Name = "btn_clearsearch";
            this.btn_clearsearch.Size = new System.Drawing.Size(105, 36);
            this.btn_clearsearch.TabIndex = 6;
            this.btn_clearsearch.Text = "Clear";
            this.btn_clearsearch.UseVisualStyleBackColor = false;
            this.btn_clearsearch.Click += new System.EventHandler(this.btn_clearsearch_Click);
            // 
            // btn_addNewI
            // 
            this.btn_addNewI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(132)))), ((int)(((byte)(232)))));
            this.btn_addNewI.FlatAppearance.BorderSize = 0;
            this.btn_addNewI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addNewI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNewI.Location = new System.Drawing.Point(20, 631);
            this.btn_addNewI.Name = "btn_addNewI";
            this.btn_addNewI.Size = new System.Drawing.Size(105, 36);
            this.btn_addNewI.TabIndex = 6;
            this.btn_addNewI.Text = "Add New";
            this.btn_addNewI.UseVisualStyleBackColor = false;
            this.btn_addNewI.Click += new System.EventHandler(this.btn_addNewI_Click);
            // 
            // dgv_Item
            // 
            this.dgv_Item.AllowCustomTheming = false;
            this.dgv_Item.AllowUserToAddRows = false;
            this.dgv_Item.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            this.dgv_Item.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgv_Item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Item.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Item.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Item.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Item.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgv_Item.ColumnHeadersHeight = 40;
            this.dgv_Item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvI_itemid,
            this.dgvI_name,
            this.dgvI_description,
            this.dgvI_stock,
            this.dgvI_price,
            this.dgvI_warrantyperiod,
            this.dgvI_catname});
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
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Item.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgv_Item.EnableHeadersVisualStyles = false;
            this.dgv_Item.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_Item.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_Item.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_Item.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Item.Location = new System.Drawing.Point(20, 74);
            this.dgv_Item.Name = "dgv_Item";
            this.dgv_Item.ReadOnly = true;
            this.dgv_Item.RowHeadersVisible = false;
            this.dgv_Item.RowHeadersWidth = 47;
            this.dgv_Item.RowTemplate.Height = 40;
            this.dgv_Item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Item.Size = new System.Drawing.Size(1293, 551);
            this.dgv_Item.TabIndex = 2;
            this.dgv_Item.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgv_Item.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Item_CellContentClick);
            // 
            // dgvI_itemid
            // 
            this.dgvI_itemid.HeaderText = "Item ID";
            this.dgvI_itemid.MinimumWidth = 6;
            this.dgvI_itemid.Name = "dgvI_itemid";
            this.dgvI_itemid.ReadOnly = true;
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
            // dgvI_catname
            // 
            this.dgvI_catname.HeaderText = "Category Name";
            this.dgvI_catname.MinimumWidth = 6;
            this.dgvI_catname.Name = "dgvI_catname";
            this.dgvI_catname.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item name:";
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
            this.txt_search.Location = new System.Drawing.Point(505, 27);
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
            this.txt_search.Padding = new System.Windows.Forms.Padding(3);
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_search.PlaceholderText = "";
            this.txt_search.ReadOnly = false;
            this.txt_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_search.SelectedText = "";
            this.txt_search.SelectionLength = 0;
            this.txt_search.SelectionStart = 0;
            this.txt_search.ShortcutsEnabled = true;
            this.txt_search.Size = new System.Drawing.Size(284, 41);
            this.txt_search.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_search.TabIndex = 1;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_search.TextMarginBottom = 0;
            this.txt_search.TextMarginLeft = 3;
            this.txt_search.TextMarginTop = 1;
            this.txt_search.TextPlaceholder = "";
            this.txt_search.UseSystemPasswordChar = false;
            this.txt_search.WordWrap = true;
            this.txt_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyUp);
            // 
            // tab_Supplier
            // 
            this.tab_Supplier.Controls.Add(this.btn_refreshS);
            this.tab_Supplier.Controls.Add(this.btn_addNewS);
            this.tab_Supplier.Controls.Add(this.dgv_supplier);
            this.tab_Supplier.Location = new System.Drawing.Point(4, 31);
            this.tab_Supplier.Name = "tab_Supplier";
            this.tab_Supplier.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Supplier.Size = new System.Drawing.Size(1333, 680);
            this.tab_Supplier.TabIndex = 2;
            this.tab_Supplier.Text = "Supplier";
            this.tab_Supplier.UseVisualStyleBackColor = true;
            // 
            // btn_refreshS
            // 
            this.btn_refreshS.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_refreshS.BackgroundImage = global::NeoLine_Computers.Properties.Resources.update1;
            this.btn_refreshS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refreshS.FlatAppearance.BorderSize = 0;
            this.btn_refreshS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refreshS.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_refreshS.Location = new System.Drawing.Point(145, 626);
            this.btn_refreshS.Name = "btn_refreshS";
            this.btn_refreshS.Size = new System.Drawing.Size(30, 30);
            this.btn_refreshS.TabIndex = 8;
            this.btn_refreshS.UseVisualStyleBackColor = false;
            this.btn_refreshS.Click += new System.EventHandler(this.btn_refreshS_Click);
            this.btn_refreshS.MouseHover += new System.EventHandler(this.btn_refreshS_MouseHover);
            // 
            // btn_addNewS
            // 
            this.btn_addNewS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(132)))), ((int)(((byte)(232)))));
            this.btn_addNewS.FlatAppearance.BorderSize = 0;
            this.btn_addNewS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addNewS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNewS.Location = new System.Drawing.Point(20, 622);
            this.btn_addNewS.Name = "btn_addNewS";
            this.btn_addNewS.Size = new System.Drawing.Size(105, 36);
            this.btn_addNewS.TabIndex = 7;
            this.btn_addNewS.Text = "Add New";
            this.btn_addNewS.UseVisualStyleBackColor = false;
            this.btn_addNewS.Click += new System.EventHandler(this.btn_addNewS_Click);
            // 
            // dgv_supplier
            // 
            this.dgv_supplier.AllowCustomTheming = false;
            this.dgv_supplier.AllowUserToAddRows = false;
            this.dgv_supplier.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            this.dgv_supplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_supplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_supplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_supplier.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_supplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_supplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_supplier.ColumnHeadersHeight = 40;
            this.dgv_supplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvs_supplierid,
            this.dgvs_name,
            this.dgvs_email,
            this.dgvs_contactno,
            this.dgvs_remark});
            this.dgv_supplier.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_supplier.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_supplier.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_supplier.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_supplier.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_supplier.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_supplier.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_supplier.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_supplier.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_supplier.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_supplier.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_supplier.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_supplier.CurrentTheme.Name = null;
            this.dgv_supplier.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_supplier.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_supplier.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_supplier.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_supplier.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_supplier.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_supplier.EnableHeadersVisualStyles = false;
            this.dgv_supplier.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_supplier.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_supplier.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_supplier.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_supplier.Location = new System.Drawing.Point(20, 22);
            this.dgv_supplier.Name = "dgv_supplier";
            this.dgv_supplier.ReadOnly = true;
            this.dgv_supplier.RowHeadersVisible = false;
            this.dgv_supplier.RowHeadersWidth = 47;
            this.dgv_supplier.RowTemplate.Height = 40;
            this.dgv_supplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_supplier.Size = new System.Drawing.Size(1293, 592);
            this.dgv_supplier.TabIndex = 6;
            this.dgv_supplier.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgv_supplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_supplier_CellContentClick);
            // 
            // dgvs_supplierid
            // 
            this.dgvs_supplierid.HeaderText = "Supplier ID";
            this.dgvs_supplierid.MinimumWidth = 6;
            this.dgvs_supplierid.Name = "dgvs_supplierid";
            this.dgvs_supplierid.ReadOnly = true;
            // 
            // dgvs_name
            // 
            this.dgvs_name.HeaderText = "Name";
            this.dgvs_name.MinimumWidth = 6;
            this.dgvs_name.Name = "dgvs_name";
            this.dgvs_name.ReadOnly = true;
            // 
            // dgvs_email
            // 
            this.dgvs_email.HeaderText = "Email";
            this.dgvs_email.MinimumWidth = 6;
            this.dgvs_email.Name = "dgvs_email";
            this.dgvs_email.ReadOnly = true;
            // 
            // dgvs_contactno
            // 
            this.dgvs_contactno.HeaderText = "Contact No";
            this.dgvs_contactno.MinimumWidth = 6;
            this.dgvs_contactno.Name = "dgvs_contactno";
            this.dgvs_contactno.ReadOnly = true;
            // 
            // dgvs_remark
            // 
            this.dgvs_remark.HeaderText = "Remark";
            this.dgvs_remark.MinimumWidth = 6;
            this.dgvs_remark.Name = "dgvs_remark";
            this.dgvs_remark.ReadOnly = true;
            // 
            // TableControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "TableControl";
            this.Size = new System.Drawing.Size(1377, 798);
            this.tabControl1.ResumeLayout(false);
            this.tab_Category.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Category)).EndInit();
            this.tab_Item.ResumeLayout(false);
            this.tab_Item.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Item)).EndInit();
            this.tab_Supplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Category;
        private System.Windows.Forms.TabPage tab_Item;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_Category;
        private System.Windows.Forms.Button btn_refreshC;
        private System.Windows.Forms.Button btn_addNewC;
        private System.Windows.Forms.TabPage tab_Supplier;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox txt_search;
        private System.Windows.Forms.Button btn_refereshI;
        private System.Windows.Forms.Button btn_addNewI;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvC_catid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvC_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvC_description;
        private System.Windows.Forms.Button btn_clearsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvI_itemid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvI_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvI_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvI_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvI_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvI_warrantyperiod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvI_catname;
        private System.Windows.Forms.Button btn_refreshS;
        private System.Windows.Forms.Button btn_addNewS;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvs_supplierid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvs_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvs_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvs_contactno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvs_remark;
    }
}
