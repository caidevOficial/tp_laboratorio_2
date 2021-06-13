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
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FactoryForms {
    public partial class frmWarehouse : Form {

        #region Attributes

        private bool robotsSelected;
        private readonly string systemImagePath = $"{Environment.CurrentDirectory}\\Images";

        #endregion

        #region Builder

        /// <summary>
        /// Creates the form.
        /// </summary>
        public frmWarehouse() {
            InitializeComponent();
            robotsSelected = true;
        }

        #endregion

        #region OnLoadEvent

        /// <summary>
        /// Event handlers of the Load Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmWarehouse_Load(object sender, EventArgs e) {
            rtbInfoRobot.Visible = false;
            cmbWarehouseShow.DataSource = new List<string>() { "Robots", "Materials" };
        }

        #endregion

        #region Combo&DataGridEventsHandlers

        /// <summary>
        /// Event handler of the comboBox that change the view in the datagrid
        /// bassed of the selected index of the combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbWarehouseShow_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbWarehouseShow.SelectedItem.ToString() == "Robots") {
                robotsSelected = true;
                rtbInfoRobot.Visible = robotsSelected;
                //paso lista ordenada por un valor en concreto
                UpdateDataGridView(RobotFactory.Robots.OrderBy(x => x.SerialNumber).ToList());
                dgvRobots.Columns[0].HeaderText = "Serial N°";
                dgvRobots.Columns[3].HeaderText = "For Ride";
                dgvRobots.Columns[dgvRobots.Columns.Count - 1].HeaderText = "Pieces";

            } else if (cmbWarehouseShow.SelectedItem.ToString() == "Materials") {
                robotsSelected = false;
                // Paso lista como viene
                UpdateDataGridView(RobotFactory.Buckets);
                dgvRobots.Columns[0].Visible = false;
                dgvRobots.Columns[1].HeaderText = "Material";
                dgvRobots.Columns[dgvRobots.Columns.Count - 1].HeaderText = "Cantidad";
                rtbInfoRobot.Visible = false;
            }
            dgvRobots.AutoResizeColumns();
        }

        /// <summary>
        /// Event handlers of the datagrid when the user clic on a specific row.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRobots_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            try {
                if (robotsSelected) {
                    rtbInfoRobot.Text = string.Empty;
                    pbImageRobot.Visible = true;
                    pbImageRobot.Image = null;
                    Robot robot = dgvRobots.CurrentRow.DataBoundItem as Robot;
                    MyPlayer.Play($"Create{robot.Model}", false);
                    rtbInfoRobot.Text = robot.Information();
                    pbImageRobot.Image = Image.FromFile($"{systemImagePath}\\{robot.Model}.png");
                } else {
                    pbImageRobot.Visible = false;
                }
            } catch (Exception exe) {
                frmLobby.FormExceptionHandler(exe);
            }

        }

        private void UpdateDataGridView<T>(List<T> list) {
            dgvRobots.DataSource = null;
            dgvRobots.DataSource = list;
        }

        #endregion

    }
}
