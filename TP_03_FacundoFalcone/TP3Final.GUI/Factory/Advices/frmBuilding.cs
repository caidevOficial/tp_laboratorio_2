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
using System.Windows.Forms;

namespace FactoryForms {
    public partial class frmBuilding : Form {
        public frmBuilding() {
            InitializeComponent();
        }

        #region OnLoadEvent

        /// <summary>
        /// Event Handler Of Load Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBuilding_Load(object sender, EventArgs e) {
            this.Opacity = 0.0;
            this.pbLoading.Value = 0;
            this.pbLoading.Minimum = 0;
            this.pbLoading.Maximum = 100;
            this.tmrFadeIn.Start();
        }

        #endregion

        #region EventTimer

        /// <summary>
        /// Event Handler Of the time fade in.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrFadeIn_Tick(object sender, EventArgs e) {
            if (this.Opacity < 1) {
                this.Opacity += 0.05;
            }
            if (this.pbLoading.Value < 100) {
                this.pbLoading.Value += 1;
            } else {
                tmrFadeIn.Stop();
                tmrFadeOut.Start();
            }
        }

        /// <summary>
        /// Event Handler Of the time fade out.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrFadeOut_Tick(object sender, EventArgs e) {
            if (this.Opacity > 0) {
                this.Opacity -= 0.1;
            }
            if (this.pbLoading.Value < 100) {
                this.pbLoading.Value += 1;
            }
            if (this.Opacity == 0) {
                this.Close();
            }
        }

        #endregion

    }
}
