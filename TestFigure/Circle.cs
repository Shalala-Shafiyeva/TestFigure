﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    [Serializable()]
    public class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle(List<Point> Points) : base(Points) {  }
        public void FindRadius()
        {
            this.Radius = Math.Sqrt((Points[0].CoordinateX - Points[1].CoordinateX) * (Points[0].CoordinateX - Points[1].CoordinateX)
                + (Points[0].CoordinateY - Points[1].CoordinateY) * (Points[0].CoordinateY - Points[1].CoordinateY));
        }
        public override void FindArea()
        {
            FindRadius();
            this.Area = Math.PI * Radius * Radius;
        }
        public override void FindPerimeter()
        {
            FindRadius();
            this.Perimeter = 2 * Math.PI * Radius;
        }
        public override void MoveFigure(double X, double Y)
        {
            Center.CoordinateX=Center.CoordinateX+X;
            Center.CoordinateY=Center.CoordinateY+Y;
        }

        public override void ScaleFigure(double Scale)
        {
            Radius *= Scale;
            FindArea();
            FindPerimeter();
        }
        public override void RotateFigure(double Degree)
        {
            Console.WriteLine("No matter how you spin it, it's a circle");
        }
        
        public override void FindCenter()
        {
            this.Center = new Point(this.Points[0].CoordinateX, this.Points[0].CoordinateY);
        }
        public override string ToString()
        {
            return $"{nameof(Circle)} Radius: {Radius} Area: {Area} Perimeter:{Perimeter} Center: { Points[0].CoordinateX}, {Points[0].CoordinateY}";
        }

        public override string ToFileString()
        {
            return $"{nameof(Circle)} Points: {this.Points[0]}, {this.Points[1]}; Area: {Area} Perimeter:{Perimeter} Center: {Points[0].CoordinateX}, {Points[0].CoordinateY}";
        }
    }
}
