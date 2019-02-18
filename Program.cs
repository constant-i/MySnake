using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Program
	{
		static void Main( string[] args )
		{
			int x = 1;
			Func1( x );
			Console.WriteLine( "Call Func1. x = " + x );

            x = 1;
			Func2( x );
			Console.WriteLine( "Call Func2. x = " + x );

			x = 1;
			Func3( x );
			Console.WriteLine( "Call Func3. x = " + x );

			Point p1 = new Point( 1, 3, '*' );
			Move( p1, 10, 10 );
			Console.WriteLine( "Call Move. p1.x = " + p1.x + ", p1.y = " + p1.y );

			Point p2 = new Point( 4, 5, '#' );
			p1 = p2;
			p2.x = 8;
			p2.y = 8;
			Console.WriteLine( "p1 = p2. p1.x = " + p1.x + ", p1.y = " + p1.y + "; p2.x = " + p2.x + ", p2.y = " + p2.y );

			p1 = new Point( 1, 3, '*' );
			Update( p1 );
			Console.WriteLine( "Call Update. p1.x = " + p1.x + ", p1.y = " + p1.y );
            Console.WriteLine("after update");

            Point p3;
            p3 = Make(6,7,'y');

            Console.WriteLine("\n\r After Call Make. p3.x = " + p3.x + ", p1.y = " + p3.y);
            p3.Draw();

            Console.ReadLine();
		}

		public static void Func1( int value )
		{
            Console.WriteLine("value in Func1 " + value);
        }

		public static void Func2( int value )
		{
            Console.WriteLine("value in Func2 before " + value);
			value = value + 1;
            Console.WriteLine("value in Func2 AFTER " + value);
        }

		public static void Func3( int x )
		{
            Console.WriteLine("x in Func3 before " + x);
            x = x + 1;
            Console.WriteLine("x in Func3 after " + x);
        }

		public static void Move( Point p, int dx, int dy )
		{
			p.x = p.x + dx;
			p.y = p.y + dy;
		}

		public static void Update( Point p )
		{
            Console.WriteLine("\n\r inside Update");
            Console.WriteLine("before changing p.x = " + p.x + ", p.y = " + p.y);

            p.x++;
            p.y++;
            p.sym = 't';
            Console.WriteLine("p has changed p.x = " + p.x + ", p.y = " + p.y);

            p = new Point();
            Console.WriteLine("\n\r after new");
            Console.WriteLine("p.x = " + p.x + ", p.y = " + p.y);

        }

        public static Point Make(int x, int y, char symb)
        {
            Console.WriteLine("\n\r inside Make");
            Point p;
            p = new Point(x, y, symb);
            Console.WriteLine("\n\r after new");
            Console.WriteLine("p.x = " + p.x + ", p.y = " + p.y);
            return p;
        }
    }
}
