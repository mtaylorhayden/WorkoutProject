using System;
using System.Collections.Generic;
using System.Text;
using WorkoutProject.FactoryPattern;

namespace WorkoutProject
{
    /// <summary>
    /// The class used to represent LightLiftWeightBehavior. Contains an algorithm for the behavior.
    /// </summary>
    public class LightLiftWeightBehavior : ILiftWeightBehavior
    {
        /// <summary>
        /// Lifts the weights in a light manner.
        /// </summary>
        /// <param name="dumbell">The dumbbell being lifted.</param>
        public void LiftWeights(Dumbbell dumbell)
        {
            Console.Write("Lifts lighter dumbbells");
        }
    }
}
