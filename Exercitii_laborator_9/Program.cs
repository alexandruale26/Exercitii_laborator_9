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


            Autoturism auto1 = new Autoturism("Mazda", "Mx5", new Motor(TipMotor.Hibrid), 4);
            Autoturism auto2 = new Autoturism("Dacia", "Spring", new Motor(TipMotor.Electric), 4);


            Autoutilitara cisterna1 = new Autoutilitara("MAN", "M1500", new Motor(TipMotor.Diesel), TipProdus.Combustibil);
            cisterna1.IncarcaMarfa(3_000);
            cisterna1.IncarcaMarfa(2_500);
            cisterna1.IncarcaMarfa(5_000);
            cisterna1.IncarcaMarfa(1_700);
            Console.WriteLine();

            Autoutilitara camion1 = new Autoutilitara("Scania", "S200", new Motor(TipMotor.Diesel), TipProdus.Materiale_Constructii);
            camion1.IncarcaMarfa(13);
            camion1.IncarcaMarfa(15);
            camion1.IncarcaMarfa(20);
            camion1.IncarcaMarfa(9);
            Console.WriteLine();

            Autoutilitara transportorAuto1 = new Autoutilitara("Mercedes", "M950", new Motor(TipMotor.Diesel), TipProdus.Autoturisme);
            transportorAuto1.IncarcaMarfa(5);
            transportorAuto1.IncarcaMarfa(4);
            transportorAuto1.IncarcaMarfa(2);
            Console.WriteLine();


            parcAuto.AdaugaAuto(auto1);
            parcAuto.AdaugaAuto(auto2);
            parcAuto.AdaugaAuto(cisterna1);
            parcAuto.AdaugaAuto(camion1);
            parcAuto.AdaugaAuto(transportorAuto1);


            parcAuto.PornesteAuto();
            Console.WriteLine();


            parcAuto.TiparesteAuto();
        }
    }
}
