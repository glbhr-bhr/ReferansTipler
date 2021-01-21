using System;

namespace ReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,bool,decimal,double,float...= Value Types= Stack

            int sayi1 = 10;
            int sayi2 = 15;
            sayi1 = sayi2;
            sayi2 = 16;
            Console.WriteLine("sayi1 :"  + sayi1);


          //Array,class,interface...= Refences Types= Heap
         

             int[] sayilar1 = new int[] { 1, 3, 5 };
             int[] sayilar2 = new int[] { 11, 12, 13 };

            sayilar1 = sayilar2;
             sayilar2[0]=18;

            //sayilar1 ve sayilar2 aynı sayıları içerir ve aynı referans numarasına aittirler.
            //sayilar1= {1,3,5}  referans numarası olmadığı için bellekten silinir.
            Console.WriteLine("sayilar1 [0] = "   + sayilar1[0] );

        }
    }
}
