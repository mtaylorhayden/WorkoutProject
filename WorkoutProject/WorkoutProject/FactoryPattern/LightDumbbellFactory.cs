using System;
using System.Collections.Generic;
using System.Text;
using WorkoutProject.FactoryPattern;

namespace WorkoutProject
{
    /// <summary>
    /// The class used to represent a LightDumbbellFactory. Used to create lightDumbbells. Concrete creator class.
    /// </summary>
    public class LightDumbbellFactory : IDumbbellFactory
    {
        /// <summary>
        /// Creates a dumbbell.
        /// </summary>
        /// <returns> The light dumbbell.</returns>
        public Dumbbell createDumbbell(double weight)
        {
            Dumbbell lightDumbbell = new LightDumbbell(weight);

            return lightDumbbell;
        }
    }
}
