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

        /// <summary>
        /// Initializes a new instance of the StrengthTraining class. 
        /// </summary>
        /// <param name="Weight">The heaviest weight you can lift 3-5 times.</param>
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

        /// <summary>
        /// Multiplies the number by the specific number needed to calculate strength.
        /// </summary>
        /// <param name="answer">The result of the formula</param>
        /// <returns>The solution to the formula.</returns>
        public override double AssistFormula(double answer)
        {
            double solution = answer * .9;

            return solution;
        }
    }
}
