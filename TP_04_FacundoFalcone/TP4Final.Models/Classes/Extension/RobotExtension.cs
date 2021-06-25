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

using Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models {
    public static class RobotExtension {

        /// <summary>
        /// Extends the funcionability of a Robot, this methodwas made for set
        /// the serial number of the robot into its pieces and the material of
        /// each robot piece.
        /// </summary>
        /// <param name="thisRobot">Class to extend.</param>
        /// <param name="aRobot">Entity to modify data.</param>
        public static void SetSerialNumber(this Robot thisRobot, Robot aRobot){
            foreach (RobotPiece item in aRobot.RobotPieces) {
                item.AssociatedRobotSerial = aRobot.SerialNumber;
                foreach (MaterialBucket itemBucket in item.RawMaterial) {
                    itemBucket.AssociatedRobotSerial = aRobot.SerialNumber;
                }
            }
        }
    }
}
