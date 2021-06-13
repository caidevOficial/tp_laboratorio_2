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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System.Collections.Generic;

namespace UnitTestProjectTPFinal {

    [TestClass]
    public class UnitTest_RobotFactory {

        private Robot aRobot;
        List<RobotPiece> pieces;

        /// <summary>
        /// Checks that the list of the factory aren't null.
        /// </summary>
        [TestMethod]
        public void Test01_Check_List_Are_not_null() {

            #region Arrange

            #endregion

            #region Act

            #endregion

            #region Assert

            Assert.IsNotNull(RobotFactory.Buckets);
            Assert.IsNotNull(RobotFactory.Materials);
            Assert.IsNotNull(RobotFactory.Robots);
            Assert.IsNotNull(RobotFactory.Pieces);

            #endregion
        }

        /// <summary>
        /// Checks that the list have more than one element inside.
        /// </summary>
        [TestMethod]
        public void Test02_Check_Lists_Have_More_Than_One_Element() {

            #region Arrange

            #endregion

            #region Act

            bool listInitialized = RobotFactory.InitFactoryAndStock();
            bool materials = RobotFactory.Materials.Count > 0;
            bool buckets = RobotFactory.Buckets.Count > 0;

            #endregion

            #region Assert

            Assert.IsTrue(listInitialized);
            Assert.IsTrue(materials);
            Assert.IsTrue(buckets);

            #endregion
        }

        /// <summary>
        /// Checks that the list of materials haven't enough materials to manufacture
        /// a robot.
        /// </summary>
        [TestMethod]
        public void Test03_Check_Not_Enough_Material_To_Manufacture() {

            #region Arrange

            #endregion

            #region Act

            bool enoughMaterials = RobotFactory.CheckAmountOfMaterialsInBuckets((int)EModelName.DragonZord);

            #endregion

            #region Assert

            Assert.IsFalse(enoughMaterials);

            #endregion
        }

        /// <summary>
        /// Checks that the robot haven't enough materials and pieces to pass the
        /// quality control.
        /// </summary>
        [TestMethod]
        public void Test04_Robot_Fails_In_Quality() {

            #region Arrange

            pieces = new List<RobotPiece>();
            aRobot = new Robot(EOrigin.Earth, EModelName.WallE, pieces);

            #endregion

            #region Act

            bool failQualityControl = RobotFactory.QualityControl(aRobot, (int)aRobot.Model);

            #endregion

            #region Assert

            Assert.IsFalse(failQualityControl);

            #endregion
        }

        /// <summary>
        /// Checks that can add a robot in the warehouse and the list size is 
        /// different after add the robot.
        /// </summary>
        [TestMethod]
        public void test05_Checks_That_Adds_Robor_In_The_List() {
            #region Arrange

            pieces = new List<RobotPiece>();
            aRobot = new Robot(EOrigin.Earth, EModelName.WallE, pieces);

            #endregion

            #region Act

            int listSizeBefore = RobotFactory.Robots.Count;
            bool addToWarehouse = RobotFactory.AddRobotToWarehouse(aRobot);
            int listSizeAfter = RobotFactory.Robots.Count;

            #endregion

            #region Assert

            Assert.AreEqual(0, listSizeBefore);
            Assert.IsTrue(addToWarehouse);
            Assert.AreEqual(1, listSizeAfter);

            #endregion
        }
    }
}
