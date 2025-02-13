using System;
using System.Collections.Generic;

namespace GeneticReconfiguration
{
    public class GAReconfiguration
    {
        public List<Chromosome> Population { get; set; }
        public int PopulationSize { get; set; } = 100;
        public int Generations { get; set; } = 300;
        public double MutationRate { get; set; } = 0.05;
        
        public GAReconfiguration()
        {
            Population = new List<Chromosome>();
        }
        
        // Initialize the population with random chromosomes
        public void InitializePopulation()
        {
            for (int i = 0; i < PopulationSize; i++)
            {
                Chromosome chrom = new Chromosome();
                // TODO: Randomly initialize network configuration, DG locations, and sizes.
                Population.Add(chrom);
            }
        }

        // Evaluate each chromosome using the fuzzy membership functions and network model.
        public void EvaluatePopulation(NetworkModel model)
        {
            foreach (var chrom in Population)
            {
                // TODO: Calculate objective values (power loss, voltage deviation, etc.)
                // Example: double powerLoss = model.CalculatePowerLoss(chrom);
                // Fuzzify each objective
                // Example: double fuzzyPowerLoss = FuzzyMembership.CalculateMembership(powerLoss, worst, best);
                // Aggregate fuzzy scores to get overall fitness.
                chrom.Fitness = /* aggregated fuzzy score */;
            }
        }

        // Main genetic algorithm loop.
        public Chromosome Run(NetworkModel model)
        {
            InitializePopulation();
            EvaluatePopulation(model);

            for (int gen = 0; gen < Generations; gen++)
            {
                // Selection, crossover, and mutation steps.
                var newPopulation = GeneticOperators.Selection(Population);
                newPopulation = GeneticOperators.Crossover(newPopulation);
                GeneticOperators.Mutate(newPopulation, MutationRate);

                Population = newPopulation;
                EvaluatePopulation(model);
                
                Console.WriteLine($"Generation {gen + 1}: Best Fitness = {GetBestChromosome().Fitness:F4}");
            }

            return GetBestChromosome();
        }

        private Chromosome GetBestChromosome()
        {
            Chromosome best = Population[0];
            foreach (var chrom in Population)
            {
                if (chrom.Fitness > best.Fitness)
                    best = chrom;
            }
            return best;
        }
    }
}
