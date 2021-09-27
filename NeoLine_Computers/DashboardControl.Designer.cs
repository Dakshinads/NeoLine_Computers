
namespace NeoLine_Computers
{
    partial class DashboardControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardControl));
            this.label1 = new System.Windows.Forms.Label();
            this.chart_7dayPieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_7dayColumn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn_refreshCharts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_7dayPieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_7dayColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // chart_7dayPieChart
            // 
            chartArea5.Name = "ChartArea1";
            this.chart_7dayPieChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart_7dayPieChart.Legends.Add(legend5);
            this.chart_7dayPieChart.Location = new System.Drawing.Point(28, 120);
            this.chart_7dayPieChart.Name = "chart_7dayPieChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "s1";
            this.chart_7dayPieChart.Series.Add(series5);
            this.chart_7dayPieChart.Size = new System.Drawing.Size(603, 607);
            this.chart_7dayPieChart.TabIndex = 1;
            this.chart_7dayPieChart.Text = "chart1";
            // 
            // chart_7dayColumn
            // 
            chartArea6.Name = "ChartArea1";
            this.chart_7dayColumn.ChartAreas.Add(chartArea6);
            legend6.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
            legend6.Name = "Legend1";
            this.chart_7dayColumn.Legends.Add(legend6);
            this.chart_7dayColumn.Location = new System.Drawing.Point(720, 120);
            this.chart_7dayColumn.Name = "chart_7dayColumn";
            series6.ChartArea = "ChartArea1";
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Sales";
            this.chart_7dayColumn.Series.Add(series6);
            this.chart_7dayColumn.Size = new System.Drawing.Size(614, 607);
            this.chart_7dayColumn.TabIndex = 1;
            this.chart_7dayColumn.Text = "chart1";
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 11.78182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.bunifuLabel1.Location = new System.Drawing.Point(129, 89);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(354, 25);
            this.bunifuLabel1.TabIndex = 2;
            this.bunifuLabel1.Text = "Total sales by category for the last 7 days";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 11.78182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bunifuLabel2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.bunifuLabel2.Location = new System.Drawing.Point(932, 89);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(167, 25);
            this.bunifuLabel2.TabIndex = 2;
            this.bunifuLabel2.Text = "Sales by last 7 days";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_refreshCharts
            // 
            this.btn_refreshCharts.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_refreshCharts.BackgroundImage = global::NeoLine_Computers.Properties.Resources.update1;
            this.btn_refreshCharts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refreshCharts.FlatAppearance.BorderSize = 0;
            this.btn_refreshCharts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refreshCharts.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_refreshCharts.Location = new System.Drawing.Point(28, 742);
            this.btn_refreshCharts.Name = "btn_refreshCharts";
            this.btn_refreshCharts.Size = new System.Drawing.Size(30, 30);
            this.btn_refreshCharts.TabIndex = 6;
            this.btn_refreshCharts.UseVisualStyleBackColor = false;
            this.btn_refreshCharts.Click += new System.EventHandler(this.btn_refreshCharts_Click);
            this.btn_refreshCharts.MouseHover += new System.EventHandler(this.btn_refreshCharts_MouseHover);
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_refreshCharts);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.chart_7dayColumn);
            this.Controls.Add(this.chart_7dayPieChart);
            this.Controls.Add(this.label1);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1377, 791);
            ((System.ComponentModel.ISupportInitialize)(this.chart_7dayPieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_7dayColumn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_7dayPieChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_7dayColumn;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.Button btn_refreshCharts;
    }
}
