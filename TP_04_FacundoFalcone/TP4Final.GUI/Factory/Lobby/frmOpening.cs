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
using System.Windows.Forms;

namespace FactoryForms {
    public partial class frmOpening : Form {

        #region Attributes

        private List<string> messages;

        #endregion

        #region Builder

        /// <summary>
        /// Creates the form.
        /// </summary>
        public frmOpening() {
            InitializeComponent();
        }

        #endregion

        #region OnLoad

        /// <summary>
        /// Load EventHandler of the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOpening_Load(object sender, EventArgs e) {
            this.Opacity = 0.0;
            this.pbProgress.Value = 0;
            this.pbProgress.Minimum = 0;
            this.pbProgress.Maximum = 100;
            this.timeFadeIn.Start();
            messages = new List<string>() {
                "Loading Resources...",
                "Hiring New Employees...",
                "Turning on the Machines...",
                "Preparing Designs...",
                "Contacting Clients",
                "Preparing Coffee..."
            };
            try {
                MyPlayer.Play("Opening", false);

            } catch (Exception exe) {
                frmLobby.FormExceptionHandler(exe);
            }
        }

        #endregion

        #region EventHandlers

        /// <summary>
        /// Sets a message in the form bassed on the 
        /// complete's percentaje of the progressBar.
        /// </summary>
        /// <param name="value">Value to select a message.</param>
        /// <returns>The message assigned.</returns>
        private string AssignMessage(int value) {
            string message = string.Empty;
            if (value < 17)
                message = messages[0];
            else if (value > 16 && value < 33)
                message = messages[1];
            else if (value > 32 && value < 48)
                message = messages[2];
            else if (value > 48 && value < 65)
                message = messages[3];
            else if (value > 64 && value < 81)
                message = messages[4];
            else
                message = messages[5];
            return message;
        }

        /// <summary>
        /// EventHandler of the Timer Fade In.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeFadeIn_Tick(object sender, EventArgs e) {
            if (this.Opacity < 1) {
                this.Opacity += 0.05;
            }
            if (this.pbProgress.Value < 100) {
                this.pbProgress.Value += 1;
                lblMessage.Text = this.AssignMessage(this.pbProgress.Value);
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
            if (this.pbProgress.Value < 100) {
                lblMessage.Text = this.AssignMessage(this.pbProgress.Value);
                this.pbProgress.Value += 1;
            }
            if (this.Opacity == 0) {
                this.Close();
            }
        }

        #endregion

    }
}
