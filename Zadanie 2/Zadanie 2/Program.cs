using System;

namespace Zadanie_2
{
    class Program
    {
      
         public static long SilniaRekurencyjna (int liczba){
            if(liczba > 1){
                return liczba * SilniaRekurencyjna(liczba - 1);
            }else{
                return 1;
            }
        }
        public static long SilniaIteracyjnie (int liczba){
            long silnia = 1;

            for ( int i = 1 ; i <=liczba ; i ++  ){
                silnia*=i;
            }
            return silnia;
        }
        static void Main(string[] args)
        {
              long x = SilniaIteracyjnie(8);  
              long  s = SilniaRekurencyjna(8);
        }
    }
}
