using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._08._2019_taskBooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salam zehmet olmasa hotel xidmetimzde olan hotel secin ");

            Console.WriteLine();
            Console.WriteLine();
            Hotels Hilton = new Hotels();
            Hilton.HotelNumber = 1;
            Hilton.Name = "Hilton";
            Hilton.Adress = "Baku Babek pr.";
            Hilton.MinPrice = 200;
           Hilton.Single = new int[] { 1, 12, 24, 6, 7, 13, 22 };
            Hilton.Double = new int[] { 2, 11, 23, 5, 8, 14, 21 };
            Hilton.Triple = new int[] { 3, 10, 20, 9, 4, 18, 15 };
            Hilton.additional = " Icmeli su ile temin edilir";
            Console.WriteLine(Hilton.HotelInfo());

            Hotels Absheron = new Hotels();
            Absheron.HotelNumber = 2;
            Absheron.Name = "Absheron";
            Absheron.Adress = "Baku Heyder Eliyev pr.";
            Absheron.MinPrice = 150;
            Absheron.Single = new int[] { 1, 4, 12, 24, 6, 7, 13, 22 };
            Absheron.Double = new int[] { 2, 11, 18, 23, 5, 8, 14, 21 };
            Absheron.Triple = new int[] { 3, 10, 20, 9, 23, 4, 18, 15 };
            Absheron.additional = " Lampalar isleyir";
            Console.WriteLine(Absheron.HotelInfo());


            Hotels Winter_Park = new Hotels();
            Winter_Park.HotelNumber = 3;
            Winter_Park.Name = "Winter_Park";
            Winter_Park.Adress = "Baku Qış Parkı";
            Winter_Park.MinPrice = 150;
            Winter_Park.Single = new int[] { 1,4, 12, 24, 6, 7, 13, 22 };
            Winter_Park.Double = new int[] { 2, 11,18, 23, 5, 8, 14, 21 };
            Winter_Park.Triple = new int[] { 3, 10, 20, 9,23, 4, 18, 15 };
            Winter_Park.additional = " Fulun fula";
            Console.WriteLine(Winter_Park.HotelInfo());

            int hotelnumber = int.Parse(Console.ReadLine());

            if (hotelnumber == Hilton.HotelNumber)
            {
                Console.WriteLine();
                Console.WriteLine(" Single rooms in Hilton: ");
                foreach (var item in Hilton.Single)
                {
                    Console.Write(item + " ");

                }

                Console.WriteLine();

                Console.WriteLine(" Double rooms in Hilton: ");
                foreach (var item in Hilton.Double)
                {
                    Console.Write(item + " ");

                }

                Console.WriteLine();


                Console.WriteLine(" Triple rooms in Hilton: ");
                foreach (var item in Hilton.Triple)
                {
                    Console.Write(item + " ");

                }

                Console.WriteLine();


                Console.WriteLine("Otaq novunu secin");
                Console.ReadLine();
                
                

                #region Single

                Console.WriteLine();
                Console.WriteLine(" Single rooms in Hilton: ");
                foreach (var item in Hilton.Single)
                {
                    Console.Write( item +" ");
                    
                }

                Console.WriteLine();

                int sNumber = int.Parse(Console.ReadLine());

                if(Array.Exists(Hilton.Single, element => element == sNumber) == true)
                {
                    Console.WriteLine(sNumber +" Reserved");

                    int a = Array.IndexOf(Hilton.Single, sNumber);
                
                    int numToRemove = sNumber;
                    int numIndex = Array.IndexOf(Hilton.Single, numToRemove);
                    Hilton.Single = Hilton.Single.Where((val, idx) => idx != numIndex).ToArray();
                    Console.ReadLine();
                    foreach (var item in Hilton.Single)
                    {
                        Console.Write(item + " ");

                    }
                    Console.WriteLine();


                  
                }

                #endregion

                #region Double

                Console.WriteLine(" Double rooms in Hilton: ");
                foreach (var item in Hilton.Double)
                {
                    Console.Write(item + " ");

                }

                Console.WriteLine();

                int dNumber = int.Parse(Console.ReadLine());

                if (Array.Exists(Hilton.Double, element => element == dNumber) == true)
                {
                    Console.WriteLine(dNumber + " Reserved");

                    int a = Array.IndexOf(Hilton.Double, dNumber);

                    int numToRemove = dNumber;
                    int numIndex = Array.IndexOf(Hilton.Double, numToRemove);
                    Hilton.Double = Hilton.Double.Where((val, idx) => idx != numIndex).ToArray();
                    Console.ReadLine();
                    foreach (var item in Hilton.Double)
                    {
                        Console.Write(item + " ");

                    }
                    Console.WriteLine();



                }

                #endregion

                #region Triple

                Console.WriteLine(" Triple rooms in Hilton: ");
                foreach (var item in Hilton.Triple)
                {
                    Console.Write(item + " ");

                }

                Console.WriteLine();

                int tNumber = int.Parse(Console.ReadLine());

                if (Array.Exists(Hilton.Triple, element => element == tNumber) == true)
                {
                    Console.WriteLine(tNumber + " Reserved");

                    int a = Array.IndexOf(Hilton.Triple, tNumber);

                    int numToRemove = tNumber;
                    int numIndex = Array.IndexOf(Hilton.Triple, numToRemove);
                    Hilton.Triple = Hilton.Triple.Where((val, idx) => idx != numIndex).ToArray();
                    Console.ReadLine();
                    foreach (var item in Hilton.Triple)
                    {
                        Console.Write(item + " ");

                    }
                    Console.WriteLine();



                }

                #endregion
            }

            if (hotelnumber == Winter_Park.HotelNumber)
            {
                Console.WriteLine();
                Console.WriteLine(" Single rooms in Winter Park: ");
                foreach (var item in Winter_Park.Single)
                {
                    Console.Write(item + " ");

                }

                Console.WriteLine();

                Console.WriteLine(" Double rooms in Winter_Park: ");
                foreach (var item in Winter_Park.Double)
                {
                    Console.Write(item + " ");

                }

                Console.WriteLine();


                Console.WriteLine(" Triple rooms in Winter_Park: ");
                foreach (var item in Winter_Park.Triple)
                {
                    Console.Write(item + " ");

                }

                Console.WriteLine();


                Console.WriteLine("Otaq novunu secin");
                Console.ReadLine();



                #region Single

                Console.WriteLine();
                Console.WriteLine(" Single rooms in Winter_Park: ");
                foreach (var item in Winter_Park.Single)
                {
                    Console.Write(item + " ");

                }

                Console.WriteLine();

                int sNumber = int.Parse(Console.ReadLine());

                if (Array.Exists(Winter_Park.Single, element => element == sNumber) == true)
                {
                    Console.WriteLine(sNumber + " Reserved");

                    int a = Array.IndexOf(Winter_Park.Single, sNumber);

                    int numToRemove = sNumber;
                    int numIndex = Array.IndexOf(Winter_Park.Single, numToRemove);
                    Winter_Park.Single = Winter_Park.Single.Where((val, idx) => idx != numIndex).ToArray();
                    Console.ReadLine();
                    foreach (var item in Winter_Park.Single)
                    {
                        Console.Write(item + " ");

                    }
                    Console.WriteLine();



                }

                #endregion

                #region Double

                Console.WriteLine(" Double rooms in Winter_Park: ");
                foreach (var item in Winter_Park.Double)
                {
                    Console.Write(item + " ");

                }

                Console.WriteLine();

                int dNumber = int.Parse(Console.ReadLine());

                if (Array.Exists(Winter_Park.Double, element => element == dNumber) == true)
                {
                    Console.WriteLine(dNumber + " Reserved");

                    int a = Array.IndexOf(Winter_Park.Double, dNumber);

                    int numToRemove = dNumber;
                    int numIndex = Array.IndexOf(Winter_Park.Double, numToRemove);
                    Winter_Park.Double = Winter_Park.Double.Where((val, idx) => idx != numIndex).ToArray();
                    Console.ReadLine();
                    foreach (var item in Winter_Park.Double)
                    {
                        Console.Write(item + " ");

                    }
                    Console.WriteLine();



                }

                #endregion

                #region Triple

                Console.WriteLine(" Triple rooms in Winter_Park: ");
                foreach (var item in Winter_Park.Triple)
                {
                    Console.Write(item + " ");

                }

                Console.WriteLine();

                int tNumber = int.Parse(Console.ReadLine());

                if (Array.Exists(Winter_Park.Triple, element => element == tNumber) == true)
                {
                    Console.WriteLine(tNumber + " Reserved");

                    int a = Array.IndexOf(Winter_Park.Triple, tNumber);

                    int numToRemove = tNumber;
                    int numIndex = Array.IndexOf(Winter_Park.Triple, numToRemove);
                    Winter_Park.Triple = Winter_Park.Triple.Where((val, idx) => idx != numIndex).ToArray();
                    Console.ReadLine();
                    foreach (var item in Winter_Park.Triple)
                    {
                        Console.Write(item + " ");

                    }
                    Console.WriteLine();



                }

                #endregion
            }

            if (hotelnumber == Absheron.HotelNumber)
            {
                Console.WriteLine();
                Console.WriteLine(" Single rooms in Absheron: ");
                foreach (var item in Absheron.Single)
                {
                    Console.Write(item + " ");

                }

                Console.WriteLine();

                Console.WriteLine(" Double rooms in Abseron: ");
                foreach (var item in Absheron.Double)
                {
                    Console.Write(item + " ");

                }

                Console.WriteLine();


                Console.WriteLine(" Triple rooms in Absheron: ");
                foreach (var item in Absheron.Triple)
                {
                    Console.Write(item + " ");

                }

                Console.WriteLine();


                Console.WriteLine("Otaq novunu secin");
                Console.ReadLine();



                #region Single

                Console.WriteLine();
                Console.WriteLine(" Single rooms in Absheron: ");
                foreach (var item in Absheron.Single)
                {
                    Console.Write(item + " ");

                }

                Console.WriteLine();

                int sNumber = int.Parse(Console.ReadLine());

                if (Array.Exists(Absheron.Single, element => element == sNumber) == true)
                {
                    Console.WriteLine(sNumber + " Reserved");

                    int a = Array.IndexOf(Absheron.Single, sNumber);

                    int numToRemove = sNumber;
                    int numIndex = Array.IndexOf(Absheron.Single, numToRemove);
                    Absheron.Single = Absheron.Single.Where((val, idx) => idx != numIndex).ToArray();
                    Console.ReadLine();
                    foreach (var item in Absheron.Single)
                    {
                        Console.Write(item + " ");

                    }
                    Console.WriteLine();



                }

                #endregion

                #region Double

                Console.WriteLine(" Double rooms in Absheron: ");
                foreach (var item in Absheron.Double)
                {
                    Console.Write(item + " ");

                }

                Console.WriteLine();

                int dNumber = int.Parse(Console.ReadLine());

                if (Array.Exists(Absheron.Double, element => element == dNumber) == true)
                {
                    Console.WriteLine(dNumber + " Reserved");

                    int a = Array.IndexOf(Absheron.Double, dNumber);

                    int numToRemove = dNumber;
                    int numIndex = Array.IndexOf(Absheron.Double, numToRemove);
                    Absheron.Double = Absheron.Double.Where((val, idx) => idx != numIndex).ToArray();
                    Console.ReadLine();
                    foreach (var item in Absheron.Double)
                    {
                        Console.Write(item + " ");

                    }
                    Console.WriteLine();



                }

                #endregion

                #region Triple

                Console.WriteLine(" Triple rooms in Absheron: ");
                foreach (var item in Absheron.Triple)
                {
                    Console.Write(item + " ");

                }

                Console.WriteLine();

                int tNumber = int.Parse(Console.ReadLine());

                if (Array.Exists(Absheron.Triple, element => element == tNumber) == true)
                {
                    Console.WriteLine(tNumber + " Reserved");

                    int a = Array.IndexOf(Absheron.Triple, tNumber);

                    int numToRemove = tNumber;
                    int numIndex = Array.IndexOf(Absheron.Triple, numToRemove);
                    Absheron.Triple = Absheron.Triple.Where((val, idx) => idx != numIndex).ToArray();
                    Console.ReadLine();
                    foreach (var item in Absheron.Triple)
                    {
                        Console.Write(item + " ");

                    }
                    Console.WriteLine();



                }

                #endregion
            }
        }
        //Ekran açılanda otellərin adları, ünvanları, minimum otaq qiyməti, göstərilən xidmətlər görsənsin
        //İstifadəçi otelin nömərisini seçdikdə -> Otaqların siyahısı (single, double, triple) və qiymətləri görsənsin
        public class Hotels
        {
            public int HotelNumber;
            public string Name;
            public string Adress;
            public int MinPrice;
            public string additional;
            public int[] Single;
            public int[] Double;
            public int[] Triple;
            public string HotelInfo()
            {
                return HotelNumber + " " + Name + " " + Adress + " " + MinPrice + " azn " + additional;
            }
        }


    }

}
