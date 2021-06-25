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
    partial class frmOpening {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpening));
            this.pnlMainImage = new System.Windows.Forms.Panel();
            this.ipbMainImage = new FontAwesome.Sharp.IconPictureBox();
            this.pnlProgressBar = new System.Windows.Forms.Panel();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lblMessage = new System.Windows.Forms.Label();
            this.timeFadeIn = new System.Windows.Forms.Timer(this.components);
            this.timeFadeOut = new System.Windows.Forms.Timer(this.components);
            this.pnlMainImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbMainImage)).BeginInit();
            this.pnlProgressBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainImage
            // 
            this.pnlMainImage.Controls.Add(this.ipbMainImage);
            this.pnlMainImage.Location = new System.Drawing.Point(7, 12);
            this.pnlMainImage.Name = "pnlMainImage";
            this.pnlMainImage.Size = new System.Drawing.Size(553, 339);
            this.pnlMainImage.TabIndex = 0;
            // 
            // ipbMainImage
            // 
            this.ipbMainImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ipbMainImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ipbMainImage.BackgroundImage")));
            this.ipbMainImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ipbMainImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipbMainImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipbMainImage.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ipbMainImage.IconColor = System.Drawing.SystemColors.ControlText;
            this.ipbMainImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbMainImage.IconSize = 339;
            this.ipbMainImage.Location = new System.Drawing.Point(0, 0);
            this.ipbMainImage.Name = "ipbMainImage";
            this.ipbMainImage.Size = new System.Drawing.Size(553, 339);
            this.ipbMainImage.TabIndex = 0;
            this.ipbMainImage.TabStop = false;
            // 
            // pnlProgressBar
            // 
            this.pnlProgressBar.Controls.Add(this.pbProgress);
            this.pnlProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProgressBar.Location = new System.Drawing.Point(0, 391);
            this.pnlProgressBar.Name = "pnlProgressBar";
            this.pnlProgressBar.Size = new System.Drawing.Size(569, 44);
            this.pnlProgressBar.TabIndex = 1;
            // 
            // pbProgress
            // 
            this.pbProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProgress.ForeColor = System.Drawing.Color.OrangeRed;
            this.pbProgress.Location = new System.Drawing.Point(0, 0);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(569, 44);
            this.pbProgress.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(10, 362);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(74, 20);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Message";
            // 
            // timeFadeIn
            // 
            this.timeFadeIn.Interval = 70;
            this.timeFadeIn.Tick += new System.EventHandler(this.timeFadeIn_Tick);
            // 
            // timeFadeOut
            // 
            this.timeFadeOut.Interval = 70;
            this.timeFadeOut.Tick += new System.EventHandler(this.timeFadeOut_Tick);
            // 
            // frmOpening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(569, 435);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pnlProgressBar);
            this.Controls.Add(this.pnlMainImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOpening";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.frmOpening_Load);
            this.pnlMainImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbMainImage)).EndInit();
            this.pnlProgressBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainImage;
        private FontAwesome.Sharp.IconPictureBox ipbMainImage;
        private System.Windows.Forms.Panel pnlProgressBar;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer timeFadeIn;
        private System.Windows.Forms.Timer timeFadeOut;
    }
}