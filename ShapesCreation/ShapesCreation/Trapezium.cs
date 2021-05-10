// <copyright file="Trapezium.cs" company="Adit Jain">
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
    /// Trapezium shape class.
    /// </summary>
    public class Trapezium : Shapes
    {
        private double height;
        private double firstBase;
        private double groundBase;

        /// <summary>
        /// Initializes a new instance of the <see cref="Trapezium"/> class.
        /// </summary>
        /// <param name="h">height. </param>
        public Trapezium(double h)
        {
            this.height = h;
            this.groundBase = this.height / 2;
            this.firstBase = Math.Round(this.height / 3, 2);
            this.ShapeType = "trapezium";
            this.Area = ((this.firstBase + this.groundBase) / 2) * this.height;
            this.Color = "black";
            this.Pattern = "solid";
            this.Thickness = 3;
        }

        /// <summary>
        /// Prints the information association to a shape.
        /// </summary>
        public override void ShapeInfo()
        {
            Console.WriteLine("\tShape type is: " + this.ShapeType);
            Console.WriteLine("\tHeight of trapezium is: " + this.height);
            Console.WriteLine("\tGround base of trapezium is: " + this.groundBase);
            Console.WriteLine("\tGround base of trapezium is: " + this.firstBase);
            Console.WriteLine("\tArea of trapezium is: " + this.Area);
            Console.WriteLine("\tColor of trapezium is: " + this.Color);
            Console.WriteLine("\tPattern of trapezium is: " + this.Pattern);
            Console.WriteLine("\tThickness of trapezium is: " + this.Thickness);
        }

        /// <summary>
        /// Returns size of a shape.
        /// </summary>
        /// <returns>Size. </returns>
        public override double Size()
        {
            return this.height;
        }
    }
}
