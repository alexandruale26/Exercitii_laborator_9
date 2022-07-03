using System;
using System.Text;

namespace Exercitii_laborator_9
{
    /// <summary>
    /// Modeleaza un autoturism
    /// </summary>
    class Autoturism : Autovehicul
    {
        private readonly int numarDeLocuri = 0;


        /// <summary>
        /// Creeaza un autoturism
        /// </summary>
        /// <param name="producator">Accepta ca parametru un string</param>
        /// <param name="model">Accepta ca parametru un string</param>
        /// <param name="motor">Accepta ca parametru un motor</param>
        /// <param name="numarDeLocuri">Accepta ca parametru un int</param>
        public Autoturism(string producator, string model, Motor motor, int numarDeLocuri) : base(producator, model, motor)
        {
            this.numarDeLocuri = numarDeLocuri;
        }


        /// <summary>
        /// Inchide usile autoturismului
        /// </summary>
        /// <returns>Returneaza un mesaj</returns>
        private string InchideUsi()
        {
            return "Am inchis usile";
        }


        /// <summary>
        /// Porneste autoturismul
        /// </summary>
        public override void Porneste()
        {
            base.Porneste();
            Console.WriteLine(InchideUsi());
        }


        /// <summary>
        /// Returneaza date despre obiectul curent
        /// </summary>
        /// <returns>Returneaza un string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.Append($"  |  Numar de locuri {this.numarDeLocuri}");

            return sb.ToString();
        }
    }
}
