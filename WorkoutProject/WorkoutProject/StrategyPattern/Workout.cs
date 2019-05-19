using System;
using System.Collections.Generic;
using System.Text;
using WorkoutProject.FactoryPattern;

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

        /// <summary>
        /// The method used to lift dumbbells in a certain way.
        /// </summary>
        /// <param name="dumbbell">The dumbbells being used to workout with.</param>
        public void GoLift(Dumbbell dumbbell)
        {
            string phrase = this.liftWeightBehavior.LiftWeights(dumbbell);

            Console.WriteLine("Working out by " + phrase);
        }
    }
}
