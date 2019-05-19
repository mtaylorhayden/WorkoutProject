using System;
using System.Collections.Generic;
using System.Text;
using WorkoutProject.FactoryPattern;

namespace WorkoutProject
{
    /// <summary>
    /// Concrete Product class.
    /// </summary>
    class LightDumbbell : Dumbbell
    {

        /// <summary>
        /// The weight of the dumbbell.
        /// </summary>
        private double weight;

        /// <summary>
        /// Initializes a new instance of the HeavyDumbbell class.
        /// </summary>
        /// <param name="weight">The weight of the dumbbell.</param>
        public LightDumbbell(double weight)
        {
            this.weight = weight;
            Console.WriteLine("A light dumbbell!");
        }

        /// <summary>
        /// Gets the weight of the dumbbell.
        /// </summary>
        public override double Weight
        {
            get
            {
                return this.weight;
            }
        }
    }
}
