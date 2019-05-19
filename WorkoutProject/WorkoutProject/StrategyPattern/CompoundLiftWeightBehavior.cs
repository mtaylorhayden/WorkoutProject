using System;
using System.Collections.Generic;
using System.Text;
using WorkoutProject.FactoryPattern;

namespace WorkoutProject
{
    /// <summary>
    /// The class used to represent LightLiftWeightBehavior. Contains an algorithm for the behavior.
    /// </summary>
    class CompoundLiftWeightBehavior : ILiftWeightBehavior
    {
        /// <summary>
        /// Lifts the weights in a compound manner.
        /// </summary>
        /// <param name="dumbell">The dumbbell being lifted.</param>
        public string LiftWeights(Dumbbell dumbell)
        {
            string phrase = "doing compound movements with dumbbells that weigh " + dumbell.Weight;

            return phrase;
        }
    }
}
