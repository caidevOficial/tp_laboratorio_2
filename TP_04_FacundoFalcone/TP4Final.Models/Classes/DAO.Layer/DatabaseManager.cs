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
using Models;
using SuperClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO {

    public static class DatabaseManager {

        #region Attributes

        private static string connString;
        private static SqlConnection myConnection;
        private static SqlCommand myCommand;

        #endregion

        #region Builders

        /// <summary>
        /// Static Builder
        /// </summary>
        static DatabaseManager() {
            connString = " Server = localhost ; Database = TPFinal; Trusted_Connection = true ; ";
            myConnection = new SqlConnection(connString);
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
        }

        #endregion

        #region Methods

        #region GetListsOfEntities

        /// <summary>
        /// Gets the list of robots.
        /// </summary>
        /// <returns>The list of all the robots in the warehouse.m</returns>
        public static List<Robot> GetRobots() { //TODO: Fix This
            List<Robot> robots = new List<Robot>();
            List<RobotPiece> pieces;
            Robot actualRobot;
            myCommand.CommandText = "Select * from Robots";
            myConnection.Open();
            SqlDataReader myReader = myCommand.ExecuteReader();
            DataTable myDT = new DataTable();
            myDT.Load(myReader);
            foreach (DataRow item in myDT.Rows) {
                int robotSerial = Convert.ToInt32(item["SerialNumber"]);
                pieces = GetPieces(robotSerial);
                actualRobot = new Robot((EOrigin)item["Origin"], (EModelName)item["ModelName"], pieces, Convert.ToBoolean(item["IsRideable"]));
                robots.Add(actualRobot);
            }
            myCommand.Parameters.Clear();
            myReader.Close();
            myConnection.Close();

            return robots;
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
            myCommand.CommandText = "Select * from RobotPieces WHERE AssociatedRobot_serial = @serial_robot";
            myCommand.Parameters.AddWithValue("@serial_robot", idRobot);
            //myConnection.Open();
            SqlDataReader myReader = myCommand.ExecuteReader();
            DataTable myDT = new DataTable();
            myDT.Load(myReader);
            foreach (DataRow item in myDT.Rows) {
                int idPiece = Convert.ToInt32(item["AssociatedPiece_id"]);
                materialsOfPiece = GetMaterialsOfPiece(idPiece);
                Enum.TryParse(item["PieceType"].ToString(), out EPieceType pieceType);
                Enum.TryParse(item["MetalType"].ToString(), out EMetalType metalType);
                Enum.TryParse(item["Material"].ToString(), out EMaterial eMaterial);
                actualPiece = new RobotPiece(pieceType, metalType, eMaterial, materialsOfPiece);
                actualPiece.AssociatedRobotSerial = Convert.ToInt32(item["AssociatedRobot_serial"]);
                actualPiece.PieceID = item["id"].ToString();
                pieces.Add(actualPiece);
            }
            myCommand.Parameters.Clear();
            //myReader.Close();
            //myConnection.Close();

            return pieces;
        }

        /// <summary>
        /// Gets the list of Materials of the robot's pieces.
        /// </summary>
        /// <param name="idRobot">Serial number of the robot.</param>
        /// <returns>The List of Materials.</returns>
        private static List<MaterialBucket> GetMaterialsOfPiece(int idPiece) {
            List<MaterialBucket> materialsOfPiece = new List<MaterialBucket>();
            Product myProduct;
            MaterialBucket actualBucket;
            myCommand.CommandText = "Select * from MaterialBuckets WHERE AssociatedPieces_id = @id_piece";
            myCommand.Parameters.AddWithValue("@id_piece", idPiece);
            //myConnection.Open();
            SqlDataReader myReader = myCommand.ExecuteReader();
            DataTable myDT = new DataTable();
            myDT.Load(myReader);
            foreach (DataRow item in myDT.Rows) {
                Enum.TryParse(item["Material_Name"].ToString(), out EMaterial mat);
                myProduct = new Product(item["Material_Name"].ToString(), mat);
                actualBucket = new MaterialBucket(myProduct, Convert.ToInt32(item["Material_Amount"]));
                actualBucket.AssociatedRobotSerial = Convert.ToInt32(item["AssociatedRobot_Serial"]);
                actualBucket.AssociatedPieceID = item["AssociatedPiece_id"].ToString();
                materialsOfPiece.Add(actualBucket);
            }
            myCommand.Parameters.Clear();
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
                myConnection.Open();
                myCommand.CommandText = $"INSERT INTO Robots Values(@SerialNumber, @Origin, @ModelName, @IsRideable);";
                myCommand.Parameters.AddWithValue("@SerialNumber", myRobot.SerialNumber);
                myCommand.Parameters.AddWithValue("@Origin", myRobot.Origin.ToString());
                myCommand.Parameters.AddWithValue("@ModelName", myRobot.Model.ToString());
                myCommand.Parameters.AddWithValue("@IsRideable", myRobot.IsRideable);
                int rows = myCommand.ExecuteNonQuery();
                InsertPieces(myRobot.RobotPieces);
            } catch (Exception ex) {
                throw new Exception("Something get wrong while inserting a Robot into the DB.", ex);
            } finally {
                myConnection.Close();
            }
        }

        /// <summary>
        /// Inserts into the DB a list of pieces of the robot.
        /// </summary>
        /// <param name="pieces">List of pieces of the robot to insert into the DB.</param>
        private static void InsertPieces(List<RobotPiece> pieces) {
            try {
                foreach (RobotPiece item in pieces) {
                    myCommand.CommandText = $"INSERT INTO RobotPieces Values(@id, @PieceType, @MetalType, @Material, @PieceRobotSerialNumber);";
                    myCommand.Parameters.AddWithValue("@id", item.PieceID);
                    myCommand.Parameters.AddWithValue("@PieceType", item.PieceType.ToString());
                    myCommand.Parameters.AddWithValue("@MetalType", item.MetalType.ToString());
                    myCommand.Parameters.AddWithValue("@Material", item.MaterialProduct.ToString());
                    myCommand.Parameters.AddWithValue("@PieceRobotSerialNumber", item.AssociatedRobotSerial);
                    int rows = myCommand.ExecuteNonQuery();
                    myCommand.Parameters.Clear();
                    InsertMaterialsPieces(item.RawMaterial);
                }
            } catch (Exception ex) {

                throw new Exception("Something get wrong while inserting a Piece into the DB.", ex);
            }
        }

        /// <summary>
        /// Inserts into the DB a list of materials of robot pieces.
        /// </summary>
        /// <param name="materials">List of materials of the robot pieces to insert into the DB.</param>
        private static void InsertMaterialsPieces(List<MaterialBucket> materials) {
            try {
                foreach (MaterialBucket item in materials) {
                    myCommand.CommandText = $"INSERT INTO MaterialBuckets Values(@Material_Name, @Material_Amount, @MaterialRobotPieceNumber, @MaterialRobotSerialNumber);";
                    myCommand.Parameters.AddWithValue("@Material_Name", item.NameProductOfBucket);
                    myCommand.Parameters.AddWithValue("@Material_Amount", item.AmoutProduct);
                    myCommand.Parameters.AddWithValue("@MaterialRobotPieceNumber", item.AssociatedPieceID);
                    myCommand.Parameters.AddWithValue("@MaterialRobotSerialNumber", item.AssociatedRobotSerial);
                    int rows = myCommand.ExecuteNonQuery();
                    myCommand.Parameters.Clear();
                }
            } catch (Exception ex) {

                throw new Exception("Something get wrong while inserting a Material into the DB.", ex);
            }
        }

        #endregion

        #endregion

    }
}
