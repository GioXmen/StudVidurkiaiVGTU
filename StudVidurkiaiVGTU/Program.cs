using System;
using System.Collections.Generic;
using System.Linq;

namespace StudVidurkiaiVGTU
{
    static class Program
    {
        public static List<Studentas> studentai = new List<Studentas>();
        static void Main(string[] args)
        {
            Menu.ShowMenu();
        }
    }

    internal static class Menu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("Studentų pažymiai v0.2 - Ernestas Lobačevskis");
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

            bool baigti = false;
            while (baigti.Equals(false))
            {
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
                        StudentData.ReadRandomInput();
                        break;
                    case "printr":
                        PrintStudentsRezultatai();
                        break;
                    case "print":
                        PrintStudents();
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
    }
}
