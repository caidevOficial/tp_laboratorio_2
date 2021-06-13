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
using SuperClasses;
using System;
using System.Collections.Generic;
using System.IO;

namespace Models {
    public static class RobotFactory {

        #region Attributes

        private static readonly string robotPersistence = "robotPersistence.xml";
        private static readonly string materialsPersistence = "materialsPersistence.xml";
        private static string systemPath = $"{Environment.CurrentDirectory}";
        private static string persistencePath = $"{systemPath}\\Persistence";

        private static SerialManager<List<MaterialBucket>> sMBucket;
        private static SerialManager<List<Robot>> sMRobot;
        private static Random rdn;
        private static List<Product> materials;
        private static List<Robot> robotsInFactory;
        private static List<MaterialBucket> buckets;
        private static List<RobotPiece> robotPieces;

        #endregion

        #region Builders

        /// <summary>
        /// Default constructor.
        /// </summary>
        static RobotFactory() {
            rdn = new Random();
            materials = new List<Product>();
            robotsInFactory = new List<Robot>();
            buckets = new List<MaterialBucket>();
            robotPieces = new List<RobotPiece>();
            sMRobot = new SerialManager<List<Robot>>();
            sMBucket = new SerialManager<List<MaterialBucket>>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Add a piece to the list of pieces.
        /// </summary>
        public static RobotPiece AddPieceToStock {
            set {
                if (value.GetType() == typeof(RobotPiece)) {
                    robotPieces.Add(value);
                }
            }
        }

        /// <summary>
        /// Gets: The list of materials.
        /// </summary>
        public static List<Product> Materials {
            get => materials;
        }

        /// <summary>
        /// Gets: The list of pieces.
        /// </summary>
        public static List<RobotPiece> Pieces {
            get => robotPieces;
        }

        /// <summary>
        /// Gets: The list of buckets.
        /// </summary>
        public static List<MaterialBucket> Buckets {
            get => buckets;
            set {
                if (value.GetType() == typeof(List<MaterialBucket>)) {
                    buckets = value;
                }
            }
        }

        /// <summary>
        /// Gets: The list of robots.
        /// </summary>
        public static List<Robot> Robots {
            get => robotsInFactory;
            set {
                if (value.GetType() == typeof(List<Robot>)) {
                    robotsInFactory = value;
                }
            }
        }

        /// <summary>
        /// Add: adds a robot into the list of robots.
        /// </summary>
        public static Robot AddRobotToStock {
            set {
                if (value.GetType() == typeof(Robot)) {
                    robotsInFactory.Add(value);
                }
            }
        }

        #endregion

        #region Methods

        #region InitTheFactoryStock

        /// <summary>
        /// Adds Materials of the enum to the list of rawMaterials.
        /// </summary>
        private static void ImportRawMaterials() {
            EMaterial[] materialsArray = (EMaterial[])Enum.GetValues(typeof(EMaterial));
            Product item;
            if (!(materials is null)) {
                foreach (EMaterial material in materialsArray) {
                    item = new Product(material.ToString(), material);
                    materials.Add(item);
                }
            }
        }

        /// <summary>
        /// Creates and Initializes the buckets in 0 and 
        /// add them into the list of buckets.
        /// </summary>
        /// <returns>True if add buckets, otherwise returns false.</returns>
        private static bool InitializeMaterialBuckets() {
            if (!(buckets is null) && !(materials is null)) {
                foreach (Product item in materials) {
                    buckets.Add(new MaterialBucket(item, 1));
                }
                return true;
            }

            return false;
        }

        /// <summary>
        /// Initializes the list of materials and buckets with the amount needed to build something.
        /// </summary>
        /// <returns>True if the both list have at least one item inside.</returns>
        public static bool InitFactoryAndStock() {
            ImportRawMaterials();
            InitializeMaterialBuckets();

            return buckets.Count > 0 && materials.Count > 0;
        }

        #endregion

        #region UpdateRawStock

        /// <summary>
        /// Adds a randomly amount of materials in every bucket.
        /// </summary>
        public static void UpdateRawMaterialsOfBuckets() {
            if (!(buckets is null)) {
                foreach (MaterialBucket item in buckets) {
                    item.AmoutProduct += rdn.Next(5000, 10000);
                }
            }
        }

        #endregion

        #region CheckStock

        /// <summary>
        /// Checks if at least ont item has less amount that the required.
        /// </summary>
        /// <param name="amountToCheck">Amount to check in every bucket.</param>
        /// <returns>False if at least one bucket has less amount, otherwise returns true.</returns>
        public static bool CheckAmountOfMaterialsInBuckets(int neededByEntireRobot) {
            if (!(buckets is null) && buckets.Count > 0) {
                foreach (MaterialBucket item in buckets) {
                    if (item.AmoutProduct < neededByEntireRobot) {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        #endregion

        #region ProductionSector

        /// <summary>
        /// Creates the piece of the robot and sustract an amount of items of the list
        /// of buckets.
        /// </summary>
        /// <param name="amountNecessary">amount necessary to build the piece</param>
        /// <param name="pieceType">Enum that indicates the type of piece to manufacture.</param>
        /// <returns></returns>
        public static RobotPiece ManufacturePiece(int amountNecessary, EPieceType pieceType, EMetalType metalType) {
            List<MaterialBucket> materialsForPiece = new List<MaterialBucket>();
            RobotPiece robotPiece;
            if (!(buckets is null)) {
                foreach (MaterialBucket item in buckets) {
                    item.AmoutProduct -= amountNecessary;
                    materialsForPiece.Add(new MaterialBucket(item.ProductOfBucket, amountNecessary));
                }
                robotPiece = new RobotPiece(pieceType, metalType, EMaterial.Metal, materialsForPiece);
                robotPiece.SerialNumber = rdn.Next(1000, 7000);
                return robotPiece;
            }

            return null;
        }

        /// <summary>
        /// Creates the amount of pieces specifieds with the characterists passed by parameter
        /// and adds the piece into the factory's list of pieces.
        /// </summary>
        /// <param name="amountPieceSpecificPiece">Amount of pieces to manufacture</param>
        /// <param name="amountMaterials">amount of kind of materials needed to manufacture the piece.</param>
        /// <param name="pieceType">Type of the piece to manufacture.</param>
        /// <param name="metalType">Type of the metal of the piece to manufacture.</param>
        public static void CreatePieceAndAddToStock(int amountPieceSpecificPiece, int amountMaterials, EPieceType pieceType, EMetalType metalType) {
            for (int h = 0; h < amountPieceSpecificPiece; h++) {
                RobotFactory.AddPieceToStock = RobotFactory.ManufacturePiece(amountMaterials, pieceType, metalType);
            }
        }

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
        /// <returns>The robot with its pieces builded.</returns>
        public static Robot CreateMultiplePiecesAmdAddToStock(EMetalType metalType, EOrigin origin, EModelName modelName, int amountOfMaterials, int amountHead, int amounTorso, int amountArms, int amountLegs, int amountTail, bool isRidable) {
            RobotFactory.CreatePieceAndAddToStock(amountHead, amountOfMaterials, EPieceType.Head, metalType);
            RobotFactory.CreatePieceAndAddToStock(amounTorso, amountOfMaterials, EPieceType.Torso, metalType);
            RobotFactory.CreatePieceAndAddToStock(amountArms, amountOfMaterials, EPieceType.UpperLimb, metalType);
            RobotFactory.CreatePieceAndAddToStock(amountLegs, amountOfMaterials, EPieceType.LowerLimb, metalType);
            RobotFactory.CreatePieceAndAddToStock(amountTail, amountOfMaterials, EPieceType.Tail, metalType);

            return RobotFactory.CreateRobot(origin, modelName, RobotFactory.Pieces, isRidable);
        }

        /// <summary>
        /// Assigns a serial number between to a robot passed by parameters.
        /// </summary>
        /// <param name="minNumber">Minimun number of the serial range.</param>
        /// <param name="maxNumber">Maximun number of the serial range.</param>
        /// <param name="aRobot">Robot to assign a serial number.</param>
        /// <returns>A robot with a new serial number</returns>
        public static Robot AssignSerialNumber(int minNumber, int maxNumber, Robot aRobot) {
            aRobot.SerialNumber = rdn.Next(minNumber, maxNumber);
            foreach (Robot item in robotsInFactory) {
                if (item.SerialNumber == aRobot.SerialNumber) {
                    aRobot.SerialNumber = rdn.Next(minNumber, maxNumber);
                }
            }

            return aRobot;
        }

        /// <summary>
        /// Creates a Robot with all its data and pieces.
        /// </summary>
        /// <param name="origin">Origin of the robot.</param>
        /// <param name="modelName">Name of the model of the robot.</param>
        /// <param name="pieces">List of pieces for the robot.</param>
        /// <param name="isRidable">Boolean state that indicate if the robot is rideable or not.</param>
        /// <returns></returns>
        public static Robot CreateRobot(EOrigin origin, EModelName modelName, List<RobotPiece> pieces, bool isRidable) {
            Robot myRobot = new Robot(origin, modelName, pieces, isRidable);
            myRobot = AssignSerialNumber(100, 80000, myRobot);
            pieces.Clear();
            return myRobot;
        }

        /// <summary>
        /// Compares two robots and return a number 
        /// bassed on the serial number of the robots.
        /// </summary>
        /// <param name="r1">First robot to compare.</param>
        /// <param name="r2">Second robot to compare.</param>
        /// <returns>1 if the first is bigger, -1 if the second is bigger, otherwise 0.</returns>
        public static int OrderByRobotSerialNumber(Robot r1, Robot r2) {
            if (r1.SerialNumber > r2.SerialNumber) {
                return 1;
            } else if (r1.SerialNumber < r2.SerialNumber) {
                return -1;
            }

            return 0;
        }

        /// <summary>
        /// Chrages the bio's file of each robot in the list.
        /// </summary>
        /// <param name="filePath">Path of the biography file of each model of robot.</param>
        public static void ChargeBiography(string filePath) {
            string binPath = string.Empty;
            foreach (Robot item in RobotFactory.Robots) {
                binPath = $"{filePath}\\{item.Model}.bin";
                item.LoadBioFile(binPath);
            }
        }

        #endregion

        #region QualitySector

        /// <summary>
        /// Gets the total amount of materials needed to build the robot.
        /// </summary>
        /// <param name="aRobot">Robot to check the total amount pf materials.</param>
        /// <returns></returns>
        private static int AmountOfUsedMaterials(Robot aRobot) {
            return aRobot.AmountOfMaterials();
        }

        /// <summary>
        /// Simulates a quality control to check if the amount of pieces used
        /// to build it is the same of the pieces needed, based in the value of the
        /// enum of the model name.
        /// </summary>
        /// <param name="aRobot">A entity robot-type</param>
        /// <returns>True if the amount of pieces are equals, otherwise returns false.</returns>
        public static bool QualityControl(Robot aRobot, int expectedPieces) {
            int amountDifferentsRawMaterials = Enum.GetNames(typeof(EMaterial)).Length;

            if (!(aRobot is null)) {
                int totalToCheck = (int)aRobot * expectedPieces * amountDifferentsRawMaterials;
                int materialsOfTheRobot = AmountOfUsedMaterials(aRobot);
                if (materialsOfTheRobot == totalToCheck) {
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region DissasembleSector

        /// <summary>
        /// Recover the materials of the robotPiece.
        /// </summary>
        /// <param name="piece">Piece to recover its materials.</param>
        /// <returns>true if can recover the materials of the piece, otherwise returns false.</returns>
        private static bool RecoverPiece(RobotPiece piece) {
            int bucketsProccessed = 0;
            int amountBuckets = piece.RawMaterial.Count;
            foreach (MaterialBucket aBucket in piece.RawMaterial) {
                if (RecoverMaterial(aBucket)) {
                    bucketsProccessed++;
                }
            }
            if (bucketsProccessed == amountBuckets) {
                piece.RawMaterial.Clear();
                return true;
            }

            return false;
        }

        /// <summary>
        /// Recover the materials of the materialBucket.
        /// </summary>
        /// <param name="material">MaterialBucket to recover its materials.</param>
        /// <returns>True if can recover the materials of the materialBucket, otherwise returns false.</returns>
        private static bool RecoverMaterial(MaterialBucket material) {
            foreach (MaterialBucket item in buckets) {
                if (material == item) {
                    item.AmoutProduct += material.AmoutProduct;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Dissasembles the entire robot.
        /// </summary>
        /// <param name="aRobot">Robot to dissasemble.</param>
        /// <returns>True if can dissasemble the robot, otherwise returns false.</returns>
        public static bool DissasembleRobot(Robot aRobot) {
            int amountPieces = aRobot.RobotPieces.Count;
            int proccessedPieces = 0;
            foreach (RobotPiece item in aRobot.RobotPieces) {
                if (RecoverPiece(item)) {
                    proccessedPieces++;
                }
            }

            if (amountPieces == proccessedPieces) {
                aRobot.RobotPieces.Clear();
                aRobot = null;
                return true;
            }

            return false;
        }

        #endregion

        #region StockRelatedSector

        /// <summary>
        /// Adds a robot into the list of robots.
        /// </summary>
        /// <param name="aRobot">A robot to add into the list.</param>
        /// <returns>True if can add the robot.</returns>
        public static bool AddRobotToWarehouse(Robot aRobot) {
            if (!(aRobot is null)) {
                AddRobotToStock = aRobot;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Gets the amount of differents kinds of materials in the list
        /// </summary>
        /// <returns>The amount of differents kinds of materials in the list</returns>
        public static int CountMaterials() {
            return Materials.Count;
        }

        /// <summary>
        /// Gets the amount of differents kind of buckets in the list of buckets.
        /// </summary>
        /// <returns>The amount of differents kind of buckets in the list of buckets.</returns>
        public static int CountBuckets() {
            return Buckets.Count;
        }

        /// <summary>
        /// Saves the data of the actual stock of the factory
        /// in a XML file.
        /// </summary>
        public static void SaveDataOfFactory() {
            if(Buckets.Count > 0 || Robots.Count > 0) {
                if (!Directory.Exists(persistencePath)) {
                    Directory.CreateDirectory(persistencePath);
                }
                if (Buckets.Count > 0) {
                    sMBucket.Save(persistencePath, materialsPersistence, Buckets);
                }
                if (Robots.Count > 0) {
                    sMRobot.Save(persistencePath, robotPersistence, Robots);
                }
            }
        }

        #endregion

        #endregion
    }
}
