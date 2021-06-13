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
using SuperClasses;
using System;
using System.Text;

namespace Materials {
    public class MaterialBucket : IInformation {

        #region Attributes

        private Product productForBucket;
        private int amount;

        #endregion

        #region Builders

        /// <summary>
        /// Creates the entity with the constructor by default.
        /// </summary>
        public MaterialBucket() { }

        /// <summary>
        /// Creates the bucket with the product and the amount of it.
        /// </summary>
        /// <param name="p">Product to add in the bucket.</param>
        /// <param name="amount">Amount of the product inside the bucket.</param>
        public MaterialBucket(Product p, int amount) : this() {
            this.AmoutProduct = amount;
            this.ProductOfBucket = p;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get/Set: The product type of the bucket.
        /// </summary>
        public Product ProductOfBucket {
            get => this.productForBucket;
            set {
                if (value.GetType() == typeof(Product)) {
                    this.productForBucket = value;
                }
            }
        }

        /// <summary>
        /// Gets/Sets: the name of the product of the bucket.
        /// </summary>
        public string NameProductOfBucket {
            get => this.productForBucket.NameProduct;
            set {
                if (!String.IsNullOrWhiteSpace(value)) {
                    this.productForBucket.NameProduct = value;
                }
            }
        }

        /// <summary>
        /// Get/Set: The amount of product of the bucket.
        /// </summary>
        public int AmoutProduct {
            get => this.amount;
            set {
                if (value >= 0) {
                    this.amount = value;
                }
            }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Compares both materialBuckets bassed by it's name of product.
        /// </summary>
        /// <param name="b1">First material bucket to compare.</param>
        /// <param name="b2">Second material bucket to compare.</param>
        /// <returns>True if both material buckets are equals, otherwise returns false.</returns>
        public static bool operator ==(MaterialBucket b1, MaterialBucket b2) {
            if (!(b1 is null) && !(b2 is null)) {
                return b1.ProductOfBucket.NameProduct.Equals(b2.ProductOfBucket.NameProduct);
            }

            return false;
        }

        /// <summary>
        /// Compares both materialBuckets bassed by its name of product.
        /// </summary>
        /// <param name="b1">First material bucket to compare.</param>
        /// <param name="b2">Second material bucket to compare.</param>
        /// <returns>True if both material buckets aren't equals, otherwise returns false.</returns>
        public static bool operator !=(MaterialBucket b1, MaterialBucket b2) {
            return !(b1 == b2);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the product and the amount used of it.
        /// </summary>
        /// <returns>The product and the amount used of it as a string.</returns>
        public string Information() {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"{this.NameProductOfBucket} - {this.AmoutProduct} units.");

            return data.ToString();
        }

        /// <summary>
        /// Gets the amount of materials used for this bucket.
        /// Only for testing purposes.
        /// </summary>
        /// <returns>The amount of materials</returns>
        public int AmountOfMaterials() {
            return this.AmoutProduct;
        }

        #endregion

    }
}
