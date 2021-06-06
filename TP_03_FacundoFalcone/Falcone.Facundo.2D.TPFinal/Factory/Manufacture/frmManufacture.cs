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

using Enums;
using Exceptions;
using Models;
using System;
using System.Windows.Forms;

namespace FactoryForms {
    public partial class frmSelectModel : Form {

        #region Attributes

        private int amountOfMaterials;
        private string filename;
        private readonly string pathBiography = $"{Environment.CurrentDirectory}\\Bio\\";
        private string absBioPath;

        #endregion

        #region Builder

        /// <summary>
        /// Creates the form.
        /// </summary>
        public frmSelectModel() {
            InitializeComponent();
        }

        #endregion

        #region AuxiliarMethods

        /// <summary>
        /// Creates multiples pieces of the robot.
        /// </summary>
        /// <param name="metalType">Type Of metal of the robot.</param>
        /// <param name="origin">Origin of the robot.</param>
        /// <param name="modelName">Model name of the robot.</param>
        /// <param name="amountOfMaterials">Amount of materials that needs the robot.</param>
        /// <param name="amountHead">Amount of heads of the robot.</param>
        /// <param name="amounTorso">Amount of torsos of the robot.</param>
        /// <param name="amountArms">Amount of arms of the robot.</param>
        /// <param name="amountLegs">Amount of legs of the robot.</param>
        /// <param name="amountTail">Amount of tails of the robot.</param>
        /// <param name="isRidable">boolean state that indicates if the robot is rideable or not.</param>
        private void ConfigureRobotForBuild(EMetalType metalType, EOrigin origin, EModelName modelName, int amountHead, int amounTorso, int amountArms, int amountLegs, int amountTail, bool isRidable) {
            amountOfMaterials = (int)modelName;
            int amountPieces = amountHead + amountArms + amountLegs + amounTorso + amountTail;
            int totalMaterialsForEachPiece = amountOfMaterials * amountPieces;

            if (RobotFactory.CheckAmountOfMaterialsInBuckets(totalMaterialsForEachPiece)) {

                Robot prototype;
                prototype = RobotFactory.CreateMultiplePiecesAmdAddToStock(metalType, origin, modelName, amountOfMaterials, amountHead, amounTorso, amountArms, amountLegs, amountTail, isRidable);
                filename = prototype.Model.ToString();
                absBioPath = $"{pathBiography}{filename}.bin";
                prototype.LoadBioFile(absBioPath);

                if (RobotFactory.QualityControl(prototype, amountPieces)) {
                    if (RobotFactory.AddRobotToWarehouse(prototype)) {
                        MyPlayer.Play($"BuildingForm", false);
                        frmLobby.FormShowDialogHandler(new frmBuilding());
                        RobotFactory.SaveDataOfFactory();
                        MyPlayer.Play($"Create{prototype.Model}", false);
                        frmLobby.FormShowDialogHandler(new frmISOCertified(prototype.Model.ToString()));
                    }
                } else {
                    if (RobotFactory.DissasembleRobot(prototype)) {
                        throw new QualityControlFailedException("There have a difference in the amount of pieces, Quality control has failed!. For safety reasons, the robot was dismantled and its materials recycled.");
                    }
                }
            } else {
                throw new InsufficientMaterialsException("Insufficients Materials to build this model of robot, you need to import more materials in the machine room or choose another model.");
            }
        }

        #endregion

        #region EventHandler_CreateRobots

        /// <summary>
        /// EventHandler of the button 'btnMegatron', that creates the instance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMegatron_Click(object sender, EventArgs e) {
            try {
                this.ConfigureRobotForBuild(EMetalType.RealSteel, EOrigin.Cybertron, EModelName.Megatron, 1, 1, 2, 2, 0, false);
            } catch (QualityControlFailedException qc) {
                frmLobby.FormExceptionHandler(qc);
            } catch (InsufficientMaterialsException im) {
                frmLobby.FormExceptionHandler(im);
            }
        }

