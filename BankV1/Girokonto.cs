using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankV1
{
    internal class Girokonto : Konto
    {
        private double dispo;

        public double Dispo 
        {  get { return dispo; } set { Dispo = value; } }

        public Girokonto() 
        { 
        }
        public Girokonto(string inhaber) : this()
        {
            this.Inhaber = inhaber;
        }
        public Girokonto(string inhaber,double betrag) : this(inhaber)
        {
            saldo = betrag;
        }

        public double Auszahlen(double betrag)
        {
            return 0;
        }
        public void Ueberweisung(Konto empfaenger,double betrag) 
        {

        }

        public override string ToString()
        {
            return "Giro"+ base.ToString();
        }
    }
}
