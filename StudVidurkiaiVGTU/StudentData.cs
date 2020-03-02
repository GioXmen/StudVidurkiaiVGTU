using System;
using System.Linq;

namespace StudVidurkiaiVGTU
{
    class StudentData
    {
        private static readonly Random random = new Random();

        public static void ReadInputFromConsole()
        {
            Studentas studentas = new Studentas();

            Console.WriteLine("Įveskite studento duomenis:  ");
            string duomenys = Console.ReadLine();
            var splitData   = duomenys.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            studentas.Vardas  = splitData[0];
            studentas.Pavarde = splitData[1];
            for (int i = 2; i < splitData.Length - 1; i++)
            {
                studentas.NamuDarbai.Add(double.Parse(splitData[i]));
            }
            studentas.Egzaminas = double.Parse(splitData[splitData.Length - 1]);
            Program.studentai.Add(studentas);

            Console.WriteLine("Ar norite dar viena studenta prideti? [Y/N]:  ");

            String answer = Console.ReadLine();
            if (answer.Equals("Y") || answer.Equals("y"))
            {
                ReadInputFromConsole();
            }
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
                    Studentas studentas = new Studentas();

                    string duomenys = line;
                    var splitData = duomenys.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    studentas.Vardas = splitData[0];
                    studentas.Pavarde = splitData[1];
                    for (int i = 2; i < splitData.Length - 1; i++)
                    {
                        studentas.NamuDarbai.Add(double.Parse(splitData[i]));
                    }
                    studentas.Egzaminas = double.Parse(splitData[splitData.Length - 1]);
                    Program.studentai.Add(studentas);
                }
                counter++;
            }
            file.Close();
            System.Console.WriteLine("There were {0} students.", counter-1);
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