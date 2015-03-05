﻿using Datatemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonendarstellungWPF
{
    // Auswählbare Telefontypen
    public enum TelefonTyp { Festnetz, Mobiltelefon, VOIP };

    public class Telefon: Rootable
    {
        // TelefonNummer -> primary Key
        //Properties
        public String TelefonNummer { get; set; }
        public TelefonTyp TelefonTyp { get; set; }
        // Liste der Personen, die unter diese Nummer erreichbar sind
        //Relationen
        //public List<Person> Personen { get; set; }
        public Relation Personen { get; set; }
        
        public Telefon()
        {
            // Default TelefonTyp
            TelefonTyp = TelefonTyp.Mobiltelefon;

            // Liste erstellen
            //Personen = new List<Person>();
            Personen = new Relation();
        }

        public override string ToString()
        {
            return TelefonNummer;
        }
    }
}
