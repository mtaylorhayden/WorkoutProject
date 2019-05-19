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

            HeavyLiftWeightBehavior heavyLiftWeight = new HeavyLiftWeightBehavior();
            LightLiftWeightBehavior lightLiftWeight = new LightLiftWeightBehavior();

            Max max = Max.Instance;
            max.Description();

            Workout workout = new Workout(heavyLiftWeight);
            
            max.LiftWeights(workout, dumbbellOne);
            max.LiftWeights(workout, dumbbellTwo);

            workout = new Workout(lightLiftWeight);

            max.LiftWeights(workout, dumbbellTwo);
        }
    }
}
