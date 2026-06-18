using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();

            activities.Add(new Running(new DateTime(2026, 6, 18), 30, 5.0));
            activities.Add(new Cycling(new DateTime(2026, 6, 18), 45, 20.0));
            activities.Add(new Swimming(new DateTime(2026, 6, 18), 40, 30));

            foreach (Activity a in activities)
            {
                Console.WriteLine(a.GetSummary());
            }
        }
    }
}