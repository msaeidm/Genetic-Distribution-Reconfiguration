using System;

namespace GeneticReconfiguration
{
    public static class FuzzyMembership
    {
        // Example fuzzy membership function for a minimization objective.
        // It normalizes an objective value to the range [0, 1].
        public static double CalculateMembership(double objectiveValue, double worstValue, double bestValue)
        {
            if (objectiveValue >= worstValue)
                return 0;
            if (objectiveValue <= bestValue)
                return 1;
            // Linear membership function:
            return (worstValue - objectiveValue) / (worstValue - bestValue);
        }
    }
}
