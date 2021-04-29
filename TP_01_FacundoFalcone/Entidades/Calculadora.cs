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
    public static class Calculadora {

        #region Validate

        /// <summary>
        /// Validates if the operator is correct.
        /// </summary>
        /// <param name="operador">Operator to validate if is +,-,* or /.</param>
        /// <returns>Returns the operator if it is correct, otherwise returns the adding operator '+'.</returns>
        private static string ValidarOperador(char operador) {
            if (operador == '+' || operador == '-' || operador == '*' || operador == '/') {
                return operador.ToString();
            }

            return "+";
        }

        #endregion

        #region OperarCalculadora

        /// <summary>
        /// Tries to do the basic operations of a calculator and returns its result.
        /// </summary>
        /// <param name="numero1">First Number to operate.</param>
        /// <param name="numero2">Second Number to operate.</param>
        /// <param name="operador">Operator to do the calculus.</param>
        /// <returns>Returns the result if can do the operation, otherwise returns 0</returns>
        public static double Operar(Numero numero1, Numero numero2, string operador) {
            double resultado = 0;
            if (Char.TryParse(operador, out char theOperator)) {
                string correctOperator = ValidarOperador(theOperator);
                switch (correctOperator) {
                    case "+":
                        resultado = numero1 + numero2;
                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        break;
                    case "*":
                        resultado = numero1 * numero2;
                        break;
                    case "/":
                        resultado = numero1 / numero2;
                        break;
                }
            }

            return resultado;
        }
    }

    #endregion
}
