using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitii_laborator_9
{
    /// <summary>
    /// Modeleaza un autoturism hibrid
    /// </summary>
    class AutoturismHibrid : Autoturism
    {
        /// <summary>
        /// Creeaza un autoturism hibrid
        /// </summary>
        /// <param name="producator">Accepta ca parametru un string</param>
        /// <param name="model">Accepta ca parametru un string</param>
        /// <param name="numarDeLocuri">Accepta ca parametru un int</param>
        public AutoturismHibrid(string producator, string model, int numarDeLocuri) : base(producator, model, numarDeLocuri)
        {
        }


        /// <summary>
        /// Obtine un motor
        /// </summary>
        /// <returns>Returneaza un motor</returns>
        protected override Motor GetMotor() => new MotorHibrid();


        /// <summary>
        /// Returneaza date despre obiectul curent
        /// </summary>
        /// <returns>Returneaza un string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.Append("  |  Motor Hibrid");
            return sb.ToString();
        }
    }
}
