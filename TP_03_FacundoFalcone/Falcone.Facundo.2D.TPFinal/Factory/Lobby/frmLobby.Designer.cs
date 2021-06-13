/*
 * MIT License
 * 
 * Copyright (c) 2021 [FacuFalcone]
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

namespace FactoryForms {
    partial class frmLobby {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLobby));
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCurrentChildFormTitle = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnWarehouse = new FontAwesome.Sharp.IconButton();
            this.btnMachineRoom = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.ibtnClose = new FontAwesome.Sharp.IconButton();
            this.btnManufacture = new FontAwesome.Sharp.IconButton();
            this.pnlButtom = new System.Windows.Forms.Panel();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.ipbImageIcon4 = new FontAwesome.Sharp.IconPictureBox();
            this.ipbImageIcon3 = new FontAwesome.Sharp.IconPictureBox();
            this.ipbImageIcon2 = new FontAwesome.Sharp.IconPictureBox();
            this.ipbImageIcon1 = new FontAwesome.Sharp.IconPictureBox();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlLogo.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbImageIcon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbImageIcon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbImageIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbImageIcon1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pnlTitleBar.Controls.Add(this.lblTime);
            this.pnlTitleBar.Controls.Add(this.lblDate);
            this.pnlTitleBar.Controls.Add(this.lblCurrentChildFormTitle);
            this.pnlTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(154, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(730, 75);
            this.pnlTitleBar.TabIndex = 15;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(427, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(291, 23);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblDate.Location = new System.Drawing.Point(423, 35);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(295, 24);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentChildFormTitle
            // 
            this.lblCurrentChildFormTitle.AutoSize = true;
            this.lblCurrentChildFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentChildFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblCurrentChildFormTitle.Location = new System.Drawing.Point(55, 35);
            this.lblCurrentChildFormTitle.Name = "lblCurrentChildFormTitle";
            this.lblCurrentChildFormTitle.Size = new System.Drawing.Size(56, 20);
            this.lblCurrentChildFormTitle.TabIndex = 1;
            this.lblCurrentChildFormTitle.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 43;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 22);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(43, 43);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(154, 119);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWarehouse.FlatAppearance.BorderSize = 0;
            this.btnWarehouse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWarehouse.ForeColor = System.Drawing.Color.White;
            this.btnWarehouse.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.btnWarehouse.IconColor = System.Drawing.Color.OrangeRed;
            this.btnWarehouse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWarehouse.IconSize = 40;
            this.btnWarehouse.Location = new System.Drawing.Point(0, 413);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnWarehouse.Size = new System.Drawing.Size(154, 90);
            this.btnWarehouse.TabIndex = 3;
            this.btnWarehouse.Text = "Warehouse";
            this.btnWarehouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWarehouse.UseVisualStyleBackColor = true;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnMachineRoom
            // 
            this.btnMachineRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMachineRoom.FlatAppearance.BorderSize = 0;
            this.btnMachineRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnMachineRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMachineRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMachineRoom.ForeColor = System.Drawing.Color.White;
            this.btnMachineRoom.IconChar = FontAwesome.Sharp.IconChar.SteamSquare;
            this.btnMachineRoom.IconColor = System.Drawing.Color.OrangeRed;
            this.btnMachineRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMachineRoom.IconSize = 40;
            this.btnMachineRoom.Location = new System.Drawing.Point(0, 221);
            this.btnMachineRoom.Name = "btnMachineRoom";
            this.btnMachineRoom.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMachineRoom.Size = new System.Drawing.Size(154, 90);
            this.btnMachineRoom.TabIndex = 1;
            this.btnMachineRoom.Text = "Machines room";
            this.btnMachineRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMachineRoom.UseVisualStyleBackColor = true;
            this.btnMachineRoom.Click += new System.EventHandler(this.btnMachineRoom_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnDashboard.IconColor = System.Drawing.Color.OrangeRed;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 40;
            this.btnDashboard.Location = new System.Drawing.Point(0, 125);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboard.Size = new System.Drawing.Size(154, 90);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pbLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(154, 119);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlMenu.Controls.Add(this.ibtnClose);
            this.pnlMenu.Controls.Add(this.btnMachineRoom);
            this.pnlMenu.Controls.Add(this.btnManufacture);
            this.pnlMenu.Controls.Add(this.btnWarehouse);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(154, 636);
            this.pnlMenu.TabIndex = 14;
            // 
            // ibtnClose
            // 
            this.ibtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnClose.FlatAppearance.BorderSize = 0;
            this.ibtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.ibtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnClose.ForeColor = System.Drawing.Color.White;
            this.ibtnClose.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.ibtnClose.IconColor = System.Drawing.Color.OrangeRed;
            this.ibtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnClose.IconSize = 64;
            this.ibtnClose.Location = new System.Drawing.Point(0, 509);
            this.ibtnClose.Name = "ibtnClose";
            this.ibtnClose.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnClose.Size = new System.Drawing.Size(154, 90);
            this.ibtnClose.TabIndex = 4;
            this.ibtnClose.UseVisualStyleBackColor = true;
            this.ibtnClose.Click += new System.EventHandler(this.ibtnClose_Click);
            // 
            // btnManufacture
            // 
            this.btnManufacture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManufacture.FlatAppearance.BorderSize = 0;
            this.btnManufacture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnManufacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManufacture.ForeColor = System.Drawing.Color.White;
            this.btnManufacture.IconChar = FontAwesome.Sharp.IconChar.Industry;
            this.btnManufacture.IconColor = System.Drawing.Color.OrangeRed;
            this.btnManufacture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManufacture.IconSize = 40;
            this.btnManufacture.Location = new System.Drawing.Point(0, 317);
            this.btnManufacture.Name = "btnManufacture";
            this.btnManufacture.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnManufacture.Size = new System.Drawing.Size(154, 90);
            this.btnManufacture.TabIndex = 2;
            this.btnManufacture.Text = "Manufacture";
            this.btnManufacture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnManufacture.UseVisualStyleBackColor = true;
            this.btnManufacture.Click += new System.EventHandler(this.btnManufacture_Click);
            // 
            // pnlButtom
            // 
            this.pnlButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtom.Location = new System.Drawing.Point(154, 574);
            this.pnlButtom.Name = "pnlButtom";
            this.pnlButtom.Size = new System.Drawing.Size(730, 62);
            this.pnlButtom.TabIndex = 16;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlChildForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlChildForm.BackgroundImage")));
            this.pnlChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlChildForm.Controls.Add(this.ipbImageIcon4);
            this.pnlChildForm.Controls.Add(this.ipbImageIcon3);
            this.pnlChildForm.Controls.Add(this.ipbImageIcon2);
            this.pnlChildForm.Controls.Add(this.ipbImageIcon1);
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(154, 75);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(730, 499);
            this.pnlChildForm.TabIndex = 17;
            // 
            // ipbImageIcon4
            // 
            this.ipbImageIcon4.BackColor = System.Drawing.Color.Transparent;
            this.ipbImageIcon4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ipbImageIcon4.BackgroundImage")));
            this.ipbImageIcon4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ipbImageIcon4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipbImageIcon4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ipbImageIcon4.IconColor = System.Drawing.SystemColors.ControlText;
            this.ipbImageIcon4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbImageIcon4.IconSize = 141;
            this.ipbImageIcon4.Location = new System.Drawing.Point(554, 21);
            this.ipbImageIcon4.Name = "ipbImageIcon4";
            this.ipbImageIcon4.Size = new System.Drawing.Size(164, 141);
            this.ipbImageIcon4.TabIndex = 3;
            this.ipbImageIcon4.TabStop = false;
            // 
            // ipbImageIcon3
            // 
            this.ipbImageIcon3.BackColor = System.Drawing.Color.Transparent;
            this.ipbImageIcon3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ipbImageIcon3.BackgroundImage")));
            this.ipbImageIcon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ipbImageIcon3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipbImageIcon3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ipbImageIcon3.IconColor = System.Drawing.SystemColors.ControlText;
            this.ipbImageIcon3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbImageIcon3.IconSize = 141;
            this.ipbImageIcon3.Location = new System.Drawing.Point(375, 21);
            this.ipbImageIcon3.Name = "ipbImageIcon3";
            this.ipbImageIcon3.Size = new System.Drawing.Size(164, 141);
            this.ipbImageIcon3.TabIndex = 2;
            this.ipbImageIcon3.TabStop = false;
            // 
            // ipbImageIcon2
            // 
            this.ipbImageIcon2.BackColor = System.Drawing.Color.Transparent;
            this.ipbImageIcon2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ipbImageIcon2.BackgroundImage")));
            this.ipbImageIcon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ipbImageIcon2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipbImageIcon2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ipbImageIcon2.IconColor = System.Drawing.SystemColors.ControlText;
            this.ipbImageIcon2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbImageIcon2.IconSize = 141;
            this.ipbImageIcon2.Location = new System.Drawing.Point(194, 21);
            this.ipbImageIcon2.Name = "ipbImageIcon2";
            this.ipbImageIcon2.Size = new System.Drawing.Size(164, 141);
            this.ipbImageIcon2.TabIndex = 1;
            this.ipbImageIcon2.TabStop = false;
            // 
            // ipbImageIcon1
            // 
            this.ipbImageIcon1.BackColor = System.Drawing.Color.Transparent;
            this.ipbImageIcon1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ipbImageIcon1.BackgroundImage")));
            this.ipbImageIcon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ipbImageIcon1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipbImageIcon1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ipbImageIcon1.IconColor = System.Drawing.SystemColors.ControlText;
            this.ipbImageIcon1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbImageIcon1.IconSize = 141;
            this.ipbImageIcon1.Location = new System.Drawing.Point(15, 21);
            this.ipbImageIcon1.Name = "ipbImageIcon1";
            this.ipbImageIcon1.Size = new System.Drawing.Size(164, 141);
            this.ipbImageIcon1.TabIndex = 0;
            this.ipbImageIcon1.TabStop = false;
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Enabled = true;
            this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
            // 
            // frmLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 636);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlButtom);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factory Lobby";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLobby_FormClosing);
            this.Load += new System.EventHandler(this.frmLobby_Load);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbImageIcon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbImageIcon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbImageIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbImageIcon1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblCurrentChildFormTitle;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.PictureBox pbLogo;
        private FontAwesome.Sharp.IconButton btnWarehouse;
        private FontAwesome.Sharp.IconButton btnMachineRoom;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlButtom;
        private System.Windows.Forms.Panel pnlChildForm;
        private FontAwesome.Sharp.IconButton btnManufacture;
        private FontAwesome.Sharp.IconButton ibtnClose;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrDateTime;
        private System.Windows.Forms.Label lblDate;
        private FontAwesome.Sharp.IconPictureBox ipbImageIcon4;
        private FontAwesome.Sharp.IconPictureBox ipbImageIcon3;
        private FontAwesome.Sharp.IconPictureBox ipbImageIcon2;
        private FontAwesome.Sharp.IconPictureBox ipbImageIcon1;
    }
}