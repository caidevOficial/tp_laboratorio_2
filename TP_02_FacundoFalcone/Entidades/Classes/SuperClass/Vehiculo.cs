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

    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo {

        #region Enums

        /// <summary>
        /// Enumerado con las posibles marcas del vehiculo.
        /// </summary>
        public enum EMarca {
            Chevrolet,
            Ford,
            Renault,
            Toyota,
            BMW,
            Honda,
            HarleyDavidson
        }

        /// <summary>
        /// Enumarado con los posibles tamaños del vehiculo.
        /// </summary>
        public enum ETamanio {
            Chico,
            Mediano,
            Grande
        }

        #endregion

        #region Attributes

        private EMarca marca;
        private string chasis;
        private ConsoleColor color;

        #endregion

        #region Builders

        /// <summary>
        /// Constructor de vehiculo con sus datos.
        /// </summary>
        /// <param name="chasis">Chasis del vehiculo.</param>
        /// <param name="marca">Marca del vehiculo.</param>
        /// <param name="color">Color del vehiculo.</param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color) {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Propiedad ReadOnly Abstracta: Retornará el tamaño al implementarse.
        /// </summary>
        protected abstract ETamanio Tamanio { get; }

        #endregion

        #region Operators

        /// <summary>
        /// Castea explicitamente un objeto tipo vehiculo
        /// y retorna su informacion basica como un string.
        /// </summary>
        /// <param name="p">Instancia tipo vehiculo a castear</param>
        public static explicit operator string(Vehiculo p) {
            StringBuilder sb = new StringBuilder();
            if (!(p is null)) {
                sb.AppendLine($"## {p.GetType().Name.ToUpper()} ##");
                sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
                sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
                sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
                sb.AppendLine("---------------------");
                sb.AppendFormat("TAMAÑO : {0} ", p.Tamanio);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Compara si dos vehiculos son iguales al compartir el mismo chasis.
        /// </summary>
        /// <param name="v1">Primer objeto tipo vehiculo a comparar</param>
        /// <param name="v2">Segundo objeto tipo vehiculo a comparar</param>
        /// <returns>Retorna True si sus chasis son iguales, sino false.</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2) {
            if (!(v1 is null) && !(v2 is null)) {
                return String.Compare(v1.chasis, v2.chasis) == 0;
            }

            return false;
        }

        /// <summary>
        /// Compara si dos vehiculos son diferentes al tener diferentes chasis.
        /// </summary>
        /// <param name="v1">Primer objeto tipo vehiculo a comparar</param>
        /// <param name="v2">Segundo objeto tipo vehiculo a comparar</param>
        /// <returns>Retorna True si sus chasis NO son iguales, sino false.</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2) {
            return !(v1 == v2);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Obtiene todos los datos del Vehiculo y los lista en un string.
        /// </summary>
        /// <returns>Los datos del Vehiculo como string.</returns>
        public virtual string Mostrar() {
            return (string)this;
        }

        #endregion
    }
}
