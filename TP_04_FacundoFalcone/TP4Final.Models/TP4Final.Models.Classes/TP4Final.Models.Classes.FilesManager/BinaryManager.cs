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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Interfaces;

namespace Models {

    public class BinaryManager : IFilesManager<string> {

        /// <summary>
        /// Reads a filePath and extract the data from a binary file.
        /// </summary>
        /// <param name="filePath">Path of the file to read.</param>
        /// <returns>An entity of type T.</returns>
        public string Read(string filePath) {
            string myEntity = default;
            if (File.Exists(filePath)) {
                try {
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read)) {
                        BinaryFormatter formatter = new BinaryFormatter();
                        myEntity = (string)formatter.Deserialize(fileStream);
                    }
                } catch (Exception exe) {
                    throw new Exception(exe.Message, exe);
                }
            }

            return myEntity;
        }

        /// <summary>
        /// Saves an Entity in a binary file.
        /// </summary>
        /// <param name="path">Path of the directory to save the file.</param>
        /// <param name="filename">Name of the file to been save in the directory.</param>
        /// <param name="dataToSave">Entity to be saved into the file.</param>
        /// <returns>NotImplementedException</returns>
        public bool Save(string path, string filename, string dataToSave) {
            throw new NotImplementedException();
        }
    }
}
