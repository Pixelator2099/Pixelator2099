using System;

namespace Hello
{
    public class test : bas
    {
        static void Main()
        {

            ScreenTitle("Consola V1");
            Screen(ConsoleColor.DarkBlue, ConsoleColor.White);
            Cls();


            int x = 0;
            int y = 0;
            int c = 0;

            // Hello
            for (x = 0; x <= 15; x++)
            {
                ForeColor(x);
                Locate(1 + x, 1 + x);
                Print("Hello");
            }

            // Hello Numbers
            for (x = 0; x <= 25; x++)
            {
                c++;
                if (c > 15) c = 0;

                for (y = 0; y <= 10; y += 2)
                {
                    ForeColor(c);
                    Locate(x + 10, y+30);
                    Print(x);
                }
            }


            Wait();
        }



    }

}