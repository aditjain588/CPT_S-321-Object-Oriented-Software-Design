// <copyright file="Square.cs" company="Adit Jain">
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
    /// Square shape class.
    /// </summary>
    public class Square : Shapes
    {
        private double shapeSize;

        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> class.
        /// </summary>
        /// <param name="side">side of square. </param>
        public Square(double side)
        {
            this.shapeSize = side;
            this.Area = this.shapeSize * this.shapeSize;
            this.ShapeType = "square";
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
                this.shapeSize = this.ShapeSize;
            }
        }

        /// <summary>
        /// Prints the information association to a shape.
        /// </summary>
        public override void ShapeInfo()
        {
            Console.WriteLine("\tShape type is: " + this.ShapeType);
            Console.WriteLine("\tRadius of square is: " + this.ShapeSize);
            Console.WriteLine("\tArea of square is: " + this.Area);
            Console.WriteLine("\tColor of square is: " + this.Color);
            Console.WriteLine("\tPattern of square is: " + this.Pattern);
            Console.WriteLine("\tThickness of square is: " + this.Thickness);
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
