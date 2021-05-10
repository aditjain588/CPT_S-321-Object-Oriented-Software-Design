// <copyright file="Shapes.cs" company="Adit Jain">
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
    /// Abstarct class for shapes.
    /// </summary>
    public abstract class Shapes
    {
        /// <summary>
        /// Gets or sets the area of particular shape.
        /// </summary>
        public double Area { get; set; }

        /// <summary>
        /// Gets or sets the type of particular shape.
        /// </summary>
        public string ShapeType { get; set; }

        /// <summary>
        /// gets or sets color of a particular shape.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// gets or sets thickness of a particular shape.
        /// </summary>
        public double Thickness { get; set; }

        /// <summary>
        /// gets or sets pattern of a particular shape.
        /// </summary>
        public string Pattern { get; set; }

        /// <summary>
        /// Prints the information association to a shape.
        /// </summary>
        public abstract void ShapeInfo();

        /// <summary>
        /// Returns size of a shape.
        /// </summary>
        /// <returns>Size. </returns>
        public abstract double Size();
    }
}
