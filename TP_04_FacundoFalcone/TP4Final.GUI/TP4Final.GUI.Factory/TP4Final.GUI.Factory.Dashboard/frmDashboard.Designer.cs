
namespace FactoryForms {
    partial class frmDashboard {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartMaterialsStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRobotStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaterialsStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRobotStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 499);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.chartMaterialsStock);
            this.panel2.Controls.Add(this.chartRobotStock);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 459);
            this.panel2.TabIndex = 18;
            // 
            // chartMaterialsStock
            // 
            this.chartMaterialsStock.BackColor = System.Drawing.Color.Transparent;
            this.chartMaterialsStock.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.WallWidth = 15;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartMaterialsStock";
            this.chartMaterialsStock.ChartAreas.Add(chartArea1);
            this.chartMaterialsStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chartMaterialsStock.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.OrangeRed;
            legend1.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickGradientLine;
            legend1.HeaderSeparatorColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.ItemColumnSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickGradientLine;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.Title = "Materials Stock";
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.TitleForeColor = System.Drawing.Color.OrangeRed;
            legend1.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickGradientLine;
            legend1.TitleSeparatorColor = System.Drawing.Color.Gold;
            this.chartMaterialsStock.Legends.Add(legend1);
            this.chartMaterialsStock.Location = new System.Drawing.Point(355, 0);
            this.chartMaterialsStock.Name = "chartMaterialsStock";
            this.chartMaterialsStock.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartMaterialsStock.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.MidnightBlue,
        System.Drawing.Color.RoyalBlue,
        System.Drawing.Color.DodgerBlue,
        System.Drawing.Color.LightSkyBlue,
        System.Drawing.Color.CornflowerBlue,
        System.Drawing.Color.LightSteelBlue};
            this.chartMaterialsStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartMaterialsStock";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelForeColor = System.Drawing.Color.OrangeRed;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Transparent;
            series1.Name = "Materials Stock";
            series1.YValuesPerPoint = 4;
            this.chartMaterialsStock.Series.Add(series1);
            this.chartMaterialsStock.Size = new System.Drawing.Size(350, 459);
            this.chartMaterialsStock.TabIndex = 0;
            this.chartMaterialsStock.Text = "Stock of Materials";
            // 
            // chartRobotStock
            // 
            this.chartRobotStock.BackColor = System.Drawing.Color.Transparent;
            this.chartRobotStock.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Area3DStyle.IsClustered = true;
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea2.Area3DStyle.WallWidth = 15;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartRobots";
            this.chartRobotStock.ChartAreas.Add(chartArea2);
            this.chartRobotStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chartRobotStock.Dock = System.Windows.Forms.DockStyle.Left;
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.ForeColor = System.Drawing.Color.OrangeRed;
            legend2.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickGradientLine;
            legend2.HeaderSeparatorColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.ItemColumnSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickGradientLine;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            legend2.Title = "Robot Models";
            legend2.TitleBackColor = System.Drawing.Color.Transparent;
            legend2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.TitleForeColor = System.Drawing.Color.OrangeRed;
            legend2.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickGradientLine;
            legend2.TitleSeparatorColor = System.Drawing.Color.Gold;
            this.chartRobotStock.Legends.Add(legend2);
            this.chartRobotStock.Location = new System.Drawing.Point(0, 0);
            this.chartRobotStock.Name = "chartRobotStock";
            this.chartRobotStock.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartRobotStock.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.MidnightBlue,
        System.Drawing.Color.RoyalBlue,
        System.Drawing.Color.DodgerBlue,
        System.Drawing.Color.LightSkyBlue,
        System.Drawing.Color.CornflowerBlue,
        System.Drawing.Color.LightSteelBlue};
            this.chartRobotStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series2.ChartArea = "ChartRobots";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.LabelBackColor = System.Drawing.Color.Transparent;
            series2.LabelForeColor = System.Drawing.Color.OrangeRed;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.Transparent;
            series2.Name = "Materials Stock";
            series2.YValuesPerPoint = 4;
            this.chartRobotStock.Series.Add(series2);
            this.chartRobotStock.Size = new System.Drawing.Size(350, 459);
            this.chartRobotStock.TabIndex = 1;
            this.chartRobotStock.Text = "Stock of Materials";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 499);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMaterialsStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRobotStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMaterialsStock;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRobotStock;
        private System.Windows.Forms.Panel panel2;
    }
}