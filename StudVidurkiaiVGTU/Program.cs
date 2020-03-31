using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace StudVidurkiaiVGTU
{
    static class Program
    {
        public static List<Studentas> studentai = new List<Studentas>();
        public static List<Studentas> vargsiukai = new List<Studentas>();
        public static List<Studentas> kietiakiai = new List<Studentas>();

        static void Main(string[] args)
        {
            Menu.ShowMenu();
        }
    }

    internal static class Menu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("Studentų pažymiai v0.4 - Ernestas Lobačevskis");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("cl      - Console įvedimas");
            Console.WriteLine("txt     - Įvestis iš teksto failo");
            Console.WriteLine("rnd     - Įvestis sugeneruota");
            Console.WriteLine("printr  - Spausdint rezultatus, rušiuoti pagal vardus");
            Console.WriteLine("print   - Spausdint studentus [raw data]");
            Console.WriteLine("end     - Baigti programa");
            Console.WriteLine("clear   - Valyti išvedimą");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("          Greičio matavimo modulis          ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("g1     - Generuoti x studentų į failą");
            Console.WriteLine("g2     - Rušiuoti  x generuotų studentų");
            Console.WriteLine("Output dir: \\StudVidurkiaiVGTU\\StudVidurkiaiVGTU\\bin\\Debug\\netcoreapp3.1");

            bool baigti = false;
            while (baigti.Equals(false))
            {
                string tekstas;
                int skaicius;
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Įveskite norimą veiksmą");
                Console.WriteLine("--------------------------------------------");
                switch (Console.ReadLine())
                {
                    case "cl":
                        StudentData.ReadInputFromConsole();
                        break;
                    case "txt":
                        StudentData.ReadInputFromFile();
                        break;
                    case "rnd":
                        StudentData.ReadRandomInput(1);
                        break;
                    case "printr":
                        PrintStudentsRezultatai();
                        break;
                    case "print":
                        PrintStudents();
                        break;
                    case "g1":
                        Program.studentai.Clear();
                        Console.WriteLine("Kiek studentų naudoti?");
                        tekstas = Console.ReadLine();
                        Int32.TryParse(tekstas, out skaicius);
                        GeneruotiXStudentuIFaila(skaicius);
                        break;
                    case "g2":
                        Program.studentai.Clear();
                        Console.WriteLine("Kiek studentų naudoti?");
                        tekstas = Console.ReadLine();
                        Int32.TryParse(tekstas, out skaicius);
                        RusiuotiXStudentu(skaicius);
                        break;
                    case "end":
                        baigti = true;
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Netinkamas variantas");
                        break;
                }
            }
        }
        public static void PrintStudentsRezultatai()
        {
            Console.WriteLine("{0, 5} {1, 16} {2, 25} {3, 31}", "Vardas", "Pavardė", "Galutinis (Vid.)", "Galutinis(Med.)");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            var newList = Program.studentai.OrderBy(value => value.Vardas).ToList();
            foreach (var studentas in newList)
            {
                Console.WriteLine("{0, 5} {1, 18} {2, 20} {3, 30}", studentas.Vardas, studentas.Pavarde, studentas.GetVidurkis(), studentas.GetMediana());
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }

        public static void PrintStudents()
        {
            foreach (var studentas in Program.studentai)
            {
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("Vardas: " + studentas.Vardas + "\n" + "Pavarde: " + studentas.Pavarde + "\n" +
                    "NamuDarbai:" + string.Join("\t", studentas.NamuDarbai) + "\n" + "Egzaminas: " + studentas.Egzaminas);
                Console.WriteLine("-------------------------------------------------------------------------");
            }
        }

        public static void GeneruotiXStudentuIFaila(int kiekis)
        {
            Stopwatch stopwatchGen = new Stopwatch();
            stopwatchGen.Start();
            StudentData.ReadRandomInput(kiekis);
            stopwatchGen.Stop();
            Console.WriteLine("Elapsed Time for random generation is {0} ms", stopwatchGen.ElapsedMilliseconds);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream("./studentai" + kiekis + ".txt", FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open studentai" + kiekis + ".txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(writer);
            Console.WriteLine("{0, 5} {1, 16} {2, 25}", "Vardas", "Pavardė", "Galutinis (Vid.)");
            foreach (var studentas in Program.studentai)
            {
                Console.WriteLine("{0, 5} {1, 18} {2, 20}", studentas.Vardas, studentas.Pavarde, studentas.GetVidurkis());
            }
            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }


        public static void RusiuotiXStudentu(int kiekis)
        {
            Stopwatch stopwatchProgramFull = new Stopwatch();
            stopwatchProgramFull.Start();


            Stopwatch stopwatchGen = new Stopwatch();
            stopwatchGen.Start();
            StudentData.ReadRandomInput(kiekis);
            stopwatchGen.Stop();
            Console.WriteLine("Elapsed Time for random generation is {0} ms", stopwatchGen.ElapsedMilliseconds);


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Program.vargsiukai = Program.studentai.Where(o => double.Parse(o.GetVidurkis()) < 5).ToList();
            Program.kietiakiai = Program.studentai.Except(Program.vargsiukai).ToList();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time for Sort part is {0} ms", stopwatch.ElapsedMilliseconds);
            Program.studentai.Clear();


            Stopwatch stopwatchFile = new Stopwatch();
            stopwatchFile.Start();
            IsvestiIfaila(kiekis, Program.vargsiukai, "Vargsiukai");
            IsvestiIfaila(kiekis, Program.kietiakiai, "Kietiakiai");
            stopwatchFile.Stop();
            Console.WriteLine("Elapsed Time for random generation is {0} ms", stopwatchFile.ElapsedMilliseconds);

            stopwatchProgramFull.Stop();
            Console.WriteLine("Elapsed Time for whole execution generation is {0} ms", stopwatchProgramFull.ElapsedMilliseconds);
        }

        public static void IsvestiIfaila(int kiekis, List<Studentas> isvestis, String type)
        {
            {
                FileStream ostrm;
                StreamWriter writer;
                TextWriter oldOut = Console.Out;
                try
                {
                    ostrm = new FileStream("./studentai" + kiekis + type + ".txt", FileMode.Create, FileAccess.Write);
                    writer = new StreamWriter(ostrm);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Cannot open studentai" + kiekis + type + ".txt for writing");
                    Console.WriteLine(e.Message);
                    return;
                }
                Console.SetOut(writer);
                Console.WriteLine("{0, 5} {1, 16} {2, 25}", "Vardas", "Pavardė", "Galutinis (Vid.)");
                foreach (var studentas in isvestis)
                {
                    Console.WriteLine("{0, 5} {1, 18} {2, 20}", studentas.Vardas, studentas.Pavarde, studentas.GetVidurkis());
                }
                Console.SetOut(oldOut);
                writer.Close();
                ostrm.Close();
            }
        }
    }
}

