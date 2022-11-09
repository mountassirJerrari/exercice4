using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice4
{
    internal class Cercle
    {

        private Point center;
        private float r;
        public Cercle( Point center, float r)
        {
            this.center =new  Point(center);
            this.r = r;
        }
        public Cercle(float x1, float y1, float r)
        {
            this.center = new Point(x1, y1);
            this.r = r;
        }
        //setters and getters
        public void setCenter(Point p)
        {
            this.center.setX(p.getX());
            this.center.setY(p.getY());
        }
        public void setR(float r)
        {
            this.r = r;
        }
        public Point getCenter()
        {
            return this.center;
        }
        public float getR()
        {
            return this.r;
        }
        //egalité 
        public bool isEqual(Cercle cercle)
        {
            if (this.center.isEqual(cercle.getCenter()) && r==cercle.getR())
            {
                return true;
            }
            return false;

        }
        //intersection
        public bool isItersected(Cercle cercle)
        {

            if (Math.Sqrt((center.getX() - cercle.getCenter().getX())*(center.getX() - cercle.getCenter().getX())+ (center.getX() - cercle.getCenter().getX()) * (center.getY() - cercle.getCenter().getY()))<=r+cercle.r)   
                    return true;
            return false;

        }
        //Circumference 
        public float circumference()
        {
            return 3.14159265359f * 2 * r;

        }
        //aire  
        public float aire()
        {
            return 3.14159265359f * r * r;

        }


    }
}
