using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutProject.StrategyPattern
{
    /// <summary>
    /// The class used to represent the Max object. 
    /// </summary>
    public sealed class Max : Person
    {
        /// <summary>
        /// The age of Max.
        /// </summary>
        private int age = 24;

        /// <summary>
        /// The weight of Max.
        /// </summary>
        private double weight = 175;

        /// <summary>
        /// The height of Max.
        /// </summary>
        private double height = 5.11;

        /// <summary>
        /// Initializes a new instance of the Max class.
        /// </summary>
        private Max() { }

        /// <summary>
        /// Checks for thread saftey and support for lazy initialization.
        /// </summary>
        private static readonly Lazy<Max>
            max = new Lazy<Max>(() => new Max());

        /// <summary>
        /// Gets the instance of max created.
        /// </summary>
        public static Max Instance
        {
            get
            {
                return max.Value;
            }
        }

        /// <summary>
        /// The description of the Max object.
        /// </summary>
        public override void Description()
        {
            Console.WriteLine("Max wants to lift some weights!");
        }
    }
}
