using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitii_laborator_9
{
    /// <summary>
    /// Modeleaza un autoturism electric
    /// </summary>
    class AutoturismElectric : Autoturism
    {
        /// <summary>
        /// Creeaza un autoturism electric
        /// </summary>
        /// <param name="producator">Accepta ca parametru un string</param>
        /// <param name="model">Accepta ca parametru un string</param>
        /// <param name="numarDeLocuri">Accepta ca parametru un int</param>
        public AutoturismElectric(string producator, string model, int numarDeLocuri) : base(producator, model, numarDeLocuri)
        {
        }


        /// <summary>
        /// Obtine un motor
        /// </summary>
        /// <returns>Returneaza un motor</returns>
        protected override Motor GetMotor() => new MotorElectric();


        /// <summary>
        /// Returneaza date despre obiectul curent
        /// </summary>
        /// <returns>Returneaza un string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.Append("  |  Motor electric");
            return sb.ToString();
        }
    }
}
