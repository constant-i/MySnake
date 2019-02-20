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

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            rightLine.Draw();
            leftLine.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            Point p2 = new Point(12,12, '2');
            Snake snake2 = new Snake(p2, 6, Direction.UP);
            snake2.Draw();

            Point p3 = new Point(13, 12, '3');
            Snake snake3 = new Snake(p3, 6, Direction.DOWN);
            snake3.Draw();

            Point p4 = new Point(11, 12, '4');
            Snake snake4 = new Snake(p4, 6, Direction.LEFT);
            snake4.Draw();

            Console.Read();
        } 
    }
}
