using System;
using System.Collections.Generic;
using Pirna_pamoka;

namespace Pirma_pamoka
{
    class Program
    {
        
        static void Main(string[] args)
        {
            meniu();
        }
        static void readfile()
        {
            Console.WriteLine("----------{Studentai}-----------");
            Console.WriteLine(System.IO.File.ReadAllText(@"C:\Users\moksleivis.KITM\Desktop\text.txt"));
            Console.WriteLine("----------------------------------");
            meniu();
        }
        static void addStudentToList(string path)
        {
            Console.WriteLine();
        }
         

        static void meniu()
        {
            Console.WriteLine("-------{Kategorijos}---------");
            Console.WriteLine("Studentai 1");
            Console.WriteLine("Prideti 2");
            Console.WriteLine("Surasti 3");
            Console.WriteLine("-----------------------------");
            try
            {
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    readfile();
                }
                else if (option == 2)
                {
                    addStudentToList();
                }
                else if (option == 3)
                {
                    searchStudent();
                }
            }

            catch (Exception)
            {

            }
        }
    }
}



//Penkta pamoka




        /*static void Main(string[] args)
        {
            readfile();
            addStudent();
        }
        private static void addStudent()
        {
            Console.WriteLine("Vardas: ");
            string ime = Console.ReadLine();

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Pavardė: ");
            string prezime = Console.ReadLine();

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Specialybė: ");
            string kurs = Console.ReadLine();

            Console.WriteLine("--------------------------------------");

            string Str = ime+ " " + prezime+ " " + kurs;

            System.IO.File.AppendAllText(@"C:\Users\moksleivis.KITM\Desktop\text.txt", Str + "\n" + "-----------------------------" + "\n");
            */

//Ketvirta pamoka

/*{
      Book AltoriuSeselis = new Book { BookId = 1, Author = "Vincas-Mykolaits-Putinas", BookName = "Altoriu sesely" };
      Book antraKnyga = new Book { BookId = 2, Author = "Kazys Saja", BookName = "Brisiaus galas" };

      List<Book> books = new List<Book>() { AltoriuSeselis, antraKnyga };

      SpausdintiKnyguPavadinimus(books);
  }

  static void SpausdintiKnyguPavadinimus(List<Book> books)
  {
      foreach (var book in books)
      {
          Console.WriteLine(book.BookName);
          Console.WriteLine(book.Author);
      }
  }*/


/*
List<Zmogus> zmones = new List<Zmogus>();

Zmogus pirmasZmogus = new Zmogus
{
    name = "Jurgis",
    surname = "Nauseda"
};
Zmogus antrasZmogus = new Zmogus
{
    name = "Mantas",
    surname = "Priseda"
};

zmones.Add(pirmasZmogus);
zmones.Add(antrasZmogus);

foreach (Zmogus zmogus in zmones)
{
    Console.WriteLine(zmogus.name + " " + zmogus.surname);
}
}
struct Zmogus
{
public string name;
public string surname;
}
*/



/*List<string> studentuVardai = new List<string>
{
    "Aurimas",
    "Tomas",
    "Paulius",
    "Jurgis",
    "Petras",
    "Kazys",
    };

studentuVardai.Remove("Jurgis");
studentuVardai.Add("Justas");

foreach (string vardas in studentuVardai)
{
    Console.WriteLine(vardas);
}

Console.WriteLine("-------------------------------");

List<string> studentaibejurgio = new List<string>();
foreach (string vardas in studentuVardai)
{
    if (vardas != "jurgis")
    {
        studentaibejurgio.Add(vardas);
    }

}
foreach (var item in studentaibejurgio)
{
    Console.WriteLine(item);
}

Console.WriteLine("-------------------------------");



/*List<string> stringuMasyvas;

ICollection<string> stringuMasyvas2;

IEnumerable<string> stringuMasyvas3;

Stack<string> stringuMasyvas4;

Queue<string> stringuMasyvas5;

IDictionary<string, string> stringuMasyvas6;
*/


