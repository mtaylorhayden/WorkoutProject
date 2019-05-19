using System;
using System.Collections.Generic;
using System.Text;
using WorkoutProject.FactoryPattern;

namespace WorkoutProject
{
    /// <summary>
    /// The class used to represent a HeavyDumbbellFactory. Used to create HeavyDumbbells. The concrete creator class.
    /// </summary>
    public class HeavyDumbbellFactory : IDumbbellFactory
    {
        /// <summary>
        /// Creates a dumbbell.
        /// </summary>
        /// <returns> The heavy dumbbell.</returns>
        public Dumbbell createDumbbell(double weight)
        {
            Dumbbell heavyDumbbell = new HeavyDumbbell(weight);

            return heavyDumbbell;
        }
    }
}
