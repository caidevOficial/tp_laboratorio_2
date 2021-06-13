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
using Materials;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using SuperClasses;
using System.Collections.Generic;

namespace UnitTestProjectTPFinal {

    [TestClass]
    public class UnitTest_RobotPiece {

        private RobotPiece piece;
        private List<MaterialBucket> materials = new List<MaterialBucket>() {
            new MaterialBucket(new Product("Bateria", EMaterial.Battery), 5000),
            new MaterialBucket(new Product("Metal", EMaterial.Metal), 5000),
            new MaterialBucket(new Product("MicroProcessor", EMaterial.MicroProcessor), 5000),
            new MaterialBucket(new Product("MotherBoard", EMaterial.MotherBoard), 5000),
            new MaterialBucket(new Product("Screws", EMaterial.Screws), 5000),
            new MaterialBucket(new Product("Wires", EMaterial.Wires), 5000)
        };

        /// <summary>
        /// Checks that the list of materials of the piece aren't null.
        /// </summary>
        [TestMethod]
        public void Test_01_List_Of_Materials_Of_The_Piece_Not_Null() {

            #region Arrange

            piece = new RobotPiece();

            #endregion

            #region Act

            #endregion

            #region Assert

            Assert.IsNotNull(piece.RawMaterial);

            #endregion

        }

        /// <summary>
        /// Checks that the amount of materials is 0.
        /// </summary>
        [TestMethod]
        public void Test_02_Checks_Materials_Equals_Zero() {

            #region Arrange

            piece = new RobotPiece();

            #endregion

            #region Act

            int amountMaterials = piece.AmountOfMaterials();

            #endregion

            #region Assert

            Assert.AreEqual(0, amountMaterials);

            #endregion
        }

        /// <summary>
        /// Checks that the amount of materials is 30K.
        /// </summary>
        [TestMethod]
        public void Test_03_Checks_Materials_Equals_30K() {

            #region Arrange

            piece = new RobotPiece(EPieceType.Head, EMetalType.ChromeDigizoid, EMaterial.Metal, materials);

            #endregion

            #region Act

            int amountMaterials = piece.AmountOfMaterials();

            #endregion

            #region Assert

            Assert.AreEqual(30000, amountMaterials);

            #endregion
        }
    }
}
