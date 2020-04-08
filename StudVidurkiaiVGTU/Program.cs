using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace StudVidurkiaiVGTU
{
    static class Program
    {
        public static List<StudentasSimple> studentaiL = new List<StudentasSimple>();
        public static List<StudentasSimple> vargsiukaiL = new List<StudentasSimple>();
        public static List<StudentasSimple> kietiakiaiL = new List<StudentasSimple>();

        public static LinkedList<StudentasSimple> studentaiLL = new LinkedList<StudentasSimple>();
        public static LinkedList<StudentasSimple> vargsiukaiLL = new LinkedList<StudentasSimple>();
        public static LinkedList<StudentasSimple> kietiakiaiLL = new LinkedList<StudentasSimple>();

        public static Queue<StudentasSimple> studentaiQ = new Queue<StudentasSimple>();
        public static Queue<StudentasSimple> vargsiukaiQ = new Queue<StudentasSimple>();
        public static Queue<StudentasSimple> kietiakiaiQ = new Queue<StudentasSimple>();

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
            Console.WriteLine("printrf - Ivesti sugeneruotus studentus i faila");
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
                        StudentDataSimple.ReadInputFromConsole();
                        break;
                    case "txt":
                        Program.studentaiL.Clear();
                        Console.WriteLine("Kiek studentų tures?");
                        tekstas = Console.ReadLine();
                        Int32.TryParse(tekstas, out skaicius);
                        StudentDataSimple.ReadInputFromFile(skaicius, "List", false);
                        break;
                    case "rnd":
                        Program.studentaiL.Clear();
                        Console.WriteLine("Kiek studentų generuoti?");
                        tekstas = Console.ReadLine();
                        Int32.TryParse(tekstas, out skaicius);
                        StudentDataSimple.ReadRandomInput(skaicius);
                        break;
                    case "printr":
                        PrintStudentsRezultatai();
                        break;
                    case "printrf":
                        PrintStudentsRezultataiIFaila();
                        break;
                    case "print":
                        PrintStudents();
                        break;
                    case "g1":
                        Program.studentaiL.Clear();
                        Console.WriteLine("Kiek studentų naudoti?");
                        tekstas = Console.ReadLine();
                        Int32.TryParse(tekstas, out skaicius);
                        GeneruotiXStudentuIFaila(skaicius);
                        break;
                    case "g2":
                        Program.studentaiL.Clear();
                        Console.WriteLine("Kiek studentų traukti? [Turi buti pirma sugeneruota]");
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
            var newList = Program.studentaiL.OrderBy(value => value.Vardas).ToList();
            foreach (var studentas in newList)
            {
                Console.WriteLine("{0, 5} {1, 18} {2, 20} {3, 30}", studentas.Vardas, studentas.Pavarde, studentas.Vidurkis.ToString("0.##"), studentas.Mediana.ToString("0.##"));
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }

        public static void PrintStudentsRezultataiIFaila()
        {
            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream("./studentai" + Program.studentaiL.Count + ".txt", FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open studentai" + Program.studentaiL.Count + ".txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(writer);
            Console.WriteLine("{0, 5} {1, 15} {2, 16} {3, 17} {4, 18} {5, 19} {6, 20} {7, 21} {8, 22}",
                "Vardas", "Pavardė", "ND1", "ND2", "ND3", "ND4", "ND5", "ND6", "Egzaminas");
            foreach (var studentas in Program.studentaiL)
            {
                Console.WriteLine("{0, 5} {1, 15} {2, 16} {3, 17} {4, 18} {5, 19} {6, 20} {7, 21} {8, 22}",
                    studentas.Vardas, studentas.Pavarde, studentas.NamuDarbai[0], studentas.NamuDarbai[1],
                    studentas.NamuDarbai[2], studentas.NamuDarbai[3], studentas.NamuDarbai[4], studentas.NamuDarbai[5], studentas.Egzaminas);
            }
            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
        }

        public static void PrintStudents()
        {
            foreach (var studentas in Program.studentaiL)
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
            StudentDataSimple.ReadRandomInput(kiekis);
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
            foreach (var studentas in Program.studentaiL)
            {
                Console.WriteLine("{0, 5} {1, 18} {2, 20}", studentas.Vardas, studentas.Pavarde, studentas.Vidurkis.ToString("0.##"));
            }
            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time for file output is {0} ms", stopwatch.ElapsedMilliseconds);

            Program.studentaiL.Clear();
            StudentDataSimple.ReadInputFromFile(kiekis, "List", false);
        }


        public static void RusiuotiXStudentu(int kiekis)
        {
            Stopwatch stopwatchProgramFull = new Stopwatch();
            stopwatchProgramFull.Start();


            Stopwatch stopwatchGen = new Stopwatch();
            stopwatchGen.Start();
            StudentDataSimple.ReadRandomInput(kiekis);
            stopwatchGen.Stop();
            Console.WriteLine("Elapsed Time for random generation is {0} ms", stopwatchGen.ElapsedMilliseconds);


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Program.vargsiukaiL = Program.studentaiL.Where(o => o.Vidurkis < 5).ToList();
            Program.kietiakiaiL = Program.studentaiL.Except(Program.vargsiukaiL).ToList();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time for Sort part is {0} ms", stopwatch.ElapsedMilliseconds);
            Program.studentaiL.Clear();


            Stopwatch stopwatchFile = new Stopwatch();
            stopwatchFile.Start();
            IsvestiIfaila(kiekis, Program.vargsiukaiL, "Vargsiukai");
            IsvestiIfaila(kiekis, Program.kietiakiaiL, "Kietiakiai");
            stopwatchFile.Stop();
            Console.WriteLine("Elapsed Time for random generation is {0} ms", stopwatchFile.ElapsedMilliseconds);

            stopwatchProgramFull.Stop();
            Console.WriteLine("Elapsed Time for whole execution generation is {0} ms", stopwatchProgramFull.ElapsedMilliseconds);
        }

        public static void IsvestiIfaila(int kiekis, List<StudentasSimple> isvestis, String type)
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
                    Console.WriteLine("{0, 5} {1, 18} {2, 20}", studentas.Vardas, studentas.Pavarde, studentas.Vidurkis.ToString("0.##"));
                }
                Console.SetOut(oldOut);
                writer.Close();
                ostrm.Close();
            }
        }
    }
}

