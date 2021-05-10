// <copyright file="Rectangle.cs" company="Adit Jain">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FinalExam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Rectangle shape class.
    /// </summary>
    public class Rectangle : Shapes
    {
        private double length;
        private double breadth;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="shapeSize">size. </param>
        public Rectangle(double shapeSize)
        {
            this.length = shapeSize;
            this.breadth = shapeSize * 0.5;
            this.Area = this.length * this.breadth;
            this.ShapeType = "rectangle";
            this.Color = "black";
            this.Pattern = "solid";
            this.Thickness = 3;
        }

        /// <summary>
        /// gets or sets length of a rectanlge.
        /// </summary>
        public double Length
        {
            get
            {
                return this.length;
            }

            set
            {
                this.length = value;
            }
        }

        /// <summary>
        /// gets or sets breadth of rectabgle.
        /// </summary>
        public double Breadth
        {
            get
            {
                return this.breadth;
            }

            set
            {
                this.breadth = value;
            }
        }

        /// <summary>
        /// Prints the information association to a shape.
        /// </summary>
        public override void ShapeInfo()
        {
            Console.WriteLine("\tShape type is: " + this.ShapeType);
            Console.WriteLine("\tLength of rectangle is: " + this.length);
            Console.WriteLine("\tBreadth of rectangle is: " + this.breadth);
            Console.WriteLine("\tArea of rectangle is: " + this.Area);
            Console.WriteLine("\tColor of rectangle is: " + this.Color);
            Console.WriteLine("\tPattern of rectangle is: " + this.Pattern);
            Console.WriteLine("\tThickness of rectangle is: " + this.Thickness);
        }

        /// <summary>
        /// Returns size of a shape.
        /// </summary>
        /// <returns>Size. </returns>
        public override double Size()
        {
            return this.length;
        }
    }
}
