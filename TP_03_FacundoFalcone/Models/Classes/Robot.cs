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
using Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Models {

    public class Robot : IInformation, ICloning<RobotPiece>, IBiographyManager {

        #region Attributes

        private int serialNumber;
        private bool isRideable;
        private string biography;
        private EOrigin origin;
        private EModelName modelName;
        private List<RobotPiece> pieces;

        #endregion

        #region Builders

        /// <summary>
        /// Initializes the list of limbs.
        /// </summary>
        private Robot() {
            pieces = new List<RobotPiece>();
        }

        /// <summary>
        /// Creates the instance with limbs, head and torso.
        /// </summary>
        /// <param name="origin">Origin of the robot.</param>
        /// <param name="model">ModelName of the robot.</param>
        /// <param name="pieces">List of pieces of the robot.</param>
        public Robot(EOrigin origin, EModelName model, List<RobotPiece> pieces)
            : this() {
            this.origin = origin;
            this.modelName = model;
            this.pieces = this.CloneList(pieces);
        }

        /// <summary>
        /// Creates the instance with limbs, head and torso.
        /// </summary>
        /// <param name="origin">Origin of the robot.</param>
        /// <param name="model">ModelName of the robot.</param>
        /// <param name="pieces">List of pieces of the robot.</param>
        /// <param name="isRideable">A boolean state that indicate if it rideable or not.</param>
        public Robot(EOrigin origin, EModelName model, List<RobotPiece> pieces, bool isRideable)
            : this(origin, model, pieces) {
            this.isRideable = isRideable;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets/Sets: the serial number of the robot.
        /// </summary>
        public int SerialNumber {
            get => this.serialNumber;
            set {
                if (value > 0) {
                    this.serialNumber = value;
                }
            }
        }

        /// <summary>
        /// Gets the origin of the robot.
        /// </summary>
        public EOrigin Origin {
            get => this.origin;
            set {
                if (value.GetType() == typeof(EOrigin)) {
                    this.origin = value;
                }
            }
        }

        /// <summary>
        /// Gets the model name of the robot.
        /// </summary>
        public EModelName Model {
            get => this.modelName;
            set {
                if (value.GetType() == typeof(EModelName)) {
                    this.modelName = value;
                }
            }
        }

        /// <summary>
        /// Get/Set the boolean state that indicates if the robot
        /// is rideable or not.
        /// </summary>
        public bool IsRideable {
            get => this.isRideable;
            set {
                if (value.GetType() == typeof(bool)) {
                    this.isRideable = value;
                }
            }
        }

        /// <summary>
        /// Gets the amount of pieces of the robot.
        /// </summary>
        public int AmountPieces {
            get => this.RobotPieces.Count;
        }

        /// <summary>
        /// Gets the list of pieces of the robot.
        /// </summary>
        public List<RobotPiece> RobotPieces {
            get => this.pieces;
        }

        /// <summary>
        /// Sets: The biography of the robot.
        /// </summary>
        public string Bio {
            set {
                if (!String.IsNullOrWhiteSpace(value)) {
                    this.biography = value;
                }
            }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Cast a entity robot-type and returns the value of the enum
        /// of the modelName.
        /// </summary>
        /// <param name="aRobot">A robot entity to cast</param>
        public static implicit operator int(Robot aRobot) {
            return (int)aRobot.modelName;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the info of the robot.
        /// </summary>
        /// <returns>The info of the robot as a string.</returns>
        public string Information() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Model: {this.modelName.ToString()}");
            data.AppendLine($"Origin: {this.origin}");
            data.AppendLine($"Ridable: {this.isRideable}");
            data.AppendLine($"Pieces: {this.pieces.Count}\n");
            data.AppendLine($"Biography: {this.biography}");
            data.AppendLine("---------------------");

            return data.ToString();
        }

        /// <summary>
        /// Creates a new list cloning the list passed by parameter.
        /// </summary>
        /// <param name="listToClone">List to be cloned</param>
        /// <returns>A new list that is a clone of the original list.</returns>
        public List<RobotPiece> CloneList(List<RobotPiece> listToClone) {
            return new List<RobotPiece>(listToClone);
        }

        /// <summary>
        /// Calculates the total amount of materials used for
        /// manufacture each robot piece of this robot.
        /// </summary>
        /// <returns>The total amount of materials.</returns>
        public int AmountOfMaterials() {
            int totalAmount = 0;
            if (!(this is null)) {
                foreach (RobotPiece item in this.RobotPieces) {
                    totalAmount += item.AmountOfMaterials();
                }
            }

            return totalAmount;
        }

        /// <summary>
        /// Loads a biography from a file specified in the path.
        /// </summary>
        /// <param name="path">Path to search the biography.</param>
        public void LoadBioFile(string path) {
            if (File.Exists(path)) {
                using (StreamReader sr = new StreamReader(path)) {
                    this.Bio = sr.ReadToEnd();
                }
            }
        }

        #endregion
    }
}
