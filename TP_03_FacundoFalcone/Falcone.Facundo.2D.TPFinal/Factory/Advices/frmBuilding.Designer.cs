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
    partial class frmBuilding {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuilding));
            this.pnlProgressBar = new System.Windows.Forms.Panel();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.ipbImage = new FontAwesome.Sharp.IconPictureBox();
            this.tmrFadeIn = new System.Windows.Forms.Timer(this.components);
            this.tmrFadeOut = new System.Windows.Forms.Timer(this.components);
            this.pnlProgressBar.SuspendLayout();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProgressBar
            // 
            this.pnlProgressBar.Controls.Add(this.pbLoading);
            this.pnlProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProgressBar.Location = new System.Drawing.Point(0, 299);
            this.pnlProgressBar.Name = "pnlProgressBar";
            this.pnlProgressBar.Size = new System.Drawing.Size(501, 48);
            this.pnlProgressBar.TabIndex = 1;
            // 
            // pbLoading
            // 
            this.pbLoading.BackColor = System.Drawing.Color.Black;
            this.pbLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLoading.Location = new System.Drawing.Point(0, 0);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(501, 48);
            this.pbLoading.TabIndex = 0;
            // 
            // pnlImage
            // 
            this.pnlImage.Controls.Add(this.lblMessage);
            this.pnlImage.Controls.Add(this.ipbImage);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImage.Location = new System.Drawing.Point(0, 0);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(501, 299);
            this.pnlImage.TabIndex = 2;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Black;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMessage.Location = new System.Drawing.Point(12, 258);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(167, 26);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Building Robot...";
            // 
            // ipbImage
            // 
            this.ipbImage.BackColor = System.Drawing.SystemColors.Control;
            this.ipbImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ipbImage.BackgroundImage")));
            this.ipbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ipbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipbImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipbImage.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ipbImage.IconColor = System.Drawing.SystemColors.ControlText;
            this.ipbImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbImage.IconSize = 299;
            this.ipbImage.Location = new System.Drawing.Point(0, 0);
            this.ipbImage.Name = "ipbImage";
            this.ipbImage.Size = new System.Drawing.Size(501, 299);
            this.ipbImage.TabIndex = 0;
            this.ipbImage.TabStop = false;
            // 
            // tmrFadeIn
            // 
            this.tmrFadeIn.Interval = 30;
            this.tmrFadeIn.Tick += new System.EventHandler(this.tmrFadeIn_Tick);
            // 
            // tmrFadeOut
            // 
            this.tmrFadeOut.Interval = 30;
            this.tmrFadeOut.Tick += new System.EventHandler(this.tmrFadeOut_Tick);
            // 
            // frmBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 347);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.pnlProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuilding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Building Robot";
            this.Load += new System.EventHandler(this.frmBuilding_Load);
            this.pnlProgressBar.ResumeLayout(false);
            this.pnlImage.ResumeLayout(false);
            this.pnlImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProgressBar;
        private System.Windows.Forms.ProgressBar pbLoading;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.Label lblMessage;
        private FontAwesome.Sharp.IconPictureBox ipbImage;
        private System.Windows.Forms.Timer tmrFadeIn;
        private System.Windows.Forms.Timer tmrFadeOut;
    }
}