using System;
using WorkoutProject.FactoryPattern;
using WorkoutProject.StrategyPattern;
using WorkoutProject.TemplatePattern;

namespace WorkoutProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demonstrates using the Factory Pattern, Strategy Pattern, and the Singleton Pattern. 
            DumbbellFactory dumbbellFactory = new DumbbellFactory();

            Dumbbell dumbbellOne = dumbbellFactory.createDumbbell(100);
            Dumbbell dumbbellTwo = dumbbellFactory.createDumbbell(25);

            CompoundLiftWeightBehavior compoundLiftWeight = new CompoundLiftWeightBehavior();
            AccessoryLiftWeightBehavior accessoryLiftWeight = new AccessoryLiftWeightBehavior();

            Max max = Max.Instance;
            max.Description();

            Workout workout = new Workout(compoundLiftWeight);
            
            max.LiftWeights(workout, dumbbellOne);
            max.LiftWeights(workout, dumbbellTwo);

            workout = new Workout(accessoryLiftWeight);

            max.LiftWeights(workout, dumbbellTwo);

            Console.WriteLine("Please enter the heaviest weight you can lift 3-5 times.");

            double userInput = Convert.ToDouble(Console.ReadLine());

            StrengthTraining test = new StrengthTraining(userInput);
            double answer = test.CalculateFormula();

            Console.WriteLine(Math.Round(answer, 0) + "lbs");

        }
    }
}
