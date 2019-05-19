using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutProject
{
    /// <summary>
    /// The super class used to represent workingout.
    /// </summary>
    public class Workout
    {
        /// <summary>
        /// The specific behavior of how to lift the weights.
        /// </summary>
        private ILiftWeightBehavior liftWeightBehavior;

        /// <summary>
        /// Initializes an instance of the workout class.
        /// </summary>
        /// <param name="liftWeightBehavior">The specific way in which the weights will be lifted.</param>
        public Workout(ILiftWeightBehavior liftWeightBehavior)
        {
            this.liftWeightBehavior = liftWeightBehavior;
        }
    }
}
