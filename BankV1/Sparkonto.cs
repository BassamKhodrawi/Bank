using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankV1
{
    internal class Sparkonto : Konto
    {
        private double zins;

        public double Zins
        { get { return zins; } set { Zins = value; } }

        public Sparkonto()
        {
        }
        public Sparkonto(string inhaber) : this()
        {
            this.Inhaber = inhaber;
        }
        public Sparkonto(string inhaber, double betrag) : this(inhaber)
        {
            saldo = betrag;
        }

        public double Auszahlen(double betrag)
        {
            return 0;
        }

        public double ZinsenBerechenen()
        {
            return 0;
        }

        public override string ToString()
        {
            return "Spar" + base.ToString();
        }
    }
}
