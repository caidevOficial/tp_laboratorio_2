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

namespace Entidades {
    public class Numero {
        private double numero;

        #region Buidlers

        /// <summary>
        /// Initializes the number in 0.
        /// </summary>
        public Numero() {
            this.numero = 0;
        }

        /// <summary>
        /// Builds the entity with value 'numero'.
        /// </summary>
        /// <param name="numero">Value to builds the entity.</param>
        public Numero(double numero) : this() {
            this.numero = numero;
        }

        /// <summary>
        /// Tries to convert the string-format number to a correct double-format.
        /// </summary>
        /// <param name="strNumero">String number to convert and set.</param>
        public Numero(string strNumero) : this() {
            this.SetNumero = strNumero;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Validates the number and sets to the entity.
        /// </summary>
        public string SetNumero {
            set {
                this.numero = ValidarNumero(value);
            }
        }

        #endregion

        #region Validators

        /// <summary>
        /// Comprobes that the received value is numeric, then returns it as a double format.
        /// </summary>
        /// <param name="numero">String-format number to validate.</param>
        /// <returns>The number in double-format if is correct, otherwise returns 0.</returns>
        private static double ValidarNumero(string numero) {
            if (Double.TryParse(numero, out double number)) {
                return number;
            }

            return 0;
        }

        /// <summary>
        /// Checks if the string is binary-format.
        /// </summary>
        /// <param name="binario">String to validate.</param>
        /// <returns>True if is binary-format, otherwise returns false.</returns>
        private static bool EsBinario(string binary) {
            for (int i = 0; i < binary.Length - 1; i++) {
                if (binary[i] != '1' && binary[i] != '0') {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region Converters

        /// <summary>
        /// Converts a double-type number to a Binary string.
        /// </summary>
        /// <param name="numero">Number to converts.</param>
        /// <returns>The binary string if everything is ok, otherwise an error message.</returns>
        public string DecimalBinario(double numero) {
            string binaryStr = string.Empty;
            int integerNumber = (int)Math.Abs(numero);

            if (integerNumber == 0) {
                binaryStr = "0";
            } else {
                while (integerNumber > 0) {
                    binaryStr = (int)integerNumber % 2 + binaryStr;
                    integerNumber = (int)integerNumber / 2;
                }
            }

            return binaryStr;
        }

        /// <summary>
        /// Tries to convert a string number to a string-formar binary number.
        /// </summary>
        /// <param name="numero">String-format number to convert to binary.</param>
        /// <returns>The number converted or an Error message.</returns>
        public string DecimalBinario(string numero) {
            if (Double.TryParse(numero, out double theNumber)) {
                return DecimalBinario(theNumber);
            }

            return "Valor Invalido";
        }

        /// <summary>
        /// Tries to convert a string-type binary to a decimal number.
        /// </summary>
        /// <param name="binario">String-type number to convert.</param>
        /// <returns>Returns the decimal number if everything is ok, otherwise returns an error message.</returns>
        public string BinarioDecimal(string binario) {
            char[] binaryArray = binario.ToCharArray();
            Array.Reverse(binaryArray);

            string errorMessage = "Valor Invalido";
            int decimalSum = 0;

            if (EsBinario(binario)) {
                for (int i = 0; i < binaryArray.Length; i++) {
                    if (binaryArray[i] == '1') {
                        // si es 1, sumo 2 elevado a la indice al acumulador
                        decimalSum += (int)Math.Pow(2, i);
                    }
                }
                //convierto el resultado en string y lo retorno
                return decimalSum.ToString();
            }
            return errorMessage;
        }

        #endregion

        #region Operators

        /// <summary>
        /// Tries to do a numerical addition between two numbers.
        /// </summary>
        /// <param name="n1">First number to sum.</param>
        /// <param name="n2">Second number to sum.</param>
        /// <returns>Returns the addition of both numbers.</returns>
        public static double operator +(Numero n1, Numero n2) {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Tries to do a numerical subtraction between two numbers.
        /// </summary>
        /// <param name="n1">First number to subtract.</param>
        /// <param name="n2">Second number to subtract.</param>
        /// <returns>Returns the subtraction of both numbers.</returns>
        public static double operator -(Numero n1, Numero n2) {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Tries to do a numerical multiplication between two numbers.
        /// </summary>
        /// <param name="n1">First number to multiplicate.</param>
        /// <param name="n2">Second number to multiplicate.</param>
        /// <returns>Returns the multiplication of both numbers.</returns>
        public static double operator *(Numero n1, Numero n2) {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Tries to do a numerical divition between two numbers.
        /// </summary>
        /// <param name="n1">First number to divide.</param>
        /// <param name="n2">Second number to divide.</param>
        /// <returns>Returns the divition of both numbers, otherwise if the second number is 0 returns the minimal value of a Double.</returns>
        public static double operator /(Numero n1, Numero n2) {
            if (n2.numero != 0) {
                return n1.numero / n2.numero;
            }

            return Double.MinValue;
        }

        #endregion
    }
}
