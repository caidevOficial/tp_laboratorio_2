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

namespace TestDeConsola {
    class Program {
        static void Main(string[] args) {

            Console.Title = "Test Console TP Final";
            Console.ForegroundColor = ConsoleColor.Green;

            #region Atributos

            TextManager logger = new TextManager();
            string mainPath = $"{Environment.CurrentDirectory}";
            string logsPath = $"{mainPath}\\Logs";
            string buildHistoryPath = $"{mainPath}\\BuildBinnacle";
            string pathBiography = $"{mainPath}\\Bio\\";
            string filename;
            string absBioPath;
            string robotBuildDetails;

            #endregion

            #region Entidades

            Robot wallE;
            Robot errorException;
            bool materialSuficiente;
            bool calidadExitosa;

            #endregion

            #region CargaStockDeMateriales

            RobotFactory.InitFactoryAndStock();
            for (int i = 0; i < 30; i++) {
                RobotFactory.UpdateRawMaterialsOfBuckets();
            }

            #endregion

            #region PrimerCasoDeTesteoExitoso

            Console.WriteLine("Primer Robot:\n");
            materialSuficiente = RobotFactory.CheckAmountOfMaterialsInBuckets((int)EModelName.WallE);
            Console.WriteLine($"Material Suficiente Para Fabricar: {materialSuficiente}");
            if (materialSuficiente) {

                RobotFactory.AddPieceToStock = RobotFactory.ManufacturePiece((int)EModelName.WallE, EPieceType.Head, EMetalType.Aluminium);
                RobotFactory.AddPieceToStock = RobotFactory.ManufacturePiece((int)EModelName.WallE, EPieceType.Torso, EMetalType.Aluminium);
                RobotFactory.AddPieceToStock = RobotFactory.ManufacturePiece((int)EModelName.WallE, EPieceType.UpperLimb, EMetalType.Aluminium);
                RobotFactory.AddPieceToStock = RobotFactory.ManufacturePiece((int)EModelName.WallE, EPieceType.UpperLimb, EMetalType.Aluminium);
                RobotFactory.AddPieceToStock = RobotFactory.ManufacturePiece((int)EModelName.WallE, EPieceType.LowerLimb, EMetalType.Aluminium);
            }

            wallE = RobotFactory.CreateRobot(EOrigin.Earth, EModelName.WallE, RobotFactory.Pieces, false);
            calidadExitosa = RobotFactory.QualityControl(wallE, 5);
            Console.WriteLine($"Paso control de calidad: {calidadExitosa}");

            filename = wallE.Model.ToString();
            absBioPath = $"{pathBiography}{filename}.bin";
            wallE.LoadBioFile(absBioPath);
            robotBuildDetails = wallE.Information();
            Console.WriteLine(robotBuildDetails);
            logger.SaveFull(buildHistoryPath, "Builds.txt", $"{robotBuildDetails}");
            
            #endregion

            #region SegundoCasoDeTesteoFallido

            Console.WriteLine("Segundo Robot:\n");

            try {
                materialSuficiente = RobotFactory.CheckAmountOfMaterialsInBuckets((int)EModelName.C3PO);
                Console.WriteLine($"Material Suficiente Para Fabricar: {materialSuficiente}");
                if (materialSuficiente) {

                    RobotFactory.AddPieceToStock = RobotFactory.ManufacturePiece((int)EModelName.C3PO, EPieceType.Head, EMetalType.Aluminium);
                    RobotFactory.AddPieceToStock = RobotFactory.ManufacturePiece((int)EModelName.C3PO, EPieceType.Torso, EMetalType.Aluminium);
                    RobotFactory.AddPieceToStock = RobotFactory.ManufacturePiece((int)EModelName.C3PO, EPieceType.UpperLimb, EMetalType.Aluminium);
                    RobotFactory.AddPieceToStock = RobotFactory.ManufacturePiece((int)EModelName.C3PO, EPieceType.UpperLimb, EMetalType.Aluminium);

                    errorException = RobotFactory.CreateRobot(EOrigin.Tatooine, EModelName.C3PO, RobotFactory.Pieces, false);
                    calidadExitosa = RobotFactory.QualityControl(errorException, 6);
                    Console.WriteLine($"Paso control de calidad: {calidadExitosa}");

                    filename = errorException.Model.ToString();
                    absBioPath = $"{pathBiography}{filename}.bin";
                    errorException.LoadBioFile(absBioPath);
                    if (!calidadExitosa) {
                        throw new QualityControlFailedException($"Fallo el control de calidad para el segundo robot: {errorException.Model.ToString()}");
                    } else {
                        Console.WriteLine(errorException.Information());
                    }
                } else {
                    throw new InsufficientMaterialsException($"Materiales isuficientes para fabricar el robot.");
                }
            } catch (Exception im) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(im.Message);
                if(logger.SaveExceptionDetail(logsPath, "Exceptions.txt", im)) {
                    Console.WriteLine("A log file has been created.");
                }
            }

            #endregion

            Console.ReadKey();

        }
    }
}
