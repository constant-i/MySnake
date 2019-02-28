﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool IsHit (Figure figure)
        {
            foreach (Point p in pList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }

        internal bool IsHit (Point point)
        {
            foreach  (Point p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }

    }
}
