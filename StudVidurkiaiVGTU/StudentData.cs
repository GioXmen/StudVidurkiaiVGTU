using System;
using System.Linq;

namespace StudVidurkiaiVGTU
{
    static class StudentData
    {
        private static readonly Random random = new Random();
        private static String formatExceptionMessage = "Duomenys įvesti neteisingu formatu arba panaudoti simboliai vietoj raidžių. Neteisingai įvestos reikšmės paversti Į nulius";
        private static String fileNotFoundExceptionMessage = "Ivesties failas nerastas";
        private static double defaultValue = 0.00;

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
            try
            {
                splitData = duomenys.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if(splitData.Length < 2) { throw new FormatException("Not enough array elements"); }
            }
            catch (FormatException ex)
            {
                //Console.WriteLine("Netinkamai įvesti studentų duomenys!");
                return;
            }

            studentas.Vardas = splitData[0];
            studentas.Pavarde = splitData[1];
            for (int i = 2; i < 7; i++)
            {
                try
                {
                    studentas.NamuDarbai.Add(double.Parse(splitData[i]));
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(formatExceptionMessage + "\n" + ex); //Atkomentuoti norint pamatyti exception message
                    studentas.NamuDarbai.Add(defaultValue);
                }
            }

            try
            {
                studentas.Egzaminas = double.Parse(splitData[7]);
            }
            catch (Exception ex)
            {
                //Console.WriteLine(formatExceptionMessage + "\n" + ex);
                studentas.Egzaminas = defaultValue;
            }

            Program.studentai.Add(studentas);
        }

        public static void ReadInputFromFile()
        {
            string line;
            int counter = 0;
            System.IO.StreamReader file = null;
            try {
                string filePath = System.IO.Path.GetFullPath("studentai.txt");
                file = new System.IO.StreamReader(filePath);
            } catch (System.IO.IOException ex)
            {
                Console.WriteLine(fileNotFoundExceptionMessage + "\n---------------------------------------------------\n" + ex);
                Console.WriteLine("Buvo prideta {0} studentų. Įvesties failas nerastas", 0);
                Console.WriteLine("---------------------------------------------------");
                return;

            }
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

        public static void ReadRandomInput(int studentuKiekis)
        {
            int index = 1;
            while(index < studentuKiekis){ 
            Studentas studentas = new Studentas();
            Random rnd = new Random();

            studentas.Vardas  = "Vardas" + index;
            studentas.Pavarde = "Pavarde" + index;
            for (int i = 0; i < 6; i++)
            {
                studentas.NamuDarbai.Add(rnd.Next(0, 10));
            }
            studentas.Egzaminas = rnd.Next(0, 10);
            Program.studentai.Add(studentas);

                index += 1;
            }
        }

    }
}