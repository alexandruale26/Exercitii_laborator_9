
namespace Exercitii_laborator_9
{
    /// <summary>
    /// Modeleaza un manager de autoutilitara
    /// </summary>
    class ManagerAutoutilitara
    {
        /// <summary>
        /// Stabileste incarcatura maxima si unitatea de masura 
        /// </summary>
        /// <param name="produs">Accepta ca parametru un tip de produs</param>
        /// <param name="unitateDeMasura">Accepta ca parametru un string</param>
        /// <returns>Returneaza incarcatura maxima</returns>
        public int StabilesteIncarcatura(TipProdus produs, ref string unitateDeMasura)
        {
            switch (produs)
            {
                case TipProdus.Combustibil:
                    unitateDeMasura = "m3";
                    return 10_000;
                case TipProdus.Materiale_Constructii:
                    unitateDeMasura = "tone";
                    return 40;
                case TipProdus.Autoturisme:
                    unitateDeMasura = "autoturisme";
                    return 10;
                default:
                    return 0;
            };
        }
    }
}
