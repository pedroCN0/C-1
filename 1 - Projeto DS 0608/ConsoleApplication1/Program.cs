using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ETEC JK (Vulgo Eteco JFlinston)");
            Console.WriteLine("Digite sua idade:");
            int a, i;
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Sua idade é de: " + a);
            Console.WriteLine("Os números digitados foram: {0}", a);
            i = 0;
            while(i < 20)
            {
                //for (i=0; i<0; i++)
                //{
                    if (a >= 18)
                    {
                        Console.WriteLine("Você é de maior");
                    }
                    else
                    {
                        Console.WriteLine("Você é de menor");
                    }
                //Console.ReadKey();
                //}
            }       
            //Console.ReadKey();
        }
    }
}