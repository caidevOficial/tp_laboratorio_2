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
using System.Text;

namespace Entidades {
    public class Sedan : Vehiculo {

        #region Enums

        /// <summary>
        /// Enumerador para indicar si el Sedan 
        /// sera de 4 puertas o de 5 puertas.
        /// </summary>
        public enum ETipo {
            CuatroPuertas,
            CincoPuertas
        }

        #endregion

        #region Attributes

        private ETipo tipo;

        #endregion

        #region Builders

        /// <summary>
        /// Crea una instancia de Sedan y Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca">Marca del Sedan.</param>
        /// <param name="chasis">Chasis del Sedan.</param>
        /// <param name="color">Color del Sedan.</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : this(marca, chasis, color, ETipo.CuatroPuertas) { }

        /// <summary>
        /// Crea una instancia de Sedan seteando todos sus atributos.
        /// </summary>
        /// <param name="marca">Marca del Sedan.</param>
        /// <param name="chasis">Chasis del Sedan.</param>
        /// <param name="color">Color del Sedan.</param>
        /// <param name="tipo">Tipo del Sedan</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : base(chasis, marca, color) {
            this.tipo = tipo;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Propiedad ReadOnly, Retornara 'Mediano' Para Sedan
        /// </summary>
        protected override ETamanio Tamanio {
            get {
                return ETamanio.Mediano;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Obtiene todos los datos del Sedan y los lista en un string.
        /// </summary>
        /// <returns>Los datos del Sedan como string.</returns>
        public override sealed string Mostrar() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TIPO : {this.tipo}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion

    }
}