        /// <summary>
        /// EventHandler of the button 'btnMugendramon', that creates the instance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMugendramon_Click(object sender, EventArgs e) {
            try {
                this.ConfigureRobotForBuild(EMetalType.ChromeDigizoid, EOrigin.DigiWorld, EModelName.Mugendramon, 1, 1, 2, 2, 1, false);
            } catch (QualityControlFailedException qc) {
                frmLobby.FormExceptionHandler(qc);
            } catch (InsufficientMaterialsException im) {
                frmLobby.FormExceptionHandler(im);
            }
        }

        /// <summary>
        /// EventHandler of the button 'btnT800', that creates the instance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnT800_Click(object sender, EventArgs e) {
            try {
                this.ConfigureRobotForBuild(EMetalType.Silice, EOrigin.Future, EModelName.T800, 1, 1, 2, 2, 0, false);
            } catch (QualityControlFailedException qc) {
                frmLobby.FormExceptionHandler(qc);
            } catch (InsufficientMaterialsException im) {
                frmLobby.FormExceptionHandler(im);
            } catch (NoSoundFoundException ns) {
                frmLobby.FormExceptionHandler(ns);
            }
        }

        /// <summary>
        /// EventHandler of the button 'btnC3po', that creates the instance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnC3po_Click(object sender, EventArgs e) {
            try {
                this.ConfigureRobotForBuild(EMetalType.GoldenMetal, EOrigin.Tatooine, EModelName.C3PO, 1, 1, 2, 2, 0, false);
            } catch (QualityControlFailedException qc) {
                frmLobby.FormExceptionHandler(qc);
            } catch (InsufficientMaterialsException im) {
                frmLobby.FormExceptionHandler(im);
            }
        }

        /// <summary>
        /// EventHandler of the button 'btnBladeLiger', that creates the instance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBladeLiger_Click(object sender, EventArgs e) {
            try {
                this.ConfigureRobotForBuild(EMetalType.RealSteel, EOrigin.Zoids, EModelName.BladeLiger, 1, 1, 2, 2, 1, true);
            } catch (QualityControlFailedException qc) {
                frmLobby.FormExceptionHandler(qc);
            } catch (InsufficientMaterialsException im) {
                frmLobby.FormExceptionHandler(im);
            }
        }

        /// <summary>
        /// EventHandler of the button 'btnOptimus', that creates the instance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOptimus_Click(object sender, EventArgs e) {
            try {
                this.ConfigureRobotForBuild(EMetalType.RealSteel, EOrigin.Cybertron, EModelName.OptimusPrime, 1, 1, 2, 2, 0, false);
            } catch (QualityControlFailedException qc) {
                frmLobby.FormExceptionHandler(qc);
            } catch (InsufficientMaterialsException im) {
                frmLobby.FormExceptionHandler(im);
            }
        }

        /// <summary>
        /// EventHandler of the button 'btnDragonZord', that creates the instance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDragonZord_Click(object sender, EventArgs e) {
            try {
                this.ConfigureRobotForBuild(EMetalType.RealSteel, EOrigin.MightyMorphin, EModelName.DragonZord, 1, 1, 2, 2, 1, true);
            } catch (QualityControlFailedException qc) {
                frmLobby.FormExceptionHandler(qc);
            } catch (InsufficientMaterialsException im) {
                frmLobby.FormExceptionHandler(im);
            }
        }

        /// <summary>
        /// EventHandler of the button 'btnEva01', that creates the instance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEva01_Click(object sender, EventArgs e) {
            try {
                this.ConfigureRobotForBuild(EMetalType.RealSteel, EOrigin.Evangelion, EModelName.Eva01, 1, 1, 2, 2, 0, true);
            } catch (QualityControlFailedException qc) {
                frmLobby.FormExceptionHandler(qc);
            } catch (InsufficientMaterialsException im) {
                frmLobby.FormExceptionHandler(im);
            }
        }

        /// <summary>
        /// EventHandler of the button 'btnWalle', that creates the instance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWalle_Click(object sender, EventArgs e) {
            try {
                this.ConfigureRobotForBuild(EMetalType.Aluminium, EOrigin.Earth, EModelName.WallE, 1, 1, 2, 1, 0, false);
            } catch (QualityControlFailedException qc) {
                frmLobby.FormExceptionHandler(qc);
            } catch (InsufficientMaterialsException im) {
                frmLobby.FormExceptionHandler(im);
            }
        }

        #endregion

    }
}
