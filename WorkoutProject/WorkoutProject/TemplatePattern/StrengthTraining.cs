using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutProject.TemplatePattern
{
    /// <summary>
    /// The class used to calculate the best numbers for strength training.
    /// </summary>
    public class StrengthTraining : WorkoutWeightCalculator
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


        public StrengthTraining(double Weight)
        {
            this.weight = Weight;
        }

        /// <summary>
        /// Gets the addend field.    
        /// </summary>
        public override double Addend
        {
            get
            {
                return this.addend;
            }
        }

        /// <summary>
        /// Gets the readonly factor field. 
        /// </summary>
        public override double Factor
        {
            get
            {
                return this.factor;
            }
        }

        /// <summary>
        /// Gets and sets the weight field.    
        /// </summary>
        public override double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                Console.WriteLine("Please enter the heaviest weight you can lift 3-5 times.");

                double userInput = Convert.ToDouble(Console.ReadLine());

                this.weight = userInput;
            }
        }

        //public double CalculateFormula()
        //{
        //    double answer = (Weight * Factor) + Addend;

        //    return answer;
        //}
    }
}
