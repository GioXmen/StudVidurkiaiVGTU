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
            Console.WriteLine("Studentų pažymiai v0.5 - Ernestas Lobačevskis");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("cl      - Console įvedimas");
            Console.WriteLine("txt     - Įvestis iš teksto failo");
            Console.WriteLine("rnd     - Įvestis sugeneruota");
            Console.WriteLine("printr  - Spausdint rezultatus, rušiuoti pagal vardus");
            Console.WriteLine("printrf - Ivesti sugeneruotus studentus i faila");
            Console.WriteLine("end     - Baigti programa");
            Console.WriteLine("clear   - Valyti išvedimą");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("          Greičio matavimo modulis          ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("g1     - Generuoti x studentų į failą");
            Console.WriteLine("g2L    - Rušiuoti  x generuotų studentų [List]");
            Console.WriteLine("g2LL   - Rušiuoti  x generuotų studentų [LinkedList]");
            Console.WriteLine("g2Q    - Rušiuoti  x generuotų studentų [Queue]");
            Console.WriteLine("Output/Input dir: \\StudVidurkiaiVGTU\\StudVidurkiaiVGTU\\bin\\Debug\\netcoreapp3.1");

            bool baigti = false;
            while (baigti.Equals(false))
            {
                string tekstas;
                int kiekis;
                int strategija;
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
                        Int32.TryParse(tekstas, out kiekis);
                        StudentDataSimple.ReadInputFromFile(kiekis, "List", false, true, 1);
                        break;
                    case "rnd":
                        Program.studentaiL.Clear();
                        Console.WriteLine("Kiek studentų generuoti?");
                        tekstas = Console.ReadLine();
                        Int32.TryParse(tekstas, out kiekis);
                        StudentDataSimple.ReadRandomInput(kiekis);
                        break;
                    case "printr":
                        PrintStudentsRezultatai();
                        break;
                    case "printrf":
                        PrintStudentsRezultataiIFaila();
                        break;
                    case "g1":
                        Program.studentaiL.Clear();
                        Console.WriteLine("Kiek studentų naudoti?");
                        tekstas = Console.ReadLine();
                        Int32.TryParse(tekstas, out kiekis);
                        GeneruotiXStudentuIFaila(kiekis, 1);
                        break;
                    case "g2L":
                        Program.studentaiL.Clear();
                        Console.WriteLine("Kiek studentų traukti? [Turi buti pirma sugeneruota]");
                        tekstas = Console.ReadLine();
                        Int32.TryParse(tekstas, out kiekis);
                        Console.WriteLine("Kiek strategija naudoti?[1 arba 2]");
                        tekstas = Console.ReadLine();
                        Int32.TryParse(tekstas, out strategija);
                        RusiuotiXStudentu(kiekis, "List", strategija);
                        break;
                    case "g2LL":
                        Program.studentaiL.Clear();
                        Console.WriteLine("Kiek studentų traukti? [Turi buti pirma sugeneruota]");
                        tekstas = Console.ReadLine();
                        Int32.TryParse(tekstas, out kiekis);
                        Console.WriteLine("Kiek strategija naudoti?[1 arba 2]");
                        tekstas = Console.ReadLine();
                        Int32.TryParse(tekstas, out strategija);
                        RusiuotiXStudentu(kiekis, "LinkedList", strategija);
                        break;
                    case "g2Q":
                        Program.studentaiL.Clear();
                        Console.WriteLine("Kiek studentų traukti? [Turi buti pirma sugeneruota]");
                        tekstas = Console.ReadLine();
                        Int32.TryParse(tekstas, out kiekis);
                        Console.WriteLine("Kiek strategija naudoti?[1 arba 2]");
                        tekstas = Console.ReadLine();
                        Int32.TryParse(tekstas, out strategija);
                        RusiuotiXStudentu(kiekis, "Queue", strategija);
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

        public static void GeneruotiXStudentuIFaila(int kiekis, int strategija)
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
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time for file output is {0} ms", stopwatch.ElapsedMilliseconds);

            Program.studentaiL.Clear();
            StudentDataSimple.ReadInputFromFile(kiekis, "List", false, false, strategija);
        }


        public static void RusiuotiXStudentu(int kiekis, String type, int strategija)
        {
            Stopwatch stopwatchProgramFull = new Stopwatch();
            stopwatchProgramFull.Start();


            Stopwatch stopwatchGen = new Stopwatch();
            stopwatchGen.Start();
            StudentDataSimple.ReadInputFromFile(kiekis, type, true, true, strategija);
            stopwatchGen.Stop();
            Console.WriteLine("Elapsed Time for read and sort is {0} ms", stopwatchGen.ElapsedMilliseconds);

            Stopwatch stopwatchFile = new Stopwatch();
            stopwatchFile.Start();
            IsvestiIfaila(kiekis, type, "Vargsiukai", strategija);
            IsvestiIfaila(kiekis, type, "Kietiakiai", strategija);
            stopwatchFile.Stop();
            Console.WriteLine("Elapsed Time for output to file is {0} ms", stopwatchFile.ElapsedMilliseconds);

            stopwatchProgramFull.Stop();
            Console.WriteLine("Elapsed Time for whole execution generation is {0} ms", stopwatchProgramFull.ElapsedMilliseconds);
        }

        public static void IsvestiIfaila(int kiekis, String type, String group, int strategija)
        {

            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream("./studentai" + kiekis + group + type + ".txt", FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open studentai" + kiekis + group + type + ".txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(writer);
            Console.WriteLine("{0, 5} {1, 16} {2, 25}", "Vardas", "Pavardė", "Galutinis (Vid.)");

            switch (type)
            {
                case "List":
                    if (group.Equals("Vargsiukai"))
                    {
                        List<StudentasSimple> isvestis = Program.vargsiukaiL;
                        foreach (var studentas in isvestis)
                        {
                            Console.WriteLine("{0, 5} {1, 18} {2, 20}", studentas.Vardas, studentas.Pavarde, studentas.Vidurkis.ToString("0.##"));
                        }
                    } else if (group.Equals("Kietiakiai"))
                    {
                        List<StudentasSimple> isvestis = new List<StudentasSimple>();
                        if (strategija == 2) { 
                        isvestis = Program.studentaiL;
                        }
                        else isvestis = Program.kietiakiaiL;
                        foreach (var studentas in isvestis)
                        {
                            Console.WriteLine("{0, 5} {1, 18} {2, 20}", studentas.Vardas, studentas.Pavarde, studentas.Vidurkis.ToString("0.##"));
                        }
                    }
                    break;
                case "LinkedList":
                    if (group.Equals("Vargsiukai"))
                    {
                        LinkedList<StudentasSimple> isvestis = Program.vargsiukaiLL;
                        foreach (var studentas in isvestis)
                        {
                            Console.WriteLine("{0, 5} {1, 18} {2, 20}", studentas.Vardas, studentas.Pavarde, studentas.Vidurkis.ToString("0.##"));
                        }
                    }
                    else if (group.Equals("Kietiakiai"))
                    {
                        LinkedList<StudentasSimple> isvestis = new LinkedList<StudentasSimple>();
                        if (strategija == 2)
                        {
                            isvestis = Program.studentaiLL;
                        }
                        else isvestis = Program.kietiakiaiLL;
                        foreach (var studentas in isvestis)
                        {
                            Console.WriteLine("{0, 5} {1, 18} {2, 20}", studentas.Vardas, studentas.Pavarde, studentas.Vidurkis.ToString("0.##"));
                        }
                    }
                    break;
                case "Queue":
                    if (group.Equals("Vargsiukai"))
                    {
                        Queue<StudentasSimple> isvestis = Program.vargsiukaiQ;
                        foreach (var studentas in isvestis)
                        {
                            Console.WriteLine("{0, 5} {1, 18} {2, 20}", studentas.Vardas, studentas.Pavarde, studentas.Vidurkis.ToString("0.##"));
                        }
                    }
                    else if (group.Equals("Kietiakiai"))
                    {
                        Queue<StudentasSimple> isvestis = new Queue<StudentasSimple>();
                        if (strategija == 2)
                        {
                            isvestis = Program.studentaiQ;
                        }
                        else isvestis = Program.kietiakiaiQ;
                        foreach (var studentas in isvestis)
                        {
                            Console.WriteLine("{0, 5} {1, 18} {2, 20}", studentas.Vardas, studentas.Pavarde, studentas.Vidurkis.ToString("0.##"));
                        }
                    }
                    break;
            }
            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();

        }
    }
}

