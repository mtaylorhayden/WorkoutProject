using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutProject.TemplatePattern
{
    /// <summary>
    /// The class used to represent the OneRepMax object. Used to define templates for algorithms calculating a one rep max.
    /// </summary>
    public abstract class WorkoutWeightCalculator
    {
        /// <summary>
        /// Sets the addend.
        /// </summary>
        public abstract double Addend { get; }

        /// <summary>
        /// Sets the factor.
        /// </summary>
        public abstract double Factor { get; }

        /// <summary>
        /// Sets the Weight.
        /// </summary>
        public abstract double Weight { get; set; }

        /// <summary>
        /// The formula used to calculate your workout weights.
        /// </summary>
        /// <returns>Your workout weight.</returns>
        public double CalculateFormula()
        {
            double answer = (Weight * Factor) + Addend;

            return answer;
        }
    }
}
