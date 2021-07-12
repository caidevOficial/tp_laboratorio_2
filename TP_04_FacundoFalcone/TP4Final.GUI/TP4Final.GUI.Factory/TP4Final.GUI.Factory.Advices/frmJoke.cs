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
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace FactoryForms {

    public delegate void Horse(object path);

    public partial class frmJoke : Form {

        private Thread horseThread;
        private event Horse horseEvent;
        double counter;

        public frmJoke() {
            InitializeComponent();
            this.counter = 0;
            horseEvent += SetGifInPictureBox;
        }

        private void frmJoke_Load(object sender, EventArgs e) {
            this.tmrFade_In.Start();
            ChargeAnimatedGif("H_");
            //ChargeAnimatedGif("Logo_Robot_Head");
        }

        /// <summary>
        /// Sets various images in a picture box simulating a gif.
        /// </summary>
        /// <param name="path"></param>
        private void SetGifInPictureBox(object path) {
            string newPath = (string)path;
            for (int i = 1; i < 16; i++) {
                this.pbHorseImage.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"{newPath}{i}");
                Thread.Sleep(100);
                if (i == 15) {
                    i = 1;
                }
            }
        }

        /// <summary>
        /// Charge the animated gif.
        /// </summary>
        /// <param name="path">Path of the gif</param>
        private void ChargeAnimatedGif(object path) {
            if (this.pbHorseImage.InvokeRequired) {
                Horse horseEv = new Horse(this.SetGifInPictureBox);
                this.BeginInvoke(horseEv, new object[] { path });
            }
            this.horseThread = new Thread(new ParameterizedThreadStart(horseEvent));
            horseThread.Start(path);
        }

        /// <summary>
        /// EventHandler of the form closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmJoke_FormClosing(object sender, FormClosingEventArgs e) {
            if (this.horseThread.IsAlive) {
                this.horseThread.Abort();
            }
        }

        /// <summary>
        /// EventHandler of the fade in.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrFade_In_Tick(object sender, EventArgs e) {
            if (this.counter < 100) {
                this.counter += 1;

            } else {
                tmrFade_In.Stop();
                tmrFade_Out.Start();
            }
        }

        /// <summary>
        /// EventHandler of the fade out.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrFade_Out_Tick(object sender, EventArgs e) {
            if (this.counter < 100) {
                this.counter += 1;
            }
            if (this.counter == 100) {
                if (this.horseThread.IsAlive) {
                    this.horseThread.Abort();
                }
                this.Close();
            }
        }
    }
}
