using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutProject.FactoryPattern
{
    /// <summary>
    /// Abstract product class.
    /// </summary>
    public abstract class Dumbbell
    {
        /// <summary>
        /// The weight of the dumbbell.
        /// </summary>
        private double weight;

        /// <summary>
        /// Gets the weight of the dumbbell.
        /// </summary>
        public abstract double Weight { get; }
    }
}
