using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione_2.Movimenti
{
    public class CashMovement : Movement 
    {
        //Proprietà
        public string Esecutore { get; set; }

        //Costruttore
        public CashMovement() { }
        public CashMovement(string esecutore)
        {
            Esecutore = esecutore;
        }
      
        //Metodo
        public override string ToString()
        {
            return base.ToString() + $" da parte di {Esecutore}";
        }

    }
}
