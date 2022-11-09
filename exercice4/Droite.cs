using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace exercice4
{
    internal class Droite
    {
        private Point p1,p2;

        // les constructeurs
        public Droite(float x1, float y1, float x2, float y2)
        {
            p1 = new Point(x1, y1);
            p2 = new Point(x2, y2);
        }
        public Droite(Point p1 , Point p2)
        {
            this.p1 = new Point(p1);
            this.p2 = new Point(p2);
        }
        //setter and getters
        public void setP1(float x, float y)
        {
            p1.setX(x);
            p1.setY(y);
        }
        public void setP2(float x, float y)
        {
            p2.setX(x);
            p2.setY(y);
        }
        public Point getP1()
        {
            return p1;
        }
        public Point getP2()
        {
            return p2;
        }
        //egalité
        public bool isCollinear(Droite d)
        {
           if (Point.islinear(this.p1, this.p2, d.p1) && Point.islinear(this.p1, this.p2, d.p2))
            {
                return true;
            }
            return false;   

        }
        //paralléle
        public bool isParall(Droite d)
        {
            // a1 le coefficient directeur de la droite courant et b1 l'ordonnée à l'origine
            float a1 = (this.p1.getY() - this.p2.getY()) / (this.p1.getX() - this.p2.getX());
            float b1 = this.p1.getY() - a1 * this.p1.getX();
            // a2 le coefficient directeur de la droite d et b2 l'ordonnée à l'origine
            float a2 = (d.p1.getY() - d.p2.getY()) / (d.p1.getX() - d.p2.getX());
            float b2 = d.p1.getY() - a2 * d.p1.getX();
            
            if ((a1*b2-a2*b1)==0)
            {
                return true;
            }

            return false;
        }
        // intersection
        public bool isIntersect(Droite d)
        {
            return !isParall(d);
        }

    }
}
