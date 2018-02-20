﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle

{

    public class Rectangle

    {

        public float Height, Width, Area, Perimeter;

        public Rectangle()

        {

            Height = 0;

            Width = 0;

            Area = 0;

            Perimeter = 0;

        }

        public float FindArea(float h, float w)

        {

            return h * w;

        }

        public float FindPerimeter(float h, float w)

        {

            return (h + w) * 2;

        }

        public Rectangle(float h, float w)

        {

            Height = h;

            Width = w;

            Area = FindArea(h, w);

            Perimeter = FindPerimeter(h, w);

        }

        public override string ToString()

        {

            return Area + " " + Perimeter;

        }

    }







    class Program

    {

        static void Main(string[] args)

        {

            Rectangle R = new Rectangle(2, 4);

            Console.WriteLine(R.ToString());

            {
                Console.ReadKey();
            }
        }

    }

}
