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
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Models {

    public class SerialManager<T> : IFilesManager<T> {

        #region Methods

        /// <summary>
        /// Reads the data from the path passed by parameter.
        /// </summary>
        /// <param name="filePath">Path to read the file.</param>
        /// <returns>True if can read the file, otherwise returns false.</returns>
        public T Read(string filePath) {
            T aux;
            try {
                using (XmlTextReader reader = new XmlTextReader(filePath)) {
                    XmlSerializer serial = new XmlSerializer(typeof(T));
                    aux = (T)serial.Deserialize(reader);
                }
            } catch (Exception ex) {
                throw new Exception("Something get wrong trying reading Buckets", ex);
            }

            return aux;
        }

        /// <summary>
        /// Saves the data from the T object into a file in the path passed by parameter.
        /// </summary>
        /// <param name="filePath">Path to save the file.</param>
        /// <param name="dataToSave">Object to save in the file.</param>
        /// <returns>True if can write the file, otherwise returns false.</returns>
        public bool Save(string path, string filename, T dataToSave) {
            string absPath = $"{path}\\{filename}";
            try {
                if (!Directory.Exists(path)) {
                    Directory.CreateDirectory(path);
                }
                using (XmlTextWriter writer = new XmlTextWriter(absPath, Encoding.UTF8)) {
                    XmlSerializer serial = new XmlSerializer(typeof(T));
                    serial.Serialize(writer, dataToSave);
                    return true;
                }
            } catch (Exception ex) {
                throw new Exception("Something get wrong trying saving Buckets", ex);
            }
        }

        #endregion

    }
}
