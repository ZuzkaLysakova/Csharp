using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{

    delegate int PorovnavacStudentu(Student stud1, Student stud2);
    public enum Fakulta { FES, FF, FEI, FCHT };

    class Student
    {
        public string Jmeno { get; set; }
        public int Cislo { get; set; }

        public Fakulta Fakulta { get; set; }

    }

    class Studenti
    {
        private Student[] studenti;
        int pocet = 0;

        public Studenti()
        {
            studenti = new Student[10];
            pocet = 0;
        }

        public void VypisStudenty()
        {
            for (int i = 0; i < studenti.Length; i++)
            {
                Console.WriteLine(studenti[i].Jmeno, studenti[i].Cislo, studenti[i].Fakulta);
            }

        }
        public void SeradStudentypodleId(PorovnavacStudentu porovnavacStudentu)
        {
            for (int i = 0; i < studenti.Length; i++)
            {
                for (int j = 0; j < studenti.Length - 1; j++)
                {
                    if (porovnavacStudentu(studenti[i], studenti[j+1]) > 0)
                    {
                        
                    }
                }
            }
        }

        public void SeradStudentypodleJmena(PorovnavacStudentu porovnavacStudentu)
        {
            for (int i = 0; i < studenti.Length; i++)
            {
                for (int j = 0; j < studenti.Length - 1; j++)
                {

                }
            }
        }

        public void SeradStudentypodleFakulty(PorovnavacStudentu porovnavacStudentu)
        {
            for (int i = 0; i < studenti.Length; i++)
            {
                for (int j = 0; j < studenti.Length - 1; j++)
                {

                }
            }
        }

    }

    class Program
    {
        static public int PorovnejId(Student st1, Student st2)
        {
            if (st1.Cislo < st2.Cislo)
            {
                return -1;
            }
            else if (st1.Cislo > st2.Cislo)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        static public int PorovnejJmena(Student st1, Student st2)
        {
            return st1.Jmeno.CompareTo(st2.Jmeno);
        }

        static public int PorovnejFakulty(Student st1, Student st2)
        {
            return st1.Fakulta.CompareTo(st2.Fakulta);
        }

        static void Main(string[] args)
        {

            
            Studenti studenti = new Studenti();
            Console.WriteLine("Možnosti:");
            Console.WriteLine("0- ukonči program");
            Console.WriteLine("1- načti z klávesnice");
            Console.WriteLine("2- vypiš všechny studenty");
            Console.WriteLine("3- seřaď podle id");
            Console.WriteLine("4- seřaď podle jména");
            Console.WriteLine("5- seřaď podle fakulty");
            int prikaz = 0;
            PorovnavacStudentu porov = null;
            switch (prikaz)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.WriteLine("Zadej id: ");

                    Console.WriteLine("Zadej jmeno: ");

                    Console.WriteLine("Zadej fakultu: ");
                    break;
                case 2:
                    studenti.VypisStudenty();
                    break;
                case 3:
                    porov = PorovnejId;
                    studenti.SeradStudentypodleId(porov);
                    break;
                case 4:
                    porov = PorovnejJmena;
                    studenti.SeradStudentypodleJmena(porov);
                    break;
                case 5:
                    porov = PorovnejFakulty;
                    studenti.SeradStudentypodleFakulty(porov);
                    break;
            }
        }
    }
}
