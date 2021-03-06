using System;
using System.Text;

namespace Exercitii_laborator_9
{
    /// <summary>
    /// Modeleaza un autovehicul
    /// </summary>
    abstract class Autovehicul
    {
        private readonly string producator = string.Empty;
        private readonly string model = string.Empty;
        protected abstract Motor Motor { get; }


        /// <summary>
        /// Creeaza un autovehicul
        /// </summary>
        /// <param name="producator">Accepta ca parametru un string</param>
        /// <param name="model">Accepta ca parametru un string</param>
        public Autovehicul(string producator, string model)
        {
            this.producator = producator;
            this.model = model;
        }


        /// <summary>
        /// Porneste autovehiculul
        /// </summary>
        public virtual void Porneste()
        {
            Console.WriteLine(this.Motor.SunetMotor);
        }


        /// <summary>
        /// Returneaza date despre obiectul curent
        /// </summary>
        /// <returns>Returneaza un string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Producator {this.producator}  |  Model {this.model}");
            return sb.ToString();
        }
    }
}
