// Fig. 8.9: Carta

using PrimerCaso;
using System;

public class PruebaPaqueteDeCartas
{
  public  static void Main (string[] args)
    {
PaqueteDeCarta miPaqueteDeCarta = new PaqueteDeCarta();
        miPaqueteDeCarta.Barajar();

        for (int i = 0; i < 13; i++) {

            Console.WriteLine( "{0, -20}  {1, -20}{2, -20} {3, -20}", miPaqueteDeCarta.RepartirCarta(), miPaqueteDeCarta.RepartirCarta(), 
                miPaqueteDeCarta.RepartirCarta(), miPaqueteDeCarta.RepartirCarta());

        }


    }

}