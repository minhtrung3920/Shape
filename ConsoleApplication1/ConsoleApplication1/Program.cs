using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draw
{
    class Program
    {
        static void Main(string[] args)
        {
            //Horizone(10, '*'); Console.WriteLine();
            //Vertical(10, '@'); Console.WriteLine();

            int number = Convert.ToInt32(Console.ReadLine());
            DrawShape(number, 'x');
            Console.WriteLine();
            CreateN(number, 'x');
            DrawShape2(number, 'x');
        }
        static void Horizone(int number, char c)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(c);
            }
        }
        static void Vertical(int number, char c)
        {
            for (int i = 0; i < number; i++)
            {
                Horizone(i, '/');
                Console.WriteLine(c);
            }
        }

        //fir line : n- 1 spaces, 1 star
        // sec line: n-2 spaces, 1 star,  1 star, 1 star
        //third line: n-3 spaces, 1 star, 3 spaces, 1 star
        // four line: n-4 spaces, 1star, 4 space, 1 star
        //last: 2n-1 spaces stars

        static void DrawShape(int number, char c)
        {
            //firstline
            Horizone(number - 1, ' ');
            Horizone(1, c);
            Console.WriteLine();
            //n-line
            int line = 1, space = number + 1;
            for (int i = 1; i < number; i++)
            {
                line = line + 1;
                Horizone(number - line, ' ');
                Horizone(1, c);
                space = space - 2;
                Horizone(number - space, ' ');
                Horizone(1, c);
                Console.WriteLine();
            }
            //lastline
            Horizone(number * 2 - 1, c);
        }
        static void CreateN(int number, char c)
        {

        }
        static void DrawShape2(int number, char c)
        {
            //fristline
            Horizone(number * 2 - 1, c);
            Console.WriteLine();
            //n-line
            int space = number + number / 2 + 1;
            for (int i = number - 1; i > 1; i--)
            {
                Horizone(number - i, ' ');
                Horizone(1, c);
                space = space - 2;
                Horizone(space, ' ');
                Horizone(1, c);
                Console.WriteLine();
            }
            //lastline
            Horizone(number - 1, ' ');
            Horizone(1, c);
            Console.WriteLine();
        }
    }
}
