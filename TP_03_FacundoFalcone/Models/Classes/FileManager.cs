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

using Interfaces;
using Materials;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Models {
    public class FileManager : IFileManager<Robot, MaterialBucket> {

        #region Builder

        /// <summary>
        /// Creates the entity with de the default constructor.
        /// </summary>
        public FileManager() { }

        #endregion

        #region Methods

        /// <summary>
        /// Reads the data from the path passed by parameter.
        /// </summary>
        /// <param name="path">Path to read the file.</param>
        /// <returns>True if can read the file, otherwise returns false.</returns>
        public List<MaterialBucket> ReadBucketsFile(string path) {
            List<MaterialBucket> aux;
            try {
                using (XmlTextReader reader = new XmlTextReader(path)) {
                    XmlSerializer serial = new XmlSerializer(typeof(List<MaterialBucket>));
                    aux = (List<MaterialBucket>)serial.Deserialize(reader);
                }
            } catch (Exception) {

                throw;
            }

            return aux;
        }

        /// <summary>
        /// Reads the data from the path passed by parameter.
        /// </summary>
        /// <param name="path">Path to read the file.</param>
        /// <returns>True if can read the file, otherwise returns false.</returns>
        public List<Robot> ReadRobotFile(string path) {
            List<Robot> aux;
            using (XmlTextReader reader = new XmlTextReader(path)) {
                XmlSerializer serial = new XmlSerializer(typeof(List<Robot>));
                aux = (List<Robot>)serial.Deserialize(reader);
            }

            return aux;
        }

        /// <summary>
        /// Saves the data from the list of buckets into a file in the path passed by parameter.
        /// </summary>
        /// <param name="path">Path to save the file.</param>
        /// <param name="file">List to save in the file.</param>
        /// <returns>True if can write the file, otherwise returns false.</returns>
        public bool SaveBucketsFile(string path, List<MaterialBucket> stockBuckets) {
            return SaveBucketsFiles(path, stockBuckets);
        }

        /// <summary>
        /// Saves the data from the list of buckets into a file in the path passed by parameter.
        /// </summary>
        /// <param name="path">Path to save the file.</param>
        /// <param name="file">List to save in the file.</param>
        /// <returns>True if can write the file, otherwise returns false.</returns>
        public static bool SaveBucketsFiles(string path, List<MaterialBucket> stockBuckets) {
            try {
                using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8)) {
                    XmlSerializer serial = new XmlSerializer(typeof(List<MaterialBucket>));
                    serial.Serialize(writer, stockBuckets);
                    return true;
                }
            } catch (Exception ex) {

                throw;
            }
            
        }

        /// <summary>
        /// Saves the data from the Text into a file in the path passed by parameter.
        /// </summary>
        /// <param name="path">Path to save the file.</param>
        /// <param name="filename">Name of the file with its extension '.txt'.</param>
        /// <param name="text">Text to write in the file.</param>
        /// <returns>True if can write the file, otherwise returns false.</returns>
        public bool SaveDocument(string path, string filename, string text) {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"{DateTime.Now} - {text}\n-----------------------------");
            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }
            using (StreamWriter sw = File.AppendText($"{path}\\{filename}")) {
                sw.WriteLine(data);
                return true;
            }
        }

        /// <summary>
        /// Saves the data from the Exception into a file in the path passed by parameter.
        /// </summary>
        /// <param name="path">Path to save the file.</param>
        /// <param name="filename">Name of the file with its extension '.txt'.</param>
        /// <param name="exe">Exception to extract its data.</param>
        /// <returns>True if can write the file, otherwise returns false.</returns>
        public bool SaveExceptionDetail(string path, string filename, Exception exe) {

            StringBuilder data = new StringBuilder();
            data.AppendLine($"{DateTime.Now} - {exe.ToString()}\n-----------------------------\n");

            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }
            using (StreamWriter sw = File.AppendText($"{path}\\{filename}")) {
                sw.WriteLine(data);
                return true;
            }
        }

        /// <summary>
        /// Saves the data from the list of robots into a file in the path passed by parameter.
        /// </summary>
        /// <param name="path">Path to save the file.</param>
        /// <param name="file">List to save in the file.</param>
        /// <returns>True if can write the file, otherwise returns false.</returns>
        public bool SaveRobotFile(string path, List<Robot> stockRobots) {
            return SaveRobotFiles(path, stockRobots);
        }

        /// <summary>
        /// Saves the data from the list of robots into a file in the path passed by parameter.
        /// </summary>
        /// <param name="path">Path to save the file.</param>
        /// <param name="file">List to save in the file.</param>
        /// <returns>True if can write the file, otherwise returns false.</returns>
        public static bool SaveRobotFiles(string path, List<Robot> stockRobots) {
            using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8)) {
                XmlSerializer serial = new XmlSerializer(typeof(List<Robot>));
                serial.Serialize(writer, stockRobots);
                return true;
            }
        }

        #endregion

    }
}
