using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione_2.Movimenti
{
    public class TransfertMovement : Movement
    {
        //Proprietà
        public string BancaOrigine { get; set; }
        public string BancaDestinazione { get; set; }
        public double Importo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DataMovimento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //Costruttore
        public TransfertMovement() { }
        public TransfertMovement(string bancaO, string bancaD)
        {
            BancaOrigine = bancaO;
            BancaDestinazione = bancaD;
        }

        //Metodo
        public override string ToString()
        {
            return base.ToString() + $" dalla banca {BancaOrigine} a {BancaDestinazione}";
        }
    }
}
