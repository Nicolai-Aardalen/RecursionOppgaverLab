using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionOppgaverLab
{
    internal class Program
    {
        static int Oppgave1(int n, int m)
        {
            if (n == m)
            {
                return 1;
            }
            else
            {
                m++;
                Console.Write(m + " ");
                return Oppgave1(n, m);
            }
        }
        static int Oppgave2(int i)
        {
            if (i == 1)
            {
                Console.Write(i + " ");
                return 1;
            }
            else
            {
                Console.Write(i + " ");
                return Oppgave2(i - 1);
            }
        }
        static int Oppgave3(int x)
        {
            if (x != 0)
            {
                return x + Oppgave3(x - 1);
            }
            else
            {
                return x;
            }
        }
        static string Oppgave4(string a, int y)
        {
            if (y == a.Length)
            {
                return a;
            }
            else
            {
                Console.Write(a[y] + " ");
                y++;
                return a + Oppgave4(a, y);
            }
        }
        static int Oppgave5(int j, int count)
        {
            if (j.ToString().Length == 1)
            {
                return count + 1;
            }
            else
            {
                int p = int.Parse(j.ToString().Substring(0, j.ToString().Length - 1));
                count++;
                return Oppgave5(p, count);
            }
        }
        static void Main(string[] args)
        {
            ////Oppgave 1
            Console.WriteLine("Enter a lenght to the method");
            int n = Convert.ToInt32(Console.ReadLine());
            Oppgave1(n, 0);
            Console.ReadLine();

            ////Oppgave 2
            Console.WriteLine("Enter a lenght to the method");
            int i = Convert.ToInt32(Console.ReadLine());
            Oppgave2(i);
            Console.ReadLine();

            //Oppgave 3
            Console.WriteLine("Enter a number to find out the sum of all integers");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write(Oppgave3(x));
            Console.ReadLine();

            //Oppgave 4
            Console.WriteLine("Enter in a large number to find the individual integers");
            string inp = Console.ReadLine();
            Console.Write("The digits in number " + inp + " is: ");
            Oppgave4(inp, 0);
            Console.ReadLine();

            //Oppgave 5
            Console.WriteLine("Enter in a number to find ho many integers it includes");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.Write(Oppgave5(j, 0));
            Console.ReadLine();
        }
    }
}
