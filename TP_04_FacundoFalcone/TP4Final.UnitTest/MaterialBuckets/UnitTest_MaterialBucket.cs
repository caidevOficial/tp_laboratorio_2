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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperClasses;

namespace UnitTestProjectTPFinal {

    [TestClass]
    public class UnitTest_MaterialBucket {

        private MaterialBucket bucket;
        private MaterialBucket anotherBucket;

        /// <summary>
        /// Checks that the MaterialBucket and its product inside aren't null.
        /// </summary>
        [TestMethod]
        public void Test01_Checks_Items_Arent_Null() {

            #region Arrange

            bucket = new MaterialBucket(new Product("Battery", EMaterial.Battery), 10);

            #endregion

            #region Act

            #endregion

            #region Assert

            Assert.IsNotNull(bucket);
            Assert.IsNotNull(bucket.ProductOfBucket);
            Assert.AreEqual(10, bucket.AmoutProduct);

            #endregion
        }

        /// <summary>
        /// Checks that the items are equals, bassed in their product name.
        /// </summary>
        [TestMethod]
        public void Test02_Checks_Items_Are_Equals() {

            #region Arrange

            bucket = new MaterialBucket(new Product("Battery", EMaterial.Battery), 10);
            anotherBucket = new MaterialBucket(new Product("Battery", EMaterial.Metal), 20);

            #endregion

            #region Act

            bool equals = bucket == anotherBucket;
            bool differents = bucket != anotherBucket;

            #endregion

            #region Assert

            Assert.IsTrue(equals);
            Assert.IsFalse(differents);

            #endregion
        }

        /// <summary>
        /// Checks that the amount of materials are correct.
        /// </summary>
        [TestMethod]
        public void Test03_Checks_Items_Amount_Materials() {

            #region Arrange

            bucket = new MaterialBucket(new Product("Battery", EMaterial.Battery), 10);
            anotherBucket = new MaterialBucket(new Product("Battery", EMaterial.Metal), 20);

            #endregion

            #region Act

            int materialsB1 = bucket.AmountOfMaterials();
            int materialsB2 = anotherBucket.AmountOfMaterials();

            #endregion

            #region Assert

            Assert.AreEqual(10, materialsB1);
            Assert.AreEqual(20, materialsB2);

            #endregion
        }
    }
}
