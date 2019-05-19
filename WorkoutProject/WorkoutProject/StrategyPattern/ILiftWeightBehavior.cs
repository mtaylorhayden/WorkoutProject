using System;
using System.Collections.Generic;
using System.Text;
using WorkoutProject.FactoryPattern;

namespace WorkoutProject
{
    /// <summary>
    /// The interface used to implement the strategy patern.
    /// </summary>
    public interface ILiftWeightBehavior
    {
        /// <summary>
        /// The method used to lift weights.
        /// </summary>
        /// <param name="dumbell">The dumbbell being lifted.</param>
        string LiftWeights(Dumbbell dumbell);
    }
}
