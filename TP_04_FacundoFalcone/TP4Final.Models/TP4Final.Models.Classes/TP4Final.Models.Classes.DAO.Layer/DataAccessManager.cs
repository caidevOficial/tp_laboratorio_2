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
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Enums;
using Exceptions;
using Materials;
using Models;
using SuperClasses;

namespace DAO {
    public class DataAccessManager : DataConnectorAbstract {

        #region Methods

        /// <summary>
        /// Converts a DataRow into a Robot Object.
        /// </summary>
        /// <param name="item">DataRow To convert into a Robot.</param>
        /// <param name="pieces">List of pieces of the robot.</param>
        /// <returns>An instance of Robot Type.</returns>
        private static Robot DataRowToRobot(DataRow item, int robotSerial, List<RobotPiece> pieces) {
            Robot myRobot;
            Enum.TryParse(item["Origin"].ToString(), out EOrigin origin);
            Enum.TryParse(item["ModelName"].ToString(), out EModelName model);
            bool rideable = Convert.ToBoolean(item["IsRideable"]);
            myRobot = new Robot(origin, model, pieces, rideable);
            myRobot.SerialNumber = robotSerial;

            return myRobot;
        }

        /// <summary>
        /// Gets the list of robots.
        /// </summary>
        /// <returns>The list of all the robots in the warehouse.m</returns>
        public static List<Robot> GetRobots() { //TODO: Fix This
            List<Robot> robots = new List<Robot>();
            List<RobotPiece> pieces;
            Robot actualRobot;
            try {
                DataAccessManager.MyCommand.CommandText = "Select * from Robots";
                DataAccessManager.MyConection.Open();
                using (SqlDataReader myReader = DataAccessManager.MyCommand.ExecuteReader()) {
                    DataTable myDT = new DataTable();
                    myDT.Load(myReader);
                    foreach (DataRow item in myDT.Rows) {
                        int robotSerial = Convert.ToInt32(item["SerialNumber"]);
                        pieces = DataAccessManager.GetPieces(robotSerial);
                        actualRobot = DataAccessManager.DataRowToRobot(item, robotSerial, pieces);
                        robots.Add(actualRobot);
                    }
                }
            } catch (Exception exe) {
                throw new FactoryConnectionErrorException(exe.Message, exe); ;
            } finally {
                DataAccessManager.MyConection.Close();
            }

            return robots;
        }

        /// <summary>
        /// Converts a DataRow into a RobotPiece Object.
        /// </summary>
        /// <param name="item">DataRow To convert into a RobotPiece.</param>
        /// <param name="pieceId"></param>
        /// <param name="materials"></param>
        /// <returns></returns>
        private static RobotPiece DataRowToRobotPiece(DataRow item, string pieceId, List<MaterialBucket> materials) {
            RobotPiece myPiece;
            int robotSerial = Convert.ToInt32(item["AssociatedRobot_serial"]);
            Enum.TryParse(item["PieceType"].ToString(), out EPieceType pieceType);
            Enum.TryParse(item["MetalType"].ToString(), out EMetalType metalType);
            Enum.TryParse(item["Material"].ToString(), out EMaterial eMaterial);
            myPiece = new RobotPiece(pieceType, metalType, eMaterial, materials);
            myPiece.AssociatedRobotSerial = robotSerial;
            myPiece.PieceID = pieceId;

            return myPiece;
        }

