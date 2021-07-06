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

using Models;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FactoryForms {
    public partial class frmISOCertified : Form {

        #region Attributes

        private Random rd;
        private TextManager logger;
        private string productName;
        private string warrantyMessage;
        private string path = $"{Environment.CurrentDirectory}\\Manufacture_Historial";
        private readonly string systemImagePath = $"{Environment.CurrentDirectory}\\Images";
        private readonly string filename = "ManufactureBinnacle.txt";

        #endregion

        #region Builders

        public frmISOCertified() {
            InitializeComponent();
            logger = new TextManager();
        }

        public frmISOCertified(string productName) : this() {
            this.productName = productName;
            rd = new Random();
        }

        #endregion

        /// <summary>
        /// Sets a message with the model of the robot, 
        /// the batch number and the manufacture date.
        /// </summary>
        /// <returns>The message of the warranty.</returns>
        private string WarrantyMessage() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Product: {this.productName}");
            data.AppendLine($"Manufacture Batch: {this.rd.Next(500, 900)}-{this.rd.Next(500, 900)}-{this.rd.Next(500, 900)}");
            data.AppendLine($"Manufacture Date: {DateTime.Now}");
            return data.ToString();
        }

        #region OnLoad

        /// <summary>
        /// EventHandler of the Load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmISOCertified_Load(object sender, EventArgs e) {
            this.Opacity = 0.0;
            this.pbCertified.Value = 0;
            this.pbCertified.Minimum = 0;
            this.pbCertified.Maximum = 100;
            this.timeFadeIn.Start();
            ipbImage.BackgroundImageLayout = ImageLayout.Zoom;
            ipbImage.BackgroundImage = Image.FromFile($"{this.systemImagePath}\\{this.productName}.png");
            warrantyMessage = WarrantyMessage();
            rtbWarrantyMessage.Text = warrantyMessage;
            logger.SaveFull(path, filename, warrantyMessage);
        }

        #endregion

        #region TimerEventHandlers

        /// <summary>
        /// EventHandler of the Timer Fade In.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeFadeIn_Tick(object sender, EventArgs e) {
            if (this.Opacity < 1) {
                this.Opacity += 0.05;
            }
            if (this.pbCertified.Value < 100) {
                this.pbCertified.Value += 1;
            } else {
                timeFadeIn.Stop();
                timeFadeOut.Start();
            }
        }

        /// <summary>
        /// EventHandler of the Timer Fade Out.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeFadeOut_Tick(object sender, EventArgs e) {
            if (this.Opacity > 0) {
                this.Opacity -= 0.1;
            }
            if (this.pbCertified.Value < 100) {
                this.pbCertified.Value += 1;
            }
            if (this.Opacity == 0) {
                this.Close();
            }
        }

        #endregion

    }
}
