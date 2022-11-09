using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice4
{
    internal class Point
    {
        private float x, y;
        //constructeur
        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
        }
        //setters and getters
        public void setX(float x)
        {
            this.x = x;
        }
        public float getX()
        {
            return this.x;
        }
        public void setY(float y)
        {
            this.y = y;
        }
        public float getY()
        {
            return this.y;
        }
        //egalité
        public bool isEqual(Point p)
        {
            if (p.x == this.x && p.y == this.y)
            {
                return true;
            }
            return false;
        }
        //translation
        public void translate(int k)
        {
            setX(k * this.x);
            setY(k * this.y);
        }
        //la linearité
        static public bool islinear(Point p1, Point p2, Point p3)
        {
            float a = (p1.y - p2.y) / (p1.x - p2.x);
            float b = p1.y - a * p1.x;
            if (p3.y == a * p3.x + b)
            {
                return true;
            }

            return false;

        }

    }
}
