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
            p1.Draw();
            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine hLine1 = new HorizontalLine(5, 10, 5, 'Y');
            hLine1.Draw();

            VerticalLine vLine = new VerticalLine(0, 1, 10, 'U');
            vLine.Draw();

            Console.Read();
        } 
    }
}