        /// <summary>
        /// Gets the list of pieces of the robot.
        /// </summary>
        /// <param name="idRobot">Serial Number of the robot.</param>
        /// <returns>The List of pieces.</returns>
        private static List<RobotPiece> GetPieces(int idRobot) {
            List<RobotPiece> pieces = new List<RobotPiece>();
            List<MaterialBucket> materialsOfPiece;
            RobotPiece actualPiece;
            DataAccessManager.MyCommand.CommandText = "Select * from RobotPieces WHERE AssociatedRobot_serial = @serial_robot";
            DataAccessManager.MyCommand.Parameters.AddWithValue("@serial_robot", idRobot);
            //DataAccessManager.MyConection.Open();
            try {
                using (SqlDataReader myReader = DataAccessManager.MyCommand.ExecuteReader()) {
                    DataTable myDT = new DataTable();
                    myDT.Load(myReader);
                    foreach (DataRow item in myDT.Rows) {
                        string idPiece = item["id"].ToString();
                        materialsOfPiece = GetMaterialsOfPiece(idPiece, idRobot);
                        actualPiece = DataAccessManager.DataRowToRobotPiece(item, idPiece, materialsOfPiece);
                        pieces.Add(actualPiece);
                        DataAccessManager.MyCommand.Parameters.Clear();
                    }
                }
            } catch (Exception exe) {
                throw new FactoryConnectionErrorException(exe.Message, exe); ;
            }

            //myReader.Close();
            //myConnection.Close();

            return pieces;
        }

        /// <summary>
        /// Converts a DataRow into a Product Object.
        /// </summary>
        /// <param name="item">DataRow To convert into a Product.</param>
        /// <returns></returns>
        private static Product DataRowToProduct(DataRow item) {
            Enum.TryParse(item["Material_Name"].ToString(), out EMaterial mat);
            return new Product(mat.ToString(), mat);
        }

        /// <summary>
        /// Converts a DataRow into a MaterialBucket Object.
        /// </summary>
        /// <param name="item">DataRow To convert into a MaterialBucket.</param>
        /// <returns></returns>
        private static MaterialBucket DataRowToBucket(DataRow item) {
            Product myProduct = DataAccessManager.DataRowToProduct(item);
            int amount = Convert.ToInt32(item["Material_Amount"]);
            MaterialBucket myBucket = new MaterialBucket(myProduct, amount);
            myBucket.AssociatedPieceID = item["AssociatedPiece_id"].ToString();
            myBucket.AssociatedRobotSerial = Convert.ToInt32(item["AssociatedRobot_Serial"]);

            return myBucket;
        }

        /// <summary>
        /// Gets the list of Materials of the robot's pieces.
        /// </summary>
        /// <param name="idRobot">Serial number of the robot.</param>
        /// <returns>The List of Materials.</returns>
        private static List<MaterialBucket> GetMaterialsOfPiece(string idPiece, int idRobot) {
            List<MaterialBucket> materialsOfPiece = new List<MaterialBucket>();
            MaterialBucket actualBucket;
            DataAccessManager.MyCommand.CommandText = "Select * from MaterialBuckets WHERE AssociatedPiece_id = @id_piece AND AssociatedRobot_Serial=@id_robot";
            DataAccessManager.MyCommand.Parameters.AddWithValue("@id_piece", idPiece);
            DataAccessManager.MyCommand.Parameters.AddWithValue("@id_robot", idRobot);
            //DataAccessManager.MyConection.Open();
            try {
                using (SqlDataReader myReader = DataAccessManager.MyCommand.ExecuteReader()) {
                    DataTable myDT = new DataTable();
                    myDT.Load(myReader);
                    foreach (DataRow item in myDT.Rows) {
                        actualBucket = DataAccessManager.DataRowToBucket(item);
                        materialsOfPiece.Add(actualBucket);
                        DataAccessManager.MyCommand.Parameters.Clear();
                    }
                }
            } catch (Exception exe) {
                throw new FactoryConnectionErrorException(exe.Message, exe); ;
            }
            //myReader.Close();
            //myConnection.Close();

            return materialsOfPiece;
        }

        #endregion

        #region InsertEntities

