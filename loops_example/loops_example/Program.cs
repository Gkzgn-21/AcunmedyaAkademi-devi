using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops_example
{
    class Program
    {
        #region While loop
        static void Main()
        {
            int sayi = 5;

            Console.WriteLine("While döngüsü:");
            while (sayi < 5) // Koşul baştan yanlış, döngü hiç çalışmaz.
            {
                Console.WriteLine("Bu satır çalışmaz.");
            }
        }

    }

}
#endregion

class Program
{
    #region Do-While Loop
    static void Main()
    {
        int sayi = 5;

        Console.WriteLine("Do-While döngüsü:");
        do
        {
            Console.WriteLine("Bu satır en az bir kez çalışır.");
        } while (sayi < 5); // Koşul yanlış olsa bile ilk tur çalışır.
    }
}

#endregion