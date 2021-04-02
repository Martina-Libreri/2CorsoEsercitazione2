using Esercitazione_2.Movimenti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Esercitazione_2
{
    public class Account
    {

        public List<Movement> ListaMovimenti = new List<Movement>();

        //Proprietà
        public string NumeroConto { get; set; }
        public string NomeBanca { get; set; }
        public double Saldo { get; set; }
        public DateTime DataUltimaOperazione { get; set; }

        //Costruttore
        public Account() : this("", "", 100, new DateTime()) { }
        public Account(string numero, string banca, double saldo, DateTime dataoperazione)
        {
            NumeroConto = numero;
            NomeBanca = banca;
            Saldo = saldo;
            DataUltimaOperazione = dataoperazione;
        }

        //Metodo
        public void Statement()
        {
            Console.WriteLine("Ecco i tuoi dati del conto: ");
            Console.WriteLine(this.ToString());
            Console.WriteLine("Elenco dei tuoi movimenti:");
            if (ListaMovimenti.Count() == 0)
            {
                Console.WriteLine("Non hai ancora effettuato movimenti");
            }
            else
            {
                foreach (Movement item in this.ListaMovimenti)
                {
                    Console.WriteLine(item);
                }
                
            }
        }

        //Metodi di overloading
        public static Account operator +(Account account, Movement movement)
        {
            account.ListaMovimenti.Add(movement);
            account.Saldo += movement.Importo;
            account.DataUltimaOperazione = movement.DataMovimento;

            Console.WriteLine(account);

            return account;
        }

        public static Account operator -(Account account, Movement movement)
        {

            if (movement.Importo > account.Saldo)
            {
                Console.WriteLine("Trasferimento negato - importo superiore al Saldo");
                return account;
            }
            account.ListaMovimenti.Add(movement);
            account.Saldo -= movement.Importo;
            account.DataUltimaOperazione = movement.DataMovimento;

            Console.WriteLine(account);

            return account;
        }

        public override string ToString()
        {
            return $"Numero conto: {NumeroConto} - Nome Banca: {NomeBanca} - Saldo: {Saldo}";
        }
    }
}
