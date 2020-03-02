﻿using System;
using System.Collections.Generic;

namespace StudVidurkiaiVGTU
{
    internal class Studentas
    {
        public List<double> NamuDarbai = new List<double>();
        private double      Mediana;
        private string      Vidurkis;

        public string Vardas { get; set; }

        public string Pavarde { get; set; }

        public double Egzaminas { get; set; }


        public string GetVidurkis()
        {
            double suma = 0;
            int size = 0;
            foreach (var pazymys in NamuDarbai)
            {
                suma += (int)pazymys;
                size += 1;
            }
            double namuVid = suma / size;
            double galutinis = 0.3 * namuVid + 0.7 * Egzaminas;
            SetVidurkis(galutinis.ToString("F2"));
            return Vidurkis;      
        }

        public void SetVidurkis(string value)
        {
            Vidurkis = value;
        }

        public string GetMediana()
        {
            double rezultatas = SkaiciuotiMediana(NamuDarbai.ToArray());
            double galutinis = 0.3 * rezultatas + 0.7 * Egzaminas;
            SetMediana(galutinis);
            return Mediana.ToString("F2");
        }

        public void SetMediana(double value)
        {
            Mediana = value;
        }

        private static double SkaiciuotiMediana(double[] skaičiai)
        {
            if (skaičiai == null || skaičiai.Length == 0)
                throw new Exception("Reikalinga bent viena reikšmė medianai skaičiuoti");

            //Rušiuoti sąraša ir naudoti naują masyvą
            double[] rušiuotiSkaičiai = (double[])skaičiai.Clone();
            Array.Sort(rušiuotiSkaičiai);

            //Gauti mediana
            int dydis = rušiuotiSkaičiai.Length;
            double mediana = (dydis % 2 != 0) ? rušiuotiSkaičiai[dydis / 2] : (rušiuotiSkaičiai[dydis / 2] + rušiuotiSkaičiai[dydis / 2 - 1]) / 2;
            return mediana;
        }

        override public string ToString()
        {
            return "Vardas: " + Vardas + "\n" + "Pavarde: " + Pavarde + "\n" + "NamuDarbai:" + string.Join("\t", NamuDarbai)
                + "\n"  + "Egzaminas: " + Egzaminas + "\n";
        }
    }
}