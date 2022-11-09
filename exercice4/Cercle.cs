﻿using System;
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



    }
}
