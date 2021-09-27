
namespace NeoLine_Computers
{
    partial class Form_Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Invoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn_close = new System.Windows.Forms.Button();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lbl_invoiceno = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_date = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_time = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_customerName = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_contactNo = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgv_list = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuLabel9 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuLabel10 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warranty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuLabel11 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_Total = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(24, 29);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(195, 30);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "NeoLine Computers";
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
            this.bunifuLabel2.Location = new System.Drawing.Point(486, 180);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(67, 20);
            this.bunifuLabel2.TabIndex = 0;
            this.bunifuLabel2.Text = "Invoice# :";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Black;
            this.btn_close.BackgroundImage = global::NeoLine_Computers.Properties.Resources.close;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(702, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 6;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel3.Location = new System.Drawing.Point(24, 58);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(220, 25);
            this.bunifuLabel3.TabIndex = 0;
            this.bunifuLabel3.Text = "121, Kandy Road, Gampaha";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel4.Location = new System.Drawing.Point(24, 83);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(100, 25);
            this.bunifuLabel4.TabIndex = 0;
            this.bunifuLabel4.Text = "0719015133";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = false;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Image = global::NeoLine_Computers.Properties.Resources.Screenshot_91___Copy1;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(528, 55);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(123, 123);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 7;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // lbl_invoiceno
            // 
            this.lbl_invoiceno.AllowParentOverrides = false;
            this.lbl_invoiceno.AutoEllipsis = false;
            this.lbl_invoiceno.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_invoiceno.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_invoiceno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_invoiceno.Location = new System.Drawing.Point(591, 180);
            this.lbl_invoiceno.Name = "lbl_invoiceno";
            this.lbl_invoiceno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_invoiceno.Size = new System.Drawing.Size(6, 20);
            this.lbl_invoiceno.TabIndex = 0;
            this.lbl_invoiceno.Text = "..";
            this.lbl_invoiceno.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_invoiceno.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel5.Location = new System.Drawing.Point(486, 206);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(95, 20);
            this.bunifuLabel5.TabIndex = 0;
            this.bunifuLabel5.Text = "Invoice Date :";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_date
            // 
            this.lbl_date.AllowParentOverrides = false;
            this.lbl_date.AutoEllipsis = false;
            this.lbl_date.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_date.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_date.Location = new System.Drawing.Point(591, 206);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_date.Size = new System.Drawing.Size(6, 20);
            this.lbl_date.TabIndex = 0;
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
            this.bunifuLabel7.Location = new System.Drawing.Point(486, 232);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(97, 20);
            this.bunifuLabel7.TabIndex = 0;
            this.bunifuLabel7.Text = "Invoice Time :";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_time
            // 
            this.lbl_time.AllowParentOverrides = false;
            this.lbl_time.AutoEllipsis = false;
            this.lbl_time.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_time.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_time.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_time.Location = new System.Drawing.Point(591, 232);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_time.Size = new System.Drawing.Size(6, 20);
            this.lbl_time.TabIndex = 0;
            this.lbl_time.Text = "..";
            this.lbl_time.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_time.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.bunifuLabel6.Location = new System.Drawing.Point(545, 29);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(66, 30);
            this.bunifuLabel6.TabIndex = 0;
            this.bunifuLabel6.Text = "Invoice";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel8
            // 
            this.bunifuLabel8.AllowParentOverrides = false;
            this.bunifuLabel8.AutoEllipsis = false;
            this.bunifuLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel8.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel8.Location = new System.Drawing.Point(24, 180);
            this.bunifuLabel8.Name = "bunifuLabel8";
            this.bunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel8.Size = new System.Drawing.Size(44, 20);
            this.bunifuLabel8.TabIndex = 0;
            this.bunifuLabel8.Text = "Bill To";
            this.bunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_customerName
            // 
            this.lbl_customerName.AllowParentOverrides = false;
            this.lbl_customerName.AutoEllipsis = false;
            this.lbl_customerName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_customerName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_customerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_customerName.Location = new System.Drawing.Point(24, 206);
            this.lbl_customerName.Name = "lbl_customerName";
            this.lbl_customerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_customerName.Size = new System.Drawing.Size(6, 20);
            this.lbl_customerName.TabIndex = 0;
            this.lbl_customerName.Text = "..";
            this.lbl_customerName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_customerName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_contactNo
            // 
            this.lbl_contactNo.AllowParentOverrides = false;
            this.lbl_contactNo.AutoEllipsis = false;
            this.lbl_contactNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_contactNo.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_contactNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_contactNo.Location = new System.Drawing.Point(24, 232);
            this.lbl_contactNo.Name = "lbl_contactNo";
            this.lbl_contactNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_contactNo.Size = new System.Drawing.Size(6, 20);
            this.lbl_contactNo.TabIndex = 0;
            this.lbl_contactNo.Text = "..";
            this.lbl_contactNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_contactNo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.des,
            this.warranty,
            this.qty,
            this.price,
            this.dis,
            this.amount});
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
            this.dgv_list.Location = new System.Drawing.Point(24, 291);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.ReadOnly = true;
            this.dgv_list.RowHeadersVisible = false;
            this.dgv_list.RowHeadersWidth = 50;
            this.dgv_list.RowTemplate.Height = 40;
            this.dgv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list.Size = new System.Drawing.Size(674, 456);
            this.dgv_list.TabIndex = 8;
            this.dgv_list.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // bunifuLabel9
            // 
            this.bunifuLabel9.AllowParentOverrides = false;
            this.bunifuLabel9.AutoEllipsis = false;
            this.bunifuLabel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel9.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel9.Location = new System.Drawing.Point(68, 840);
            this.bunifuLabel9.Name = "bunifuLabel9";
            this.bunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel9.Size = new System.Drawing.Size(149, 20);
            this.bunifuLabel9.TabIndex = 0;
            this.bunifuLabel9.Text = "Authorised Signature";
            this.bunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(59, 832);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 2);
            this.panel1.TabIndex = 9;
            // 
            // bunifuLabel10
            // 
            this.bunifuLabel10.AllowParentOverrides = false;
            this.bunifuLabel10.AutoEllipsis = false;
            this.bunifuLabel10.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel10.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel10.Location = new System.Drawing.Point(545, 840);
            this.bunifuLabel10.Name = "bunifuLabel10";
            this.bunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel10.Size = new System.Drawing.Size(84, 20);
            this.bunifuLabel10.TabIndex = 0;
            this.bunifuLabel10.Text = "Received By";
            this.bunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(493, 832);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 2);
            this.panel2.TabIndex = 9;
            // 
            // des
            // 
            this.des.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.des.FillWeight = 163.7319F;
            this.des.HeaderText = "Description";
            this.des.MinimumWidth = 6;
            this.des.Name = "des";
            this.des.ReadOnly = true;
            this.des.Width = 135;
            // 
            // warranty
            // 
            this.warranty.FillWeight = 6.101812F;
            this.warranty.HeaderText = "Warranty Period";
            this.warranty.MinimumWidth = 6;
            this.warranty.Name = "warranty";
            this.warranty.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.FillWeight = 6.101812F;
            this.qty.HeaderText = "QTY";
            this.qty.MinimumWidth = 6;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // price
            // 
            this.price.FillWeight = 6.101812F;
            this.price.HeaderText = "Price (Rs.)";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // dis
            // 
            this.dis.FillWeight = 6.101812F;
            this.dis.HeaderText = "Discount";
            this.dis.MinimumWidth = 6;
            this.dis.Name = "dis";
            this.dis.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.FillWeight = 6.101812F;
            this.amount.HeaderText = "Amount (Rs.)";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // bunifuLabel11
            // 
            this.bunifuLabel11.AllowParentOverrides = false;
            this.bunifuLabel11.AutoEllipsis = false;
            this.bunifuLabel11.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel11.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel11.Location = new System.Drawing.Point(483, 753);
            this.bunifuLabel11.Name = "bunifuLabel11";
            this.bunifuLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel11.Size = new System.Drawing.Size(98, 20);
            this.bunifuLabel11.TabIndex = 0;
            this.bunifuLabel11.Text = "Total Amount";
            this.bunifuLabel11.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel11.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AllowParentOverrides = false;
            this.lbl_Total.AutoEllipsis = false;
            this.lbl_Total.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_Total.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_Total.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Total.Location = new System.Drawing.Point(608, 753);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Total.Size = new System.Drawing.Size(12, 20);
            this.lbl_Total.TabIndex = 0;
            this.lbl_Total.Text = "...";
            this.lbl_Total.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Total.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Form_Invoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(732, 872);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_list);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_invoiceno);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.bunifuLabel7);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.lbl_contactNo);
            this.Controls.Add(this.lbl_customerName);
            this.Controls.Add(this.bunifuLabel10);
            this.Controls.Add(this.bunifuLabel9);
            this.Controls.Add(this.bunifuLabel11);
            this.Controls.Add(this.bunifuLabel8);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel6);
            this.Controls.Add(this.bunifuLabel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Invoice";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.Button btn_close;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel lbl_invoiceno;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel lbl_date;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private Bunifu.UI.WinForms.BunifuLabel lbl_time;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private Bunifu.UI.WinForms.BunifuLabel lbl_customerName;
        private Bunifu.UI.WinForms.BunifuLabel lbl_contactNo;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_list;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel9;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn des;
        private System.Windows.Forms.DataGridViewTextBoxColumn warranty;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn dis;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel11;
        private Bunifu.UI.WinForms.BunifuLabel lbl_Total;
    }
}