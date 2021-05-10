// <copyright file="Circle.cs" company="Adit Jain">
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
    /// Circle shape class.
    /// </summary>
    public class Circle : Shapes
    {
        private double shapeSize;

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">size. </param>
        public Circle(double radius)
        {
            this.ShapeSize = radius;
            this.Area = Math.Round(Math.PI * this.shapeSize * this.shapeSize, 2);
            this.ShapeType = "circle";
            this.Color = "black";
            this.Pattern = "solid";
            this.Thickness = 3;
        }

        /// <summary>
        /// Gets or sets the size of circle.
        /// </summary>
        public double ShapeSize
        {
            get
            {
                return this.shapeSize;
            }

            set
            {
                this.shapeSize = value;
            }
        }

        /// <summary>
        /// Prints the information association to a shape.
        /// </summary>
        public override void ShapeInfo()
        {
            Console.WriteLine("\tShape type is: " + this.ShapeType);
            Console.WriteLine("\tRadius of circle is: " + this.ShapeSize);
            Console.WriteLine("\tArea of circle is: " + this.Area);
            Console.WriteLine("\tColor of circle is: " + this.Color);
            Console.WriteLine("\tPattern of circle is: " + this.Pattern);
            Console.WriteLine("\tThickness of circle is: " + this.Thickness);
        }

        /// <summary>
        /// Returns size of a shape.
        /// </summary>
        /// <returns>Size. </returns>
        public override double Size()
        {
            return this.shapeSize;
        }
    }
}
