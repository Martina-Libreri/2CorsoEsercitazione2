using Esercitazione_2.Movimenti;
using System;
using System.Collections.Generic;

namespace Esercitazione_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            Console.WriteLine("Benvenuto sul Menu");

            //Creazione Account
            Account account = new Account();
            Console.WriteLine("Inserisci il nome della banca");
            account.NomeBanca = Console.ReadLine();
            Console.WriteLine("Inserisci il numero del conto");
            do
            {
                try
                {
                    x = 1;
                    int numeroConto = Convert.ToInt32(Console.ReadLine());
                    account.NumeroConto = numeroConto.ToString();
                }
                catch
                {
                    Console.WriteLine("Numero non valido, riprova");
                    x = 0;
                }
            } while (x == 0);

            Console.WriteLine(account);
            x = 0;

            do
            {
                Console.WriteLine("Movimenti Bancari");

                Console.WriteLine("Inserisci il tipo di movimento che vuoi eseguire:");
                Console.WriteLine("1 - Cash Movement");
                Console.WriteLine("2 - Credit Card Movement");
                Console.WriteLine("3 - Transfert Movement");
                Console.WriteLine("4 - Stampare la lista dei movimenti");
                Console.WriteLine("Premi un tasto per uscire");

                char c = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (c)
                {
                    case '1':
                        CashMovement movimento = new CashMovement();
                        Console.WriteLine("Inserisci l'esecutore del movimento");
                        movimento.Esecutore = Console.ReadLine();
                        GestioneMovimenti<CashMovement>.Gestione(movimento, account);
                        Console.WriteLine(movimento);
                        break;
                    case '2':
                        CreditCardMovement creditCardMovement = new CreditCardMovement();
                        
                        creditCardMovement.NumeroCarta = creditCardMovement.ControlloNumeroCarta();
                        Console.WriteLine($"Inserisci il tipo della carta: {Tipo.Amex}, {Tipo.Mastercard}, {Tipo.Visa}, {Tipo.Other}");
                        creditCardMovement.Tipo = creditCardMovement.ControlloCarta(Console.ReadLine());
                        GestioneMovimenti<CreditCardMovement>.Gestione(creditCardMovement, account);
                        Console.WriteLine(creditCardMovement);
                        break;
                    case '3':
                        TransfertMovement trasferimento = new TransfertMovement();
                        Console.WriteLine("Inserisci la banca di destinazione");
                        trasferimento.BancaDestinazione = Console.ReadLine();
                        trasferimento.BancaOrigine = account.NomeBanca;
                        GestioneMovimenti<TransfertMovement>.Gestione(trasferimento, account);
                        Console.WriteLine(trasferimento);
                        break;
                    case '4':
                        account.Statement();
                        break;
                    default:
                        x = 1;
                        Console.WriteLine();
                        break;
                }
            } while (x == 0);

            Console.WriteLine("Operazioni Terminate");
        }
    }
}
