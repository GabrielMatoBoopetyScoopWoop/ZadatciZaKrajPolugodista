using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatciZaKrajPolugodista
{
    class KlasaC
    {
        static public int Zbroj(int[] Broj)
        {
            int Zbroj = Broj.Sum();
            return Zbroj;
        }
        static public double Prosjek(int[] Broj)
        {
            double Prosjek = Broj.Average();
            return Prosjek;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int Izbor = 0;
            do
            {
                Console.Write("Izaberite zadatak brojem od 1 do 7 (0 za exit): ");
                Izbor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (Izbor)
                {
                    case 1:
                        Prvi();
                        break;

                    case 2:
                        Drugi();
                        break;

                    case 3:
                        Treci();
                        break;

                    case 4:
                        Cetvrti();
                        break;

                    case 5:
                        Peti();
                        break;

                    case 6:
                        Sesti();
                        break;


                    case 7:
                        Sedmi();
                        break;
                }
                Console.WriteLine();
            } while (Izbor != 0);
        }
        static void Prvi()
        {
            string S1 = "Hrvatska ima more";
            string S2 = "Italija je prvak svijeta";
            string S3 = S1.Substring(0, 7) + S2.Substring(6);
            Console.WriteLine("S3 = " + S3);
        }
        static void Drugi()
        {
            int Broj;
            Console.Write("Upisite broj: ");
            Broj = Convert.ToInt32(Console.ReadLine());
            if (Broj % 6 == 0 && Broj % 4 == 0)
                Console.WriteLine("Broj je djeljiv sa 4 i sa 6");
            else if (Broj % 6 == 0)
                Console.WriteLine("Broj je djeljiv sa 6");
            else if (Broj % 4 == 0)
                Console.WriteLine("Broj je djeljiv sa 4");
            else
                Console.WriteLine("Broj nije djeljiv sa 4 ni sa 6");
        }
        static void Treci()
        {
            for (int i1 = 1; i1 <= 33; i1++)
            {
                for (int i2 = i1 + 1; i2 <= 34; i2++)
                {
                    for (int i3 = i2 + 1; i3 <= 35; i3++)
                    {
                        for (int i4 = i3 + 1; i4 <= 36; i4++)
                        {
                            for (int i5 = i4 + 1; i5 <= 37; i5++)
                            {
                                for (int i6 = i5 + 1; i6 <= 38; i6++)
                                {
                                    for (int i7 = i6 + 1; i7 <= 39; i7++)
                                    {
                                        Console.WriteLine(i1 + " " + i2 + " " + i3 + " " + i4 + " " + i5 + " " + i6 + " " + i7);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        static void Cetvrti()
        {
            int[] Broj = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Upisite " + (i + 1) + ". broj: ");
                Broj[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Zbroj tih brojeva je: " + KlasaC.Zbroj(Broj));
            Console.WriteLine("Prosjek tih brojeva je: " + KlasaC.Prosjek(Broj));
        }
        static void Peti()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Sesti()
        {
            int n, Zbroj = 0;
            Console.Write("Upisite broj n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Zbroj += i;
            }
            Console.WriteLine("Zbroj prvih n brojeva je " + Zbroj);
        }
        static void Sedmi()
        {
            Console.Write("Upisite broj clanova: ");
            int BrojClanova = Convert.ToInt32(Console.ReadLine());
            int[] Brojevi = new int[BrojClanova];
            for (int i = 0; i < BrojClanova; i++)
            {
                Console.Write("Upisite broj " + (i + 1) + ": ");
                Brojevi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(Brojevi);
            Console.WriteLine("Clanovi od najmanje vrijednosti do najvece:");
            for (int i = 0; i < BrojClanova; i++)
            {
                Console.Write(Brojevi[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
