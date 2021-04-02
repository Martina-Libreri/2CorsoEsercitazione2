using Esercitazione_2.Movimenti;
using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione_2
{
    public static class GestioneMovimenti<T> where T : Movement
    {
        public static void Gestione(T movimento, Account account)
        {
            Console.WriteLine("1 - Esegui un Prelievo");
            Console.WriteLine("2 - Esegui un Deposito");

            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (c)
            {
                case '1':
                    movimento.DataMovimento = DateTime.Now;
                    Console.WriteLine("Inserisci l'importo da prelevare");
                    ControlloImporto(movimento);
                    account = account - movimento;
                    break;
                case '2':
                    movimento.DataMovimento = DateTime.Now;
                    Console.WriteLine("Inserisci l'importo da depositare");
                    ControlloImporto(movimento);
                    account = account + movimento;
                    break;
                default:
                    break;
            }

        }
        //Metodo di controllo importo
        public static void ControlloImporto(Movement movimento)
        {
            {
                int x = 0;
                do
                {
                    try
                    {
                        x = 1;
                        string s = Console.ReadLine();
                        movimento.Importo = Convert.ToDouble(s);

                    }
                    catch
                    {
                        Console.WriteLine("Numero non valido, riprova");
                        x = 0;
                    }
                } while (x == 0);

            }
        }
    }
}
