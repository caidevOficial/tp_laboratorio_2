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

using Materials;
using Models;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace FactoryForms {
    public partial class frmFactory : Form {

        #region Attributes

        private bool isEnabled;

        #endregion

        #region Builder

        /// <summary>
        /// Creates the Form.
        /// </summary>
        public frmFactory() {
            InitializeComponent();
            isEnabled = false;
            LockButtons(isEnabled);
        }

        #endregion

        #region OnLoad

        private void frmFactory_Load(object sender, EventArgs e) {
            chartMaterialsStock.Visible = false;
            chartMaterialsStock.BackColor = Color.Transparent;
            chartMaterialsStock.ChartAreas[0].BackColor = Color.Transparent;
            chartMaterialsStock.Legends[0].BackColor = Color.Transparent;
            try {
                if (RobotFactory.Buckets.Count > 0) {
                    isEnabled = !isEnabled;
                    LockButtons(isEnabled);
                    GetMaterialStock();
                }
            } catch (Exception ex) {
                frmLobby.FormExceptionHandler(ex);
            }
        }

        #endregion

        #region UpdateVisual

        /// <summary>
        /// Update and configure the factory material stock within the pie chart.
        /// </summary>
        private void GetMaterialStock() {
            ArrayList amount = new ArrayList();
            ArrayList percentage = new ArrayList();
            ArrayList product = new ArrayList();
            if (RobotFactory.Buckets.Count > 0) {
                chartMaterialsStock.Visible = true;
                chartMaterialsStock.Update();

                foreach (MaterialBucket item in RobotFactory.Buckets) {
                    amount.Add(item.AmoutProduct);
                    product.Add(item.NameProductOfBucket);
                }

                chartMaterialsStock.Series[0].Points.DataBindXY(product, amount);
            }
        }

        #endregion

        #region LockButtons

        /// <summary>
        /// Locks the button 'btnInitializeFactory'.
        /// </summary>
        /// <param name="unloqued">Boolean state that indicate if the button should be locked or not.</param>
        private void LockButtons(bool unloqued) {
            this.btnInitializeFactory.Enabled = !unloqued;
            this.btnInitializeFactory.Visible = !unloqued;
            this.btnImportStock.Enabled = unloqued;
        }

        #endregion

        #region ButtonsEventHandler

        /// <summary>
        /// EventHandler of the button 'btnInitializeFactory'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInitializeFactory_Click(object sender, EventArgs e) {
            if (!isEnabled && RobotFactory.InitFactoryAndStock()) {
                isEnabled = !isEnabled;
                this.GetMaterialStock();
                LockButtons(isEnabled);
            } else {
                MessageBox.Show("The factory has been already initialized");
            }
        }

        /// <summary>
        /// EventHandler of the button 'btnImportStock'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportStock_Click(object sender, EventArgs e) {
            RobotFactory.UpdateRawMaterialsOfBuckets();
            this.GetMaterialStock();
            RobotFactory.SaveDataOfFactory();
        }

        #endregion

    }
}
