using System;
using System.Text;

namespace Exercitii_laborator_9
{
    /// <summary>
    /// Modeleaza o autoutilitara
    /// </summary>
    class Autoutilitara : Autovehicul
    {
        private readonly int cantitateMaxima = 0;
        private int cantitateCurenta = 0;
        private readonly string unitateDeMasura = string.Empty;

        private readonly TipProdus produs;
        private readonly ManagerAutoutilitara managerAutoutilitara = new ManagerAutoutilitara();


        /// <summary>
        /// Creeaza o autoutilitara
        /// </summary>
        /// <param name="producator">Accepta ca parametru un string</param>
        /// <param name="model">Accepta ca parametru un string</param>
        /// <param name="motor">Accepta ca parametru un motor</param>
        /// <param name="produs">Accepta ca parametru un tip de produs</param>
        public Autoutilitara(string producator, string model, Motor motor, TipProdus produs) : base(producator, model, motor)
        {
            this.produs = produs;
            this.cantitateMaxima = managerAutoutilitara.StabilesteIncarcatura(this.produs, ref unitateDeMasura);
        }


        /// <summary>
        /// Incarca autoutilitara cu marfa
        /// </summary>
        /// <param name="deIncarcat">Accepta ca parametru un int</param>
        public void IncarcaMarfa(int deIncarcat)
        {
            if (this.cantitateCurenta + deIncarcat <= this.cantitateMaxima)
            {
                this.cantitateCurenta += deIncarcat;
                Console.WriteLine($"{this.cantitateCurenta} {unitateDeMasura} din {this.cantitateMaxima} {unitateDeMasura}");
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
            sb.Append($"  |  Continut {Enum.GetName(typeof(TipProdus), this.produs)}  |  Cantitate {this.cantitateCurenta} {unitateDeMasura}");

            return sb.ToString();
        }
    }
}