//trecia pamoka

/*
//int[] randomnumbers = new int[] { 5, 2, 9, 8, 1, 10 };

//Array.Sort(randomnumbers);

//for (int i = 0; i < randomnumbers.Length; i++)
//{
//Console.WriteLine(randomnumbers[i]);
//}
*/

/*
Array.Sort(randomnumbers);

for (int i = 0; i < randomnumbers.Length; i++)
{
    Console.WriteLine(randomnumbers[i]);


/*
            int lines = int.Parse(Console.ReadLine());
            int spaces = lines - 1;
            int stars = 1;
            int spaces1 = lines - 1;
            int stars1 = 1;

            for (int i = 0; i < lines; i++)
            {
                for (int y = 0; y < spaces; y++)
                {
                    Console.Write(" ");
                }

                for (int z = 0; z < stars; z++)
                {
                    Console.Write("* ");
                }
                spaces--;
                stars++;
                Console.WriteLine();
            }

            for (int i = 0; i < lines; i++)
            {
                for (int y = 0; y < stars1; y++)
                {
                    Console.Write(" ");
                }

                for (int z = 0; z < spaces1; z++)
                {
                    Console.Write("* ");
                }

                spaces1--;
                stars1++;
                Console.WriteLine();


/*
int lines = int.Parse(Console.ReadLine());
int spaces = lines - 1;
int stars = 1;
for (int i = 0; i < lines; i++)
{
    for (int y = 0; y < spaces; y++)
    {
        Console.Write(" ");
    }

    for (int z = 0; z < stars; z++)
    {
        Console.Write("* ");
    }

    spaces--;
    stars++;
    Console.WriteLine();


/*
int[] skaiciai = new int[2];
skaiciai[0] = 3;
skaiciai[1] = 5;

foreach (var item in new int[5,6])
{
    Console.WriteLine("FOR EACH LOOP" + item);
}

/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

//Antra pamoka

/*static void Main(string[] args)
{
int rezultatas = sudetis(5, 9);
SpausdintiAntEkrano(rezultatas);
}

static int sudetis(int pirmas, int antras)
{
return pirmas + antras;
}
static void SpausdintiAntEkrano(object tekstas)
{
Console.WriteLine(tekstas);
}*/



/*bool arVakaras = true;
if (arVakaras)
{
 Console.WriteLine("taip tai vakaras");
}

Console.WriteLine(arVakaras ? "TRUE" : "FALSE");*/


/*Console.WriteLine("kokia siandien diena?");
 * string savaitesDiena = Console.ReadLine();
 * switch (savaitesDiena)
 * {
 * case "pirmadienis":
 * Console.WriteLine("kaip blogai");
 * break;
 * case "antradienis":
 * Console.WriteLine("jau geriau");
 * break;
 * case "penktadienis":
 * Console.WriteLine("super");
 * break;
 * default:
 * Console.WriteLine("siaip dienos");
 * break;
 * }*/



/*Console.WriteLine("Pasakykite skaiciu:");
string skaicius1 = Console.ReadLine();
Console.WriteLine("Pasakykite kita skaiciu");
string skaicius2 = Console.ReadLine();

int tikras1 = int.Parse(skaicius1);
int tikras2 = int.Parse(skaicius2);

Console.WriteLine(tikras1 + tikras2);*/


/*Console.WriteLine("Koks tavo vardas?");
string vardas = Console.ReadLine();
Console.WriteLine("Sveikas" + vardas);


/*string mytext = "6";
int sesetas = int.Parse(mytext);

string mytext2 = "7";
int septyni = int.Parse(mytext2);

Console.WriteLine(sesetas * septyni);*/


/*object KitasSkaicius = (object)ManoSkaicius;
int test = (int)KitasSkaicius;
Console.WriteLine(KitasSkaicius);*/


