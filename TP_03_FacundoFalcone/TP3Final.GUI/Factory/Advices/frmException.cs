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
using System.Windows.Forms;

namespace FactoryForms {
    public partial class frmException : Form {

        #region Attributes

        private TextManager tm;
        private Exception formEx;
        private string path = $"{Environment.CurrentDirectory}\\Logs";
        private string filename = "Exceptions.txt";

        #endregion

        #region Builders

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public frmException() {
            InitializeComponent();
        }

        /// <summary>
        /// Creates the entity with an exception.
        /// </summary>
        /// <param name="e"></param>
        public frmException(Exception e) : this() {
            formEx = e;
        }

        #endregion

        #region CloseEvents

        /// <summary>
        /// EventHandler of the btnAccept.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccept_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// EventHndler of the formClosing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmException_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Do you want to close?", "Leaving", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No) {
                e.Cancel = true;
            } else {
                this.Dispose();
            }
        }

        #endregion

        #region LoadEventHandler

        /// <summary>
        /// Prints on the form the message of the exception.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmException_Load(object sender, EventArgs e) {
            tm = new TextManager();
            rtbExceptionMsg.Text = $"Exception:\n{formEx.Message}";
            tm.SaveFull(path, filename, formEx.ToString());
            MyPlayer.Play("ExceptionForm", false);
        }

        #endregion

    }
}
