using System;
using WorkoutProject.FactoryPattern;

namespace WorkoutProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Dumbbell d = new HeavyDumbbell(100);
        }
    }
}
