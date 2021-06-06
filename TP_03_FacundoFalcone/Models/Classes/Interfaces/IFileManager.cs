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

namespace Interfaces {
    public interface IFileManager<T, U> {

        /// <summary>
        /// Saves the data from the list of robots into a file in the path passed by parameter.
        /// </summary>
        /// <param name="path">Path to save the file.</param>
        /// <param name="file">List to save in the file.</param>
        /// <returns>True if can write the file, otherwise returns false.</returns>
        bool SaveRobotFile(string path, List<T> file);

        /// <summary>
        /// Saves the data from the list of buckets into a file in the path passed by parameter.
        /// </summary>
        /// <param name="path">Path to save the file.</param>
        /// <param name="file">List to save in the file.</param>
        /// <returns>True if can write the file, otherwise returns false.</returns>
        bool SaveBucketsFile(string path, List<U> file);

        /// <summary>
        /// Saves the data from the Exception into a file in the path passed by parameter.
        /// </summary>
        /// <param name="path">Path to save the file.</param>
        /// <param name="filename">Name of the file with its extension '.txt'.</param>
        /// <param name="exe">Exception to extract its data.</param>
        /// <returns>True if can write the file, otherwise returns false.</returns>
        bool SaveExceptionDetail(string path, string filename, Exception exe);

        /// <summary>
        /// Saves the data from the Text into a file in the path passed by parameter.
        /// </summary>
        /// <param name="path">Path to save the file.</param>
        /// <param name="filename">Name of the file with its extension '.txt'.</param>
        /// <param name="text">Text to write in the file.</param>
        /// <returns>True if can write the file, otherwise returns false.</returns>
        bool SaveDocument(string path, string filename, string text);

        /// <summary>
        /// Reads the data from the path passed by parameter.
        /// </summary>
        /// <param name="path">Path to read the file.</param>
        /// <returns>True if can read the file, otherwise returns false.</returns>
        List<T> ReadRobotFile(string path);

        /// <summary>
        /// Reads the data from the path passed by parameter.
        /// </summary>
        /// <param name="path">Path to read the file.</param>
        /// <returns>True if can read the file, otherwise returns false.</returns>
        List<U> ReadBucketsFile(string path);
    }
}
