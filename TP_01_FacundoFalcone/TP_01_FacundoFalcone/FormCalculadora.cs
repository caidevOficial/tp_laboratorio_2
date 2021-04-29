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

using Entidades;
using System;
using System.Media;
using System.Windows.Forms;

namespace TP_01_FacundoFalcone {
    public partial class FormCalculadora : Form {
        private readonly string pathToMusic = Environment.CurrentDirectory;
        private readonly SoundPlayer myPlayer = new SoundPlayer();
        private bool isPlaying = true;

        #region Load_Events

        /// <summary>
        /// Initializes the components.
        /// </summary>
        public FormCalculadora() {
            InitializeComponent();
        }

        /// <summary>
        /// On load the app, disables the group box of convert buttons 
        /// and loads the background music.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e) {
            grpConvert.Enabled = false;
            this.Music(myPlayer);
        }

        #endregion

        #region Media

        /// <summary>
        /// Plays an 8-bit audio of Dragon Ball Z in '.wav' format.
        /// </summary>
        private void Music(SoundPlayer myPlayer) {
            myPlayer.SoundLocation = this.pathToMusic + "/Media/DBZ.wav";
            myPlayer.PlayLooping();
        }

        /// <summary>
        /// Plays or pauses the background music of the app, also changes the button icon with each press.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayPause_Click(object sender, EventArgs e) {
            if (isPlaying) {
                myPlayer.Stop();
                btnPlayPause.ImageIndex = 1; // Play icon.
            } else {
                myPlayer.PlayLooping();
                btnPlayPause.ImageIndex = 0; // Pause icon.
            }
            isPlaying = !isPlaying;
        }

        #endregion

        #region Operator_Event

        /// <summary>
        /// Disables the group box of the convert buttons.
        /// </summary>
        private void BlockConvertButtons() {
            grpConvert.Enabled = false;
        }

        /// <summary>
        /// Receives two valid numbers  and an operator as a string-formatto operate between them.
        /// </summary>
        /// <param name="theNumber1">First number in string-format to operate.</param>
        /// <param name="theNumber2">Second number in string-format to operate.</param>
        /// <param name="theOperator">Operator as a String format to operate.</param>
        /// <returns>The result of the operation between the two numbers.</returns>
        private static double Operar(string theNumber1, string theNumber2, string theOperator) {
            Numero num1 = new Numero(theNumber1);
            Numero num2 = new Numero(theNumber2);

            return Calculadora.Operar(num1, num2, theOperator);
        }

        /// <summary>
        /// Operates the App and its math calculus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e) {
            string operador;
            if (String.IsNullOrWhiteSpace(txtNumero1.Text) || String.IsNullOrWhiteSpace(txtNumero2.Text)) {
                MessageBox.Show("You forget at least one number, check please!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                if (!Double.TryParse(txtNumero1.Text, out double garbageNumber) || !Double.TryParse(txtNumero2.Text, out garbageNumber) || Double.IsNaN(garbageNumber)) {
                    MessageBox.Show("Invalid Decimal or Integer numbers, check please!", "Error: Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    if (cmbOperador.SelectedItem == null) {
                        cmbOperador.Text = "+";
                        operador = "+";
                    } else {
                        operador = cmbOperador.SelectedItem.ToString();
                    }
                    grpConvert.Enabled = true;
                    btnConvertirABinario.Enabled = true;
                    btnConvertirADecimal.Enabled = false;
                    lblResultado.Text = Operar(txtNumero1.Text.Replace(".", ","), txtNumero2.Text.Replace(".", ","), operador).ToString();
                }
            }
        }

        #endregion

        #region Convert_Events

        /// <summary>
        /// Converts a Double number to a Binary-Format number and shows it in the App's Display.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e) {
            Numero number = new Numero();

            bool couldParse = Double.TryParse(lblResultado.Text, out double checkResult);

            if (!couldParse) {
                MessageBox.Show("I haven't Power to Convert a negative number to a Binary number using Complement A2.\nPlease wait for the next update, assuming there will be.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            lblResultado.Text = number.DecimalBinario(lblResultado.Text);
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;
        }

        /// <summary>
        /// Converts a binary-format string to a Double number and shows it in the App's Display.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e) {
            Numero number = new Numero();
            lblResultado.Text = number.BinarioDecimal(lblResultado.Text);
            if (lblResultado.Text.StartsWith("Valor")) {
                BlockConvertButtons();
                lblResultado.Text = lblResultado.Text;
            } else {
                btnConvertirABinario.Enabled = true;
            }
            btnConvertirADecimal.Enabled = false;
            btnConvertirABinario.Enabled = true;
        }

        #endregion

        #region Closing_events

        /// <summary>
        /// Tries to close the app if the user click Yes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Do you want to quit this wonderful app?", "Choose wisely", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Dispose();
            }
        }

        /// <summary>
        /// Tries to close the app if the user click Yes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Do you want to quit this wonderful app?", "Choose wisely", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                e.Cancel = true;
            } else {
                Dispose();
            }
        }

        #endregion

        #region Clean_Events

        /// <summary>
        /// Cleans all the fields of the App.
        /// </summary>
        private void Limpiar() {
            string empty = "";
            txtNumero1.Text = empty;
            txtNumero2.Text = empty;
            cmbOperador.SelectedIndex = -1;
            lblResultado.Text = "Become a Hero!";
        }

        /// <summary>
        /// Cleans the App from old data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e) {
            Limpiar();
            grpConvert.Enabled = false;
            txtNumero1.Focus();
        }

        #endregion

    }
}
