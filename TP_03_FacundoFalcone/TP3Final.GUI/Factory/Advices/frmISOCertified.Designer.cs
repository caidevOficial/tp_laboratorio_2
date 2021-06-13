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
    partial class frmISOCertified {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmISOCertified));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ipbLogoIso = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbCertified = new System.Windows.Forms.ProgressBar();
            this.rtbWarrantyMessage = new System.Windows.Forms.RichTextBox();
            this.timeFadeIn = new System.Windows.Forms.Timer(this.components);
            this.timeFadeOut = new System.Windows.Forms.Timer(this.components);
            this.ipbImage = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbLogoIso)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.ipbLogoIso);
            this.panel1.Location = new System.Drawing.Point(3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 325);
            this.panel1.TabIndex = 0;
            // 
            // ipbLogoIso
            // 
            this.ipbLogoIso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ipbLogoIso.BackgroundImage")));
            this.ipbLogoIso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ipbLogoIso.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ipbLogoIso.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ipbLogoIso.IconColor = System.Drawing.SystemColors.ControlLight;
            this.ipbLogoIso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbLogoIso.IconSize = 321;
            this.ipbLogoIso.Location = new System.Drawing.Point(0, 1);
            this.ipbLogoIso.Name = "ipbLogoIso";
            this.ipbLogoIso.Size = new System.Drawing.Size(340, 321);
            this.ipbLogoIso.TabIndex = 0;
            this.ipbLogoIso.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbCertified);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 32);
            this.panel2.TabIndex = 1;
            // 
            // pbCertified
            // 
            this.pbCertified.Location = new System.Drawing.Point(0, 3);
            this.pbCertified.Name = "pbCertified";
            this.pbCertified.Size = new System.Drawing.Size(647, 29);
            this.pbCertified.Step = 30;
            this.pbCertified.TabIndex = 0;
            // 
            // rtbWarrantyMessage
            // 
            this.rtbWarrantyMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbWarrantyMessage.BackColor = System.Drawing.Color.Black;
            this.rtbWarrantyMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtbWarrantyMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbWarrantyMessage.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rtbWarrantyMessage.Location = new System.Drawing.Point(363, 6);
            this.rtbWarrantyMessage.Name = "rtbWarrantyMessage";
            this.rtbWarrantyMessage.ReadOnly = true;
            this.rtbWarrantyMessage.Size = new System.Drawing.Size(261, 99);
            this.rtbWarrantyMessage.TabIndex = 2;
            this.rtbWarrantyMessage.Text = "";
            // 
            // timeFadeIn
            // 
            this.timeFadeIn.Interval = 30;
            this.timeFadeIn.Tick += new System.EventHandler(this.timeFadeIn_Tick);
            // 
            // timeFadeOut
            // 
            this.timeFadeOut.Interval = 30;
            this.timeFadeOut.Tick += new System.EventHandler(this.timeFadeOut_Tick);
            // 
            // ipbImage
            // 
            this.ipbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ipbImage.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ipbImage.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ipbImage.IconColor = System.Drawing.SystemColors.ControlLight;
            this.ipbImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbImage.IconSize = 199;
            this.ipbImage.Location = new System.Drawing.Point(360, 121);
            this.ipbImage.Name = "ipbImage";
            this.ipbImage.Size = new System.Drawing.Size(263, 199);
            this.ipbImage.TabIndex = 3;
            this.ipbImage.TabStop = false;
            // 
            // frmISOCertified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(647, 379);
            this.Controls.Add(this.ipbImage);
            this.Controls.Add(this.rtbWarrantyMessage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmISOCertified";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certified warranty";
            this.Load += new System.EventHandler(this.frmISOCertified_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbLogoIso)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox ipbLogoIso;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar pbCertified;
        private System.Windows.Forms.RichTextBox rtbWarrantyMessage;
        private System.Windows.Forms.Timer timeFadeIn;
        private System.Windows.Forms.Timer timeFadeOut;
        private FontAwesome.Sharp.IconPictureBox ipbImage;
    }
}