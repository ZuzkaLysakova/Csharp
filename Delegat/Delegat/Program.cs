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
        int pocet;
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

        }

        public void SeradStudentypodleJmena(PorovnavacStudentu porovnavacStudentu)
        {

        }

        public void SeradStudentypodleFakulty(PorovnavacStudentu porovnavacStudentu)
        {

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Studenti studenti = new Studenti();

            int prikaz = 0;
            switch (prikaz)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:

                    break;
                case 2:
                    studenti.VypisStudenty();
                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
            }
        }
    }
}
