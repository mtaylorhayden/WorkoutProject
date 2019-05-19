using System;
using WorkoutProject.FactoryPattern;
using WorkoutProject.StrategyPattern;

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
        }
    }
}
