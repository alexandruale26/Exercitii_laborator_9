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
        private readonly Motor motor;


        /// <summary>
        /// Creeaza un autovehicul
        /// </summary>
        /// <param name="producator">Accepta ca parametru un string</param>
        /// <param name="model">Accepta ca parametru un string</param>
        /// <param name="motor">Accepta ca parametru un motor</param>
        public Autovehicul(string producator, string model, Motor motor)
        {
            this.producator = producator;
            this.model = model;
            this.motor = motor;
        }


        /// <summary>
        /// Porneste autovehiculul
        /// </summary>
        public virtual void Porneste()
        {
            Console.WriteLine(motor.SePornesteMotor());
        }


        /// <summary>
        /// Returneaza date despre obiectul curent
        /// </summary>
        /// <returns>Returneaza un string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Producator {this.producator}  |  Model {this.model}  |  Motor {Enum.GetName(typeof(TipMotor),this.motor.TipMotor)}");

            return sb.ToString();
        }
    }
}
