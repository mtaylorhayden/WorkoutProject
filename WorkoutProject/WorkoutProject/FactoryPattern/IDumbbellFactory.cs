using System;
using System.Collections.Generic;
using System.Text;
using WorkoutProject.FactoryPattern;

namespace WorkoutProject
{
    /// <summary>
    /// The class used to represent the IDumbbellFactory interace. The "abstract" creator class.
    /// </summary>
    public interface IDumbbellFactory
    {
        /// <summary>
        /// The factory method used to create the dumbbells.
        /// </summary>
        /// <returns>The newly created dumbbell.</returns>
        Dumbbell createDumbbell(double weight);
    }
}
