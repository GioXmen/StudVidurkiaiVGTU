﻿using System.Collections.Generic;

namespace StudVidurkiaiVGTU
{
    internal class StudentasSimple
    {
        public List<double> NamuDarbai = new List<double>();

        public string Vardas { get; set; }

        public string Pavarde { get; set; }

        public double Egzaminas { get; set; }

        public double Mediana { get; set; }

        public double Vidurkis { get; set; }

        public StudentasSimple()
        {
        }
    }
}