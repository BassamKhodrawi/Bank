using System;
using System.Windows.Forms;

namespace BankV1
{
    class Konto
    {
        // Attribute für das Bankkonto
        protected int kontoNr;
        protected static int nextKontoNr = 101;
        protected string inhaber;
        protected double saldo;

        // Eigenschaften
        public int KontoNr
        {
            get { return kontoNr; }
        }
        public string Inhaber
        {
            get { return inhaber; }
            set { inhaber = value; }
        }
        public double Saldo
        {
            get { return saldo; }
        }
        public static int NextKontoNr
        {
            get { return nextKontoNr; }
        }

        // Konstruktoren
        public Konto()
        {
            // Initialisiert die Kontonummer und setzt den Inhaber auf einen leeren String und das Saldo auf 0
            kontoNr = nextKontoNr++;
            Inhaber = "";
            saldo = 0;
        }

        // Konstruktor mit einem Parameter für den Kontoinhaber
        public Konto(string inhaber) : this()
        {
            Inhaber = inhaber;
        }

        // Konstruktor mit zwei Parametern für den Kontoinhaber und den Anfangsbetrag
        public Konto(string inhaber, double betrag) : this(inhaber)
        {
            saldo = betrag;
        }

        // Methoden für Einzahlen und Auszahlen von Geld
        public double Einzahlen(double betrag)
        {
            // Erhöht das Saldo um den übergebenen Betrag
            saldo += betrag;
            return saldo;
        }
        // Methoden für Einzahlen und Auszahlen von Geld
        public double Auszahlen(double betrag)
        {
            try
            {
                saldo -= betrag;

                if (saldo < 0)
                {
                    // Wenn das Saldo negativ wird, kommt ein Fehler
                    throw new Exception("Kontostand darf nicht negativ sein!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // Betrag wieder zum Saldo hinzufügen, um den vorherigen Zustand wiederherzustellen
                saldo += betrag;
            }
            return saldo;
        }


        // Überschriebene ToString-Methode
        public override string ToString()
        {
            // Gibt die Kontonummer und den Kontoinhaber als Zeichenkette zurück
            if (inhaber == "")
                return "KontoNr: " + kontoNr;
            else
                return "KontoNr: " + kontoNr + ", " + inhaber;
        }
    }
}
