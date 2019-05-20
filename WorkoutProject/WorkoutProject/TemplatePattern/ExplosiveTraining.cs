using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutProject.TemplatePattern
{
    /// <summary>
    /// The class used to calculate the best numbers for explosive training. 
    /// </summary>
    public class ExplosiveTraining : WorkoutWeightCalculator
    {
        /// <summary>
        /// The number multiplied by the weight lifted 3-5 times.
        /// </summary>
        private readonly double factor = 1.1307;

        /// <summary>
        /// The amount of weight you can lift 3-5 times.
        /// </summary>
        private double weight;

        /// <summary>
        /// The number added to the end of the formula.
        /// </summary>
        private readonly double addend = 0.6998;

        public ExplosiveTraining()
        {

        }

        public override double Addend => throw new NotImplementedException();

        public override double Factor => throw new NotImplementedException();

        public override double Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override double AssistFormula(double answer)
        {
            throw new NotImplementedException();
        }
    }
}
