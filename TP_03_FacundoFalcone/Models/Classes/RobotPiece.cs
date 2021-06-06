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
using Materials;
using SuperClasses;
using System.Collections.Generic;
using System.Text;

namespace Models {
    public class RobotPiece : Product, IInformation {

        #region Attributes

        private int serialNumber;
        private EMetalType metalType;
        private EPieceType pieceType;
        private List<MaterialBucket> materials;

        #endregion

        #region Builders

        /// <summary>
        /// Creates the entity with default constructor.
        /// </summary>
        public RobotPiece() {
            this.materials = new List<MaterialBucket>();
        }

        /// <summary>
        /// Creates the instance with the name of the piece and its material
        /// </summary>
        /// <param name="pieceType">Name of the entity.</param>
        /// <param name="metalType">Type of metal of the entity</param>
        /// <param name="material">Material of the entity</param>
        public RobotPiece(EPieceType pieceType, EMetalType metalType, EMaterial material) : base(pieceType.ToString(), material) {
            this.materials = new List<MaterialBucket>();
            this.metalType = metalType;
            this.PieceType = pieceType;
        }

        /// <summary>
        /// Creates the instance with the name of the piece and its material
        /// </summary>
        /// <param name="pieceType">Name of the entity.</param>
        /// <param name="metalType">Type of metal of the entity</param>
        /// <param name="material">Material of the entity</param>
        /// <param name="materials">Dictionary of materials Bucket</param>
        public RobotPiece(EPieceType pieceType, EMetalType metalType, EMaterial material, List<MaterialBucket> materials)
            : this(pieceType, metalType, material) {
            this.materials = materials;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets/Sets: The serial number of the robot piece.
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
        /// Get: Gets the list of materials needed for the RobotPart.
        /// </summary>
        public List<MaterialBucket> RawMaterial {
            get => this.materials;
            set {
                if (value.GetType() == typeof(List<MaterialBucket>))
                    this.materials = value;
            }
        }

        /// <summary>
        /// Get/Set: The piece type of the robotPiece.
        /// </summary>
        public EPieceType PieceType {
            get => this.pieceType;
            set {
                if (value.GetType() == typeof(EPieceType)) {
                    this.pieceType = value;
                }
            }
        }

        /// <summary>
        /// Get/Set: The metal type of the robotPiece.
        /// </summary>
        public EMetalType MetalType {
            get => this.metalType;
            set {
                if (value.GetType() == typeof(EMetalType)) {
                    this.metalType = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the amount of materias of the piece.
        /// </summary>
        /// <returns></returns>
        public int AmountOfMaterials() {
            int amount = 0;
            foreach (MaterialBucket item in materials) {
                amount += item.AmoutProduct;
            }

            return amount;
        }

        /// <summary>
        /// Gets the information of the robot piece.
        /// </summary>
        /// <returns>The information of the robot piece as a string.</returns>
        public string Information() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Piece: {this.NameProduct}");
            data.AppendLine($"Type: {this.PieceType}");
            data.AppendLine($"Metal-Type: {this.MetalType}");
            data.AppendLine($"Material: {this.MaterialProduct}");
            data.AppendLine($"Materials Used: {this.AmountOfMaterials()}");

            return data.ToString();
        }

        #endregion
    }
}
