using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Manav
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList meyveler = new ArrayList();
            ArrayList sebzeler = new ArrayList();
            ArrayList musteri = new ArrayList();

            int ELMA = 0;
            int ARMUT = 0;
            int MUZ = 0;

            int PATLICAN = 0;
            int DOMATES = 0;
            int BIBER = 0;

            while (true)
            {
                Console.WriteLine("HALE HOŞGELDİNİZ");
                Console.WriteLine("MEYVE Mİ? SEBZE Mİ?: (M/S)\nÇIKIŞ (Q)");
                string secimhale = Console.ReadLine().ToUpper();
                if (secimhale == "m")
                {
                    Console.WriteLine("1) Elma\n2) Armut\n3) Muz\n\tSeçiminiz: ");
                    int meyve = Convert.ToInt32(Console.ReadLine());
                    if(meyve==1) 
                    {
                        if(!meyveler.Contains("ELMA"))
                        meyveler.Add("ELMA");

                        Console.WriteLine("Kaç kilo?: ");
                        ELMA += Convert.ToInt32(Console.ReadLine());

                        foreach (var item in meyveler)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine(ELMA);
                    }
                    else if(meyve==2) 
                    {
                        if (!meyveler.Contains("ARMUT"))
                            meyveler.Add("ARMUT");

                        Console.WriteLine("Kaç kilo?: ");
                        ARMUT += Convert.ToInt32(Console.ReadLine());

                        foreach (var item in meyveler)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine(ARMUT);
                    }
                    else if(meyve==3)
                    {
                        if (!meyveler.Contains("MUZ"))
                            meyveler.Add("MUZ");

                        Console.WriteLine("Kaç kilo?: ");
                        MUZ += Convert.ToInt32(Console.ReadLine());

                        foreach (var item in meyveler)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine(MUZ);
                    }
                    else { Console.WriteLine("HATALI SEÇİM!!!"); }





                }
                else if (secimhale == "s")
                {
                    Console.WriteLine("1) Patlıcan\n2) Domates\n3) Biber\n\tSeçiminiz: ");
                    int sebze = Convert.ToInt32(Console.ReadLine());
                    if (sebze == 1)
                    {
                        if (!meyveler.Contains("PATLICAN"))
                            meyveler.Add("PATLICAN");

                        Console.WriteLine("Kaç kilo?: ");
                        PATLICAN += Convert.ToInt32(Console.ReadLine());

                        foreach (var item in meyveler)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine(PATLICAN);
                    }
                    else if (sebze == 2)
                    {
                        if (!meyveler.Contains("DOMATES"))
                            meyveler.Add("DOMATES");

                        Console.WriteLine("Kaç kilo?: ");
                        DOMATES += Convert.ToInt32(Console.ReadLine());

                        foreach (var item in meyveler)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine(DOMATES);
                    }
                    else if (sebze == 3)
                    {
                        if (!meyveler.Contains("BİBER"))
                            meyveler.Add("BİBER");

                        Console.WriteLine("Kaç kilo?: ");
                        BIBER += Convert.ToInt32(Console.ReadLine());

                        foreach (var item in meyveler)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine(BIBER);
                    }
                    else { Console.WriteLine("HATALI SEÇİM!!!"); }
                }
                else if (secimhale == "q")
                {
                    Console.WriteLine("Yinee bekleriz.");
                    break;
                }
                else
                {
                    Console.WriteLine("HATALI SEÇİM!!!");
                }
            }

            Console.WriteLine("MANAVA HOŞGELDİNİZ");
            Console.WriteLine("MEYVE Mİ? SEBZE Mİ?: (M/S)\nÇIKIŞ (Q)");
            string secimmanav = Console.ReadLine().ToUpper();

            if(secimmanav=="m")
            {
                foreach (var item in meyveler)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Seçiminiz: ");
                string meyve = Console.ReadLine();
                Console.WriteLine("Kaç kilo istersiniz?: ");
                int kilo = Convert.ToInt32(Console.ReadLine());

                if (meyve=="ELMA" && ELMA>0 && ELMA>=kilo)
                {
                    
                    musteri.Add(meyve);
                    ELMA -= kilo;

                    if(ELMA==0)
                    {
                        meyveler.Remove(meyve);
                    }
                }
                else if (meyve == "ARMUT" && ARMUT > 0 && ARMUT >= kilo)
                {

                    musteri.Add(meyve);
                    ARMUT -= kilo;

                    if (ARMUT == 0)
                    {
                        meyveler.Remove(meyve);
                    }
                }
                else if (meyve == "MUZ" && MUZ > 0 && MUZ >= kilo)
                {

                    musteri.Add(meyve);
                    MUZ -= kilo;

                    if (MUZ == 0)
                    {
                        meyveler.Remove(meyve);
                    }
                }
            }
            else if(secimmanav=="s")
            {
                foreach (var item in sebzeler)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Seçiminiz: ");
                string sebze = Console.ReadLine();
                Console.WriteLine("Kaç kilo istersiniz?: ");
                int kilo = Convert.ToInt32(Console.ReadLine());

                if (sebze == "PATLICAN" && PATLICAN > 0 && PATLICAN >= kilo)
                {

                    musteri.Add(sebze);
                    PATLICAN -= kilo;

                    if (PATLICAN == 0)
                    {
                        sebzeler.Remove(sebze);
                    }
                }
                else if (sebze == "DOMATES" && DOMATES > 0 && DOMATES >= kilo)
                {

                    musteri.Add(sebze);
                    DOMATES -= kilo;

                    if (DOMATES == 0)
                    {
                        sebzeler.Remove(sebze);
                    }
                }
                else if (sebze == "BİBER" && BIBER > 0 && BIBER >= kilo)
                {

                    musteri.Add(sebze);
                    BIBER -= kilo;

                    if (BIBER == 0)
                    {
                        sebzeler.Remove(sebze);
                    }
                }
            }


            Console.WriteLine("YİNE BEKLERİZ");

            Console.ReadLine();

        }













            

        
    }
}
