using System;

namespace Exercitii_laborator_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Scrieti un program care va modela un parc auto.

              Autovehiculele vor avea
                • Producator si model
                • motor electric, hibrid sau cu diesel
                • o metoda Porneste la apelul careia autovehiculul va porni motorul.

              Motoarele
                • La pornirea acestora vor emite un zgomot caracteristic, afisandu-l ca mesaj in consola

              Parcul auto va contine autovehicule care vor putea fi autoturisme sau autoutilitare.

              Autoturismele
                • vor avea un numar de locuri
                • vor avea motoare electrice sau hibride
                • la pornirea autoturismelor, dupa pornirea motorului, acestea vor inchide usile afisand acest lucru pe ecran.

              Autoutilitarele
                • vor avea doar motoare diesel
                • vor putea transporta combustibil si materiale de constructie
                • vor avea capacitati maxime prestabilite
                    o 10000 mc pentru combustibil pentru cisterne
                    o 40t pentru camioane
                • vor avea o metoda de incarcaMarfa care va incarca o cantitate primita ca parametru asigurand incarcarea sub capacitatea maxima


              Toate autovehiculele vor avea o metoda care va produce un sir de caractere ce va descrie in detaliu fiecare autovehicul 
              in parte (producator, model, continut, etc...).


              Apelati-o in Main, si afisati-i rezultatul pe ecran.

              „Porniti” autovehiculele in metoda main.
            */


            ParcAuto parcAuto = new ParcAuto();

            AutoturismHibrid hibrid1 = new AutoturismHibrid("Mazda", "CX-5", 4);
            AutoturismElectric electric1 = new AutoturismElectric("Dacia", "Spring", 2);
            Cisterna cisterna1 = new Cisterna("MAN", "M1000");
            Camion camion1 = new Camion("Volvo", "V200");
            Cisterna cisterna2 = new Cisterna("Scania", "S98");


            parcAuto.AdaugaAuto(hibrid1);
            parcAuto.AdaugaAuto(electric1);
            parcAuto.AdaugaAuto(cisterna1);
            parcAuto.AdaugaAuto(camion1);
            parcAuto.AdaugaAuto(cisterna2);


            parcAuto.IncarcaAutoutilitarele();


            parcAuto.PornesteAuto();
            parcAuto.TiparesteAuto();
        }
    }
}
