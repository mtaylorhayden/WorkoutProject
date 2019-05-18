using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutProject
{
    /// <summary>
    /// The class used to represent LightLiftWeightBehavior. Contains an algorithm for the behavior.
    /// </summary>
    class HeavyLiftWeightBehavior : ILiftWeightBehavior
    {
        /// <summary>
        /// Lifts the weights in a heavy manner.
        /// </summary>
        /// <param name="dumbell">The dumbbell being lifted.</param>
        public void LiftWeights(Dumbbell dumbell)
        {
            Console.Write("Lifts heavier dumbbells");
        }
    }
}
