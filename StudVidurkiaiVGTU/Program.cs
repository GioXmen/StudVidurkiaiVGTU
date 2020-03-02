using System;
using System.Collections.Generic;
using System.Linq;

namespace StudVidurkiaiVGTU
{
    class Program
    {
        public static List<Studentas> studentai = new List<Studentas>();
        static void Main(string[] args)
        {
            Menu.ShowMenu();
        }
    }

    internal class Menu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("Studentų pažymiai v0.2 - Ernestas Lobačevskis");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("cl      - Console įvedimas su list");
            Console.WriteLine("cm      - Console įvedimas su masyvais");
            Console.WriteLine("txt     - Įvestis iš teksto failo");
            Console.WriteLine("rnd     - Įvestis sugeneruota");
            Console.WriteLine("printv  - Spausdint vidurkius");
            Console.WriteLine("printm  - Spausdint mediana");
            Console.WriteLine("print   - Spausdint studentus");
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
                    case "printv":
                        PrintStudentsVidurkiai();
                        break;
                    case "printm":
                        PrintStudentsMediana();
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
        public static void PrintStudentsVidurkiai()
        {
            Console.WriteLine("{0, 5} {1, 15} {2, 25}", "Vardas", "Pavardė", "Galutinis (Vid.)");
            Console.WriteLine("--------------------------------------------");
            var newList = Program.studentai.OrderBy(value => value.Vardas).ToList();
            foreach (var studentas in newList)
            {
                Console.WriteLine("{0, 5} {1, 15} {2, 25}", studentas.Vardas, studentas.Pavarde, studentas.GetVidurkis());
            }
            Console.WriteLine("--------------------------------------------");
        }
        public static void PrintStudentsMediana()
        {
            Console.WriteLine("{0, 5} {1, 15} {2, 25}", "Vardas", "Pavardė", "Galutinis (Med.)");
            Console.WriteLine("--------------------------------------------");
            var newList = Program.studentai.OrderBy(value => value.Vardas).ToList();
            foreach (var studentas in newList)
            {
                Console.WriteLine("{0, 5} {1, 15} {2, 25}", studentas.Vardas, studentas.Pavarde, studentas.GetMediana());
            }
            Console.WriteLine("--------------------------------------------");
        }

        public static void PrintStudents()
        {
            foreach (var studentas in Program.studentai)
            {
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("Vardas: " + studentas.Vardas + "\n" + "Pavarde: " + studentas.Pavarde + "\n" +
                    "NamuDarbai:" + string.Join("\t", studentas.NamuDarbai) + "\n" + "Egzaminas: " + studentas.Egzaminas + "\n" + 
                    "Vidurkis: " + studentas.GetVidurkis() + "\n" + "Mediana: " + studentas.GetMediana());
                Console.WriteLine("-------------------------------------------------------------------------");
            }
        }
    }
}
