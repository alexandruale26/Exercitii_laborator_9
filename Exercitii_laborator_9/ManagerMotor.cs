using System;

namespace Exercitii_laborator_9
{
    /// <summary>
    /// Modeleaza un manager de motor
    /// </summary>
    class ManagerMotor
    {
        //NivelUlei, NivelLichidDeFrana, ControlTermostat, etc


        /// <summary>
        /// Genereaza sunet de motor
        /// </summary>
        /// <param name="tipMotor">Accepta ca parametru un tip de motor</param>
        /// <returns>Returneaza sunetul obtinut</returns>
        public string GenerareSunet(TipMotor tipMotor)
        {
            return tipMotor switch
            {
                TipMotor.Electric => "Whhhheeeeeeeeeeeeeeeeeeeeeee",
                TipMotor.Hibrid => "Vooooooooooooooooooooooooooo",
                TipMotor.Diesel => "Vroooomm vrooooooooooooommmm",
                _ => throw new NotImplementedException(),
            };
        }
    }
}
