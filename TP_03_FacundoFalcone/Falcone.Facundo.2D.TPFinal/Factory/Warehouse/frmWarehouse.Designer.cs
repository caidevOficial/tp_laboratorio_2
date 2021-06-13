
namespace FactoryForms {
    partial class frmWarehouse {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarehouse));
            this.dgvRobots = new System.Windows.Forms.DataGridView();
            this.cmbWarehouseShow = new System.Windows.Forms.ComboBox();
            this.pnlImageRobot = new System.Windows.Forms.Panel();
            this.pbImageRobot = new System.Windows.Forms.PictureBox();
            this.pnlInfoRobot = new System.Windows.Forms.Panel();
            this.rtbInfoRobot = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRobots)).BeginInit();
            this.pnlImageRobot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageRobot)).BeginInit();
            this.pnlInfoRobot.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRobots
            // 
            this.dgvRobots.AllowUserToResizeColumns = false;
            this.dgvRobots.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lime;
            this.dgvRobots.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRobots.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRobots.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRobots.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dgvRobots.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRobots.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvRobots.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRobots.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRobots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRobots.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvRobots.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvRobots.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dgvRobots.Location = new System.Drawing.Point(177, 39);
            this.dgvRobots.Name = "dgvRobots";
            this.dgvRobots.ReadOnly = true;
            this.dgvRobots.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRobots.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Lime;
            this.dgvRobots.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRobots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRobots.Size = new System.Drawing.Size(374, 128);
            this.dgvRobots.TabIndex = 1;
            this.dgvRobots.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRobots_CellContentClick);
            // 
            // cmbWarehouseShow
            // 
            this.cmbWarehouseShow.FormattingEnabled = true;
            this.cmbWarehouseShow.Location = new System.Drawing.Point(177, 12);
            this.cmbWarehouseShow.Name = "cmbWarehouseShow";
            this.cmbWarehouseShow.Size = new System.Drawing.Size(121, 21);
            this.cmbWarehouseShow.TabIndex = 3;
            this.cmbWarehouseShow.SelectedIndexChanged += new System.EventHandler(this.cmbWarehouseShow_SelectedIndexChanged);
            // 
            // pnlImageRobot
            // 
            this.pnlImageRobot.BackColor = System.Drawing.Color.Transparent;
            this.pnlImageRobot.Controls.Add(this.pbImageRobot);
            this.pnlImageRobot.Location = new System.Drawing.Point(137, 193);
            this.pnlImageRobot.Name = "pnlImageRobot";
            this.pnlImageRobot.Size = new System.Drawing.Size(228, 277);
            this.pnlImageRobot.TabIndex = 4;
            // 
            // pbImageRobot
            // 
            this.pbImageRobot.BackColor = System.Drawing.Color.Transparent;
            this.pbImageRobot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImageRobot.Location = new System.Drawing.Point(0, 0);
            this.pbImageRobot.Name = "pbImageRobot";
            this.pbImageRobot.Size = new System.Drawing.Size(228, 277);
            this.pbImageRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageRobot.TabIndex = 0;
            this.pbImageRobot.TabStop = false;
            // 
            // pnlInfoRobot
            // 
            this.pnlInfoRobot.BackColor = System.Drawing.Color.Transparent;
            this.pnlInfoRobot.Controls.Add(this.rtbInfoRobot);
            this.pnlInfoRobot.Location = new System.Drawing.Point(383, 193);
            this.pnlInfoRobot.Name = "pnlInfoRobot";
            this.pnlInfoRobot.Size = new System.Drawing.Size(225, 274);
            this.pnlInfoRobot.TabIndex = 5;
            // 
            // rtbInfoRobot
            // 
            this.rtbInfoRobot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.rtbInfoRobot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInfoRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInfoRobot.ForeColor = System.Drawing.Color.Tomato;
            this.rtbInfoRobot.Location = new System.Drawing.Point(0, 0);
            this.rtbInfoRobot.Name = "rtbInfoRobot";
            this.rtbInfoRobot.ReadOnly = true;
            this.rtbInfoRobot.Size = new System.Drawing.Size(225, 274);
            this.rtbInfoRobot.TabIndex = 12;
            this.rtbInfoRobot.Text = "";
            // 
            // frmWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 499);
            this.Controls.Add(this.pnlInfoRobot);
            this.Controls.Add(this.pnlImageRobot);
            this.Controls.Add(this.cmbWarehouseShow);
            this.Controls.Add(this.dgvRobots);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse";
            this.Load += new System.EventHandler(this.frmWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRobots)).EndInit();
            this.pnlImageRobot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageRobot)).EndInit();
            this.pnlInfoRobot.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRobots;
        private System.Windows.Forms.ComboBox cmbWarehouseShow;
        private System.Windows.Forms.Panel pnlImageRobot;
        private System.Windows.Forms.Panel pnlInfoRobot;
        private System.Windows.Forms.RichTextBox rtbInfoRobot;
        private System.Windows.Forms.PictureBox pbImageRobot;
    }
}