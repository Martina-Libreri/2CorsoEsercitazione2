using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione_2.Movimenti
{
    class CreditCardMovement : Movement 
    {
        //Proprietà
        public Tipo Tipo { get; set; }
        public string NumeroCarta { get; set; }


        //Costruttore
        public CreditCardMovement() { }
        public CreditCardMovement(Tipo tipo, string numeroCarta)
        {
            Tipo = tipo;
            NumeroCarta = numeroCarta;
        }

        //Metodi
        public override string ToString()
        {
            return base.ToString() + $" con numero carta: {NumeroCarta} di tipo: {Tipo} ";
        }

        //Controllo sul tipo di carta
        public Tipo ControlloCarta(string t)
        {
            if (t.ToLower().Equals("amex"))
            {
                return Tipo.Amex;
            }
            else if (t.ToLower().Equals("mastercard"))
            {
                return Tipo.Mastercard;
            }
            else if (t.ToLower().Equals("visa"))
            {
                return Tipo.Visa;
            }
            else
            {
                return Tipo.Other;
            }
        }

        //Controllo sul numero carta
        public string ControlloNumeroCarta()
        {
            int x = 0;
            string carta = ""; 
            do
            {
                x = 1;
                try
                {
                    Console.WriteLine("Inserisci il numero della carta");
                    string s = Console.ReadLine();
                    int numeroCarta = Convert.ToInt32(s);
                    carta = numeroCarta.ToString();
                }
                catch
                {
                    Console.WriteLine("Numero non valido, riprova");
                    x = 0;
                }
            } while (x == 0);

            return carta;
        }
    }

    public enum Tipo
    {
        Amex,
        Visa,
        Mastercard,
        Other
    }
}
