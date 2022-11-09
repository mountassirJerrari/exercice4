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
        public void setP1()
    }
}
