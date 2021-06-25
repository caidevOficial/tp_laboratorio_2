
namespace FactoryForms {
    partial class frmFactory {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactory));
            this.btnInitializeFactory = new FontAwesome.Sharp.IconButton();
            this.btnImportStock = new FontAwesome.Sharp.IconButton();
            this.chartMaterialsStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaterialsStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInitializeFactory
            // 
            this.btnInitializeFactory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInitializeFactory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitializeFactory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitializeFactory.ForeColor = System.Drawing.Color.White;
            this.btnInitializeFactory.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnInitializeFactory.IconColor = System.Drawing.Color.Tomato;
            this.btnInitializeFactory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInitializeFactory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInitializeFactory.Location = new System.Drawing.Point(2, 107);
            this.btnInitializeFactory.Name = "btnInitializeFactory";
            this.btnInitializeFactory.Size = new System.Drawing.Size(164, 71);
            this.btnInitializeFactory.TabIndex = 0;
            this.btnInitializeFactory.Text = "Initialize Factory";
            this.btnInitializeFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInitializeFactory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInitializeFactory.UseVisualStyleBackColor = true;
            this.btnInitializeFactory.Click += new System.EventHandler(this.btnInitializeFactory_Click);
            // 
            // btnImportStock
            // 
            this.btnImportStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportStock.ForeColor = System.Drawing.Color.White;
            this.btnImportStock.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnImportStock.IconColor = System.Drawing.Color.Tomato;
            this.btnImportStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImportStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportStock.Location = new System.Drawing.Point(2, 201);
            this.btnImportStock.Name = "btnImportStock";
            this.btnImportStock.Size = new System.Drawing.Size(164, 71);
            this.btnImportStock.TabIndex = 1;
            this.btnImportStock.Text = "Import Stock";
            this.btnImportStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportStock.UseVisualStyleBackColor = true;
            this.btnImportStock.Click += new System.EventHandler(this.btnImportStock_Click);
            // 
            // chartMaterialsStock
            // 
            this.chartMaterialsStock.BackColor = System.Drawing.Color.Transparent;
            this.chartMaterialsStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartMaterialsStock.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 50;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Rotation = 50;
            chartArea1.Area3DStyle.WallWidth = 15;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartMaterialsStock.ChartAreas.Add(chartArea1);
            this.chartMaterialsStock.Cursor = System.Windows.Forms.Cursors.Hand;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.OrangeRed;
            legend1.IsTextAutoFit = false;
            legend1.ItemColumnSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickGradientLine;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.Title = "Materials Stock";
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.TitleForeColor = System.Drawing.Color.OrangeRed;
            legend1.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickGradientLine;
            legend1.TitleSeparatorColor = System.Drawing.Color.Gold;
            this.chartMaterialsStock.Legends.Add(legend1);
            this.chartMaterialsStock.Location = new System.Drawing.Point(167, 12);
            this.chartMaterialsStock.Name = "chartMaterialsStock";
            this.chartMaterialsStock.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.chartMaterialsStock.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartMaterialsStock.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.MidnightBlue,
        System.Drawing.Color.RoyalBlue,
        System.Drawing.Color.DodgerBlue,
        System.Drawing.Color.LightSkyBlue,
        System.Drawing.Color.CornflowerBlue,
        System.Drawing.Color.LightSteelBlue};
            this.chartMaterialsStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.Transparent;
            series1.CustomProperties = "CollectedColor=Transparent";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.LabelForeColor = System.Drawing.Color.OrangeRed;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Transparent;
            series1.Name = "Materials Stock";
            series1.YValuesPerPoint = 4;
            this.chartMaterialsStock.Series.Add(series1);
            this.chartMaterialsStock.Size = new System.Drawing.Size(396, 439);
            this.chartMaterialsStock.TabIndex = 16;
            this.chartMaterialsStock.Text = "Stock of Materials";
            // 
            // frmFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 499);
            this.Controls.Add(this.chartMaterialsStock);
            this.Controls.Add(this.btnImportStock);
            this.Controls.Add(this.btnInitializeFactory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFactory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Machines Room";
            this.Load += new System.EventHandler(this.frmFactory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMaterialsStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnInitializeFactory;
        private FontAwesome.Sharp.IconButton btnImportStock;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMaterialsStock;
    }
}

