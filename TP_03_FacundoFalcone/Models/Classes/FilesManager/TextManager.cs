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

namespace Models {
    public class TextManager : IFilesManager<string> {

        #region Methods

        /// <summary>
        /// This Method no need to be implemented.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public string Read(string file) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves a stream into a file.
        /// </summary>
        /// <param name="path">Path to save the file.</param>
        /// <param name="fileName">Name of the file to save in the path.</param>
        /// <param name="dataToSave">Data to write into the file.</param>
        /// <returns>True if can write the file, otherwise returns false.</returns>
        public bool Save(string path, string filename, string dataToSave) {
            string absPath = $"{path}\\{filename}";
            StringBuilder data = new StringBuilder();
            data.AppendLine($"{DateTime.Now} - {dataToSave}\n-----------------------------");
            try {
                if (!Directory.Exists(path)) {
                    Directory.CreateDirectory(path);
                }
                using (StreamWriter sw = File.AppendText($"{absPath}")) {
                    sw.WriteLine(data);
                    return true;
                }
            } catch (Exception ex) {
                throw new Exception("Something get wrong trying saving Document", ex);
            }
        }

        /// <summary>
        /// Saves a stream into a file.
        /// </summary>
        /// <param name="path">Path to save the file.</param>
        /// <param name="fileName">Name of the file to save in the path.</param>
        /// <param name="dataToSave">Data to write into the file.</param>
        /// <returns>True if can write the file, otherwise returns false.</returns>
        public bool SaveFull(string path, string fileName, string dataToSave) {
            return Save(path, fileName, dataToSave);
        }

        /// <summary>
        /// Saves the data from the Exception into a file in the path passed by parameter.
        /// </summary>
        /// <param name="path">Path to save the file.</param>
        /// <param name="filename">Name of the file with its extension '.txt'.</param>
        /// <param name="exe">Exception to extract its data.</param>
        /// <returns>True if can write the file, otherwise returns false.</returns>
        public bool SaveExceptionDetail(string path, string filename, Exception exe) {
            try {
                if (this.Save(path, filename, exe.Message)) {
                    return true;
                }
            } catch (Exception ex) {
                throw new Exception("Something get wrong trying saving Exceptions details", ex);
            }

            return false;
        }

        #endregion
    }
}
