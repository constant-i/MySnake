using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80,25);

            Point p1 = new Point(1, 3, '*');           
            //p1.Draw();
            Point p2 = new Point(4, 5, '#');
            //p2.Draw();
            Point p3 = new Point(6, 4, 'r');
            Point p4 = new Point(3, 2, 'L');
            Point p5 = new Point(8, 8, '№');

            List<int> numList = new List<int>();
            numList.Add(3);
            numList.Add(4);
            numList.Add(5);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            Console.WriteLine();
            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            numList.RemoveAt(0);
            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            //List<Point> pList = new List<Point>();

            List<Point> pList = new List<Point>();
            List<char> chList = new List<char>();

            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            pList.Add(p5);

            foreach (Point p in pList)
            {
                p.Draw();
            }


            foreach (Point p in pList)
            {
                chList.Add(p.sym);
            }

            Console.SetCursorPosition(0,10);
            foreach (char sym in chList)
            {
                Console.WriteLine(sym);
            }

            Console.Read();
        } 
    }
}
