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

namespace SuperClasses {
    public class Product {

        #region Attributes

        private string nameProduct;
        private EMaterial material;

        #endregion

        #region Builders

        /// <summary>
        /// Creates the entity with the default constructor.
        /// </summary>
        public Product() { }

        /// <summary>
        /// Creates the entity with id, name and material.
        /// </summary>
        /// <param name="id">ID of the entity.</param>
        /// <param name="name">Name of the entity.</param>
        /// <param name="material">Material of the entity.</param>
        public Product(string name, EMaterial material) : this() {
            this.NameProduct = name;
            this.MaterialProduct = material;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get/Set: The name of the product.
        /// </summary>
        public string NameProduct {
            get => this.nameProduct;
            set {
                if (!string.IsNullOrWhiteSpace(value)) {
                    this.nameProduct = value;
                }
            }
        }

        /// <summary>
        /// Get/Set: The type of material of the product.
        /// </summary>
        public EMaterial MaterialProduct {
            get => this.material;
            set {
                if (value.GetType() == typeof(EMaterial)) {
                    this.material = value;
                }
            }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Compares two product to check if are equals.
        /// </summary>
        /// <param name="a">First product to compare.</param>
        /// <param name="b">Second product to compare.</param>
        /// <returns>True if both products are equals, otherwise returns false.</returns>
        public static bool operator ==(Product a, Product b) {
            if (!(a is null) && !(b is null)) {
                return a.nameProduct.Equals(b.nameProduct);
            }
            return false;
        }

        /// <summary>
        /// Compares two product to check if aren't equals.
        /// </summary>
        /// <param name="a">First product to compare.</param>
        /// <param name="b">Second product to compare.</param>
        /// <returns>True if both products aren't equals, otherwise returns false.</returns>
        public static bool operator !=(Product a, Product b) {
            return !(a == b);
        }

        #endregion

    }
}