        /// <summary>
        /// Inserts into the DB a Robot.
        /// </summary>
        /// <param name="myRobot">Robot to insert into the DB.</param>
        public static void InsertRobot(Robot myRobot) {
            try {
                DataAccessManager.MyConection.Open();
                DataAccessManager.MyCommand.CommandText = $"INSERT INTO Robots Values(@SerialNumber, @Origin, @ModelName, @IsRideable);";
                DataAccessManager.MyCommand.Parameters.AddWithValue("@SerialNumber", myRobot.SerialNumber);
                DataAccessManager.MyCommand.Parameters.AddWithValue("@Origin", myRobot.Origin.ToString());
                DataAccessManager.MyCommand.Parameters.AddWithValue("@ModelName", myRobot.Model.ToString());
                DataAccessManager.MyCommand.Parameters.AddWithValue("@IsRideable", myRobot.IsRideable);
                //DataAccessManager.Execute();
                int rows = DataAccessManager.MyCommand.ExecuteNonQuery();
                InsertPieces(myRobot.RobotPieces);
            } catch (Exception ex) {
                throw new FactoryConnectionErrorException("Something get wrong while inserting a Robot into the DB.", ex);
            } finally {
                DataAccessManager.MyConection.Close();
            }
        }

        /// <summary>
        /// Inserts into the DB a list of pieces of the robot.
        /// </summary>
        /// <param name="pieces">List of pieces of the robot to insert into the DB.</param>
        private static void InsertPieces(List<RobotPiece> pieces) {
            try {
                foreach (RobotPiece item in pieces) {
                    DataAccessManager.MyCommand.CommandText = $"INSERT INTO RobotPieces Values(@id, @PieceType, @MetalType, @Material, @PieceRobotSerialNumber);";
                    DataAccessManager.MyCommand.Parameters.AddWithValue("@id", item.PieceID);
                    DataAccessManager.MyCommand.Parameters.AddWithValue("@PieceType", item.PieceType.ToString());
                    DataAccessManager.MyCommand.Parameters.AddWithValue("@MetalType", item.MetalType.ToString());
                    DataAccessManager.MyCommand.Parameters.AddWithValue("@Material", item.MaterialProduct.ToString());
                    DataAccessManager.MyCommand.Parameters.AddWithValue("@PieceRobotSerialNumber", item.AssociatedRobotSerial);
                    int rows = DataAccessManager.MyCommand.ExecuteNonQuery();
                    //DataAccessManager.Execute();
                    DataAccessManager.MyCommand.Parameters.Clear();
                    InsertMaterialsPieces(item.RawMaterial);
                }
            } catch (Exception ex) {
                throw new FactoryConnectionErrorException("Something get wrong while inserting a Robot into the DB.", ex);
            }
        }

        /// <summary>
        /// Inserts into the DB a list of materials of robot pieces.
        /// </summary>
        /// <param name="materials">List of materials of the robot pieces to insert into the DB.</param>
        private static void InsertMaterialsPieces(List<MaterialBucket> materials) {
            try {
                foreach (MaterialBucket item in materials) {
                    DataAccessManager.MyCommand.CommandText = $"INSERT INTO MaterialBuckets Values(@Material_Name, @Material_Amount, @MaterialRobotPieceNumber, @MaterialRobotSerialNumber);";
                    DataAccessManager.MyCommand.Parameters.AddWithValue("@Material_Name", item.NameProductOfBucket);
                    DataAccessManager.MyCommand.Parameters.AddWithValue("@Material_Amount", item.AmoutProduct);
                    DataAccessManager.MyCommand.Parameters.AddWithValue("@MaterialRobotPieceNumber", item.AssociatedPieceID);
                    DataAccessManager.MyCommand.Parameters.AddWithValue("@MaterialRobotSerialNumber", item.AssociatedRobotSerial);
                    int rows = DataAccessManager.MyCommand.ExecuteNonQuery();
                    //DataAccessManager.Execute();
                    DataAccessManager.MyCommand.Parameters.Clear();
                }
            } catch (Exception ex) {
                throw new FactoryConnectionErrorException("Something get wrong while inserting a Robot into the DB.", ex);
            }
        }

        #endregion
    }
}
