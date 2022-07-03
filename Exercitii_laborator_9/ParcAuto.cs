using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitii_laborator_9
{
    /// <summary>
    /// Modeleaza un parc auto
    /// </summary>
    class ParcAuto
    {
        public List<Autovehicul> auto = new List<Autovehicul>();


        /// <summary>
        /// Creeaza o lista de autovehicule
        /// </summary>
        /// <param name="autovehicul">Accepta ca parametru un autovehicul</param>
        public void AdaugaAuto(Autovehicul autovehicul)
        {
            auto.Add(autovehicul);
        }


        /// <summary>
        /// Porneste autovehiculele
        /// </summary>
        public void PornesteAuto()
        {
            foreach (Autovehicul autovehicul in auto)
            {
                autovehicul.Porneste();
            }
        }


        /// <summary>
        /// Afiseaza datele autovehiculelor
        /// </summary>
        public void TiparesteAuto()
        {
            foreach (Autovehicul autovehicul in auto)
            {
                Console.WriteLine(autovehicul.ToString());
            }
        }
    }
}
