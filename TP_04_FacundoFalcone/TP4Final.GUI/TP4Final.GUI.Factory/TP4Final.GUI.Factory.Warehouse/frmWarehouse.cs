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

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Models;

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
            this.InitializeComponent();
            this.robotsSelected = true;
        }

        #endregion

        #region OnLoadEvent

        /// <summary>
        /// Event handlers of the Load Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmWarehouse_Load(object sender, EventArgs e) {
            this.rtbInfoRobot.Visible = false;
            this.cmbWarehouseShow.DataSource = new List<string>() { "Robots", "Materials" };
            this.dgvRobots.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            if (this.cmbWarehouseShow.SelectedItem.ToString() == "Robots") {
                this.robotsSelected = true;
                this.rtbInfoRobot.Visible = robotsSelected;
                this.txtSearch.Visible = true;
                this.ibtnSearch.Visible = true;
                this.UpdateDataGridRobot(RobotFactory.Robots);

            } else if (cmbWarehouseShow.SelectedItem.ToString() == "Materials") {
                this.robotsSelected = false;
                this.txtSearch.Visible = false;
                this.ibtnSearch.Visible = false;
                this.UpdateDataGridView(RobotFactory.Buckets);
                this.dgvRobots.Columns[0].Visible = false;
                this.dgvRobots.Columns[1].HeaderText = "Material";
                this.dgvRobots.Columns[2].HeaderText = "Cantidad";
                this.dgvRobots.Columns[3].Visible = false;
                this.rtbInfoRobot.Visible = false;
            }
            this.dgvRobots.AutoResizeColumns();
        }

        /// <summary>
        /// Event handlers of the datagrid when the user clic on a specific row.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRobots_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            try {
                if (this.robotsSelected) {
                    this.rtbInfoRobot.Text = string.Empty;
                    this.pbImageRobot.Visible = true;
                    this.pbImageRobot.Image = null;
                    Robot robot = dgvRobots.CurrentRow.DataBoundItem as Robot;
                    MyPlayer player = new MyPlayer();
                    player.Play($"Create{robot.Model}");
                    this.rtbInfoRobot.Text = robot.Information();
                    this.pbImageRobot.Image = Image.FromFile($"{systemImagePath}\\{robot.Model}.png");
                } else {
                    this.pbImageRobot.Visible = false;
                }
            } catch (Exception exe) {
                frmLobby.FormExceptionHandler(exe);
            }
        }

        /// <summary>
        /// Updates the datagridView and its columns with a list of Robots.
        /// </summary>
        /// <param name="list"></param>
        private void UpdateDataGridRobot(List<Robot> list) {
            this.UpdateDataGridView(list.OrderBy(x => x.SerialNumber).ToList());
            this.dgvRobots.Columns[0].HeaderText = "Serial N°";
            this.dgvRobots.Columns[3].HeaderText = "For Ride";
            this.dgvRobots.Columns[dgvRobots.Columns.Count - 1].HeaderText = "Pieces";
        }

        /// <summary>
        /// Updates the datagridView with a generic list.
        /// </summary>
        /// <typeparam name="T">List type T.</typeparam>
        /// <param name="list">List of type T.</param>
        private void UpdateDataGridView<T>(List<T> list) {
            this.dgvRobots.DataSource = null;
            this.dgvRobots.DataSource = list;
        }

        #endregion

        #region TextBoxEventHandler

        /// <summary>
        /// Search into the list of robots, is exist at least one robot with the
        /// name or origin indicated by the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_TextChanged(object sender, EventArgs e) {
            List<Robot> robots = new List<Robot>();
            if (this.robotsSelected) {
                string search = this.txtSearch.Text.Trim().ToLower();
                if (!String.IsNullOrWhiteSpace(search)) {
                    foreach (Robot item in RobotFactory.Robots) {
                        if (item.Model.ToString().ToLower().Contains(search) ||
                            item.Origin.ToString().ToLower().Contains(search)) {
                            robots.Add(item);
                        }
                    }
                    this.UpdateDataGridRobot(robots);
                } else {
                    this.UpdateDataGridRobot(RobotFactory.Robots);
                }
            }
        }

        #endregion
    }
}
