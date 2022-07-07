using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitii_laborator_9
{
    /// <summary>
    /// Modeleaza un camion
    /// </summary>
    class Camion : Autoutilitara
    {
        protected override int CantitateMaxima => 40;

        /// <summary>
        /// Creeaza un camion
        /// </summary>
        /// <param name="producator">Accepta ca parametru un string</param>
        /// <param name="model">Accepta ca parametru un string</param>
        public Camion(string producator, string model) : base(producator, model)
        {
        }


        /// <summary>
        /// Incarca camionul cu marfa
        /// </summary>
        /// <param name="deIncarcat">Accepta ca parametru un int</param>
        public override void IncarcaMarfa(int deIncarcat)
        {
            if (base.cantitateCurenta + deIncarcat <= this.CantitateMaxima)
            {
                base.cantitateCurenta += deIncarcat;
                Console.WriteLine($"Am incarcat camionul cu {base.cantitateCurenta} din {this.CantitateMaxima} tone");
            }
            else
                Console.WriteLine("Cantitatea depaseste incarcatura maxima");
        }


        /// <summary>
        /// Returneaza date despre obiectul curent
        /// </summary>
        /// <returns>Returneaza un string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.Append($"  |  Cantitate incarcata {base.cantitateCurenta} tone");
            return sb.ToString();
        }
    }
}
