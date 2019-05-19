using System;
using WorkoutProject.FactoryPattern;

namespace WorkoutProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DumbbellFactory dumbbellFactory = new DumbbellFactory();

            Dumbbell dumbbell = dumbbellFactory.createDumbbell(100);
            Dumbbell dumbbellTwo = dumbbellFactory.createDumbbell(25);

        }
    }
}
