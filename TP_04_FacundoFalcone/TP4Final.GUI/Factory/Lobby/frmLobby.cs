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

using DAO;
using FontAwesome.Sharp;
using Materials;
using Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FactoryForms {

    public partial class frmLobby : Form {

        #region Attributes

        //private event SoundPlayerHandler myDelPlayer;
        //private Thread myPlayerThread;
        private const string EXTENSION_XML = ".xml";
        private const string EXTENSION_TXT = ".txt";
        private frmReports reports;
        private OpenFileDialog openFile;
        private Form activeForm;
        private Panel leftBorderBtn;
        private IconButton currentBtn;
        private static frmException formEx;
        private static frmShutdown formShut;
        private static SerialManager<List<Robot>> smr;
        private static SerialManager<List<MaterialBucket>> smb;
        private SerialManager<List<MaterialBucket>> serialManager;
        private TextManager textManager;
        private static List<Thread> threads;
        private static readonly string frmDashboardSound = "DashboardForm";
        private static readonly string frmWarehouseSound = "WarehouseForm";
        private static readonly string frmManufactureSound = "ManufactureForm";
        private static readonly string frmMachineRoomSound = "MachineRoomForm";
        private static readonly string robotPersistence = "robotPersistence.xml";
        private static readonly string materialsPersistence = "materialsPersistence.xml";
        private static string systemPath = $"{Environment.CurrentDirectory}";
        private static string biographyPath = $"{systemPath}\\Bio";
        private static string persistencePath = $"{systemPath}\\Persistence";
        private static string fullRpersistencePath = $"{persistencePath}\\{robotPersistence}";
        private static string fullMpersistencePath = $"{persistencePath}\\{materialsPersistence}";

        /// <summary>
        /// Struct of RGB colors.
        /// </summary>
        private struct RRGBColors {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        #endregion

        #region Builder

        /// <summary>
        /// Creates the form.
        /// </summary>
        public frmLobby() {
            InitializeComponent();
            activeForm = null;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 90);
            pnlMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            //myDelPlayer += MyPlayerMainMusic;
            threads = new List<Thread>();
            smr = new SerialManager<List<Robot>>();
            smb = new SerialManager<List<MaterialBucket>>();
            serialManager = new SerialManager<List<MaterialBucket>>();
            textManager = new TextManager();
        }

        #endregion

        #region ChildFormMethod

        /// <summary>
        /// Receives a childform and make it an active form
        /// </summary>
        /// <param name="childForm">Child form to make it active.</param>
        private void OpenChildForm(Form childForm) {
            if (!(activeForm is null)) {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblCurrentChildFormTitle.Text = childForm.Text;
        }

        #endregion

        #region StaticMethod

        /// <summary>
        /// Opens a new form of exceptions with the exception passed by parameter.
        /// </summary>
        /// <param name="e">Exception of the form.</param>
        public static void FormExceptionHandler(Exception e) {

            formEx = new frmException(e);
            if (formEx.ShowDialog() == DialogResult.OK) {
                MessageBox.Show("Thanks", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Opens a new form of frmISOCertified with the Name of the product passed by parameter.
        /// </summary>
        /// <param name="productName">Name of the product to show.</param>
        public static void FormShowDialogHandler(Form myForm) {
            myForm.ShowDialog();
        }

        #endregion

        #region OnLoadEventHandler

        /// <summary>
        /// Event handler of the clock of the main form, 
        /// which is updated every second.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrDateTime_Tick(object sender, EventArgs e) {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }


        //private void MyPlayerMainMusic(object soundName) {
        //    if (this.InvokeRequired) {
        //        SoundPlayerHandler sp = new SoundPlayerHandler(MyPlayerMainMusic);
        //        this.BeginInvoke(sp);
        //    } else {
        //        MyPlayer player = new MyPlayer();
        //        player.Play((string)soundName,false);
        //    }
        //}

        /// <summary>
        /// Load Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLobby_Load(object sender, EventArgs e) {
            frmOpening opening = new frmOpening();
            opening.ShowDialog();
            
            //myPlayerThread = new Thread(new ParameterizedThreadStart(this.MyPlayerMainMusic));
            //threads.Add(myPlayerThread);
            //threads[threads.Count - 1].Start("MainTheme");
            
            //myPlayerThread.Start("MainTheme");

            try {
                if (File.Exists(fullMpersistencePath)) {
                    RobotFactory.Buckets = smb.Read(fullMpersistencePath);
                }
                if (File.Exists(fullRpersistencePath)) {
                    //RobotFactory.Robots = smr.Read(fullRpersistencePath);
                }
                RobotFactory.Robots = DataAccessManager.GetRobots();
                RobotFactory.ChargeBiography(biographyPath);
            } catch (Exception ex) {
                frmLobby.FormExceptionHandler(ex);
            }
        }

        #endregion

        #region ButtonsEventHandlers

        /// <summary>
        /// Resets the effects in the form.
        /// </summary>
        private void Reset() {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.White;
            lblCurrentChildFormTitle.Text = "Home";
        }

        /// <summary>
        /// Enables the color effects in the actual button.
        /// </summary>
        /// <param name="senderBtn"></param>
        /// <param name="color"></param>
        private void ActivateButton(object senderBtn, Color color) {
            if (!(senderBtn is null)) {

                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextAboveImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        /// <summary>
        /// Disables the color effect in the actual button.
        /// </summary>
        private void DisableButton() {
            if (!(currentBtn is null)) {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.OrangeRed;
                currentBtn.TextImageRelation = TextImageRelation.ImageAboveText;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
                lblCurrentChildFormTitle.Text = string.Empty;
            }
        }

        /// <summary>
        /// Event handler of the button that opens the frmFactory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMachineRoom_Click(object sender, EventArgs e) {
            try {
                ActivateButton(sender, RRGBColors.color5);
                MyPlayer player = new MyPlayer();
                player.Play(frmMachineRoomSound, false);
                OpenChildForm(new frmFactory());
            } catch (Exception exe) {
                FormExceptionHandler(exe);
            }
        }

        /// <summary>
        /// Event handler of the button that opens the frmWarehouse.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWarehouse_Click(object sender, EventArgs e) {
            try {
                ActivateButton(sender, RRGBColors.color4);
                MyPlayer player = new MyPlayer();
                player.Play(frmWarehouseSound, false);
                OpenChildForm(new frmWarehouse());
            } catch (Exception exe) {
                FormExceptionHandler(exe);
            }
        }

        /// <summary>
        /// Event handler of the button that opens the frmSelectModel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManufacture_Click(object sender, EventArgs e) {
            try {
                ActivateButton(sender, RRGBColors.color6);
                MyPlayer player = new MyPlayer();
                player.Play(frmManufactureSound, false);
                OpenChildForm(new frmSelectModel());
            } catch (Exception exe) {
                FormExceptionHandler(exe);
            }
        }

        /// <summary>
        /// Event handler of the button that opens the frmDashboard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDashboard_Click(object sender, EventArgs e) {
            try {
                ActivateButton(sender, RRGBColors.color1);
                MyPlayer player = new MyPlayer();
                player.Play(frmDashboardSound, false);
                OpenChildForm(new frmDashboard());
            } catch (Exception exe) {
                FormExceptionHandler(exe);
            }
        }

        #endregion

        #region ClosingEvent

        /// <summary>
        /// EventHandler of the formClosing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLobby_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Are you sure to quit?", "Leaving", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
                RobotFactory.SaveDataOfFactory();
                formShut = new frmShutdown();
                formShut.ShowDialog();
                
                foreach (Thread item in threads) {
                    if (item.IsAlive) {
                        item.Abort();
                    }
                }
                
                //MyPlayer player = new MyPlayer();
                //player.Stop();
                
                this.Dispose();
            } else {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// EventHandler of the button Close.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibtnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// EventHandler of the logo that activate the home screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbLogo_Click(object sender, EventArgs e) {
            this.Reset();
            if(!(activeForm is null)) {
                activeForm.Close();
            }
            frmJoke joke = new frmJoke();
            joke.ShowDialog();
        }

        #endregion

        private void XmlFileToolStripMenuItem_Click(object sender, EventArgs e) {
            StringBuilder data = new StringBuilder();
            string file = string.Empty;
            List<MaterialBucket> myList;
            openFile = new OpenFileDialog();
            openFile.InitialDirectory = persistencePath;
            if (openFile.ShowDialog() == DialogResult.OK) {
                file = openFile.FileName;
                if (Path.GetExtension(file) == EXTENSION_XML) {
                    myList = new List<MaterialBucket>(serialManager.Read(file));
                    foreach (MaterialBucket item in myList) {
                        data.AppendLine(item.Information());
                    }
                    reports = new frmReports(data.ToString());
                    reports.ShowDialog();
                } else {
                    MessageBox.Show("Error opening the file", "Invalid Extension", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtFileToolStripMenuItem_Click_1(object sender, EventArgs e) {
            string text = string.Empty;
            string file = string.Empty;
            openFile = new OpenFileDialog();
            openFile.InitialDirectory = $"{systemPath}\\Manufacture_Historial";
            if (openFile.ShowDialog() == DialogResult.OK) {
                file = openFile.FileName;
                if (Path.GetExtension(file) == EXTENSION_TXT) {
                    text = textManager.Read(file);
                    reports = new frmReports(text);
                    reports.ShowDialog();
                } else {
                    MessageBox.Show("Error opening the file", "Invalid Extension", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
