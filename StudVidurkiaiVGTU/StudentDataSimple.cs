using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace StudVidurkiaiVGTU
{
    static class StudentDataSimple
    {
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

        public static void ReadInputFromFile(int kiekis, String tipas, Boolean sort)
        {
            string line;
            int counter = 0;
            System.IO.StreamReader file = null;
            try
            {
                string filePath = System.IO.Path.GetFullPath("./studentai" + kiekis + ".txt");
                file = new System.IO.StreamReader(filePath);
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine(fileNotFoundExceptionMessage + "\n---------------------------------------------------\n" + ex);
                Console.WriteLine("Buvo prideta {0} studentų. Įvesties failas nerastas", 0);
                Console.WriteLine("---------------------------------------------------");
                return;

            }
            StudentasSimple studentas = null;
            Stopwatch stopwatchRead = new Stopwatch();
            stopwatchRead.Start();
            while ((line = file.ReadLine()) != null)
            {
                if (counter > 0)
                {
                    studentas = ParseStudent(line);

                    if (studentas == null) { continue; }


                    if (tipas.Equals("List"))
                    {
                        Program.studentaiL.Add(studentas);
                        if (sort)
                        {
                            if (studentas.Vidurkis >= 5)
                            {
                                Program.kietiakiaiL.Add(studentas);
                            }
                            else
                            {
                                Program.vargsiukaiL.Add(studentas);
                            }
                        }
                    }
                    if (tipas.Equals("LinkedList"))
                    {
                        Program.studentaiLL.AddLast(studentas);
                        if (sort)
                        {
                            if (studentas.Vidurkis >= 5)
                            {
                                Program.kietiakiaiLL.AddLast(studentas);
                            }
                            else
                            {
                                Program.vargsiukaiLL.AddLast(studentas);
                            }
                        }
                    }
                    else if (tipas.Equals("Queue"))
                    {
                        Program.studentaiQ.Enqueue(studentas);
                        if (sort)
                        {
                            if (studentas.Vidurkis >= 5)
                            {
                                Program.kietiakiaiQ.Enqueue(studentas);
                            }
                            else
                            {
                                Program.vargsiukaiQ.Enqueue(studentas);
                            }
                        }
                    }
                }
                counter++;
            }
            file.Close();
            stopwatchRead.Stop();
            Console.WriteLine("Elapsed Time for file read {0} ms", stopwatchRead.ElapsedMilliseconds);
            System.Console.WriteLine("Buvo prideta {0} studentų.", counter - 1);
        }

        public static void ReadRandomInput(int studentuKiekis)
        {
            int index = 0;
            while (index < studentuKiekis)
            {
                StudentasSimple studentas = new StudentasSimple();
                Random rnd = new Random();

                studentas.Vardas = "Vardas" + (index + 1);
                studentas.Pavarde = "Pavarde" + (index + 1);
                for (int i = 0; i < 6; i++)
                {
                    studentas.NamuDarbai.Add(rnd.Next(0, 10));
                }
                studentas.Egzaminas = rnd.Next(0, 10);
                studentas.Vidurkis = GetVidurkis(studentas.NamuDarbai, studentas.Egzaminas);
                studentas.Mediana = GetMediana(studentas.NamuDarbai, studentas.Egzaminas);
                Program.studentaiL.Add(studentas);

                index += 1;
            }
        }

        private static StudentasSimple ParseStudent(String duomenys)
        {
/*            Stopwatch stopwatchT = new Stopwatch();
            stopwatchT.Start();*/
            StudentasSimple studentas = new StudentasSimple();
            String[] splitData;
            try
            {
                splitData = duomenys.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (splitData.Length < 2) { throw new FormatException("Not enough array elements"); }
            }
            catch (FormatException ex)
            {
                return null;
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
                    studentas.NamuDarbai.Add(defaultValue);
                }
            }

            try
            {
                studentas.Egzaminas = double.Parse(splitData[7]);
            }
            catch (Exception ex)
            {
                studentas.Egzaminas = defaultValue;
            }

            studentas.Vidurkis = GetVidurkis(studentas.NamuDarbai, studentas.Egzaminas);
            studentas.Mediana  = GetMediana(studentas.NamuDarbai, studentas.Egzaminas);
/*            stopwatchT.Stop();
            Console.WriteLine("Elapsed Time for file read {0} ms", stopwatchT.ElapsedMilliseconds);*/

            return studentas;
        }


        private static double GetVidurkis(List<double> NamuDarbai, double Egzaminas)
        {
            double suma = 0;
            double namuVid = 0;
            int size = 0;
            foreach (var pazymys in NamuDarbai)
            {
                suma += (int)pazymys;
                size += 1;
            }
            if (suma == 0 || size == 0)
            {
                namuVid = 0;
            }
            else namuVid = suma / size;
            double galutinis = 0.3 * namuVid + 0.7 * Egzaminas;
            return galutinis;
        }

        private static double GetMediana(List<double> NamuDarbai, double Egzaminas)
        {
            double rezultatas = SkaiciuotiMediana(NamuDarbai.ToArray());
            double galutinis = 0.3 * rezultatas + 0.7 * Egzaminas;
            return galutinis;
        }

        private static double SkaiciuotiMediana(double[] skaičiai)
        {
            try
            {
                if (skaičiai == null || skaičiai.Length < 5)
                    throw new Exception("Reikalinga bent viena reikšmė medianai skaičiuoti");
            }
            catch (Exception)
            {
                return 0.00;
            }

            //Rušiuoti sąraša ir naudoti naują masyvą
            double[] rušiuotiSkaičiai = (double[])skaičiai.Clone();
            Array.Sort(rušiuotiSkaičiai);

            //Gauti mediana
            int dydis = rušiuotiSkaičiai.Length;
            double mediana = (dydis % 2 != 0) ? rušiuotiSkaičiai[dydis / 2] : (rušiuotiSkaičiai[dydis / 2] + rušiuotiSkaičiai[dydis / 2 - 1]) / 2;
            return mediana;
        }

    }
}