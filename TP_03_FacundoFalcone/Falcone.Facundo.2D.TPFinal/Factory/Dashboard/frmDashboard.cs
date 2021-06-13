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
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FactoryForms {
    public partial class frmDashboard : Form {

        #region Builders

        public frmDashboard() {
            InitializeComponent();
            chartMaterialsStock.Visible = false;
            chartMaterialsStock.BackColor = Color.Transparent;
            chartMaterialsStock.ChartAreas[0].BackColor = Color.Transparent;
            chartMaterialsStock.Legends[0].BackColor = Color.Transparent;
            chartRobotStock.Visible = false;
            chartRobotStock.BackColor = Color.Transparent;
            chartRobotStock.ChartAreas[0].BackColor = Color.Transparent;
            chartRobotStock.Legends[0].BackColor = Color.Transparent;
            GetMaterialStock();
            GetRobotStock();
        }

        #endregion

        #region UpdatePieChart

        /// <summary>
        /// Update and configure the factory material stock within the pie chart.
        /// </summary>
        private void GetMaterialStock() {
            ArrayList amount = new ArrayList();
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

        /// <summary>
        /// Update and configure the factory robot stock within the pie chart.
        /// </summary>
        private void GetRobotStock() {
            Dictionary<string, int> stock = new Dictionary<string, int>();
            if (RobotFactory.Robots.Count > 0) {
                chartRobotStock.Visible = true;
                chartRobotStock.Update();

                foreach (Robot item in RobotFactory.Robots) {
                    if (!stock.ContainsKey(item.Model.ToString())) {
                        stock.Add(item.Model.ToString(), 1);
                    } else {
                        stock[item.Model.ToString()] += 1;
                    }
                }

                chartRobotStock.Series[0].Points.DataBindXY(stock.Keys, stock.Values);
            }
        }

        #endregion
    }
}
