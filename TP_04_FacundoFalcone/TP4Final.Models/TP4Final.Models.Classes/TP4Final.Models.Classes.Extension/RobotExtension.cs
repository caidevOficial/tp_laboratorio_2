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

namespace Models {
    public static class RobotExtension {

        /// <summary>
        /// Format a robot piece, bassed on the serial of the robot.
        /// </summary>
        /// <param name="piece">Class affected.</param>
        /// <param name="robotSerial">Serial of the robot to use for format.</param>
        /// <param name="indexPiece">Index of the piece to format its ID.</param>
        public static void FormatRobotPieceID(this RobotPiece piece, int robotSerial, int indexPiece) {
            string prefix = string.Empty;
            switch (piece.PieceType) {
                case EPieceType.Head:
                    prefix = "HE";
                    break;
                case EPieceType.Torso:
                    prefix = "TO";
                    break;
                case EPieceType.UpperLimb:
                    prefix = "UL";
                    break;
                case EPieceType.LowerLimb:
                    prefix = "LL";
                    break;
                case EPieceType.Tail:
                    prefix = "TA";
                    break;
            }
            piece.PieceID = $"{robotSerial}-{prefix}-{indexPiece}";
        }

        /// <summary>
        /// Extends the funcionability of a Robot, this methodwas made for set
        /// the serial number of the robot into its pieces and the material of
        /// each robot piece.
        /// </summary>
        /// <param name="thisRobot">Class to extend.</param>
        /// <param name="aRobot">Entity to modify data.</param>
        public static void SetSerialNumber(this Robot thisRobot) {
            foreach (RobotPiece item in thisRobot.RobotPieces) {
                item.AssociatedRobotSerial = thisRobot.SerialNumber;
                item.FormatRobotPieceID(item.AssociatedRobotSerial, thisRobot.RobotPieces.IndexOf(item));
                foreach (MaterialBucket itemBucket in item.RawMaterial) {
                    itemBucket.AssociatedRobotSerial = thisRobot.SerialNumber;
                    itemBucket.AssociatedPieceID = item.PieceID;
                }
            }
        }
    }
}
