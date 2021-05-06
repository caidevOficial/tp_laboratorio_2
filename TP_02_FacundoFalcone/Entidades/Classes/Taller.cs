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

using System.Collections.Generic;
using System.Text;

namespace Entidades {
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller {

        #region Enums

        /// <summary>
        /// Enumerado para el tipo de vehiculo.
        /// </summary>
        public enum ETipo {
            Ciclomotor,
            Sedan,
            SUV,
            Todos
        }

        #endregion

        #region Attributes

        private List<Vehiculo> vehiculos;
        private int espacioDisponible;

        #endregion

        #region "Constructores"

        /// <summary>
        /// Crea la instancia Taller e inicializa la lista de vehiculos.
        /// </summary>
        private Taller() {
            this.vehiculos = new List<Vehiculo>();
        }

        /// <summary>
        /// Crea la instancia de Taller seteandole el espacio disponible
        /// e inicializa la lista de vehiculos.
        /// </summary>
        /// <param name="espacioDisponible">Espacio de vehiculos disponibles del taller</param>
        public Taller(int espacioDisponible) : this() {
            this.espacioDisponible = espacioDisponible;
        }

        #endregion

        #region "Operadores"

        /// <summary>
        /// Agregará un elemento a la lista en caso de que no exista en la lista de vehiculos 
        /// de la instancia de clase taller.
        /// </summary>
        /// <param name="taller">instancia de clase Taller donde se agregará el elemento</param>
        /// <param name="vehiculo">Instancia a agregar en la lista de vehiculos de la instancia clase taller</param>
        /// <returns>El taller con el objeto Vehiculo en caso de que no exista y pueda agregarlo, sino retornara el taller tal cual estaba.</returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo) {

            if (!(taller is null) && !(vehiculo is null)) {
                if (taller.vehiculos.Count < taller.espacioDisponible) {
                    foreach (Vehiculo v in taller.vehiculos) {
                        if (v == vehiculo) {
                            return taller;
                        }
                    }
                    taller.vehiculos.Add(vehiculo);
                }
            }

            return taller;
        }

        /// <summary>
        /// Quitará un elemento de la lista si lo encuentra, sino lo encuentra
        /// no hara nada, en ambos casos retornara el taller con o sin la instancia a quitar.
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento en caso de existir.</param>
        /// <param name="vehiculo">Objeto a quitar de la lista en caso de existir.</param>
        /// <returns>El taller sin el objeto Vehiculo en caso de que exista, sino retornara el taller tal cual estaba.</returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo) {
            if (!(taller is null) && !(vehiculo is null)) {
                if (taller.vehiculos.Count > 0) {
                    foreach (Vehiculo v in taller.vehiculos) {
                        if (v == vehiculo) {
                            taller.vehiculos.Remove(v);
                            break;
                        }
                    }
                }
            }

            return taller;
        }

        #endregion

        #region "Sobrecargas"

        /// <summary>
        /// Obtiene info del Taller y los vehículos de 
        /// tipo Ciclomotor, SUV y Sedan.
        /// </summary>
        /// <returns>Retorna la info de todos los vehiculos del taller como un string.</returns>
        public override string ToString() {
            return Listar(this, ETipo.Todos);
        }

        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Taller a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns>Retorna un string con la informacion del taller.</returns>
        public static string Listar(Taller taller, ETipo tipo) {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", taller.vehiculos.Count, taller.espacioDisponible);
            sb.AppendLine("");
            foreach (Vehiculo v in taller.vehiculos) {
                switch (tipo) {
                    case ETipo.SUV:
                        if (v is Suv) {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Ciclomotor:
                        if (v is Ciclomotor) {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Sedan:
                        if (v is Sedan) {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    default:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }

        #endregion
    }
}
