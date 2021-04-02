using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione_2.Movimenti
{
    public abstract class Movement
    {
        //Proprietà
        public double Importo { get; set; }
        public DateTime DataMovimento { get; set; }

        //Costruttore
        public Movement() { }
        public Movement(double importo)
        {
            DataMovimento = DateTime.Now;
            Importo = importo;
        }
        //Metodo
        public override string ToString()
        {
            return $"Importo movimento: {Importo} in data {DataMovimento}";
        }

       
    }
   
}
