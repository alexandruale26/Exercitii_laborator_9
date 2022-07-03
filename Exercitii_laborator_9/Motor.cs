using System;

namespace Exercitii_laborator_9
{
    /// <summary>
    /// Modeleaza un motor
    /// </summary>
    class Motor
    {
        public TipMotor TipMotor { get; private set; }
        private readonly ManagerMotor functiiMotor = new ManagerMotor();


        /// <summary>
        /// Creeaza un motor
        /// </summary>
        /// <param name="tipMotor">Accepta ca parametru un tip de motor</param>
        public Motor(TipMotor tipMotor)
        {
            this.TipMotor = tipMotor;
        }


        /// <summary>
        /// Se porneste motorul
        /// </summary>
        /// <returns>Returneaza sunetul motorului</returns>
        public string SePornesteMotor()
        {
            return functiiMotor.GenerareSunet(TipMotor);
        }
    }
}
