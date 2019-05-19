using System;
using System.Collections.Generic;
using System.Text;
using WorkoutProject.FactoryPattern;

namespace WorkoutProject
{
    /// <summary>
    /// The class used to represent a heavy dumbbell. Concrete Product Class.
    /// </summary>
    class HeavyDumbbell : Dumbbell
    {
        /// <summary>
        /// The weight of the dumbbell.
        /// </summary>
        private double weight;

        /// <summary>
        /// Initializes a new instance of the HeavyDumbbell class.
        /// </summary>
        /// <param name="weight">The weight of the dumbbell.</param>
        public HeavyDumbbell(double weight)
        {
            this.weight = weight;
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
