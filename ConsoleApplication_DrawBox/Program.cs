using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_DrawBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter box length in #x# format: ");
            string x = Console.ReadLine();

            if (x.IndexOf("x") > 0)
            {
                string[] strSplit = x.Split('x');

                int intWidth = Convert.ToInt32(strSplit[0].Trim());
                int intHeight = Convert.ToInt32(strSplit[1].Trim());

                Console.WriteLine("You entered: " + intWidth + " x " + intHeight);

                for (int h = 1; h <= intHeight; h++)
                {
                    for (int w = 1; w <= intWidth; w++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            } else
            {
                Console.WriteLine("The format you entered is incorrect!");
            }
            Console.WriteLine("Press any key to quit. (Where's the any key?)");
            Console.ReadKey();
        }
    }
}
