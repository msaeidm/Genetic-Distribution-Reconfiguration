# Genetic-Distribution-Reconfiguration

This repository contains an implementation of a genetic algorithm for multi-objective reconfiguration of balanced and unbalanced distribution systems in a fuzzy framework. The project is based on the concepts described in the paper:

**A Genetic Algorithm for Multi-Objective Reconfiguration of Balanced and Unbalanced Distribution Systems in Fuzzy Framework**

## Overview

The project consists of the following modules:

- **Chromosome.cs**: Defines the representation of a candidate solution (chromosome) that encodes the network configuration, distributed generation (DG) locations, and sizes.
- **FuzzyMembership.cs**: Implements fuzzy membership functions to fuzzify the objective functions (e.g., power loss minimization, voltage deviation, load balancing) into a normalized range.
- **GAReconfiguration.cs**: Contains the main genetic algorithm loop. It handles population initialization, evaluation (using fuzzy satisfaction), selection, crossover, and mutation.
- **GeneticOperators.cs**: Provides implementations for genetic operators such as selection, crossover, and mutation.
- **NetworkModel.cs**: Simulates the electrical network model and calculates objective values (e.g., power loss, voltage deviation) for a given configuration.
- **Program.cs**: The entry point that sets up the problem, runs the genetic algorithm, and outputs the optimal network configuration.

## Repository Structure

