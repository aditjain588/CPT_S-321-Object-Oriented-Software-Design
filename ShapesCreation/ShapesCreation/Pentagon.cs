// <copyright file="Pentagon.cs" company="Adit Jain">
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
    /// Pentagon shape class.
    /// </summary>
    public class Pentagon : Shapes
    {
        private double side;

        /// <summary>
        /// Initializes a new instance of the <see cref="Pentagon"/> class.
        /// </summary>
        /// <param name="s">side. </param>
        public Pentagon(double s)
        {
            this.side = s;
            this.ShapeType = "pentagon";
            this.Area = Math.Round(0.25 * Math.Sqrt(5 * (5 + (2 * Math.Sqrt(5)))) * this.side * this.side, 2);
            this.Color = "black";
            this.Pattern = "solid";
            this.Thickness = 3;
        }

        /// <summary>
        /// gets or sets value of side.
        /// </summary>
        public double Side
        {
            get
            {
                return this.side;
            }

            set
            {
                this.side = value;
            }
        }

        /// <summary>
        /// Prints the information association to a shape.
        /// </summary>
        public override void ShapeInfo()
        {
            Console.WriteLine("\tShape type is: " + this.ShapeType);
            Console.WriteLine("\tSide of pentagon is: " + this.side);
            Console.WriteLine("\tArea of pentagon is: " + this.Area);
            Console.WriteLine("\tColor of pentagon is: " + this.Color);
            Console.WriteLine("\tPattern of pentagon is: " + this.Pattern);
            Console.WriteLine("\tThickness of pentagon is: " + this.Thickness);
        }

        /// <summary>
        /// Returns size of a shape.
        /// </summary>
        /// <returns>Size. </returns>
        public override double Size()
        {
            return this.side;
        }
    }
}
