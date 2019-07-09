﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpleidingKlasses
{
    public class Docent
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Bedrijf { get; set; }

        public Docent()
        {
        }

        public Docent(string naam, string bedrijf)
        {
            Naam = naam;
            Bedrijf = bedrijf;
        }
    }
}