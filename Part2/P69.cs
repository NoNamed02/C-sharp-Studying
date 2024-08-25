﻿using System;

namespace P69 // 속성
{
    class Rectangle
    {
        private double width;
        private double height;

        public double GetWidth() { return width; }
        public double GetHeight() { return height; }

        public void SetWidth(double w) { if (w > 0) width = w; }
        public void SetHeight(double h) { if (h > 0) height = h; }
    }

    class RectWithProp
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    class RectWithPropFull
    {
        private double width;
        public double Width { get { return width; } set { if (value > 0) width = value; } }

        private double height;
        public double Height { get { return height; } set { if (value > 0) height = value; } }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.SetWidth(10.0);
            r.SetHeight(10.0);
            Console.WriteLine($"r의 면적 {r.GetWidth() * r.GetHeight()}");

            RectWithProp r1 = new RectWithProp();
            r1.Width = 10.0;
            r1.Height = 10.0;
            Console.WriteLine($"r1의 면적 {r1.Width * r1.Height}");

            RectWithPropFull r2 = new RectWithPropFull();
            r2.Width = 10.0;
            r2.Height = 10.0;
            Console.WriteLine($"r2의 면적 {r2.Width * r2.Height}");

            RectWithPropFull r3 = new RectWithPropFull();
            r3.Width = 10.0;
            r3.Height = -10.0;
            Console.WriteLine($"r2의 면적 {r3.Width * r3.Height}");
        }
    }
}
