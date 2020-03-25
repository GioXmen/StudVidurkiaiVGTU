using System;
using System.Linq;

namespace StudVidurkiaiVGTU
{
    static class StudentData
    {
        private static readonly Random random = new Random();

        public static void ReadInputFromConsole()
        {
            Console.WriteLine("Įveskite studento duomenis šitu formatu:    ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Vardas Pavardė ND1 ND2 ND3 ND4 ND5 Egzaminas");
            Console.WriteLine("--------------------------------------------");

            string duomenys = Console.ReadLine();
            ParseStudent(duomenys);

            Console.WriteLine("Ar norite dar viena studenta prideti? [Y/N]:  ");

            String answer = Console.ReadLine();
            if (answer.Equals("Y") || answer.Equals("y"))
            {
                ReadInputFromConsole();
            }
        }

        private static void ParseStudent(String duomenys)
        {
            Studentas studentas = new Studentas();
            String[] splitData;

            splitData = duomenys.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            studentas.Vardas = splitData[0];
            studentas.Pavarde = splitData[1];
            for (int i = 2; i < 7; i++)
            {

             studentas.NamuDarbai.Add(double.Parse(splitData[i]));

            }
            studentas.Egzaminas = double.Parse(splitData[7]);
            Program.studentai.Add(studentas);
        }

        public static void ReadInputFromFile()
        {
            string line;
            int counter = 0;
            string filePath = System.IO.Path.GetFullPath("studentai.txt");
            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            {
                if (counter > 0)
                {
                    ParseStudent(line);
                }
                counter++;
            }
            file.Close();
            System.Console.WriteLine("Buvo prideta {0} studentų.", counter-1);
        }

        public static void ReadRandomInput()
        {
            Studentas studentas = new Studentas();
            Random rnd = new Random();

            studentas.Vardas  = GeneruotiVarda(9);
            studentas.Pavarde = GeneruotiVarda(12);
            for (int i = 0; i < 6; i++)
            {
                studentas.NamuDarbai.Add(rnd.Next(0, 10));
            }
            studentas.Egzaminas = rnd.Next(0, 10);
            Program.studentai.Add(studentas);

            Console.WriteLine(studentas.ToString());
            Console.WriteLine("Ar norite dar viena studenta sugeneruoti? [Y/N]:  ");

            String answer = Console.ReadLine();
            if (answer.Equals("Y") || answer.Equals("y"))
            {
                ReadRandomInput();
            }
        }
        private static string GeneruotiVarda(int ilgis)
        {
            const string abc = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(abc, ilgis)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}