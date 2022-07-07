using System;
using System.Text;

namespace Exercitii_laborator_9
{
    /// <summary>
    /// Modeleaza o autoutilitara
    /// </summary>
    abstract class Autoutilitara : Autovehicul
    {
        protected override Motor Motor => new MotorDiesel();
        protected abstract int CantitateMaxima { get; }
        protected int cantitateCurenta = 0;


        /// <summary>
        /// Creeaza o autoutilitara
        /// </summary>
        /// <param name="producator">Accepta ca parametru un string</param>
        /// <param name="model">Accepta ca parametru un string</param>
        public Autoutilitara(string producator, string model) : base(producator, model)
        {
        }


        /// <summary>
        /// Incarca autoutilitara cu marfa
        /// </summary>
        /// <param name="deIncarcat">Accepta ca parametru un int</param>
        abstract public void IncarcaMarfa(int deIncarcat);


        /// <summary>
        /// Returneaza date despre obiectul curent
        /// </summary>
        /// <returns>Returneaza un string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.Append("  |  Motor Diesel");
            return sb.ToString();
        }
    }
}
