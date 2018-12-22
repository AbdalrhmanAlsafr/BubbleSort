using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
    
        public static void diziyedegerat()
        {
            Random uretec = new Random();
           
            for(int i=0;i<dizi.Length;i++)
            {
                dizi[i] = uretec.Next(20,50);
            }
        }
        public static int[] dizi = new int[10];
        public static void dizisirala()
        {
            int uzn = dizi.Length;
            int temp;
            for (int outer = uzn; outer >= 1; outer--)
            {
                for (int inner = 0; inner < outer - 1; inner++)
                    if ((int)dizi[inner] > dizi[inner + 1])
                    {
                        temp = dizi[inner];
                        dizi[inner] = dizi[inner + 1];
                        dizi[inner + 1] = temp;
                    }
               
            }
        }
        
        static void Main(string[] args)
        {
           
            diziyedegerat();
            Console.WriteLine("işlem biti");
            dizisirala();
            

            for (int i=0;i<dizi.Length;i++)
            {
                Console.WriteLine(dizi[i]);
            }
            Console.ReadLine();
        }








    }
}
