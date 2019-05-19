using System;
using WorkoutProject.FactoryPattern;
using WorkoutProject.StrategyPattern;

namespace WorkoutProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DumbbellFactory dumbbellFactory = new DumbbellFactory();

            Dumbbell dumbbell = dumbbellFactory.createDumbbell(100);
            Dumbbell dumbbellTwo = dumbbellFactory.createDumbbell(25);

            Max max = Max.Instance;
            max.Description();
        }
    }
}
