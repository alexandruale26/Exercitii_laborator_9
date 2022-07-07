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
        private List<Autovehicul> auto = new List<Autovehicul>();

        /// <summary>
        /// Creeaza o lista de autovehicule
        /// </summary>
        /// <param name="autovehicul">Accepta ca parametru un autovehicul</param>
        public void AdaugaAuto(Autovehicul autovehicul)
        {
            auto.Add(autovehicul);
        }


        /// <summary>
        /// Incarca autoutilitarele. Parcurge lista de autovehicule
        /// </summary>
        public void IncarcaAutoutilitarele()
        {
            foreach (Autovehicul autovehicul in auto)
            {
                if (autovehicul is Cisterna)
                {
                    Console.WriteLine($"Incarca Cisterna -> {autovehicul}");
                    Cisterna cisterna = (Cisterna)autovehicul;
                    cisterna.IncarcaMarfa(IntroduCantitate());
                    Console.WriteLine();
                }
                else if (autovehicul is Camion)
                {
                    Console.WriteLine($"Incarca Camion -> {autovehicul}");
                    Camion camion = (Camion)autovehicul;
                    camion.IncarcaMarfa(IntroduCantitate());
                    Console.WriteLine();
                }
            }
        }


        /// <summary>
        /// Pentru introdus o cantitate de tip intreg de la tastatura
        /// </summary>
        /// <returns>Returneaza cantitatea introdusa</returns>
        private int IntroduCantitate()
        {
            return int.Parse(Console.ReadLine());
        }


        /// <summary>
        /// Porneste autovehiculele
        /// </summary>
        public void PornesteAuto()
        {
            foreach (Autovehicul autovehicul in auto)
            {
                autovehicul.Porneste();
                Console.WriteLine();
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
            Console.WriteLine();
        }
    }
}
