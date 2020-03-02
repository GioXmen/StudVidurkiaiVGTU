using System;

namespace StudVidurkiaiVGTU
{
    internal class StudentasArray
    {
        public double[,]  NamuDarbai = new double[100, 100];
        public double[]   Mediana    = new double[100];
        public string[]   Vidurkis   = new string[100];
        public string[]   vardas     = new string[100];
        public string[]   pavarde    = new string[100];
        public double[]   egzaminas  = new double[100];
        public int        dydis      = 0;

        public int GetArraySize()
        {
         return dydis;
        }

        public void SkaiciuotiVidurki(int studentas)
        {
            double suma = 0;
            int    size = 0;
            for (int i = 0; i < 6; i++)
            {
                suma += NamuDarbai[studentas,i];
                size += 1;
            }
            
            double namuVid      = suma / size;
            double galutinis    = 0.3 * namuVid + 0.7 * egzaminas[studentas];
            Vidurkis[studentas] = galutinis.ToString("F2");
        }
        public void SkaiciuotiMediana(int studentas)
        {
            double[] TempNamuDarbai = new double[6];
            for (int i = 0; i < 6; i++)
            {
                TempNamuDarbai[i] = NamuDarbai[studentas, i];
            }
            double rezultatas  = SkaiciuotiMediana(TempNamuDarbai);
            double galutinis   = 0.3 * rezultatas + 0.7 * egzaminas[studentas];
            Mediana[studentas] = galutinis;
        }

        private static double SkaiciuotiMediana(double[] skaičiai)
        {
            if (skaičiai == null || skaičiai.Length == 0)
                throw new Exception("Reikalinga bent viena reikšmė medianai skaičiuoti");

            //Rušiuoti sąraša ir naudoti naują masyvą
            double[] rušiuotiSkaičiai = (double[])skaičiai.Clone();
            Array.Sort(rušiuotiSkaičiai);

            //Gauti mediana
            int dydis      = rušiuotiSkaičiai.Length;
            double mediana = (dydis % 2 != 0) ? rušiuotiSkaičiai[dydis / 2] : (rušiuotiSkaičiai[dydis / 2] + rušiuotiSkaičiai[dydis / 2 - 1]) / 2;
            return mediana;
        }
    }
}