using System;
using System.Collections.Generic;
using System.Text;
using WorkoutProject.FactoryPattern;

namespace WorkoutProject
{
    /// <summary>
    /// The class used to represent a HeavyDumbbellFactory. Used to create HeavyDumbbells. The concrete creator class.
    /// </summary>
    public class DumbbellFactory : IDumbbellFactory
    {
        /// <summary>
        /// Creates a dumbbell.
        /// </summary>
        /// <returns> The heavy dumbbell.</returns>
        public Dumbbell createDumbbell(double weight)
        {
            Dumbbell dumbbell;

            //Logic check for a heavy or light dumbbell?
            if (weight >= 50)
            {
                dumbbell = new HeavyDumbbell(weight);
            }
            else
            {
                dumbbell = new LightDumbbell(weight);
            }

            return dumbbell;
        }
    }
}
