using System;

namespace GeneticReconfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Genetic Algorithm for Distribution Reconfiguration");
            
            // Initialize the network model
            NetworkModel model = new NetworkModel();

            // Create and run the genetic algorithm
            GAReconfiguration ga = new GAReconfiguration();
            Chromosome bestSolution = ga.Run(model);

            // Display the best solution found
            Console.WriteLine("Optimal Configuration Found:");
            // TODO: Print details of the bestSolution.
        }
    }
}
